<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherDashboard
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
        RemoveButton = New Button()
        ImportButton = New Button()
        TeacherPictureBox = New PictureBox()
        TeacherICTextBox = New TextBox()
        Label10 = New Label()
        SaveBtn = New Button()
        PhoneTextBox = New TextBox()
        Label9 = New Label()
        EditBtn = New Button()
        BirthdayDateTimePicker = New DateTimePicker()
        Label8 = New Label()
        GenderComboBox = New ComboBox()
        Label7 = New Label()
        ShowPasswordBtn = New Button()
        TeacherEmailTextBox = New TextBox()
        Label6 = New Label()
        TeacherIDTextBox = New TextBox()
        Label5 = New Label()
        TeacherPasswordTextBox = New TextBox()
        Label4 = New Label()
        TeacherUsernameTextBox = New TextBox()
        Label3 = New Label()
        TeacherNameTextBox = New TextBox()
        Label2 = New Label()
        StudentNumber = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Panel2 = New Panel()
        StaffNumber = New Label()
        Label11 = New Label()
        Panel3 = New Panel()
        TeacherNumber = New Label()
        Label1 = New Label()
        Panel4 = New Panel()
        Panel1 = New Panel()
        GroupBox1 = New GroupBox()
        Panel = New Panel()
        CType(TeacherPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' RemoveButton
        ' 
        RemoveButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RemoveButton.ForeColor = Color.Red
        RemoveButton.Location = New Point(518, 276)
        RemoveButton.Name = "RemoveButton"
        RemoveButton.Size = New Size(37, 35)
        RemoveButton.TabIndex = 28
        RemoveButton.Text = "X"
        RemoveButton.UseVisualStyleBackColor = True
        ' 
        ' ImportButton
        ' 
        ImportButton.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ImportButton.Location = New Point(415, 276)
        ImportButton.Name = "ImportButton"
        ImportButton.Size = New Size(97, 35)
        ImportButton.TabIndex = 27
        ImportButton.Text = "Import..."
        ImportButton.UseVisualStyleBackColor = True
        ' 
        ' TeacherPictureBox
        ' 
        TeacherPictureBox.BorderStyle = BorderStyle.Fixed3D
        TeacherPictureBox.ErrorImage = Nothing
        TeacherPictureBox.InitialImage = Nothing
        TeacherPictureBox.Location = New Point(415, 95)
        TeacherPictureBox.Name = "TeacherPictureBox"
        TeacherPictureBox.Size = New Size(140, 175)
        TeacherPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        TeacherPictureBox.TabIndex = 26
        TeacherPictureBox.TabStop = False
        ' 
        ' TeacherICTextBox
        ' 
        TeacherICTextBox.BackColor = Color.White
        TeacherICTextBox.BorderStyle = BorderStyle.FixedSingle
        TeacherICTextBox.Cursor = Cursors.IBeam
        TeacherICTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TeacherICTextBox.Location = New Point(105, 229)
        TeacherICTextBox.Name = "TeacherICTextBox"
        TeacherICTextBox.Size = New Size(284, 27)
        TeacherICTextBox.TabIndex = 25
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(16, 232)
        Label10.Name = "Label10"
        Label10.Size = New Size(83, 20)
        Label10.TabIndex = 24
        Label10.Text = "IC Number:"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.Red
        SaveBtn.Cursor = Cursors.Hand
        SaveBtn.FlatStyle = FlatStyle.Flat
        SaveBtn.ForeColor = SystemColors.ControlLightLight
        SaveBtn.Location = New Point(576, 141)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(101, 40)
        SaveBtn.TabIndex = 23
        SaveBtn.Text = "Save"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' PhoneTextBox
        ' 
        PhoneTextBox.BackColor = Color.White
        PhoneTextBox.BorderStyle = BorderStyle.FixedSingle
        PhoneTextBox.Cursor = Cursors.IBeam
        PhoneTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PhoneTextBox.Location = New Point(105, 185)
        PhoneTextBox.Name = "PhoneTextBox"
        PhoneTextBox.Size = New Size(285, 27)
        PhoneTextBox.TabIndex = 22
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(17, 187)
        Label9.Name = "Label9"
        Label9.Size = New Size(53, 20)
        Label9.TabIndex = 21
        Label9.Text = "Phone:"
        ' 
        ' EditBtn
        ' 
        EditBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        EditBtn.Cursor = Cursors.Hand
        EditBtn.FlatStyle = FlatStyle.Flat
        EditBtn.ForeColor = SystemColors.ControlLightLight
        EditBtn.Location = New Point(576, 95)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(101, 40)
        EditBtn.TabIndex = 19
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = False
        ' 
        ' BirthdayDateTimePicker
        ' 
        BirthdayDateTimePicker.Location = New Point(395, 40)
        BirthdayDateTimePicker.Name = "BirthdayDateTimePicker"
        BirthdayDateTimePicker.Size = New Size(250, 27)
        BirthdayDateTimePicker.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(322, 43)
        Label8.Name = "Label8"
        Label8.Size = New Size(67, 20)
        Label8.TabIndex = 17
        Label8.Text = "Birthday:"
        ' 
        ' GenderComboBox
        ' 
        GenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        GenderComboBox.FormattingEnabled = True
        GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        GenderComboBox.Location = New Point(191, 39)
        GenderComboBox.Name = "GenderComboBox"
        GenderComboBox.Size = New Size(95, 28)
        GenderComboBox.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(125, 43)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 20)
        Label7.TabIndex = 15
        Label7.Text = "Gender:"
        ' 
        ' ShowPasswordBtn
        ' 
        ShowPasswordBtn.Cursor = Cursors.Hand
        ShowPasswordBtn.Image = My.Resources.Resources.eye_1_
        ShowPasswordBtn.Location = New Point(293, 320)
        ShowPasswordBtn.Name = "ShowPasswordBtn"
        ShowPasswordBtn.Size = New Size(27, 27)
        ShowPasswordBtn.TabIndex = 14
        ShowPasswordBtn.UseVisualStyleBackColor = True
        ' 
        ' TeacherEmailTextBox
        ' 
        TeacherEmailTextBox.BackColor = Color.White
        TeacherEmailTextBox.BorderStyle = BorderStyle.FixedSingle
        TeacherEmailTextBox.Cursor = Cursors.IBeam
        TeacherEmailTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TeacherEmailTextBox.Location = New Point(105, 140)
        TeacherEmailTextBox.Name = "TeacherEmailTextBox"
        TeacherEmailTextBox.Size = New Size(285, 27)
        TeacherEmailTextBox.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(17, 141)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 20)
        Label6.TabIndex = 12
        Label6.Text = "Email:"
        ' 
        ' TeacherIDTextBox
        ' 
        TeacherIDTextBox.BackColor = Color.White
        TeacherIDTextBox.BorderStyle = BorderStyle.FixedSingle
        TeacherIDTextBox.Cursor = Cursors.IBeam
        TeacherIDTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TeacherIDTextBox.Location = New Point(49, 40)
        TeacherIDTextBox.Name = "TeacherIDTextBox"
        TeacherIDTextBox.Size = New Size(45, 27)
        TeacherIDTextBox.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(16, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(27, 20)
        Label5.TabIndex = 10
        Label5.Text = "ID:"
        ' 
        ' TeacherPasswordTextBox
        ' 
        TeacherPasswordTextBox.BackColor = Color.White
        TeacherPasswordTextBox.BorderStyle = BorderStyle.FixedSingle
        TeacherPasswordTextBox.Cursor = Cursors.IBeam
        TeacherPasswordTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TeacherPasswordTextBox.Location = New Point(105, 320)
        TeacherPasswordTextBox.Name = "TeacherPasswordTextBox"
        TeacherPasswordTextBox.PasswordChar = "•"c
        TeacherPasswordTextBox.Size = New Size(181, 27)
        TeacherPasswordTextBox.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(16, 323)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 8
        Label4.Text = "Password:"
        ' 
        ' TeacherUsernameTextBox
        ' 
        TeacherUsernameTextBox.BackColor = Color.White
        TeacherUsernameTextBox.BorderStyle = BorderStyle.FixedSingle
        TeacherUsernameTextBox.Cursor = Cursors.IBeam
        TeacherUsernameTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TeacherUsernameTextBox.Location = New Point(105, 275)
        TeacherUsernameTextBox.Name = "TeacherUsernameTextBox"
        TeacherUsernameTextBox.Size = New Size(181, 27)
        TeacherUsernameTextBox.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(16, 277)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 6
        Label3.Text = "Username:"
        ' 
        ' TeacherNameTextBox
        ' 
        TeacherNameTextBox.BackColor = Color.White
        TeacherNameTextBox.BorderStyle = BorderStyle.FixedSingle
        TeacherNameTextBox.Cursor = Cursors.IBeam
        TeacherNameTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TeacherNameTextBox.Location = New Point(105, 95)
        TeacherNameTextBox.Name = "TeacherNameTextBox"
        TeacherNameTextBox.Size = New Size(285, 27)
        TeacherNameTextBox.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(17, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 20)
        Label2.TabIndex = 4
        Label2.Text = "Name:"
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
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Teal
        Label13.Location = New Point(93, 135)
        Label13.Name = "Label13"
        Label13.Size = New Size(79, 25)
        Label13.TabIndex = 3
        Label13.Text = "Student"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(14, 15)
        Label12.Name = "Label12"
        Label12.Size = New Size(264, 31)
        Label12.TabIndex = 9
        Label12.Text = "TEACHER DASHBOARD"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(StudentNumber)
        Panel2.Controls.Add(Label13)
        Panel2.Location = New Point(22, 60)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(185, 171)
        Panel2.TabIndex = 0
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
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Teal
        Label11.Location = New Point(120, 135)
        Label11.Name = "Label11"
        Label11.Size = New Size(53, 25)
        Label11.TabIndex = 5
        Label11.Text = "Staff"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(StaffNumber)
        Panel3.Controls.Add(Label11)
        Panel3.Location = New Point(492, 60)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(185, 171)
        Panel3.TabIndex = 1
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Teal
        Label1.Location = New Point(93, 135)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 25)
        Label1.TabIndex = 4
        Label1.Text = "Teacher"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(TeacherNumber)
        Panel4.Controls.Add(Label1)
        Panel4.Location = New Point(257, 60)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(185, 171)
        Panel4.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(19, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(693, 251)
        Panel1.TabIndex = 11
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RemoveButton)
        GroupBox1.Controls.Add(ImportButton)
        GroupBox1.Controls.Add(TeacherPictureBox)
        GroupBox1.Controls.Add(TeacherICTextBox)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(SaveBtn)
        GroupBox1.Controls.Add(PhoneTextBox)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(EditBtn)
        GroupBox1.Controls.Add(BirthdayDateTimePicker)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(GenderComboBox)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(ShowPasswordBtn)
        GroupBox1.Controls.Add(TeacherEmailTextBox)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TeacherIDTextBox)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TeacherPasswordTextBox)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TeacherUsernameTextBox)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TeacherNameTextBox)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(19, 279)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(693, 371)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Teacher Account Information"
        ' 
        ' Panel
        ' 
        Panel.AutoScroll = True
        Panel.Controls.Add(Panel1)
        Panel.Controls.Add(GroupBox1)
        Panel.Dock = DockStyle.Fill
        Panel.Location = New Point(0, 0)
        Panel.Name = "Panel"
        Panel.Size = New Size(730, 670)
        Panel.TabIndex = 4
        ' 
        ' TeacherDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel)
        Name = "TeacherDashboard"
        Size = New Size(730, 670)
        CType(TeacherPictureBox, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents RemoveButton As Button
    Friend WithEvents ImportButton As Button
    Friend WithEvents TeacherPictureBox As PictureBox
    Friend WithEvents TeacherICTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents EditBtn As Button
    Friend WithEvents BirthdayDateTimePicker As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ShowPasswordBtn As Button
    Friend WithEvents TeacherEmailTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TeacherIDTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TeacherPasswordTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TeacherUsernameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TeacherNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents StudentNumber As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents StaffNumber As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TeacherNumber As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel As Panel

End Class
