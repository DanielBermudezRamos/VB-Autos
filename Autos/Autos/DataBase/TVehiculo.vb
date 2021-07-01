Public Class TVehiculo
    Inherits TDataBase

    Public Sub New()
        MyBase.New()
    End Sub

    Public Function Consultar()
        cmd.Connection = myConn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT codigo, CONCAT(nombre_modelo, ' (', dominio, ')' ) as Datos, nombre_modelo, dominio FROM Vehiculos"
        Try
            reader = cmd.ExecuteReader()
            Return reader
        Catch ex As Exception
            Return DBNull.Value
        End Try
        ' your device ran into

    End Function

    Public Function Consultar(ByRef codigo As Integer)
        cmd.Connection = myConn
        cmd.CommandType = CommandType.Text
        If codigo > 0 Then
            cmd.CommandText = "SELECT codigo, CONCAT(nombre_modelo, ' (', dominio, ')' ) as Datos, nombre_modelo, dominio FROM Vehiculos WHERE codigo = " + codigo.ToString()
        Else
            cmd.CommandText = "SELECT codigo, CONCAT(nombre_modelo, ' (', dominio, ')' ) as Datos, nombre_modelo, dominio FROM Vehiculos"
        End If
        Try
            reader = cmd.ExecuteReader()
            Return reader
        Catch ex As Exception
            Return DBNull.Value
        End Try
    End Function

    Public Function Guardar(ByVal modelo As String, ByVal dominio As String) As Integer
        cmd.Connection = myConn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO Vehiculos (nombre_modelo, dominio) VALUES ('" & modelo & "', '" & dominio & "')"
        Try
            Dim resultado As Integer = cmd.ExecuteNonQuery()
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical)
            Return 0
        End Try
    End Function

    Public Function Modificar(ByVal codigo As Integer, ByVal modelo As String, ByVal dominio As String) As Integer
        cmd.Connection = myConn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "UPDATE Vehiculos SET 
                            nombre_modelo = '" & modelo & "', 
                            dominio = '" & dominio & "' 
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
        cmd.CommandText = "DELETE FROM Vehiculos WHERE codigo = " & codigo
        Try
            Dim resultado As Integer = cmd.ExecuteNonQuery()
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical)
            Return 0
        End Try
    End Function
End Class
