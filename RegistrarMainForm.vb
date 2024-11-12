Imports System.Threading

Public Class RegistrarMainForm
    Private registrarDashboard As New RegistrarDashboard
    Private registrarStaff As New RegistrarStaff
    Private registrarTeacher As New RegistrarTeacher
    Private registrarClass As New RegistrarClass
    Private registrarStudent As New RegistrarStudent
    Private registrarSubject As New RegistrarSubject
    Private registrarRegistration As New RegistrarRegistration
    Private userId As Integer
    Private Sub SignOutBtn_Click(sender As Object, e As EventArgs) Handles SignOutBtn.Click
        ' Sign Out back to login Page
        LoginForm.Show
        Hide
    End Sub

    Private Sub RegistrarMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        registrarDashboard.Dock = DockStyle.Fill
        registrarStaff.Dock = DockStyle.Fill
        registrarTeacher.Dock = DockStyle.Fill
        registrarClass.Dock = DockStyle.Fill
        registrarStudent.Dock = DockStyle.Fill
        registrarSubject.Dock = DockStyle.Fill
        registrarRegistration.Dock = DockStyle.Fill
        Me.Controls.Add(registrarDashboard)
        Me.Controls.Add(registrarStaff)
        Me.Controls.Add(registrarTeacher)
        Me.Controls.Add(registrarClass)
        Me.Controls.Add(registrarStudent)
        Me.Controls.Add(registrarSubject)
        Me.Controls.Add(registrarRegistration)

        registrarDashboard.BringToFront()
    End Sub

    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
        registrarDashboard.BringToFront()
    End Sub

    Private Sub StaffButton_Click(sender As Object, e As EventArgs) Handles StaffButton.Click
        registrarStaff.BringToFront()
    End Sub

    Private Sub TeacherButton_Click(sender As Object, e As EventArgs) Handles TeacherButton.Click
        registrarTeacher.BringToFront()
    End Sub

    Private Sub ClassButton_Click(sender As Object, e As EventArgs) Handles ClassButton.Click
        registrarClass.BringToFront()
    End Sub

    Private Sub StudentButton_Click(sender As Object, e As EventArgs) Handles StudentButton.Click
        registrarStudent.BringToFront()
    End Sub

    Private Sub SubjectButton_Click(sender As Object, e As EventArgs) Handles SubjectButton.Click
        registrarSubject.BringToFront()
    End Sub

    Private Sub RegistrationButton_Click(sender As Object, e As EventArgs) Handles RegistrationButton.Click
        registrarRegistration.BringToFront()
    End Sub
End Class