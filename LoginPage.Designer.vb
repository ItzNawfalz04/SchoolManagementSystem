<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Title = New Label()
        GroupBox1 = New GroupBox()
        PictureBox1 = New PictureBox()
        ShowPasswordBtn = New Button()
        InsLabel = New Label()
        LoginBtn = New Button()
        PasswordTextBox = New TextBox()
        Label2 = New Label()
        UsernameTextBox = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Title)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(882, 95)
        Panel1.TabIndex = 0
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Title.ForeColor = Color.White
        Title.Location = New Point(12, 9)
        Title.Name = "Title"
        Title.Size = New Size(454, 38)
        Title.TabIndex = 1
        Title.Text = "SCHOOL MANAGEMENT SYSTEM"
        Title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Control
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(ShowPasswordBtn)
        GroupBox1.Controls.Add(InsLabel)
        GroupBox1.Controls.Add(LoginBtn)
        GroupBox1.Controls.Add(PasswordTextBox)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(UsernameTextBox)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ControlText
        GroupBox1.Location = New Point(0, 95)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(882, 358)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Login"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlLightLight
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(515, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(325, 250)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' ShowPasswordBtn
        ' 
        ShowPasswordBtn.Cursor = Cursors.Hand
        ShowPasswordBtn.Image = My.Resources.Resources.eye_1_
        ShowPasswordBtn.Location = New Point(421, 117)
        ShowPasswordBtn.Name = "ShowPasswordBtn"
        ShowPasswordBtn.Size = New Size(33, 28)
        ShowPasswordBtn.TabIndex = 6
        ShowPasswordBtn.UseVisualStyleBackColor = True
        ' 
        ' InsLabel
        ' 
        InsLabel.AutoSize = True
        InsLabel.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        InsLabel.Location = New Point(40, 174)
        InsLabel.Name = "InsLabel"
        InsLabel.Size = New Size(277, 20)
        InsLabel.TabIndex = 5
        InsLabel.Text = "Instruction: Enter username and password."
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = Color.Teal
        LoginBtn.Cursor = Cursors.Hand
        LoginBtn.FlatStyle = FlatStyle.Flat
        LoginBtn.ForeColor = SystemColors.ControlLightLight
        LoginBtn.Location = New Point(315, 226)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(100, 40)
        LoginBtn.TabIndex = 4
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.BackColor = Color.White
        PasswordTextBox.BorderStyle = BorderStyle.FixedSingle
        PasswordTextBox.Location = New Point(149, 117)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "•"c
        PasswordTextBox.Size = New Size(266, 27)
        PasswordTextBox.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(46, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 28)
        Label2.TabIndex = 2
        Label2.Text = "Password:"
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.BackColor = Color.White
        UsernameTextBox.BorderStyle = BorderStyle.FixedSingle
        UsernameTextBox.Location = New Point(149, 57)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(266, 27)
        UsernameTextBox.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(40, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 28)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(12, 47)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 28)
        Label3.TabIndex = 2
        Label3.Text = "School Name"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 453)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Name = "LoginForm"
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Title As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents InsLabel As Label
    Friend WithEvents ShowPasswordBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label

End Class
