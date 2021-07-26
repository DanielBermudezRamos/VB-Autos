Public Class TCtrlBox
    Inherits TCargaControl
    Protected _listBox As ListBox

    Public Sub New(ByVal NombreTabla As String)
        If _dt IsNot Nothing Then _dt.Clear()
        MyBase.tabla(NombreTabla)
    End Sub
    Public Function getTable() As DataTable
        Return _dt
    End Function
    Public Function getList(ByVal value As String, ByVal display As String) As ListBox
        _listBox.DataSource = getTable()
        _listBox.ValueMember = value
        _listBox.DisplayMember = display
        Return _listBox
    End Function
End Class
