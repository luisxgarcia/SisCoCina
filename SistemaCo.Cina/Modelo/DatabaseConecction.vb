Imports System.Data.SqlClient

Public Class DatabaseConnection
    Private connectionString As String = "Data Source=LUISGARCIAPC;Initial Catalog=dbCremPach;User ID=sa;Password=sql123;Integrated Security=False"
    Private connection As SqlConnection

    Public Sub New()
        connection = New SqlConnection(connectionString)
    End Sub

    Public Function GetConnection() As SqlConnection
        Return connection
    End Function

    Public Sub OpenConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    Public Sub CloseConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class
