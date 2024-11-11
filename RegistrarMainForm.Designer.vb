<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarMainForm
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
        Panel = New Panel()
        SubjectButton = New Button()
        StudentButton = New Button()
        StaffButton = New Button()
        TeacherButton = New Button()
        ClassButton = New Button()
        DashboardButton = New Button()
        SignOutBtn = New Button()
        RegistrationButton = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(43, 175)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 28)
        Label1.TabIndex = 0
        Label1.Text = "Welcome, Registrar"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel
        ' 
        Panel.BackColor = Color.Teal
        Panel.Controls.Add(SubjectButton)
        Panel.Controls.Add(StudentButton)
        Panel.Controls.Add(StaffButton)
        Panel.Controls.Add(TeacherButton)
        Panel.Controls.Add(ClassButton)
        Panel.Controls.Add(DashboardButton)
        Panel.Controls.Add(SignOutBtn)
        Panel.Controls.Add(RegistrationButton)
        Panel.Controls.Add(PictureBox1)
        Panel.Controls.Add(Label1)
        Panel.Dock = DockStyle.Left
        Panel.Location = New Point(0, 0)
        Panel.Name = "Panel"
        Panel.Size = New Size(270, 853)
        Panel.TabIndex = 1
        ' 
        ' SubjectButton
        ' 
        SubjectButton.BackColor = Color.PaleTurquoise
        SubjectButton.FlatStyle = FlatStyle.Flat
        SubjectButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SubjectButton.ForeColor = Color.Black
        SubjectButton.Location = New Point(43, 458)
        SubjectButton.Name = "SubjectButton"
        SubjectButton.Size = New Size(186, 40)
        SubjectButton.TabIndex = 10
        SubjectButton.Text = "SUBJECT"
        SubjectButton.UseVisualStyleBackColor = False
        ' 
        ' StudentButton
        ' 
        StudentButton.BackColor = Color.PaleTurquoise
        StudentButton.FlatStyle = FlatStyle.Flat
        StudentButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StudentButton.ForeColor = Color.Black
        StudentButton.Location = New Point(43, 367)
        StudentButton.Name = "StudentButton"
        StudentButton.Size = New Size(186, 40)
        StudentButton.TabIndex = 3
        StudentButton.Text = "STUDENT"
        StudentButton.UseVisualStyleBackColor = False
        ' 
        ' StaffButton
        ' 
        StaffButton.BackColor = Color.PaleTurquoise
        StaffButton.FlatStyle = FlatStyle.Flat
        StaffButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StaffButton.ForeColor = Color.Black
        StaffButton.Location = New Point(43, 275)
        StaffButton.Name = "StaffButton"
        StaffButton.Size = New Size(186, 40)
        StaffButton.TabIndex = 9
        StaffButton.Text = "STAFF"
        StaffButton.UseVisualStyleBackColor = False
        ' 
        ' TeacherButton
        ' 
        TeacherButton.BackColor = Color.PaleTurquoise
        TeacherButton.FlatStyle = FlatStyle.Flat
        TeacherButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TeacherButton.ForeColor = Color.Black
        TeacherButton.Location = New Point(43, 413)
        TeacherButton.Name = "TeacherButton"
        TeacherButton.Size = New Size(186, 40)
        TeacherButton.TabIndex = 4
        TeacherButton.Text = "TEACHER"
        TeacherButton.UseVisualStyleBackColor = False
        ' 
        ' ClassButton
        ' 
        ClassButton.BackColor = Color.PaleTurquoise
        ClassButton.FlatStyle = FlatStyle.Flat
        ClassButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ClassButton.ForeColor = Color.Black
        ClassButton.Location = New Point(43, 321)
        ClassButton.Name = "ClassButton"
        ClassButton.Size = New Size(186, 40)
        ClassButton.TabIndex = 2
        ClassButton.Text = "CLASS"
        ClassButton.UseVisualStyleBackColor = False
        ' 
        ' DashboardButton
        ' 
        DashboardButton.BackColor = Color.PaleTurquoise
        DashboardButton.FlatStyle = FlatStyle.Flat
        DashboardButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DashboardButton.ForeColor = Color.Black
        DashboardButton.Location = New Point(43, 228)
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
        SignOutBtn.Location = New Point(78, 641)
        SignOutBtn.Name = "SignOutBtn"
        SignOutBtn.Size = New Size(113, 51)
        SignOutBtn.TabIndex = 7
        SignOutBtn.Text = "Log Out"
        SignOutBtn.TextAlign = ContentAlignment.MiddleRight
        SignOutBtn.UseVisualStyleBackColor = True
        ' 
        ' RegistrationButton
        ' 
        RegistrationButton.BackColor = Color.PaleTurquoise
        RegistrationButton.FlatStyle = FlatStyle.Flat
        RegistrationButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RegistrationButton.ForeColor = Color.Black
        RegistrationButton.Location = New Point(43, 504)
        RegistrationButton.Name = "RegistrationButton"
        RegistrationButton.Size = New Size(186, 40)
        RegistrationButton.TabIndex = 5
        RegistrationButton.Text = "REGISTRATION"
        RegistrationButton.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.settings
        PictureBox1.Location = New Point(69, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(135, 135)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDarkDark
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(270, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1112, 853)
        Panel2.TabIndex = 2
        ' 
        ' RegistrarMainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1382, 853)
        Controls.Add(Panel2)
        Controls.Add(Panel)
        Name = "RegistrarMainForm"
        Text = "Registrar Dashboard"
        Panel.ResumeLayout(False)
        Panel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel As Panel
    Friend WithEvents ClassButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TeacherButton As Button
    Friend WithEvents StudentButton As Button
    Friend WithEvents RegistrationButton As Button
    Friend WithEvents ShowPasswordBtn As Button
    Friend WithEvents SignOutBtn As Button
    Friend WithEvents DashboardButton As Button
    Friend WithEvents StaffButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SubjectButton As Button
End Class
