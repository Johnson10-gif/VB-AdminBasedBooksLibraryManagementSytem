Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Module DatabaseHelper

    ' Connection string for MySQL (XAMPP)
    ' Adjust Server, Port, Database, Uid, and Pwd as needed
    Private ReadOnly ConnectionString As String = "Server=localhost;Port=3306;Database=librarydb;Uid=root;Pwd=;SslMode=none;"

    ''' <summary>
    ''' Gets a new MySQL connection
    ''' </summary>
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function

    ''' <summary>
    ''' Computes SHA256 hash for password
    ''' </summary>
    Public Function HashPassword(plainText As String) As Byte()
        Using sha As SHA256 = SHA256.Create()
            Return sha.ComputeHash(Encoding.UTF8.GetBytes(plainText))
        End Using
    End Function

    ''' <summary>
    ''' Tests database connection
    ''' </summary>
    Public Function TestConnection() As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Authenticates user and returns user information
    ''' </summary>
    Public Function AuthenticateUser(username As String, password As String, ByRef userId As Integer, ByRef fullName As String, ByRef role As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT UserID, FullName, Role FROM Users WHERE Username=@username AND Password=@password"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", HashPassword(password))

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            userId = Convert.ToInt32(reader("UserID"))
                            fullName = reader("FullName").ToString()
                            role = reader("Role").ToString()
                            Return True
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Authentication error: " & ex.Message)
        End Try
        Return False
    End Function

    ''' <summary>
    ''' Registers a new user
    ''' </summary>
    Public Function RegisterUser(fullName As String, username As String, password As String, Optional role As String = "User") As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO Users (FullName, Username, Password, Role) VALUES (@fullName, @username, @password, @role)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fullName", fullName)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", HashPassword(password))
                    cmd.Parameters.AddWithValue("@role", role)

                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Registration error: " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Registers a new book
    ''' </summary>
    Public Function RegisterBook(bookCode As String, title As String, author As String, yearPublished As Integer, quantity As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO Books (BookCode, Title, Author, YearPublished, Quantity) VALUES (@code, @title, @author, @year, @qty)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@code", If(String.IsNullOrEmpty(bookCode), DBNull.Value, CObj(bookCode)))
                    cmd.Parameters.AddWithValue("@title", title)
                    cmd.Parameters.AddWithValue("@author", If(String.IsNullOrEmpty(author), DBNull.Value, CObj(author)))
                    cmd.Parameters.AddWithValue("@year", If(yearPublished = 0, DBNull.Value, CObj(yearPublished)))
                    cmd.Parameters.AddWithValue("@qty", quantity)

                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Book registration error: " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Submits a borrow request
    ''' </summary>
    Public Function SubmitBorrowRequest(userId As Integer, bookId As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO BorrowRequests (UserID, BookID, RequestDate, Status) VALUES (@userId, @bookId, @date, 'Pending')"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", userId)
                    cmd.Parameters.AddWithValue("@bookId", bookId)
                    cmd.Parameters.AddWithValue("@date", DateTime.Now)

                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Borrow request error: " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Submits a return request
    ''' </summary>
    Public Function SubmitReturnRequest(userId As Integer, bookId As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO ReturnRequests (UserID, BookID, RequestDate, Status) VALUES (@userId, @bookId, @date, 'Pending')"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", userId)
                    cmd.Parameters.AddWithValue("@bookId", bookId)
                    cmd.Parameters.AddWithValue("@date", DateTime.Now)

                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Return request error: " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Approves a borrow request
    ''' </summary>
    Public Function ApproveBorrowRequest(requestId As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "UPDATE BorrowRequests SET Status='Approved' WHERE BorrowRequestID=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", requestId)
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Approval error: " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Approves a return request
    ''' </summary>
    Public Function ApproveReturnRequest(requestId As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "UPDATE ReturnRequests SET Status='Approved' WHERE ReturnRequestID=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", requestId)
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Return approval error: " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Checks if book is available
    ''' </summary>
    Public Function IsBookAvailable(bookId As Integer, ByRef bookTitle As String, ByRef quantity As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT Title, Quantity FROM Books WHERE BookID=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", bookId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            bookTitle = reader("Title").ToString()
                            quantity = Convert.ToInt32(reader("Quantity"))
                            Return quantity > 0
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Book availability check error: " & ex.Message)
        End Try
        Return False
    End Function

End Module
