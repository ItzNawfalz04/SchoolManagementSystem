Public Class RegistrarMainForm
    Private registrarDashboard As New RegistrarDashboard
    Private registrarStaff As New RegistrarStaff
    Private userId As Integer
    Private Sub SignOutBtn_Click(sender As Object, e As EventArgs) Handles SignOutBtn.Click
        ' Sign Out back to login Page
        LoginForm.Show
        Hide
    End Sub

    Private Sub RegistrarMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            RegistrarDashboard.Dock = DockStyle.Fill
            RegistrarStaff.Dock = DockStyle.Fill
            Me.Controls.Add(registrarDashboard)
            Me.Controls.Add(registrarStaff)
        End Sub

    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
        registrarDashboard.BringToFront
    End Sub

    Private Sub StaffButton_Click(sender As Object, e As EventArgs) Handles StaffButton.Click
        RegistrarStaff.BringToFront
    End Sub
End Class