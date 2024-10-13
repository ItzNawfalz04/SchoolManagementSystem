Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim connectionString = "server=localhost;user id=root;database=school_db;"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim username = UsernameTextBox.Text
                Dim password = PasswordTextBox.Text

                ' Check Registrar Table
                If CheckLogin(conn, "registrar", username, password) Then
                    MessageBox.Show("Login Successful as Registrar")
                    Dim registrarForm As New RegistrarMainForm
                    registrarForm.Show()
                    Hide()
                    Return
                End If

                ' Check Teacher Table
                If CheckLogin(conn, "teacher", username, password) Then
                    MessageBox.Show("Login Successful as Teacher")
                    Dim teacherForm As New TeacherMainForm
                    teacherForm.Show()
                    Hide()
                    Return
                End If

                ' Check Staff Table
                If CheckLogin(conn, "staff", username, password) Then
                    MessageBox.Show("Login Successful as Staff")
                    Dim staffForm As New StaffMainForm
                    staffForm.Show()
                    Hide()
                    Return
                End If

                MessageBox.Show("Invalid Username or Password")
            Catch ex As MySqlException
                MessageBox.Show("Error connecting to the database: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Function CheckLogin(conn As MySqlConnection, tableName As String, username As String, password As String) As Boolean
        Dim query As String = $"SELECT COUNT(*) FROM {tableName} WHERE username=@username AND password=@password"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return result > 0
        End Using
    End Function

    Private Sub ShowPasswordBtn_Click(sender As Object, e As EventArgs) Handles ShowPasswordBtn.Click
        ' Check if the PasswordTextBox is currently displaying dots (masked)
        If PasswordTextBox.PasswordChar = "•"c Then
            ' Show the password (no masking)
            PasswordTextBox.PasswordChar = ControlChars.NullChar
        Else
            ' Mask the password again
            PasswordTextBox.PasswordChar = "•"c
        End If
    End Sub
End Class
