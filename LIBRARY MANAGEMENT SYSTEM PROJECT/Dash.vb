
Imports System.Data.OleDb

Public Class Dash
    Private Sub Dash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinalbooksdataDataSet3.bookdata' table. You can move, or remove it, as needed.
        ' Me.BookdataTableAdapter1.Fill(Me.FinalbooksdataDataSet1.bookdata)
        'TODO: This  code loads data into the '
        Me.BookdataTableAdapter.Fill(Me.FinalbooksdataDataSet1.bookdata)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim provider As String
            Dim datafile As String
            Dim connstring As String
            provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            datafile = "C:\Users\SHREE\source\repos\LIBRARY MANAGEMENT SYSTEM PROJECT\LIBRARY MANAGEMENT SYSTEM PROJECT\finalbooksdata.accdb"
            connstring = provider & datafile
            Dim cnn As OleDbConnection = New OleDbConnection
            cnn.ConnectionString = connstring
            cnn.Open()
            DataGridView1.DataSource = Nothing
            DataGridView1.Refresh()

            Dim str As String = "select * from bookdata"
            Using cmd As New OleDb.OleDbCommand(str, cnn)
                Using da As New OleDbDataAdapter(cmd)
                    Using newtable As New DataTable
                        da.Fill(newtable)
                        DataGridView1.DataSource = newtable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

End Class