Imports MySql.Data.MySqlClient
Imports System.IO

Public Class RegistrarStudent
    Dim isAddMode As Boolean = False ' Track if we are in Add mode
    Dim isEditMode As Boolean = False ' Track if we are in Edit mode
    Dim originalStaffID As Integer ' To store the selected Student ID

    ' Form Load Event - Load student data into the DataGridView when the form loads
    Private Sub RegistrarStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentData()
        SetDefaultFormState()
        LoadStudent() ' Load teachers into the ComboBox
    End Sub

    ' Method to load student data from the database into the DataGridView
    Private Sub LoadStudentData()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "SELECT StudentID, name, gender, birthday, email, phone, ic, class.ClassName, picture " &
                          "FROM student " &
                          "JOIN class ON student.ClassID = class.ClassID"
        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            StudentDataGridView.DataSource = dataTable

            ' Optionally, rename the ClassName column to ClassID for display purposes
            StudentDataGridView.Columns("ClassName").HeaderText = "Class Name"
        End Using
    End Sub

    ' Load student into the StudentClassComboBox
    Private Sub LoadStudent()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "SELECT ClassID, ClassName FROM class"
        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            StudentClassComboBox.DataSource = dataTable
            StudentClassComboBox.DisplayMember = "ClassName"
            StudentClassComboBox.ValueMember = "ClassID"
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
        PictureBox.Image = My.Resources._default
        PictureBox.Tag = Nothing
    End Sub

    ' Enable or disable input controls (TextBoxes, ComboBox, DateTimePicker)
    Private Sub EnableInputControls(enable As Boolean)
        IDTextBox.Enabled = False ' StudentID is auto-generated, so always disabled
        NameTextBox.Enabled = enable
        GenderComboBox.Enabled = enable
        BirthdayDateTimePicker.Enabled = enable
        EmailTextBox.Enabled = enable
        PhoneTextBox.Enabled = enable
        ICTextBox.Enabled = enable
        StudentClassComboBox.Enabled = enable

        ' Show/hide Import and Remove buttons
        ImportButton.Visible = enable
        RemoveButton.Visible = enable
    End Sub

    ' Event to handle row selection in StudentDataGridView - populate TextBoxes with selected student data
    Private Sub StudentDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = StudentDataGridView.Rows(e.RowIndex)

            If selectedRow IsNot Nothing AndAlso selectedRow.Cells("StudentID").Value IsNot DBNull.Value Then
                ' Populate the TextBoxes with the selected student data
                IDTextBox.Text = selectedRow.Cells("StudentID").Value.ToString()
                NameTextBox.Text = selectedRow.Cells("name").Value.ToString()
                GenderComboBox.Text = selectedRow.Cells("gender").Value.ToString()
                If selectedRow.Cells("birthday").Value IsNot DBNull.Value Then
                    BirthdayDateTimePicker.Value = DateTime.Parse(selectedRow.Cells("birthday").Value.ToString())
                End If
                EmailTextBox.Text = selectedRow.Cells("email").Value.ToString()
                PhoneTextBox.Text = selectedRow.Cells("phone").Value.ToString()
                ICTextBox.Text = selectedRow.Cells("ic").Value.ToString()

                ' Set the ClassID based on the selected ClassName
                Dim className As String = selectedRow.Cells("ClassName").Value.ToString()
                Dim classID As Integer = GetClassIDByName(className)
                StudentClassComboBox.SelectedValue = classID

                ' Load picture from the relative path stored in the database
                If selectedRow.Cells("picture").Value IsNot DBNull.Value Then
                    Dim relativeImagePath As String = selectedRow.Cells("picture").Value.ToString()
                    Dim fullImagePath As String = Path.Combine(Application.StartupPath, relativeImagePath)
                    If File.Exists(fullImagePath) Then
                        PictureBox.Image = Image.FromFile(fullImagePath)
                        PictureBox.Tag = fullImagePath
                    Else
                        PictureBox.Image = My.Resources._default
                        PictureBox.Tag = Nothing
                    End If
                Else
                    PictureBox.Image = My.Resources._default
                    PictureBox.Tag = Nothing
                End If

                EnableInputControls(False) ' Disable controls initially
            End If
        End If
    End Sub

    ' Method to get ClassID by ClassName
    Private Function GetClassIDByName(className As String) As Integer
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "SELECT ClassID FROM class WHERE ClassName = @ClassName"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ClassName", className)
                conn.Open()
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Return Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return -1 ' Return -1 if not found
    End Function

    ' Handle Add Button Click - Add or Save new student
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
            ' Save new student to the database
            If ValidateInputFields() Then
                SaveNewStudent()
                LoadStudentData() ' Reload data after adding
                SetDefaultFormState() ' Reset the form
            End If
        ElseIf isEditMode Then
            ' Save edited student to the database
            If ValidateInputFields() Then
                SaveEditedStudent()
                LoadStudentData() ' Reload data after editing
                SetDefaultFormState() ' Reset the form
            End If
        End If
    End Sub

    ' Handle Edit Button Click - Edit or Cancel editing student
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If Not isEditMode And IDTextBox.Text <> "" Then
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
                Dim selectedRow As DataGridViewRow = StudentDataGridView.Rows(StudentDataGridView.SelectedCells(0).RowIndex)
                IDTextBox.Text = selectedRow.Cells("StudentID").Value.ToString()
                NameTextBox.Text = selectedRow.Cells("name").Value.ToString()
                GenderComboBox.Text = selectedRow.Cells("gender").Value.ToString()
                BirthdayDateTimePicker.Value = DateTime.Parse(selectedRow.Cells("birthday").Value.ToString())
                EmailTextBox.Text = selectedRow.Cells("email").Value.ToString()
                PhoneTextBox.Text = selectedRow.Cells("phone").Value.ToString()
                ICTextBox.Text = selectedRow.Cells("ic").Value.ToString()
                StudentClassComboBox.Text = selectedRow.Cells("ClassName").Value.ToString()
                SetDefaultFormState()
            Else
                ' Save edited student to the database
                If ValidateInputFields() Then
                    SaveEditedStudent()
                    LoadStudentData() ' Reload data after editing
                    SetDefaultFormState() ' Reset the form
                End If
            End If
        ElseIf isAddMode Then
            ' Cancel Add mode
            ClearInputFields()
            SetDefaultFormState()
        End If
    End Sub

    ' Handle Delete Button Click - Delete selected student
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If IDTextBox.Text <> "" Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteStaff()
                LoadStudentData() ' Reload data after deleting
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
        IDTextBox.Clear()
        NameTextBox.Clear()
        GenderComboBox.SelectedIndex = -1
        BirthdayDateTimePicker.Value = DateTime.Now
        EmailTextBox.Clear()
        PhoneTextBox.Clear()
        ICTextBox.Clear()
        StudentClassComboBox.SelectedIndex = -1
    End Sub

    ' Method to validate input fields before saving
    Private Function ValidateInputFields() As Boolean
        If NameTextBox.Text = "" Or GenderComboBox.SelectedIndex = -1 Or EmailTextBox.Text = "" Or
           PhoneTextBox.Text = "" Or ICTextBox.Text = "" Or StudentClassComboBox.SelectedIndex = -1 Then
            MessageBox.Show("All fields must be filled!")
            Return False
        End If
        Return True
    End Function

    ' Method to save new student to the database
    Private Sub SaveNewStudent()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "INSERT INTO student (name, gender, birthday, email, phone, ic, ClassID, picture) " &
                              "VALUES (@name, @gender, @birthday, @email, @phone, @ic, @ClassID, @picture)"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", NameTextBox.Text)
                    cmd.Parameters.AddWithValue("@gender", GenderComboBox.Text)
                    cmd.Parameters.AddWithValue("@birthday", BirthdayDateTimePicker.Value)
                    cmd.Parameters.AddWithValue("@email", EmailTextBox.Text)
                    cmd.Parameters.AddWithValue("@phone", PhoneTextBox.Text)
                    cmd.Parameters.AddWithValue("@ic", ICTextBox.Text)
                    cmd.Parameters.AddWithValue("@ClassID", StudentClassComboBox.SelectedValue)
                    Dim imagePath As String = SaveImage(PictureBox.Image)
                    cmd.Parameters.AddWithValue("@picture", imagePath)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("New student added successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error adding student: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Method to save edited student to the database
    Private Sub SaveEditedStudent()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "UPDATE student SET name=@name, gender=@gender, birthday=@birthday, email=@email, phone=@phone, " &
                              "ic=@ic, ClassID=@ClassID, picture = @picture WHERE StudentID=@StudentID"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StudentID", IDTextBox.Text)
                    cmd.Parameters.AddWithValue("@name", NameTextBox.Text)
                    cmd.Parameters.AddWithValue("@gender", GenderComboBox.Text)
                    cmd.Parameters.AddWithValue("@birthday", BirthdayDateTimePicker.Value)
                    cmd.Parameters.AddWithValue("@email", EmailTextBox.Text)
                    cmd.Parameters.AddWithValue("@phone", PhoneTextBox.Text)
                    cmd.Parameters.AddWithValue("@ic", ICTextBox.Text)
                    cmd.Parameters.AddWithValue("@ClassID", StudentClassComboBox.SelectedValue)
                    Dim imagePath As String = SaveImage(PictureBox.Image)
                    cmd.Parameters.AddWithValue("@picture", imagePath)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Student data updated successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error updating student: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Method to delete staff from the database
    Private Sub DeleteStaff()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "DELETE FROM student WHERE StudentID=@StudentID"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StudentID", IDTextBox.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Student deleted successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error deleting student: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Panel_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel.Scroll
        ' Ensure Smooth Scrolling
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    ' Method to filter student data based on search text
    Private Sub FilterStudentData(searchText As String)
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "SELECT StudentID, name, gender, birthday, email, phone, ic, ClassID FROM student " &
                              "WHERE StudentID LIKE @searchText OR ic LIKE @searchText OR gender LIKE @searchText OR name LIKE @searchText OR email LIKE @searchText OR phone LIKE @searchText OR ClassID LIKE @searchText"
        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            StudentDataGridView.DataSource = dataTable
        End Using
    End Sub

    ' Handle SearchTextBox TextChanged event - Filter student data as user types
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchTextBox.Text <> "" Then
            FilterStudentData(SearchTextBox.Text)
        Else
            LoadStudentData() ' Reload all student data if search text is empty
        End If
    End Sub

    ' Handle Import Button Click - Import picture for student
    Private Sub ImportBtn_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim sourceFilePath As String = openFileDialog.FileName
                Dim img As Image = Image.FromFile(sourceFilePath)
                PictureBox.Image = img
                PictureBox.Tag = SaveImage(img)
            End If
        End Using
    End Sub

    ' Handle Remove Button Click - Remove picture from PictureBox
    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        PictureBox.Image = My.Resources._default
        PictureBox.Tag = Nothing ' Clear the stored path
    End Sub

    ' Method to save an image to a designated folder within the project and return the relative path
    Private Function SaveImage(img As Image) As String
        Dim folderPath As String = Path.Combine(Application.StartupPath, "StudentImages")
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If
        Dim fileName As String = Guid.NewGuid().ToString() & ".jpg"
        Dim filePath As String = Path.Combine(folderPath, fileName)
        img.Save(filePath, Imaging.ImageFormat.Jpeg)

        ' Return the relative path instead of the full path
        Dim relativePath As String = Path.Combine("StudentImages", fileName)
        Return relativePath
    End Function
End Class