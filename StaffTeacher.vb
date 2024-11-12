Imports MySql.Data.MySqlClient
Imports System.IO

Public Class StaffTeacher
    Dim isAddMode As Boolean = False ' Track if we are in Add mode
    Dim isEditMode As Boolean = False ' Track if we are in Edit mode
    Dim originalStaffID As Integer ' To store the selected Teacher ID

    ' Form Load Event - Load Teacher data into the DataGridView when the form loads
    Private Sub RegistrarTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTeacherData()
        SetDefaultFormState()
    End Sub

    ' Method to load staff data from the database into the DataGridView
    Private Sub LoadTeacherData()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "SELECT TeacherID, name, gender, birthday, email, phone, ic, username, password, picture FROM teacher"
        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            TeacherDataGridView.DataSource = dataTable
        End Using
    End Sub

    ' Set default form state (textboxes disabled, buttons in default state)
    Private Sub SetDefaultFormState()
        ' Disable all input controls
        EnableInputControls(False)

        ' Hide picture-related buttons
        ImportButton.Visible = False
        RemoveButton.Visible = False

        ' Set default button visibility and text
        AddBtn.Text = "Add"
        AddBtn.BackColor = Color.Teal
        EditBtn.Text = "Edit"
        DeleteBtn.Visible = True
        ClearBtn.Visible = True
        EditBtn.Visible = True
        isAddMode = False
        isEditMode = False

        ' Set default picture
        TeacherPictureBox.Image = My.Resources._default
        TeacherPictureBox.Tag = Nothing
    End Sub

    ' Enable or disable input controls (TextBoxes, ComboBox, DateTimePicker)
    Private Sub EnableInputControls(enable As Boolean)
        TeacherIDTextBox.Enabled = False ' TeacherID is auto-generated, so always disabled
        TeacherNameTextBox.Enabled = enable
        GenderComboBox.Enabled = enable
        BirthdayDateTimePicker.Enabled = enable
        TeacherEmailTextBox.Enabled = enable
        PhoneTextBox.Enabled = enable
        TeacherICTextBox.Enabled = enable
        TeacherUsernameTextBox.Enabled = enable
        TeacherPasswordTextBox.Enabled = enable

        ' Show/hide Import and Remove buttons
        ImportButton.Visible = enable
        RemoveButton.Visible = enable
    End Sub

    ' Event to handle row selection in TeacherDataGridView - populate TextBoxes with selected teacher data
    Private Sub TeacherDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TeacherDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = TeacherDataGridView.Rows(e.RowIndex)

            If selectedRow IsNot Nothing AndAlso selectedRow.Cells("TeacherID").Value IsNot DBNull.Value Then
                ' Populate the TextBoxes with the selected Teacher data
                TeacherIDTextBox.Text = selectedRow.Cells("TeacherID").Value.ToString()
                TeacherNameTextBox.Text = selectedRow.Cells("name").Value.ToString()
                GenderComboBox.Text = selectedRow.Cells("gender").Value.ToString()
                If selectedRow.Cells("birthday").Value IsNot DBNull.Value Then
                    BirthdayDateTimePicker.Value = DateTime.Parse(selectedRow.Cells("birthday").Value.ToString())
                End If
                TeacherEmailTextBox.Text = selectedRow.Cells("email").Value.ToString()
                PhoneTextBox.Text = selectedRow.Cells("phone").Value.ToString()
                TeacherICTextBox.Text = selectedRow.Cells("ic").Value.ToString()
                TeacherUsernameTextBox.Text = selectedRow.Cells("username").Value.ToString()
                TeacherPasswordTextBox.Text = selectedRow.Cells("password").Value.ToString()

                ' Load picture from the relative path stored in the database
                If selectedRow.Cells("picture").Value IsNot DBNull.Value Then
                    Dim relativeImagePath As String = selectedRow.Cells("picture").Value.ToString()
                    Dim fullImagePath As String = Path.Combine(Application.StartupPath, relativeImagePath)
                    If File.Exists(fullImagePath) Then
                        TeacherPictureBox.Image = Image.FromFile(fullImagePath)
                        TeacherPictureBox.Tag = fullImagePath
                    Else
                        TeacherPictureBox.Image = My.Resources._default
                        TeacherPictureBox.Tag = Nothing
                    End If
                Else
                    TeacherPictureBox.Image = My.Resources._default
                    TeacherPictureBox.Tag = Nothing
                End If


                EnableInputControls(False) ' Disable controls initially
            End If
        End If
    End Sub

    ' Handle Add Button Click - Add or Save new teacher
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If Not isAddMode And Not isEditMode Then
            ' Enter Add Mode
            isAddMode = True
            EnableInputControls(True)
            ClearInputFields() ' Clear input fields for new entry

            AddBtn.Text = "Save"
            AddBtn.BackColor = Color.Red
            EditBtn.Text = "Cancel"
            DeleteBtn.Visible = False
            ClearBtn.Visible = False
        ElseIf isAddMode Then
            ' Save new teacher to the database
            If ValidateInputFields() Then
                SaveNewTeacher()
                LoadTeacherData() ' Reload data after adding
                SetDefaultFormState() ' Reset the form
            End If
        ElseIf isEditMode Then
            ' Save edited teacher to the database
            If ValidateInputFields() Then
                SaveEditedTeacher()
                LoadTeacherData() ' Reload data after editing
                SetDefaultFormState() ' Reset the form
            End If
        End If
    End Sub

    ' Handle Edit Button Click - Edit or Cancel editing teacher
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If Not isEditMode And TeacherIDTextBox.Text <> "" Then
            ' Enter Edit Mode
            isEditMode = True
            EnableInputControls(True)

            AddBtn.Text = "Save"
            AddBtn.BackColor = Color.Red
            EditBtn.Text = "Cancel"
            DeleteBtn.Visible = False
            ClearBtn.Visible = False
        ElseIf isEditMode Then
            If EditBtn.Text = "Cancel" Then
                ' Cancel editing mode
                Dim selectedRow As DataGridViewRow = TeacherDataGridView.Rows(TeacherDataGridView.SelectedCells(0).RowIndex)
                TeacherIDTextBox.Text = selectedRow.Cells("TeacherID").Value.ToString()
                TeacherNameTextBox.Text = selectedRow.Cells("name").Value.ToString()
                GenderComboBox.Text = selectedRow.Cells("gender").Value.ToString()
                BirthdayDateTimePicker.Value = DateTime.Parse(selectedRow.Cells("birthday").Value.ToString())
                TeacherEmailTextBox.Text = selectedRow.Cells("email").Value.ToString()
                PhoneTextBox.Text = selectedRow.Cells("phone").Value.ToString()
                TeacherICTextBox.Text = selectedRow.Cells("ic").Value.ToString()
                TeacherUsernameTextBox.Text = selectedRow.Cells("username").Value.ToString()
                TeacherPasswordTextBox.Text = selectedRow.Cells("password").Value.ToString()
                SetDefaultFormState()
            Else
                ' Save edited teacher to the database
                If ValidateInputFields() Then
                    SaveEditedTeacher()
                    LoadTeacherData() ' Reload data after editing
                    SetDefaultFormState() ' Reset the form
                End If
            End If
        ElseIf isAddMode Then
            ' Cancel Add mode
            ClearInputFields()
            SetDefaultFormState()
        End If
    End Sub

    ' Handle Delete Button Click - Delete selected teacher
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If TeacherIDTextBox.Text <> "" Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this teacher?", "Confirm Delete", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteTeacher()
                LoadTeacherData() ' Reload data after deleting
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
        TeacherIDTextBox.Clear()
        TeacherNameTextBox.Clear()
        GenderComboBox.SelectedIndex = -1
        BirthdayDateTimePicker.Value = DateTime.Now
        TeacherEmailTextBox.Clear()
        PhoneTextBox.Clear()
        TeacherICTextBox.Clear()
        TeacherUsernameTextBox.Clear()
        TeacherPasswordTextBox.Clear()
    End Sub

    ' Method to validate input fields before saving
    Private Function ValidateInputFields() As Boolean
        If TeacherNameTextBox.Text = "" Or GenderComboBox.SelectedIndex = -1 Or TeacherEmailTextBox.Text = "" Or
           PhoneTextBox.Text = "" Or TeacherUsernameTextBox.Text = "" Or TeacherPasswordTextBox.Text = "" Then
            MessageBox.Show("All fields must be filled!")
            Return False
        End If
        Return True
    End Function

    ' Method to save new staff to the database
    Private Sub SaveNewTeacher()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "INSERT INTO teacher (name, gender, birthday, email, phone, ic, username, password, picture) " &
                              "VALUES (@name, @gender, @birthday, @email, @phone, @ic, @username, @password, @picture)"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", TeacherNameTextBox.Text)
                    cmd.Parameters.AddWithValue("@gender", GenderComboBox.Text)
                    cmd.Parameters.AddWithValue("@birthday", BirthdayDateTimePicker.Value)
                    cmd.Parameters.AddWithValue("@email", TeacherEmailTextBox.Text)
                    cmd.Parameters.AddWithValue("@phone", PhoneTextBox.Text)
                    cmd.Parameters.AddWithValue("@ic", TeacherICTextBox.Text)
                    cmd.Parameters.AddWithValue("@username", TeacherUsernameTextBox.Text)
                    cmd.Parameters.AddWithValue("@password", TeacherPasswordTextBox.Text)
                    Dim imagePath As String = SaveImage(TeacherPictureBox.Image)
                    cmd.Parameters.AddWithValue("@picture", imagePath)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("New teacher added successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error adding teacher: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Method to save edited staff to the database
    Private Sub SaveEditedTeacher()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "UPDATE teacher SET name=@name, gender=@gender, birthday=@birthday, email=@email, phone=@phone, " &
                              "ic=@ic, username=@username, password=@password, picture = @picture WHERE TeacherID=@TeacherID"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TeacherID", TeacherIDTextBox.Text)
                    cmd.Parameters.AddWithValue("@name", TeacherNameTextBox.Text)
                    cmd.Parameters.AddWithValue("@gender", GenderComboBox.Text)
                    cmd.Parameters.AddWithValue("@birthday", BirthdayDateTimePicker.Value)
                    cmd.Parameters.AddWithValue("@email", TeacherEmailTextBox.Text)
                    cmd.Parameters.AddWithValue("@phone", PhoneTextBox.Text)
                    cmd.Parameters.AddWithValue("@ic", TeacherICTextBox.Text)
                    cmd.Parameters.AddWithValue("@username", TeacherUsernameTextBox.Text)
                    cmd.Parameters.AddWithValue("@password", TeacherPasswordTextBox.Text)
                    Dim imagePath As String = SaveImage(TeacherPictureBox.Image)
                    cmd.Parameters.AddWithValue("@picture", imagePath)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Teacher data updated successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error updating teacher: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Method to delete staff from the database
    Private Sub DeleteTeacher()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "DELETE FROM teacher WHERE TeacherID=@TeacherID"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TeacherID", TeacherIDTextBox.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Teacher deleted successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error deleting teacher: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Toggle Password Visibility
    Private Sub ShowPasswordBtn_Click(sender As Object, e As EventArgs) Handles ShowPasswordBtn.Click
        If TeacherPasswordTextBox.PasswordChar = "•"c Then
            ' Show the password
            TeacherPasswordTextBox.PasswordChar = ControlChars.NullChar
        Else
            ' Mask the password
            TeacherPasswordTextBox.PasswordChar = "•"c
        End If
    End Sub

    Private Sub Panel_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel.Scroll
        ' Ensure Smooth Scrolling
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    ' Method to filter staff data based on search text
    Private Sub FilterTeacherData(searchText As String)
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "SELECT TeacherID, name, gender, birthday, email, phone, username, ic, password FROM teacher " &
                              "WHERE TeacherID LIKE @searchText OR ic LIKE @searchText OR gender LIKE @searchText OR name LIKE @searchText OR email LIKE @searchText OR phone LIKE @searchText"
        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            TeacherDataGridView.DataSource = dataTable
        End Using
    End Sub

    ' Handle SearchTextBox TextChanged event - Filter teacher data as user types
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchTextBox.Text <> "" Then
            FilterTeacherData(SearchTextBox.Text)
        Else
            LoadTeacherData() ' Reload all teacher data if search text is empty
        End If
    End Sub

    ' Handle Import Button Click - Import picture for teacher
    Private Sub ImportBtn_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim sourceFilePath As String = openFileDialog.FileName
                Dim img As Image = Image.FromFile(sourceFilePath)
                TeacherPictureBox.Image = img
                TeacherPictureBox.Tag = SaveImage(img)
            End If
        End Using
    End Sub

    ' Handle Remove Button Click - Remove picture from TeachePictureBox
    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        TeacherPictureBox.Image = My.Resources._default
        TeacherPictureBox.Tag = Nothing ' Clear the stored path
    End Sub

    ' Method to save an image to a designated folder within the project and return the relative path
    Private Function SaveImage(img As Image) As String
        Dim folderPath As String = Path.Combine(Application.StartupPath, "TeacherImages")
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If
        Dim fileName As String = Guid.NewGuid().ToString() & ".jpg"
        Dim filePath As String = Path.Combine(folderPath, fileName)
        img.Save(filePath, Imaging.ImageFormat.Jpeg)

        ' Return the relative path instead of the full path
        Dim relativePath As String = Path.Combine("TeacherImages", fileName)
        Return relativePath
    End Function
End Class
