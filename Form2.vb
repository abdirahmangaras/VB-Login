Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.IO
Imports System.Configuration
Public Class Form2
    Dim connectionString As String = "Data Source=.;Initial Catalog=VBprojects;Integrated Security=True"
    Dim cn As New SqlConnection(connectionString)
    Dim cmd As New SqlCommand
    Dim dr As SqlDataAdapter
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Form1.Show()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Dashboard.Show()


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If IsNumeric(TextBox3.Text) = True Then
            MsgBox("Enter Only Text")
            TextBox1.Focus()
        End If

        If Not IsNumeric(TextBox3.Text) = False Then

        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text.Trim() <> "" Then
            Dim str As String = "Data Source=.;Initial Catalog=VBprojects;Integrated Security=True"
            Dim sql As String = "INSERT INTO students (firstName,lastName,semister,batch,studentid,pwd) values (@fname,@lname,@foculty, @batch ,@studentid,@pwd)"
            Using Conn As New SqlConnection(str)
                Using cmd As New SqlCommand(sql, Conn)
                    Conn.Open()
                    cmd.Parameters.AddWithValue("@fname", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@lname", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@foculty", ComboBox1.Text)
                    cmd.Parameters.AddWithValue("@batch", ComboBox3.Text)
                    cmd.Parameters.AddWithValue("@studentid", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@pwd", TextBox4.Text)
                    Dim value = cmd.ExecuteScalar()

                    If value > 0 Then
                        MessageBox.Show("Register successFull!")
                        Me.Hide()

                        Dim dashboard As New Dashboard()
                        dashboard.Show()
                    Else
                        MessageBox.Show("Register SuccessFully")
                    End If
                End Using
            End Using
        Else
            MsgBox("Please Enter Your ID")
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""


    End Sub

    Private Sub SqlConnection1_InfoMessage(sender As Object, e As SqlInfoMessageEventArgs) Handles SqlConnection1.InfoMessage

    End Sub

    Private Sub SqlConnection2_InfoMessage(sender As Object, e As SqlInfoMessageEventArgs) Handles SqlConnection2.InfoMessage

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) = True Then
            MsgBox("Enter Only Text")
            TextBox1.Focus()
        End If

        If Not IsNumeric(TextBox1.Text) = False Then

        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
    End Sub
End Class