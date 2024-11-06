<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarClass
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
        Panel1 = New Panel()
        SearchTextBox = New TextBox()
        ClassDataGridView = New DataGridView()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        RemarksTextBox = New TextBox()
        Label3 = New Label()
        DeleteBtn = New Button()
        ClearBtn = New Button()
        EditBtn = New Button()
        AddBtn = New Button()
        ClassTeacherComboBox = New ComboBox()
        Label7 = New Label()
        ClassIDTextBox = New TextBox()
        Label5 = New Label()
        ClassNameTextBox = New TextBox()
        Label2 = New Label()
        Panel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(ClassDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
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
        Panel.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(SearchTextBox)
        Panel1.Controls.Add(ClassDataGridView)
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
        ' ClassDataGridView
        ' 
        ClassDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ClassDataGridView.Location = New Point(16, 55)
        ClassDataGridView.Name = "ClassDataGridView"
        ClassDataGridView.RowHeadersWidth = 51
        ClassDataGridView.Size = New Size(661, 260)
        ClassDataGridView.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(16, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 28)
        Label1.TabIndex = 1
        Label1.Text = "CLASS DATA"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RemarksTextBox)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(DeleteBtn)
        GroupBox1.Controls.Add(ClearBtn)
        GroupBox1.Controls.Add(EditBtn)
        GroupBox1.Controls.Add(AddBtn)
        GroupBox1.Controls.Add(ClassTeacherComboBox)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(ClassIDTextBox)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(ClassNameTextBox)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(19, 357)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(693, 383)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Class Information"
        ' 
        ' RemarksTextBox
        ' 
        RemarksTextBox.BackColor = Color.White
        RemarksTextBox.BorderStyle = BorderStyle.FixedSingle
        RemarksTextBox.Cursor = Cursors.IBeam
        RemarksTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RemarksTextBox.Location = New Point(111, 139)
        RemarksTextBox.Multiline = True
        RemarksTextBox.Name = "RemarksTextBox"
        RemarksTextBox.Size = New Size(393, 181)
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
        ClearBtn.BackColor = Color.Teal
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
        ' ClassTeacherComboBox
        ' 
        ClassTeacherComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        ClassTeacherComboBox.FormattingEnabled = True
        ClassTeacherComboBox.Location = New Point(272, 41)
        ClassTeacherComboBox.Name = "ClassTeacherComboBox"
        ClassTeacherComboBox.Size = New Size(232, 28)
        ClassTeacherComboBox.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(166, 43)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 20)
        Label7.TabIndex = 15
        Label7.Text = "Class Teacher:"
        ' 
        ' ClassIDTextBox
        ' 
        ClassIDTextBox.BackColor = Color.White
        ClassIDTextBox.BorderStyle = BorderStyle.FixedSingle
        ClassIDTextBox.Cursor = Cursors.IBeam
        ClassIDTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ClassIDTextBox.Location = New Point(86, 41)
        ClassIDTextBox.Name = "ClassIDTextBox"
        ClassIDTextBox.Size = New Size(45, 27)
        ClassIDTextBox.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(16, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 20)
        Label5.TabIndex = 10
        Label5.Text = "Class ID:"
        ' 
        ' ClassNameTextBox
        ' 
        ClassNameTextBox.BackColor = Color.White
        ClassNameTextBox.BorderStyle = BorderStyle.FixedSingle
        ClassNameTextBox.Cursor = Cursors.IBeam
        ClassNameTextBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ClassNameTextBox.Location = New Point(111, 92)
        ClassNameTextBox.Name = "ClassNameTextBox"
        ClassNameTextBox.Size = New Size(393, 27)
        ClassNameTextBox.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(16, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 4
        Label2.Text = "Class Name:"
        ' 
        ' RegistrarClass
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel)
        Name = "RegistrarClass"
        Size = New Size(730, 760)
        Panel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(ClassDataGridView, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents ClassDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents ClassTeacherComboBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ClassIDTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ClassNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RemarksTextBox As TextBox
    Friend WithEvents Label3 As Label

End Class
