<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMomentoContable = New System.Windows.Forms.ComboBox()
        Me.txtNroTomo = New System.Windows.Forms.TextBox()
        Me.txtPeriodoAdeudado = New System.Windows.Forms.ComboBox()
        Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.txtNroPago = New System.Windows.Forms.TextBox()
        Me.txtImporteAdeudado = New System.Windows.Forms.TextBox()
        Me.txtDescripcionDeuda = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCCImporteAdeudado = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpCCFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.txtCCNro = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNombreBeneficiario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCHImporteCheque = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpCHFechaCobro = New System.Windows.Forms.DateTimePicker()
        Me.txtCHNro = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtBoleto = New System.Windows.Forms.TextBox()
        Me.txtFormularioNro = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtGestion = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Momento Contable"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nro Tomo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gestión"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Periodo Adeudado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(110, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha de Pago"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(208, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nro de Pago"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(143, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Importe Adeudado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(312, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Descripcion de la deuda"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(130, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Nro "
        '
        'txtMomentoContable
        '
        Me.txtMomentoContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtMomentoContable.FormattingEnabled = True
        Me.txtMomentoContable.Items.AddRange(New Object() {"PREVENTIVO", "DEVENGADO"})
        Me.txtMomentoContable.Location = New System.Drawing.Point(6, 57)
        Me.txtMomentoContable.Name = "txtMomentoContable"
        Me.txtMomentoContable.Size = New System.Drawing.Size(121, 21)
        Me.txtMomentoContable.TabIndex = 12
        '
        'txtNroTomo
        '
        Me.txtNroTomo.Location = New System.Drawing.Point(12, 60)
        Me.txtNroTomo.MaxLength = 5
        Me.txtNroTomo.Name = "txtNroTomo"
        Me.txtNroTomo.Size = New System.Drawing.Size(51, 20)
        Me.txtNroTomo.TabIndex = 13
        '
        'txtPeriodoAdeudado
        '
        Me.txtPeriodoAdeudado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPeriodoAdeudado.FormattingEnabled = True
        Me.txtPeriodoAdeudado.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.txtPeriodoAdeudado.Location = New System.Drawing.Point(12, 127)
        Me.txtPeriodoAdeudado.Name = "txtPeriodoAdeudado"
        Me.txtPeriodoAdeudado.Size = New System.Drawing.Size(92, 21)
        Me.txtPeriodoAdeudado.TabIndex = 15
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPago.Location = New System.Drawing.Point(113, 126)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(83, 20)
        Me.dtpFechaPago.TabIndex = 16
        '
        'txtNroPago
        '
        Me.txtNroPago.Location = New System.Drawing.Point(214, 126)
        Me.txtNroPago.MaxLength = 5
        Me.txtNroPago.Name = "txtNroPago"
        Me.txtNroPago.Size = New System.Drawing.Size(51, 20)
        Me.txtNroPago.TabIndex = 17
        '
        'txtImporteAdeudado
        '
        Me.txtImporteAdeudado.Location = New System.Drawing.Point(146, 59)
        Me.txtImporteAdeudado.MaxLength = 10
        Me.txtImporteAdeudado.Name = "txtImporteAdeudado"
        Me.txtImporteAdeudado.Size = New System.Drawing.Size(91, 20)
        Me.txtImporteAdeudado.TabIndex = 18
        '
        'txtDescripcionDeuda
        '
        Me.txtDescripcionDeuda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionDeuda.Location = New System.Drawing.Point(312, 177)
        Me.txtDescripcionDeuda.MaxLength = 10000
        Me.txtDescripcionDeuda.Multiline = True
        Me.txtDescripcionDeuda.Name = "txtDescripcionDeuda"
        Me.txtDescripcionDeuda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcionDeuda.Size = New System.Drawing.Size(237, 125)
        Me.txtDescripcionDeuda.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCCImporteAdeudado)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.dtpCCFechaPago)
        Me.GroupBox1.Controls.Add(Me.txtCCNro)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtMomentoContable)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 90)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COMPROBANTE DE CONTABILIDAD"
        '
        'txtCCImporteAdeudado
        '
        Me.txtCCImporteAdeudado.Location = New System.Drawing.Point(271, 57)
        Me.txtCCImporteAdeudado.MaxLength = 10
        Me.txtCCImporteAdeudado.Name = "txtCCImporteAdeudado"
        Me.txtCCImporteAdeudado.Size = New System.Drawing.Size(91, 20)
        Me.txtCCImporteAdeudado.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(268, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Importe Adeudado"
        '
        'dtpCCFechaPago
        '
        Me.dtpCCFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCCFechaPago.Location = New System.Drawing.Point(182, 57)
        Me.dtpCCFechaPago.Name = "dtpCCFechaPago"
        Me.dtpCCFechaPago.Size = New System.Drawing.Size(83, 20)
        Me.dtpCCFechaPago.TabIndex = 22
        '
        'txtCCNro
        '
        Me.txtCCNro.Location = New System.Drawing.Point(133, 57)
        Me.txtCCNro.MaxLength = 5
        Me.txtCCNro.Name = "txtCCNro"
        Me.txtCCNro.Size = New System.Drawing.Size(43, 20)
        Me.txtCCNro.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(179, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Fecha de Pago"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNombreBeneficiario)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtCHImporteCheque)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.dtpCHFechaCobro)
        Me.GroupBox2.Controls.Add(Me.txtCHNro)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 314)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 91)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CHEQUE"
        '
        'txtNombreBeneficiario
        '
        Me.txtNombreBeneficiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreBeneficiario.Location = New System.Drawing.Point(290, 52)
        Me.txtNombreBeneficiario.Name = "txtNombreBeneficiario"
        Me.txtNombreBeneficiario.Size = New System.Drawing.Size(254, 20)
        Me.txtNombreBeneficiario.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(287, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Nombre Del  Beneficiario"
        '
        'txtCHImporteCheque
        '
        Me.txtCHImporteCheque.Location = New System.Drawing.Point(185, 52)
        Me.txtCHImporteCheque.MaxLength = 10
        Me.txtCHImporteCheque.Name = "txtCHImporteCheque"
        Me.txtCHImporteCheque.Size = New System.Drawing.Size(91, 20)
        Me.txtCHImporteCheque.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(182, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Importe del Cheque"
        '
        'dtpCHFechaCobro
        '
        Me.dtpCHFechaCobro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCHFechaCobro.Location = New System.Drawing.Point(86, 52)
        Me.dtpCHFechaCobro.Name = "dtpCHFechaCobro"
        Me.dtpCHFechaCobro.Size = New System.Drawing.Size(83, 20)
        Me.dtpCHFechaCobro.TabIndex = 22
        '
        'txtCHNro
        '
        Me.txtCHNro.Location = New System.Drawing.Point(19, 52)
        Me.txtCHNro.MaxLength = 5
        Me.txtCHNro.Name = "txtCHNro"
        Me.txtCHNro.Size = New System.Drawing.Size(51, 20)
        Me.txtCHNro.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(83, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Fecha de Cobro"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 13)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Nro "
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(373, 420)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(103, 56)
        Me.btnGuardar.TabIndex = 26
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(39, 420)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(102, 56)
        Me.btnVolver.TabIndex = 29
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtBoleto)
        Me.GroupBox3.Controls.Add(Me.txtFormularioNro)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(422, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(127, 90)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Formulario"
        '
        'txtBoleto
        '
        Me.txtBoleto.Location = New System.Drawing.Point(62, 57)
        Me.txtBoleto.MaxLength = 5
        Me.txtBoleto.Name = "txtBoleto"
        Me.txtBoleto.Size = New System.Drawing.Size(57, 20)
        Me.txtBoleto.TabIndex = 32
        '
        'txtFormularioNro
        '
        Me.txtFormularioNro.Location = New System.Drawing.Point(6, 57)
        Me.txtFormularioNro.MaxLength = 5
        Me.txtFormularioNro.Name = "txtFormularioNro"
        Me.txtFormularioNro.Size = New System.Drawing.Size(50, 20)
        Me.txtFormularioNro.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(59, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Boleto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Nro"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtGestion)
        Me.GroupBox4.Controls.Add(Me.txtImporteAdeudado)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtNroTomo)
        Me.GroupBox4.Controls.Add(Me.txtNroPago)
        Me.GroupBox4.Controls.Add(Me.dtpFechaPago)
        Me.GroupBox4.Controls.Add(Me.txtPeriodoAdeudado)
        Me.GroupBox4.Location = New System.Drawing.Point(18, 147)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(288, 161)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        '
        'txtGestion
        '
        Me.txtGestion.Location = New System.Drawing.Point(70, 59)
        Me.txtGestion.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.txtGestion.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txtGestion.Name = "txtGestion"
        Me.txtGestion.Size = New System.Drawing.Size(70, 20)
        Me.txtGestion.TabIndex = 32
        Me.txtGestion.Value = New Decimal(New Integer() {2015, 0, 0, 0})
        '
        'frmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 488)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDescripcionDeuda)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmRegistro"
        Me.Text = ".:Formulario de Registro:."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txtGestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMomentoContable As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroTomo As System.Windows.Forms.TextBox
    Friend WithEvents txtPeriodoAdeudado As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNroPago As System.Windows.Forms.TextBox
    Friend WithEvents txtImporteAdeudado As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionDeuda As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCCImporteAdeudado As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpCCFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCCNro As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCHImporteCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpCHFechaCobro As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCHNro As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents txtNombreBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBoleto As System.Windows.Forms.TextBox
    Friend WithEvents txtFormularioNro As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGestion As System.Windows.Forms.NumericUpDown
End Class
