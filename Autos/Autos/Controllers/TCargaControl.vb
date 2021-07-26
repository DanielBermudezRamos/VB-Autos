Public Class TCargaControl
    Protected _col As String
    Protected _dt As DataTable = New DataTable
    Protected _ds As DataSet
    Protected _dr As DataRow
    Protected reader As MySqlConnector.MySqlDataReader

    Public Sub tabla(ByVal NombreTabla As String)
        _dt = New DataTable(NombreTabla)
    End Sub
    Public Sub AddColum(nombre As String)
        _dt.Columns.Add(nombre)
    End Sub
    Public Sub CargarControl(ByVal reader As MySqlConnector.MySqlDataReader)
        While reader.Read()
            _dr = _dt.NewRow()
            For I = 0 To _dr.ItemArray.Length - 1
                _dr(I) = reader(I)
            Next
            _dt.Rows.Add(_dr)
        End While
    End Sub
End Class
