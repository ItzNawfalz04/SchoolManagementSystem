﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Title = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        Label1 = New Label()
        UsernameTextBox = New TextBox()
        Label2 = New Label()
        PasswordTextBox = New TextBox()
        LoginBtn = New Button()
        InsLabel = New Label()
        ShowPasswordBtn = New Button()
        LinkLabel1 = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Control
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(48, 140)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(250, 258)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(34, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(275, 25)
        Label3.TabIndex = 2
        Label3.Text = "~Cempaka International School~"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.BackColor = Color.Transparent
        Title.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Title.ForeColor = Color.White
        Title.Location = New Point(33, 23)
        Title.Name = "Title"
        Title.Size = New Size(276, 62)
        Title.TabIndex = 1
        Title.Text = "SCHOOL MANAGEMENT" & vbCrLf & "SYSTEM"
        Title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Teal
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Title)
        Panel2.Controls.Add(Label3)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(347, 434)
        Panel2.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(375, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(206, 38)
        Label4.TabIndex = 8
        Label4.Text = "Login Account"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(375, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 25)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.BackColor = Color.White
        UsernameTextBox.BorderStyle = BorderStyle.FixedSingle
        UsernameTextBox.Cursor = Cursors.IBeam
        UsernameTextBox.Font = New Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UsernameTextBox.Location = New Point(375, 113)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(285, 29)
        UsernameTextBox.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(375, 169)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 2
        Label2.Text = "Password:"
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.AccessibleRole = AccessibleRole.MenuBar
        PasswordTextBox.AllowDrop = True
        PasswordTextBox.BackColor = Color.White
        PasswordTextBox.BorderStyle = BorderStyle.FixedSingle
        PasswordTextBox.Cursor = Cursors.IBeam
        PasswordTextBox.Font = New Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordTextBox.Location = New Point(375, 198)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "•"c
        PasswordTextBox.Size = New Size(285, 29)
        PasswordTextBox.TabIndex = 3
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = Color.Teal
        LoginBtn.Cursor = Cursors.Hand
        LoginBtn.FlatStyle = FlatStyle.Flat
        LoginBtn.ForeColor = SystemColors.ControlLightLight
        LoginBtn.Location = New Point(375, 295)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(100, 40)
        LoginBtn.TabIndex = 4
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' InsLabel
        ' 
        InsLabel.AutoSize = True
        InsLabel.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        InsLabel.Location = New Point(375, 244)
        InsLabel.Name = "InsLabel"
        InsLabel.Size = New Size(277, 20)
        InsLabel.TabIndex = 5
        InsLabel.Text = "Instruction: Enter username and password."
        ' 
        ' ShowPasswordBtn
        ' 
        ShowPasswordBtn.Cursor = Cursors.Hand
        ShowPasswordBtn.Image = My.Resources.Resources.eye_1_
        ShowPasswordBtn.Location = New Point(666, 198)
        ShowPasswordBtn.Name = "ShowPasswordBtn"
        ShowPasswordBtn.Size = New Size(33, 29)
        ShowPasswordBtn.TabIndex = 6
        ShowPasswordBtn.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(559, 305)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(101, 20)
        LinkLabel1.TabIndex = 9
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "About System"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(735, 434)
        Controls.Add(LinkLabel1)
        Controls.Add(ShowPasswordBtn)
        Controls.Add(Label4)
        Controls.Add(InsLabel)
        Controls.Add(LoginBtn)
        Controls.Add(Panel2)
        Controls.Add(PasswordTextBox)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(UsernameTextBox)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "LoginForm"
        Text = "Login Account"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Title As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents InsLabel As Label
    Friend WithEvents ShowPasswordBtn As Button
    Friend WithEvents LinkLabel1 As LinkLabel

End Class
