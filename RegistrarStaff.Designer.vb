<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarStaff
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
        Panel1 = New Panel()
        SearchTextBox = New TextBox()
        StaffDataGridView = New DataGridView()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        RemoveButton = New Button()
        ImportButton = New Button()
        StaffPictureBox = New PictureBox()
        StaffICTextBox = New TextBox()
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
        StaffEmailTextBox = New TextBox()
        Label6 = New Label()
        StaffIDTextBox = New TextBox()
        Label5 = New Label()
        StaffPasswordTextBox = New TextBox()
        Label4 = New Label()
        StaffUsernameTextBox = New TextBox()
        Label3 = New Label()
        StaffNameTextBox = New TextBox()
        Label2 = New Label()
        Panel = New Panel()
        Panel1.SuspendLayout()
        CType(StaffDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(StaffPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(SearchTextBox)
        Panel1.Controls.Add(StaffDataGridView)
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
        ' StaffDataGridView
        ' 
        StaffDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        StaffDataGridView.Location = New Point(16, 55)
        StaffDataGridView.Name = "StaffDataGridView"
        StaffDataGridView.RowHeadersWidth = 51
        StaffDataGridView.Size = New Size(661, 260)
        StaffDataGridView.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(16, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 28)
        Label1.TabIndex = 1
        Label1.Text = "STAFF DATA"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RemoveButton)
        GroupBox1.Controls.Add(ImportButton)
        GroupBox1.Controls.Add(StaffPictureBox)
        GroupBox1.Controls.Add(StaffICTextBox)
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
        GroupBox1.Controls.Add(StaffEmailTextBox)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(StaffIDTextBox)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(StaffPasswordTextBox)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(StaffUsernameTextBox)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(StaffNameTextBox)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(21, 359)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(693, 383)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Staff Account Information"
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
        ' StaffPictureBox
        ' 
        StaffPictureBox.BorderStyle = BorderStyle.Fixed3D
        StaffPictureBox.ErrorImage = Nothing
        StaffPictureBox.InitialImage = Nothing
        StaffPictureBox.Location = New Point(415, 95)
        StaffPictureBox.Name = "StaffPictureBox"
        StaffPictureBox.Size = New Size(140, 175)
        StaffPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        StaffPictureBox.TabIndex = 26
        StaffPictureBox.TabStop = False
        ' 
        ' StaffICTextBox
        ' 
        StaffICTextBox.BackColor = Color.White
        StaffICTextBox.BorderStyle = BorderStyle.FixedSingle
        StaffICTextBox.Cursor = Cursors.IBeam
        StaffICTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StaffICTextBox.Location = New Point(105, 229)
        StaffICTextBox.Name = "StaffICTextBox"
        StaffICTextBox.Size = New Size(284, 27)
        StaffICTextBox.TabIndex = 25
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
        ' StaffEmailTextBox
        ' 
        StaffEmailTextBox.BackColor = Color.White
        StaffEmailTextBox.BorderStyle = BorderStyle.FixedSingle
        StaffEmailTextBox.Cursor = Cursors.IBeam
        StaffEmailTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StaffEmailTextBox.Location = New Point(105, 140)
        StaffEmailTextBox.Name = "StaffEmailTextBox"
        StaffEmailTextBox.Size = New Size(285, 27)
        StaffEmailTextBox.TabIndex = 13
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
        ' StaffIDTextBox
        ' 
        StaffIDTextBox.BackColor = Color.White
        StaffIDTextBox.BorderStyle = BorderStyle.FixedSingle
        StaffIDTextBox.Cursor = Cursors.IBeam
        StaffIDTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StaffIDTextBox.Location = New Point(49, 40)
        StaffIDTextBox.Name = "StaffIDTextBox"
        StaffIDTextBox.Size = New Size(45, 27)
        StaffIDTextBox.TabIndex = 11
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
        ' StaffPasswordTextBox
        ' 
        StaffPasswordTextBox.BackColor = Color.White
        StaffPasswordTextBox.BorderStyle = BorderStyle.FixedSingle
        StaffPasswordTextBox.Cursor = Cursors.IBeam
        StaffPasswordTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StaffPasswordTextBox.Location = New Point(105, 320)
        StaffPasswordTextBox.Name = "StaffPasswordTextBox"
        StaffPasswordTextBox.PasswordChar = "•"c
        StaffPasswordTextBox.Size = New Size(181, 27)
        StaffPasswordTextBox.TabIndex = 9
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
        ' StaffUsernameTextBox
        ' 
        StaffUsernameTextBox.BackColor = Color.White
        StaffUsernameTextBox.BorderStyle = BorderStyle.FixedSingle
        StaffUsernameTextBox.Cursor = Cursors.IBeam
        StaffUsernameTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StaffUsernameTextBox.Location = New Point(105, 275)
        StaffUsernameTextBox.Name = "StaffUsernameTextBox"
        StaffUsernameTextBox.Size = New Size(181, 27)
        StaffUsernameTextBox.TabIndex = 7
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
        ' StaffNameTextBox
        ' 
        StaffNameTextBox.BackColor = Color.White
        StaffNameTextBox.BorderStyle = BorderStyle.FixedSingle
        StaffNameTextBox.Cursor = Cursors.IBeam
        StaffNameTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StaffNameTextBox.Location = New Point(105, 95)
        StaffNameTextBox.Name = "StaffNameTextBox"
        StaffNameTextBox.Size = New Size(285, 27)
        StaffNameTextBox.TabIndex = 5
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
        ' Panel
        ' 
        Panel.AutoScroll = True
        Panel.Controls.Add(GroupBox1)
        Panel.Controls.Add(Panel1)
        Panel.Dock = DockStyle.Fill
        Panel.Location = New Point(0, 0)
        Panel.Name = "Panel"
        Panel.Size = New Size(730, 760)
        Panel.TabIndex = 2

        ' RegistrarStaff
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel)
        name = "RegistrarStaffDataGridView"
        Size = New Size(730, 760)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(StaffDataGridView, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(StaffPictureBox, ComponentModel.ISupportInitialize).EndInit()
        Panel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents StaffDataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StaffNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents StaffUsernameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents StaffPasswordTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents StaffEmailTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents StaffIDTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ShowPasswordBtn As Button
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BirthdayDateTimePicker As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents EditBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents StaffICTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel As Panel
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents StaffPictureBox As PictureBox
    Friend WithEvents ImportButton As Button
    Friend WithEvents RemoveButton As Button

End Class
