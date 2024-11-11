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
        Button5 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button1 = New Button()
        DashboardButton = New Button()
        SignOutBtn = New Button()
        Button4 = New Button()
        ProfilePictureBox = New PictureBox()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(ProfilePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' StaffNameLabel
        ' 
        StaffNameLabel.AutoSize = True
        StaffNameLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
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
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(DashboardButton)
        Panel1.Controls.Add(SignOutBtn)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(ProfilePictureBox)
        Panel1.Controls.Add(StaffNameLabel)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(270, 753)
        Panel1.TabIndex = 3
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.RoyalBlue
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Button5.ForeColor = Color.White
        Button5.Location = New Point(44, 458)
        Button5.Name = "Button5"
        Button5.Size = New Size(186, 40)
        Button5.TabIndex = 9
        Button5.Text = "USER"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.RoyalBlue
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(44, 366)
        Button2.Name = "Button2"
        Button2.Size = New Size(186, 40)
        Button2.TabIndex = 3
        Button2.Text = "STUDENT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.RoyalBlue
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(44, 274)
        Button3.Name = "Button3"
        Button3.Size = New Size(186, 40)
        Button3.TabIndex = 4
        Button3.Text = "TEACHER"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.RoyalBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(44, 320)
        Button1.Name = "Button1"
        Button1.Size = New Size(186, 40)
        Button1.TabIndex = 2
        Button1.Text = "CLASS"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DashboardButton
        ' 
        DashboardButton.BackColor = Color.RoyalBlue
        DashboardButton.FlatStyle = FlatStyle.Flat
        DashboardButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
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
        SignOutBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0)
        SignOutBtn.ForeColor = Color.Black
        SignOutBtn.Image = My.Resources.Resources.logout_2_
        SignOutBtn.ImageAlign = ContentAlignment.MiddleLeft
        SignOutBtn.Location = New Point(78, 561)
        SignOutBtn.Name = "SignOutBtn"
        SignOutBtn.Size = New Size(113, 50)
        SignOutBtn.TabIndex = 7
        SignOutBtn.Text = "Log Out"
        SignOutBtn.TextAlign = ContentAlignment.MiddleRight
        SignOutBtn.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.RoyalBlue
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(44, 412)
        Button4.Name = "Button4"
        Button4.Size = New Size(186, 40)
        Button4.TabIndex = 5
        Button4.Text = "REGISTRATION"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' ProfilePictureBox
        ' 
        ProfilePictureBox.BorderStyle = BorderStyle.Fixed3D
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
        Panel2.Size = New Size(1282, 753)
        Panel2.TabIndex = 4
        ' 
        ' StaffMainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1282, 753)
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DashboardButton As Button
    Friend WithEvents SignOutBtn As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ProfilePictureBox As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
End Class
