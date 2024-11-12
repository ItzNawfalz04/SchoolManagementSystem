<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffSubject
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
        CreditHourComboBox = New ComboBox()
        Label6 = New Label()
        SubjectCodeTextBox = New TextBox()
        Label4 = New Label()
        RemarksTextBox = New TextBox()
        Label3 = New Label()
        DeleteBtn = New Button()
        ClearBtn = New Button()
        EditBtn = New Button()
        AddBtn = New Button()
        IDTextBox = New TextBox()
        Label5 = New Label()
        Panel1 = New Panel()
        SearchTextBox = New TextBox()
        SubjectDataGridView = New DataGridView()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        SubjectNameTextBox = New TextBox()
        Label2 = New Label()
        Panel = New Panel()
        Panel1.SuspendLayout()
        CType(SubjectDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' CreditHourComboBox
        ' 
        CreditHourComboBox.FormattingEnabled = True
        CreditHourComboBox.Location = New Point(531, 40)
        CreditHourComboBox.Name = "CreditHourComboBox"
        CreditHourComboBox.Size = New Size(73, 28)
        CreditHourComboBox.TabIndex = 29
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(436, 43)
        Label6.Name = "Label6"
        Label6.Size = New Size(89, 20)
        Label6.TabIndex = 28
        Label6.Text = "Credit Hour:"
        ' 
        ' SubjectCodeTextBox
        ' 
        SubjectCodeTextBox.BackColor = Color.White
        SubjectCodeTextBox.BorderStyle = BorderStyle.FixedSingle
        SubjectCodeTextBox.Cursor = Cursors.IBeam
        SubjectCodeTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SubjectCodeTextBox.Location = New Point(291, 41)
        SubjectCodeTextBox.Name = "SubjectCodeTextBox"
        SubjectCodeTextBox.Size = New Size(101, 27)
        SubjectCodeTextBox.TabIndex = 27
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(185, 43)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 20)
        Label4.TabIndex = 26
        Label4.Text = "Subject Code:"
        ' 
        ' RemarksTextBox
        ' 
        RemarksTextBox.BackColor = Color.White
        RemarksTextBox.BorderStyle = BorderStyle.FixedSingle
        RemarksTextBox.Cursor = Cursors.IBeam
        RemarksTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RemarksTextBox.Location = New Point(123, 139)
        RemarksTextBox.Multiline = True
        RemarksTextBox.Name = "RemarksTextBox"
        RemarksTextBox.Size = New Size(381, 181)
        RemarksTextBox.TabIndex = 25
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(16, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 20)
        Label3.TabIndex = 24
        Label3.Text = "Remarks:"
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = Color.Red
        DeleteBtn.Cursor = Cursors.Hand
        DeleteBtn.FlatStyle = FlatStyle.Flat
        DeleteBtn.ForeColor = SystemColors.ControlLightLight
        DeleteBtn.Location = New Point(531, 184)
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
        ClearBtn.Location = New Point(531, 230)
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
        EditBtn.Location = New Point(531, 138)
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
        AddBtn.Location = New Point(531, 92)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(101, 40)
        AddBtn.TabIndex = 10
        AddBtn.Text = "Add"
        AddBtn.UseVisualStyleBackColor = False
        ' 
        ' IDTextBox
        ' 
        IDTextBox.BackColor = Color.White
        IDTextBox.BorderStyle = BorderStyle.FixedSingle
        IDTextBox.Cursor = Cursors.IBeam
        IDTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IDTextBox.Location = New Point(102, 41)
        IDTextBox.Name = "IDTextBox"
        IDTextBox.Size = New Size(45, 27)
        IDTextBox.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(16, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 20)
        Label5.TabIndex = 10
        Label5.Text = "Subject ID:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(SearchTextBox)
        Panel1.Controls.Add(SubjectDataGridView)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(19, 20)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(693, 331)
        Panel1.TabIndex = 2
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
        ' SubjectDataGridView
        ' 
        SubjectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        SubjectDataGridView.Location = New Point(16, 55)
        SubjectDataGridView.Name = "SubjectDataGridView"
        SubjectDataGridView.RowHeadersWidth = 51
        SubjectDataGridView.Size = New Size(661, 260)
        SubjectDataGridView.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(16, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 28)
        Label1.TabIndex = 1
        Label1.Text = "SUBJECT DATA"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(CreditHourComboBox)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(SubjectCodeTextBox)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(RemarksTextBox)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(DeleteBtn)
        GroupBox1.Controls.Add(ClearBtn)
        GroupBox1.Controls.Add(EditBtn)
        GroupBox1.Controls.Add(AddBtn)
        GroupBox1.Controls.Add(IDTextBox)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(SubjectNameTextBox)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(19, 357)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(693, 383)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Subject Information"
        ' 
        ' SubjectNameTextBox
        ' 
        SubjectNameTextBox.BackColor = Color.White
        SubjectNameTextBox.BorderStyle = BorderStyle.FixedSingle
        SubjectNameTextBox.Cursor = Cursors.IBeam
        SubjectNameTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SubjectNameTextBox.Location = New Point(123, 92)
        SubjectNameTextBox.Name = "SubjectNameTextBox"
        SubjectNameTextBox.Size = New Size(381, 27)
        SubjectNameTextBox.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(16, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 20)
        Label2.TabIndex = 4
        Label2.Text = "Subect Name:"
        ' 
        ' Panel
        ' 
        Panel.AutoScroll = True
        Panel.Controls.Add(Panel1)
        Panel.Controls.Add(GroupBox1)
        Panel.Dock = DockStyle.Fill
        Panel.Location = New Point(0, 0)
        Panel.Name = "Panel"
        Panel.Size = New Size(730, 760)
        Panel.TabIndex = 2
        ' 
        ' StaffSubject
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel)
        Name = "StaffSubject"
        Size = New Size(730, 760)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(SubjectDataGridView, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents CreditHourComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SubjectCodeTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RemarksTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SubjectDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SubjectNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel As Panel

End Class
