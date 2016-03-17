<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicioF
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioF))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbUsurio = New System.Windows.Forms.Label()
        Me.lbrol = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.USUARIO = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADMINISTRADOR = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRODEUSUARIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITARREGISTRODEARCHIVOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTES = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportePorNumeroDeChequeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportePorNombreBeneficiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportePorTomoYMomentoContableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 586)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1171, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Rol:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Usuario:"
        '
        'lbUsurio
        '
        Me.lbUsurio.AutoSize = True
        Me.lbUsurio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsurio.Location = New System.Drawing.Point(64, 5)
        Me.lbUsurio.Name = "lbUsurio"
        Me.lbUsurio.Size = New System.Drawing.Size(84, 20)
        Me.lbUsurio.TabIndex = 20
        Me.lbUsurio.Text = "USUARIO"
        '
        'lbrol
        '
        Me.lbrol.AutoSize = True
        Me.lbrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbrol.Location = New System.Drawing.Point(241, 6)
        Me.lbrol.Name = "lbrol"
        Me.lbrol.Size = New System.Drawing.Size(81, 20)
        Me.lbrol.TabIndex = 19
        Me.lbrol.Text = "FUNCION"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackgroundImage = Global.Archivos.My.Resources.Resources.owl
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.USUARIO, Me.ADMINISTRADOR, Me.REPORTES, Me.WindowsMenu, Me.HelpMenu, Me.SalirToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1171, 24)
        Me.MenuStrip.TabIndex = 24
        Me.MenuStrip.Text = "MenuStrip"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem1})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.InicioToolStripMenuItem.Text = "&INICIO"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'USUARIO
        '
        Me.USUARIO.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTROToolStripMenuItem, Me.REPORTESToolStripMenuItem})
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.Size = New System.Drawing.Size(68, 20)
        Me.USUARIO.Text = "&USUARIO"
        '
        'REGISTROToolStripMenuItem
        '
        Me.REGISTROToolStripMenuItem.Name = "REGISTROToolStripMenuItem"
        Me.REGISTROToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.REGISTROToolStripMenuItem.Text = "REGISTRO"
        '
        'REPORTESToolStripMenuItem
        '
        Me.REPORTESToolStripMenuItem.Name = "REPORTESToolStripMenuItem"
        Me.REPORTESToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.REPORTESToolStripMenuItem.Text = "CARGADO DE IMAGENES"
        '
        'ADMINISTRADOR
        '
        Me.ADMINISTRADOR.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTRODEUSUARIOSToolStripMenuItem, Me.EDITARREGISTRODEARCHIVOSToolStripMenuItem})
        Me.ADMINISTRADOR.Name = "ADMINISTRADOR"
        Me.ADMINISTRADOR.Size = New System.Drawing.Size(113, 20)
        Me.ADMINISTRADOR.Text = "A&DMINISTRADOR"
        '
        'REGISTRODEUSUARIOSToolStripMenuItem
        '
        Me.REGISTRODEUSUARIOSToolStripMenuItem.Name = "REGISTRODEUSUARIOSToolStripMenuItem"
        Me.REGISTRODEUSUARIOSToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.REGISTRODEUSUARIOSToolStripMenuItem.Text = "REGISTRO DE USUARIOS"
        '
        'EDITARREGISTRODEARCHIVOSToolStripMenuItem
        '
        Me.EDITARREGISTRODEARCHIVOSToolStripMenuItem.Name = "EDITARREGISTRODEARCHIVOSToolStripMenuItem"
        Me.EDITARREGISTRODEARCHIVOSToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.EDITARREGISTRODEARCHIVOSToolStripMenuItem.Text = "EDITAR REGISTRO DE ARCHIVOS"
        '
        'REPORTES
        '
        Me.REPORTES.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportePorNumeroDeChequeToolStripMenuItem, Me.ReportePorNombreBeneficiarioToolStripMenuItem, Me.ReportePorTomoYMomentoContableToolStripMenuItem})
        Me.REPORTES.Name = "REPORTES"
        Me.REPORTES.Size = New System.Drawing.Size(73, 20)
        Me.REPORTES.Text = "&REPORTES"
        '
        'ReportePorNumeroDeChequeToolStripMenuItem
        '
        Me.ReportePorNumeroDeChequeToolStripMenuItem.Name = "ReportePorNumeroDeChequeToolStripMenuItem"
        Me.ReportePorNumeroDeChequeToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.ReportePorNumeroDeChequeToolStripMenuItem.Text = "Reporte por Numero de Cheque"
        '
        'ReportePorNombreBeneficiarioToolStripMenuItem
        '
        Me.ReportePorNombreBeneficiarioToolStripMenuItem.Name = "ReportePorNombreBeneficiarioToolStripMenuItem"
        Me.ReportePorNombreBeneficiarioToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.ReportePorNombreBeneficiarioToolStripMenuItem.Text = "Reporte por Nombre del Beneficiario"
        '
        'ReportePorTomoYMomentoContableToolStripMenuItem
        '
        Me.ReportePorTomoYMomentoContableToolStripMenuItem.Name = "ReportePorTomoYMomentoContableToolStripMenuItem"
        Me.ReportePorTomoYMomentoContableToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.ReportePorTomoYMomentoContableToolStripMenuItem.Text = "Reporte por Tomo y Momento Contable"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(78, 20)
        Me.WindowsMenu.Text = "&VENTANAS"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(57, 20)
        Me.HelpMenu.Text = "AY&UDA"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ContentsToolStripMenuItem.Text = "&Ayuda"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.IndexToolStripMenuItem.Text = "Contactenos"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(151, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SalirToolStripMenuItem.Text = "SALIR"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1171, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.Archivos.My.Resources.Resources.cancel
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSalir.Location = New System.Drawing.Point(893, 6)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 36)
        Me.btnSalir.TabIndex = 27
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmInicioF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Archivos.My.Resources.Resources.owl
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1171, 608)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbUsurio)
        Me.Controls.Add(Me.lbrol)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.IsMdiContainer = True
        Me.Name = "frmInicioF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:Formulario Principal:."
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbUsurio As System.Windows.Forms.Label
    Friend WithEvents lbrol As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADMINISTRADOR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTRODEUSUARIOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents USUARIO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTROToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDITARREGISTRODEARCHIVOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTES As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportePorNumeroDeChequeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportePorNombreBeneficiarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents ReportePorTomoYMomentoContableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
