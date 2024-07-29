<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        CatalogoToolStripMenuItem = New ToolStripMenuItem()
        AlmacenToolStripMenuItem = New ToolStripMenuItem()
        PreciosToolStripMenuItem = New ToolStripMenuItem()
        ReportesToolStripMenuItem = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(156, 54)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(512, 178)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(388, 257)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 15)
        Label1.TabIndex = 1
        Label1.Text = "Bienvenido"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {CatalogoToolStripMenuItem, AlmacenToolStripMenuItem, PreciosToolStripMenuItem, ReportesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CatalogoToolStripMenuItem
        ' 
        CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem"
        CatalogoToolStripMenuItem.Size = New Size(67, 20)
        CatalogoToolStripMenuItem.Text = "Catalogo"
        ' 
        ' AlmacenToolStripMenuItem
        ' 
        AlmacenToolStripMenuItem.Name = "AlmacenToolStripMenuItem"
        AlmacenToolStripMenuItem.Size = New Size(66, 20)
        AlmacenToolStripMenuItem.Text = "Almacen"
        ' 
        ' PreciosToolStripMenuItem
        ' 
        PreciosToolStripMenuItem.Name = "PreciosToolStripMenuItem"
        PreciosToolStripMenuItem.Size = New Size(57, 20)
        PreciosToolStripMenuItem.Text = "Precios"
        ' 
        ' ReportesToolStripMenuItem
        ' 
        ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        ReportesToolStripMenuItem.Size = New Size(65, 20)
        ReportesToolStripMenuItem.Text = "Reportes"
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Main"
        Text = "Main"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatalogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlmacenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
End Class
