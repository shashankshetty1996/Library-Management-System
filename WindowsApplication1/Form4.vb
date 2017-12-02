Imports System.Data.SqlClient

Public Class Form4
    Public count As Integer

    Private Function display()
        Dim loginadp As SqlDataAdapter
        Dim logindt As DataTable

        loginadp = New SqlDataAdapter("Select * from login", con)
        logindt = New DataTable()

        loginadp.Fill(logindt)
        Return Nothing
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If MsgBox("Do You want to Close This Form?", vbYesNo, "Warning") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If TextBox1.Text = "" Then
            '  MsgBox("Please Enter the Fields!!!", MsgBoxStyle.OkOnly, "Invalid")
            ErrorProvider1.SetError(TextBox1, "Enter Username")
            Exit Sub
        Else
            ErrorProvider1.Clear()
        End If

        If TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "Enter Password")
            Exit Sub
        Else
            ErrorProvider1.Clear()
        End If

        'assigning the values to the variable
        Dim uid As String = TextBox1.Text.ToUpper
        Dim pwd As String = TextBox2.Text

        Dim sqlcmd As SqlCommand

        Dim validuid As String = "select pwd from login where uname='" & uid & "'"
        'Dim validpwd As String = "Select permission from login where pwd=" & pwd

        Try
            sqlcmd = New SqlCommand(validuid, con)
            Dim Str As String = sqlcmd.ExecuteScalar()
            'ExecuteScalar gives 1st row and 1st coln of result table
            If Str = TextBox2.Text Then
                Dim enroll As String
                enroll = InputBox("Enter Your Enrollment Key", "Secret Enrollment Key", "NMAMIT")
                If enroll = "NMAMIT" Or enroll = "library" Or enroll = "nitte" Then
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    'Form5.Show()
                    'Me.Hide()
                    'we can use close child process and it won't stop the program thus me.close() can be used
                    Me.Close()
                    Dim NewMDIChild As New Form5()
                    'Set the Parent Form of the Child window.
                    NewMDIChild.MdiParent = Form1
                    'Display the new form.
                    NewMDIChild.Show()
                End If
            Else
                count = Val(count + 1)
                If count > 3 Then
                    MsgBox("Reached The Limit Of the login!!!")
                    Me.Close()
                    Exit Sub
                End If
                MsgBox("Not Authenticated")
                Exit Sub
            End If

            'sqlcmd1 = New SqlCommand(validpwd, con)
            '    sqlcmd1.ExecuteNonQuery()
            '    If sqlcmd.ToString = sqlcmd1.ToString Then
            '        MsgBox("login successfull")
            '    Else
            '        MsgBox("login unsuccessfull")
            '        Exit Sub
            '    End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        count = Nothing
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs)
        Button1.BackColor = Color.Azure
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs)
        Button1.BackColor = Color.PaleGoldenrod
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Call Button3_Click(New Object, New EventArgs)
    End Sub
End Class