Imports System.Data.SqlClient

Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Are you sure you want to close?", vbYesNo, "Closing Form") = vbYes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MsgBox("Are you sure you want to close?", vbYesNo, "Closing Form") = vbYes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uid As String
        Dim psd As String
        If TextBox1.Text = "" Then
            uid = InputBox("Please Enter User ID", "User ID missing")
            TextBox1.Text = uid
        End If
        If TextBox2.Text = "" Then
            If MsgBox("Please enter your password", vbYesNo + vbCritical, "Error Password File Missing") = vbYes Then
                Me.Hide()
                Form1.Show()
            End If
        End If
        uid = TextBox1.Text.ToUpper
        psd = TextBox2.Text

        Dim validlogin As String = "select lpassword from leactureliblogin where luserid='" & uid & "'"

        Dim sqlcmd As SqlCommand

        Try
            sqlcmd = New SqlCommand(validlogin, con)
            Dim str As String = sqlcmd.ExecuteScalar()
            If str = psd Then
                sqlcmd = New SqlCommand("select lname from leactureliblogin where luserid='" & uid & "'", con)
                Dim uname As String = sqlcmd.ExecuteScalar()
                Form3.Label5.Text = uid.ToUpper
                Form3.Label4.Text = "staff"
                Form3.Label2.Text = uname
                Button5.PerformClick()
                Me.Hide()
                Form3.Show()
            Else
                MsgBox("Invalid Username and Password", vbCritical, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim uid As String
        Dim psd As String
        If TextBox3.Text = "" Then
            uid = InputBox("Please Enter User ID", "User ID missing")
            TextBox1.Text = uid
        End If
        If TextBox4.Text = "" Then
            If MsgBox("Please enter your password", vbYesNo + vbCritical, "Error Password File Missing") = vbYes Then
                Me.Hide()
                Form1.Show()
            End If
        End If
        uid = TextBox3.Text.ToUpper
        psd = TextBox4.Text

        Dim validlogin As String = "select stdpassword from studentliblogin where stduserid='" & uid & "'"

        Dim sqlcmd As SqlCommand

        Try
            sqlcmd = New SqlCommand(validlogin, con)
            Dim str As String = sqlcmd.ExecuteScalar()
            If str = psd Then
                sqlcmd = New SqlCommand("select stdname from studentliblogin where stduserid='" & uid & "'", con)
                Dim uname As String = sqlcmd.ExecuteScalar()
                Form3.Label5.Text = uid.ToUpper
                Form3.Label4.Text = "student"
                Form3.Label2.Text = uname
                Button2.PerformClick()
                Me.Hide()
                Form3.Show()
            Else
                MsgBox("Invalid Username and Password", vbExclamation, "Warning")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub
End Class