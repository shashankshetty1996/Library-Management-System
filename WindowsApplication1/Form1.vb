Public Class Form1
    Private Sub ComputerScienceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComputerScienceToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub LibrarianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrarianToolStripMenuItem.Click
        Dim NewMDIChild As New Form4()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        loading.Close()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'AboutBox1.ShowDialog()
        Dim NewMDIChild As New AboutBox1()
        'Set the Parent Form of the Child window.
        NewMDIChild.MdiParent = Me
        'Display the new form.
        NewMDIChild.Show()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        BackgroundImageLayout = ImageLayout.Stretch
    End Sub
End Class
