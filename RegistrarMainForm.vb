Public Class RegistrarMainForm
    Private Sub SignOutBtn_Click(sender As Object, e As EventArgs) Handles SignOutBtn.Click
        ' Sign Out back to login Page
        LoginForm.Show()
        Hide()
    End Sub
End Class