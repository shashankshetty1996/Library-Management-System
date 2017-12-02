Imports System.Data.SqlClient

Public Class Form3
    Private Function display()
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("Select * from books", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
        Return Nothing
    End Function
    Private Sub Form3_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet1.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.LibraryDataSet1.books)
        Label4.Hide()
        Label5.Hide()
        Call display()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Input Box is Empty", vbExclamation, "Warning")
            Exit Sub
        End If
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Please Enter Valid Book Number", vbExclamation, "Warning")
            Exit Sub
        End If

        Dim bnum As Integer = Val(TextBox1.Text)

        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("Select * from books where bnum=" & bnum, con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Input Box is Empty", vbExclamation, "Warning")
            Exit Sub
        End If

        Dim anum As String = TextBox1.Text.ToUpper
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("Select * from books where authorName='" & anum & "' ", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Call display()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Input Box is Empty", vbExclamation, "Warning")
            Exit Sub
        End If

        Dim title As String = TextBox1.Text.ToUpper
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("Select * from books where bname='" & title & "' ", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim bno As Integer
        bno = InputBox("Please Enter Book Number to be borrowed", "Welcome to Book Bank")
        If Not IsNumeric(bno) Then
            MsgBox("Please Enter Valid Book Number which is a Integer value only", vbCritical, "Error Promt")
            Exit Sub
        End If
        Dim query As String

        query = "Select numberOfCopies from books where bnum=" & bno & ""
        Dim avbcopy As Integer
        Dim sqlcmd As SqlCommand

        Try
            sqlcmd = New SqlCommand(query, con)
            avbcopy = sqlcmd.ExecuteScalar()
            If avbcopy = Nothing Then
                MsgBox("Out Of Stock", vbExclamation, "Sorry we ran out of books")
                Exit Sub
            Else
                avbcopy = Val(avbcopy - 1)
                query = "update books set numberOfCopies=" & avbcopy & " where bnum=" & bno & ""
                sqlcmd = New SqlCommand(query, con)
                sqlcmd.ExecuteNonQuery()

                Dim uid As String = Label5.Text
                Dim uname As String = Label2.Text

                If Label4.Text = "student" Then
                    query = "select borrow from studentliblogin where stduserid='" & uid & "'"
                    sqlcmd = New SqlCommand(query, con)
                    Dim brow As Integer = sqlcmd.ExecuteScalar()

                    brow = Val(brow + 1)
                    If brow > 8 Then
                        MsgBox("Maximum a student can borrow 8 books in total", vbExclamation, "Warning")
                        Exit Sub
                    Else
                        query = "update studentliblogin set borrow=" & brow & " where stduserid='" & uid & "'"
                        sqlcmd = New SqlCommand(query, con)
                        sqlcmd.ExecuteNonQuery()
                    End If
                ElseIf Label4.Text = "staff" Then
                    query = "select borrow from leactureliblogin where luserid='" & uid & "'"
                    sqlcmd = New SqlCommand(query, con)
                    Dim brow As Integer = sqlcmd.ExecuteScalar()

                    brow = Val(brow + 1)

                    query = "update leactureliblogin set borrow=" & brow & " where luserid='" & uid & "'"
                    sqlcmd = New SqlCommand(query, con)
                    sqlcmd.ExecuteNonQuery()
                Else
                    MsgBox("Invalid user type")
                End If

                'adding contains to borrow table

                query = "select authorName from books where bnum=" & bno & ""
                sqlcmd = New SqlCommand(query, con)
                Dim authorname As String = sqlcmd.ExecuteScalar()

                query = "select bname from books where bnum=" & bno & ""
                sqlcmd = New SqlCommand(query, con)
                Dim bookname As String = sqlcmd.ExecuteScalar()

                query = "insert into borrowbook values('" & uid & "','" & uname & "'," & bno & ",'" & bookname & "','" & authorname & "')"
                sqlcmd = New SqlCommand(query, con)
                sqlcmd.ExecuteNonQuery()
                MsgBox("Added to Borrow Book Details")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        MsgBox("Borrowed one Book")
        Call display()
    End Sub
End Class