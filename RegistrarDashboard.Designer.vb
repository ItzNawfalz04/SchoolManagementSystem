﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarDashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Label4 = New Label()
        Panel1 = New Panel()
        Panel4 = New Panel()
        Label6 = New Label()
        Panel3 = New Panel()
        Label7 = New Label()
        Panel2 = New Panel()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        EditBtn = New Button()
        BackBtn = New Button()
        ShowPasswordBtn = New Button()
        PasswordTextBox = New TextBox()
        UsernameTextBox = New TextBox()
        NameTextBox = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        StudentNumber = New Label()
        TeacherNumber = New Label()
        StaffNumber = New Label()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(14, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(250, 28)
        Label4.TabIndex = 9
        Label4.Text = "REGISTRAR DASHBOARD"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(21, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(659, 231)
        Panel1.TabIndex = 10
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(TeacherNumber)
        Panel4.Controls.Add(Label6)
        Panel4.Location = New Point(232, 42)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(185, 171)
        Panel4.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Teal
        Label6.Location = New Point(93, 135)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 25)
        Label6.TabIndex = 4
        Label6.Text = "Teacher"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(StaffNumber)
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(453, 42)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(185, 171)
        Panel3.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Teal
        Label7.Location = New Point(120, 135)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 25)
        Label7.TabIndex = 5
        Label7.Text = "Staff"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(StudentNumber)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(14, 42)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(185, 171)
        Panel2.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Teal
        Label5.Location = New Point(93, 135)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 25)
        Label5.TabIndex = 3
        Label5.Text = "Student"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Control
        GroupBox1.Controls.Add(EditBtn)
        GroupBox1.Controls.Add(BackBtn)
        GroupBox1.Controls.Add(ShowPasswordBtn)
        GroupBox1.Controls.Add(PasswordTextBox)
        GroupBox1.Controls.Add(UsernameTextBox)
        GroupBox1.Controls.Add(NameTextBox)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(21, 273)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(659, 351)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "My Profile"
        ' 
        ' EditBtn
        ' 
        EditBtn.BackColor = Color.Teal
        EditBtn.Cursor = Cursors.Hand
        EditBtn.FlatStyle = FlatStyle.Flat
        EditBtn.ForeColor = SystemColors.ControlLightLight
        EditBtn.Location = New Point(38, 253)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(100, 40)
        EditBtn.TabIndex = 9
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = False
        ' 
        ' BackBtn
        ' 
        BackBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        BackBtn.Cursor = Cursors.Hand
        BackBtn.FlatStyle = FlatStyle.Flat
        BackBtn.ForeColor = SystemColors.ControlLightLight
        BackBtn.Location = New Point(144, 253)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(100, 40)
        BackBtn.TabIndex = 8
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = False
        ' 
        ' ShowPasswordBtn
        ' 
        ShowPasswordBtn.Cursor = Cursors.Hand
        ShowPasswordBtn.Image = My.Resources.Resources.eye_1_
        ShowPasswordBtn.Location = New Point(329, 208)
        ShowPasswordBtn.Name = "ShowPasswordBtn"
        ShowPasswordBtn.Size = New Size(33, 29)
        ShowPasswordBtn.TabIndex = 7
        ShowPasswordBtn.UseVisualStyleBackColor = True
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.BackColor = Color.White
        PasswordTextBox.BorderStyle = BorderStyle.FixedSingle
        PasswordTextBox.Cursor = Cursors.IBeam
        PasswordTextBox.Font = New Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PasswordTextBox.Location = New Point(38, 208)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "•"c
        PasswordTextBox.Size = New Size(285, 29)
        PasswordTextBox.TabIndex = 5
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.BackColor = Color.White
        UsernameTextBox.BorderStyle = BorderStyle.FixedSingle
        UsernameTextBox.Cursor = Cursors.IBeam
        UsernameTextBox.Font = New Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UsernameTextBox.Location = New Point(38, 136)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(285, 29)
        UsernameTextBox.TabIndex = 4
        ' 
        ' NameTextBox
        ' 
        NameTextBox.BackColor = Color.White
        NameTextBox.BorderStyle = BorderStyle.FixedSingle
        NameTextBox.Cursor = Cursors.IBeam
        NameTextBox.Font = New Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NameTextBox.Location = New Point(38, 65)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(285, 29)
        NameTextBox.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(38, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 25)
        Label3.TabIndex = 2
        Label3.Text = "Password:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(38, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 25)
        Label2.TabIndex = 1
        Label2.Text = "Username:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(38, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 25)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' StudentNumber
        ' 
        StudentNumber.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StudentNumber.ForeColor = Color.Black
        StudentNumber.Location = New Point(53, 33)
        StudentNumber.Name = "StudentNumber"
        StudentNumber.Size = New Size(79, 85)
        StudentNumber.TabIndex = 4
        StudentNumber.Text = "0"
        StudentNumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TeacherNumber
        ' 
        TeacherNumber.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TeacherNumber.ForeColor = Color.Black
        TeacherNumber.Location = New Point(56, 33)
        TeacherNumber.Name = "TeacherNumber"
        TeacherNumber.Size = New Size(79, 85)
        TeacherNumber.TabIndex = 5
        TeacherNumber.Text = "0"
        TeacherNumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' StaffNumber
        ' 
        StaffNumber.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StaffNumber.ForeColor = Color.Black
        StaffNumber.Location = New Point(57, 33)
        StaffNumber.Name = "StaffNumber"
        StaffNumber.Size = New Size(79, 85)
        StaffNumber.TabIndex = 6
        StaffNumber.Text = "0"
        StaffNumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RegistrarDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Name = "RegistrarDashboard"
        Size = New Size(706, 653)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents ShowPasswordBtn As Button
    Friend WithEvents BackBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents TeacherNumber As Label
    Friend WithEvents StaffNumber As Label
    Friend WithEvents StudentNumber As Label

End Class
