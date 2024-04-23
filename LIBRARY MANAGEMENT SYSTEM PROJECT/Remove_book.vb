Imports System.Data.OleDb
Public Class Remove_book
    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "C:\Users\SHREE\source\repos\LIBRARY MANAGEMENT SYSTEM PROJECT\LIBRARY MANAGEMENT SYSTEM PROJECT\finalbooksdata.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim str As String
        str = "Delete from [bookdata] where [ID]=" & TextBox1.Text
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            TextBox1.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MessageBox.Show("RECORD DELETE SUCCESSFUL")

    End Sub
End Class