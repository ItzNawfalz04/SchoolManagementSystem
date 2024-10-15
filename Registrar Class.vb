Imports MySql.Data.MySqlClient
Public Class Registrar_Class

    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim id As Integer

    Private Sub Registrar_Class_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Server=localhost;Database=school_db;Uid=root;Pwd=''"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        disp_data()

    End Sub

    Public Sub disp_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from class"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into class values(NULL,'" + TextBox1.Text + "' , '" + TextBox2.Text + "' , '" + TextBox3.Text + "')"
        cmd.ExecuteNonQuery()

        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "

        disp_data()

        MessageBox.Show("Record Save Successfully")

    End Sub

    Private Sub viewBtn_Click(sender As Object, e As EventArgs) Handles viewBtn.Click

        disp_data()

    End Sub

    Private Sub updBtn_Click(sender As Object, e As EventArgs) Handles updBtn.Click

    End Sub

    Private Sub srcBtn_Click(sender As Object, e As EventArgs) Handles srcBtn.Click

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from class where name='" + TextBox1.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub
End Class
