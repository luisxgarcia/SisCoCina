Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports SistemaCo.Cina.Main

Public Class Login
    Private userController As LoginController

    Public Sub New()
        InitializeComponent()
        userController = New LoginController()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsuario.Select() ' Establece el foco en el campo de usuario al cargar el formulario
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ValidarCredenciales()
    End Sub

    Private Sub ValidarCredenciales()
        Dim usuario As String = TxtUsuario.Text
        Dim contrasena As String = TxtContrasena.Text

        If userController.Login(usuario, contrasena) Then
            Me.Hide()
            Dim mainForm As New Main()
            mainForm.Show()
        Else
            MsgBox("Usuario o contraseña incorrecta")
        End If
    End Sub

    Private Sub TxtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtContrasena.Focus()
        End If
    End Sub

    Private Sub TxtContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtContrasena.KeyDown
        If e.KeyCode = Keys.Enter Then
            ValidarCredenciales()
        End If
    End Sub

    Private Sub Button2_KeyDown(sender As Object, e As KeyEventArgs) Handles Button2.KeyDown
        If e.KeyCode = Keys.Enter Then
            ValidarCredenciales()
        End If
    End Sub
End Class
