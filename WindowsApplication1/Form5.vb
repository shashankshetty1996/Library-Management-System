Public Class Form5
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Form5_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Button1.Hide()
        'Button2.Hide()
        'Button4.Hide()
        'Button5.Hide()
        'Button6.Hide()
        'Button7.Hide()
        'Button8.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form9.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form10.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form11.Show()
    End Sub
End Class