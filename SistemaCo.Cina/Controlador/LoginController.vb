Public Class LoginController
    Private userModel As LoginModel

    Public Sub New()
        userModel = New LoginModel()
    End Sub

    Public Function Login(usuario As String, contrasena As String) As Boolean
        Return userModel.AuthenticateUser(usuario, contrasena)
    End Function
End Class
