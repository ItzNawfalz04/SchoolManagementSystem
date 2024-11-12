Imports MySql.Data.MySqlClient
Imports System.IO

Public Class TeacherDashboard
    Private originalTeacherID As Integer ' To store the teacher ID of the logged-in user
    Private isEditing As Boolean = False ' Track editing mode
    Private connectionString As String = "server=localhost;user id=root;database=school_db;" ' Database connection string

    ' Constructor to accept the teacher ID
    Public Sub New(teacherID As Integer)
        InitializeComponent() ' Initialize the form components
        originalTeacherID = teacherID ' Set the teacher ID
    End Sub

    ' Form Load Event - Load teacher data and counts when the form loads
    Private Sub TeacherDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTeacherData()
        LoadCounts() ' Load the counts for students, teachers, and staff
        SetViewMode()
    End Sub

    ' Method to load teacher data for the logged-in user
    Private Sub LoadTeacherData()
        Dim query As String = "SELECT TeacherID, name, gender, phone, birthday, email, ic, username, password, picture FROM teacher WHERE TeacherID = @TeacherID"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@TeacherID", originalTeacherID) ' Use teacher ID passed during login
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        TeacherIDTextBox.Text = reader("TeacherID").ToString()
                        TeacherNameTextBox.Text = reader("name").ToString()
                        GenderComboBox.Text = reader("gender").ToString()
                        PhoneTextBox.Text = reader("phone").ToString()
                        BirthdayDateTimePicker.Value = DateTime.Parse(reader("birthday").ToString())
                        TeacherEmailTextBox.Text = reader("email").ToString()
                        TeacherICTextBox.Text = reader("ic").ToString()
                        TeacherUsernameTextBox.Text = reader("username").ToString()
                        TeacherPasswordTextBox.Text = reader("password").ToString()

                        Dim picturePath As String = reader("picture").ToString()
                        If Not String.IsNullOrEmpty(picturePath) AndAlso File.Exists(Path.Combine(Application.StartupPath, picturePath)) Then
                            TeacherPictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, picturePath))
                        Else
                            TeacherPictureBox.Image = My.Resources._default
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub

    ' Method to load counts for students and teachers
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

    ' Set form to view mode (disable inputs, adjust button text)
    Private Sub SetViewMode()
        isEditing = False
        EnableInputControls(False)
        EditBtn.Text = "Edit"
        SaveBtn.Visible = False
        ImportButton.Visible = False
        RemoveButton.Visible = False
    End Sub

    ' Set form to editing mode (enable inputs, adjust button text)
    Private Sub SetEditMode()
        isEditing = True
        EnableInputControls(True)
        EditBtn.Text = "Cancel"
        SaveBtn.Visible = True
        ImportButton.Visible = True
        RemoveButton.Visible = True
    End Sub

    ' Enable or disable input controls
    Private Sub EnableInputControls(enable As Boolean)
        TeacherIDTextBox.Enabled = False ' TeacherID should not be editable
        TeacherNameTextBox.Enabled = enable
        GenderComboBox.Enabled = enable
        PhoneTextBox.Enabled = enable
        BirthdayDateTimePicker.Enabled = enable
        TeacherEmailTextBox.Enabled = enable
        TeacherICTextBox.Enabled = enable
        TeacherUsernameTextBox.Enabled = enable
        TeacherPasswordTextBox.Enabled = enable
    End Sub

    ' Handle Edit Button Click - Toggle between Edit and Cancel mode
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If isEditing Then
            SetViewMode() ' Cancel editing
            LoadTeacherData() ' Reload original data
        Else
            SetEditMode() ' Enable editing
        End If
    End Sub

    ' Handle Save Button Click - Save changes
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If ValidateInputFields() Then
            SaveEditedTeacher()
            MessageBox.Show("Teacher information updated successfully!")
            SetViewMode()
            LoadTeacherData() ' Reload saved data
        End If
    End Sub

    ' Method to validate input fields before saving
    Private Function ValidateInputFields() As Boolean
        If String.IsNullOrWhiteSpace(TeacherNameTextBox.Text) OrElse
           GenderComboBox.SelectedIndex = -1 OrElse
           String.IsNullOrWhiteSpace(TeacherEmailTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(PhoneTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(TeacherICTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(TeacherUsernameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(TeacherPasswordTextBox.Text) Then
            MessageBox.Show("All fields must be filled!")
            Return False
        End If
        Return True
    End Function

    ' Method to save edited teacher data to the database
    Private Sub SaveEditedTeacher()
        Dim query As String = "UPDATE teacher SET name=@name, gender=@gender, phoen=@phone, birthday=@birthday, email=@email, " &
                              "ic=@ic, username=@username, password=@password, picture=@picture WHERE TeacherID=@TeacherID"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TeacherID", TeacherIDTextBox.Text)
                    cmd.Parameters.AddWithValue("@name", TeacherNameTextBox.Text)
                    cmd.Parameters.AddWithValue("@gender", GenderComboBox.Text)
                    cmd.Parameters.AddWithValue("@phone", PhoneTextBox.Text)
                    cmd.Parameters.AddWithValue("@birthday", BirthdayDateTimePicker.Value)
                    cmd.Parameters.AddWithValue("@email", TeacherEmailTextBox.Text)
                    cmd.Parameters.AddWithValue("@ic", TeacherICTextBox.Text)
                    cmd.Parameters.AddWithValue("@username", TeacherUsernameTextBox.Text)
                    cmd.Parameters.AddWithValue("@password", TeacherPasswordTextBox.Text)
                    Dim imagePath As String = SaveImage(TeacherPictureBox.Image)
                    cmd.Parameters.AddWithValue("@picture", imagePath)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error updating teacher: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Handle Import Button Click - Import picture for teacher
    Private Sub ImportBtn_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim img As Image = Image.FromFile(openFileDialog.FileName)
                TeacherPictureBox.Image = img
                TeacherPictureBox.Tag = SaveImage(img)
            End If
        End Using
    End Sub

    ' Handle Remove Button Click - Remove picture from TeacherPictureBox
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

    Private Sub Panel_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel.Scroll
        ' Ensure Smooth Scrolling
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel.VerticalScroll.Value = e.NewValue
        End If
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
End Class