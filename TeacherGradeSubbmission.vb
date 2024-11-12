Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO

Public Class TeacherGradeSubbmission
    Private connectionString As String = "server=localhost;user id=root;database=school_db;"
    Private selectedRegistrationID As Integer

    ' Form Load Event - Load student data and subject data into DataGridView when the form loads
    Private Sub RegistrarRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClassData() ' Load class data into StudentFilterComboBox
        LoadStudentData() ' Load all student data
        LoadSubjectData() ' Load subject data

        ' Clear the subject-related controls
        ClearSubjectFields()
    End Sub

    ' Method to clear subject-related input fields
    Private Sub ClearSubjectFields()
        SubjectNameComboBox.SelectedIndex = -1
        SubjectGradeComboBox.SelectedIndex = -1
        SubjectCodeTextBox.Clear()
        SubjectCreditHourTextBox.Clear()
    End Sub

    ' Method to load class names into StudentFilterComboBox
    Private Sub LoadClassData()
        Dim query As String = "SELECT ClassID, ClassName FROM class"

        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Add "All Students" option
            Dim allClassesRow As DataRow = dataTable.NewRow()
            allClassesRow("ClassID") = DBNull.Value
            allClassesRow("ClassName") = "All Students"
            dataTable.Rows.InsertAt(allClassesRow, 0)

            StudentFilterComboBox.DataSource = dataTable
            StudentFilterComboBox.DisplayMember = "ClassName"
            StudentFilterComboBox.ValueMember = "ClassID"
        End Using
    End Sub


    ' Method to load all student data into StudentInformationDataGridView
    Private Sub LoadStudentData(Optional classID As Object = Nothing)
        Dim query As String = "SELECT s.StudentID, s.name AS StudentName, s.email AS StudentEmail, c.ClassID, c.ClassName, " &
                          "IFNULL((SELECT SUM(su.SubjectCreditHour) FROM registrationdetail rd " &
                          "JOIN subject su ON rd.SubjectID = su.SubjectID WHERE rd.RegistrationID = r.RegistrationID), 0) AS StudentTotalCreditHour, " &
                          "r.RegistrationID " &
                          "FROM student s " &
                          "JOIN class c ON s.ClassID = c.ClassID " &
                          "LEFT JOIN registration r ON s.StudentID = r.StudentID"

        If classID IsNot Nothing AndAlso Not IsDBNull(classID) Then
            query &= " WHERE c.ClassID = @ClassID"
        End If

        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            If classID IsNot Nothing AndAlso Not IsDBNull(classID) Then
                adapter.SelectCommand.Parameters.AddWithValue("@ClassID", classID)
            End If
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Bind DataTable to DataGridView
            StudentInformationDataGridView.DataSource = dataTable

            ' Set column headers and display order
            With StudentInformationDataGridView
                .Columns("RegistrationID").HeaderText = "Registration ID"
                .Columns("StudentID").HeaderText = "Student ID"
                .Columns("StudentName").HeaderText = "Student Name"
                .Columns("StudentEmail").HeaderText = "Student Email"
                .Columns("ClassName").HeaderText = "Class Name"
                .Columns("StudentTotalCreditHour").HeaderText = "Total Credit Hours" ' Add this line

                ' Set display order
                .Columns("RegistrationID").DisplayIndex = 0
                .Columns("StudentID").DisplayIndex = 1
                .Columns("StudentName").DisplayIndex = 2
                .Columns("StudentEmail").DisplayIndex = 3
                .Columns("ClassName").DisplayIndex = 4
                .Columns("StudentTotalCreditHour").DisplayIndex = 5 ' Set the display order

                ' Hide ClassID column
                .Columns("ClassID").Visible = False
            End With
        End Using
    End Sub


    ' Method to assign a RegistrationID to a student
    Private Function AssignRegistrationID(studentID As Integer) As Integer
        Dim newRegistrationID As Integer
        Dim query As String = "INSERT INTO registration (StudentID) VALUES (@StudentID); SELECT LAST_INSERT_ID();"

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@StudentID", studentID)
            newRegistrationID = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return newRegistrationID
    End Function

    ' Method to load subject names into SubjectNameComboBox
    Private Sub LoadSubjectData()
        Dim query As String = "SELECT SubjectID, SubjectName, SubjectCode, SubjectCreditHour FROM subject"

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
        Dim query As String = "SELECT rd.SubjectID, s.SubjectCode, s.SubjectName, s.SubjectCreditHour, rd.SubjectGrade " &
                              "FROM registrationdetail rd " &
                              "JOIN subject s ON rd.SubjectID = s.SubjectID " &
                              "WHERE rd.RegistrationID = @RegistrationID"

        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@RegistrationID", selectedRegistrationID)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            StudentSubjectGradeDataGridView.DataSource = dataTable

            ' Set column headers
            With StudentSubjectGradeDataGridView
                .Columns("SubjectID").HeaderText = "Subject ID"
                .Columns("SubjectName").HeaderText = "Subject Name"
                .Columns("SubjectCode").HeaderText = "Subject Code"
                .Columns("SubjectCreditHour").HeaderText = "Credit Hour"
                .Columns("SubjectGrade").HeaderText = "Grade"
            End With
        End Using
    End Sub

    ' Event to handle row selection in StudentInformationDataGridView
    Private Sub StudentInformationDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentInformationDataGridView.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < StudentInformationDataGridView.Rows.Count Then
            Dim selectedRow As DataGridViewRow = StudentInformationDataGridView.Rows(e.RowIndex)

            ' Check if the RegistrationID cell is not null or empty
            If Not IsDBNull(selectedRow.Cells("RegistrationID").Value) Then
                ' Get selected RegistrationID
                selectedRegistrationID = CInt(selectedRow.Cells("RegistrationID").Value)

                ' Load registered subjects for the selected student
                LoadStudentSubjectData()

                ' Display student information
                DisplayStudentInfo(selectedRow)
            End If
        End If
    End Sub

    Private Sub DisplayStudentInfo(selectedRow As DataGridViewRow)
        RegistrationIDTextBox.Text = selectedRow.Cells("RegistrationID").Value.ToString()
        StudentIDTextBox.Text = selectedRow.Cells("StudentID").Value.ToString()
        StudentNameTextBox.Text = selectedRow.Cells("StudentName").Value.ToString()
        StudentEmailTextBox.Text = selectedRow.Cells("StudentEmail").Value.ToString()
        ClassTextBox.Text = selectedRow.Cells("ClassName").Value.ToString()

        ' Display total credit hours
        Dim totalCreditHours As Integer = CInt(selectedRow.Cells("StudentTotalCreditHour").Value)
        TotalCreditTextBox.Text = totalCreditHours.ToString()
    End Sub

    ' Method to update the registration table with total credit hours and fee
    Private Sub UpdateRegistrationTable(totalCreditHours As Integer, studentFee As Decimal)
        Dim query As String = "UPDATE registration SET StudentTotalCreditHour = @TotalCreditHour, StudentFee = @StudentFee WHERE RegistrationID = @RegistrationID"

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@TotalCreditHour", totalCreditHours)
            cmd.Parameters.AddWithValue("@StudentFee", studentFee)
            cmd.Parameters.AddWithValue("@RegistrationID", selectedRegistrationID)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' Event handler for SubjectNameComboBox selection change
    Private Sub SubjectNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubjectNameComboBox.SelectedIndexChanged
        If SubjectNameComboBox.SelectedItem IsNot Nothing Then
            Dim selectedRowView As DataRowView = CType(SubjectNameComboBox.SelectedItem, DataRowView)
            Dim selectedSubjectID As Integer = Convert.ToInt32(selectedRowView("SubjectID")) ' Extract SubjectID

            Dim query As String = "SELECT SubjectCode, SubjectCreditHour FROM subject WHERE SubjectID = @SubjectID"

            Using conn As New MySqlConnection(connectionString)
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SubjectID", selectedSubjectID)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    SubjectCodeTextBox.Text = reader("SubjectCode").ToString()
                    SubjectCreditHourTextBox.Text = reader("SubjectCreditHour").ToString()
                End If
            End Using
        End If
    End Sub

    ' Event handler for AddBtn - Adds selected subject to the student's registered subjects
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If SubjectNameComboBox.SelectedItem IsNot Nothing Then
            Dim selectedRowView = CType(SubjectNameComboBox.SelectedItem, DataRowView)
            Dim subjectID = Convert.ToInt32(selectedRowView("SubjectID")) ' Extract SubjectID

            Dim query = "INSERT INTO registrationdetail (RegistrationID, SubjectID) " &
                              "VALUES (@RegistrationID, @SubjectID)"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@RegistrationID", selectedRegistrationID)
                cmd.Parameters.AddWithValue("@SubjectID", subjectID)
                cmd.ExecuteNonQuery()
            End Using

            ' Refresh DataGridView and update student information
            LoadStudentSubjectData()
            LoadStudentData() ' Refresh student data to update total credit hours and fees
        Else
            MessageBox.Show("Please select a subject to add.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Event handler for DeleteBtn - Deletes the selected subject from the student's registered subjects
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If StudentSubjectGradeDataGridView.SelectedCells.Count > 0 Then
            Dim selectedCell As DataGridViewCell = StudentSubjectGradeDataGridView.SelectedCells(0)
            Dim selectedRow As DataGridViewRow = selectedCell.OwningRow

            ' Check if the SubjectID cell is not null or empty
            If Not IsDBNull(selectedRow.Cells("SubjectID").Value) Then
                Dim subjectID As Integer = CInt(selectedRow.Cells("SubjectID").Value)

                Dim query As String = "DELETE FROM registrationdetail WHERE RegistrationID = @RegistrationID AND SubjectID = @SubjectID"

                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RegistrationID", selectedRegistrationID)
                    cmd.Parameters.AddWithValue("@SubjectID", subjectID)
                    cmd.ExecuteNonQuery()
                End Using

                ' Refresh DataGridView and update student information
                LoadStudentSubjectData()
                LoadStudentData() ' Refresh student data to update total credit hours and fees
            Else
                MessageBox.Show("Please select a valid subject to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please select a subject to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    ' Method to update the subject grade
    Private Sub UpdateSubjectGrade(subjectID As Integer, grade As String)
        Dim query As String = "UPDATE registrationdetail SET SubjectGrade = @SubjectGrade WHERE RegistrationID = @RegistrationID AND SubjectID = @SubjectID"

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@SubjectGrade", grade)
            cmd.Parameters.AddWithValue("@RegistrationID", selectedRegistrationID)
            cmd.Parameters.AddWithValue("@SubjectID", subjectID)
            cmd.ExecuteNonQuery()
        End Using
    End Sub


    ' Event handler for ClearBtn - Clears the input fields
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        SubjectNameComboBox.SelectedIndex = -1
        SubjectGradeComboBox.SelectedIndex = -1
        SubjectCodeTextBox.Clear()
        SubjectCreditHourTextBox.Clear()
    End Sub


    ' Event handler for ClearBtnStudent - Clears the input fields
    Private Sub ClearBtnStudent_Click(sender As Object, e As EventArgs) Handles ClearBtnStudent.Click
        StudentInformationDataGridView.ClearSelection()
        StudentSubjectGradeDataGridView.DataSource = Nothing
        ClearBtn.PerformClick() ' Clear subject fields as well
        ' Clear student information fields
        RegistrationIDTextBox.Clear()
        StudentIDTextBox.Clear()
        StudentNameTextBox.Clear()
        StudentEmailTextBox.Clear()
        ClassTextBox.Clear()
        TotalCreditTextBox.Clear()
    End Sub

    ' Event handler for StudentFilterComboBox selection change
    Private Sub StudentFilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StudentFilterComboBox.SelectedIndexChanged
        Dim selectedClassID As Object = StudentFilterComboBox.SelectedValue
        LoadStudentData(selectedClassID) ' Load students for the selected class
    End Sub


    ' Method to filter student data based on search text
    Private Sub FilterStudentData(searchText As String)
        Dim query As String = "SELECT s.StudentID, s.name AS StudentName, s.email AS StudentEmail, c.ClassID, c.ClassName, r.RegistrationID " &
                              "FROM student s " &
                              "JOIN class c ON s.ClassID = c.ClassID " &
                              "LEFT JOIN registration r ON s.StudentID = r.StudentID " &
                              "WHERE s.StudentID LIKE @searchText OR s.name LIKE @searchText OR s.email LIKE @searchText"

        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            StudentInformationDataGridView.DataSource = dataTable
        End Using
    End Sub

    ' Method to filter student subject data based on search text
    Private Sub FilterStudentSubjectData(searchText As String)
        Dim query As String = "SELECT rd.SubjectID, s.SubjectCode, s.SubjectName, s.SubjectCreditHour, s.SubjectRemarks " &
                              "FROM registrationdetail rd " &
                              "JOIN subject s ON rd.SubjectID = s.SubjectID " &
                              "WHERE rd.RegistrationID = @RegistrationID AND (s.SubjectCode LIKE @searchText OR s.SubjectName LIKE @searchText)"

        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@RegistrationID", selectedRegistrationID)
            adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            StudentSubjectGradeDataGridView.DataSource = dataTable
        End Using
    End Sub

    ' Handle SearchStudentSubjectTextBox TextChanged event - Filter student subject data as user types
    Private Sub SearchStudentSubjectTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchStudentSubjectTextBox.TextChanged
        If SearchStudentSubjectTextBox.Text <> "" Then
            FilterStudentSubjectData(SearchStudentSubjectTextBox.Text)
        Else
            LoadStudentSubjectData() ' Reload all subjects for the selected student if search text is empty
        End If
    End Sub

    ' Handle SearchStudentTextBox TextChanged event - Filter student data as user types
    Private Sub SearchStudentTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchStudentTextBox.TextChanged
        If SearchStudentTextBox.Text <> "" Then
            FilterStudentData(SearchStudentTextBox.Text)
        Else
            LoadStudentData() ' Reload all student data if search text is empty
        End If
    End Sub


    ' Add this method to handle printing with formatted content
    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        ' Create a PrintDocument object
        Dim printDoc As New Printing.PrintDocument()

        ' Set up the PrintPage event to format content for printing
        AddHandler printDoc.PrintPage, AddressOf Me.PrintDocument_PrintPage

        ' Show print preview dialog
        Dim printPreview As New PrintPreviewDialog() With {.Document = printDoc}
        printPreview.ShowDialog()
    End Sub


    ' Method to format and print the content
    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        ' Fonts and layout settings
        Dim fontTitle As New Font("Arial", 18, FontStyle.Bold)
        Dim fontContent As New Font("Arial", 10)
        Dim fontHeader As New Font("Arial", 12, FontStyle.Bold)
        Dim fontSubHeader As New Font("Arial", 12, FontStyle.Italic)
        Dim startX As Integer = 50
        Dim startY As Integer = 50
        Dim offsetY As Integer = startY

        ' School Logo
        Dim schoolLogo As Image = My.Resources.logo
        Dim logoSize As New Size(75, 75)
        e.Graphics.DrawImage(schoolLogo, New Rectangle(startX, startY, logoSize.Width, logoSize.Height))

        ' School Details
        e.Graphics.DrawString("Chempaka International School", fontTitle, Brushes.Black, startX + logoSize.Width + 15, startY)
        e.Graphics.DrawString("Jalan Setia Bakti 1, Bukit Damansara, 50490 Kuala Lumpur, Wilayah Persekutuan Kuala Lumpur", fontContent, Brushes.Black, startX + logoSize.Width + 15, startY + 30)
        e.Graphics.DrawString("Phone: 03-2093 1740, Email: enquiry@cempaka.edu.my", fontContent, Brushes.Black, startX + logoSize.Width + 15, startY + 50)

        ' Horizontal Line
        offsetY += 80
        e.Graphics.DrawLine(New Pen(Color.Gray, 2), startX, offsetY, e.PageBounds.Width - startX, offsetY)
        offsetY += 20

        ' Section Header - Student Information
        e.Graphics.DrawString("Student Information", fontHeader, Brushes.Black, startX, offsetY)
        offsetY += 30

        ' Student Information Table
        Dim tableWidth As Integer = e.PageBounds.Width - 2 * startX
        Dim rowHeight As Integer = 25
        Dim columnWidth As Integer = tableWidth / 2
        Dim fields As String() = {"Student ID", "Name", "Email", "Class"}
        Dim values As String() = {StudentIDTextBox.Text, StudentNameTextBox.Text, StudentEmailTextBox.Text, ClassTextBox.Text}

        ' Draw Table Header
        e.Graphics.FillRectangle(Brushes.LightGray, New Rectangle(startX, offsetY, tableWidth, rowHeight))
        e.Graphics.DrawRectangle(Pens.Black, startX, offsetY, tableWidth, rowHeight)
        e.Graphics.DrawString("Field", fontSubHeader, Brushes.Black, startX + 5, offsetY + 5)
        e.Graphics.DrawString("Value", fontSubHeader, Brushes.Black, startX + columnWidth, offsetY + 5)
        offsetY += rowHeight

        ' Draw Student Info Rows
        For i As Integer = 0 To fields.Length - 1
            e.Graphics.DrawRectangle(Pens.Black, startX, offsetY, tableWidth, rowHeight)
            e.Graphics.DrawString(fields(i), fontContent, Brushes.Black, startX + 5, offsetY + 5)
            e.Graphics.DrawString(values(i), fontContent, Brushes.Black, startX + columnWidth, offsetY + 5)
            offsetY += rowHeight
        Next
        offsetY += 30

        ' Section Header - Registered Subjects
        e.Graphics.DrawString("Registered Subjects", fontHeader, Brushes.Black, startX, offsetY)
        offsetY += 30

        ' Registered Subjects Table
        Dim subjectsTableWidth As Integer = tableWidth
        Dim subjectsRowHeight As Integer = 25
        Dim colWidth1 As Integer = 150
        Dim colWidth2 As Integer = 150
        Dim colWidth3 As Integer = 100
        Dim colWidth4 As Integer = 100

        ' Header Row for Subjects
        e.Graphics.FillRectangle(Brushes.LightGray, New Rectangle(startX, offsetY, subjectsTableWidth, subjectsRowHeight))
        e.Graphics.DrawRectangle(Pens.Black, startX, offsetY, subjectsTableWidth, subjectsRowHeight)
        e.Graphics.DrawString("Subject Code", fontSubHeader, Brushes.Black, startX + 5, offsetY + 5)
        e.Graphics.DrawString("Subject Name", fontSubHeader, Brushes.Black, startX + colWidth1, offsetY + 5)
        e.Graphics.DrawString("Credit Hour", fontSubHeader, Brushes.Black, startX + colWidth1 + colWidth2, offsetY + 5)
        e.Graphics.DrawString("Grade", fontSubHeader, Brushes.Black, startX + colWidth1 + colWidth2 + colWidth3, offsetY + 5)
        offsetY += subjectsRowHeight

        ' Horizontal Line after Header
        e.Graphics.DrawLine(Pens.Black, startX, offsetY, e.PageBounds.Width - startX, offsetY)
        offsetY += 5

        ' Registered Subjects Rows
        For Each row As DataGridViewRow In StudentSubjectGradeDataGridView.Rows
            If Not row.IsNewRow Then
                Dim subjectCode As String = row.Cells("SubjectCode").Value.ToString()
                Dim subjectName As String = row.Cells("SubjectName").Value.ToString()
                Dim creditHour As String = row.Cells("SubjectCreditHour").Value.ToString()
                Dim grade As String = row.Cells("SubjectGrade").Value.ToString()

                e.Graphics.DrawRectangle(Pens.Black, startX, offsetY, subjectsTableWidth, subjectsRowHeight)
                e.Graphics.DrawString(subjectCode, fontContent, Brushes.Black, startX + 5, offsetY + 5)
                e.Graphics.DrawString(subjectName, fontContent, Brushes.Black, startX + colWidth1, offsetY + 5)
                e.Graphics.DrawString(creditHour, fontContent, Brushes.Black, startX + colWidth1 + colWidth2, offsetY + 5)
                e.Graphics.DrawString(grade, fontContent, Brushes.Black, startX + colWidth1 + colWidth2 + colWidth3, offsetY + 5)
                offsetY += subjectsRowHeight
            End If
        Next

        ' Thank You Note and Footer
        offsetY += 40
        e.Graphics.DrawString("Thank you for your attention.", fontContent, Brushes.Black, startX, offsetY)
        offsetY += 30
        e.Graphics.DrawString("Page 1", fontContent, Brushes.Black, e.MarginBounds.Right - 50, e.MarginBounds.Bottom - 20)
    End Sub

    Private Sub Panel_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel.Scroll
        ' Ensure Smooth Scrolling
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    Private Sub EmailBtn_Click(sender As Object, e As EventArgs) Handles EmailBtn.Click
        ' Construct the Gmail compose URL
        Dim gmailComposeUrl As String = "https://mail.google.com/mail/#compose"

        ' Open the default web browser with the Gmail compose URL
        Try
            Process.Start(gmailComposeUrl)
        Catch ex As Exception
            MessageBox.Show("Could not open the web browser. Please ensure you have a default web browser set up.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
