Imports System.Data.SqlClient

Public Class Form11
    Public Function display()
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("select * from leactureliblogin", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
        TextBox4.Text = 0
        Return Nothing
    End Function

    Private Function checkusn(ByVal usn As String) As Boolean
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        dt = New DataTable()
        adp = New SqlDataAdapter("select * from leactureliblogin where luserid='" & usn & "'", con)

        adp.Fill(dt)
        If dt.Rows.Count = 0 Then
            Return True
        End If
        Return False
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet1.leactureliblogin' table. You can move, or remove it, as needed.
        Me.LeacturelibloginTableAdapter.Fill(Me.LibraryDataSet1.leactureliblogin)
        TextBox4.Text = 0
        Call display()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Please Enter Your User ID")
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
            ErrorProvider3.SetError(TextBox3, "Please Enter Your Name")
            Exit Sub
        Else
            ErrorProvider3.Clear()
        End If
        If TextBox4.Text = "" Then
            ErrorProvider4.SetError(TextBox4, "Please Enter Number of books borrowed")
            Exit Sub
        Else
            ErrorProvider4.Clear()
        End If

        If Not IsNumeric(TextBox4.Text) Then
            ErrorProvider4.SetError(TextBox4, "Please enter integer only")
            Exit Sub
        Else
            ErrorProvider4.Clear()
        End If

        Dim usn As String = TextBox1.Text.ToUpper
        Dim name As String = TextBox3.Text.ToUpper
        Dim password As String = TextBox2.Text
        Dim borrow As Integer = Val(TextBox4.Text)

        Dim query As String

        query = "insert into leactureliblogin values('" & usn & "','" & name & "','" & password & "'," & borrow & ")"

        Dim sqlcmd As SqlCommand

        Try
            sqlcmd = New SqlCommand(query, con)
            sqlcmd.ExecuteNonQuery()
            MsgBox("Staff Added to the Database",, "Insertion Successful")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Auto Refresh
        Call display()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Please Enter Your User ID")
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
            ErrorProvider3.SetError(TextBox3, "Please Enter Your User Name")
            Exit Sub
        Else
            ErrorProvider3.Clear()
        End If
        If TextBox4.Text = "" Then
            ErrorProvider4.SetError(TextBox4, "Please Enter Number of books borrowed")
            Exit Sub
        Else
            ErrorProvider4.Clear()
        End If

        If Not IsNumeric(TextBox4.Text) Then
            ErrorProvider4.SetError(TextBox4, "Please enter integer only")
            Exit Sub
        Else
            ErrorProvider4.Clear()
        End If

        Dim usn As String = TextBox1.Text.ToUpper
        Dim name As String = TextBox3.Text.ToUpper
        Dim password As String = TextBox2.Text
        Dim borrow As Integer = Val(TextBox4.Text)

        Dim query As String

        query = "update leactureliblogin set lname='" & name & "',lpassword='" & password & "',borrow=" & borrow & " where luserid= '" & usn & "'"

        Dim sqlcmd As SqlCommand

        Try
            sqlcmd = New SqlCommand(query, con)
            sqlcmd.ExecuteNonQuery()
            MsgBox("A Staff data has been updated from Database",, "Updated Successful")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Auto Refresh
        Call display()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim usn As String

        usn = InputBox("Please Enter the Staff ID to be Deleted", "Delete a Staff", "Enter Staff ID Eg: 14CSE007")
        usn.ToUpper()

        If checkusn(usn) = True Then
            MsgBox("Staff Not found", MsgBoxStyle.Critical, "Warning")
            Exit Sub
        End If

        Dim query As String
        Dim sqlcmd As SqlCommand

        query = "delete from leactureliblogin where luserid ='" & usn & "'"
        Try
            If MsgBox("Are you sure you want to delete", vbYesNo, "Warning!!!") = vbYes Then
                sqlcmd = New SqlCommand(query, con)
                sqlcmd.ExecuteNonQuery()
                MsgBox("A Student details has been deleted", vbExclamation, "Note :")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call display()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form12.Show()
    End Sub
End Class