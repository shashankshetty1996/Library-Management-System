Imports System.Threading

Public Class loading
    Private Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.ContextMenuStrip.BackColor = Color.Black
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form1.Show()
            Hide()

        End If
    End Sub
End Class