Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.IO
Imports System.Configuration
Public Class Form1
    Dim connectionString As String = "Data Source=.;Initial Catalog=VBprojects;Integrated Security=True"
    Dim cn As New SqlConnection(connectionString)
    Dim cmd As New SqlCommand
    Dim dr As SqlDataAdapter


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Dim str As String = "Data Source=.;Initial Catalog=VBprojects;Integrated Security=True"
        Dim sql As String = "select count(*) from students where studentid=@studentid and pwd=@pwd"
        Using Conn As New SqlConnection(str)
            Using cmd As New SqlCommand(sql, Conn)
                Conn.Open()
                cmd.Parameters.AddWithValue("@studentid", TextBox1.Text)
                cmd.Parameters.AddWithValue("@pwd", TextBox2.Text)
                Dim value = cmd.ExecuteScalar()
                If value > 0 Then
                    MessageBox.Show("Login sucessfully!")
                    'Label11.Text = TextBox5.Text
                    Me.Hide()

                    Dim dashboard As New Dashboard()
                    dashboard.Show()
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                Else
                    MessageBox.Show("Incorrect ID or Password")
                End If
            End Using
        End Using


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        Label6.Text = ProgressBar1.Value & "% Completed"


        If ProgressBar1.Value = 100 Then
            Timer1.Stop()



            If TextBox1.Text = "" Then



                MsgBox(" Fadlan ID soo gali")
                TextBox1.Focus()
                ProgressBar1.Value = 0
                Label6.Text = ""


            ElseIf TextBox2.Text = "" Then

                MsgBox("Fadlan Password Soo gali...")
                'TextBox2.Focus()
                ProgressBar1.Value = 0
                Label6.Text = ""


            Else

                ProgressBar1.Value = 0
                Label6.Text = ""





            End If
        End If
    End Sub



    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
