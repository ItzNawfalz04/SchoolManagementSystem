Imports MySql.Data.MySqlClient
Imports System.IO

Public Class StaffDashboard
    Private originalStaffID As Integer ' To store the staff ID of the logged-in user
    Private isEditing As Boolean = False ' Track editing mode
    Private connectionString As String = "server=localhost;user id=root;database=school_db;" ' Database connection string

    ' Constructor to accept the staff ID
    Public Sub New(staffID As Integer)
        InitializeComponent() ' Initialize the form components
        originalStaffID = staffID ' Set the staff ID
    End Sub

    ' Form Load Event - Load staff data and counts when the form loads
    Private Sub StaffDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaffData()
        LoadCounts() ' Load the counts for students, teachers, and staff
        SetViewMode()
    End Sub

    ' Method to load staff data for the logged-in user
    Private Sub LoadStaffData()
        Dim query As String = "SELECT StaffID, name, gender, birthday, email, phone, ic, username, password, picture FROM staff WHERE StaffID = @StaffID"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@StaffID", originalStaffID) ' Use staff ID passed during login
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        StaffIDTextBox.Text = reader("StaffID").ToString()
                        StaffNameTextBox.Text = reader("name").ToString()
                        GenderComboBox.Text = reader("gender").ToString()
                        BirthdayDateTimePicker.Value = DateTime.Parse(reader("birthday").ToString())
                        StaffEmailTextBox.Text = reader("email").ToString()
                        PhoneTextBox.Text = reader("phone").ToString()
                        StaffICTextBox.Text = reader("ic").ToString()
                        StaffUsernameTextBox.Text = reader("username").ToString()
                        StaffPasswordTextBox.Text = reader("password").ToString()

                        Dim picturePath As String = reader("picture").ToString()
                        If Not String.IsNullOrEmpty(picturePath) AndAlso File.Exists(Path.Combine(Application.StartupPath, picturePath)) Then
                            StaffPictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, picturePath))
                        Else
                            StaffPictureBox.Image = My.Resources._default
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub

    ' Method to load counts for students, teachers, and staff
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
        StaffIDTextBox.Enabled = False ' StaffID should not be editable
        StaffNameTextBox.Enabled = enable
        GenderComboBox.Enabled = enable
        BirthdayDateTimePicker.Enabled = enable
        StaffEmailTextBox.Enabled = enable
        PhoneTextBox.Enabled = enable
        StaffICTextBox.Enabled = enable
        StaffUsernameTextBox.Enabled = enable
        StaffPasswordTextBox.Enabled = enable
    End Sub

    ' Handle Edit Button Click - Toggle between Edit and Cancel mode
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If isEditing Then
            SetViewMode() ' Cancel editing
            LoadStaffData() ' Reload original data
        Else
            SetEditMode() ' Enable editing
        End If
    End Sub

    ' Handle Save Button Click - Save changes
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If ValidateInputFields() Then
            SaveEditedStaff()
            MessageBox.Show("Staff information updated successfully!")
            SetViewMode()
            LoadStaffData() ' Reload saved data
        End If
    End Sub

    ' Method to validate input fields before saving
    Private Function ValidateInputFields() As Boolean
        If String.IsNullOrWhiteSpace(StaffNameTextBox.Text) OrElse
           GenderComboBox.SelectedIndex = -1 OrElse
           String.IsNullOrWhiteSpace(StaffEmailTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(PhoneTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(StaffUsernameTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(StaffPasswordTextBox.Text) Then
            MessageBox.Show("All fields must be filled!")
            Return False
        End If
        Return True
    End Function

    ' Method to save edited staff data to the database
    Private Sub SaveEditedStaff()
        Dim connectionString As String = "server=localhost;user id=root;database=school_db;"
        Dim query As String = "UPDATE staff SET name=@name, gender=@gender, birthday=@birthday, email=@email, phone=@phone, " &
                              "ic=@ic, username=@username, password=@password, picture=@picture WHERE StaffID=@StaffID"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StaffID", StaffIDTextBox.Text)
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
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error updating staff: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Handle Import Button Click - Import picture for staff
    Private Sub ImportBtn_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim img As Image = Image.FromFile(openFileDialog.FileName)
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

    Private Sub Panel_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel.Scroll
        ' Ensure Smooth Scrolling
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel.VerticalScroll.Value = e.NewValue
        End If
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
End Class
