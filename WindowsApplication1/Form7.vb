Imports System.Data.SqlClient

Public Class Form7
    Private Sub Form7_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text Then
            MsgBox("Please Enter all the fields")
            Exit Sub
        End If
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Please enter integer only")
            Exit Sub
        End If
        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("number of copies should be number only")
            Exit Sub
        End If

        Dim bnum As Integer = Val(TextBox1.Text)
        Dim bname As String = TextBox2.Text
        Dim aname As String = TextBox3.Text
        Dim nc As Integer = Val(TextBox4.Text)

        Dim Query As String
        Query = "insert into books values(& bnum &,' & bname & ',' & aname & ',& nc &)"

        Dim sqlcmd As SqlCommand
        Try
            sqlcmd = New SqlCommand(Query, con)
            sqlcmd.ExecuteNonQuery()
            MsgBox("Added new book")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Please Enter Book Number")
        Else
            ErrorProvider1.Clear()
        End If
        If TextBox2.Text = "" Then
            ErrorProvider2.SetError(TextBox2, "Please Enter Book Name")
        Else
            ErrorProvider2.Clear()
        End If
        If TextBox2.Text = "" Then
            ErrorProvider3.SetError(TextBox3, "Please Enter Author Name")
        Else
            ErrorProvider3.Clear()
        End If
        If TextBox4.Text = "" Then
            ErrorProvider4.SetError(TextBox4, "Please Enter Number of Copies")
            Exit Sub
        Else
            ErrorProvider4.Clear()
        End If
        If Not IsNumeric(TextBox1.Text) Then
            'MsgBox("Please enter integer only", vbExclamation, "Warning")
            ErrorProvider1.SetError(TextBox1, "Enter Integer Value only")
            Exit Sub
        Else
            ErrorProvider1.Clear()
        End If
        If Not IsNumeric(TextBox4.Text) Then
            'MsgBox("Number of copies should be number only", vbExclamation, "Warning")
            ErrorProvider4.SetError(TextBox4, "Enter Integer Value only")
            Exit Sub
        Else
            ErrorProvider4.Clear()
        End If

        Dim bnum As Integer = Val(TextBox1.Text)
        Dim Bname As String = TextBox2.Text.ToUpper
        Dim aname As String = TextBox3.Text.ToUpper
        Dim nc As Integer = Val(TextBox4.Text)

        Dim Query As String

        Query = "insert into books values(" & bnum & ",'" & Bname & "','" & aname & "'," & nc & ")"

        Dim sqlcmd As SqlCommand

        Try
            sqlcmd = New SqlCommand(Query, con)
            sqlcmd.ExecuteNonQuery()
            MsgBox("Added New item",, "Please press on refresh")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Button1.PerformClick()
    End Sub
End Class