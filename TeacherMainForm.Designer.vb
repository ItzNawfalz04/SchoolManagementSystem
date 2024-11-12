<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Panel1 = New Panel()
        GradeSubmissionButton = New Button()
        DashboardButton = New Button()
        SignOutBtn = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(48, 173)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 28)
        Label1.TabIndex = 0
        Label1.Text = "Welcome, Teacher"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(GradeSubmissionButton)
        Panel1.Controls.Add(DashboardButton)
        Panel1.Controls.Add(SignOutBtn)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(270, 853)
        Panel1.TabIndex = 5
        ' 
        ' GradeSubmissionButton
        ' 
        GradeSubmissionButton.BackColor = Color.PaleTurquoise
        GradeSubmissionButton.FlatStyle = FlatStyle.Flat
        GradeSubmissionButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GradeSubmissionButton.ForeColor = Color.Black
        GradeSubmissionButton.Location = New Point(44, 274)
        GradeSubmissionButton.Name = "GradeSubmissionButton"
        GradeSubmissionButton.Size = New Size(186, 40)
        GradeSubmissionButton.TabIndex = 9
        GradeSubmissionButton.Text = "GRADE"
        GradeSubmissionButton.UseVisualStyleBackColor = False
        ' 
        ' DashboardButton
        ' 
        DashboardButton.BackColor = Color.PaleTurquoise
        DashboardButton.FlatStyle = FlatStyle.Flat
        DashboardButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DashboardButton.ForeColor = Color.Black
        DashboardButton.Location = New Point(44, 228)
        DashboardButton.Name = "DashboardButton"
        DashboardButton.Size = New Size(186, 40)
        DashboardButton.TabIndex = 8
        DashboardButton.Text = "DASHBOARD"
        DashboardButton.UseVisualStyleBackColor = False
        ' 
        ' SignOutBtn
        ' 
        SignOutBtn.Cursor = Cursors.Hand
        SignOutBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignOutBtn.ForeColor = Color.Black
        SignOutBtn.Image = My.Resources.Resources.logout_2_
        SignOutBtn.ImageAlign = ContentAlignment.MiddleLeft
        SignOutBtn.Location = New Point(78, 561)
        SignOutBtn.Name = "SignOutBtn"
        SignOutBtn.Size = New Size(113, 50)
        SignOutBtn.TabIndex = 7
        SignOutBtn.Text = "Log Out"
        SignOutBtn.TextAlign = ContentAlignment.MiddleRight
        SignOutBtn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(68, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(135, 135)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDarkDark
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1382, 853)
        Panel2.TabIndex = 6
        ' 
        ' TeacherMainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1382, 853)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "TeacherMainForm"
        Text = "TeacherMainForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DashboardButton As Button
    Friend WithEvents SignOutBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GradeSubmissionButton As Button
End Class
