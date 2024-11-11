Imports MySql.Data.MySqlClient
Imports System.IO

Public Class StaffMainForm
    Private connectionString As String = "server=localhost;user id=root;database=school_db;"
    Private staffUsername As String ' Variable to hold the staff username

    ' Constructor that accepts the username
    Public Sub New(username As String)
        InitializeComponent()
        staffUsername = username
    End Sub

    ' Load event for the form
    Private Sub StaffMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaffProfile()
    End Sub

    ' Method to load staff profile information
    Private Sub LoadStaffProfile()
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT name, picture FROM staff WHERE username=@username"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", staffUsername)

                ' Execute the command and read the staff name and profile picture
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Get the staff name
                        Dim staffName As String = reader("name").ToString()
                        StaffNameLabel.Text = "Welcome, " & staffName ' Set the label text to the staff name

                        ' Get the profile picture path
                        Dim picturePath As String = reader("picture").ToString()
                        If Not String.IsNullOrEmpty(picturePath) Then
                            Dim fullImagePath As String = Path.Combine(Application.StartupPath, picturePath)
                            If File.Exists(fullImagePath) Then
                                ProfilePictureBox.Image = Image.FromFile(fullImagePath)
                            Else
                                ProfilePictureBox.Image = My.Resources._default ' Set a default image if the file does not exist
                            End If
                        Else
                            ProfilePictureBox.Image = My.Resources._default ' Set a default image if no picture path is found
                        End If
                    Else
                        MessageBox.Show("Staff not found.")
                    End If
                End Using
            End Using
        End Using
    End Sub

End Class