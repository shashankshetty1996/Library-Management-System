<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.LibraryDataSet1 = New WindowsApplication1.libraryDataSet1()
        Me.StudentlibloginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentlibloginTableAdapter = New WindowsApplication1.libraryDataSet1TableAdapters.studentlibloginTableAdapter()
        Me.StduseridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StdpasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentlibloginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student USN"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(162, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(307, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(406, 30)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(185, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(106, 74)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(162, 20)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(406, 74)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(185, 20)
        Me.TextBox4.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Student Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(307, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Borrowed Books"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StduseridDataGridViewTextBoxColumn, Me.StdnameDataGridViewTextBoxColumn, Me.StdpasswordDataGridViewTextBoxColumn, Me.BorrowDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentlibloginBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(592, 159)
        Me.DataGridView1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 32)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(141, 281)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 32)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(257, 281)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 32)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(492, 281)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 32)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "HOME"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.ContainerControl = Me
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(378, 281)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 32)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Borrow details"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'LibraryDataSet1
        '
        Me.LibraryDataSet1.DataSetName = "libraryDataSet1"
        Me.LibraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentlibloginBindingSource
        '
        Me.StudentlibloginBindingSource.DataMember = "studentliblogin"
        Me.StudentlibloginBindingSource.DataSource = Me.LibraryDataSet1
        '
        'StudentlibloginTableAdapter
        '
        Me.StudentlibloginTableAdapter.ClearBeforeFill = True
        '
        'StduseridDataGridViewTextBoxColumn
        '
        Me.StduseridDataGridViewTextBoxColumn.DataPropertyName = "stduserid"
        Me.StduseridDataGridViewTextBoxColumn.HeaderText = "Student User ID"
        Me.StduseridDataGridViewTextBoxColumn.Name = "StduseridDataGridViewTextBoxColumn"
        Me.StduseridDataGridViewTextBoxColumn.Width = 130
        '
        'StdnameDataGridViewTextBoxColumn
        '
        Me.StdnameDataGridViewTextBoxColumn.DataPropertyName = "stdname"
        Me.StdnameDataGridViewTextBoxColumn.HeaderText = "Student Name"
        Me.StdnameDataGridViewTextBoxColumn.Name = "StdnameDataGridViewTextBoxColumn"
        Me.StdnameDataGridViewTextBoxColumn.Width = 150
        '
        'StdpasswordDataGridViewTextBoxColumn
        '
        Me.StdpasswordDataGridViewTextBoxColumn.DataPropertyName = "stdpassword"
        Me.StdpasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.StdpasswordDataGridViewTextBoxColumn.Name = "StdpasswordDataGridViewTextBoxColumn"
        Me.StdpasswordDataGridViewTextBoxColumn.Width = 150
        '
        'BorrowDataGridViewTextBoxColumn
        '
        Me.BorrowDataGridViewTextBoxColumn.DataPropertyName = "borrow"
        Me.BorrowDataGridViewTextBoxColumn.HeaderText = "Borrow"
        Me.BorrowDataGridViewTextBoxColumn.Name = "BorrowDataGridViewTextBoxColumn"
        Me.BorrowDataGridViewTextBoxColumn.Width = 120
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 321)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form10"
        Me.Text = "Student Details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentlibloginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents Button5 As Button
    Friend WithEvents LibraryDataSet1 As libraryDataSet1
    Friend WithEvents StudentlibloginBindingSource As BindingSource
    Friend WithEvents StudentlibloginTableAdapter As libraryDataSet1TableAdapters.studentlibloginTableAdapter
    Friend WithEvents StduseridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StdnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StdpasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
