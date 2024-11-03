Imports MySql.Data.MySqlClient
Imports System.IO

Public Class RegistrarStaff
    Dim isAddMode As Boolean = False ' Track if we are in Add mode
    Dim isEditMode As Boolean = False ' Track if we are in Edit mode
    Dim originalStaffID As Integer ' To store the selected staff ID

    ' Form Load Event - Load staff data into the DataGridView when the form loads
    Private Sub RegistrarStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaffData()
        SetDefaultFormState()
    End Sub

    ' Method to load staff data from the database into the DataGridView
    Private Sub LoadStaffData()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "SELECT id, name, gender, birthday, email, phone, ic, username, password, picture FROM staff"
        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            StaffDataGridView.DataSource = dataTable
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
        StaffPictureBox.Image = My.Resources._default
        StaffPictureBox.Tag = Nothing
    End Sub

    ' Enable or disable input controls (TextBoxes, ComboBox, DateTimePicker)
    Private Sub EnableInputControls(enable As Boolean)
        StaffIDTextBox.Enabled = False ' StaffID is auto-generated, so always disabled
        StaffNameTextBox.Enabled = enable
        GenderComboBox.Enabled = enable
        BirthdayDateTimePicker.Enabled = enable
        StaffEmailTextBox.Enabled = enable
        PhoneTextBox.Enabled = enable
        StaffICTextBox.Enabled = enable
        StaffUsernameTextBox.Enabled = enable
        StaffPasswordTextBox.Enabled = enable

        ' Show/hide Import and Remove buttons
        ImportButton.Visible = enable
        RemoveButton.Visible = enable
    End Sub

    ' Event to handle row selection in StaffDataGridView - populate TextBoxes with selected staff data
    Private Sub StaffDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StaffDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = StaffDataGridView.Rows(e.RowIndex)

            If selectedRow IsNot Nothing AndAlso selectedRow.Cells("id").Value IsNot DBNull.Value Then
                ' Populate the TextBoxes with the selected staff data
                StaffIDTextBox.Text = selectedRow.Cells("id").Value.ToString()
                StaffNameTextBox.Text = selectedRow.Cells("name").Value.ToString()
                GenderComboBox.Text = selectedRow.Cells("gender").Value.ToString()
                If selectedRow.Cells("birthday").Value IsNot DBNull.Value Then
                    BirthdayDateTimePicker.Value = DateTime.Parse(selectedRow.Cells("birthday").Value.ToString())
                End If
                StaffEmailTextBox.Text = selectedRow.Cells("email").Value.ToString()
                PhoneTextBox.Text = selectedRow.Cells("phone").Value.ToString()
                StaffICTextBox.Text = selectedRow.Cells("ic").Value.ToString()
                StaffUsernameTextBox.Text = selectedRow.Cells("username").Value.ToString()
                StaffPasswordTextBox.Text = selectedRow.Cells("password").Value.ToString()

                ' Load picture from the relative path stored in the database
                If selectedRow.Cells("picture").Value IsNot DBNull.Value Then
                    Dim relativeImagePath As String = selectedRow.Cells("picture").Value.ToString()
                    Dim fullImagePath As String = Path.Combine(Application.StartupPath, relativeImagePath)
                    If File.Exists(fullImagePath) Then
                        StaffPictureBox.Image = Image.FromFile(fullImagePath)
                        StaffPictureBox.Tag = fullImagePath
                    Else
                        StaffPictureBox.Image = My.Resources._default
                        StaffPictureBox.Tag = Nothing
                    End If
                Else
                    StaffPictureBox.Image = My.Resources._default
                    StaffPictureBox.Tag = Nothing
                End If


                EnableInputControls(False) ' Disable controls initially
            End If
        End If
    End Sub

    ' Handle Add Button Click - Add or Save new staff
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
            ' Save new staff to the database
            If ValidateInputFields() Then
                SaveNewStaff()
                LoadStaffData() ' Reload data after adding
                SetDefaultFormState() ' Reset the form
            End If
        ElseIf isEditMode Then
            ' Save edited staff to the database
            If ValidateInputFields() Then
                SaveEditedStaff()
                LoadStaffData() ' Reload data after editing
                SetDefaultFormState() ' Reset the form
            End If
        End If
    End Sub

    ' Handle Edit Button Click - Edit or Cancel editing staff
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If Not isEditMode And StaffIDTextBox.Text <> "" Then
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
                Dim selectedRow As DataGridViewRow = StaffDataGridView.Rows(StaffDataGridView.SelectedCells(0).RowIndex)
                StaffIDTextBox.Text = selectedRow.Cells("id").Value.ToString()
                StaffNameTextBox.Text = selectedRow.Cells("name").Value.ToString()
                GenderComboBox.Text = selectedRow.Cells("gender").Value.ToString()
                BirthdayDateTimePicker.Value = DateTime.Parse(selectedRow.Cells("birthday").Value.ToString())
                StaffEmailTextBox.Text = selectedRow.Cells("email").Value.ToString()
                PhoneTextBox.Text = selectedRow.Cells("phone").Value.ToString()
                StaffICTextBox.Text = selectedRow.Cells("ic").Value.ToString()
                StaffUsernameTextBox.Text = selectedRow.Cells("username").Value.ToString()
                StaffPasswordTextBox.Text = selectedRow.Cells("password").Value.ToString()
                SetDefaultFormState()
            Else
                ' Save edited staff to the database
                If ValidateInputFields() Then
                    SaveEditedStaff()
                    LoadStaffData() ' Reload data after editing
                    SetDefaultFormState() ' Reset the form
                End If
            End If
        ElseIf isAddMode Then
            ' Cancel Add mode
            ClearInputFields()
            SetDefaultFormState()
        End If
    End Sub

    ' Handle Delete Button Click - Delete selected staff
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If StaffIDTextBox.Text <> "" Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this staff?", "Confirm Delete", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteStaff()
                LoadStaffData() ' Reload data after deleting
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
        StaffIDTextBox.Clear()
        StaffNameTextBox.Clear()
        GenderComboBox.SelectedIndex = -1
        BirthdayDateTimePicker.Value = DateTime.Now
        StaffEmailTextBox.Clear()
        PhoneTextBox.Clear()
        StaffICTextBox.Clear()
        StaffUsernameTextBox.Clear()
        StaffPasswordTextBox.Clear()
    End Sub

    ' Method to validate input fields before saving
    Private Function ValidateInputFields() As Boolean
        If StaffNameTextBox.Text = "" Or GenderComboBox.SelectedIndex = -1 Or StaffEmailTextBox.Text = "" Or
           PhoneTextBox.Text = "" Or StaffUsernameTextBox.Text = "" Or StaffPasswordTextBox.Text = "" Then
            MessageBox.Show("All fields must be filled!")
            Return False
        End If
        Return True
    End Function

    ' Method to save new staff to the database
    Private Sub SaveNewStaff()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "INSERT INTO staff (name, gender, birthday, email, phone, ic, username, password, picture) " &
                              "VALUES (@name, @gender, @birthday, @email, @phone, @ic, @username, @password, @picture)"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", StaffNameTextBox.Text)
                    cmd.Parameters.AddWithValue("@gender", GenderComboBox.Text)
                    cmd.Parameters.AddWithValue("@birthday", BirthdayDateTimePicker.Value)
                    cmd.Parameters.AddWithValue("@email", StaffEmailTextBox.Text)
                    cmd.Parameters.AddWithValue("@phone", PhoneTextBox.Text)
                    cmd.Parameters.AddWithValue("@ic", StaffICTextBox.Text)
                    cmd.Parameters.AddWithValue("@username", StaffUsernameTextBox.Text)
                    cmd.Parameters.AddWithValue("@password", StaffPasswordTextBox.Text)
                    Dim imagePath As String = SaveImage(StaffPictureBox.Image)
                    cmd.Parameters.AddWithValue("@picture", imagePath)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("New staff added successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error adding staff: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Method to save edited staff to the database
    Private Sub SaveEditedStaff()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "UPDATE staff SET name=@name, gender=@gender, birthday=@birthday, email=@email, phone=@phone, " &
                              "ic=@ic, username=@username, password=@password, picture = @picture WHERE id=@id"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", StaffIDTextBox.Text)
                    cmd.Parameters.AddWithValue("@name", StaffNameTextBox.Text)
                    cmd.Parameters.AddWithValue("@gender", GenderComboBox.Text)
                    cmd.Parameters.AddWithValue("@birthday", BirthdayDateTimePicker.Value)
                    cmd.Parameters.AddWithValue("@email", StaffEmailTextBox.Text)
                    cmd.Parameters.AddWithValue("@phone", PhoneTextBox.Text)
                    cmd.Parameters.AddWithValue("@ic", StaffICTextBox.Text)
                    cmd.Parameters.AddWithValue("@username", StaffUsernameTextBox.Text)
                    cmd.Parameters.AddWithValue("@password", StaffPasswordTextBox.Text)
                    Dim imagePath As String = SaveImage(StaffPictureBox.Image)
                    cmd.Parameters.AddWithValue("@picture", imagePath)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Staff data updated successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error updating staff: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Method to delete staff from the database
    Private Sub DeleteStaff()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "DELETE FROM staff WHERE id=@id"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", StaffIDTextBox.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Staff deleted successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error deleting staff: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Toggle Password Visibility
    Private Sub ShowPasswordBtn_Click(sender As Object, e As EventArgs) Handles ShowPasswordBtn.Click
        If StaffPasswordTextBox.PasswordChar = "•"c Then
            ' Show the password
            StaffPasswordTextBox.PasswordChar = ControlChars.NullChar
        Else
            ' Mask the password
            StaffPasswordTextBox.PasswordChar = "•"c
        End If
    End Sub

    Private Sub Panel_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel.Scroll
        ' Ensure Smooth Scrolling
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    ' Method to filter staff data based on search text
    Private Sub FilterStaffData(searchText As String)
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "SELECT id, name, gender, birthday, email, phone, username, ic, password FROM staff " &
                              "WHERE id LIKE @searchText OR ic LIKE @searchText OR gender LIKE @searchText OR name LIKE @searchText OR email LIKE @searchText OR phone LIKE @searchText"
        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            StaffDataGridView.DataSource = dataTable
        End Using
    End Sub

    ' Handle SearchTextBox TextChanged event - Filter staff data as user types
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchTextBox.Text <> "" Then
            FilterStaffData(SearchTextBox.Text)
        Else
            LoadStaffData() ' Reload all staff data if search text is empty
        End If
    End Sub

    ' Handle Import Button Click - Import picture for staff
    Private Sub ImportBtn_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim sourceFilePath As String = openFileDialog.FileName
                Dim img As Image = Image.FromFile(sourceFilePath)
                StaffPictureBox.Image = img
                StaffPictureBox.Tag = SaveImage(img)
            End If
        End Using
    End Sub

    ' Handle Remove Button Click - Remove picture from StaffPictureBox
    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        StaffPictureBox.Image = My.Resources._default
        StaffPictureBox.Tag = Nothing ' Clear the stored path
    End Sub

    ' Method to save an image to a designated folder within the project and return the relative path
    Private Function SaveImage(img As Image) As String
        Dim folderPath As String = Path.Combine(Application.StartupPath, "StaffImages")
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If
        Dim fileName As String = Guid.NewGuid().ToString() & ".jpg"
        Dim filePath As String = Path.Combine(folderPath, fileName)
        img.Save(filePath, Imaging.ImageFormat.Jpeg)

        ' Return the relative path instead of the full path
        Dim relativePath As String = Path.Combine("StaffImages", fileName)
        Return relativePath
    End Function
End Class