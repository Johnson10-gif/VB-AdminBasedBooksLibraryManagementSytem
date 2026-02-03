Public Class UserDashboard

    Private currentUserId As Integer
    Private currentUserName As String

    Public Sub New(userId As Integer, userName As String)
        InitializeComponent()
        currentUserId = userId
        currentUserName = userName
        lblWelcome.Text = "Welcome, " & userName
    End Sub

    Private Sub UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form initialization
    End Sub

    Private Sub btnViewBooks_Click(sender As Object, e As EventArgs) Handles btnViewBooks.Click
        Dim form As New UserViewBooks()
        form.ShowDialog()
    End Sub

    Private Sub btnRequestBook_Click(sender As Object, e As EventArgs) Handles btnRequestBook.Click
        Dim form As New UserRequestBook(currentUserId)
        form.ShowDialog()
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        Dim form As New UserReturnBook(currentUserId)
        form.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub UserDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Application.Exit()
        End If
    End Sub

    Private Sub panelButtons_Paint(sender As Object, e As PaintEventArgs) Handles panelButtons.Paint

    End Sub
End Class
