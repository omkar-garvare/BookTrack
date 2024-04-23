
Imports System.Data.OleDb
Public Class Add_new_book
    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    ' Dim adapter As OleDbDataAdapter
    '   Dim dt As DataTable = New DataTable()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "C:\Users\SHREE\source\repos\LIBRARY MANAGEMENT SYSTEM PROJECT\LIBRARY MANAGEMENT SYSTEM PROJECT\finalbooksdata.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim str As String
        str = "Insert into bookdata([ID],[Book Name],[Author],[Borrow Date],[Return Date],[Cost]) Values (?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.Parameters.Add(New OleDbParameter("ID", CType(TextBox1.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Book Name", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Author", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Borrow Date", CType(TextBox4.Text, Date)))
        cmd.Parameters.Add(New OleDbParameter("Return Date", CType(TextBox5.Text, Date)))
        cmd.Parameters.Add(New OleDbParameter("Cost", CType(TextBox6.Text, Integer)))


        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        MessageBox.Show(" NEW BOOK ADDED SUCCESFULLY  ")
        myconnection.Close()



    End Sub

End Class