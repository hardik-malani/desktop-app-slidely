<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtGithubLink = New TextBox()
        txtPhone = New TextBox()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        lblStopwatch = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(88, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(339, 20)
        Label1.TabIndex = 0
        Label1.Text = "Hardik Malani - Slidely Task 2 - Create Submission"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(48, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(41, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 3
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(41, 199)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 40)
        Label5.TabIndex = 4
        Label5.Text = "GithubLink" & vbCrLf & "Task 2"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(205, 91)
        txtName.Name = "txtName"
        txtName.Size = New Size(301, 27)
        txtName.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(205, 128)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(301, 27)
        txtEmail.TabIndex = 6
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(205, 199)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(301, 27)
        txtGithubLink.TabIndex = 7
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(205, 162)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(301, 27)
        txtPhone.TabIndex = 8
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.Yellow
        btnToggleStopwatch.Location = New Point(12, 270)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(301, 35)
        btnToggleStopwatch.TabIndex = 9
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.LightBlue
        btnSubmit.Location = New Point(109, 334)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(329, 38)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "SUBMIT (CTRL + S )"
        btnSubmit.TextImageRelation = TextImageRelation.ImageAboveText
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(409, 277)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(63, 20)
        lblStopwatch.TabIndex = 11
        lblStopwatch.Text = "00:00:00"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(534, 394)
        Controls.Add(lblStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(txtPhone)
        Controls.Add(txtGithubLink)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblStopwatch As Label
End Class
