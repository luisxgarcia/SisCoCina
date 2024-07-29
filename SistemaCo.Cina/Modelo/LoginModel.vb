Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class LoginModel
    Private dbConnection As DatabaseConnection

    Public Sub New()
        dbConnection = New DatabaseConnection()
    End Sub

    Public Function AuthenticateUser(usuario As String, contrasena As String) As Boolean
        Dim sql As String = "SELECT * FROM dbo.usuario WHERE usuario = @usuario AND clave = @clave"
        Dim claveCifrada As String = CifrarSHA256(contrasena)

        Using connection As SqlConnection = dbConnection.GetConnection()
            Using cmd As New SqlCommand(sql, connection)
                cmd.Parameters.AddWithValue("@usuario", usuario)
                cmd.Parameters.AddWithValue("@clave", HexStringToByteArray(claveCifrada))

                dbConnection.OpenConnection()
                Dim dr As SqlDataReader = cmd.ExecuteReader()

                If dr.Read() Then
                    dbConnection.CloseConnection()
                    Return True
                Else
                    dbConnection.CloseConnection()
                    Return False
                End If
            End Using
        End Using
    End Function

    Private Function CifrarSHA256(ByVal texto As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("X2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Function HexStringToByteArray(hex As String) As Byte()
        Dim NumberChars As Integer = hex.Length
        Dim bytes(NumberChars \ 2 - 1) As Byte
        For i As Integer = 0 To NumberChars - 1 Step 2
            bytes(i \ 2) = Convert.ToByte(hex.Substring(i, 2), 16)
        Next
        Return bytes
    End Function
End Class
