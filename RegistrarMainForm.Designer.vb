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
        StaffButton = New Button()
        Button2 = New Button()
        TeacherButton = New Button()
        Button1 = New Button()
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
        Label1.Location = New Point(38, 131)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 21)
        Label1.TabIndex = 0
        Label1.Text = "Welcome, Registrar"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(StaffButton)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(TeacherButton)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(DashboardButton)
        Panel1.Controls.Add(SignOutBtn)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(236, 527)
        Panel1.TabIndex = 1
        ' 
        ' StaffButton
        ' 
        StaffButton.BackColor = Color.Teal
        StaffButton.FlatStyle = FlatStyle.Flat
        StaffButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StaffButton.ForeColor = Color.White
        StaffButton.Location = New Point(38, 206)
        StaffButton.Margin = New Padding(3, 2, 3, 2)
        StaffButton.Name = "StaffButton"
        StaffButton.Size = New Size(163, 30)
        StaffButton.TabIndex = 9
        StaffButton.Text = "STAFF"
        StaffButton.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Teal
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(38, 309)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(163, 30)
        Button2.TabIndex = 3
        Button2.Text = "STUDENT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TeacherButton
        ' 
        TeacherButton.BackColor = Color.Teal
        TeacherButton.FlatStyle = FlatStyle.Flat
        TeacherButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TeacherButton.ForeColor = Color.White
        TeacherButton.Location = New Point(38, 240)
        TeacherButton.Margin = New Padding(3, 2, 3, 2)
        TeacherButton.Name = "TeacherButton"
        TeacherButton.Size = New Size(163, 30)
        TeacherButton.TabIndex = 4
        TeacherButton.Text = "TEACHER"
        TeacherButton.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Teal
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(38, 274)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 30)
        Button1.TabIndex = 2
        Button1.Text = "CLASS"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DashboardButton
        ' 
        DashboardButton.BackColor = Color.Teal
        DashboardButton.FlatStyle = FlatStyle.Flat
        DashboardButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DashboardButton.ForeColor = Color.White
        DashboardButton.Location = New Point(38, 171)
        DashboardButton.Margin = New Padding(3, 2, 3, 2)
        DashboardButton.Name = "DashboardButton"
        DashboardButton.Size = New Size(163, 30)
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
        SignOutBtn.Location = New Point(68, 481)
        SignOutBtn.Margin = New Padding(3, 2, 3, 2)
        SignOutBtn.Name = "SignOutBtn"
        SignOutBtn.Size = New Size(99, 38)
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
        Button4.Location = New Point(38, 344)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(163, 30)
        Button4.TabIndex = 5
        Button4.Text = "REGISTRATION"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.settings
        PictureBox1.Location = New Point(60, 26)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(118, 101)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDarkDark
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(236, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(711, 527)
        Panel2.TabIndex = 2
        ' 
        ' RegistrarMainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(947, 527)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 2, 3, 2)
        Name = "RegistrarMainForm"
        Text = "Registrar Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TeacherButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ShowPasswordBtn As Button
    Friend WithEvents SignOutBtn As Button
    Friend WithEvents DashboardButton As Button
    Friend WithEvents StaffButton As Button
    Friend WithEvents Panel2 As Panel
End Class
