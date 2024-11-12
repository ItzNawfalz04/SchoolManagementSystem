Imports MySql.Data.MySqlClient

Public Class StaffUser
    Dim isAddMode As Boolean = False ' Track if we are in Add mode
    Dim isEditMode As Boolean = False ' Track if we are in Edit mode
    Dim originalUserID As Integer ' To store the selected User ID

    ' Form Load Event - Load user data into the DataGridView when the form loads
    Private Sub StaffUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserData()
        SetDefaultFormState()
    End Sub

    ' Method to load user data from the database into the DataGridView
    Private Sub LoadUserData()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "SELECT UserID, Name, Email, Birthday, Username, Password FROM users"
        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            UserDataGridView.DataSource = dataTable

            ' Set custom headers for the DataGridView columns
            UserDataGridView.Columns("UserID").HeaderText = "User ID"
            UserDataGridView.Columns("Name").HeaderText = "Full Name"
            UserDataGridView.Columns("Email").HeaderText = "Email Address"
            UserDataGridView.Columns("Birthday").HeaderText = "Date of Birth"
            UserDataGridView.Columns("Username").HeaderText = "Username"
            UserDataGridView.Columns("Password").HeaderText = "Password"
        End Using
    End Sub

    ' Set default form state (textboxes disabled, buttons in default state)
    Private Sub SetDefaultFormState()
        EnableInputControls(False)

        AddBtn.Text = "Add"
        AddBtn.BackColor = Color.Teal
        EditBtn.Text = "Edit"
        DeleteBtn.Visible = True
        ClearBtn.Visible = True
        EditBtn.Visible = True
        isAddMode = False
        isEditMode = False
    End Sub

    ' Enable or disable input controls (TextBoxes, DateTimePicker)
    Private Sub EnableInputControls(enable As Boolean)
        UserIDTextBox.Enabled = False ' UserID is auto-generated, so always disabled
        UserNameTextBox.Enabled = enable
        UserEmailTextBox.Enabled = enable
        BirthdayDateTimePicker.Enabled = enable
        UserUsernameTextBox.Enabled = enable
        UserPasswordTextBox.Enabled = enable
    End Sub

    ' Event to handle row selection in UserDataGridView - populate TextBoxes with selected user data
    Private Sub UserDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = UserDataGridView.Rows(e.RowIndex)

            If selectedRow IsNot Nothing AndAlso selectedRow.Cells("UserID").Value IsNot DBNull.Value Then
                UserIDTextBox.Text = selectedRow.Cells("UserID").Value.ToString()
                UserNameTextBox.Text = selectedRow.Cells("Name").Value.ToString()
                If selectedRow.Cells("Birthday").Value IsNot DBNull.Value Then
                    BirthdayDateTimePicker.Value = DateTime.Parse(selectedRow.Cells("Birthday").Value.ToString())
                End If
                UserEmailTextBox.Text = selectedRow.Cells("Email").Value.ToString()
                UserUsernameTextBox.Text = selectedRow.Cells("Username").Value.ToString()
                UserPasswordTextBox.Text = selectedRow.Cells("Password").Value.ToString()

                EnableInputControls(False) ' Disable controls initially
            End If
        End If
    End Sub

    ' Handle Add Button Click - Add or Save new user
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If Not isAddMode And Not isEditMode Then
            isAddMode = True
            EnableInputControls(True)
            ClearInputFields()

            AddBtn.Text = "Save"
            AddBtn.BackColor = Color.Red
            EditBtn.Text = "Cancel"
            DeleteBtn.Visible = False
            ClearBtn.Visible = False
        ElseIf isAddMode Then
            If ValidateInputFields() Then
                SaveNewUser()
                LoadUserData()
                SetDefaultFormState()
            End If
        End If
    End Sub

    ' Handle Edit Button Click - Edit or Cancel editing user
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If Not isEditMode And UserIDTextBox.Text <> "" Then
            isEditMode = True
            EnableInputControls(True)

            AddBtn.Text = "Save"
            AddBtn.BackColor = Color.Red
            EditBtn.Text = "Cancel"
            DeleteBtn.Visible = False
            ClearBtn.Visible = False
        ElseIf isEditMode Then
            If ValidateInputFields() Then
                SaveEditedUser()
                LoadUserData()
                SetDefaultFormState()
            End If
        End If
    End Sub

    ' Handle Delete Button Click - Delete selected user
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If UserIDTextBox.Text <> "" Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteUser()
                LoadUserData()
                ClearInputFields()
            End If
        End If
    End Sub

    ' Handle Clear Button Click - Clear all input fields
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ClearInputFields()
    End Sub

    ' Method to clear all input fields
    Private Sub ClearInputFields()
        UserIDTextBox.Clear()
        UserNameTextBox.Clear()
        BirthdayDateTimePicker.Value = DateTime.Now
        UserEmailTextBox.Clear()
        UserUsernameTextBox.Clear()
        UserPasswordTextBox.Clear()
    End Sub

    ' Method to validate input fields before saving
    Private Function ValidateInputFields() As Boolean
        If UserNameTextBox.Text = "" Or UserEmailTextBox.Text = "" Or
           UserUsernameTextBox.Text = "" Or UserPasswordTextBox.Text = "" Then
            MessageBox.Show("All fields must be filled!")
            Return False
        End If
        Return True
    End Function

    ' Method to save new user to the database
    Private Sub SaveNewUser()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "INSERT INTO users (Name, Email, Birthday, Username, Password) " &
                              "VALUES (@Name, @Email, @Birthday, @Username, @Password)"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Name", UserNameTextBox.Text)
                    cmd.Parameters.AddWithValue("@Email", UserEmailTextBox.Text)
                    cmd.Parameters.AddWithValue("@Birthday", BirthdayDateTimePicker.Value)
                    cmd.Parameters.AddWithValue("@Username", UserUsernameTextBox.Text)
                    cmd.Parameters.AddWithValue("@Password", UserPasswordTextBox.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("New user added successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error adding user: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Method to save edited user to the database
    Private Sub SaveEditedUser()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "UPDATE users SET Name=@Name, Email=@Email, Birthday=@Birthday, " &
                              "Username=@Username, Password=@Password WHERE UserID=@UserID"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@UserID", UserIDTextBox.Text)
                    cmd.Parameters.AddWithValue("@Name", UserNameTextBox.Text)
                    cmd.Parameters.AddWithValue("@Email", UserEmailTextBox.Text)
                    cmd.Parameters.AddWithValue("@Birthday", BirthdayDateTimePicker.Value)
                    cmd.Parameters.AddWithValue("@Username", UserUsernameTextBox.Text)
                    cmd.Parameters.AddWithValue("@Password", UserPasswordTextBox.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User data updated successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error updating user: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Method to delete user from the database
    Private Sub DeleteUser()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "DELETE FROM users WHERE UserID=@UserID"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@UserID", UserIDTextBox.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User deleted successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error deleting user: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
