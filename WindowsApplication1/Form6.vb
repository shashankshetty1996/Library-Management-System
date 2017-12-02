Imports System.Data.SqlClient
Public Class Form6
    Private Function checkbnum(ByVal bnum As Integer) As Boolean
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        dt = New DataTable()
        adp = New SqlDataAdapter("select * from books where bnum=" & bnum, con)

        adp.Fill(dt)
        If dt.Rows.Count = 0 Then
            Return True
        End If
        Return False
    End Function
    Private Function display()
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("Select * from books", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
        Return Nothing
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sqlcmd As SqlCommand
        Dim query As String
        Dim bnum As Integer = Val(TextBox1.Text)

        If TextBox1.Text = "" Then
            MsgBox("Please Enter the BookNumber", vbExclamation, "Warning")
            Exit Sub
        End If

        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Book Number should be number only", vbExclamation, "Warning")
            Exit Sub
        End If

        If checkbnum(bnum) = True Then
            MsgBox("Book Number Not found", vbExclamation, "Warning")
            Exit Sub
        End If

        query = "delete from books where bnum =" & bnum
        Try
            If MsgBox("Are you sure you want to delete", vbYesNo, "Warning!!!") = vbYes Then
                sqlcmd = New SqlCommand(query, con)
                sqlcmd.ExecuteNonQuery()
                MsgBox("A book has been deleted", vbExclamation, "Please press on refresh")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form6_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Form5.Show()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.LibraryDataSet.books)
        Call display()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form7.Show()
        Call display()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form8.Show()
        Call display()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Call display()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class