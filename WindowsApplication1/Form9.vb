Imports System.Data.SqlClient

Public Class Form9
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Please Enter Your User Name")
            Exit Sub
        Else
            ErrorProvider1.Clear()
        End If
        If TextBox2.Text = "" Then
            ErrorProvider2.SetError(TextBox2, "Please Enter Your Password")
            Exit Sub
        Else
            ErrorProvider2.Clear()
        End If
        If TextBox3.Text = "" Then
            ErrorProvider3.SetError(TextBox3, "Please Enter Your Password")
            Exit Sub
        Else
            ErrorProvider3.Clear()
        End If
        If TextBox4.Text = "" Then
            ErrorProvider4.SetError(TextBox4, "Please Enter New Password")
            Exit Sub
        Else
            ErrorProvider4.Clear()
        End If

        If Not TextBox4.Text = TextBox3.Text Then
            ErrorProvider3.SetError(TextBox3, "Please Enter Your Password")
            ErrorProvider4.SetError(TextBox4, "Password Doesn't Match")
            Exit Sub
        Else
            ErrorProvider3.Clear()
            ErrorProvider4.Clear()
        End If

        If TextBox2.Text = TextBox3.Text Then
            ErrorProvider3.SetError(TextBox4, "Please Enter New Password")
            Exit Sub
        Else
            ErrorProvider3.Clear()
        End If

        Dim uid As String = TextBox1.Text
        Dim psw As String = TextBox2.Text
        Dim newPsd As String = TextBox3.Text
        Dim query As String

        query = "update login set pwd='" & newPsd & "' where uname='" & uid & "'"

        Dim sqlcmd As SqlCommand

        Try
            sqlcmd = New SqlCommand(query, con)
            sqlcmd.ExecuteNonQuery()
            MsgBox("Password Has Been Successfully Changed",, "Password Changed")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class