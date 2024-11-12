<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffUser
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
        DeleteBtn = New Button()
        ClearBtn = New Button()
        EditBtn = New Button()
        AddBtn = New Button()
        BirthdayDateTimePicker = New DateTimePicker()
        Label8 = New Label()
        ShowPasswordBtn = New Button()
        UserEmailTextBox = New TextBox()
        Label6 = New Label()
        UserIDTextBox = New TextBox()
        Label5 = New Label()
        UserPasswordTextBox = New TextBox()
        Label4 = New Label()
        UserUsernameTextBox = New TextBox()
        Label3 = New Label()
        UserNameTextBox = New TextBox()
        Label2 = New Label()
        SearchTextBox = New TextBox()
        UserDataGridView = New DataGridView()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Panel1 = New Panel()
        Panel = New Panel()
        CType(UserDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = Color.Red
        DeleteBtn.Cursor = Cursors.Hand
        DeleteBtn.FlatStyle = FlatStyle.Flat
        DeleteBtn.ForeColor = SystemColors.ControlLightLight
        DeleteBtn.Location = New Point(412, 187)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(101, 40)
        DeleteBtn.TabIndex = 23
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' ClearBtn
        ' 
        ClearBtn.BackColor = Color.MidnightBlue
        ClearBtn.Cursor = Cursors.Hand
        ClearBtn.FlatStyle = FlatStyle.Flat
        ClearBtn.ForeColor = SystemColors.ControlLightLight
        ClearBtn.Location = New Point(412, 233)
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
        EditBtn.Location = New Point(412, 141)
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
        AddBtn.Location = New Point(412, 95)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(101, 40)
        AddBtn.TabIndex = 10
        AddBtn.Text = "Add"
        AddBtn.UseVisualStyleBackColor = False
        ' 
        ' BirthdayDateTimePicker
        ' 
        BirthdayDateTimePicker.Location = New Point(223, 40)
        BirthdayDateTimePicker.Name = "BirthdayDateTimePicker"
        BirthdayDateTimePicker.Size = New Size(250, 27)
        BirthdayDateTimePicker.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(150, 42)
        Label8.Name = "Label8"
        Label8.Size = New Size(67, 20)
        Label8.TabIndex = 17
        Label8.Text = "Birthday:"
        ' 
        ' ShowPasswordBtn
        ' 
        ShowPasswordBtn.Cursor = Cursors.Hand
        ShowPasswordBtn.Image = My.Resources.Resources.eye_1_
        ShowPasswordBtn.Location = New Point(293, 232)
        ShowPasswordBtn.Name = "ShowPasswordBtn"
        ShowPasswordBtn.Size = New Size(27, 27)
        ShowPasswordBtn.TabIndex = 14
        ShowPasswordBtn.UseVisualStyleBackColor = True
        ' 
        ' UserEmailTextBox
        ' 
        UserEmailTextBox.BackColor = Color.White
        UserEmailTextBox.BorderStyle = BorderStyle.FixedSingle
        UserEmailTextBox.Cursor = Cursors.IBeam
        UserEmailTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UserEmailTextBox.Location = New Point(105, 140)
        UserEmailTextBox.Name = "UserEmailTextBox"
        UserEmailTextBox.Size = New Size(285, 27)
        UserEmailTextBox.TabIndex = 13
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
        ' UserIDTextBox
        ' 
        UserIDTextBox.BackColor = Color.White
        UserIDTextBox.BorderStyle = BorderStyle.FixedSingle
        UserIDTextBox.Cursor = Cursors.IBeam
        UserIDTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UserIDTextBox.Location = New Point(49, 40)
        UserIDTextBox.Name = "UserIDTextBox"
        UserIDTextBox.Size = New Size(45, 27)
        UserIDTextBox.TabIndex = 11
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
        ' UserPasswordTextBox
        ' 
        UserPasswordTextBox.BackColor = Color.White
        UserPasswordTextBox.BorderStyle = BorderStyle.FixedSingle
        UserPasswordTextBox.Cursor = Cursors.IBeam
        UserPasswordTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UserPasswordTextBox.Location = New Point(105, 232)
        UserPasswordTextBox.Name = "UserPasswordTextBox"
        UserPasswordTextBox.PasswordChar = "•"c
        UserPasswordTextBox.Size = New Size(181, 27)
        UserPasswordTextBox.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(16, 235)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 8
        Label4.Text = "Password:"
        ' 
        ' UserUsernameTextBox
        ' 
        UserUsernameTextBox.BackColor = Color.White
        UserUsernameTextBox.BorderStyle = BorderStyle.FixedSingle
        UserUsernameTextBox.Cursor = Cursors.IBeam
        UserUsernameTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UserUsernameTextBox.Location = New Point(105, 187)
        UserUsernameTextBox.Name = "UserUsernameTextBox"
        UserUsernameTextBox.Size = New Size(181, 27)
        UserUsernameTextBox.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(16, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 6
        Label3.Text = "Username:"
        ' 
        ' UserNameTextBox
        ' 
        UserNameTextBox.BackColor = Color.White
        UserNameTextBox.BorderStyle = BorderStyle.FixedSingle
        UserNameTextBox.Cursor = Cursors.IBeam
        UserNameTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UserNameTextBox.Location = New Point(105, 95)
        UserNameTextBox.Name = "UserNameTextBox"
        UserNameTextBox.Size = New Size(285, 27)
        UserNameTextBox.TabIndex = 5
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
        ' UserDataGridView
        ' 
        UserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        UserDataGridView.Location = New Point(16, 55)
        UserDataGridView.Name = "UserDataGridView"
        UserDataGridView.RowHeadersWidth = 51
        UserDataGridView.Size = New Size(661, 260)
        UserDataGridView.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(16, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 28)
        Label1.TabIndex = 1
        Label1.Text = "USER DATA"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DeleteBtn)
        GroupBox1.Controls.Add(ClearBtn)
        GroupBox1.Controls.Add(EditBtn)
        GroupBox1.Controls.Add(AddBtn)
        GroupBox1.Controls.Add(BirthdayDateTimePicker)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(ShowPasswordBtn)
        GroupBox1.Controls.Add(UserEmailTextBox)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(UserIDTextBox)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(UserPasswordTextBox)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(UserUsernameTextBox)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(UserNameTextBox)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(21, 359)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(693, 383)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "User Account Information"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(SearchTextBox)
        Panel1.Controls.Add(UserDataGridView)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(21, 23)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(693, 331)
        Panel1.TabIndex = 0
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
        ' StaffUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel)
        Name = "StaffUser"
        Size = New Size(730, 760)
        CType(UserDataGridView, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents BirthdayDateTimePicker As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents ShowPasswordBtn As Button
    Friend WithEvents UserEmailTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents UserPasswordTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents UserUsernameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents UserDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel As Panel

End Class
