<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditarRegistro))
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cbxListadoClientes = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.TRegistroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDArchivosDataSet = New Archivos.BDArchivosDataSet()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Inexistente = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoleto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFormularioNro = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtMomentoContable = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtDescripcionDeuda = New System.Windows.Forms.TextBox()
        Me.txtNroTomo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtImporteAdeudado = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtNombreBeneficiario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCHImporteCheque = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpCHFechaCobro = New System.Windows.Forms.DateTimePicker()
        Me.txtCHNro = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCCImporteAdeudado = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpCCFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.txtCCNro = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGestion = New System.Windows.Forms.ComboBox()
        Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPeriodoAdeudado = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.TRegistroTableAdapter = New Archivos.BDArchivosDataSetTableAdapters.TRegistroTableAdapter()
        Me.BDArchivosDataSet1 = New Archivos.BDArchivosDataSet()
        Me.MostrarregistroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mostrar_registroTableAdapter = New Archivos.BDArchivosDataSetTableAdapters.mostrar_registroTableAdapter()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRegistroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDArchivosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.BDArchivosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarregistroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'cbxListadoClientes
        '
        Me.cbxListadoClientes.FormattingEnabled = True
        Me.cbxListadoClientes.Items.AddRange(New Object() {"NroTomo", "Gestion", "PeriodoAdeudado", "Tipo", "ImporteAdeudado", "DescripcionDeuda", "CCNro", "CCFechaPago", "CHNro", "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.cbxListadoClientes.Location = New System.Drawing.Point(6, 25)
        Me.cbxListadoClientes.Name = "cbxListadoClientes"
        Me.cbxListadoClientes.Size = New System.Drawing.Size(147, 21)
        Me.cbxListadoClientes.TabIndex = 1
        Me.cbxListadoClientes.Text = "MomentoContable"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Location = New System.Drawing.Point(6, 51)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(661, 434)
        Me.datalistado.TabIndex = 0
        '
        'BDArchivosDataSet
        '
        Me.BDArchivosDataSet.DataSetName = "BDArchivosDataSet"
        Me.BDArchivosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Location = New System.Drawing.Point(159, 25)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(508, 20)
        Me.txtBuscar.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Inexistente)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.cbxListadoClientes)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Location = New System.Drawing.Point(529, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(673, 497)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Clientes"
        '
        'Inexistente
        '
        Me.Inexistente.AutoSize = True
        Me.Inexistente.Location = New System.Drawing.Point(289, 194)
        Me.Inexistente.Name = "Inexistente"
        Me.Inexistente.Size = New System.Drawing.Size(94, 13)
        Me.Inexistente.TabIndex = 4
        Me.Inexistente.TabStop = True
        Me.Inexistente.Text = "Datos Inexistentes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBoleto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFormularioNro)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtMomentoContable)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionDeuda)
        Me.GroupBox1.Controls.Add(Me.txtNroTomo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtImporteAdeudado)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.txtTipo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtGestion)
        Me.GroupBox1.Controls.Add(Me.dtpFechaPago)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtPeriodoAdeudado)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 497)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Boleto"
        '
        'txtBoleto
        '
        Me.txtBoleto.Location = New System.Drawing.Point(125, 277)
        Me.txtBoleto.MaxLength = 5
        Me.txtBoleto.Name = "txtBoleto"
        Me.txtBoleto.Size = New System.Drawing.Size(68, 20)
        Me.txtBoleto.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Formulario Nro"
        '
        'txtFormularioNro
        '
        Me.txtFormularioNro.Location = New System.Drawing.Point(125, 251)
        Me.txtFormularioNro.MaxLength = 5
        Me.txtFormularioNro.Name = "txtFormularioNro"
        Me.txtFormularioNro.Size = New System.Drawing.Size(68, 20)
        Me.txtFormularioNro.TabIndex = 49
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(153, 437)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(168, 48)
        Me.btnEditar.TabIndex = 14
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 25)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 13)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Momento Contable"
        '
        'txtMomentoContable
        '
        Me.txtMomentoContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtMomentoContable.FormattingEnabled = True
        Me.txtMomentoContable.Items.AddRange(New Object() {"PREVENTIVO", "DEVENGADO"})
        Me.txtMomentoContable.Location = New System.Drawing.Point(126, 21)
        Me.txtMomentoContable.Name = "txtMomentoContable"
        Me.txtMomentoContable.Size = New System.Drawing.Size(121, 21)
        Me.txtMomentoContable.TabIndex = 38
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(43, 51)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Nro Tomo"
        '
        'txtDescripcionDeuda
        '
        Me.txtDescripcionDeuda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionDeuda.Location = New System.Drawing.Point(125, 214)
        Me.txtDescripcionDeuda.MaxLength = 500
        Me.txtDescripcionDeuda.Multiline = True
        Me.txtDescripcionDeuda.Name = "txtDescripcionDeuda"
        Me.txtDescripcionDeuda.Size = New System.Drawing.Size(118, 31)
        Me.txtDescripcionDeuda.TabIndex = 45
        '
        'txtNroTomo
        '
        Me.txtNroTomo.Location = New System.Drawing.Point(125, 48)
        Me.txtNroTomo.MaxLength = 5
        Me.txtNroTomo.Name = "txtNroTomo"
        Me.txtNroTomo.Size = New System.Drawing.Size(66, 20)
        Me.txtNroTomo.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 26)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Descripcion " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de la deuda"
        '
        'txtImporteAdeudado
        '
        Me.txtImporteAdeudado.Location = New System.Drawing.Point(126, 187)
        Me.txtImporteAdeudado.MaxLength = 10
        Me.txtImporteAdeudado.Name = "txtImporteAdeudado"
        Me.txtImporteAdeudado.Size = New System.Drawing.Size(91, 20)
        Me.txtImporteAdeudado.TabIndex = 44
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtNombreBeneficiario)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtCHImporteCheque)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.dtpCHFechaCobro)
        Me.GroupBox3.Controls.Add(Me.txtCHNro)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 314)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(486, 117)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CHEQUE"
        '
        'txtNombreBeneficiario
        '
        Me.txtNombreBeneficiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreBeneficiario.Location = New System.Drawing.Point(11, 69)
        Me.txtNombreBeneficiario.Name = "txtNombreBeneficiario"
        Me.txtNombreBeneficiario.Size = New System.Drawing.Size(459, 20)
        Me.txtNombreBeneficiario.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nombre del Beneficiario"
        '
        'txtCHImporteCheque
        '
        Me.txtCHImporteCheque.Location = New System.Drawing.Point(379, 19)
        Me.txtCHImporteCheque.MaxLength = 10
        Me.txtCHImporteCheque.Name = "txtCHImporteCheque"
        Me.txtCHImporteCheque.Size = New System.Drawing.Size(91, 20)
        Me.txtCHImporteCheque.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(274, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Importe del Cheque"
        '
        'dtpCHFechaCobro
        '
        Me.dtpCHFechaCobro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCHFechaCobro.Location = New System.Drawing.Point(185, 19)
        Me.dtpCHFechaCobro.Name = "dtpCHFechaCobro"
        Me.dtpCHFechaCobro.Size = New System.Drawing.Size(83, 20)
        Me.dtpCHFechaCobro.TabIndex = 22
        '
        'txtCHNro
        '
        Me.txtCHNro.Location = New System.Drawing.Point(38, 19)
        Me.txtCHNro.MaxLength = 5
        Me.txtCHNro.Name = "txtCHNro"
        Me.txtCHNro.Size = New System.Drawing.Size(51, 20)
        Me.txtCHNro.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(95, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Fecha de Cobro"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 13)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Nro "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(59, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Gestión"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtCCImporteAdeudado)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.dtpCCFechaPago)
        Me.GroupBox4.Controls.Add(Me.txtCCNro)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(313, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(155, 234)
        Me.GroupBox4.TabIndex = 46
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "COMPROBANTE DE CONTABILIDAD"
        '
        'txtCCImporteAdeudado
        '
        Me.txtCCImporteAdeudado.Location = New System.Drawing.Point(33, 182)
        Me.txtCCImporteAdeudado.MaxLength = 10
        Me.txtCCImporteAdeudado.Name = "txtCCImporteAdeudado"
        Me.txtCCImporteAdeudado.Size = New System.Drawing.Size(91, 20)
        Me.txtCCImporteAdeudado.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Importe Adeudado"
        '
        'dtpCCFechaPago
        '
        Me.dtpCCFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCCFechaPago.Location = New System.Drawing.Point(33, 113)
        Me.dtpCCFechaPago.Name = "dtpCCFechaPago"
        Me.dtpCCFechaPago.Size = New System.Drawing.Size(99, 20)
        Me.dtpCCFechaPago.TabIndex = 22
        '
        'txtCCNro
        '
        Me.txtCCNro.Location = New System.Drawing.Point(32, 44)
        Me.txtCCNro.MaxLength = 5
        Me.txtCCNro.Name = "txtCCNro"
        Me.txtCCNro.Size = New System.Drawing.Size(100, 20)
        Me.txtCCNro.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(30, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Fecha de Pago"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Nro "
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(126, 161)
        Me.txtTipo.MaxLength = 5
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(51, 20)
        Me.txtTipo.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Importe Adeudado"
        '
        'txtGestion
        '
        Me.txtGestion.FormattingEnabled = True
        Me.txtGestion.Items.AddRange(New Object() {"2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.txtGestion.Location = New System.Drawing.Point(126, 76)
        Me.txtGestion.Name = "txtGestion"
        Me.txtGestion.Size = New System.Drawing.Size(67, 21)
        Me.txtGestion.TabIndex = 40
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPago.Location = New System.Drawing.Point(125, 134)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(83, 20)
        Me.dtpFechaPago.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Periodo Adeudado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(67, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Tipo"
        '
        'txtPeriodoAdeudado
        '
        Me.txtPeriodoAdeudado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPeriodoAdeudado.FormattingEnabled = True
        Me.txtPeriodoAdeudado.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.txtPeriodoAdeudado.Location = New System.Drawing.Point(126, 103)
        Me.txtPeriodoAdeudado.Name = "txtPeriodoAdeudado"
        Me.txtPeriodoAdeudado.Size = New System.Drawing.Size(92, 21)
        Me.txtPeriodoAdeudado.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Fecha de Pago"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(272, 1)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 19
        Me.txtId.Text = "0"
        Me.txtId.Visible = False
        '
        'TRegistroTableAdapter
        '
        Me.TRegistroTableAdapter.ClearBeforeFill = True
        '
        'BDArchivosDataSet1
        '
        Me.BDArchivosDataSet1.DataSetName = "BDArchivosDataSet1"
        Me.BDArchivosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Mostrar_registroTableAdapter
        '
        Me.Mostrar_registroTableAdapter.ClearBeforeFill = True
        '
        'frmEditarRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 536)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEditarRegistro"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = ".:Editar Registro:."
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRegistroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDArchivosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.BDArchivosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarregistroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbxListadoClientes As System.Windows.Forms.ComboBox
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents BDArchivosDataSet As Archivos.BDArchivosDataSet
    Friend WithEvents TRegistroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TRegistroTableAdapter As Archivos.BDArchivosDataSetTableAdapters.TRegistroTableAdapter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCHImporteCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpCHFechaCobro As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCHNro As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtMomentoContable As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionDeuda As System.Windows.Forms.TextBox
    Friend WithEvents txtNroTomo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtImporteAdeudado As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCCImporteAdeudado As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpCCFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCCNro As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGestion As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPeriodoAdeudado As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents Inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombreBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents BDArchivosDataSet1 As Archivos.BDArchivosDataSet
    Friend WithEvents MostrarregistroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mostrar_registroTableAdapter As Archivos.BDArchivosDataSetTableAdapters.mostrar_registroTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBoleto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFormularioNro As System.Windows.Forms.TextBox
End Class
