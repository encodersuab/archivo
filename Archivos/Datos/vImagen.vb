Public Class vImagen
    Dim Id, IdRegistro As Integer
    Dim CCNro, Descripcion As String
    Dim Imagen() As Byte


    Public Property gid
        Get
            Return id
        End Get
        Set(ByVal value)
            id = value
        End Set
    End Property
    Public Property gIdRegistro
        Get
            Return IdRegistro
        End Get
        Set(ByVal value)
            IdRegistro = value
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
    Public Property gDescripcion
        Get
            Return Descripcion
        End Get
        Set(ByVal value)
            Descripcion = value
        End Set
    End Property


   
    Public Property gImagen
        Get
            Return Imagen
        End Get
        Set(ByVal value)
            Imagen = value
        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal IdRegistro As String, ByVal CCNro As String, Descripcion As String, ByVal Imagen As Byte)

        gid = id
        gIdRegistro = IdRegistro
        gCCNro = CCNro
        gDescripcion = Descripcion
        gImagen = Imagen


    End Sub
End Class
