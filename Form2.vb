Public Class Form2
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "1234" Then
            Form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Login Credentials")
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class