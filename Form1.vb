Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Launch MainApplication as the primary form
        Dim mainApp As New MainApplication()
        mainApp.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ensure application exits completely
        Application.Exit()
    End Sub

End Class
