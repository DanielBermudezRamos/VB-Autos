Public Class ClassOperacion
    Private _codigo As String
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Private _codCliente As String
    Public Property Cod_Cliente() As String
        Get
            Return _codCliente
        End Get
        Set(ByVal value As String)
            _codCliente = value
        End Set
    End Property

    Private codVehiculo As String
    Public Property Cod_Vehiculo() As String
        Get
            Return codVehiculo
        End Get
        Set(ByVal value As String)
            codVehiculo = value
        End Set
    End Property

    Private _fechaAlta As String
    Public Property Fech_Alta() As String
        Get
            Return _fechaAlta
        End Get
        Set(ByVal value As String)
            _fechaAlta = value
        End Set
    End Property
End Class
