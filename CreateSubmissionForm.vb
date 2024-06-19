Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private WithEvents timer As New Timer()

    Public Sub New()
        InitializeComponent()

        ' Set Timer interval to 1 second
        timer.Interval = 1000

        ' Set size of the label programmatically
        lblStopwatch.AutoSize = False
        lblStopwatch.Width = 200  ' Set your desired width
        lblStopwatch.Height = 50  ' Set your desired height
    End Sub

    ' Event handler for Toggle Stopwatch button click
    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop()
        Else
            stopwatch.Start()
            timer.Start()
        End If
        UpdateStopwatchLabel()
    End Sub

    ' Event handler for Timer tick
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        UpdateStopwatchLabel()
    End Sub

    ' Update the stopwatch label with the elapsed time
    Private Sub UpdateStopwatchLabel()
        lblStopwatch.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub

    ' Event handler for Submit button click
    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim githubLink As String = txtGithubLink.Text
        Dim stopwatchTime As String = lblStopwatch.Text

        ' Make the API call to submit the form data
        Dim result As String = Await SubmitForm(name, email, phone, githubLink, stopwatchTime)
        MessageBox.Show(result)
    End Sub

    ' Function to submit form data to the backend
    Private Async Function SubmitForm(name As String, email As String, phone As String, githubLink As String, stopwatchTime As String) As Task(Of String)
        Using client As New HttpClient()
            Dim formData As New Dictionary(Of String, String) From {
                {"name", name},
                {"email", email},
                {"phone", phone},
                {"github_link", githubLink},
                {"stopwatch_time", stopwatchTime}
            }

            Dim json As String = JsonConvert.SerializeObject(formData)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)

            If response.IsSuccessStatusCode Then
                Return "Submission Successful"
            Else
                Return "Submission Failed: " & response.ReasonPhrase
            End If
        End Using
    End Function

    ' Override ProcessCmdKey to handle keyboard shortcuts
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.S) Then
            ' Ctrl + S to submit the form
            btnSubmit.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.T) Then
            ' Ctrl + T to toggle the stopwatch
            btnToggleStopwatch.PerformClick()
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class
