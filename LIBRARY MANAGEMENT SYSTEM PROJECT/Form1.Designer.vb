<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BookdataTableAdapter = New LIBRARY_MANAGEMENT_SYSTEM_PROJECT.finalbooksdataDataSetTableAdapters.bookdataTableAdapter()
        Me.FinalbooksdataDataSet = New LIBRARY_MANAGEMENT_SYSTEM_PROJECT.finalbooksdataDataSet()
        Me.BookdataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookdataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalbooksdataDataSet1 = New LIBRARY_MANAGEMENT_SYSTEM_PROJECT.finalbooksdataDataSet1()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BookdataTableAdapter1 = New LIBRARY_MANAGEMENT_SYSTEM_PROJECT.finalbooksdataDataSet1TableAdapters.bookdataTableAdapter()
        CType(Me.FinalbooksdataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookdataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookdataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalbooksdataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SandyBrown
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(532, 150)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 60)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "REMOVE BOOK "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SandyBrown
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(88, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 60)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "ADD BOOK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT Condensed", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(111, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(590, 75)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "LIBRARY MANAGEMENT SYSTEM"
        '
        'BookdataTableAdapter
        '
        Me.BookdataTableAdapter.ClearBeforeFill = True
        '
        'FinalbooksdataDataSet
        '
        Me.FinalbooksdataDataSet.DataSetName = "finalbooksdataDataSet"
        Me.FinalbooksdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookdataBindingSource
        '
        Me.BookdataBindingSource.DataMember = "bookdata"
        Me.BookdataBindingSource.DataSource = Me.FinalbooksdataDataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.BookNameDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.BorrowDateDataGridViewTextBoxColumn, Me.ReturnDateDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookdataBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(1084, 397)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(75, 36)
        Me.DataGridView1.TabIndex = 10
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
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
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "Cost"
        Me.CostDataGridViewTextBoxColumn.HeaderText = "Cost"
        Me.CostDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
        Me.CostDataGridViewTextBoxColumn.Width = 125
        '
        'BookdataBindingSource1
        '
        Me.BookdataBindingSource1.DataMember = "bookdata"
        Me.BookdataBindingSource1.DataSource = Me.FinalbooksdataDataSet1
        '
        'FinalbooksdataDataSet1
        '
        Me.FinalbooksdataDataSet1.DataSetName = "finalbooksdataDataSet1"
        Me.FinalbooksdataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SandyBrown
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(309, 150)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(180, 60)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "SHOW DASHBOARD"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Pink
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(344, 250)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 32)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "ABOUT"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(239, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "GUIDED  BY  Prof.Miss. Jadhav S.V "
        '
        'BookdataTableAdapter1
        '
        Me.BookdataTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(812, 443)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.FinalbooksdataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookdataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookdataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalbooksdataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FinalbooksdataDataSet1 As finalbooksdataDataSet1
    Friend WithEvents BookdataBindingSource1 As BindingSource
    Friend WithEvents BookdataTableAdapter1 As finalbooksdataDataSet1TableAdapters.bookdataTableAdapter
    Friend WithEvents BookdataTableAdapter As finalbooksdataDataSetTableAdapters.bookdataTableAdapter
    Friend WithEvents FinalbooksdataDataSet As finalbooksdataDataSet
    Friend WithEvents BookdataBindingSource As BindingSource
    Friend WithEvents CostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
End Class
