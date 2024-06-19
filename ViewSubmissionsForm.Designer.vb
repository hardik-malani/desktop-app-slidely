<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        btnSave = New Button()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        lblGithubLink = New Label()
        lblPhone = New Label()
        lblEmail = New Label()
        lblName = New Label()
        Label1 = New Label()
        lblStopwatchTime = New Label()
        txtStopwatchTime = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.LightBlue
        btnSave.Location = New Point(240, 400)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(329, 38)
        btnSave.TabIndex = 22
        btnSave.Text = "SAVE (CTRL + S )"
        btnSave.TextImageRelation = TextImageRelation.ImageAboveText
        btnSave.UseVisualStyleBackColor = False
        btnSave.Visible = False
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(346, 184)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(301, 27)
        txtPhone.TabIndex = 20
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(346, 217)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(301, 27)
        txtGithubLink.TabIndex = 19
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(346, 146)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(301, 27)
        txtEmail.TabIndex = 18
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(346, 109)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(301, 27)
        txtName.TabIndex = 17
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(67, 211)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(79, 40)
        lblGithubLink.TabIndex = 16
        lblGithubLink.Text = "GithubLink" & vbCrLf & "Task 2"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(67, 187)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(86, 20)
        lblPhone.TabIndex = 15
        lblPhone.Text = "Phone Num"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(67, 153)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 14
        lblEmail.Text = "Email"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(67, 116)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 13
        lblName.Text = "Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(177, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(418, 25)
        Label1.TabIndex = 12
        Label1.Text = "Hardik Malani - Slidely Task 2 - View Submission"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(67, 260)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(114, 20)
        lblStopwatchTime.TabIndex = 23
        lblStopwatchTime.Text = "StopWatchTime"
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(346, 257)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(301, 27)
        txtStopwatchTime.TabIndex = 24
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.LightCyan
        btnPrevious.Location = New Point(12, 356)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(329, 38)
        btnPrevious.TabIndex = 25
        btnPrevious.Text = "PREVIOUS (CTRL + P )"
        btnPrevious.TextImageRelation = TextImageRelation.ImageAboveText
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.LightYellow
        btnNext.Location = New Point(459, 356)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(329, 38)
        btnNext.TabIndex = 26
        btnNext.Text = "NEXT (CTRL + N )"
        btnNext.TextImageRelation = TextImageRelation.ImageAboveText
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.MediumAquamarine
        btnEdit.Location = New Point(12, 12)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(129, 33)
        btnEdit.TabIndex = 27
        btnEdit.Text = "EDIT (CTRL + E )"
        btnEdit.TextImageRelation = TextImageRelation.ImageAboveText
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.LightPink
        btnDelete.Location = New Point(647, 12)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(141, 33)
        btnDelete.TabIndex = 28
        btnDelete.Text = "DELETE (CTRL + D )"
        btnDelete.TextImageRelation = TextImageRelation.ImageAboveText
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtStopwatchTime)
        Controls.Add(lblStopwatchTime)
        Controls.Add(btnSave)
        Controls.Add(txtPhone)
        Controls.Add(txtGithubLink)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(Label1)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
End Class
