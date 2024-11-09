Imports MySql.Data.MySqlClient

Public Class RegistrarDashboard
    Private connectionString As String = "server=localhost;user id=root;database=school_db;"
    Private isEditing As Boolean = False

    Private Sub RegistrarDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserData()
        LoadCounts() ' Load counts of students, teachers, and staff
        ToggleEditMode(False)
    End Sub

    Private Sub LoadUserData()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT name, username, password FROM registrar WHERE username=@username"
                Using cmd As New MySqlCommand(query, conn)
                    ' Assuming you have the username stored from login
                    cmd.Parameters.AddWithValue("@username", LoginForm.UsernameTextBox.Text)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            NameTextBox.Text = reader("name").ToString()
                            UsernameTextBox.Text = reader("username").ToString()
                            PasswordTextBox.Text = reader("password").ToString()
                        End If
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error loading user data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadCounts()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' Get total number of students
                Dim studentCountQuery As String = "SELECT COUNT(*) FROM student"
                Using cmd As New MySqlCommand(studentCountQuery, conn)
                    Dim studentCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    StudentNumber.Text = studentCount.ToString()
                End Using

                ' Get total number of teachers
                Dim teacherCountQuery As String = "SELECT COUNT(*) FROM teacher"
                Using cmd As New MySqlCommand(teacherCountQuery, conn)
                    Dim teacherCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    TeacherNumber.Text = teacherCount.ToString()
                End Using

                ' Get total number of staff
                Dim staffCountQuery As String = "SELECT COUNT(*) FROM staff"
                Using cmd As New MySqlCommand(staffCountQuery, conn)
                    Dim staffCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    StaffNumber.Text = staffCount.ToString()
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Error loading counts: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If isEditing Then
            SaveUserData()
            ToggleEditMode(False)
        Else
            ToggleEditMode(True)
        End If
    End Sub

    Private Sub SaveUserData()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "UPDATE registrar SET name=@name, username=@username, password=@password WHERE username=@originalUsername"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", NameTextBox.Text)
                    cmd.Parameters.AddWithValue("@username", UsernameTextBox.Text)
                    cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text)
                    cmd.Parameters.AddWithValue("@originalUsername", LoginForm.UsernameTextBox.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User  data saved successfully.")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error saving user data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ToggleEditMode(editing As Boolean)
        isEditing = editing
        NameTextBox.Enabled = editing
        UsernameTextBox.Enabled = editing
        PasswordTextBox.Enabled = editing
        BackBtn.Visible = editing
        If editing Then
            EditBtn.BackColor = Color.Red
            EditBtn.Text = "Save"
        Else
            EditBtn.BackColor = Color.Teal
            EditBtn.Text = "Edit"
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        LoadUserData()
        ToggleEditMode(False)
    End Sub

    ' Toggle Password Visibility
    Private Sub ShowPasswordBtn_Click(sender As Object, e As EventArgs) Handles ShowPasswordBtn.Click
        If PasswordTextBox.PasswordChar = "•"c Then
            ' Show the password
            PasswordTextBox.PasswordChar = ControlChars.NullChar
        Else
            ' Mask the password
            PasswordTextBox.PasswordChar = "•"c
        End If
    End Sub
End Class
