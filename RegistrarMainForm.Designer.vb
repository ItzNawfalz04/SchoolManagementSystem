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
        Panel1 = New Panel()
        SubjectButton = New Button()
        StudentButton = New Button()
        StaffButton = New Button()
        TeacherButton = New Button()
        ClassButton = New Button()
        DashboardButton = New Button()
        SignOutBtn = New Button()
        Button4 = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
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
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(SubjectButton)
        Panel1.Controls.Add(StudentButton)
        Panel1.Controls.Add(StaffButton)
        Panel1.Controls.Add(TeacherButton)
        Panel1.Controls.Add(ClassButton)
        Panel1.Controls.Add(DashboardButton)
        Panel1.Controls.Add(SignOutBtn)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(270, 703)
        Panel1.TabIndex = 1
        ' 
        ' SubjectButton
        ' 
        SubjectButton.BackColor = Color.Teal
        SubjectButton.FlatStyle = FlatStyle.Flat
        SubjectButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SubjectButton.ForeColor = Color.White
        SubjectButton.Location = New Point(43, 458)
        SubjectButton.Name = "SubjectButton"
        SubjectButton.Size = New Size(186, 40)
        SubjectButton.TabIndex = 10
        SubjectButton.Text = "SUBJECT"
        SubjectButton.UseVisualStyleBackColor = False
        ' 
        ' StudentButton
        ' 
        StudentButton.BackColor = Color.Teal
        StudentButton.FlatStyle = FlatStyle.Flat
        StudentButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StudentButton.ForeColor = Color.White
        StudentButton.Location = New Point(43, 367)
        StudentButton.Name = "StudentButton"
        StudentButton.Size = New Size(186, 40)
        StudentButton.TabIndex = 3
        StudentButton.Text = "STUDENT"
        StudentButton.UseVisualStyleBackColor = False
        ' 
        ' StaffButton
        ' 
        StaffButton.BackColor = Color.Teal
        StaffButton.FlatStyle = FlatStyle.Flat
        StaffButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StaffButton.ForeColor = Color.White
        StaffButton.Location = New Point(43, 275)
        StaffButton.Name = "StaffButton"
        StaffButton.Size = New Size(186, 40)
        StaffButton.TabIndex = 9
        StaffButton.Text = "STAFF"
        StaffButton.UseVisualStyleBackColor = False
        ' 
        ' TeacherButton
        ' 
        TeacherButton.BackColor = Color.Teal
        TeacherButton.FlatStyle = FlatStyle.Flat
        TeacherButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TeacherButton.ForeColor = Color.White
        TeacherButton.Location = New Point(43, 413)
        TeacherButton.Name = "TeacherButton"
        TeacherButton.Size = New Size(186, 40)
        TeacherButton.TabIndex = 4
        TeacherButton.Text = "TEACHER"
        TeacherButton.UseVisualStyleBackColor = False
        ' 
        ' ClassButton
        ' 
        ClassButton.BackColor = Color.Teal
        ClassButton.FlatStyle = FlatStyle.Flat
        ClassButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ClassButton.ForeColor = Color.White
        ClassButton.Location = New Point(43, 321)
        ClassButton.Name = "ClassButton"
        ClassButton.Size = New Size(186, 40)
        ClassButton.TabIndex = 2
        ClassButton.Text = "CLASS"
        ClassButton.UseVisualStyleBackColor = False
        ' 
        ' DashboardButton
        ' 
        DashboardButton.BackColor = Color.Teal
        DashboardButton.FlatStyle = FlatStyle.Flat
        DashboardButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DashboardButton.ForeColor = Color.White
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
        ' Button4
        ' 
        Button4.BackColor = Color.Teal
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(43, 504)
        Button4.Name = "Button4"
        Button4.Size = New Size(186, 40)
        Button4.TabIndex = 5
        Button4.Text = "REGISTRATION"
        Button4.UseVisualStyleBackColor = False
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
        Panel2.Size = New Size(752, 703)
        Panel2.TabIndex = 2
        ' 
        ' RegistrarMainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1022, 703)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "RegistrarMainForm"
        Text = "Registrar Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ClassButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TeacherButton As Button
    Friend WithEvents StudentButton As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ShowPasswordBtn As Button
    Friend WithEvents SignOutBtn As Button
    Friend WithEvents DashboardButton As Button
    Friend WithEvents StaffButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SubjectButton As Button
End Class
