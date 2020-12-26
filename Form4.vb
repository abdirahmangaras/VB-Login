Imports System.Windows.Forms

Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.IO
Imports System.Configuration
Imports System.Data.OleDb



Public Class Form4
    Dim connectionString As String = "Data Source=.;Initial Catalog=VBprojects;Integrated Security=True"
    Dim cn As New SqlConnection(connectionString)
    Dim cmd As New SqlCommand
    Dim dr As SqlDataAdapter

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "select candName , sum(votes) as total_votes from president group by candName order by total_votes"
        Dim rdr As SqlDataReader = cmd.ExecuteReader
        Dim dtable As New DataTable

        dtable.Load(rdr)
        rdr.Close()
        DataGridView1.DataSource = dtable


        cn.Close()

    End Sub

    Private Sub OleDbConnection1_InfoMessage(sender As Object, e As OleDbInfoMessageEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "select candName , sum(votes) as total_votes from Vice group by candName order by total_votes"
        Dim rdr As SqlDataReader = cmd.ExecuteReader
        Dim dtable As New DataTable

        dtable.Load(rdr)
        rdr.Close()
        DataGridView2.DataSource = dtable


        cn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "select candName , sum(votes) as total_votes from sect group by candName order by total_votes"
        Dim rdr As SqlDataReader = cmd.ExecuteReader
        Dim dtable As New DataTable

        dtable.Load(rdr)
        rdr.Close()
        DataGridView3.DataSource = dtable


        cn.Close()
    End Sub
End Class