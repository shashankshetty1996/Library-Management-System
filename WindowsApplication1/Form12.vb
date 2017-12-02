Imports System.Data.SqlClient

Public Class Form12
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

        adp = New SqlDataAdapter("Select * from borrowbook where bid=" & bnum, con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Input Box is Empty", vbExclamation, "Warning")
            Exit Sub
        End If

        Dim uid As Integer = Val(TextBox1.Text)

        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("Select * from borrowbook where userid='" & uid & "'", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Input Box Is Empty", vbExclamation, "Warning")
            Exit Sub
        End If

        Dim uname As Integer = Val(TextBox1.Text)

        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("Select * from borrowbook where username='" & uname & "'", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MsgBox("Input Box Is Empty", vbExclamation, "Warning")
            Exit Sub
        End If

        Dim bname As Integer = Val(TextBox1.Text)

        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("Select * from borrowbook where bname='" & bname & "'", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Then
            MsgBox("Input Box Is Empty", vbExclamation, "Warning")
            Exit Sub
        End If

        Dim aname As Integer = Val(TextBox1.Text)

        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("Select * from borrowbook where aname='" & aname & "'", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet1.borrowbook' table. You can move, or remove it, as needed.
        Me.BorrowbookTableAdapter.Fill(Me.LibraryDataSet1.borrowbook)
        Button1.Hide()
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Hide()
        TextBox1.Hide()
        Label1.Hide()
        LinkLabel1.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.BorrowbookTableAdapter.Fill(Me.LibraryDataSet1.borrowbook)
    End Sub
End Class