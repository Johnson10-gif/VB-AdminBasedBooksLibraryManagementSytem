Imports MySql.Data.MySqlClient

Public Class AdminRegisterUser

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validation
        If String.IsNullOrWhiteSpace(txtFullName.Text) Then
            MessageBox.Show("Please enter full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFullName.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Please enter username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return
        End If

        Dim password As String = If(String.IsNullOrWhiteSpace(txtPassword.Text), "Password@123", txtPassword.Text)

        Try
            DatabaseHelper.RegisterUser(txtFullName.Text.Trim(), txtUsername.Text.Trim(), password, "User")
            MessageBox.Show("User registered successfully!" & vbCrLf & vbCrLf &
                          "Username: " & txtUsername.Text.Trim() & vbCrLf &
                          "Password: " & password, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            If ex.Message.Contains("Duplicate") OrElse ex.Message.Contains("unique") OrElse ex.Message.Contains("exists") Then
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Focus()
            Else
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
