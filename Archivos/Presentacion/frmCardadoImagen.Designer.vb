<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCardadoImagen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdRegistro = New System.Windows.Forms.TextBox()
        Me.txtCCNro = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.Imagen = New System.Windows.Forms.PictureBox()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.btnGuardar = New System.Windows.Forms.Button()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Registro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Comprobante de Contabilidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Imagen"
        '
        'txtIdRegistro
        '
        Me.txtIdRegistro.Location = New System.Drawing.Point(76, 28)
        Me.txtIdRegistro.Name = "txtIdRegistro"
        Me.txtIdRegistro.Size = New System.Drawing.Size(100, 20)
        Me.txtIdRegistro.TabIndex = 4
        '
        'txtCCNro
        '
        Me.txtCCNro.Location = New System.Drawing.Point(76, 87)
        Me.txtCCNro.Name = "txtCCNro"
        Me.txtCCNro.Size = New System.Drawing.Size(100, 20)
        Me.txtCCNro.TabIndex = 5
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(76, 152)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(141, 52)
        Me.txtDescripcion.TabIndex = 6
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = Global.Archivos.My.Resources.Resources.Limpiar
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLimpiar.Location = New System.Drawing.Point(107, 225)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(79, 81)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.BackgroundImage = Global.Archivos.My.Resources.Resources.Cargado
        Me.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCargar.Location = New System.Drawing.Point(12, 225)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(79, 81)
        Me.btnCargar.TabIndex = 8
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'Imagen
        '
        Me.Imagen.BackgroundImage = Global.Archivos.My.Resources.Resources.fondo_transparente_fotos
        Me.Imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Imagen.Location = New System.Drawing.Point(235, 16)
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Size = New System.Drawing.Size(266, 411)
        Me.Imagen.TabIndex = 7
        Me.Imagen.TabStop = False
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(76, 361)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmCardadoImagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 435)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.Imagen)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCCNro)
        Me.Controls.Add(Me.txtIdRegistro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCardadoImagen"
        Me.Text = "frmCardadoImagen"
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIdRegistro As System.Windows.Forms.TextBox
    Friend WithEvents txtCCNro As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Imagen As System.Windows.Forms.PictureBox
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents dlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
End Class
