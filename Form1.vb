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



        If TextBox1.Text <> "amadi@123.com" Then

            MsgBox(" Fadlan Email Sax Soo Gali")

        ElseIf TextBox1.Text = "" Then

            MsgBox(" Fadlan Email soo gali")

        ElseIf TextBox2.Text = "" Then

            MsgBox(" Fadlan password soo gali")
        Else
            MsgBox(" Waad Ku Mahadsan Tahay Inaad Soo Gashid!")



        End If









    End Sub
End Class
