Imports MySqlConnector
Public Class Form1
    Private dt As DataTable = New DataTable("Operaciones")
    Private ds As New DataSet
    Private dr As DataRow
    Private reader As MySqlDataReader
    Private adp As MySqlDataAdapter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarOperaciones()
    End Sub

    Private Sub pnlPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pnlPrincipal.SelectedIndexChanged

        ' Se recargan los datos al momento de cambiar de TAB
        Select Case pnlPrincipal.SelectedIndex
            Case 0 ' Operaciones
                LlenarOperaciones()
            Case 1 ' Clientes
                LlenarClientes()
            Case 2 ' Vehículo
                LlenarVehiculos()

        End Select

    End Sub

    Private Sub LlenarOperaciones()
        Dim o As TOperacion = New TOperacion()
        o.Conectarse()
        adp = o.Consultar()
        If Not ds.Tables.Contains("operaciones") Then
            ds.Tables.Add("operaciones")
        Else
            ds.Tables("operaciones").Clear()
        End If
        adp.Fill(ds.Tables("operaciones"))
        dgvOperaciones.DataSource = ds.Tables("operaciones")
        dgvOperaciones.Columns(0).Visible = False
        dgvOperaciones.Columns(3).Visible = False
        dgvOperaciones.Columns(4).Visible = False
        pckfecha.Value = Now
        'Datos de los Clientes
        dt.Clear()
        dt = New DataTable("Clientes")
        dt.Columns.Add("Codigo")
        dt.Columns.Add("FullName")
        Dim c As TCliente = New TCliente()
        c.Conectarse()
        reader = c.Consultar()
        While reader.Read()
            dr = dt.NewRow()
            dr(0) = reader(0)
            dr(1) = reader(1)
            dt.Rows.Add(dr)
        End While
        LstOperClientes.DataSource = dt
        LstOperClientes.ValueMember = "Codigo"
        LstOperClientes.DisplayMember = "FullName"
        LstOperClientes.SelectedIndex = -1
        'Datos de los Vehículos
        dt = New DataTable("vehiculo")
        dt.Columns.Add("Codigo")
        dt.Columns.Add("Datos")
        Dim v As TVehiculo = New TVehiculo()
        v.Conectarse()
        reader = v.Consultar()
        While reader.Read()
            dr = dt.NewRow()
            dr(0) = reader(0)
            dr(1) = reader(1)
            dt.Rows.Add(dr)
        End While
        lstOperVehiculo.DataSource = dt
        lstOperVehiculo.ValueMember = "Codigo"
        lstOperVehiculo.DisplayMember = "Datos"
        lstOperVehiculo.SelectedIndex = -1
    End Sub

    Private Sub LlenarVehiculos()
        dt.Clear()
        dt = New DataTable("vehiculo")
        dt.Columns.Add("Codigo")
        dt.Columns.Add("Datos")
        dt.Columns.Add("nombre_modelo")
        dt.Columns.Add("Dominio")

        Dim v As TVehiculo = New TVehiculo()
        v.Conectarse()
        reader = v.Consultar()
        While reader.Read()
            dr = dt.NewRow()
            dr(0) = reader(0)
            dr(1) = reader(1)
            dr(2) = reader(2)
            dr(3) = reader(3)
            dt.Rows.Add(dr)
        End While

        lstVehiculos.DataSource = dt
        lstVehiculos.ValueMember = "Codigo"
        lstVehiculos.DisplayMember = "Datos"
        lstVehiculos.SelectedIndex = -1
        txtVehiculoModelo.Clear()
        txtVehiculoDominio.Clear()
    End Sub

    Private Sub LlenarClientes()
        dt.Clear()
        dt = New DataTable("Clientes")
        dt.Columns.Add("Codigo")
        dt.Columns.Add("FullName")
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Apellido")
        dt.Columns.Add("Domicilio")
        Dim c As TCliente = New TCliente()
        c.Conectarse()
        reader = c.Consultar()
        While reader.Read()
            dr = dt.NewRow()
            dr(0) = reader(0)
            dr(1) = reader(1)
            dr(2) = reader(2)
            dr(3) = reader(3)
            dr(4) = reader(4)
            dt.Rows.Add(dr)
        End While

        lstClientes.DataSource = dt
        lstClientes.ValueMember = "Codigo"
        lstClientes.DisplayMember = "FullName"
        lstClientes.SelectedIndex = -1
        txtClienteNombre.Clear()
        txtClienteApellido.Clear()
        txtClienteDomicilio.Clear()

    End Sub

    Private Sub cmdClienteSave_Click(sender As Object, e As EventArgs) Handles cmdClienteSave.Click
        Dim c As TCliente = New TCliente()
        If txtClienteApellido.Text.Trim() = "" Then
            MsgBox("El Apellido del Cliente es Requerido")
            txtClienteApellido.SelectAll()
            Exit Sub
        ElseIf txtClienteNombre.Text.Trim() = "" Then
            MsgBox("El Nombre del Cliente es Requerido")
            txtClienteNombre.SelectAll()
            Exit Sub
        ElseIf txtClienteDomicilio.Text.Trim() = "" Then
            MsgBox("El Domicilio del Cliente es Requerido")
            txtClienteDomicilio.SelectAll()
            Exit Sub
        Else
            c.Conectarse()
            If (c.Guardar(txtClienteApellido.Text, txtClienteNombre.Text, txtClienteDomicilio.Text) > 0) Then
                LlenarClientes()
                txtClienteNombre.Clear()
                txtClienteApellido.Clear()
                txtClienteDomicilio.Clear()
                lstClientes.SelectedIndex = -1
                MsgBox("El Cliente fue Agregado con Éxito", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Se produce un error al guardar en la Base de Datos", MsgBoxStyle.Critical)
            End If
            c.Cerrar()
        End If
    End Sub

    Private Sub cmdVehiculoSave_Click(sender As Object, e As EventArgs) Handles cmdVehiculoSave.Click
        Dim v As TVehiculo = New TVehiculo()
        If txtVehiculoModelo.Text.Trim() = "" Then
            MsgBox("El Modelo es Requerido")
            txtVehiculoModelo.SelectAll()
            Exit Sub
        ElseIf txtVehiculoDominio.Text.Trim() = "" Then
            MsgBox("El Dominio es Requerido")
            txtVehiculoDominio.SelectAll()
            Exit Sub
        Else
            v.Conectarse()
            If (v.Guardar(txtVehiculoModelo.Text, txtVehiculoDominio.Text) > 0) Then
                LlenarVehiculos()
                txtVehiculoModelo.Clear()
                txtVehiculoDominio.Clear()

                MsgBox("El Vehículo fue Agregado con Éxito", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Se produce un error al guardar en la Base de Datos", MsgBoxStyle.Critical)
            End If
            v.Cerrar()
        End If
    End Sub

    Private Sub cmdOperSave_Click(sender As Object, e As EventArgs) Handles cmdOperSave.Click
        Dim o As TOperacion = New TOperacion()
        If LstOperClientes.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar un Cliente")
            Exit Sub
        ElseIf lstOperVehiculo.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar un Vehículo")
            Exit Sub
        Else
            o.Conectarse()
            If (o.Guardar(LstOperClientes.SelectedValue, lstOperVehiculo.SelectedValue, pckfecha.Value) > 0) Then
                LlenarClientes()
                LlenarVehiculos()
                LlenarOperaciones()
                LstOperClientes.SelectedIndex = -1
                lstOperVehiculo.SelectedIndex = -1
                pckfecha.Value = Date.Now()
                MsgBox("La Operación fue Agregada con Éxito", MsgBoxStyle.Exclamation)

            Else
                MsgBox("Se produce un error al guardar en la Base de Datos", MsgBoxStyle.Critical)
            End If
            o.Cerrar()
        End If
    End Sub

    Private Sub dgvOperaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOperaciones.CellClick
        LstOperClientes.SelectedValue = dgvOperaciones.CurrentRow.Cells(3).Value
        lstOperVehiculo.SelectedValue = dgvOperaciones.CurrentRow.Cells(4).Value
        pckfecha.Value = dgvOperaciones.CurrentRow.Cells(5).Value
    End Sub

    Private Sub lstVehiculos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstVehiculos.SelectedIndexChanged
        If lstVehiculos.SelectedIndex >= 0 Then
            txtVehiculoModelo.Text = lstVehiculos.SelectedItem.Row.ItemArray(2)
            txtVehiculoDominio.Text = lstVehiculos.SelectedItem.Row.ItemArray(3)
        End If
    End Sub

    Private Sub lstClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstClientes.SelectedIndexChanged
        If lstClientes.SelectedIndex >= 0 Then
            txtClienteNombre.Text = lstClientes.SelectedItem.Row.ItemArray(2)
            txtClienteApellido.Text = lstClientes.SelectedItem.Row.ItemArray(3)
            txtClienteDomicilio.Text = lstClientes.SelectedItem.Row.ItemArray(4)
        End If
    End Sub

    Private Sub cmdOperEdit_Click(sender As Object, e As EventArgs) Handles cmdOperEdit.Click
        Dim o As TOperacion = New TOperacion()
        If LstOperClientes.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar un Cliente")
            Exit Sub
        ElseIf lstOperVehiculo.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar un Vehículo")
            Exit Sub
        Else
            o.Conectarse()
            If (o.Modificar(dgvOperaciones.CurrentRow.Cells(0).Value, LstOperClientes.SelectedValue, lstOperVehiculo.SelectedValue, pckfecha.Value) > 0) Then
                LlenarClientes()
                LlenarVehiculos()
                LlenarOperaciones()
                LstOperClientes.SelectedIndex = -1
                lstOperVehiculo.SelectedIndex = -1
                pckfecha.Value = Date.Now()
                MsgBox("La Operación fue Modificada con Éxito", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Se produce un error al guardar en la Base de Datos", MsgBoxStyle.Critical)
            End If
            o.Cerrar()
        End If
    End Sub

    Private Sub cmdClienteEdit_Click(sender As Object, e As EventArgs) Handles cmdClienteEdit.Click
        Dim c As TCliente = New TCliente()
        If txtClienteApellido.Text.Trim() = "" Then
            MsgBox("El Apellido del Cliente es Requerido")
            txtClienteApellido.SelectAll()
            Exit Sub
        ElseIf txtClienteNombre.Text.Trim() = "" Then
            MsgBox("El Nombre del Cliente es Requerido")
            txtClienteNombre.SelectAll()
            Exit Sub
        ElseIf txtClienteDomicilio.Text.Trim() = "" Then
            MsgBox("El Domicilio del Cliente es Requerido")
            txtClienteDomicilio.SelectAll()
            Exit Sub
        Else
            c.Conectarse()
            If (c.Modificar(lstClientes.SelectedItem.Row.ItemArray(0), txtClienteApellido.Text, txtClienteNombre.Text, txtClienteDomicilio.Text) > 0) Then
                LlenarClientes()
                LstOperClientes.SelectedIndex = -1
                MsgBox("La Operación fue Modificada con Éxito", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Se produce un error al guardar en la Base de Datos", MsgBoxStyle.Critical)
            End If
            c.Cerrar()
        End If
    End Sub

    Private Sub cmdVehiculoEdit_Click(sender As Object, e As EventArgs) Handles cmdVehiculoEdit.Click
        Dim v As TVehiculo = New TVehiculo()
        If txtVehiculoModelo.Text.Trim() = "" Then
            MsgBox("El Modelo es Requerido")
            txtVehiculoModelo.SelectAll()
            Exit Sub
        ElseIf txtVehiculoDominio.Text.Trim() = "" Then
            MsgBox("El Dominio es Requerido")
            txtVehiculoDominio.SelectAll()
            Exit Sub
        Else
            v.Conectarse()
            If (v.Modificar(lstVehiculos.SelectedItem.Row.ItemArray(0), txtVehiculoModelo.Text, txtVehiculoDominio.Text) > 0) Then
                LlenarVehiculos()
                LstOperClientes.SelectedIndex = -1
                MsgBox("La Operación fue Modificada con Éxito", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Se produce un error al guardar en la Base de Datos", MsgBoxStyle.Critical)
            End If
            v.Cerrar()
        End If
    End Sub

    Private Sub cdmOperDel_Click(sender As Object, e As EventArgs) Handles cdmOperDel.Click
        Dim c As TCliente = New TCliente()
        If dgvOperaciones.CurrentRow.Cells(0).Value < 1 Then
            MsgBox("No ha seleccionado Operaciones para Borrar")
            Exit Sub
        Else
            If MsgBox("¿Quiere eliminar La Operación " & dgvOperaciones.CurrentRow.Cells(1).Value & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                c.Conectarse()
                If (c.Borrar(dgvOperaciones.CurrentRow.Cells(0).Value) > 0) Then
                    LlenarClientes()
                    lstClientes.SelectedIndex = -1
                    MsgBox("La Operación fue Eliminada", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Se produce un error al acceder en la Base de Datos", MsgBoxStyle.Critical)
                End If
                c.Cerrar()
            End If
        End If
    End Sub

    Private Sub cmdClienteDel_Click(sender As Object, e As EventArgs) Handles cmdClienteDel.Click
        Dim c As TCliente = New TCliente()
        If lstVehiculos.SelectedIndex < 0 Then
            MsgBox("No ha seleccionado Clientes para Borrar")
            Exit Sub
        Else
            If MsgBox("¿Quiere eliminar el Vehiculo " & lstVehiculos.SelectedItem.row.itemarray(1) & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                c.Conectarse()
                If (c.Borrar(lstClientes.SelectedItem.Row.ItemArray(0)) > 0) Then
                    LlenarClientes()
                    lstClientes.SelectedIndex = -1
                    MsgBox("La Operación fue Eliminada", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Se produce un error al acceder en la Base de Datos", MsgBoxStyle.Critical)
                End If
                c.Cerrar()
            End If
        End If
    End Sub

    Private Sub cmdVehiculoDel_Click(sender As Object, e As EventArgs) Handles cmdVehiculoDel.Click
        Dim v As TVehiculo = New TVehiculo()
        If lstVehiculos.SelectedIndex < 0 Then
            MsgBox("No ha seleccionado Vehículos para Borrar")
            Exit Sub
        Else
            If MsgBox("¿Quiere eliminar el Vehiculo " & lstVehiculos.SelectedItem.row.itemarray(1) & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                v.Conectarse()
                If (v.Borrar(lstVehiculos.SelectedItem.Row.ItemArray(0)) > 0) Then
                    LlenarVehiculos()
                    lstVehiculos.SelectedIndex = -1
                    MsgBox("La Operación fue Eliminada", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("Se produce un error al acceder en la Base de Datos", MsgBoxStyle.Critical)
                End If
                v.Cerrar()
            End If
        End If
    End Sub
End Class
