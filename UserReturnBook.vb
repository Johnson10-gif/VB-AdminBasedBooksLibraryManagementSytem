Imports System.Data.SqlClient

Public Class UserReturnBook
    Inherits Form

    Private currentUserId As Integer
    Private WithEvents dgvBorrowedBooks As DataGridView
    Private WithEvents btnSubmitReturn As Button
    Private WithEvents btnRefresh As Button
    Private WithEvents btnClose As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Private lblTitle As Label

    Public Sub New(userId As Integer)
        currentUserId = userId
        InitializeComponent()
        LoadBorrowedBooks()
    End Sub

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.dgvBorrowedBooks = New System.Windows.Forms.DataGridView()
        Me.btnSubmitReturn = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.dgvBorrowedBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(53, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(860, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "RETURN BOOK (REQUEST)"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfo
        '
        Me.lblInfo.ForeColor = System.Drawing.Color.Gray
        Me.lblInfo.Location = New System.Drawing.Point(39, 98)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(860, 20)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Select a book from your borrowed books and click 'Submit Return Request'."
        '
        'dgvBorrowedBooks
        '
        Me.dgvBorrowedBooks.AllowUserToAddRows = False
        Me.dgvBorrowedBooks.AllowUserToDeleteRows = False
        Me.dgvBorrowedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBorrowedBooks.ColumnHeadersHeight = 29
        Me.dgvBorrowedBooks.Location = New System.Drawing.Point(60, 136)
        Me.dgvBorrowedBooks.MultiSelect = False
        Me.dgvBorrowedBooks.Name = "dgvBorrowedBooks"
        Me.dgvBorrowedBooks.ReadOnly = True
        Me.dgvBorrowedBooks.RowHeadersWidth = 51
        Me.dgvBorrowedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBorrowedBooks.Size = New System.Drawing.Size(860, 391)
        Me.dgvBorrowedBooks.TabIndex = 2
        '
        'btnSubmitReturn
        '
        Me.btnSubmitReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubmitReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitReturn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmitReturn.ForeColor = System.Drawing.Color.White
        Me.btnSubmitReturn.Location = New System.Drawing.Point(208, 533)
        Me.btnSubmitReturn.Name = "btnSubmitReturn"
        Me.btnSubmitReturn.Size = New System.Drawing.Size(180, 35)
        Me.btnSubmitReturn.TabIndex = 3
        Me.btnSubmitReturn.Text = "SUBMIT RETURN REQUEST"
        Me.btnSubmitReturn.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(448, 533)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(120, 35)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(633, 533)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 35)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(1, 574)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 68)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblTitle)
        Me.Panel2.Location = New System.Drawing.Point(1, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(978, 69)
        Me.Panel2.TabIndex = 7
        '
        'UserReturnBook
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(980, 641)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.dgvBorrowedBooks)
        Me.Controls.Add(Me.btnSubmitReturn)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "UserReturnBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User - Return Book"
        CType(Me.dgvBorrowedBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private Sub LoadBorrowedBooks()
        Try
            Using conn As SqlConnection = DatabaseHelper.GetConnection()
                conn.Open()
                Dim query As String = "SELECT br.BorrowRequestID, br.BookID, b.BookCode AS [Book Code], " &
                                     "b.Title, b.Author, br.RequestDate AS [Borrowed Date], br.Status " &
                                     "FROM BorrowRequests br " &
                                     "INNER JOIN Books b ON br.BookID = b.BookID " &
                                     "WHERE br.UserID = @userId AND br.Status = 'Approved' " &
                                     "ORDER BY br.RequestDate DESC"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", currentUserId)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvBorrowedBooks.DataSource = dt

                    ' Hide ID columns
                    If dgvBorrowedBooks.Columns.Count > 0 Then
                        dgvBorrowedBooks.Columns("BorrowRequestID").Visible = False
                        dgvBorrowedBooks.Columns("BookID").Visible = False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading borrowed books: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSubmitReturn_Click(sender As Object, e As EventArgs) Handles btnSubmitReturn.Click
        If dgvBorrowedBooks.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a book to return.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bookId As Integer = Convert.ToInt32(dgvBorrowedBooks.SelectedRows(0).Cells("BookID").Value)
        Dim bookTitle As String = dgvBorrowedBooks.SelectedRows(0).Cells("Title").Value.ToString()

        Dim result As DialogResult = MessageBox.Show("Submit return request for:" & vbCrLf & vbCrLf &
                                                     "Book: " & bookTitle & vbCrLf & vbCrLf &
                                                     "Note: This will submit a request to admin for approval.",
                                                     "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                DatabaseHelper.SubmitReturnRequest(currentUserId, bookId)
                MessageBox.Show("Return request submitted successfully!" & vbCrLf & vbCrLf &
                              "Book: " & bookTitle & vbCrLf &
                              "Status: Pending admin approval",
                              "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadBorrowedBooks()
            Catch ex As Exception
                MessageBox.Show("Error submitting return request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadBorrowedBooks()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
