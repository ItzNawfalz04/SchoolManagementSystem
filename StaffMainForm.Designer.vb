<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffMainForm
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
        StaffNameLabel = New Label()
        Panel1 = New Panel()
        SubjectButton = New Button()
        UserButton = New Button()
        StudentButton = New Button()
        TeacherButton = New Button()
        ClassButton = New Button()
        DashboardButton = New Button()
        SignOutBtn = New Button()
        RegistrationButton = New Button()
        ProfilePictureBox = New PictureBox()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(ProfilePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' StaffNameLabel
        ' 
        StaffNameLabel.AutoSize = True
        StaffNameLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StaffNameLabel.ForeColor = SystemColors.ControlLightLight
        StaffNameLabel.Location = New Point(61, 175)
        StaffNameLabel.Name = "StaffNameLabel"
        StaffNameLabel.Size = New Size(148, 28)
        StaffNameLabel.TabIndex = 0
        StaffNameLabel.Text = "Welcome, Staff"
        StaffNameLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(SubjectButton)
        Panel1.Controls.Add(UserButton)
        Panel1.Controls.Add(StudentButton)
        Panel1.Controls.Add(TeacherButton)
        Panel1.Controls.Add(ClassButton)
        Panel1.Controls.Add(DashboardButton)
        Panel1.Controls.Add(SignOutBtn)
        Panel1.Controls.Add(RegistrationButton)
        Panel1.Controls.Add(ProfilePictureBox)
        Panel1.Controls.Add(StaffNameLabel)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(270, 853)
        Panel1.TabIndex = 3
        ' 
        ' SubjectButton
        ' 
        SubjectButton.BackColor = Color.RoyalBlue
        SubjectButton.FlatStyle = FlatStyle.Flat
        SubjectButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SubjectButton.ForeColor = Color.White
        SubjectButton.Location = New Point(44, 412)
        SubjectButton.Name = "SubjectButton"
        SubjectButton.Size = New Size(186, 40)
        SubjectButton.TabIndex = 10
        SubjectButton.Text = "SUBJECT"
        SubjectButton.UseVisualStyleBackColor = False
        ' 
        ' UserButton
        ' 
        UserButton.BackColor = Color.RoyalBlue
        UserButton.FlatStyle = FlatStyle.Flat
        UserButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UserButton.ForeColor = Color.White
        UserButton.Location = New Point(44, 504)
        UserButton.Name = "UserButton"
        UserButton.Size = New Size(186, 40)
        UserButton.TabIndex = 9
        UserButton.Text = "USER"
        UserButton.UseVisualStyleBackColor = False
        ' 
        ' StudentButton
        ' 
        StudentButton.BackColor = Color.RoyalBlue
        StudentButton.FlatStyle = FlatStyle.Flat
        StudentButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StudentButton.ForeColor = Color.White
        StudentButton.Location = New Point(44, 320)
        StudentButton.Name = "StudentButton"
        StudentButton.Size = New Size(186, 40)
        StudentButton.TabIndex = 3
        StudentButton.Text = "STUDENT"
        StudentButton.UseVisualStyleBackColor = False
        ' 
        ' TeacherButton
        ' 
        TeacherButton.BackColor = Color.RoyalBlue
        TeacherButton.FlatStyle = FlatStyle.Flat
        TeacherButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TeacherButton.ForeColor = Color.White
        TeacherButton.Location = New Point(44, 366)
        TeacherButton.Name = "TeacherButton"
        TeacherButton.Size = New Size(186, 40)
        TeacherButton.TabIndex = 4
        TeacherButton.Text = "TEACHER"
        TeacherButton.UseVisualStyleBackColor = False
        ' 
        ' ClassButton
        ' 
        ClassButton.BackColor = Color.RoyalBlue
        ClassButton.FlatStyle = FlatStyle.Flat
        ClassButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ClassButton.ForeColor = Color.White
        ClassButton.Location = New Point(44, 274)
        ClassButton.Name = "ClassButton"
        ClassButton.Size = New Size(186, 40)
        ClassButton.TabIndex = 2
        ClassButton.Text = "CLASS"
        ClassButton.UseVisualStyleBackColor = False
        ' 
        ' DashboardButton
        ' 
        DashboardButton.BackColor = Color.RoyalBlue
        DashboardButton.FlatStyle = FlatStyle.Flat
        DashboardButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DashboardButton.ForeColor = Color.White
        DashboardButton.Location = New Point(44, 228)
        DashboardButton.Name = "DashboardButton"
        DashboardButton.Size = New Size(186, 40)
        DashboardButton.TabIndex = 8
        DashboardButton.Text = "DASHBOARD"
        DashboardButton.UseVisualStyleBackColor = False
        ' 
        ' SignOutBtn
        ' 
        SignOutBtn.Cursor = Cursors.Hand
        SignOutBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignOutBtn.ForeColor = Color.Black
        SignOutBtn.Image = My.Resources.Resources.logout_2_
        SignOutBtn.ImageAlign = ContentAlignment.MiddleLeft
        SignOutBtn.Location = New Point(68, 632)
        SignOutBtn.Name = "SignOutBtn"
        SignOutBtn.Size = New Size(113, 50)
        SignOutBtn.TabIndex = 7
        SignOutBtn.Text = "Log Out"
        SignOutBtn.TextAlign = ContentAlignment.MiddleRight
        SignOutBtn.UseVisualStyleBackColor = True
        ' 
        ' RegistrationButton
        ' 
        RegistrationButton.BackColor = Color.RoyalBlue
        RegistrationButton.FlatStyle = FlatStyle.Flat
        RegistrationButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RegistrationButton.ForeColor = Color.White
        RegistrationButton.Location = New Point(44, 458)
        RegistrationButton.Name = "RegistrationButton"
        RegistrationButton.Size = New Size(186, 40)
        RegistrationButton.TabIndex = 5
        RegistrationButton.Text = "REGISTRATION"
        RegistrationButton.UseVisualStyleBackColor = False
        ' 
        ' ProfilePictureBox
        ' 
        ProfilePictureBox.BackColor = Color.Transparent
        ProfilePictureBox.ErrorImage = Nothing
        ProfilePictureBox.Image = My.Resources.Resources.logo
        ProfilePictureBox.Location = New Point(68, 35)
        ProfilePictureBox.Name = "ProfilePictureBox"
        ProfilePictureBox.Size = New Size(135, 135)
        ProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        ProfilePictureBox.TabIndex = 1
        ProfilePictureBox.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDarkDark
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1382, 853)
        Panel2.TabIndex = 4
        ' 
        ' StaffMainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1382, 853)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "StaffMainForm"
        Text = "StaffMainForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(ProfilePictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents StaffNameLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StudentButton As Button
    Friend WithEvents TeacherButton As Button
    Friend WithEvents ClassButton As Button
    Friend WithEvents DashboardButton As Button
    Friend WithEvents SignOutBtn As Button
    Friend WithEvents RegistrationButton As Button
    Friend WithEvents ProfilePictureBox As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UserButton As Button
    Friend WithEvents SubjectButton As Button
End Class
