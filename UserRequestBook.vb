Imports MySql.Data.MySqlClient

Public Class UserRequestBook
    Inherits Form

    Private currentUserId As Integer
    Private WithEvents txtBookID As TextBox
    Private WithEvents btnSubmit As Button
    Private WithEvents btnViewBooks As Button
    Private WithEvents btnClose As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblBookID As Label
    Friend WithEvents lblInstructions As Label
    Private lblTitle As Label

    Public Sub New(userId As Integer)
        currentUserId = userId
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnViewBooks = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(95, 43)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(460, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "REQUEST BOOK"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfo
        '
        Me.lblInfo.ForeColor = System.Drawing.Color.Gray
        Me.lblInfo.Location = New System.Drawing.Point(99, 130)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(460, 20)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Enter the Book ID of the book you want to borrow."
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBookID
        '
        Me.lblBookID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookID.Location = New System.Drawing.Point(173, 191)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(100, 20)
        Me.lblBookID.TabIndex = 2
        Me.lblBookID.Text = "Book ID:"
        '
        'txtBookID
        '
        Me.txtBookID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtBookID.Location = New System.Drawing.Point(169, 223)
        Me.txtBookID.Multiline = True
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(340, 39)
        Me.txtBookID.TabIndex = 3
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblInstructions.ForeColor = System.Drawing.Color.Gray
        Me.lblInstructions.Location = New System.Drawing.Point(150, 347)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(359, 30)
        Me.lblInstructions.TabIndex = 4
        Me.lblInstructions.Text = " Use 'View Books' button below to see available  books and their IDs."
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(113, 445)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(160, 50)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "SUBMIT REQUEST"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnViewBooks
        '
        Me.btnViewBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnViewBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewBooks.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnViewBooks.ForeColor = System.Drawing.Color.White
        Me.btnViewBooks.Location = New System.Drawing.Point(349, 445)
        Me.btnViewBooks.Name = "btnViewBooks"
        Me.btnViewBooks.Size = New System.Drawing.Size(160, 50)
        Me.btnViewBooks.TabIndex = 6
        Me.btnViewBooks.Text = "VIEW BOOKS"
        Me.btnViewBooks.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(228, 538)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(160, 42)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'UserRequestBook
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(649, 634)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblBookID)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnViewBooks)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserRequestBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User - Request Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrWhiteSpace(txtBookID.Text) Then
            MessageBox.Show("Please enter a Book ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBookID.Focus()
            Return
        End If

        Dim bookId As Integer = 0
        If Not Integer.TryParse(txtBookID.Text, bookId) Then
            MessageBox.Show("Please enter a valid Book ID (numeric value).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBookID.Focus()
            Return
        End If

        Try
            ' Check if book exists and is available
            Dim bookTitle As String = ""
            Dim quantity As Integer = 0
            If DatabaseHelper.IsBookAvailable(bookId, bookTitle, quantity) Then
                ' Submit borrow request
                DatabaseHelper.SubmitBorrowRequest(currentUserId, bookId)
                MessageBox.Show("Borrow request submitted successfully!" & vbCrLf & vbCrLf &
                              "Book: " & bookTitle & vbCrLf &
                              "Status: Pending approval" & vbCrLf & vbCrLf &
                              "Please wait for admin approval.",
                              "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtBookID.Clear()
            Else
                If String.IsNullOrEmpty(bookTitle) Then
                    MessageBox.Show("Book ID not found. Please check and try again.", "Book Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Book '" & bookTitle & "' is currently not available." & vbCrLf &
                                  "Available quantity: " & quantity,
                                  "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                txtBookID.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnViewBooks_Click(sender As Object, e As EventArgs) Handles btnViewBooks.Click
        Dim form As New UserViewBooks()
        form.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
