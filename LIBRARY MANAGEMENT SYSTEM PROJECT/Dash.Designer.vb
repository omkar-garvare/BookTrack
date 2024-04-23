<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dash))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BookdataBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalbooksdataDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalbooksdataDataSet1 = New LIBRARY_MANAGEMENT_SYSTEM_PROJECT.finalbooksdataDataSet1()
        Me.BookdataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookdataTableAdapter = New LIBRARY_MANAGEMENT_SYSTEM_PROJECT.finalbooksdataDataSet1TableAdapters.bookdataTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FinalbooksdataDataSet = New LIBRARY_MANAGEMENT_SYSTEM_PROJECT.finalbooksdataDataSet()
        Me.BookdataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookdataBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalbooksdataDataSet3 = New LIBRARY_MANAGEMENT_SYSTEM_PROJECT.finalbooksdataDataSet3()
        Me.FinalbooksdataDataSet3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookdataBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookdataTableAdapter1 = New LIBRARY_MANAGEMENT_SYSTEM_PROJECT.finalbooksdataDataSet3TableAdapters.bookdataTableAdapter()
        Me.BookdataBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookdataBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalbooksdataDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalbooksdataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookdataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalbooksdataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookdataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookdataBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalbooksdataDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalbooksdataDataSet3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookdataBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookdataBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.BookNameDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.BorrowDateDataGridViewTextBoxColumn, Me.ReturnDateDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookdataBindingSource5
        Me.DataGridView1.Location = New System.Drawing.Point(66, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(707, 354)
        Me.DataGridView1.TabIndex = 11
        '
        'BookdataBindingSource5
        '
        Me.BookdataBindingSource5.DataMember = "bookdata"
        Me.BookdataBindingSource5.DataSource = Me.FinalbooksdataDataSet1BindingSource
        '
        'FinalbooksdataDataSet1BindingSource
        '
        Me.FinalbooksdataDataSet1BindingSource.DataSource = Me.FinalbooksdataDataSet1
        Me.FinalbooksdataDataSet1BindingSource.Position = 0
        '
        'FinalbooksdataDataSet1
        '
        Me.FinalbooksdataDataSet1.DataSetName = "finalbooksdataDataSet1"
        Me.FinalbooksdataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookdataBindingSource
        '
        Me.BookdataBindingSource.DataMember = "bookdata"
        Me.BookdataBindingSource.DataSource = Me.FinalbooksdataDataSet1BindingSource
        '
        'BookdataTableAdapter
        '
        Me.BookdataTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LemonChiffon
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(340, 378)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(172, 60)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "REFRESH DASHBOARD"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FinalbooksdataDataSet
        '
        Me.FinalbooksdataDataSet.DataSetName = "finalbooksdataDataSet"
        Me.FinalbooksdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookdataBindingSource1
        '
        Me.BookdataBindingSource1.DataMember = "bookdata"
        Me.BookdataBindingSource1.DataSource = Me.FinalbooksdataDataSet1BindingSource
        '
        'BookdataBindingSource2
        '
        Me.BookdataBindingSource2.DataMember = "bookdata"
        Me.BookdataBindingSource2.DataSource = Me.FinalbooksdataDataSet1BindingSource
        '
        'FinalbooksdataDataSet3
        '
        Me.FinalbooksdataDataSet3.DataSetName = "finalbooksdataDataSet3"
        Me.FinalbooksdataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinalbooksdataDataSet3BindingSource
        '
        Me.FinalbooksdataDataSet3BindingSource.DataSource = Me.FinalbooksdataDataSet3
        Me.FinalbooksdataDataSet3BindingSource.Position = 0
        '
        'BookdataBindingSource3
        '
        Me.BookdataBindingSource3.DataMember = "bookdata"
        Me.BookdataBindingSource3.DataSource = Me.FinalbooksdataDataSet3BindingSource
        '
        'BookdataTableAdapter1
        '
        Me.BookdataTableAdapter1.ClearBeforeFill = True
        '
        'BookdataBindingSource4
        '
        Me.BookdataBindingSource4.DataMember = "bookdata"
        Me.BookdataBindingSource4.DataSource = Me.FinalbooksdataDataSet3BindingSource
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "ID NO."
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Column1.Width = 125
        '
        'BookNameDataGridViewTextBoxColumn
        '
        Me.BookNameDataGridViewTextBoxColumn.DataPropertyName = "Book Name"
        Me.BookNameDataGridViewTextBoxColumn.HeaderText = "Book Name"
        Me.BookNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BookNameDataGridViewTextBoxColumn.Name = "BookNameDataGridViewTextBoxColumn"
        Me.BookNameDataGridViewTextBoxColumn.Width = 125
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.Width = 125
        '
        'BorrowDateDataGridViewTextBoxColumn
        '
        Me.BorrowDateDataGridViewTextBoxColumn.DataPropertyName = "Borrow Date"
        Me.BorrowDateDataGridViewTextBoxColumn.HeaderText = "Borrow Date"
        Me.BorrowDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BorrowDateDataGridViewTextBoxColumn.Name = "BorrowDateDataGridViewTextBoxColumn"
        Me.BorrowDateDataGridViewTextBoxColumn.Width = 125
        '
        'ReturnDateDataGridViewTextBoxColumn
        '
        Me.ReturnDateDataGridViewTextBoxColumn.DataPropertyName = "Return Date"
        Me.ReturnDateDataGridViewTextBoxColumn.HeaderText = "Return Date"
        Me.ReturnDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ReturnDateDataGridViewTextBoxColumn.Name = "ReturnDateDataGridViewTextBoxColumn"
        Me.ReturnDateDataGridViewTextBoxColumn.Width = 125
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "Cost"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'Dash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(854, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Dash"
        Me.Text = "Dash"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookdataBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalbooksdataDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalbooksdataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookdataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalbooksdataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookdataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookdataBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalbooksdataDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalbooksdataDataSet3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookdataBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookdataBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FinalbooksdataDataSet1BindingSource As BindingSource
    Friend WithEvents FinalbooksdataDataSet1 As finalbooksdataDataSet1
    Friend WithEvents BookdataBindingSource As BindingSource
    Friend WithEvents BookdataTableAdapter As finalbooksdataDataSet1TableAdapters.bookdataTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents FinalbooksdataDataSet3BindingSource As BindingSource
    Friend WithEvents FinalbooksdataDataSet3 As finalbooksdataDataSet3
    Friend WithEvents FinalbooksdataDataSet As finalbooksdataDataSet
    Friend WithEvents BookdataBindingSource1 As BindingSource
    Friend WithEvents BookdataBindingSource2 As BindingSource
    Friend WithEvents BookdataBindingSource3 As BindingSource
    Friend WithEvents BookdataTableAdapter1 As finalbooksdataDataSet3TableAdapters.bookdataTableAdapter
    Friend WithEvents BookdataBindingSource4 As BindingSource
    Friend WithEvents BookdataBindingSource5 As BindingSource
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
