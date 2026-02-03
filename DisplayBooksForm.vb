Public Class DisplayBooksForm
    Private Sub DisplayBooksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBooks()
    End Sub
    Sub LoadBooks()
        lstAllBooks.Items.Clear()
        For Each book In Form1.books
            lstAllBooks.Items.Add(book)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        If lstAllBooks.SelectedIndex = -1 Then
            MessageBox.Show("please select a book to borrow")
            Exit Sub
        End If
        Dim selectedBook As String = lstAllBooks.SelectedItem.ToString()
        If selectedBook.Contains("Borrowed") Then
            MessageBox.Show("This book is already borrowed")
            Exit Sub
        End If
        Dim index As Integer = Form1.books.IndexOf(selectedBook)
        Form1.books(index) = selectedBook.Replace("Available", "Borrowed")
        MessageBox.Show("Book Borrowed Successfully")
        LoadBooks()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If lstAllBooks.SelectedIndex = -1 Then
            MessageBox.Show("please select a book to return")
            Exit Sub
        End If
        Dim selectedBook As String = lstAllBooks.SelectedItem.ToString()
        If selectedBook.Contains("Available") Then
            MessageBox.Show("This book is already Available")
            Exit Sub
        End If
        Dim index As Integer = Form1.books.IndexOf(selectedBook)
        Form1.books(index) = selectedBook.Replace("Borrowed", "Available")
        MessageBox.Show("Book Returned Successfully")
        LoadBooks()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If lstAllBooks.SelectedIndex <> -1 Then

            Dim index As Integer = lstAllBooks.SelectedIndex


            Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirm = DialogResult.Yes Then
                Form1.books.RemoveAt(index)
                MessageBox.Show("Book deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                LoadBooks()
                Form1.UpdateBookCount()
            End If

        Else

            MessageBox.Show("Please select the book you want to delete", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class
