Imports System.Data.SqlClient

Module Module1
    Public con As SqlConnection

    Public Function connect()


        Try
            'con = New SqlConnection("server=DESKTOP-LFV0TRS;database=library;user ID=student;password=student;")
            con = New SqlConnection(WindowsApplication1.My.Settings.libraryConnectionString)
            con.Open()

        Catch ex As Exception
            MessageBox.Show("Error in Database Connection \n Error code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function
End Module
