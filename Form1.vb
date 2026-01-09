Imports System.IO

Public Class Form1
    Dim books As New List(Of String)
    Dim filePath As String = "library_books.txt"


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
        lstBooks.Items.Clear()
        For Each b In books
            lstBooks.Items.Add(b)
        Next
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        If lstBooks.SelectedIndex <> -1 Then
            Dim selected As String = lstBooks.SelectedItem.ToString()
            books(books.IndexOf(selected)) = selected.Replace("Available", "Borrowed")
            btnDisplay.PerformClick()
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If lstBooks.SelectedIndex <> -1 Then
            Dim selected As String = lstBooks.SelectedItem.ToString()
            books(books.IndexOf(selected)) = selected.Replace("Borrowed", "Available")
            btnDisplay.PerformClick()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lstBooks.SelectedIndex <> -1 Then
            books.Remove(lstBooks.SelectedItem.ToString())
            btnDisplay.PerformClick()
            UpdateCount()
        End If
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

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        Dim vScroll As New VScrollBar()
        vScroll.Minimum = 0
        vScroll.Maximum = 100
        vScroll.Dock = DockStyle.Right
        Me.Controls.Add(vScroll)
        Me.AutoScroll = True
    End Sub
End Class
