Imports System.Threading

Public Class StaffMainForm
    Private staffDashboard As StaffDashboard
    Private staffClass As StaffClass
    Private staffStudent As StaffStudent
    Private staffTeacher As StaffTeacher
    Private staffSubject As StaffSubject
    Private staffStudentRegistration As StaffStudentRegistration
    Private staffUser As StaffUser

    ' New constructor accepting staff ID
    Public Sub New(staffId As Integer)
        InitializeComponent()
        ' Initialize StaffDashboard and StaffClass with the staff ID
        staffDashboard = New StaffDashboard(staffId)
        staffClass = New StaffClass()
        staffStudent = New StaffStudent()
        staffTeacher = New StaffTeacher()
        staffSubject = New StaffSubject()
        staffStudentRegistration = New StaffStudentRegistration()
        staffUser = New StaffUser
    End Sub

    Private Sub StaffMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the dashboard and class views to fill the form
        staffDashboard.Dock = DockStyle.Fill
        staffClass.Dock = DockStyle.Fill
        staffStudent.Dock = DockStyle.Fill
        staffTeacher.Dock = DockStyle.Fill
        staffSubject.Dock = DockStyle.Fill
        staffStudentRegistration.Dock = DockStyle.Fill
        staffUser.Dock = DockStyle.Fill
        Me.Controls.Add(staffDashboard)
        Me.Controls.Add(staffClass)
        Me.Controls.Add(staffStudent)
        Me.Controls.Add(staffTeacher)
        Me.Controls.Add(staffSubject)
        Me.Controls.Add(staffStudentRegistration)
        Me.Controls.Add(staffUser)

        ' Show the dashboard by default
        staffDashboard.BringToFront()
    End Sub

    ' Handle the SignOut Button Click to log out and return to the login form
    Private Sub SignOutBtn_Click(sender As Object, e As EventArgs) Handles SignOutBtn.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
        staffDashboard.BringToFront()
    End Sub

    Private Sub ClassButton_Click(sender As Object, e As EventArgs) Handles ClassButton.Click
        staffClass.BringToFront()
    End Sub

    Private Sub StudentButton_Click(sender As Object, e As EventArgs) Handles StudentButton.Click
        staffStudent.BringToFront()
    End Sub

    Private Sub TeacherButton_Click(sender As Object, e As EventArgs) Handles TeacherButton.Click
        staffTeacher.BringToFront()
    End Sub

    Private Sub SubjectButton_Click(sender As Object, e As EventArgs) Handles SubjectButton.Click
        staffSubject.BringToFront()
    End Sub

    Private Sub RegistrationButton_Click(sender As Object, e As EventArgs) Handles RegistrationButton.Click
        staffStudentRegistration.BringToFront()
    End Sub

    Private Sub USerButton_Click(sender As Object, e As EventArgs) Handles UserButton.Click
        staffUser.BringToFront()
    End Sub
End Class
