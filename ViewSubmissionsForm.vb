Imports System.Net.Http
Imports System.Text ' Ensure System.Text is imported for Encoding
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private submissions As List(Of Dictionary(Of String, String))
    Private currentIndex As Integer = 0

    Public Sub New()
        InitializeComponent()
        LoadSubmissions()
    End Sub

    ' Load submissions from the backend
    Private Async Sub LoadSubmissions()
        Try
            Using client As New HttpClient()
                Dim url As String = "http://localhost:3000/read"
                If currentIndex >= 0 Then
                    url &= $"?index={currentIndex}"
                End If

                Dim response As HttpResponseMessage = Await client.GetAsync(url)
                If response.IsSuccessStatusCode Then
                    Dim json As String = Await response.Content.ReadAsStringAsync()

                    ' Deserialize JSON to Dictionary(Of String, String)
                    submissions = New List(Of Dictionary(Of String, String))()
                    Dim submission As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(json)
                    submissions.Add(submission)

                    DisplaySubmission()
                Else
                    MessageBox.Show($"Failed to load submissions. Status code: {response.StatusCode}")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading submissions: {ex.Message}")
        End Try
    End Sub

    ' Display the current submission
    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(0) ' Since we are fetching one submission at a time
            txtName.Text = submission("name")
            txtEmail.Text = submission("email")
            txtPhone.Text = submission("phone")
            txtGithubLink.Text = submission("github_link")
            txtStopwatchTime.Text = submission("stopwatch_time")

            ' Set text boxes to read-only by default
            txtName.ReadOnly = True
            txtEmail.ReadOnly = True
            txtPhone.ReadOnly = True
            txtGithubLink.ReadOnly = True
            txtStopwatchTime.ReadOnly = True

            btnSave.Visible = False
            btnEdit.Visible = True
        End If
    End Sub

    ' Navigate to the previous submission
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmissions()
        End If
    End Sub

    ' Navigate to the next submission
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        LoadSubmissions()
    End Sub

    ' Delete the current submission
    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Try
                Using client As New HttpClient()
                    Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/delete?index={currentIndex}")

                    If response.IsSuccessStatusCode Then
                        MessageBox.Show("Submission deleted")
                        LoadSubmissions()
                    Else
                        MessageBox.Show("Failed to delete submission")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error deleting submission: {ex.Message}")
            End Try
        End If
    End Sub

    ' Edit the current submission
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            txtName.ReadOnly = False
            txtEmail.ReadOnly = False
            txtPhone.ReadOnly = False
            txtGithubLink.ReadOnly = False
            txtStopwatchTime.ReadOnly = False

            btnSave.Visible = True
            btnEdit.Visible = False
        Catch ex As Exception
            MessageBox.Show($"Error in btnEdit_Click: {ex.Message}")
        End Try
    End Sub

    ' Save the edited submission
    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Try
                Dim updatedSubmission As New Dictionary(Of String, String) From {
                    {"index", currentIndex.ToString()},
                    {"name", txtName.Text},
                    {"email", txtEmail.Text},
                    {"phone", txtPhone.Text},
                    {"github_link", txtGithubLink.Text},
                    {"stopwatch_time", txtStopwatchTime.Text}
                }

                Using client As New HttpClient()
                    Dim json As String = JsonConvert.SerializeObject(updatedSubmission)
                    Dim content As New StringContent(json, Encoding.UTF8, "application/json")
                    Dim response As HttpResponseMessage = Await client.PutAsync("http://localhost:3000/edit", content)

                    If response.IsSuccessStatusCode Then
                        MessageBox.Show("Submission updated")
                        txtName.ReadOnly = True
                        txtEmail.ReadOnly = True
                        txtPhone.ReadOnly = True
                        txtGithubLink.ReadOnly = True
                        txtStopwatchTime.ReadOnly = True
                        btnSave.Visible = False
                        btnEdit.Visible = True
                    Else
                        MessageBox.Show("Failed to update submission")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error updating submission: {ex.Message}")
            End Try
        End If
    End Sub
End Class
