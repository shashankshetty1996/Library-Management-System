Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        'Dim ApplicationTitle As String
        'If My.Application.Info.Title <> "" Then
        '    ApplicationTitle = My.Application.Info.Title
        'Else
        '    ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        'End If
        'Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).


        'Me.LabelProductName.Text = My.Application.Info.ProductName
        'Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        'Me.LabelCopyright.Text = My.Application.Info.Copyright
        'Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        'Me.TextBoxDescription.Text = My.Application.Info.Description


        Me.Text = String.Format("About {0}", "Library Mangement System")
        Me.LabelProductName.Text = "Library Management System"
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = "Designed By : Shanshank and Nigel"
        Me.LabelCompanyName.Text = "Fifth Semster CSE"
        Me.TextBoxDescription.Text = "Description :

     Our project is all about how one can access the library books and different fuctions like searching books for a student and all can be done easily.

     In our project user can search for books using Book Number,Author Name or but Title of the Book

     In Admin mode or Librarian can Add New Books, Update the Current Books as well as he can delete the existing books in the data base."
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
End Class
