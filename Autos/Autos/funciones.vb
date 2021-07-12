Imports System.Windows.Forms

Module funciones
    Public cadenaConexion As String = "datasource=localhost;Initial Catalog=autosdb;port=3306;username=root;password=IdBp*2017"

    Public OperSelect As Integer = 0
    Public Enum OperTipo As Integer
        oper
        cliente
        auto
    End Enum

    Public Sub soloLetras(ByRef e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Public Sub soloNumeros(ByRef e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Module
