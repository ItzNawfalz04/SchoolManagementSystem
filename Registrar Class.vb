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
        cmd.CommandText = "insert into class values(NULL,'" + TextBox1.Text + "' , '" + TextBox2.Text + "' , '" + TextBox3.Text + "' , '" + FormComboBox1.Text + "')"
        cmd.ExecuteNonQuery()

        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "

        disp_data()

        MessageBox.Show("Record Save Successfully!")

    End Sub

    Private Sub viewBtn_Click(sender As Object, e As EventArgs) Handles viewBtn.Click

        disp_data()

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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        id = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from class where id=" & id & ""
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read

            TextBox1.Text = dr.GetString(1).ToString()
            TextBox2.Text = dr.GetString(2).ToString()
            TextBox3.Text = dr.GetString(3).ToString()
            FormComboBox1.Text = dr.GetString(4).ToString()

        End While
    End Sub

    Private Sub updBtn_Click(sender As Object, e As EventArgs) Handles updBtn.Click

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        Try

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update class set name='" + TextBox1.Text + "',teacher='" + TextBox2.Text + "',location='" + TextBox3.Text + "',form='" + FormComboBox1.Text + "' where id=" & id & ""
            cmd.ExecuteNonQuery()

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            FormComboBox1.Text = ""

            disp_data()

            MessageBox.Show("Update Selected Class Successfully!")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dltBtn_Click(sender As Object, e As EventArgs) Handles dltBtn.Click

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        Try

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from class where id=" & id & ""
            cmd.ExecuteNonQuery()

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            FormComboBox1.Text = ""

            disp_data()

            MessageBox.Show("Delete Selected Class Successfully!")


        Catch ex As Exception

        End Try

    End Sub

    Private Sub clrBtn_Click(sender As Object, e As EventArgs) Handles clrBtn.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        FormComboBox1.Text = ""

    End Sub
End Class
