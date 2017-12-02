<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfCopiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDataSet1 = New WindowsApplication1.libraryDataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BooksTableAdapter = New WindowsApplication1.libraryDataSet1TableAdapters.booksTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BnumDataGridViewTextBoxColumn, Me.BnameDataGridViewTextBoxColumn, Me.AuthorNameDataGridViewTextBoxColumn, Me.NumberOfCopiesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BooksBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(32, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(490, 210)
        Me.DataGridView1.TabIndex = 0
        '
        'BnumDataGridViewTextBoxColumn
        '
        Me.BnumDataGridViewTextBoxColumn.DataPropertyName = "bnum"
        Me.BnumDataGridViewTextBoxColumn.HeaderText = "Book Number"
        Me.BnumDataGridViewTextBoxColumn.Name = "BnumDataGridViewTextBoxColumn"
        '
        'BnameDataGridViewTextBoxColumn
        '
        Me.BnameDataGridViewTextBoxColumn.DataPropertyName = "bname"
        Me.BnameDataGridViewTextBoxColumn.HeaderText = "Book Name"
        Me.BnameDataGridViewTextBoxColumn.Name = "BnameDataGridViewTextBoxColumn"
        Me.BnameDataGridViewTextBoxColumn.Width = 120
        '
        'AuthorNameDataGridViewTextBoxColumn
        '
        Me.AuthorNameDataGridViewTextBoxColumn.DataPropertyName = "authorName"
        Me.AuthorNameDataGridViewTextBoxColumn.HeaderText = "Author Name"
        Me.AuthorNameDataGridViewTextBoxColumn.Name = "AuthorNameDataGridViewTextBoxColumn"
        Me.AuthorNameDataGridViewTextBoxColumn.Width = 120
        '
        'NumberOfCopiesDataGridViewTextBoxColumn
        '
        Me.NumberOfCopiesDataGridViewTextBoxColumn.DataPropertyName = "numberOfCopies"
        Me.NumberOfCopiesDataGridViewTextBoxColumn.HeaderText = "Number Of Copies"
        Me.NumberOfCopiesDataGridViewTextBoxColumn.Name = "NumberOfCopiesDataGridViewTextBoxColumn"
        Me.NumberOfCopiesDataGridViewTextBoxColumn.Width = 120
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "books"
        Me.BooksBindingSource.DataSource = Me.LibraryDataSet1
        '
        'LibraryDataSet1
        '
        Me.LibraryDataSet1.DataSetName = "libraryDataSet1"
        Me.LibraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Book By"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(119, 278)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(297, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 41)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Book Number"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(206, 335)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 41)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Author Name"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(393, 335)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 41)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Title of book"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(32, 6)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(44, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Refresh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Welcome"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(444, 264)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 47)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Borrow"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(332, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Staff/student label 4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(441, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "id label 5"
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 412)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form3"
        Me.Text = "Search Books"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LibraryDataSet1 As libraryDataSet1
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents BooksTableAdapter As libraryDataSet1TableAdapters.booksTableAdapter
    Friend WithEvents BnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumberOfCopiesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
