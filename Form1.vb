Public Class Form1



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

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        Label6.Text = ProgressBar1.Value & "% Completed"


        If ProgressBar1.Value = 100 Then
            Timer1.Stop()


            If TextBox1.Text <> "amadi@123.com" Then

                MsgBox(" Fadlan Email Sax Soo Gali")
                TextBox1.Focus()
                ProgressBar1.Value = 0
                Label6.Text = ""

            ElseIf TextBox1.Text = "" Then

                MsgBox(" Fadlan Email soo gali")
                TextBox1.Focus()
                ProgressBar1.Value = 0
                Label6.Text = ""


            ElseIf TextBox2.Text <> "1234" Then

                MsgBox(" Fadlan password sax soo gali")
                TextBox2.Focus()
                ProgressBar1.Value = 0
                Label6.Text = ""

            ElseIf TextBox2.Text = "" Then

                MsgBox("Fadlan Password Soo gali...")
                TextBox2.Focus()
                ProgressBar1.Value = 0
                Label6.Text = ""


            Else

                ProgressBar1.Value = 0
                Label6.Text = ""

                Me.Hide()

                Dim dashboard As New Dashboard()



                dashboard.Show()



            End If
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
