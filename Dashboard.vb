Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.IO
Imports System.Configuration


Public Class Dashboard
    Dim connectionString As String = "Data Source=.;Initial Catalog=VBprojects;Integrated Security=True"
    Dim cn As New SqlConnection(connectionString)
    Dim cmd As New SqlCommand
    Dim dr As SqlDataAdapter



    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub RegisteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisteToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()


    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        Form1.Show()







    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim str As String = "Data Source=.;Initial Catalog=VBprojects;Integrated Security=True"
        Dim sql As String = "INSERT INTO president (cID, candName,Position,Votes) values (00, @candName,'President',1)"
        Using Conn As New SqlConnection(str)
            Using cmd As New SqlCommand(sql, Conn)
                Conn.Open()
                cmd.Parameters.AddWithValue("@candName", ComboBox1.Text)



                Dim value = cmd.ExecuteScalar()

                If value > 0 Then
                    MessageBox.Show("Congartulation, You Voted!")
                    Me.Hide()

                    Dim dashboard As New Dashboard()
                    dashboard.Show()
                Else
                    MessageBox.Show("Congartulation, You Voted!")
                End If
            End Using
        End Using

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Dim das As New Dashboard()

        das.MdiParent = Me
    End Sub

    Private Sub StatusStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip.ItemClicked

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub CandiatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CandiatesToolStripMenuItem.Click

    End Sub

    Private Sub VotersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VotersToolStripMenuItem.Click
        Dim result As New Result()
        result.Show()

        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As String = "Data Source=.;Initial Catalog=VBprojects;Integrated Security=True"
        Dim sql As String = "INSERT INTO sectratory (cID, candName,Position,Votes) values (00, @candName,'Sectratory',1)"
        Using Conn As New SqlConnection(str)
            Using cmd As New SqlCommand(sql, Conn)
                Conn.Open()
                cmd.Parameters.AddWithValue("@candName", ComboBox2.Text)



                Dim value = cmd.ExecuteScalar()

                If value > 0 Then
                    MessageBox.Show("Congartulation, You Voted!")
                    Me.Hide()

                    Dim dashboard As New Dashboard()
                    dashboard.Show()
                Else
                    MessageBox.Show("Congartulation, You Voted!")
                End If
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str As String = "Data Source=.;Initial Catalog=VBprojects;Integrated Security=True"
        Dim sql As String = "INSERT INTO Vice (cID, candName,Position,Votes) values (00, @candName,'Vice',1)"
        Using Conn As New SqlConnection(str)
            Using cmd As New SqlCommand(sql, Conn)
                Conn.Open()
                cmd.Parameters.AddWithValue("@candName", ComboBox3.Text)



                Dim value = cmd.ExecuteScalar()

                If value > 0 Then
                    MessageBox.Show("Congartulation, You Voted!")
                    Me.Hide()

                    Dim dashboard As New Dashboard()
                    dashboard.Show()
                Else
                    MessageBox.Show("Congartulation, You Voted!")
                End If
            End Using
        End Using
    End Sub
End Class
