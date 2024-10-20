<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Class
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
        Label1 = New Label()
        subject = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        DataGridView1 = New DataGridView()
        GroupBox1 = New GroupBox()
        clrBtn = New Button()
        FormComboBox1 = New ComboBox()
        Label2 = New Label()
        dltBtn = New Button()
        updBtn = New Button()
        viewBtn = New Button()
        addBtn = New Button()
        srcBtn = New Button()
        Panel1 = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Teal
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(18, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 37)
        Label1.TabIndex = 0
        Label1.Text = "Class List"
        ' 
        ' subject
        ' 
        subject.AutoSize = True
        subject.Font = New Font("Segoe UI", 9F)
        subject.Location = New Point(21, 32)
        subject.Name = "subject"
        subject.Size = New Size(52, 15)
        subject.TabIndex = 1
        subject.Text = "Subject :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.Location = New Point(21, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 15)
        Label3.TabIndex = 2
        Label3.Text = "Teacher :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F)
        Label4.Location = New Point(21, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 3
        Label4.Text = "Location :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 9F)
        TextBox1.Location = New Point(119, 29)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(266, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 9F)
        TextBox2.Location = New Point(119, 82)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(266, 23)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 9F)
        TextBox3.Location = New Point(119, 135)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(266, 23)
        TextBox3.TabIndex = 6
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(18, 35)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1058, 319)
        DataGridView1.TabIndex = 7
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(clrBtn)
        GroupBox1.Controls.Add(FormComboBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(subject)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(dltBtn)
        GroupBox1.Controls.Add(updBtn)
        GroupBox1.Controls.Add(viewBtn)
        GroupBox1.Controls.Add(addBtn)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(57, 441)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1058, 251)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Class Information"
        ' 
        ' clrBtn
        ' 
        clrBtn.BackColor = Color.Red
        clrBtn.Location = New Point(512, 196)
        clrBtn.Name = "clrBtn"
        clrBtn.Size = New Size(129, 27)
        clrBtn.TabIndex = 10
        clrBtn.Text = "Clear"
        clrBtn.UseVisualStyleBackColor = False
        ' 
        ' FormComboBox1
        ' 
        FormComboBox1.FormattingEnabled = True
        FormComboBox1.Items.AddRange(New Object() {"Form 1", "Form 2", "Form 3", "Form 4", "Form 5"})
        FormComboBox1.Location = New Point(119, 185)
        FormComboBox1.Name = "FormComboBox1"
        FormComboBox1.Size = New Size(121, 28)
        FormComboBox1.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(21, 192)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 12
        Label2.Text = "Form :"
        ' 
        ' dltBtn
        ' 
        dltBtn.BackColor = Color.Red
        dltBtn.Font = New Font("Segoe UI", 9.75F)
        dltBtn.Location = New Point(512, 159)
        dltBtn.Name = "dltBtn"
        dltBtn.Size = New Size(129, 31)
        dltBtn.TabIndex = 11
        dltBtn.Text = "Delete Selected"
        dltBtn.UseVisualStyleBackColor = False
        ' 
        ' updBtn
        ' 
        updBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        updBtn.Font = New Font("Segoe UI", 9.75F)
        updBtn.Location = New Point(512, 122)
        updBtn.Name = "updBtn"
        updBtn.Size = New Size(129, 31)
        updBtn.TabIndex = 10
        updBtn.Text = "Update Selected"
        updBtn.UseVisualStyleBackColor = False
        ' 
        ' viewBtn
        ' 
        viewBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        viewBtn.Font = New Font("Segoe UI", 9.75F)
        viewBtn.Location = New Point(512, 85)
        viewBtn.Name = "viewBtn"
        viewBtn.Size = New Size(129, 31)
        viewBtn.TabIndex = 8
        viewBtn.Text = "View"
        viewBtn.UseVisualStyleBackColor = False
        ' 
        ' addBtn
        ' 
        addBtn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        addBtn.Font = New Font("Segoe UI", 9.75F)
        addBtn.ForeColor = SystemColors.ControlText
        addBtn.Location = New Point(512, 48)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(129, 31)
        addBtn.TabIndex = 7
        addBtn.Text = "Add"
        addBtn.UseVisualStyleBackColor = False
        ' 
        ' srcBtn
        ' 
        srcBtn.BackColor = Color.SpringGreen
        srcBtn.Font = New Font("Segoe UI", 9.75F)
        srcBtn.ForeColor = SystemColors.ControlText
        srcBtn.Location = New Point(947, 360)
        srcBtn.Name = "srcBtn"
        srcBtn.Size = New Size(129, 31)
        srcBtn.TabIndex = 9
        srcBtn.Text = "Search"
        srcBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(srcBtn)
        Panel1.Location = New Point(39, 26)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1089, 397)
        Panel1.TabIndex = 9
        ' 
        ' Registrar_Class
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Name = "Registrar_Class"
        Size = New Size(1190, 725)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents subject As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dltBtn As Button
    Friend WithEvents updBtn As Button
    Friend WithEvents srcBtn As Button
    Friend WithEvents viewBtn As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents FormComboBox1 As ComboBox
    Friend WithEvents clrBtn As Button

End Class
