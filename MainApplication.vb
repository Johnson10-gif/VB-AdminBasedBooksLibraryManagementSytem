Imports System.Data.Common
Imports System.Data

Public Class MainApplication

    Private currentUserId As Integer = 0
    Private currentUserName As String = ""
    Private currentRole As String = ""

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub MainApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowLoginPanel()
    End Sub

    Private Sub MainApplication_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    ' ==================== PANEL VISIBILITY ====================

    Private Sub HideAllPanels()
        pnlLogin.Visible = False
        pnlRegister.Visible = False
        pnlAdminDashboard.Visible = False
        pnlAdminRegisterUser.Visible = False
        pnlAdminRegisterBook.Visible = False
        pnlAdminPermitBorrowing.Visible = False
        pnlAdminViewBookStatus.Visible = False
        pnlAdminPermitReturn.Visible = False
        pnlAdminGenerateReport.Visible = False
        pnlUserDashboard.Visible = False
        pnlUserViewBooks.Visible = False
        pnlUserRequestBook.Visible = False
        pnlUserReturnBook.Visible = False
    End Sub

    Private Sub ShowLoginPanel()
        HideAllPanels()
        pnlLogin.Visible = True
        ClearLoginFields()
        txtLoginUsername.Focus()
    End Sub

    Private Sub ShowAdminDashboard()
        HideAllPanels()
        pnlAdminDashboard.Visible = True
        lblAdminWelcome.Text = "Welcome Admin, " & currentUserName
    End Sub

    Private Sub ShowUserDashboard()
        HideAllPanels()
        pnlUserDashboard.Visible = True
        lblUserWelcome.Text = "Welcome " & currentUserName & " (ID: " & currentUserId & ")"
    End Sub

    ' ==================== LOGIN ====================

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtLoginUsername.Text) OrElse String.IsNullOrWhiteSpace(txtLoginPassword.Text) Then
            MessageBox.Show("Please enter username and password.")
            Return
        End If

        Try
            DatabaseConnection.OpenConnection()
            Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                cmd.CommandText = "SELECT UserID, Role, FullName FROM Users WHERE Username=@u AND Password=@p"

                Dim p1 As DbParameter = cmd.CreateParameter()
                p1.ParameterName = "@u"
                p1.Value = txtLoginUsername.Text
                cmd.Parameters.Add(p1)

                Dim p2 As DbParameter = cmd.CreateParameter()
                p2.ParameterName = "@p"
                p2.DbType = DbType.Binary
                p2.Value = DatabaseConnection.ComputeSha256HashBytes(txtLoginPassword.Text)
                cmd.Parameters.Add(p2)

                Using reader As IDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        currentUserId = Convert.ToInt32(reader("UserID"))
                        currentRole = If(IsDBNull(reader("Role")), "User", reader("Role").ToString())
                        currentUserName = If(IsDBNull(reader("FullName")), "", reader("FullName").ToString())

                        If currentRole = "Admin" Then
                            ShowAdminDashboard()
                        Else
                            ShowUserDashboard()
                        End If
                    Else
                        MessageBox.Show("Invalid credentials.")
                        txtLoginPassword.Text = ""
                    End If
                End Using
            End Using
            DatabaseConnection.CloseConnection()
        Catch ex As Exception
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        HideAllPanels()
        pnlRegister.Visible = True
        ClearRegisterFields()
    End Sub

    Private Sub btnExitLogin_Click(sender As Object, e As EventArgs) Handles btnExitLogin.Click
        Application.Exit()
    End Sub

    Private Sub ClearLoginFields()
        txtLoginUsername.Text = ""
        txtLoginPassword.Text = ""
    End Sub

    ' ==================== REGISTER ====================

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If String.IsNullOrWhiteSpace(txtRegFullName.Text) OrElse String.IsNullOrWhiteSpace(txtRegUsername.Text) Then
            MessageBox.Show("Please fill all fields.")
            Return
        End If

        If txtRegPassword.Text <> txtRegConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.")
            Return
        End If

        Try
            DatabaseConnection.OpenConnection()
            Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                cmd.CommandText = "INSERT INTO Users(FullName,Username,Password,Role) VALUES(@f,@u,@p,'User')"

                Dim p1 As DbParameter = cmd.CreateParameter()
                p1.ParameterName = "@f"
                p1.Value = txtRegFullName.Text
                cmd.Parameters.Add(p1)

                Dim p2 As DbParameter = cmd.CreateParameter()
                p2.ParameterName = "@u"
                p2.Value = txtRegUsername.Text
                cmd.Parameters.Add(p2)

                Dim p3 As DbParameter = cmd.CreateParameter()
                p3.ParameterName = "@p"
                p3.DbType = DbType.Binary
                p3.Value = DatabaseConnection.ComputeSha256HashBytes(txtRegPassword.Text)
                cmd.Parameters.Add(p3)

                cmd.ExecuteNonQuery()
            End Using
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Account created! Login now.")
            ShowLoginPanel()
        Catch ex As Exception
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBackRegister_Click(sender As Object, e As EventArgs) Handles btnBackRegister.Click
        ShowLoginPanel()
    End Sub

    Private Sub ClearRegisterFields()
        txtRegFullName.Text = ""
        txtRegUsername.Text = ""
        txtRegPassword.Text = ""
        txtRegConfirmPassword.Text = ""
    End Sub

    ' ==================== ADMIN BUTTONS ====================

    Private Sub btnAdminRegisterUser_Click(sender As Object, e As EventArgs) Handles btnAdminRegisterUser.Click
        HideAllPanels()
        pnlAdminRegisterUser.Visible = True
    End Sub

    Private Sub btnAdminRegisterBook_Click(sender As Object, e As EventArgs) Handles btnAdminRegisterBook.Click
        HideAllPanels()
        pnlAdminRegisterBook.Visible = True
    End Sub

    Private Sub btnAdminPermitBorrowing_Click(sender As Object, e As EventArgs) Handles btnAdminPermitBorrowing.Click
        HideAllPanels()
        pnlAdminPermitBorrowing.Visible = True
        LoadBorrowRequests()
    End Sub

    Private Sub btnAdminViewBookStatus_Click(sender As Object, e As EventArgs) Handles btnAdminViewBookStatus.Click
        HideAllPanels()
        pnlAdminViewBookStatus.Visible = True
        LoadBookStatus()
    End Sub

    Private Sub btnAdminPermitReturn_Click(sender As Object, e As EventArgs) Handles btnAdminPermitReturn.Click
        HideAllPanels()
        pnlAdminPermitReturn.Visible = True
        LoadReturnRequests()
    End Sub

    Private Sub btnAdminGenerateReport_Click(sender As Object, e As EventArgs) Handles btnAdminGenerateReport.Click
        HideAllPanels()
        pnlAdminGenerateReport.Visible = True
        GenerateReport()
    End Sub

    Private Sub btnAdminLogout_Click(sender As Object, e As EventArgs) Handles btnAdminLogout.Click
        currentUserId = 0
        ShowLoginPanel()
    End Sub

    ' ==================== ADMIN REGISTER USER ====================

    Private Sub btnAdminSaveUser_Click(sender As Object, e As EventArgs) Handles btnAdminSaveUser.Click
        If String.IsNullOrWhiteSpace(txtAdminUserName.Text) Then
            MessageBox.Show("Please enter a username.")
            txtAdminUserName.Focus()
            Return
        End If

        ' Default password if not provided
        Dim userPassword As String = If(String.IsNullOrWhiteSpace(txtAdminUserPassword.Text), "Password@123", txtAdminUserPassword.Text)

        Try
            DatabaseConnection.OpenConnection()
            Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                cmd.CommandText = "INSERT INTO Users(FullName,Username,Password,Role) VALUES(@f,@u,@p,@r)"

                Dim p1 As DbParameter = cmd.CreateParameter()
                p1.ParameterName = "@f"
                p1.Value = txtAdminUserName.Text
                cmd.Parameters.Add(p1)

                Dim p2 As DbParameter = cmd.CreateParameter()
                p2.ParameterName = "@u"
                p2.Value = txtAdminUserName.Text
                cmd.Parameters.Add(p2)

                Dim p3 As DbParameter = cmd.CreateParameter()
                p3.ParameterName = "@p"
                p3.DbType = DbType.Binary
                p3.Value = DatabaseConnection.ComputeSha256HashBytes(userPassword)
                cmd.Parameters.Add(p3)

                Dim p4 As DbParameter = cmd.CreateParameter()
                p4.ParameterName = "@r"
                p4.Value = "User"
                cmd.Parameters.Add(p4)

                cmd.ExecuteNonQuery()
            End Using
            DatabaseConnection.CloseConnection()
            MessageBox.Show("User registered successfully!" & vbCrLf & "Username: " & txtAdminUserName.Text & vbCrLf & "Password: " & userPassword)
            txtAdminUserName.Text = ""
            txtAdminUserPassword.Text = ""
            ShowAdminDashboard()
        Catch ex As Exception
            DatabaseConnection.CloseConnection()
            If ex.Message.Contains("Duplicate") OrElse ex.Message.Contains("unique") Then
                MessageBox.Show("Username already exists. Please choose a different username.")
                txtAdminUserName.Focus()
            Else
                MessageBox.Show("Error: " & ex.Message)
            End If
        End Try
    End Sub

    Private Sub btnAdminBackUser_Click(sender As Object, e As EventArgs) Handles btnAdminBackUser.Click
        ShowAdminDashboard()
    End Sub

    ' ==================== ADMIN REGISTER BOOK ====================

    Private Sub btnAdminSaveBook_Click(sender As Object, e As EventArgs) Handles btnAdminSaveBook.Click
        If String.IsNullOrWhiteSpace(txtAdminBookCode.Text) OrElse String.IsNullOrWhiteSpace(txtAdminBookTitle.Text) Then
            MessageBox.Show("Please fill all required fields (Book Code and Title).")
            Return
        End If

        ' Validate year if provided
        Dim yearValue As Integer = 0
        If Not String.IsNullOrWhiteSpace(txtAdminBookYear.Text) Then
            If Not Integer.TryParse(txtAdminBookYear.Text, yearValue) Then
                MessageBox.Show("Please enter a valid year.")
                txtAdminBookYear.Focus()
                Return
            End If
            If yearValue < 1000 OrElse yearValue > DateTime.Now.Year + 1 Then
                MessageBox.Show("Please enter a valid year between 1000 and " & (DateTime.Now.Year + 1).ToString() & ".")
                txtAdminBookYear.Focus()
                Return
            End If
        End If

        ' Validate quantity if provided
        Dim qtyValue As Integer = 1
        If Not String.IsNullOrWhiteSpace(txtAdminBookQuantity.Text) Then
            If Not Integer.TryParse(txtAdminBookQuantity.Text, qtyValue) Then
                MessageBox.Show("Please enter a valid quantity.")
                txtAdminBookQuantity.Focus()
                Return
            End If
            If qtyValue < 1 Then
                MessageBox.Show("Quantity must be at least 1.")
                txtAdminBookQuantity.Focus()
                Return
            End If
        End If

        Try
            DatabaseConnection.OpenConnection()
            Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                cmd.CommandText = "INSERT INTO Books(BookCode,Title,Author,YearPublished,Quantity) VALUES(@code,@title,@author,@year,@qty)"

                Dim p1 As DbParameter = cmd.CreateParameter()
                p1.ParameterName = "@code"
                p1.Value = txtAdminBookCode.Text
                cmd.Parameters.Add(p1)

                Dim p2 As DbParameter = cmd.CreateParameter()
                p2.ParameterName = "@title"
                p2.Value = txtAdminBookTitle.Text
                cmd.Parameters.Add(p2)

                Dim p3 As DbParameter = cmd.CreateParameter()
                p3.ParameterName = "@author"
                p3.Value = If(String.IsNullOrWhiteSpace(txtAdminBookAuthor.Text), DBNull.Value, CObj(txtAdminBookAuthor.Text))
                cmd.Parameters.Add(p3)

                Dim p4 As DbParameter = cmd.CreateParameter()
                p4.ParameterName = "@year"
                p4.Value = If(yearValue = 0, DBNull.Value, CObj(yearValue))
                cmd.Parameters.Add(p4)

                Dim p5 As DbParameter = cmd.CreateParameter()
                p5.ParameterName = "@qty"
                p5.Value = qtyValue
                cmd.Parameters.Add(p5)

                cmd.ExecuteNonQuery()
            End Using
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Book registered successfully!")
            ClearBookFields()
        Catch ex As Exception
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdminBackBook_Click(sender As Object, e As EventArgs) Handles btnAdminBackBook.Click
        ShowAdminDashboard()
    End Sub

    Private Sub ClearBookFields()
        txtAdminBookCode.Text = ""
        txtAdminBookTitle.Text = ""
        txtAdminBookAuthor.Text = ""
        txtAdminBookYear.Text = ""
        txtAdminBookQuantity.Text = ""
    End Sub

    ' ==================== ADMIN PERMIT BORROWING ====================

    Private Sub LoadBorrowRequests()
        Try
            DatabaseConnection.OpenConnection()
            Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                cmd.CommandText = "SELECT br.BorrowRequestID, br.UserID, u.FullName, br.BookID, b.Title, br.RequestDate " &
                                  "FROM BorrowRequests br " &
                                  "INNER JOIN Users u ON br.UserID = u.UserID " &
                                  "INNER JOIN Books b ON br.BookID = b.BookID " &
                                  "WHERE br.Status='Pending' ORDER BY br.RequestDate"
                Dim dt As New DataTable()
                Using reader As IDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
                dgvBorrowRequests.DataSource = dt
            End Using
            DatabaseConnection.CloseConnection()
        Catch ex As Exception
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnApproveRequest_Click(sender As Object, e As EventArgs) Handles btnApproveRequest.Click
        If dgvBorrowRequests.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a borrow request to approve.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id As Integer = Convert.ToInt32(dgvBorrowRequests.SelectedRows(0).Cells("BorrowRequestID").Value)
        Dim userName As String = dgvBorrowRequests.SelectedRows(0).Cells("FullName").Value.ToString()
        Dim bookTitle As String = dgvBorrowRequests.SelectedRows(0).Cells("Title").Value.ToString()

        Dim result As DialogResult = MessageBox.Show("Approve borrow request for:" & vbCrLf & "User: " & userName & vbCrLf & "Book: " & bookTitle & "?", "Confirm Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result <> DialogResult.Yes Then
            Return
        End If

        Try
            DatabaseConnection.OpenConnection()
            Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                cmd.CommandText = "UPDATE BorrowRequests SET Status='Approved' WHERE BorrowRequestID=@id"
                Dim p As DbParameter = cmd.CreateParameter()
                p.ParameterName = "@id"
                p.Value = id
                cmd.Parameters.Add(p)
                cmd.ExecuteNonQuery()
            End Using
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Borrow request approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadBorrowRequests()
        Catch ex As Exception
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Error approving request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdminBackBorrow_Click(sender As Object, e As EventArgs) Handles btnAdminBackBorrow.Click
        ShowAdminDashboard()
    End Sub

    ' ==================== ADMIN VIEW BOOK STATUS ====================

    Private Sub LoadBookStatus()
        Try
            DatabaseConnection.OpenConnection()
            Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                cmd.CommandText = "SELECT BookID, BookCode, Title, Author, YearPublished, Quantity FROM Books ORDER BY Title"
                Dim dt As New DataTable()
                Using reader As IDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
                dgvBookStatus.DataSource = dt
            End Using
            DatabaseConnection.CloseConnection()
        Catch ex As Exception
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdminBackStatus_Click(sender As Object, e As EventArgs) Handles btnAdminBackStatus.Click
        ShowAdminDashboard()
    End Sub

    ' ==================== ADMIN PERMIT RETURN ====================

    Private Sub LoadReturnRequests()
        Try
            DatabaseConnection.OpenConnection()
            Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                cmd.CommandText = "SELECT rr.ReturnRequestID, rr.UserID, u.FullName, rr.BookID, b.Title, rr.RequestDate " &
                                  "FROM ReturnRequests rr " &
                                  "INNER JOIN Users u ON rr.UserID = u.UserID " &
                                  "INNER JOIN Books b ON rr.BookID = b.BookID " &
                                  "WHERE rr.Status='Pending' ORDER BY rr.RequestDate"
                Dim dt As New DataTable()
                Using reader As IDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
                dgvReturnRequests.DataSource = dt
            End Using
            DatabaseConnection.CloseConnection()
        Catch ex As Exception
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnApproveReturn_Click(sender As Object, e As EventArgs) Handles btnApproveReturn.Click
        If dgvReturnRequests.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a return request to approve.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id As Integer = Convert.ToInt32(dgvReturnRequests.SelectedRows(0).Cells("ReturnRequestID").Value)
        Dim userName As String = dgvReturnRequests.SelectedRows(0).Cells("FullName").Value.ToString()
        Dim bookTitle As String = dgvReturnRequests.SelectedRows(0).Cells("Title").Value.ToString()

        Dim result As DialogResult = MessageBox.Show("Approve return request for:" & vbCrLf & "User: " & userName & vbCrLf & "Book: " & bookTitle & "?", "Confirm Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result <> DialogResult.Yes Then
            Return
        End If

        Try
            DatabaseConnection.OpenConnection()
            Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                cmd.CommandText = "UPDATE ReturnRequests SET Status='Approved' WHERE ReturnRequestID=@id"
                Dim p As DbParameter = cmd.CreateParameter()
                p.ParameterName = "@id"
                p.Value = id
                cmd.Parameters.Add(p)
                cmd.ExecuteNonQuery()
            End Using
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Return request approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadReturnRequests()
        Catch ex As Exception
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Error approving return: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdminBackReturn_Click(sender As Object, e As EventArgs) Handles btnAdminBackReturn.Click
        ShowAdminDashboard()
    End Sub

    ' ==================== ADMIN GENERATE REPORT ====================

    Private Sub GenerateReport()
        Try
            Dim report As String = "=== LIBRARY MANAGEMENT REPORT ===" & vbCrLf & vbCrLf
            DatabaseConnection.OpenConnection()

            Try
                Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                    cmd.CommandText = "SELECT COUNT(*) FROM Books"
                    Dim total As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    report &= "Total Books: " & total & vbCrLf
                End Using

                Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                    cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE Role='User'"
                    Dim total As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    report &= "Total Users: " & total & vbCrLf
                End Using

                Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                    cmd.CommandText = "SELECT COUNT(*) FROM BorrowRequests WHERE Status='Approved'"
                    Dim total As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    report &= "Active Loans: " & total & vbCrLf
                End Using

                Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                    cmd.CommandText = "SELECT COUNT(*) FROM BorrowRequests WHERE Status='Pending'"
                    Dim total As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    report &= "Pending Requests: " & total & vbCrLf
                End Using

                txtAdminReport.Text = report
            Finally
                DatabaseConnection.CloseConnection()
            End Try
        Catch ex As Exception
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdminBackReport_Click(sender As Object, e As EventArgs) Handles btnAdminBackReport.Click
        ShowAdminDashboard()
    End Sub

    ' ==================== USER BUTTONS ====================

    Private Sub btnUserViewBooks_Click(sender As Object, e As EventArgs) Handles btnUserViewBooks.Click
        HideAllPanels()
        pnlUserViewBooks.Visible = True
        LoadAvailableBooks()
    End Sub

    Private Sub btnUserRequestBook_Click(sender As Object, e As EventArgs) Handles btnUserRequestBook.Click
        HideAllPanels()
        pnlUserRequestBook.Visible = True
    End Sub

    Private Sub btnUserReturnBook_Click(sender As Object, e As EventArgs) Handles btnUserReturnBook.Click
        HideAllPanels()
        pnlUserReturnBook.Visible = True
        LoadUserBooks()
    End Sub

    Private Sub btnUserLogout_Click(sender As Object, e As EventArgs) Handles btnUserLogout.Click
        currentUserId = 0
        ShowLoginPanel()
    End Sub

    ' ==================== USER VIEW BOOKS ====================

    Private Sub LoadAvailableBooks()
        Try
            DatabaseConnection.OpenConnection()
            Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                cmd.CommandText = "SELECT BookID, BookCode, Title, Author, YearPublished, Quantity FROM Books WHERE Quantity > 0 ORDER BY Title"
                Dim dt As New DataTable()
                Using reader As IDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
                dgvUserAvailableBooks.DataSource = dt
            End Using
            DatabaseConnection.CloseConnection()
        Catch ex As Exception
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUserBackViewBooks_Click(sender As Object, e As EventArgs) Handles btnUserBackViewBooks.Click
        ShowUserDashboard()
    End Sub

    ' ==================== USER REQUEST BOOK ====================

    Private Sub btnUserSubmitRequest_Click(sender As Object, e As EventArgs) Handles btnUserSubmitRequest.Click
        If String.IsNullOrWhiteSpace(txtUserBookID.Text) Then
            MessageBox.Show("Please enter a Book ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUserBookID.Focus()
            Return
        End If

        Dim bookId As Integer = 0
        If Not Integer.TryParse(txtUserBookID.Text, bookId) Then
            MessageBox.Show("Please enter a valid Book ID (numeric value).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUserBookID.Focus()
            Return
        End If

        Try
            DatabaseConnection.OpenConnection()

            ' Check if book exists and is available
            Dim bookExists As Boolean = False
            Dim bookTitle As String = ""
            Dim availableQty As Integer = 0

            Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                cmd.CommandText = "SELECT Title, Quantity FROM Books WHERE BookID=@id"
                Dim p As DbParameter = cmd.CreateParameter()
                p.ParameterName = "@id"
                p.Value = bookId
                cmd.Parameters.Add(p)

                Using reader As IDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        bookExists = True
                        bookTitle = If(IsDBNull(reader("Title")), "Unknown", reader("Title").ToString())
                        availableQty = Convert.ToInt32(reader("Quantity"))
                    End If
                End Using
            End Using

            If Not bookExists Then
                DatabaseConnection.CloseConnection()
                MessageBox.Show("Book ID not found. Please check and try again.", "Book Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUserBookID.Focus()
                Return
            End If

            If availableQty <= 0 Then
                DatabaseConnection.CloseConnection()
                MessageBox.Show("This book is currently not available. Quantity: " & availableQty, "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUserBookID.Text = ""
                Return
            End If

            ' Submit borrow request
            Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                cmd.CommandText = "INSERT INTO BorrowRequests(UserID,BookID,RequestDate,Status) VALUES(@uid,@bid,@date,'Pending')"

                Dim p1 As DbParameter = cmd.CreateParameter()
                p1.ParameterName = "@uid"
                p1.Value = currentUserId
                cmd.Parameters.Add(p1)

                Dim p2 As DbParameter = cmd.CreateParameter()
                p2.ParameterName = "@bid"
                p2.Value = bookId
                cmd.Parameters.Add(p2)

                Dim p3 As DbParameter = cmd.CreateParameter()
                p3.ParameterName = "@date"
                p3.Value = DateTime.Now
                cmd.Parameters.Add(p3)

                cmd.ExecuteNonQuery()
            End Using

            DatabaseConnection.CloseConnection()
            MessageBox.Show("Borrow request submitted successfully for:" & vbCrLf & bookTitle & vbCrLf & vbCrLf & "Please wait for admin approval.", "Request Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUserBookID.Text = ""
        Catch ex As Exception
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Error submitting request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUserBackRequest_Click(sender As Object, e As EventArgs) Handles btnUserBackRequest.Click
        ShowUserDashboard()
    End Sub

    ' ==================== USER RETURN BOOK ====================

    Private Sub LoadUserBooks()
        Try
            DatabaseConnection.OpenConnection()
            Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                cmd.CommandText = "SELECT br.BorrowRequestID, br.BookID, b.Title, b.Author, br.RequestDate " &
                                  "FROM BorrowRequests br " &
                                  "INNER JOIN Books b ON br.BookID = b.BookID " &
                                  "WHERE br.UserID=@uid AND br.Status='Approved'"
                Dim p As DbParameter = cmd.CreateParameter()
                p.ParameterName = "@uid"
                p.Value = currentUserId
                cmd.Parameters.Add(p)

                Dim dt As New DataTable()
                Using reader As IDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
                dgvUserBooks.DataSource = dt
            End Using
            DatabaseConnection.CloseConnection()
        Catch ex As Exception
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUserSubmitReturn_Click(sender As Object, e As EventArgs) Handles btnUserSubmitReturn.Click
        If dgvUserBooks.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a book to return.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim borrowId As Integer = Convert.ToInt32(dgvUserBooks.SelectedRows(0).Cells("BorrowRequestID").Value)
        Dim bookTitle As String = dgvUserBooks.SelectedRows(0).Cells("Title").Value.ToString()

        Dim result As DialogResult = MessageBox.Show("Submit return request for:" & vbCrLf & "Book: " & bookTitle & "?", "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result <> DialogResult.Yes Then
            Return
        End If

        Try
            DatabaseConnection.OpenConnection()
            Using cmd As DbCommand = DatabaseConnection.con.CreateCommand()
                cmd.CommandText = "INSERT INTO ReturnRequests(UserID,BookID,RequestDate,Status) SELECT UserID,BookID,@date,'Pending' FROM BorrowRequests WHERE BorrowRequestID=@id"

                Dim p1 As DbParameter = cmd.CreateParameter()
                p1.ParameterName = "@id"
                p1.Value = borrowId
                cmd.Parameters.Add(p1)

                Dim p2 As DbParameter = cmd.CreateParameter()
                p2.ParameterName = "@date"
                p2.Value = DateTime.Now
                cmd.Parameters.Add(p2)

                cmd.ExecuteNonQuery()
            End Using
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Return request submitted successfully! Please wait for admin approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadUserBooks()
        Catch ex As Exception
            DatabaseConnection.CloseConnection()
            MessageBox.Show("Error submitting return request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUserBackReturn_Click(sender As Object, e As EventArgs) Handles btnUserBackReturn.Click
        ShowUserDashboard()
    End Sub

    Private Sub pnlLogin_Paint(sender As Object, e As PaintEventArgs) Handles pnlLogin.Paint

    End Sub
End Class
