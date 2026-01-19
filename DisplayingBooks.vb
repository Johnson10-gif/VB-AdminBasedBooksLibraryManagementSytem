Public Class lstDisplayBooks
    Public lstDisplayBookPublic As ListBox

    Private Sub lstBooks_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DisplayingBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstDisplayBookPublic = lstDisplayBook
    End Sub
End Class