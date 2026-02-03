Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form is already designed in Designer
        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim userId As Integer = 0
            Dim fullName As String = ""
            Dim role As String = ""

            If DatabaseHelper.AuthenticateUser(txtUsername.Text.Trim(), txtPassword.Text, userId, fullName, role) Then
                If role = "Admin" Then
                    Dim adminDashboard As New AdminDashboard(userId, fullName)
                    adminDashboard.Show()
                    Me.Hide()
                Else
                    Dim userDashboard As New UserDashboard(userId, fullName)
                    userDashboard.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Clear()
                txtPassword.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Dim registrationForm As New RegistrationForm()
        registrationForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnLogin.PerformClick()
            e.Handled = True
        End If
    End Sub

End Class
