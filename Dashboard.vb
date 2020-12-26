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

    Public Sub RegisteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisteToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()


    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click

        Form1.Show()

    End Sub




    Public Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()

    End Sub

    Public Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form3.Show()
    End Sub

    Public Sub VoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoteToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form4.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
