Imports System.Data.Common
Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.SqlClient

Public Module DatabaseConnection

    Public ReadOnly con As DbConnection = CreateDbConnection()

    Private Function CreateDbConnection() As DbConnection
        Dim conn As New SqlConnection()
        conn.ConnectionString = "Server=localhost\SQLEXPRESS;Database=librarydb;User Id=sa;Password=Library@2026;TrustServerCertificate=True;"
        Return conn
    End Function

    Public Sub OpenConnection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Public Sub CloseConnection()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Public Function ComputeSha256HashBytes(ByVal plainText As String) As Byte()
        Using sha As SHA256 = SHA256.Create()
            Return sha.ComputeHash(Encoding.UTF8.GetBytes(plainText))
        End Using
    End Function

End Module

