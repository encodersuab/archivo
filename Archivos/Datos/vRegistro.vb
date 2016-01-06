Public Class vRegistro
    Dim id As Integer
    Dim NroTomo, Gestion, CCNro, CHNro, NombreBeneficiario, MomentoContable, PeriodoAdeudado, NroPago, DescripcionDeuda, FormularioNro, Boleto As String
    Dim FechaPago, CCFechaPago, CHFechaCobro As Date
    Dim ImporteAdeudado, CCImporteAdeudado, CHImporteCheque As Decimal

    Public Property gid
        Get
            Return id
        End Get
        Set(ByVal value)
            id = value
        End Set
    End Property
    Public Property gFormularioNro
        Get
            Return FormularioNro
        End Get
        Set(ByVal value)
            FormularioNro = value
        End Set
    End Property
    Public Property gBoleto
        Get
            Return Boleto
        End Get
        Set(ByVal value)
            Boleto = value
        End Set
    End Property
    Public Property gNroTomo
        Get
            Return NroTomo
        End Get
        Set(ByVal value)
            NroTomo = value
        End Set
    End Property


    Public Property gGestion
        Get
            Return Gestion
        End Get
        Set(ByVal value)
            Gestion = value
        End Set
    End Property
    Public Property gCCNro
        Get
            Return CCNro
        End Get
        Set(ByVal value)
            CCNro = value
        End Set
    End Property
    Public Property gCHNro
        Get
            Return CHNro
        End Get
        Set(ByVal value)
            CHNro = value
        End Set
    End Property
    Public Property gNombreBeneficiario
        Get
            Return NombreBeneficiario
        End Get
        Set(ByVal value)
            NombreBeneficiario = value
        End Set
    End Property
    Public Property gMomentoContable
        Get
            Return MomentoContable
        End Get
        Set(ByVal value)
            MomentoContable = value
        End Set
    End Property
    Public Property gPeriodoAdeudado
        Get
            Return PeriodoAdeudado
        End Get
        Set(ByVal value)
            PeriodoAdeudado = value
        End Set
    End Property
    Public Property gNroPago
        Get
            Return NroPago
        End Get
        Set(ByVal value)
            NroPago = value
        End Set
    End Property
    Public Property gDescripcionDeuda
        Get
            Return DescripcionDeuda
        End Get
        Set(ByVal value)
            DescripcionDeuda = value
        End Set
    End Property

    Public Property gFechaPago
        Get
            Return FechaPago
        End Get
        Set(ByVal value)
            FechaPago = value
        End Set
    End Property
    Public Property gCCFechaPago
        Get
            Return CCFechaPago
        End Get
        Set(ByVal value)
            CCFechaPago = value
        End Set
    End Property
    Public Property gCHFechaCobro
        Get
            Return CHFechaCobro
        End Get
        Set(ByVal value)
            CHFechaCobro = value
        End Set
    End Property
    Public Property gImporteAdeudado
        Get
            Return ImporteAdeudado
        End Get
        Set(ByVal value)
            ImporteAdeudado = value
        End Set
    End Property
    Public Property gCCImporteAdeudado
        Get
            Return CCImporteAdeudado
        End Get
        Set(ByVal value)
            CCImporteAdeudado = value
        End Set
    End Property
    Public Property gCHImporteCheque
        Get
            Return CHImporteCheque
        End Get
        Set(ByVal value)
            CHImporteCheque = value
        End Set
    End Property
   

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal FormularioNro As String, ByVal Boleto As String, ByVal NroTomo As Integer, ByVal Gestion As Integer, ByVal CCNro As Integer, ByVal CHNro As Integer, ByVal NombreBeneficiario As String, ByVal MomentoContable As String, ByVal PeriodoAdeudado As String, ByVal NroPago As String, ByVal DescripcionDeuda As String,
                    ByVal FechaPago As Date, ByVal CCFechaPago As Date, ByVal CHFechaCobro As Date,
                    ByVal ImporteAdeudado As Decimal, ByVal CCImporteAdeudado As Decimal, ByVal CHImporteCheque As Decimal)

        gid = id
        gFormularioNro = FormularioNro
        gBoleto = Boleto
        gNroTomo = NroTomo
        gGestion = gGestion
        gCCNro = gCCNro
        gCHNro = CHNro
        gNombreBeneficiario = NombreBeneficiario
        gMomentoContable = MomentoContable
        gPeriodoAdeudado = PeriodoAdeudado
        gNroPago = NroPago
        gDescripcionDeuda = DescripcionDeuda
        gFechaPago = FechaPago
        gCCFechaPago = CCFechaPago
        gCHFechaCobro = CHFechaCobro
        gImporteAdeudado = ImporteAdeudado
        gCCImporteAdeudado = CCImporteAdeudado
        gCHImporteCheque = CHImporteCheque



    End Sub
End Class
