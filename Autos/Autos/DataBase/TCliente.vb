
Public Class TCliente
    Inherits TDataBase
    Public Sub New()
        MyBase.New()
    End Sub

    Public Function Consultar()
        cmd.Connection = myConn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT codigo, CONCAT (Nombre, ' ', Apellido) As FullName, Nombre, Apellido, Domicilio FROM clientes"
        Try
            reader = cmd.ExecuteReader()
            Return reader
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical)
        End Try
    End Function

    Public Function Consultar(ByRef codigo As Integer)
        cmd.Connection = myConn
        cmd.CommandType = CommandType.Text
        If codigo > 0 Then
            cmd.CommandText = "SELECT codigo, CONCAT (Nombre, ' ', Apellido) As FullName, Nombre, Apellido, Domicilio FROM clientes WHERE codigo = " + codigo.ToString()
        Else
            cmd.CommandText = "SELECT codigo, CONCAT (Nombre, ' ', Apellido) As FullName, Nombre, Apellido, Domicilio FROM clientes"
        End If
        Try
            reader = cmd.ExecuteReader()
            Return reader
        Catch ex As Exception

        End Try
    End Function

    Public Function Guardar(ByVal apellido As String, ByVal nombre As String, ByVal domicilio As String) As Integer
        cmd.Connection = myConn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO Clientes(nombre, apellido, domicilio) Values('" & nombre & "', '" & apellido & "', '" & domicilio & "')"
        Try
            Dim resultado As Integer = cmd.ExecuteNonQuery()
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical)
            Return 0
        End Try
    End Function

    Public Function Modificar(ByVal codigo As Integer, ByVal apellido As String, ByVal nombre As String, ByVal domicilio As String) As Integer
        cmd.Connection = myConn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "UPDATE Clientes SET 
                            apellido = '" & apellido & "', 
                            nombre = '" & nombre & "', 
                            domicilio = '" & domicilio & "' 
                            WHERE codigo = " & codigo.ToString()
        Try
            Dim resultado As Integer = cmd.ExecuteNonQuery()
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical)
            Return 0
        End Try
    End Function

    Public Function Borrar(ByVal codigo As String) As Integer
        cmd.Connection = myConn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "DELETE FROM Clientes WHERE codigo = " & codigo
        Try
            Dim resultado As Integer = cmd.ExecuteNonQuery()
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical)
            Return 0
        End Try
    End Function

End Class
