﻿Imports MySql.Data.MySqlClient
Imports System.IO

Public Class RegistrarClass
    Dim isAddMode As Boolean = False ' Track if we are in Add mode
    Dim isEditMode As Boolean = False ' Track if we are in Edit mode
    Dim originalClassID As Integer ' To store the selected class ID

    ' Form Load Event - Load class data into the DataGridView when the form loads
    Private Sub RegistrarClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClassData()
        SetDefaultFormState()
        LoadTeachers() ' Load teachers into the ComboBox
    End Sub

    ' Method to load class data from the database into the DataGridView
    Private Sub LoadClassData()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "SELECT class.ClassID, class.ClassName, teacher.name AS TeacherName, class.Remarks " &
                          "FROM class " &
                          "JOIN teacher ON class.TeacherID = teacher.TeacherID"
        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Set the DataSource of the DataGridView to the loaded data
            ClassDataGridView.DataSource = dataTable
        End Using
    End Sub

    ' Load teachers into the ClassTeacherComboBox
    Private Sub LoadTeachers()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "SELECT TeacherID, name FROM teacher"
        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            ClassTeacherComboBox.DataSource = dataTable
            ClassTeacherComboBox.DisplayMember = "name"
            ClassTeacherComboBox.ValueMember = "TeacherID"
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

    ' Enable or disable input controls (TextBoxes, ComboBox)
    Private Sub EnableInputControls(enable As Boolean)
        ClassIDTextBox.Enabled = False ' ClassID is auto-generated, so always disabled
        ClassNameTextBox.Enabled = enable
        ClassTeacherComboBox.Enabled = enable
        RemarksTextBox.Enabled = enable
    End Sub

    ' Event to handle row selection in ClassDataGridView - populate TextBoxes with selected class data
    Private Sub ClassDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClassDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow = ClassDataGridView.Rows(e.RowIndex)

            If selectedRow IsNot Nothing AndAlso selectedRow.Cells("ClassID").Value IsNot DBNull.Value Then
                ' Populate the TextBoxes with the selected class data
                ClassIDTextBox.Text = selectedRow.Cells("ClassID").Value.ToString
                ClassNameTextBox.Text = selectedRow.Cells("ClassName").Value.ToString

                ' Set the selected TeacherID based on the displayed TeacherName
                Dim teacherName = selectedRow.Cells("TeacherName").Value.ToString
                Dim teacherID = GetTeacherIDByName(teacherName)
                ClassTeacherComboBox.SelectedValue = teacherID

                RemarksTextBox.Text = selectedRow.Cells("Remarks").Value.ToString

                EnableInputControls(False) ' Disable controls initially

                ' Load students for the selected class
                LoadStudentList(selectedRow.Cells("ClassID").Value.ToString())
            End If
        End If
    End Sub

    ' Method to load students for the selected class
    Private Sub LoadStudentList(classID As String)
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "SELECT StudentID, name FROM student WHERE ClassID = @ClassID"
        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@ClassID", classID)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Set the DataSource of the ClassStudentListDataGridView to the loaded data
            ClassStudentListDataGridView.DataSource = dataTable
        End Using
    End Sub

    ' Handle SearchTextBox TextChanged event - Filter student data as user types
    Private Sub StudentListSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles StudentListSearchTextBox.TextChanged
        If StudentListSearchTextBox.Text <> "" Then
            FilterStudentData(StudentListSearchTextBox.Text)
        Else
            Dim selectedClassID As String = ClassIDTextBox.Text
            If Not String.IsNullOrEmpty(selectedClassID) Then
                LoadStudentList(selectedClassID) ' Reload all student data for the selected class if search text is empty
            End If
        End If
    End Sub

    ' Method to filter student data based on search text
    Private Sub FilterStudentData(searchText As String)
        Dim classID As String = ClassIDTextBox.Text
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "SELECT StudentID, name FROM student WHERE ClassID = @ClassID AND (name LIKE @searchText OR StudentID LIKE @searchText)"
        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@ClassID", classID)
            adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            ClassStudentListDataGridView.DataSource = dataTable
        End Using
    End Sub

    ' Method to get TeacherID by TeacherName
    Private Function GetTeacherIDByName(teacherName As String) As Integer
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "SELECT TeacherID FROM teacher WHERE name = @TeacherName"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@TeacherName", teacherName)
                conn.Open()
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Return Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return -1 ' Return -1 if not found
    End Function

    ' Handle Add Button Click - Add or Save new class
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
            ' Save new class to the database
            If ValidateInputFields() Then
                SaveNewClass()
                LoadClassData() ' Reload data after adding
                SetDefaultFormState() ' Reset the form
            End If
        ElseIf isEditMode Then
            ' Save edited class to the database
            If ValidateInputFields() Then
                SaveEditedClass()
                LoadClassData() ' Reload data after editing
                SetDefaultFormState() ' Reset the form
            End If
        End If
    End Sub

    ' Handle Edit Button Click - Edit or Cancel editing class
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If Not isEditMode And ClassIDTextBox.Text <> "" Then
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
                Dim selectedRow As DataGridViewRow = ClassDataGridView.Rows(ClassDataGridView.SelectedCells(0).RowIndex)
                ClassIDTextBox.Text = selectedRow.Cells("ClassID").Value.ToString()
                ClassNameTextBox.Text = selectedRow.Cells("ClassName").Value.ToString()
                ClassTeacherComboBox.SelectedValue = selectedRow.Cells("TeacherID").Value
                RemarksTextBox.Text = selectedRow.Cells("Remarks").Value.ToString()
                SetDefaultFormState()
            Else
                ' Save edited class to the database
                If ValidateInputFields() Then
                    SaveEditedClass()
                    LoadClassData() ' Reload data after editing
                    SetDefaultFormState() ' Reset the form
                End If
            End If
        ElseIf isAddMode Then
            ' Cancel Add mode
            ClearInputFields()
            SetDefaultFormState()
        End If
    End Sub

    ' Handle Delete Button Click - Delete selected class
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If ClassIDTextBox.Text <> "" Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this class?", "Confirm Delete", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteClass()
                LoadClassData() ' Reload data after deleting
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
        ClassIDTextBox.Clear()
        ClassNameTextBox.Clear()
        ClassTeacherComboBox.SelectedIndex = -1
        RemarksTextBox.Clear()
    End Sub

    ' Method to validate input fields before saving
    Private Function ValidateInputFields() As Boolean
        If ClassNameTextBox.Text = "" Or ClassTeacherComboBox.SelectedIndex = -1 Or RemarksTextBox.Text = "" Then
            MessageBox.Show("All fields must be filled!")
            Return False
        End If
        Return True
    End Function

    ' Method to save new class to the database
    Private Sub SaveNewClass()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "INSERT INTO class (ClassName, TeacherID, Remarks) VALUES (@ClassName, @TeacherID, @Remarks)"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ClassName", ClassNameTextBox.Text)
                    cmd.Parameters.AddWithValue("@TeacherID", ClassTeacherComboBox.SelectedValue)
                    cmd.Parameters.AddWithValue("@Remarks", RemarksTextBox.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("New class added successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error adding class: " & ex.Message)
            End Try
        End Using
    End Sub


    ' Method to save edited class to the database
    Private Sub SaveEditedClass()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "UPDATE class SET ClassName=@ClassName, TeacherID=@TeacherID, Remarks=@Remarks WHERE ClassID=@ClassID"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ClassID", ClassIDTextBox.Text)
                    cmd.Parameters.AddWithValue("@ClassName", ClassNameTextBox.Text)
                    cmd.Parameters.AddWithValue("@TeacherID", ClassTeacherComboBox.SelectedValue)
                    cmd.Parameters.AddWithValue("@Remarks", RemarksTextBox.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Class data updated successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error updating class: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Method to delete class from the database
    Private Sub DeleteClass()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "DELETE FROM class WHERE ClassID=@ClassID "
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ClassID", ClassIDTextBox.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Class deleted successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error deleting class: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Panel_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel.Scroll
        ' Ensure Smooth Scrolling
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    Private Sub FilterClassData(searchText As String)
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "SELECT class.ClassID, class.ClassName, teacher.name AS TeacherName, class.Remarks " &
                          "FROM class " &
                          "JOIN teacher ON class.TeacherID = teacher.TeacherID " &
                          "WHERE class.ClassID LIKE @searchText OR class.ClassName LIKE @searchText OR " &
                          "teacher.name LIKE @searchText OR class.Remarks LIKE @searchText"

        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            ClassDataGridView.DataSource = dataTable
        End Using
    End Sub

    ' Handle SearchTextBox TextChanged event - Filter class data as user types
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchTextBox.Text <> "" Then
            FilterClassData(SearchTextBox.Text)
        Else
            LoadClassData() ' Call LoadClassData with parentheses
        End If
    End Sub
End Class