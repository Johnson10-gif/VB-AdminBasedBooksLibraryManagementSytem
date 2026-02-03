Imports System.Data.Common
Imports System.Security.Cryptography
Imports System.Text

Public Module DatabaseConnection

    Public ReadOnly con As DbConnection = CreateDbConnection()

    Private Function CreateDbConnection() As DbConnection
        Dim connType As Type = Nothing

        ' Try MySqlConnector then MySql.Data
        connType = Type.GetType("MySqlConnector.MySqlConnection, MySqlConnector")
        If connType Is Nothing Then
            connType = Type.GetType("MySql.Data.MySqlClient.MySqlConnection, MySql.Data")
        End If

        If connType Is Nothing Then
            Throw New Exception("MySQL ADO.NET provider not found. Install MySqlConnector or MySql.Data via NuGet.")
        End If

        Dim conn As DbConnection = DirectCast(Activator.CreateInstance(connType), DbConnection)
        conn.ConnectionString = "Server=localhost;Database=librarydb;Uid=lib_user;Pwd=123;SslMode=none;"
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

