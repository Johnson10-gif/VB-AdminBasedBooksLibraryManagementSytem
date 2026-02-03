
Imports System.IO
Imports System.Linq


Public Class Form1
    Public Shared books As New List(Of String)
    Dim filePath As String = "library_books.txt"
    Public Sub UpdateBookCount()
        lblCount.Text = "Total Books: " & books.Count
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(filePath) Then
            books = File.ReadAllLines(filePath).ToList()
        End If
        UpdateCount()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtID.Text = "" Or txtTittle.Text = "" Or txtAuthor.Text = "" Or year.Text = "" Then
            MessageBox.Show("All fields are required")
            Exit Sub
        End If

        Dim book As String = txtID.Text & " | " & txtTittle.Text & " | " & txtAuthor.Text & " | " & year.Text & " | Available"
        books.Add(book)
        MessageBox.Show("Book Added")
        ClearFields()
        UpdateCount()
    End Sub


    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim dispalyForm As New DisplayBooksForm()
        DisplayBooksForm.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        File.WriteAllLines(filePath, books)
        MessageBox.Show("Saved Successfully")
    End Sub

    Sub UpdateCount()
        lblCount.Text = "Total Books: " & books.Count
    End Sub

    Sub ClearFields()
        txtID.Clear()
        txtTittle.Clear()
        txtAuthor.Clear()
        year.Clear()
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)
        Dim vScroll As New VScrollBar
        vScroll.Minimum = 0
        vScroll.Maximum = 100
        vScroll.Dock = DockStyle.Right
        Controls.Add(vScroll)
        AutoScroll = True
    End Sub

    Private Sub lstBooks_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub mnuFile_Click(sender As Object, e As EventArgs) Handles mnuFile.Click

    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub mnuAddBook_Click(sender As Object, e As EventArgs) Handles mnuAddBook.Click
        Me.Show()
    End Sub

    Private Sub mnuDisplayBooks_Click(sender As Object, e As EventArgs) Handles mnuDisplayBooks.Click
        Dim f As New DisplayBooksForm()
        f.Show()
    End Sub

    Private Sub mnuBorrow_Click(sender As Object, e As EventArgs) Handles mnuBorrow.Click
        Dim f As New DisplayBooksForm()
        f.Show()
    End Sub

    Private Sub mnuReturn_Click(sender As Object, e As EventArgs) Handles mnuReturn.Click
        Dim f As New DisplayBooksForm()
        f.Show()
    End Sub

    Private Sub mnuTotalBooks_Click(sender As Object, e As EventArgs) Handles mnuTotalBooks.Click
        MessageBox.Show("Total Books: " & books.Count, "Report")

    End Sub

    Private Sub mnuBorrowedBooks_Click(sender As Object, e As EventArgs) Handles mnuBorrowedBooks.Click
        Dim borrowedCount As Integer = 0
        For Each b As String In books
            If b.Contains("Borrowed") Then
                borrowedCount += 1
            End If
        Next
        MessageBox.Show("Borrowed Books: " & borrowedCount)

    End Sub

    Private Sub mnuAvailableBooks_Click(sender As Object, e As EventArgs) Handles mnuAvailableBooks.Click
        Dim availableCount As Integer = 0
        For Each b As String In books
            If b.Contains("Available") Then
                availableCount += 1
            End If
        Next
        MessageBox.Show("Available Books: " & availableCount)
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        MessageBox.Show(" LibraryManagementSytem Admin Based Management sytem" & vbCrLf & "Developed by: mwecau", "About sytem")
    End Sub
End Class
