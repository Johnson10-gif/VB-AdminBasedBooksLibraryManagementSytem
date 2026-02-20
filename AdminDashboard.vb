Public Class AdminDashboard

    Private currentUserId As Integer
    Private currentUserName As String

    Public Sub New(userId As Integer, userName As String)
        InitializeComponent()
        currentUserId = userId
        currentUserName = userName
        lblWelcome.Text = "Welcome, " & userName
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form initialization
    End Sub

    Private Sub btnRegisterUser_Click(sender As Object, e As EventArgs) Handles btnRegisterUser.Click
        Dim form As New AdminRegisterUser()
        form.ShowDialog()
    End Sub

    Private Sub btnRegisterBook_Click(sender As Object, e As EventArgs) Handles btnRegisterBook.Click
        Dim form As New AdminRegisterBook()
        form.ShowDialog()
    End Sub

    Private Sub btnPermitBorrowing_Click(sender As Object, e As EventArgs) Handles btnPermitBorrowing.Click
        Dim form As New AdminPermitBorrowing()
        form.ShowDialog()
    End Sub

    Private Sub btnViewBookStatus_Click(sender As Object, e As EventArgs) Handles btnViewBookStatus.Click
        Dim form As New AdminViewBookStatus()
        form.ShowDialog()
    End Sub

    Private Sub btnPermitReturn_Click(sender As Object, e As EventArgs) Handles btnPermitReturn.Click
        Dim form As New AdminPermitReturn()
        form.ShowDialog()
    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Dim form As New AdminGenerateReport()
        form.ShowDialog()
    End Sub

    Private isLoggingOut As Boolean = False

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            isLoggingOut = True
            Dim loginForm As New LoginForm()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub AdminDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing AndAlso Not isLoggingOut Then
            Application.Exit()
        End If
    End Sub

End Class
