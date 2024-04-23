Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Public Class DASHBOARD
    Private Sub DASHBOARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim provider As String
        Dim dataFile As String
        Dim connString As String
        Dim addstring As String
        Dim cnn As OleDbConnection = New OleDbConnection
        Dim ds As DataSet = New DataSet
        Dim da As OleDbDataAdapter
        Dim tables As DataTableCollection = ds.Tables
        Dim cmd As New OleDb.OleDbCommand
        Dim dr As System.Data.OleDb.OleDbDataReader




        '  t_date.Text = Today
        provider = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source="
        dataFile = "C:\Users\SHREE\source\repos\LIBRARY MANAGEMENT SYSTEM PROJECT\LIBRARY MANAGEMENT SYSTEM PROJECT\finalbooksdata.accdb"

        connString = provider & dataFile
        cnn.ConnectionString = connString
        da = New OleDbDataAdapter("Select * FROM bookdata", cnn)
        da.Fill(ds, "bookdata")

        Dim view1 As New DataView(tables(0))
        Dim source1 As New BindingSource()
        source1.DataSource = view1
        '  datagridview1.DataSource = view1
        ' datagridview1.Refresh()
        cnn.Close()
    End Sub


End Class