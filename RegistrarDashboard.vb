Imports MySql.Data.MySqlClient

Public Class RegistrarDashboard
    Dim editMode As Boolean = False ' To track if we are in edit mode
    Dim originalName As String ' To store original data
    Dim originalUsername As String
    Dim originalPassword As String

    ' Form Load Event - Show data when the form loads
    Private Sub RegistrarDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserData()
        BackBtn.Visible = False ' Hide the back button initially
    End Sub

    ' Method to load user data from the database (for user id = 1)
    Private Sub LoadUserData()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT name, username, password FROM registrar WHERE id = 1"
                Using cmd As New MySqlCommand(query, conn)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Store original data to revert if needed
                        originalName = reader("name").ToString()
                        originalUsername = reader("username").ToString()
                        originalPassword = reader("password").ToString()

                        ' Display data in the textboxes
                        NameTextBox.Text = originalName
                        UsernameTextBox.Text = originalUsername
                        PasswordTextBox.Text = originalPassword
                    End If
                End Using
                ' Disable textboxes initially
                EnableTextBoxes(False)
            Catch ex As MySqlException
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Enable or disable the textboxes based on the parameter
    Private Sub EnableTextBoxes(enable As Boolean)
        NameTextBox.Enabled = enable
        UsernameTextBox.Enabled = enable
        PasswordTextBox.Enabled = enable
    End Sub

    ' Toggle Edit Mode when Edit Button is clicked
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If Not editMode Then
            ' Enter Edit Mode
            EnableTextBoxes(True)
            EditBtn.Text = "Save"
            EditBtn.BackColor = Color.Red
            BackBtn.Visible = True ' Show the back button in edit mode
            editMode = True
        Else
            ' Save the data and exit Edit Mode
            SaveUserData()
            EnableTextBoxes(False)
            EditBtn.Text = "Edit"
            EditBtn.BackColor = Color.Teal
            BackBtn.Visible = False ' Hide the back button after saving
            editMode = False
        End If
    End Sub

    ' Method to save edited data back to the database
    Private Sub SaveUserData()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "UPDATE registrar SET name=@name, username=@username, password=@password WHERE id = 1"
                Using cmd As New MySqlCommand(query, conn)
                    ' Update parameters with the textbox values
                    cmd.Parameters.AddWithValue("@name", NameTextBox.Text)
                    cmd.Parameters.AddWithValue("@username", UsernameTextBox.Text)
                    cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User data saved successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error saving data: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Cancel Editing Mode and revert changes when Back Button is clicked
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        ' Revert the textboxes to the original values
        NameTextBox.Text = originalName
        UsernameTextBox.Text = originalUsername
        PasswordTextBox.Text = originalPassword

        ' Disable textboxes and return to view mode
        EnableTextBoxes(False)
        EditBtn.Text = "Edit"
        EditBtn.BackColor = Color.Teal
        BackBtn.Visible = False ' Hide the back button
        editMode = False
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
