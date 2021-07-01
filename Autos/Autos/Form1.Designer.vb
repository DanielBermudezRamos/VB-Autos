<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlPrincipal = New System.Windows.Forms.TabControl()
        Me.tabOperaciones = New System.Windows.Forms.TabPage()
        Me.cmdOperSave = New System.Windows.Forms.Button()
        Me.dgvOperaciones = New System.Windows.Forms.DataGridView()
        Me.lstOperVehiculo = New System.Windows.Forms.ComboBox()
        Me.LstOperClientes = New System.Windows.Forms.ComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblOperacionesVehiculo = New System.Windows.Forms.Label()
        Me.lblOperacionesFecha = New System.Windows.Forms.Label()
        Me.pckfecha = New System.Windows.Forms.DateTimePicker()
        Me.cdmOperDel = New System.Windows.Forms.Button()
        Me.cmdOperEdit = New System.Windows.Forms.Button()
        Me.tabClientes = New System.Windows.Forms.TabPage()
        Me.cmdClienteSave = New System.Windows.Forms.Button()
        Me.cmdClienteDel = New System.Windows.Forms.Button()
        Me.cmdClienteEdit = New System.Windows.Forms.Button()
        Me.txtClienteDomicilio = New System.Windows.Forms.TextBox()
        Me.txtClienteApellido = New System.Windows.Forms.TextBox()
        Me.lblClienteDomicilio = New System.Windows.Forms.Label()
        Me.lblClienteApellido = New System.Windows.Forms.Label()
        Me.txtClienteNombre = New System.Windows.Forms.TextBox()
        Me.lblClienteNombre = New System.Windows.Forms.Label()
        Me.lstClientes = New System.Windows.Forms.ListBox()
        Me.tabVehiculos = New System.Windows.Forms.TabPage()
        Me.cmdVehiculoDel = New System.Windows.Forms.Button()
        Me.cmdVehiculoEdit = New System.Windows.Forms.Button()
        Me.cmdVehiculoSave = New System.Windows.Forms.Button()
        Me.txtVehiculoDominio = New System.Windows.Forms.TextBox()
        Me.txtVehiculoModelo = New System.Windows.Forms.TextBox()
        Me.lblVehiculoDominio = New System.Windows.Forms.Label()
        Me.lblVehiculoModelo = New System.Windows.Forms.Label()
        Me.lstVehiculos = New System.Windows.Forms.ListBox()
        Me.pnlPrincipal.SuspendLayout()
        Me.tabOperaciones.SuspendLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabClientes.SuspendLayout()
        Me.tabVehiculos.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.tabOperaciones)
        Me.pnlPrincipal.Controls.Add(Me.tabClientes)
        Me.pnlPrincipal.Controls.Add(Me.tabVehiculos)
        Me.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.pnlPrincipal.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.SelectedIndex = 0
        Me.pnlPrincipal.Size = New System.Drawing.Size(528, 554)
        Me.pnlPrincipal.TabIndex = 0
        '
        'tabOperaciones
        '
        Me.tabOperaciones.Controls.Add(Me.cmdOperSave)
        Me.tabOperaciones.Controls.Add(Me.dgvOperaciones)
        Me.tabOperaciones.Controls.Add(Me.lstOperVehiculo)
        Me.tabOperaciones.Controls.Add(Me.LstOperClientes)
        Me.tabOperaciones.Controls.Add(Me.lblCliente)
        Me.tabOperaciones.Controls.Add(Me.lblOperacionesVehiculo)
        Me.tabOperaciones.Controls.Add(Me.lblOperacionesFecha)
        Me.tabOperaciones.Controls.Add(Me.pckfecha)
        Me.tabOperaciones.Controls.Add(Me.cdmOperDel)
        Me.tabOperaciones.Controls.Add(Me.cmdOperEdit)
        Me.tabOperaciones.Location = New System.Drawing.Point(4, 25)
        Me.tabOperaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.tabOperaciones.Name = "tabOperaciones"
        Me.tabOperaciones.Padding = New System.Windows.Forms.Padding(4)
        Me.tabOperaciones.Size = New System.Drawing.Size(520, 525)
        Me.tabOperaciones.TabIndex = 0
        Me.tabOperaciones.Text = "Operaciones"
        Me.tabOperaciones.UseVisualStyleBackColor = True
        '
        'cmdOperSave
        '
        Me.cmdOperSave.Location = New System.Drawing.Point(420, 60)
        Me.cmdOperSave.Name = "cmdOperSave"
        Me.cmdOperSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdOperSave.TabIndex = 0
        Me.cmdOperSave.Text = "Guardar"
        Me.cmdOperSave.UseVisualStyleBackColor = True
        '
        'dgvOperaciones
        '
        Me.dgvOperaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOperaciones.Location = New System.Drawing.Point(11, 120)
        Me.dgvOperaciones.MultiSelect = False
        Me.dgvOperaciones.Name = "dgvOperaciones"
        Me.dgvOperaciones.ReadOnly = True
        Me.dgvOperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOperaciones.Size = New System.Drawing.Size(403, 182)
        Me.dgvOperaciones.TabIndex = 17
        Me.dgvOperaciones.TabStop = False
        '
        'lstOperVehiculo
        '
        Me.lstOperVehiculo.FormattingEnabled = True
        Me.lstOperVehiculo.Location = New System.Drawing.Point(118, 60)
        Me.lstOperVehiculo.Name = "lstOperVehiculo"
        Me.lstOperVehiculo.Size = New System.Drawing.Size(296, 24)
        Me.lstOperVehiculo.TabIndex = 10
        '
        'LstOperClientes
        '
        Me.LstOperClientes.FormattingEnabled = True
        Me.LstOperClientes.Location = New System.Drawing.Point(118, 30)
        Me.LstOperClientes.Name = "LstOperClientes"
        Me.LstOperClientes.Size = New System.Drawing.Size(296, 24)
        Me.LstOperClientes.TabIndex = 9
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(8, 33)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(55, 17)
        Me.lblCliente.TabIndex = 6
        Me.lblCliente.Text = "Cliente:"
        '
        'lblOperacionesVehiculo
        '
        Me.lblOperacionesVehiculo.AutoSize = True
        Me.lblOperacionesVehiculo.Location = New System.Drawing.Point(5, 63)
        Me.lblOperacionesVehiculo.Name = "lblOperacionesVehiculo"
        Me.lblOperacionesVehiculo.Size = New System.Drawing.Size(66, 17)
        Me.lblOperacionesVehiculo.TabIndex = 5
        Me.lblOperacionesVehiculo.Text = "Vehículo:"
        '
        'lblOperacionesFecha
        '
        Me.lblOperacionesFecha.AutoSize = True
        Me.lblOperacionesFecha.Location = New System.Drawing.Point(8, 96)
        Me.lblOperacionesFecha.Name = "lblOperacionesFecha"
        Me.lblOperacionesFecha.Size = New System.Drawing.Size(99, 17)
        Me.lblOperacionesFecha.TabIndex = 4
        Me.lblOperacionesFecha.Text = "Fecha de Alta:"
        '
        'pckfecha
        '
        Me.pckfecha.Checked = False
        Me.pckfecha.Location = New System.Drawing.Point(118, 91)
        Me.pckfecha.Name = "pckfecha"
        Me.pckfecha.ShowCheckBox = True
        Me.pckfecha.Size = New System.Drawing.Size(296, 23)
        Me.pckfecha.TabIndex = 11
        Me.pckfecha.Value = New Date(2021, 6, 15, 12, 44, 35, 0)
        '
        'cdmOperDel
        '
        Me.cdmOperDel.Location = New System.Drawing.Point(420, 189)
        Me.cdmOperDel.Name = "cdmOperDel"
        Me.cdmOperDel.Size = New System.Drawing.Size(75, 25)
        Me.cdmOperDel.TabIndex = 2
        Me.cdmOperDel.Text = "Eliminar"
        Me.cdmOperDel.UseVisualStyleBackColor = True
        '
        'cmdOperEdit
        '
        Me.cmdOperEdit.Location = New System.Drawing.Point(420, 160)
        Me.cmdOperEdit.Name = "cmdOperEdit"
        Me.cmdOperEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdOperEdit.TabIndex = 1
        Me.cmdOperEdit.Text = "Editar"
        Me.cmdOperEdit.UseVisualStyleBackColor = True
        '
        'tabClientes
        '
        Me.tabClientes.Controls.Add(Me.cmdClienteSave)
        Me.tabClientes.Controls.Add(Me.cmdClienteDel)
        Me.tabClientes.Controls.Add(Me.cmdClienteEdit)
        Me.tabClientes.Controls.Add(Me.txtClienteDomicilio)
        Me.tabClientes.Controls.Add(Me.txtClienteApellido)
        Me.tabClientes.Controls.Add(Me.lblClienteDomicilio)
        Me.tabClientes.Controls.Add(Me.lblClienteApellido)
        Me.tabClientes.Controls.Add(Me.txtClienteNombre)
        Me.tabClientes.Controls.Add(Me.lblClienteNombre)
        Me.tabClientes.Controls.Add(Me.lstClientes)
        Me.tabClientes.Location = New System.Drawing.Point(4, 25)
        Me.tabClientes.Name = "tabClientes"
        Me.tabClientes.Size = New System.Drawing.Size(520, 525)
        Me.tabClientes.TabIndex = 2
        Me.tabClientes.Text = "Clientes"
        Me.tabClientes.UseVisualStyleBackColor = True
        '
        'cmdClienteSave
        '
        Me.cmdClienteSave.Location = New System.Drawing.Point(327, 65)
        Me.cmdClienteSave.Name = "cmdClienteSave"
        Me.cmdClienteSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdClienteSave.TabIndex = 3
        Me.cmdClienteSave.Text = "Guardar"
        Me.cmdClienteSave.UseVisualStyleBackColor = True
        '
        'cmdClienteDel
        '
        Me.cmdClienteDel.Location = New System.Drawing.Point(327, 179)
        Me.cmdClienteDel.Name = "cmdClienteDel"
        Me.cmdClienteDel.Size = New System.Drawing.Size(75, 23)
        Me.cmdClienteDel.TabIndex = 5
        Me.cmdClienteDel.Text = "Eliminar"
        Me.cmdClienteDel.UseVisualStyleBackColor = True
        '
        'cmdClienteEdit
        '
        Me.cmdClienteEdit.Location = New System.Drawing.Point(327, 149)
        Me.cmdClienteEdit.Name = "cmdClienteEdit"
        Me.cmdClienteEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdClienteEdit.TabIndex = 4
        Me.cmdClienteEdit.Text = "Editar"
        Me.cmdClienteEdit.UseVisualStyleBackColor = True
        '
        'txtClienteDomicilio
        '
        Me.txtClienteDomicilio.Location = New System.Drawing.Point(81, 105)
        Me.txtClienteDomicilio.Name = "txtClienteDomicilio"
        Me.txtClienteDomicilio.Size = New System.Drawing.Size(239, 23)
        Me.txtClienteDomicilio.TabIndex = 14
        '
        'txtClienteApellido
        '
        Me.txtClienteApellido.Location = New System.Drawing.Point(81, 68)
        Me.txtClienteApellido.Name = "txtClienteApellido"
        Me.txtClienteApellido.Size = New System.Drawing.Size(239, 23)
        Me.txtClienteApellido.TabIndex = 13
        '
        'lblClienteDomicilio
        '
        Me.lblClienteDomicilio.AutoSize = True
        Me.lblClienteDomicilio.Location = New System.Drawing.Point(7, 105)
        Me.lblClienteDomicilio.Name = "lblClienteDomicilio"
        Me.lblClienteDomicilio.Size = New System.Drawing.Size(68, 17)
        Me.lblClienteDomicilio.TabIndex = 4
        Me.lblClienteDomicilio.Text = "Domicilio:"
        '
        'lblClienteApellido
        '
        Me.lblClienteApellido.AutoSize = True
        Me.lblClienteApellido.Location = New System.Drawing.Point(8, 68)
        Me.lblClienteApellido.Name = "lblClienteApellido"
        Me.lblClienteApellido.Size = New System.Drawing.Size(62, 17)
        Me.lblClienteApellido.TabIndex = 3
        Me.lblClienteApellido.Text = "Apellido:"
        '
        'txtClienteNombre
        '
        Me.txtClienteNombre.Location = New System.Drawing.Point(81, 28)
        Me.txtClienteNombre.Name = "txtClienteNombre"
        Me.txtClienteNombre.Size = New System.Drawing.Size(239, 23)
        Me.txtClienteNombre.TabIndex = 12
        '
        'lblClienteNombre
        '
        Me.lblClienteNombre.AutoSize = True
        Me.lblClienteNombre.Location = New System.Drawing.Point(5, 31)
        Me.lblClienteNombre.Name = "lblClienteNombre"
        Me.lblClienteNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblClienteNombre.TabIndex = 1
        Me.lblClienteNombre.Text = "Nombre"
        '
        'lstClientes
        '
        Me.lstClientes.FormattingEnabled = True
        Me.lstClientes.ItemHeight = 16
        Me.lstClientes.Location = New System.Drawing.Point(8, 136)
        Me.lstClientes.Name = "lstClientes"
        Me.lstClientes.Size = New System.Drawing.Size(312, 84)
        Me.lstClientes.TabIndex = 18
        Me.lstClientes.TabStop = False
        '
        'tabVehiculos
        '
        Me.tabVehiculos.Controls.Add(Me.cmdVehiculoDel)
        Me.tabVehiculos.Controls.Add(Me.cmdVehiculoEdit)
        Me.tabVehiculos.Controls.Add(Me.cmdVehiculoSave)
        Me.tabVehiculos.Controls.Add(Me.txtVehiculoDominio)
        Me.tabVehiculos.Controls.Add(Me.txtVehiculoModelo)
        Me.tabVehiculos.Controls.Add(Me.lblVehiculoDominio)
        Me.tabVehiculos.Controls.Add(Me.lblVehiculoModelo)
        Me.tabVehiculos.Controls.Add(Me.lstVehiculos)
        Me.tabVehiculos.Location = New System.Drawing.Point(4, 25)
        Me.tabVehiculos.Margin = New System.Windows.Forms.Padding(4)
        Me.tabVehiculos.Name = "tabVehiculos"
        Me.tabVehiculos.Padding = New System.Windows.Forms.Padding(4)
        Me.tabVehiculos.Size = New System.Drawing.Size(520, 525)
        Me.tabVehiculos.TabIndex = 1
        Me.tabVehiculos.Text = "Vehículos"
        Me.tabVehiculos.UseVisualStyleBackColor = True
        '
        'cmdVehiculoDel
        '
        Me.cmdVehiculoDel.Location = New System.Drawing.Point(372, 208)
        Me.cmdVehiculoDel.Name = "cmdVehiculoDel"
        Me.cmdVehiculoDel.Size = New System.Drawing.Size(75, 23)
        Me.cmdVehiculoDel.TabIndex = 8
        Me.cmdVehiculoDel.Text = "Borrar"
        Me.cmdVehiculoDel.UseVisualStyleBackColor = True
        '
        'cmdVehiculoEdit
        '
        Me.cmdVehiculoEdit.Location = New System.Drawing.Point(372, 178)
        Me.cmdVehiculoEdit.Name = "cmdVehiculoEdit"
        Me.cmdVehiculoEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdVehiculoEdit.TabIndex = 7
        Me.cmdVehiculoEdit.Text = "Editar"
        Me.cmdVehiculoEdit.UseVisualStyleBackColor = True
        '
        'cmdVehiculoSave
        '
        Me.cmdVehiculoSave.Location = New System.Drawing.Point(372, 60)
        Me.cmdVehiculoSave.Name = "cmdVehiculoSave"
        Me.cmdVehiculoSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdVehiculoSave.TabIndex = 6
        Me.cmdVehiculoSave.Text = "Guardar"
        Me.cmdVehiculoSave.UseVisualStyleBackColor = True
        '
        'txtVehiculoDominio
        '
        Me.txtVehiculoDominio.Location = New System.Drawing.Point(138, 83)
        Me.txtVehiculoDominio.Name = "txtVehiculoDominio"
        Me.txtVehiculoDominio.Size = New System.Drawing.Size(179, 23)
        Me.txtVehiculoDominio.TabIndex = 16
        '
        'txtVehiculoModelo
        '
        Me.txtVehiculoModelo.Location = New System.Drawing.Point(138, 41)
        Me.txtVehiculoModelo.Name = "txtVehiculoModelo"
        Me.txtVehiculoModelo.Size = New System.Drawing.Size(179, 23)
        Me.txtVehiculoModelo.TabIndex = 15
        '
        'lblVehiculoDominio
        '
        Me.lblVehiculoDominio.AutoSize = True
        Me.lblVehiculoDominio.Location = New System.Drawing.Point(26, 86)
        Me.lblVehiculoDominio.Name = "lblVehiculoDominio"
        Me.lblVehiculoDominio.Size = New System.Drawing.Size(63, 17)
        Me.lblVehiculoDominio.TabIndex = 2
        Me.lblVehiculoDominio.Text = "Dominio:"
        '
        'lblVehiculoModelo
        '
        Me.lblVehiculoModelo.AutoSize = True
        Me.lblVehiculoModelo.Location = New System.Drawing.Point(26, 41)
        Me.lblVehiculoModelo.Name = "lblVehiculoModelo"
        Me.lblVehiculoModelo.Size = New System.Drawing.Size(58, 17)
        Me.lblVehiculoModelo.TabIndex = 1
        Me.lblVehiculoModelo.Text = "Modelo:"
        '
        'lstVehiculos
        '
        Me.lstVehiculos.FormattingEnabled = True
        Me.lstVehiculos.ItemHeight = 16
        Me.lstVehiculos.Location = New System.Drawing.Point(26, 178)
        Me.lstVehiculos.Name = "lstVehiculos"
        Me.lstVehiculos.Size = New System.Drawing.Size(291, 84)
        Me.lstVehiculos.TabIndex = 19
        Me.lstVehiculos.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 554)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Control de Créditos para Vehículos"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.tabOperaciones.ResumeLayout(False)
        Me.tabOperaciones.PerformLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabClientes.ResumeLayout(False)
        Me.tabClientes.PerformLayout()
        Me.tabVehiculos.ResumeLayout(False)
        Me.tabVehiculos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPrincipal As TabControl
    Friend WithEvents tabOperaciones As TabPage
    Friend WithEvents tabClientes As TabPage
    Friend WithEvents lstClientes As ListBox
    Friend WithEvents tabVehiculos As TabPage
    Friend WithEvents lstVehiculos As ListBox
    Friend WithEvents cdmOperDel As Button
    Friend WithEvents cmdOperEdit As Button
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblOperacionesVehiculo As Label
    Friend WithEvents lblOperacionesFecha As Label
    Friend WithEvents pckfecha As DateTimePicker
    Friend WithEvents txtClienteNombre As TextBox
    Friend WithEvents lblClienteNombre As Label
    Friend WithEvents cmdClienteDel As Button
    Friend WithEvents cmdClienteEdit As Button
    Friend WithEvents txtClienteDomicilio As TextBox
    Friend WithEvents txtClienteApellido As TextBox
    Friend WithEvents lblClienteDomicilio As Label
    Friend WithEvents lblClienteApellido As Label
    Friend WithEvents lstOperVehiculo As ComboBox
    Friend WithEvents LstOperClientes As ComboBox
    Friend WithEvents txtVehiculoDominio As TextBox
    Friend WithEvents txtVehiculoModelo As TextBox
    Friend WithEvents lblVehiculoDominio As Label
    Friend WithEvents lblVehiculoModelo As Label
    Friend WithEvents dgvOperaciones As DataGridView
    Friend WithEvents cmdClienteSave As Button
    Friend WithEvents cmdOperSave As Button
    Friend WithEvents cmdVehiculoDel As Button
    Friend WithEvents cmdVehiculoEdit As Button
    Friend WithEvents cmdVehiculoSave As Button
End Class
