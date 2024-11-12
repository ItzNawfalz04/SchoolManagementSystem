Public Class TeacherMainForm
    Private teacherDashboard As TeacherDashboard
    Private teacherGradeSubmission As TeacherGradeSubbmission

    ' New constructor accepting Teacher ID
    Public Sub New(teacherId As Integer)
        InitializeComponent()
        ' Initialize TeacherDashboard and TeacherClass with the teacher ID
        teacherDashboard = New TeacherDashboard(teacherId)
        teacherGradeSubmission = New TeacherGradeSubbmission()

    End Sub

    Private Sub TeacherMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the dashboard and class views to fill the form
        teacherDashboard.Dock = DockStyle.Fill
        teacherGradeSubmission.Dock = DockStyle.Fill
        ' teacherStudent.Dock = DockStyle.Fill
        ' teacherSubject.Dock = DockStyle.Fill
        ' teacherUser.Dock = DockStyle.Fill

        ' Add the controls to the main form
        Me.Controls.Add(teacherDashboard)
        Me.Controls.Add(teacherGradeSubmission)
        ' Me.Controls.Add(teacherStudent)
        ' Me.Controls.Add(teacherSubject)
        ' Me.Controls.Add(teacherUser)

        ' Show the dashboard by default
        teacherDashboard.BringToFront()
    End Sub

    ' Handle the SignOut Button Click to log out and return to the login form
    Private Sub SignOutBtn_Click(sender As Object, e As EventArgs) Handles SignOutBtn.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    ' Handle navigation buttons to switch views
    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
        teacherDashboard.BringToFront()
    End Sub

    Private Sub GradeSubmissionButton_Click(sender As Object, e As EventArgs) Handles GradeSubmissionButton.Click
        teacherGradeSubmission.BringToFront()
    End Sub
End Class