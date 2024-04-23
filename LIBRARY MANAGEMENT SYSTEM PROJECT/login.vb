Public Class login

    Dim a As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.Username Then
            a += 1
        End If
        If TextBox2.Text = My.Settings.Password Then
            a += 1
        End If
        If a = 2 Then
            Dim Form1 As New Form1
            Form1.Show()
            MsgBox("Login Successful !", MsgBoxStyle.Information)


        Else
            MsgBox("Invalid Login.Try again ! ", MsgBoxStyle.Information)
        End If




    End Sub
End Class