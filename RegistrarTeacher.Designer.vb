<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarTeacher
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
        Panel = New Panel()
        GroupBox1 = New GroupBox()
        RemoveButton = New Button()
        ImportButton = New Button()
        TeacherPictureBox = New PictureBox()
        TeacherICTextBox = New TextBox()
        Label10 = New Label()
        DeleteBtn = New Button()
        PhoneTextBox = New TextBox()
        Label9 = New Label()
        ClearBtn = New Button()
        EditBtn = New Button()
        AddBtn = New Button()
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
        Panel1 = New Panel()
        SearchTextBox = New TextBox()
        TeacherDataGridView = New DataGridView()
        Label1 = New Label()
        Panel.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(TeacherPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(TeacherDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel
        ' 
        Panel.AutoScroll = True
        Panel.Controls.Add(GroupBox1)
        Panel.Controls.Add(Panel1)
        Panel.Dock = DockStyle.Fill
        Panel.Location = New Point(0, 0)
        Panel.Name = "Panel"
        Panel.Size = New Size(730, 760)
        Panel.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RemoveButton)
        GroupBox1.Controls.Add(ImportButton)
        GroupBox1.Controls.Add(TeacherPictureBox)
        GroupBox1.Controls.Add(TeacherICTextBox)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(DeleteBtn)
        GroupBox1.Controls.Add(PhoneTextBox)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(ClearBtn)
        GroupBox1.Controls.Add(EditBtn)
        GroupBox1.Controls.Add(AddBtn)
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
        GroupBox1.Location = New Point(21, 359)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(693, 383)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Teacher Account Information"
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
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = Color.Red
        DeleteBtn.Cursor = Cursors.Hand
        DeleteBtn.FlatStyle = FlatStyle.Flat
        DeleteBtn.ForeColor = SystemColors.ControlLightLight
        DeleteBtn.Location = New Point(576, 187)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(101, 40)
        DeleteBtn.TabIndex = 23
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = False
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
        ' ClearBtn
        ' 
        ClearBtn.BackColor = Color.Teal
        ClearBtn.Cursor = Cursors.Hand
        ClearBtn.FlatStyle = FlatStyle.Flat
        ClearBtn.ForeColor = SystemColors.ControlLightLight
        ClearBtn.Location = New Point(576, 233)
        ClearBtn.Name = "ClearBtn"
        ClearBtn.Size = New Size(101, 40)
        ClearBtn.TabIndex = 20
        ClearBtn.Text = "Clear"
        ClearBtn.UseVisualStyleBackColor = False
        ' 
        ' EditBtn
        ' 
        EditBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        EditBtn.Cursor = Cursors.Hand
        EditBtn.FlatStyle = FlatStyle.Flat
        EditBtn.ForeColor = SystemColors.ControlLightLight
        EditBtn.Location = New Point(576, 141)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(101, 40)
        EditBtn.TabIndex = 19
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = False
        ' 
        ' AddBtn
        ' 
        AddBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        AddBtn.Cursor = Cursors.Hand
        AddBtn.FlatStyle = FlatStyle.Flat
        AddBtn.ForeColor = SystemColors.ControlLightLight
        AddBtn.Location = New Point(576, 95)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(101, 40)
        AddBtn.TabIndex = 10
        AddBtn.Text = "Add"
        AddBtn.UseVisualStyleBackColor = False
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
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(SearchTextBox)
        Panel1.Controls.Add(TeacherDataGridView)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(21, 23)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(693, 331)
        Panel1.TabIndex = 0
        ' 
        ' SearchTextBox
        ' 
        SearchTextBox.BackColor = Color.White
        SearchTextBox.BorderStyle = BorderStyle.FixedSingle
        SearchTextBox.Cursor = Cursors.IBeam
        SearchTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SearchTextBox.Location = New Point(531, 21)
        SearchTextBox.Name = "SearchTextBox"
        SearchTextBox.PlaceholderText = "  Search..."
        SearchTextBox.Size = New Size(145, 27)
        SearchTextBox.TabIndex = 26
        ' 
        ' TeacherDataGridView
        ' 
        TeacherDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TeacherDataGridView.Location = New Point(16, 55)
        TeacherDataGridView.Name = "TeacherDataGridView"
        TeacherDataGridView.RowHeadersWidth = 51
        TeacherDataGridView.Size = New Size(661, 260)
        TeacherDataGridView.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(16, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 28)
        Label1.TabIndex = 1
        Label1.Text = "TEACHER DATA"
        ' 
        ' RegistrarTeacher
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel)
        Margin = New Padding(3, 4, 3, 4)
        Name = "RegistrarTeacher"
        Size = New Size(730, 760)
        Panel.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(TeacherPictureBox, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(TeacherDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RemoveButton As Button
    Friend WithEvents ImportButton As Button
    Friend WithEvents TeacherPictureBox As PictureBox
    Friend WithEvents TeacherICTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ClearBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents AddBtn As Button
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents TeacherDataGridView As DataGridView
    Friend WithEvents Label1 As Label

End Class
