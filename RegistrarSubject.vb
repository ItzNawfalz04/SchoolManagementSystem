Imports MySql.Data.MySqlClient

Public Class RegistrarSubject
    Dim isAddMode As Boolean = False ' Track if we are in Add mode
    Dim isEditMode As Boolean = False ' Track if we are in Edit mode
    Dim originalSubjectID As Integer ' To store the selected subject ID

    ' Form Load Event - Load subject data into the DataGridView when the form loads
    Private Sub RegistrarSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubjectData()
        SetDefaultFormState()
        LoadCreditHours() ' Load credit hours into the ComboBox
    End Sub

    ' Method to load subject data from the database into the DataGridView
    Private Sub LoadSubjectData()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "SELECT SubjectID, SubjectCode, SubjectName, SubjectRemarks, SubjectCreditHour FROM subject"
        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Set the DataSource of the DataGridView to the loaded data
            SubjectDataGridView.DataSource = dataTable
        End Using
    End Sub

    ' Load credit hours into the CreditHourComboBox
    Private Sub LoadCreditHours()
        ' Assuming credit hours are integers from 1 to 6
        For i As Integer = 1 To 6
            CreditHourComboBox.Items.Add(i)
        Next
    End Sub

    ' Set default form state (textboxes disabled, buttons in default state)
    Private Sub SetDefaultFormState()
        EnableInputControls(False)
        AddBtn.Text = "Add"
        AddBtn.BackColor = Color.Teal
        EditBtn.Text = "Edit"
        DeleteBtn.Visible = True
        ClearBtn.Visible = True
        isAddMode = False
        isEditMode = False
    End Sub

    ' Enable or disable input controls (TextBoxes)
    Private Sub EnableInputControls(enable As Boolean)
        IDTextBox.Enabled = False ' SubjectID is auto-generated, so always disabled
        SubjectCodeTextBox.Enabled = enable
        SubjectNameTextBox.Enabled = enable
        RemarksTextBox.Enabled = enable
        CreditHourComboBox.Enabled = enable ' Enable the CreditHourComboBox
    End Sub

    ' Event to handle row selection in SubjectDataGridView - populate TextBoxes with selected subject data
    Private Sub SubjectDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SubjectDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = SubjectDataGridView.Rows(e.RowIndex)

            If selectedRow IsNot Nothing AndAlso selectedRow.Cells("SubjectID").Value IsNot DBNull.Value Then
                ' Populate the TextBoxes with the selected subject data
                IDTextBox.Text = selectedRow.Cells("SubjectID").Value.ToString()
                SubjectCodeTextBox.Text = selectedRow.Cells("SubjectCode").Value.ToString()
                SubjectNameTextBox.Text = selectedRow.Cells("SubjectName").Value.ToString()
                RemarksTextBox.Text = selectedRow.Cells("SubjectRemarks").Value.ToString()
                CreditHourComboBox.SelectedItem = selectedRow.Cells("SubjectCreditHour").Value ' Set selected credit hour

                EnableInputControls(False) ' Disable controls initially
            End If
        End If
    End Sub

    ' Handle Add Button Click - Add or Save new subject
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
            ' Save new subject to the database
            If ValidateInputFields() Then
                SaveNewSubject()
                LoadSubjectData() ' Reload data after adding
                SetDefaultFormState() ' Reset the form
            End If
        ElseIf isEditMode Then
            ' Save edited subject to the database
            If ValidateInputFields() Then
                SaveEditedSubject()
                LoadSubjectData() ' Reload data after editing
                SetDefaultFormState() ' Reset the form
            End If
        End If
    End Sub

    ' Handle Edit Button Click - Edit or Cancel editing subject
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
                Dim selectedRow As DataGridViewRow = SubjectDataGridView.Rows(SubjectDataGridView.SelectedCells(0).RowIndex)
                IDTextBox.Text = selectedRow.Cells("SubjectID").Value.ToString()
                SubjectCodeTextBox.Text = selectedRow.Cells("SubjectCode").Value.ToString()
                SubjectNameTextBox.Text = selectedRow.Cells("SubjectName").Value.ToString()
                RemarksTextBox.Text = selectedRow.Cells("SubjectRemarks").Value.ToString()
                CreditHourComboBox.SelectedItem = selectedRow.Cells("SubjectCreditHour").Value ' Set selected credit hour
                SetDefaultFormState()
            Else
                ' Save edited subject to the database
                If ValidateInputFields() Then
                    SaveEditedSubject()
                    LoadSubjectData() ' Reload data after editing
                    SetDefaultFormState() ' Reset the form
                End If
            End If
        ElseIf isAddMode Then
            ' Cancel Add mode
            ClearInputFields()
            SetDefaultFormState()
        End If
    End Sub

    ' Handle Delete Button Click - Delete selected subject
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If IDTextBox.Text <> "" Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteSubject()
                LoadSubjectData() ' Reload data after deleting
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
        SubjectCodeTextBox.Clear()
        SubjectNameTextBox.Clear()
        RemarksTextBox.Clear()
        CreditHourComboBox.SelectedIndex = -1 ' Clear selected credit hour
    End Sub

    ' Method to validate input fields before saving
    Private Function ValidateInputFields() As Boolean
        If SubjectCodeTextBox.Text = "" Or SubjectNameTextBox.Text = "" Or CreditHourComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Subject Code, Subject Name, and Credit Hour must be filled!")
            Return False
        End If
        Return True
    End Function

    ' Method to save new subject to the database
    Private Sub SaveNewSubject()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "INSERT INTO subject (SubjectCode, SubjectName, SubjectRemarks, SubjectCreditHour) VALUES (@SubjectCode, @SubjectName, @SubjectRemarks, @SubjectCreditHour)"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SubjectCode", SubjectCodeTextBox.Text)
                    cmd.Parameters.AddWithValue("@SubjectName", SubjectNameTextBox.Text)
                    cmd.Parameters.AddWithValue("@SubjectRemarks", RemarksTextBox.Text)
                    cmd.Parameters.AddWithValue("@SubjectCreditHour", CreditHourComboBox.SelectedItem)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("New subject added successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error adding subject: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Method to save edited subject to the database
    Private Sub SaveEditedSubject()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "UPDATE subject SET SubjectCode=@SubjectCode, SubjectName=@SubjectName, SubjectRemarks=@SubjectRemarks, SubjectCreditHour=@SubjectCreditHour WHERE SubjectID=@SubjectID"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SubjectID", IDTextBox.Text)
                    cmd.Parameters.AddWithValue("@SubjectCode", SubjectCodeTextBox.Text)
                    cmd.Parameters.AddWithValue("@SubjectName", SubjectNameTextBox.Text)
                    cmd.Parameters.AddWithValue("@SubjectRemarks", RemarksTextBox.Text)
                    cmd.Parameters.AddWithValue("@SubjectCreditHour", CreditHourComboBox.SelectedItem)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Subject data updated successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error updating subject: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Method to delete subject from the database
    Private Sub DeleteSubject()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "DELETE FROM subject WHERE SubjectID=@SubjectID"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SubjectID", IDTextBox.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Subject deleted successfully!")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error deleting subject: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Panel_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel.Scroll
        ' Ensure Smooth Scrolling
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    ' Handle SearchTextBox TextChanged event - Filter subject data as user types
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        If SearchTextBox.Text <> "" Then
            FilterSubjectData(SearchTextBox.Text)
        Else
            LoadSubjectData() ' Reload all subject data if search text is empty
        End If
    End Sub

    ' Method to filter subject data based on search text
    Private Sub FilterSubjectData(searchText As String)
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "SELECT SubjectID, SubjectCode, SubjectName, SubjectRemarks, SubjectCreditHour FROM subject " &
                              "WHERE SubjectCode LIKE @searchText OR SubjectName LIKE @searchText"
        Using conn As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            SubjectDataGridView.DataSource = dataTable
        End Using
    End Sub
End Class