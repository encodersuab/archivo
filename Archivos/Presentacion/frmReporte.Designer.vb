<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporte))
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreBeneficiario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumeroTomo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMomentoContable = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoleto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumeroFormulario = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtImporteCheque = New System.Windows.Forms.TextBox()
        Me.txtFechaCobro = New System.Windows.Forms.TextBox()
        Me.txtCCImporteAdeudado = New System.Windows.Forms.TextBox()
        Me.txtCCFechaPago = New System.Windows.Forms.TextBox()
        Me.txtCCNro = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtDescripcionDeuda = New System.Windows.Forms.TextBox()
        Me.txtImporteAdeudado = New System.Windows.Forms.TextBox()
        Me.txtCHNro = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFechaPago = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPeriodoAdeudado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGestion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cbxListadoClientes = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(26, 497)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 41)
        Me.btncancelar.TabIndex = 13
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-3, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nombre del Beneficiario"
        '
        'txtNombreBeneficiario
        '
        Me.txtNombreBeneficiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreBeneficiario.Location = New System.Drawing.Point(133, 95)
        Me.txtNombreBeneficiario.Name = "txtNombreBeneficiario"
        Me.txtNombreBeneficiario.Size = New System.Drawing.Size(140, 20)
        Me.txtNombreBeneficiario.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Numero de Tomo"
        '
        'txtNumeroTomo
        '
        Me.txtNumeroTomo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroTomo.Location = New System.Drawing.Point(132, 147)
        Me.txtNumeroTomo.Name = "txtNumeroTomo"
        Me.txtNumeroTomo.Size = New System.Drawing.Size(140, 20)
        Me.txtNumeroTomo.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "MomentoContable"
        '
        'txtMomentoContable
        '
        Me.txtMomentoContable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMomentoContable.Location = New System.Drawing.Point(132, 121)
        Me.txtMomentoContable.Name = "txtMomentoContable"
        Me.txtMomentoContable.Size = New System.Drawing.Size(140, 20)
        Me.txtMomentoContable.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Boleto"
        '
        'txtBoleto
        '
        Me.txtBoleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBoleto.Location = New System.Drawing.Point(133, 69)
        Me.txtBoleto.Name = "txtBoleto"
        Me.txtBoleto.Size = New System.Drawing.Size(140, 20)
        Me.txtBoleto.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Numero de Formulario"
        '
        'txtNumeroFormulario
        '
        Me.txtNumeroFormulario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroFormulario.Location = New System.Drawing.Point(133, 43)
        Me.txtNumeroFormulario.Name = "txtNumeroFormulario"
        Me.txtNumeroFormulario.Size = New System.Drawing.Size(140, 20)
        Me.txtNumeroFormulario.TabIndex = 2
        '
        'txtId
        '
        Me.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(133, 17)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(140, 20)
        Me.txtId.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtImporteCheque)
        Me.GroupBox1.Controls.Add(Me.txtFechaCobro)
        Me.GroupBox1.Controls.Add(Me.txtCCImporteAdeudado)
        Me.GroupBox1.Controls.Add(Me.txtCCFechaPago)
        Me.GroupBox1.Controls.Add(Me.txtCCNro)
        Me.GroupBox1.Controls.Add(Me.txtTipo)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionDeuda)
        Me.GroupBox1.Controls.Add(Me.txtImporteAdeudado)
        Me.GroupBox1.Controls.Add(Me.txtCHNro)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtFechaPago)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtPeriodoAdeudado)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtGestion)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNombreBeneficiario)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNumeroTomo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtMomentoContable)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBoleto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNumeroFormulario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 544)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(187, 497)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 41)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Cargar Imagen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtImporteCheque
        '
        Me.txtImporteCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImporteCheque.Location = New System.Drawing.Point(132, 458)
        Me.txtImporteCheque.Name = "txtImporteCheque"
        Me.txtImporteCheque.Size = New System.Drawing.Size(140, 20)
        Me.txtImporteCheque.TabIndex = 45
        '
        'txtFechaCobro
        '
        Me.txtFechaCobro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFechaCobro.Location = New System.Drawing.Point(132, 432)
        Me.txtFechaCobro.Name = "txtFechaCobro"
        Me.txtFechaCobro.Size = New System.Drawing.Size(140, 20)
        Me.txtFechaCobro.TabIndex = 44
        '
        'txtCCImporteAdeudado
        '
        Me.txtCCImporteAdeudado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCCImporteAdeudado.Location = New System.Drawing.Point(132, 380)
        Me.txtCCImporteAdeudado.Name = "txtCCImporteAdeudado"
        Me.txtCCImporteAdeudado.Size = New System.Drawing.Size(140, 20)
        Me.txtCCImporteAdeudado.TabIndex = 42
        '
        'txtCCFechaPago
        '
        Me.txtCCFechaPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCCFechaPago.Location = New System.Drawing.Point(132, 354)
        Me.txtCCFechaPago.Name = "txtCCFechaPago"
        Me.txtCCFechaPago.Size = New System.Drawing.Size(140, 20)
        Me.txtCCFechaPago.TabIndex = 41
        '
        'txtCCNro
        '
        Me.txtCCNro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCCNro.Location = New System.Drawing.Point(133, 328)
        Me.txtCCNro.Name = "txtCCNro"
        Me.txtCCNro.Size = New System.Drawing.Size(140, 20)
        Me.txtCCNro.TabIndex = 40
        '
        'txtTipo
        '
        Me.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipo.Location = New System.Drawing.Point(132, 250)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(140, 20)
        Me.txtTipo.TabIndex = 35
        '
        'txtDescripcionDeuda
        '
        Me.txtDescripcionDeuda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionDeuda.Location = New System.Drawing.Point(132, 302)
        Me.txtDescripcionDeuda.Name = "txtDescripcionDeuda"
        Me.txtDescripcionDeuda.Size = New System.Drawing.Size(140, 20)
        Me.txtDescripcionDeuda.TabIndex = 39
        '
        'txtImporteAdeudado
        '
        Me.txtImporteAdeudado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImporteAdeudado.Location = New System.Drawing.Point(132, 276)
        Me.txtImporteAdeudado.Name = "txtImporteAdeudado"
        Me.txtImporteAdeudado.Size = New System.Drawing.Size(140, 20)
        Me.txtImporteAdeudado.TabIndex = 38
        '
        'txtCHNro
        '
        Me.txtCHNro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCHNro.Location = New System.Drawing.Point(132, 406)
        Me.txtCHNro.Name = "txtCHNro"
        Me.txtCHNro.Size = New System.Drawing.Size(140, 20)
        Me.txtCHNro.TabIndex = 43
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(29, 279)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 13)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Importe Deudado"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(18, 305)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 13)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Descripcion Deuda"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(-30, 331)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(146, 13)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Comprobante de Contabilidad"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(24, 361)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "CCFecha de Pago"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 383)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "CCImporteAdeudado"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(32, 409)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Cheque Numero"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(36, 435)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "CHFechaCobro"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 461)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "CHImporteCheque"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Fecha de Pago"
        '
        'txtFechaPago
        '
        Me.txtFechaPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFechaPago.Location = New System.Drawing.Point(133, 224)
        Me.txtFechaPago.Name = "txtFechaPago"
        Me.txtFechaPago.Size = New System.Drawing.Size(140, 20)
        Me.txtFechaPago.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(90, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Tipo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Periodo Adeudado"
        '
        'txtPeriodoAdeudado
        '
        Me.txtPeriodoAdeudado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPeriodoAdeudado.Location = New System.Drawing.Point(132, 199)
        Me.txtPeriodoAdeudado.Name = "txtPeriodoAdeudado"
        Me.txtPeriodoAdeudado.Size = New System.Drawing.Size(140, 20)
        Me.txtPeriodoAdeudado.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Gestion"
        '
        'txtGestion
        '
        Me.txtGestion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGestion.Location = New System.Drawing.Point(132, 173)
        Me.txtGestion.Name = "txtGestion"
        Me.txtGestion.Size = New System.Drawing.Size(140, 20)
        Me.txtGestion.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id"
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        '
        'Inexistente
        '
        Me.Inexistente.AutoSize = True
        Me.Inexistente.Location = New System.Drawing.Point(169, 206)
        Me.Inexistente.Name = "Inexistente"
        Me.Inexistente.Size = New System.Drawing.Size(94, 13)
        Me.Inexistente.TabIndex = 3
        Me.Inexistente.TabStop = True
        Me.Inexistente.Text = "Datos Inexistentes"
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Location = New System.Drawing.Point(186, 25)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(322, 20)
        Me.txtBuscar.TabIndex = 2
        '
        'cbxListadoClientes
        '
        Me.cbxListadoClientes.FormattingEnabled = True
        Me.cbxListadoClientes.Items.AddRange(New Object() {"NombreBeneficiario", "CHNro", "CCNro", "FormularioNro"})
        Me.cbxListadoClientes.Location = New System.Drawing.Point(6, 24)
        Me.cbxListadoClientes.Name = "cbxListadoClientes"
        Me.cbxListadoClientes.Size = New System.Drawing.Size(174, 21)
        Me.cbxListadoClientes.TabIndex = 1
        Me.cbxListadoClientes.Text = "NombreBeneficiario"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        Me.datalistado.Location = New System.Drawing.Point(6, 51)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(676, 401)
        Me.datalistado.TabIndex = 0
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Inexistente)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.cbxListadoClientes)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Location = New System.Drawing.Point(315, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 544)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Beneficiarios"
        '
        'frmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 568)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmReporte"
        Me.Text = ".:Reporte:."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNombreBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroTomo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMomentoContable As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBoleto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroFormulario As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFechaPago As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPeriodoAdeudado As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGestion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbxListadoClientes As System.Windows.Forms.ComboBox
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFechaCobro As System.Windows.Forms.TextBox
    Friend WithEvents txtCCImporteAdeudado As System.Windows.Forms.TextBox
    Friend WithEvents txtCCFechaPago As System.Windows.Forms.TextBox
    Friend WithEvents txtCCNro As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionDeuda As System.Windows.Forms.TextBox
    Friend WithEvents txtImporteAdeudado As System.Windows.Forms.TextBox
    Friend WithEvents txtCHNro As System.Windows.Forms.TextBox
    Friend WithEvents txtImporteCheque As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
