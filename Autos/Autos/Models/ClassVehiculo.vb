Public Class ClassVehiculo
    Private _codigo As Integer
    Private _modelo As String
    Private _dominio As String

    Public Property Codigo() As Integer
        Get
            Return _codigo
        End Get
        Set(ByVal value As Integer)
            _codigo = value
        End Set
    End Property

    Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
        End Set
    End Property

    Public Property Dominio() As String
        Get
            Return _dominio
        End Get
        Set(ByVal value As String)
            _dominio = value
        End Set
    End Property

    Public Overloads Function ToString() As String
        Return _modelo + " (" + _dominio + ")"
    End Function
End Class
