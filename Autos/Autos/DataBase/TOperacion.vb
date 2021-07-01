Imports MySqlConnector
Public Class TOperacion
    Inherits TDataBase
    Private _adp As MySqlDataAdapter
    Public Sub New()
        MyBase.New()
    End Sub

    Public Function Consultar()
        cmd.Connection = myConn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT o.codigo , CONCAT (c.nombre, '', c.apellido) as Cliente , 
                               v.nombre_modelo as Vehiculo ,
                               cod_cliente, cod_vehiculo, DATE_FORMAT(fecha_alta, '%d/%m/%Y') fecha_Alta
                               From Operaciones o 
                            Inner Join Clientes c ON o.cod_cliente = c.codigo 
                            Inner Join Vehiculos v On o.cod_vehiculo = v.codigo"
        Try
            _adp = New MySqlDataAdapter(cmd)
            Return _adp
        Catch ex As Exception
            Return DBNull.Value
        End Try
        ' your device ran into

    End Function

    Public Function Consultar(ByRef codigo As Integer)
        cmd = New MySqlCommand()
        cmd.Connection = myConn
        cmd.CommandType = CommandType.Text
        If codigo > 0 Then
            cmd.CommandText = "Select o.codigo , CONCAT(c.nombre, '', c.apellido) as Cliente , 
                               v.nombre_modelo As Vehiculo ,
                               cod_cliente ,cod_vehiculo ,fecha_alta 
                               FROM Operaciones o 
                               Inner join Clientes c ON o.cod_cliente = c.codigo 
                               Inner Join Vehiculos v On o.cod_vehiculo = v.codigo WHERE o.codigo = " + codigo.ToString()
        Else
            cmd.CommandText = "SELECT o.codigo , CONCAT (c.nombre, '', c.apellido) as Cliente , 
                               v.nombre_modelo as Vehiculo ,
                               cod_cliente ,cod_vehiculo ,fecha_alta 
                               FROM Operaciones o 
                               Inner join Clientes c ON o.cod_cliente = c.codigo 
                               Inner Join Vehiculos v On o.cod_vehiculo = v.codigo"
        End If
        Try
            _adp = New MySqlDataAdapter(cmd)
            Return _adp
        Catch ex As Exception
            Return DBNull.Value
        End Try
    End Function

    Public Function Guardar(ByVal cliente As Integer, ByVal vehiculo As Integer, ByVal fecha As String) As Integer
        cmd.Connection = myConn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO Operaciones (cod_cliente, cod_vehiculo, fecha_alta) 
                           VALUES(" & cliente.ToString() & ", " & vehiculo.ToString() & ", STR_TO_DATE('" & fecha & "', '%d/%m/%Y'))"
        Try
            Dim resultado As Integer = cmd.ExecuteNonQuery()
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical)
            Return 0
        End Try
    End Function
    Public Function Modificar(ByVal codigo As String, ByVal cliente As Integer, ByVal vehiculo As Integer, ByVal fecha As String) As Integer
        cmd.Connection = myConn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "UPDATE Operaciones SET 
                            cod_cliente = " & cliente.ToString() & ", 
                            cod_vehiculo = " & vehiculo.ToString() & ", 
                            fecha_alta = STR_TO_DATE('" & fecha & "', '%d/%m/%Y')
                           WHERE codigo = " & codigo
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
        cmd.CommandText = "DELETE FROM Operaciones WHERE codigo = " & codigo
        Try
            Dim resultado As Integer = cmd.ExecuteNonQuery()
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical)
            Return 0
        End Try
    End Function

End Class
