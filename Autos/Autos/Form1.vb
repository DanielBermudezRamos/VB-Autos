'Imports MySqlConnector
Public Class Form1
    Private dt As DataTable = New DataTable("Operaciones")
    Private ds As New DataSet
    Private dr As DataRow
    Private reader As MySqlConnector.MySqlDataReader
    Private adp As MySqlConnector.MySqlDataAdapter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultarElementos()
        LlenarOperaciones()
        MostrarElementos(OperTipo.oper)
        'dgvOperaciones_CurrentCellChanged(sender, e)
    End Sub

    Private Sub LlenarOperaciones()
        Dim c As TCliente = New TCliente()
        Dim v As TVehiculo = New TVehiculo()
        Dim o As TOperacion = New TOperacion()
        'Datos de los Clientes
        dt.Clear()
        dt = New DataTable("Clientes")
        dt.Columns.Add("Codigo")
        dt.Columns.Add("FullName")
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
        'Datos de Operaciones
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
    End Sub

    Private Sub LlenarVehiculos()
        Dim DVehiculo = New TVehiculo()
        Dim LVehiculo = New TCtrlBox("vehiculo")

        LVehiculo.AddColum("Codigo")
        LVehiculo.AddColum("Datos")
        LVehiculo.AddColum("nombre_modelo")
        LVehiculo.AddColum("Dominio")
        DVehiculo.Conectarse()
        LVehiculo.CargarControl(DVehiculo.Consultar())
        'lstClientes.DataSource = LVehiculo.getTable()
        'lstClientes.ValueMember = "Codigo"
        'lstClientes.DisplayMember = "Datos"
        lstClientes = LVehiculo.getList("Codigo", "Datos")
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
    End Sub
    '' ocultarElementos
    ' Oculta todos los elementos antes de cambiar la configuración
    ' de datos para mostrar.
    Private Sub ocultarElementos()
        ' Ocultar dato 1
        lblCliente.Hide()
        lblCliente.Text = "" ' Cliente
        txtClienteNombre.Clear()
        txtClienteNombre.Hide()
        ' Ocultar dato 2
        lblOperacionesVehiculo.Hide()
        lblOperacionesVehiculo.Text = "" ' Vehículo
        txtClienteApellido.Clear()
        txtClienteApellido.Hide()
        ' Ocultar dato 3
        lblOperacionesFecha.Hide()
        lblOperacionesFecha.Text = "" ' Fecha de Alta
        txtClienteDomicilio.Clear()
        txtClienteDomicilio.Hide()
        pckfecha.Hide()
        pckfecha.Value = Now
        ' Ocultar lista de Clientes
        LstOperClientes.Hide()
        ' Ocultar lista de Vehículos
        lstOperVehiculo.Hide()
        ' Ocultar DataGridView
        dgvOperaciones.Hide()
        ' Ocultar listado
        lstClientes.Hide()
        ' Ocultar Botón Guardar
        cmdOperSave.Hide()
        cmdOperSave.Text = "" ' Guardar
        ' Ocultar Botón Editar
        cmdOperEdit.Hide()
        cmdOperEdit.Text = "" ' Editar
        ' Ocultar Botón Eliminar
        cmdOperDel.Hide()
        cmdOperDel.Text = "" ' Eliminar
    End Sub
    ' MostrarElementos
    ' depende del botón seleccionado, muestras los componentes adecuados ya cargados.
    Private Sub MostrarElementos(ByVal Tipo)
        Select Case Tipo
            Case OperTipo.oper
                ' Ocultar dato 1
                lblCliente.Text = "Cliente:"
                lblCliente.Show()
                LstOperClientes.SelectedIndex = -1
                LstOperClientes.Show()
                ' Ocultar dato 2
                lblOperacionesVehiculo.Text = "Vehículo:"
                lstOperVehiculo.Show()
                lstOperVehiculo.SelectedIndex = -1
                lblOperacionesVehiculo.Show()
                ' Ocultar dato 3
                lblOperacionesFecha.Text = "Fecha de Alta:"
                lblOperacionesFecha.Show()
                pckfecha.Value = Now
                pckfecha.Show()
                ' Ocultar lista de Clientes
                LstOperClientes.Show()
                ' Ocultar lista de Vehículos
                lstOperVehiculo.Show()
                ' Ocultar DataGridView
                'dgvOperaciones.ClearSelection()
                dgvOperaciones.Show()
                ' Ocultar Botón Guardar
                cmdOperSave.Show()
                cmdOperSave.Text = "Guardar"
            Case OperTipo.cliente
                ' Ocultar dato 1
                lblCliente.Text = "Nombre:" ' Cliente
                lblCliente.Show()
                txtClienteNombre.Clear()
                txtClienteNombre.Show()
                ' Ocultar dato 2
                lblOperacionesVehiculo.Text = "Apellido:" ' Vehículo
                lblOperacionesVehiculo.Show()
                txtClienteApellido.Clear()
                txtClienteApellido.Show()
                ' Ocultar dato 3
                lblOperacionesFecha.Text = "Domicilio:" ' Fecha de Alta
                lblOperacionesFecha.Show()
                txtClienteDomicilio.Clear()
                txtClienteDomicilio.Show()
                ' Mostrar listado de Clientes
                lstClientes.SelectedIndex = -1
                lstClientes.Show()
                ' Ocultar Botón Guardar
                cmdOperSave.Show()
                cmdOperSave.Text = "Guardar"
            Case OperTipo.auto
                ' Mostrar listado de Vehículos
                lstClientes.SelectedIndex = -1
                lstClientes.Show()
                ' Ocultar dato 1
                lblCliente.Text = "Modelo:"
                lblCliente.Show()
                txtClienteNombre.Clear()
                txtClienteNombre.Show()
                ' Ocultar dato 2
                lblOperacionesVehiculo.Text = "Dominio:"
                lblOperacionesVehiculo.Show()
                txtClienteApellido.Clear()
                txtClienteApellido.Show()
                ' Ocultar Botón Guardar
                cmdOperSave.Show()
                cmdOperSave.Text = "Guardar"
        End Select
        cmdOperEdit.Hide()
        cmdOperDel.Hide()
    End Sub

    Private Sub LimpiarCampos(ByVal Tipo)
        Select Case Tipo
            Case OperTipo.oper
                ' Ocultar dato 1
                txtClienteNombre.Clear()
                ' Ocultar dato 2
                txtClienteApellido.Clear()
                ' Ocultar dato 3
                pckfecha.Value = Now
                ' Ocultar lista de Clientes
                LstOperClientes.SelectedIndex = -1
                ' Ocultar lista de Vehículos
                lstOperVehiculo.SelectedIndex = -1
                ' Ocultar DataGridView
                dgvOperaciones.ClearSelection()
                ' Ocultar listado
                ' Ocultar Botón Guardar
                cmdOperSave.Show()
                cmdOperSave.Text = "Guardar"
                ' Ocultar Botón Editar
                cmdOperEdit.Hide()
                cmdOperEdit.Text = "" ' Editar
                ' Ocultar Botón Eliminar
                cmdOperDel.Hide()
                cmdOperDel.Text = "" ' Eliminar
            Case OperTipo.cliente
                ' Ocultar dato 1
                txtClienteNombre.Clear()
                ' Ocultar dato 2
                txtClienteApellido.Clear()
                ' Ocultar Botón Guardar
                cmdOperSave.Show()
                cmdOperSave.Text = "Guardar"
                ' Ocultar listado
                lstClientes.SelectedIndex = -1
                ' Ocultar Botón Editar
                cmdOperEdit.Hide()
                cmdOperEdit.Text = "" ' Editar
                ' Ocultar Botón Eliminar
                cmdOperDel.Hide()
                cmdOperDel.Text = "" ' Eliminar
            Case OperTipo.auto
                ' Ocultar dato 1
                txtClienteNombre.Clear()
                ' Ocultar dato 2
                txtClienteApellido.Clear()
                ' Ocultar dato 3
                txtClienteDomicilio.Clear()
                ' Ocultar listado
                lstClientes.SelectedIndex = -1
                ' Ocultar Botón Guardar
                cmdOperSave.Show()
                cmdOperSave.Text = "Guardar"
                ' Ocultar Botón Editar
                cmdOperEdit.Hide()
                cmdOperEdit.Text = "" ' Editar
                ' Ocultar Botón Eliminar
                cmdOperDel.Hide()
                cmdOperDel.Text = "" ' Eliminar
        End Select
    End Sub

    Private Sub cmdClienteSave_Click(sender As Object, e As EventArgs)
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

    Private Sub lstClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstClientes.SelectedIndexChanged
        If lstClientes.SelectedIndex >= 0 Then
            txtClienteNombre.Text = lstClientes.SelectedItem.Row.ItemArray(2)
            txtClienteApellido.Text = lstClientes.SelectedItem.Row.ItemArray(3)
            If txtClienteDomicilio.Visible Then
                txtClienteDomicilio.Text = lstClientes.SelectedItem.Row.ItemArray(4)
            End If
            'Mostrar botones de Edición
            cmdOperEdit.Show()
            cmdOperDel.Show()
            cmdOperEdit.Text = "Editar"
            cmdOperDel.Text = "Eliminar"
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

    Private Sub cmdClienteEdit_Click(sender As Object, e As EventArgs)
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

    Private Sub cmdOperDel_Click(sender As Object, e As EventArgs) Handles cmdOperDel.Click
        Dim c As TCliente = New TCliente()
        If dgvOperaciones.CurrentRow.Cells(0).Value < 1 Then
            'MsgBox("No ha seleccionado Operaciones para Borrar")
            'Exit Sub
            LimpiarCampos(OperSelect)
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

    Private Sub cmdOperaciones_Click(sender As Object, e As EventArgs) Handles cmdOperaciones.Click
        ocultarElementos()
        LlenarOperaciones()
        MostrarElementos(OperTipo.oper)
        'dgvOperaciones_CurrentCellChanged(sender, e)
    End Sub

    Private Sub cmdClientes_Click(sender As Object, e As EventArgs) Handles cmdClientes.Click
        ocultarElementos()
        LlenarClientes()
        MostrarElementos(OperTipo.cliente)
    End Sub

    Private Sub cmdVehiculos_Click(sender As Object, e As EventArgs) Handles cmdVehiculos.Click
        ocultarElementos()
        LlenarVehiculos()
        MostrarElementos(OperTipo.auto)
    End Sub

    Private Sub dgvOperaciones_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvOperaciones.CurrentCellChanged
        If dgvOperaciones.CurrentRow IsNot Nothing Then
            LstOperClientes.SelectedValue = dgvOperaciones.CurrentRow.Cells(3).Value
            lstOperVehiculo.SelectedValue = dgvOperaciones.CurrentRow.Cells(4).Value
            pckfecha.Value = dgvOperaciones.CurrentRow.Cells(5).Value
            'Mostrar botones de Edición
            cmdOperEdit.Show()
            cmdOperDel.Show()
            cmdOperEdit.Text = "Editar"
            cmdOperDel.Text = "Eliminar"
        End If
    End Sub
End Class
