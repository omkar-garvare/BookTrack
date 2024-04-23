<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DASHBOARD
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
        Me.BookdataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalbooksdataDataSet2 = New LIBRARY_MANAGEMENT_SYSTEM_PROJECT.finalbooksdataDataSet2()
        Me.BookdataTableAdapter = New LIBRARY_MANAGEMENT_SYSTEM_PROJECT.finalbooksdataDataSet2TableAdapters.bookdataTableAdapter()
        Me.FinalbooksdataDataSet1 = New LIBRARY_MANAGEMENT_SYSTEM_PROJECT.finalbooksdataDataSet1()
        Me.FinalbooksdataDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookdataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookdataTableAdapter1 = New LIBRARY_MANAGEMENT_SYSTEM_PROJECT.finalbooksdataDataSet1TableAdapters.bookdataTableAdapter()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.BookdataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalbooksdataDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalbooksdataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalbooksdataDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookdataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookdataBindingSource
        '
        Me.BookdataBindingSource.DataMember = "bookdata"
        Me.BookdataBindingSource.DataSource = Me.FinalbooksdataDataSet2
        '
        'FinalbooksdataDataSet2
        '
        Me.FinalbooksdataDataSet2.DataSetName = "finalbooksdataDataSet2"
        Me.FinalbooksdataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookdataTableAdapter
        '
        Me.BookdataTableAdapter.ClearBeforeFill = True
        '
        'FinalbooksdataDataSet1
        '
        Me.FinalbooksdataDataSet1.DataSetName = "finalbooksdataDataSet1"
        Me.FinalbooksdataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinalbooksdataDataSet1BindingSource
        '
        Me.FinalbooksdataDataSet1BindingSource.DataSource = Me.FinalbooksdataDataSet1
        Me.FinalbooksdataDataSet1BindingSource.Position = 0
        '
        'BookdataBindingSource1
        '
        Me.BookdataBindingSource1.DataMember = "bookdata"
        Me.BookdataBindingSource1.DataSource = Me.FinalbooksdataDataSet1BindingSource
        '
        'BookdataTableAdapter1
        '
        Me.BookdataTableAdapter1.ClearBeforeFill = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.BookdataBindingSource
        Me.ListBox1.DisplayMember = "Book Name"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(120, 119)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(384, 196)
        Me.ListBox1.TabIndex = 0
        '
        'DASHBOARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "DASHBOARD"
        Me.Text = "DASHBOARD"
        CType(Me.BookdataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalbooksdataDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalbooksdataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalbooksdataDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookdataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FinalbooksdataDataSet2 As finalbooksdataDataSet2
    Friend WithEvents BookdataBindingSource As BindingSource
    Friend WithEvents BookdataTableAdapter As finalbooksdataDataSet2TableAdapters.bookdataTableAdapter
    Friend WithEvents FinalbooksdataDataSet1BindingSource As BindingSource
    Friend WithEvents FinalbooksdataDataSet1 As finalbooksdataDataSet1
    Friend WithEvents BookdataBindingSource1 As BindingSource
    Friend WithEvents BookdataTableAdapter1 As finalbooksdataDataSet1TableAdapters.bookdataTableAdapter
    Friend WithEvents ListBox1 As ListBox
End Class
