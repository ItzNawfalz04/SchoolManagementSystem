Imports MySql.Data.MySqlClient

Public Class RegistrarRegistration
    Private connectionString As String = "server=localhost;user id=root;database=school_db;"
    Private selectedRegistrationID As Integer
    Private selectedSubjectID As Integer

    ' Form Load Event - Load student data and subject data into DataGridView and ComboBox when the form loads
    Private Sub RegistrarRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentData()
        LoadSubjectData()
        LoadClassData() ' Load class names into ClassFilterComboBox
    End Sub

    ' Method to load student names with auto-incremented registrationID into StudentRegistrationDataGridView
    Private Sub LoadStudentData()
        Dim query As String = "SELECT s.StudentID, s.name AS StudentName, s.email AS StudentEmail, c.ClassID, c.ClassName " &
                              "FROM student s " &
                              "JOIN class c ON s.ClassID = c.ClassID"

        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Add a new column for registrationID with auto-incremented values
            dataTable.Columns.Add("RegistrationID", GetType(Integer))

            ' Auto-increment RegistrationID for each row
            For i As Integer = 0 To dataTable.Rows.Count - 1
                dataTable.Rows(i)("RegistrationID") = i + 1
            Next

            ' Bind DataTable to DataGridView
            StudentRegistrationDataGridView.DataSource = dataTable

            ' Set column headers and display order
            With StudentRegistrationDataGridView
                .Columns("RegistrationID").HeaderText = "Registration ID"
                .Columns("StudentID").HeaderText = "Student ID"
                .Columns("StudentName").HeaderText = "Student Name"
                .Columns("StudentEmail").HeaderText = "Student Email"
                .Columns("ClassName").HeaderText = "Class Name"

                ' Set display order
                .Columns("RegistrationID").DisplayIndex = 0
                .Columns("StudentID").DisplayIndex = 1
                .Columns("StudentName").DisplayIndex = 2
                .Columns("StudentEmail").DisplayIndex = 3
                .Columns("ClassName").DisplayIndex = 4

                ' Hide ClassID column
                .Columns("ClassID").Visible = False
            End With
        End Using
    End Sub

    ' Method to load subject names into SubjectNameComboBox
    Private Sub LoadSubjectData()
        Dim query As String = "SELECT SubjectID, SubjectName, SubjectCode, SubjectCreditHour, SubjectRemarks FROM subject"

        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            SubjectNameComboBox.DataSource = dataTable
            SubjectNameComboBox.DisplayMember = "SubjectName"
            SubjectNameComboBox.ValueMember = "SubjectID"
        End Using
    End Sub

    ' Method to load subjects registered by the selected student
    Private Sub LoadStudentSubjectData()
        Dim query As String = "SELECT rd.SubjectID, s.SubjectName, s.SubjectCode, s.SubjectCreditHour, s.SubjectRemarks " &
                          "FROM registrationdetail rd " &
                          "JOIN subject s ON rd.SubjectID = s.SubjectID " &
                          "WHERE rd.RegistrationID = @RegistrationID"

        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@RegistrationID", selectedRegistrationID)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            StudentSubjectRegistrationDataGridView.DataSource = dataTable

            ' Set column headers
            StudentSubjectRegistrationDataGridView.Columns("SubjectID").HeaderText = "Subject ID"
            StudentSubjectRegistrationDataGridView.Columns("SubjectName").HeaderText = "Subject Name"
            StudentSubjectRegistrationDataGridView.Columns("SubjectCode").HeaderText = "Subject Code"
            StudentSubjectRegistrationDataGridView.Columns("SubjectCreditHour").HeaderText = "Credit Hour"
            StudentSubjectRegistrationDataGridView.Columns("SubjectRemarks").HeaderText = "Remarks"
        End Using
    End Sub


    ' Event to handle row selection in StudentRegistrationDataGridView
    Private Sub StudentRegistrationDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentRegistrationDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = StudentRegistrationDataGridView.Rows(e.RowIndex)

            ' Check for DBNull before casting
            If Not IsDBNull(selectedRow.Cells("RegistrationID").Value) Then
                selectedRegistrationID = CInt(selectedRow.Cells("RegistrationID").Value)
                RegistrationIDTextBox.Text = selectedRow.Cells("RegistrationID").Value.ToString()
            Else
                ' Handle DBNull case
                selectedRegistrationID = 0 ' Or any default value you prefer
            End If

            StudentNameTextBox.Text = selectedRow.Cells("StudentName").Value.ToString()
            StudentEmailTextBox.Text = selectedRow.Cells("StudentEmail").Value.ToString()
            ClassTextBox.Text = selectedRow.Cells("ClassName").Value.ToString()
            StudentIDTextBox.Text = selectedRow.Cells("StudentID").Value.ToString()

            ' Load registered subjects for the selected student
            LoadStudentSubjectData()
        End If
    End Sub



    ' Event handler for SubjectNameComboBox selection change
    Private Sub SubjectNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubjectNameComboBox.SelectedIndexChanged
        If SubjectNameComboBox.SelectedIndex >= 0 Then
            ' Access the selected row directly and get the SubjectID
            Dim selectedRow As DataRowView = CType(SubjectNameComboBox.SelectedItem, DataRowView)
            Dim subjectID As Integer = Convert.ToInt32(selectedRow("SubjectID"))

            ' Query to get subject details based on selected SubjectID
            Dim query As String = "SELECT SubjectCode, SubjectCreditHour, SubjectRemarks FROM subject WHERE SubjectID = @SubjectID"

            Using conn As New MySqlConnection(connectionString)
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SubjectID", subjectID)

                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    SubjectCodeTextBox.Text = reader("SubjectCode").ToString()
                    SubjectCreditHourTextBox.Text = reader("SubjectCreditHour").ToString()
                    SubjectRemarksTextBox.Text = reader("SubjectRemarks").ToString()
                End If
            End Using
        End If
    End Sub


    ' Event handler for row selection in StudentSubjectRegistrationDataGridView
    Private Sub StudentSubjectRegistrationDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentSubjectRegistrationDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = StudentSubjectRegistrationDataGridView.Rows(e.RowIndex)

            ' Check for DBNull before casting
            If Not IsDBNull(selectedRow.Cells("SubjectID").Value) Then
                selectedSubjectID = CInt(selectedRow.Cells("SubjectID").Value)
            Else
                selectedSubjectID = 0 ' Handle DBNull case
            End If

            ' Populate textboxes with selected subject details
            SubjectCodeTextBox.Text = selectedRow.Cells("SubjectCode").Value.ToString()
            SubjectCreditHourTextBox.Text = selectedRow.Cells("SubjectCreditHour").Value.ToString()
            SubjectRemarksTextBox.Text = selectedRow.Cells("SubjectRemarks").Value.ToString()
        End If
    End Sub


    ' Event handler for AddBtn - Adds selected subject to the student's registered subjects
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim subjectID As Integer = CInt(SubjectNameComboBox.SelectedValue)
        Dim remarks As String = SubjectRemarksTextBox.Text

        Dim query As String = "INSERT INTO registrationdetail (RegistrationID, SubjectID) " &
                              "VALUES (@RegistrationID, @SubjectID)"

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@RegistrationID", selectedRegistrationID)
            cmd.Parameters.AddWithValue("@SubjectID", subjectID)
            cmd.ExecuteNonQuery()
        End Using

        ' Refresh DataGridView
        LoadStudentSubjectData()
    End Sub

    ' Event handler for DeleteBtn - Deletes the selected subject from the student's registered subjects
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        ' Check if any cell is selected in the DataGridView
        If StudentSubjectRegistrationDataGridView.SelectedCells.Count > 0 Then
            Dim selectedCell As DataGridViewCell = StudentSubjectRegistrationDataGridView.SelectedCells(0)
            Dim selectedRow As DataGridViewRow = selectedCell.OwningRow
            Dim subjectID As Integer = CInt(selectedRow.Cells("SubjectID").Value)

            ' Try-Catch block for error handling
            Try
                ' SQL query to delete the registration detail based on the RegistrationID and SubjectID
                Dim query As String = "DELETE FROM registrationdetail WHERE RegistrationID = @RegistrationID AND SubjectID = @SubjectID"

                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RegistrationID", selectedRegistrationID)
                    cmd.Parameters.AddWithValue("@SubjectID", subjectID)
                    cmd.ExecuteNonQuery()
                End Using

                ' Show message on successful deletion
                MessageBox.Show("Subject deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh DataGridView after deletion
                LoadStudentSubjectData()

            Catch ex As MySqlException
                ' Handle any SQL-related errors
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                ' Handle any other types of errors
                MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' If no cell is selected, show an alert
            MessageBox.Show("Please select a subject to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Event handler for ClearBtn - Clears the input fields
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        SubjectNameComboBox.SelectedIndex = -1
        SubjectCodeTextBox.Clear()
        SubjectCreditHourTextBox.Clear()
        SubjectRemarksTextBox.Clear()
    End Sub

    ' Event handler for ClearBtnStudent - Clears the input fields
    Private Sub ClearBtnStudent_Click(sender As Object, e As EventArgs) Handles ClearBtnStudent.Click
        RegistrationIDTextBox.Clear()
        StudentIDTextBox.Clear()
        TotalCreditTextBox.Clear()
        ClassTextBox.Clear()
        StudentNameTextBox.Clear()
        StudentEmailTextBox.Clear()
        StudentFeeTextBox.Clear()
        StudentSubjectRegistrationDataGridView.DataSource = Nothing
    End Sub

    Private Sub Panel_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel.Scroll
        ' Ensure Smooth Scrolling
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    ' Method to filter student data based on search text
    Private Sub FilterStudentData(searchText As String)
        Dim query As String = "SELECT s.StudentID, s.name AS StudentName, s.email AS StudentEmail, c.ClassID, c.ClassName " &
                              "FROM student s " &
                              "JOIN class c ON s.ClassID = c.ClassID " &
                              "WHERE s.StudentID LIKE @searchText OR s.name LIKE @searchText OR s.email LIKE @searchText OR c.ClassName LIKE @searchText"

        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Add a new column for registrationID with auto-incremented values
            dataTable.Columns.Add("RegistrationID", GetType(Integer))

            ' Auto-increment RegistrationID for each row
            For i As Integer = 0 To dataTable.Rows.Count - 1
                dataTable.Rows(i)("RegistrationID") = i + 1
            Next

            StudentRegistrationDataGridView.DataSource = dataTable
        End Using
    End Sub

    ' Method to filter student subject data based on search text
    Private Sub FilterStudentSubjectData(searchText As String)
        Dim query As String = "SELECT rd.SubjectID, s.SubjectName, s.SubjectCode, s.SubjectCreditHour, s.SubjectRemarks " &
                          "FROM registrationdetail rd " &
                          "JOIN subject s ON rd.SubjectID = s.SubjectID " &
                          "WHERE rd.RegistrationID = @RegistrationID AND " &
                          "(s.SubjectName LIKE @searchText OR s.SubjectCode LIKE @searchText OR s.SubjectRemarks LIKE @searchText)"

        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@RegistrationID", selectedRegistrationID)
            adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            StudentSubjectRegistrationDataGridView.DataSource = dataTable
        End Using
    End Sub

    ' Handle SearchStudentTextBox TextChanged event - Filter student data as user types
    Private Sub SearchStudentTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchStudentTextBox.TextChanged
        If SearchStudentTextBox.Text <> "" Then
            FilterStudentData(SearchStudentTextBox.Text)
        Else
            LoadStudentData() ' Reload all student data if search text is empty
        End If
    End Sub

    ' Handle SearchStudentSubjectTextBox TextChanged event - Filter student subject data as user types
    Private Sub SearchStudentSubjectTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchStudentSubjectTextBox.TextChanged
        If SearchStudentSubjectTextBox.Text <> "" Then
            FilterStudentSubjectData(SearchStudentSubjectTextBox.Text)
        Else
            LoadStudentSubjectData() ' Reload all student subject data if search text is empty
        End If
    End Sub

    ' Method to load class names into ClassFilterComboBox
    Private Sub LoadClassData()
        Dim query As String = "SELECT ClassID, ClassName FROM class"

        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Add a default item for showing all classes
            Dim allClassesRow As DataRow = dataTable.NewRow()
            allClassesRow("ClassID") = DBNull.Value
            allClassesRow("ClassName") = "All Classes"
            dataTable.Rows.InsertAt(allClassesRow, 0)

            ClassFilterComboBox.DataSource = dataTable
            ClassFilterComboBox.DisplayMember = "ClassName"
            ClassFilterComboBox.ValueMember = "ClassID"
        End Using
    End Sub

    ' Method to load student names with auto-incremented registrationID into StudentRegistrationDataGridView
    Private Sub LoadStudentData(Optional classID As Object = Nothing)
        Dim query As String = "SELECT s.StudentID, s.name AS StudentName, s.email AS StudentEmail, c.ClassID, c.ClassName " &
                              "FROM student s " &
                              "JOIN class c ON s.ClassID = c.ClassID"

        If classID IsNot Nothing Then
            query &= " WHERE c.ClassID = @ClassID"
        End If

        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            If classID IsNot Nothing Then
                adapter.SelectCommand.Parameters.AddWithValue("@ClassID", classID)
            End If
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Add a new column for registrationID with auto-incremented values
            dataTable.Columns.Add("RegistrationID", GetType(Integer))

            ' Auto-increment RegistrationID for each row
            For i As Integer = 0 To dataTable.Rows.Count - 1
                dataTable.Rows(i)("RegistrationID") = i + 1
            Next

            ' Bind DataTable to DataGridView
            StudentRegistrationDataGridView.DataSource = dataTable

            ' Set column headers and display order
            With StudentRegistrationDataGridView
                .Columns("RegistrationID").HeaderText = "Registration ID"
                .Columns("StudentID").HeaderText = "Student ID"
                .Columns("StudentName").HeaderText = "Student Name"
                .Columns("StudentEmail").HeaderText = "Student Email"
                .Columns("ClassName").HeaderText = "Class Name"

                ' Set display order
                .Columns("RegistrationID").DisplayIndex = 0
                .Columns("StudentID").DisplayIndex = 1
                .Columns("StudentName").DisplayIndex = 2
                .Columns("StudentEmail").DisplayIndex = 3
                .Columns("ClassName").DisplayIndex = 4

                ' Hide ClassID column
                .Columns("ClassID").Visible = False
            End With
        End Using
    End Sub

    ' Event handler for ClassFilterComboBox selection change
    Private Sub ClassFilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClassFilterComboBox.SelectedIndexChanged
        Dim selectedClassID As Object = ClassFilterComboBox.SelectedValue
        If selectedClassID IsNot Nothing AndAlso Not IsDBNull(selectedClassID) Then
            LoadStudentData(selectedClassID) ' Load students for the selected class
        Else
            LoadStudentData() ' Load all students if "All Classes" is selected
        End If
    End Sub
End Class
