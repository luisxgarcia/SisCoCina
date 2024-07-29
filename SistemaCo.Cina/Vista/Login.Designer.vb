<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TxtUsuario = New TextBox()
        TxtContrasena = New TextBox()
        Button2 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(478, 46)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Location = New Point(429, 11)
        Button1.Name = "Button1"
        Button1.Size = New Size(37, 23)
        Button1.TabIndex = 0
        Button1.Text = "x"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(90, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 1
        Label1.Text = "Usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(70, 219)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 2
        Label2.Text = "Contraseña"
        ' 
        ' TxtUsuario
        ' 
        TxtUsuario.Location = New Point(172, 141)
        TxtUsuario.Name = "TxtUsuario"
        TxtUsuario.Size = New Size(100, 23)
        TxtUsuario.TabIndex = 3
        ' 
        ' TxtContrasena
        ' 
        TxtContrasena.Location = New Point(172, 211)
        TxtContrasena.Name = "TxtContrasena"
        TxtContrasena.PasswordChar = "*"c
        TxtContrasena.Size = New Size(100, 23)
        TxtContrasena.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(197, 287)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 5
        Button2.Text = "Ingresar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(479, 406)
        Controls.Add(Button2)
        Controls.Add(TxtContrasena)
        Controls.Add(TxtUsuario)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "Login"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents Button2 As Button

End Class
