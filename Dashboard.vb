Imports System.Windows.Forms

Public Class Dashboard





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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Dim das As New Dashboard()

        das.MdiParent = Me
    End Sub

    Private Sub StatusStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip.ItemClicked

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
