<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffStudentRegistration
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffStudentRegistration))
        SubjectCreditHourTextBox = New TextBox()
        SubjectCodeTextBox = New TextBox()
        Label12 = New Label()
        DeleteBtn = New Button()
        ClearBtn = New Button()
        AddBtn = New Button()
        Label14 = New Label()
        EmailBtn = New Button()
        PrintBtn = New Button()
        ClearBtnStudent = New Button()
        StudentIDTextBox = New TextBox()
        Label11 = New Label()
        SearchStudentSubjectTextBox = New TextBox()
        StudentSubjectRegistrationDataGridView = New DataGridView()
        ClassTextBox = New TextBox()
        Label3 = New Label()
        Label9 = New Label()
        TotalCreditTextBox = New TextBox()
        StudentFeeTextBox = New TextBox()
        Label8 = New Label()
        StudentEmailTextBox = New TextBox()
        Label6 = New Label()
        ToolTip = New ToolTip(components)
        PrintDocument1 = New Printing.PrintDocument()
        Label4 = New Label()
        RegistrationIDTextBox = New TextBox()
        Panel2 = New Panel()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Label5 = New Label()
        SubjectRemarksTextBox = New TextBox()
        Label7 = New Label()
        SubjectNameComboBox = New ComboBox()
        GroupBox2 = New GroupBox()
        Label10 = New Label()
        StudentNameTextBox = New TextBox()
        Label2 = New Label()
        PrintDialog1 = New PrintDialog()
        GroupBox1 = New GroupBox()
        StudentFilterComboBox = New ComboBox()
        SearchStudentTextBox = New TextBox()
        StudentRegistrationDataGridView = New DataGridView()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel = New Panel()
        CType(StudentSubjectRegistrationDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(StudentRegistrationDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' SubjectCreditHourTextBox
        ' 
        SubjectCreditHourTextBox.BackColor = Color.White
        SubjectCreditHourTextBox.BorderStyle = BorderStyle.FixedSingle
        SubjectCreditHourTextBox.Cursor = Cursors.IBeam
        SubjectCreditHourTextBox.Enabled = False
        SubjectCreditHourTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SubjectCreditHourTextBox.Location = New Point(434, 81)
        SubjectCreditHourTextBox.Name = "SubjectCreditHourTextBox"
        SubjectCreditHourTextBox.Size = New Size(76, 27)
        SubjectCreditHourTextBox.TabIndex = 30
        ' 
        ' SubjectCodeTextBox
        ' 
        SubjectCodeTextBox.BackColor = Color.White
        SubjectCodeTextBox.BorderStyle = BorderStyle.FixedSingle
        SubjectCodeTextBox.Cursor = Cursors.IBeam
        SubjectCodeTextBox.Enabled = False
        SubjectCodeTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SubjectCodeTextBox.Location = New Point(138, 81)
        SubjectCodeTextBox.Name = "SubjectCodeTextBox"
        SubjectCodeTextBox.Size = New Size(106, 27)
        SubjectCodeTextBox.TabIndex = 27
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(20, 39)
        Label12.Name = "Label12"
        Label12.Size = New Size(105, 20)
        Label12.TabIndex = 26
        Label12.Text = "Subject Name:"
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = Color.Red
        DeleteBtn.Cursor = Cursors.Hand
        DeleteBtn.FlatStyle = FlatStyle.Flat
        DeleteBtn.ForeColor = SystemColors.ControlLightLight
        DeleteBtn.Location = New Point(532, 83)
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
        ClearBtn.Location = New Point(532, 129)
        ClearBtn.Name = "ClearBtn"
        ClearBtn.Size = New Size(101, 40)
        ClearBtn.TabIndex = 20
        ClearBtn.Text = "Clear"
        ClearBtn.UseVisualStyleBackColor = False
        ' 
        ' AddBtn
        ' 
        AddBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        AddBtn.Cursor = Cursors.Hand
        AddBtn.FlatStyle = FlatStyle.Flat
        AddBtn.ForeColor = SystemColors.ControlLightLight
        AddBtn.Location = New Point(532, 37)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(101, 40)
        AddBtn.TabIndex = 10
        AddBtn.Text = "Add"
        AddBtn.UseVisualStyleBackColor = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(17, 83)
        Label14.Name = "Label14"
        Label14.Size = New Size(100, 20)
        Label14.TabIndex = 4
        Label14.Text = "Subject Code:"
        ' 
        ' EmailBtn
        ' 
        EmailBtn.BackColor = Color.RoyalBlue
        EmailBtn.Cursor = Cursors.Hand
        EmailBtn.FlatStyle = FlatStyle.Flat
        EmailBtn.ForeColor = SystemColors.ControlLightLight
        EmailBtn.Image = My.Resources.Resources.envelope
        EmailBtn.Location = New Point(532, 175)
        EmailBtn.Name = "EmailBtn"
        EmailBtn.Size = New Size(45, 45)
        EmailBtn.TabIndex = 39
        ToolTip.SetToolTip(EmailBtn, "Email Student Registration Slip to Student")
        EmailBtn.UseVisualStyleBackColor = False
        ' 
        ' PrintBtn
        ' 
        PrintBtn.BackColor = Color.RoyalBlue
        PrintBtn.Cursor = Cursors.Hand
        PrintBtn.FlatStyle = FlatStyle.Flat
        PrintBtn.ForeColor = SystemColors.ControlLightLight
        PrintBtn.Image = My.Resources.Resources.print1
        PrintBtn.Location = New Point(588, 175)
        PrintBtn.Name = "PrintBtn"
        PrintBtn.Size = New Size(45, 45)
        PrintBtn.TabIndex = 38
        ToolTip.SetToolTip(PrintBtn, "Print Student Registration Information")
        PrintBtn.UseVisualStyleBackColor = False
        ' 
        ' ClearBtnStudent
        ' 
        ClearBtnStudent.BackColor = Color.MidnightBlue
        ClearBtnStudent.Cursor = Cursors.Hand
        ClearBtnStudent.FlatStyle = FlatStyle.Flat
        ClearBtnStudent.ForeColor = SystemColors.ControlLightLight
        ClearBtnStudent.Location = New Point(413, 41)
        ClearBtnStudent.Name = "ClearBtnStudent"
        ClearBtnStudent.Size = New Size(101, 40)
        ClearBtnStudent.TabIndex = 36
        ClearBtnStudent.Text = "Clear"
        ClearBtnStudent.UseVisualStyleBackColor = False
        ' 
        ' StudentIDTextBox
        ' 
        StudentIDTextBox.BackColor = Color.White
        StudentIDTextBox.BorderStyle = BorderStyle.FixedSingle
        StudentIDTextBox.Cursor = Cursors.IBeam
        StudentIDTextBox.Enabled = False
        StudentIDTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentIDTextBox.Location = New Point(133, 82)
        StudentIDTextBox.Name = "StudentIDTextBox"
        StudentIDTextBox.Size = New Size(45, 27)
        StudentIDTextBox.TabIndex = 37
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(20, 84)
        Label11.Name = "Label11"
        Label11.Size = New Size(82, 20)
        Label11.TabIndex = 36
        Label11.Text = "Student ID:"
        ' 
        ' SearchStudentSubjectTextBox
        ' 
        SearchStudentSubjectTextBox.BackColor = Color.White
        SearchStudentSubjectTextBox.BorderStyle = BorderStyle.FixedSingle
        SearchStudentSubjectTextBox.Cursor = Cursors.IBeam
        SearchStudentSubjectTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SearchStudentSubjectTextBox.Location = New Point(328, 20)
        SearchStudentSubjectTextBox.Name = "SearchStudentSubjectTextBox"
        SearchStudentSubjectTextBox.PlaceholderText = "  Search..."
        SearchStudentSubjectTextBox.Size = New Size(145, 27)
        SearchStudentSubjectTextBox.TabIndex = 26
        ' 
        ' StudentSubjectRegistrationDataGridView
        ' 
        StudentSubjectRegistrationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        StudentSubjectRegistrationDataGridView.Location = New Point(17, 55)
        StudentSubjectRegistrationDataGridView.Name = "StudentSubjectRegistrationDataGridView"
        StudentSubjectRegistrationDataGridView.RowHeadersWidth = 51
        StudentSubjectRegistrationDataGridView.Size = New Size(456, 720)
        StudentSubjectRegistrationDataGridView.TabIndex = 2
        ' 
        ' ClassTextBox
        ' 
        ClassTextBox.BackColor = Color.White
        ClassTextBox.BorderStyle = BorderStyle.FixedSingle
        ClassTextBox.Cursor = Cursors.IBeam
        ClassTextBox.Enabled = False
        ClassTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ClassTextBox.Location = New Point(304, 82)
        ClassTextBox.Name = "ClassTextBox"
        ClassTextBox.Size = New Size(95, 27)
        ClassTextBox.TabIndex = 35
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(253, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 20)
        Label3.TabIndex = 34
        Label3.Text = "Class:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(20, 195)
        Label9.Name = "Label9"
        Label9.Size = New Size(90, 20)
        Label9.TabIndex = 32
        Label9.Text = "Student Fee:"
        ' 
        ' TotalCreditTextBox
        ' 
        TotalCreditTextBox.BackColor = Color.White
        TotalCreditTextBox.BorderStyle = BorderStyle.FixedSingle
        TotalCreditTextBox.Cursor = Cursors.IBeam
        TotalCreditTextBox.Enabled = False
        TotalCreditTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TotalCreditTextBox.Location = New Point(304, 41)
        TotalCreditTextBox.Name = "TotalCreditTextBox"
        TotalCreditTextBox.Size = New Size(95, 27)
        TotalCreditTextBox.TabIndex = 31
        ' 
        ' StudentFeeTextBox
        ' 
        StudentFeeTextBox.BackColor = Color.White
        StudentFeeTextBox.BorderStyle = BorderStyle.FixedSingle
        StudentFeeTextBox.Cursor = Cursors.IBeam
        StudentFeeTextBox.Enabled = False
        StudentFeeTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentFeeTextBox.Location = New Point(133, 193)
        StudentFeeTextBox.Name = "StudentFeeTextBox"
        StudentFeeTextBox.Size = New Size(381, 27)
        StudentFeeTextBox.TabIndex = 30
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(209, 43)
        Label8.Name = "Label8"
        Label8.Size = New Size(89, 20)
        Label8.TabIndex = 29
        Label8.Text = "Total Credit:"
        ' 
        ' StudentEmailTextBox
        ' 
        StudentEmailTextBox.BackColor = Color.White
        StudentEmailTextBox.BorderStyle = BorderStyle.FixedSingle
        StudentEmailTextBox.Cursor = Cursors.IBeam
        StudentEmailTextBox.Enabled = False
        StudentEmailTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentEmailTextBox.Location = New Point(133, 158)
        StudentEmailTextBox.Name = "StudentEmailTextBox"
        StudentEmailTextBox.Size = New Size(381, 27)
        StudentEmailTextBox.TabIndex = 27
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(16, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(191, 28)
        Label6.TabIndex = 1
        Label6.Text = "STUDENT SUBJECT"
        ' 
        ' ToolTip
        ' 
        ToolTip.ToolTipIcon = ToolTipIcon.Info
        ToolTip.ToolTipTitle = "Information"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(20, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 20)
        Label4.TabIndex = 26
        Label4.Text = "Student Name:"
        ' 
        ' RegistrationIDTextBox
        ' 
        RegistrationIDTextBox.BackColor = Color.White
        RegistrationIDTextBox.BorderStyle = BorderStyle.FixedSingle
        RegistrationIDTextBox.Cursor = Cursors.IBeam
        RegistrationIDTextBox.Enabled = False
        RegistrationIDTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RegistrationIDTextBox.Location = New Point(133, 41)
        RegistrationIDTextBox.Name = "RegistrationIDTextBox"
        RegistrationIDTextBox.Size = New Size(45, 27)
        RegistrationIDTextBox.TabIndex = 11
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.MidnightBlue
        Panel2.Controls.Add(SearchStudentSubjectTextBox)
        Panel2.Controls.Add(StudentSubjectRegistrationDataGridView)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(692, 18)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(489, 791)
        Panel2.TabIndex = 27
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(16, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 20)
        Label5.TabIndex = 10
        Label5.Text = "Registration ID:"
        ' 
        ' SubjectRemarksTextBox
        ' 
        SubjectRemarksTextBox.BackColor = Color.White
        SubjectRemarksTextBox.BorderStyle = BorderStyle.FixedSingle
        SubjectRemarksTextBox.Cursor = Cursors.IBeam
        SubjectRemarksTextBox.Enabled = False
        SubjectRemarksTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SubjectRemarksTextBox.Location = New Point(138, 127)
        SubjectRemarksTextBox.Multiline = True
        SubjectRemarksTextBox.Name = "SubjectRemarksTextBox"
        SubjectRemarksTextBox.Size = New Size(373, 56)
        SubjectRemarksTextBox.TabIndex = 35
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(17, 129)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 20)
        Label7.TabIndex = 34
        Label7.Text = "Remarks:"
        ' 
        ' SubjectNameComboBox
        ' 
        SubjectNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        SubjectNameComboBox.FormattingEnabled = True
        SubjectNameComboBox.Location = New Point(138, 36)
        SubjectNameComboBox.Name = "SubjectNameComboBox"
        SubjectNameComboBox.Size = New Size(372, 28)
        SubjectNameComboBox.TabIndex = 33
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(SubjectRemarksTextBox)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(SubjectNameComboBox)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(SubjectCreditHourTextBox)
        GroupBox2.Controls.Add(SubjectCodeTextBox)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(DeleteBtn)
        GroupBox2.Controls.Add(ClearBtn)
        GroupBox2.Controls.Add(AddBtn)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Location = New Point(18, 610)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(657, 199)
        GroupBox2.TabIndex = 36
        GroupBox2.TabStop = False
        GroupBox2.Text = "Subject Registration"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(286, 83)
        Label10.Name = "Label10"
        Label10.Size = New Size(142, 20)
        Label10.TabIndex = 32
        Label10.Text = "Subject Credit Hour:"
        ' 
        ' StudentNameTextBox
        ' 
        StudentNameTextBox.BackColor = Color.White
        StudentNameTextBox.BorderStyle = BorderStyle.FixedSingle
        StudentNameTextBox.Cursor = Cursors.IBeam
        StudentNameTextBox.Enabled = False
        StudentNameTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentNameTextBox.Location = New Point(133, 123)
        StudentNameTextBox.Name = "StudentNameTextBox"
        StudentNameTextBox.Size = New Size(381, 27)
        StudentNameTextBox.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(20, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 4
        Label2.Text = "Student Email:"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(EmailBtn)
        GroupBox1.Controls.Add(PrintBtn)
        GroupBox1.Controls.Add(ClearBtnStudent)
        GroupBox1.Controls.Add(StudentIDTextBox)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(ClassTextBox)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(TotalCreditTextBox)
        GroupBox1.Controls.Add(StudentFeeTextBox)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(StudentEmailTextBox)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(RegistrationIDTextBox)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(StudentNameTextBox)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(18, 355)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(657, 249)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Student Information"
        ' 
        ' StudentFilterComboBox
        ' 
        StudentFilterComboBox.FormattingEnabled = True
        StudentFilterComboBox.Location = New Point(339, 20)
        StudentFilterComboBox.Name = "StudentFilterComboBox"
        StudentFilterComboBox.Size = New Size(151, 28)
        StudentFilterComboBox.TabIndex = 27
        ' 
        ' SearchStudentTextBox
        ' 
        SearchStudentTextBox.BackColor = Color.White
        SearchStudentTextBox.BorderStyle = BorderStyle.FixedSingle
        SearchStudentTextBox.Cursor = Cursors.IBeam
        SearchStudentTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SearchStudentTextBox.Location = New Point(496, 21)
        SearchStudentTextBox.Name = "SearchStudentTextBox"
        SearchStudentTextBox.PlaceholderText = "  Search..."
        SearchStudentTextBox.Size = New Size(145, 27)
        SearchStudentTextBox.TabIndex = 26
        ' 
        ' StudentRegistrationDataGridView
        ' 
        StudentRegistrationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        StudentRegistrationDataGridView.Location = New Point(16, 55)
        StudentRegistrationDataGridView.Name = "StudentRegistrationDataGridView"
        StudentRegistrationDataGridView.RowHeadersWidth = 51
        StudentRegistrationDataGridView.Size = New Size(625, 260)
        StudentRegistrationDataGridView.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(16, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(251, 28)
        Label1.TabIndex = 1
        Label1.Text = "STUDENT REGISTRATION"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(StudentFilterComboBox)
        Panel1.Controls.Add(SearchStudentTextBox)
        Panel1.Controls.Add(StudentRegistrationDataGridView)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(18, 18)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(657, 331)
        Panel1.TabIndex = 2
        ' 
        ' Panel
        ' 
        Panel.AutoScroll = True
        Panel.Controls.Add(GroupBox2)
        Panel.Controls.Add(Panel2)
        Panel.Controls.Add(Panel1)
        Panel.Controls.Add(GroupBox1)
        Panel.Dock = DockStyle.Fill
        Panel.Location = New Point(0, 0)
        Panel.Name = "Panel"
        Panel.Size = New Size(1200, 835)
        Panel.TabIndex = 3
        ' 
        ' StaffStudentRegistration
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel)
        Name = "StaffStudentRegistration"
        Size = New Size(1200, 835)
        CType(StudentSubjectRegistrationDataGridView, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(StudentRegistrationDataGridView, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents SubjectCreditHourTextBox As TextBox
    Friend WithEvents SubjectCodeTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents EmailBtn As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents PrintBtn As Button
    Friend WithEvents ClearBtnStudent As Button
    Friend WithEvents StudentIDTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents SearchStudentSubjectTextBox As TextBox
    Friend WithEvents StudentSubjectRegistrationDataGridView As DataGridView
    Friend WithEvents ClassTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TotalCreditTextBox As TextBox
    Friend WithEvents StudentFeeTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents StudentEmailTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label4 As Label
    Friend WithEvents RegistrationIDTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents SubjectRemarksTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SubjectNameComboBox As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents StudentNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StudentFilterComboBox As ComboBox
    Friend WithEvents SearchStudentTextBox As TextBox
    Friend WithEvents StudentRegistrationDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel As Panel

End Class
