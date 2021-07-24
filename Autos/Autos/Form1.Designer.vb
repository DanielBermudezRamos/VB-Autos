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
        Me.cmdOperSave = New System.Windows.Forms.Button()
        Me.cmdOperDel = New System.Windows.Forms.Button()
        Me.cmdOperEdit = New System.Windows.Forms.Button()
        Me.txtClienteDomicilio = New System.Windows.Forms.TextBox()
        Me.txtClienteApellido = New System.Windows.Forms.TextBox()
        Me.txtClienteNombre = New System.Windows.Forms.TextBox()
        Me.lstClientes = New System.Windows.Forms.ListBox()
        Me.contenedor = New System.Windows.Forms.SplitContainer()
        Me.cmdVehiculos = New System.Windows.Forms.Button()
        Me.cmdClientes = New System.Windows.Forms.Button()
        Me.cmdOperaciones = New System.Windows.Forms.Button()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblOperacionesVehiculo = New System.Windows.Forms.Label()
        Me.lblOperacionesFecha = New System.Windows.Forms.Label()
        Me.dgvOperaciones = New System.Windows.Forms.DataGridView()
        Me.lstOperVehiculo = New System.Windows.Forms.ComboBox()
        Me.LstOperClientes = New System.Windows.Forms.ComboBox()
        Me.pckfecha = New System.Windows.Forms.DateTimePicker()
        CType(Me.contenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contenedor.Panel1.SuspendLayout()
        Me.contenedor.Panel2.SuspendLayout()
        Me.contenedor.SuspendLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOperSave
        '
        Me.cmdOperSave.Location = New System.Drawing.Point(99, 8)
        Me.cmdOperSave.Name = "cmdOperSave"
        Me.cmdOperSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdOperSave.TabIndex = 0
        Me.cmdOperSave.Text = "Guardar"
        Me.cmdOperSave.UseVisualStyleBackColor = True
        '
        'cmdOperDel
        '
        Me.cmdOperDel.Location = New System.Drawing.Point(261, 7)
        Me.cmdOperDel.Name = "cmdOperDel"
        Me.cmdOperDel.Size = New System.Drawing.Size(75, 25)
        Me.cmdOperDel.TabIndex = 2
        Me.cmdOperDel.Text = "Eliminar"
        Me.cmdOperDel.UseVisualStyleBackColor = True
        '
        'cmdOperEdit
        '
        Me.cmdOperEdit.Location = New System.Drawing.Point(180, 8)
        Me.cmdOperEdit.Name = "cmdOperEdit"
        Me.cmdOperEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdOperEdit.TabIndex = 1
        Me.cmdOperEdit.Text = "Editar"
        Me.cmdOperEdit.UseVisualStyleBackColor = True
        '
        'txtClienteDomicilio
        '
        Me.txtClienteDomicilio.Location = New System.Drawing.Point(119, 103)
        Me.txtClienteDomicilio.Name = "txtClienteDomicilio"
        Me.txtClienteDomicilio.Size = New System.Drawing.Size(268, 23)
        Me.txtClienteDomicilio.TabIndex = 14
        '
        'txtClienteApellido
        '
        Me.txtClienteApellido.Location = New System.Drawing.Point(119, 73)
        Me.txtClienteApellido.Name = "txtClienteApellido"
        Me.txtClienteApellido.Size = New System.Drawing.Size(268, 23)
        Me.txtClienteApellido.TabIndex = 13
        '
        'txtClienteNombre
        '
        Me.txtClienteNombre.Location = New System.Drawing.Point(119, 43)
        Me.txtClienteNombre.Name = "txtClienteNombre"
        Me.txtClienteNombre.Size = New System.Drawing.Size(268, 23)
        Me.txtClienteNombre.TabIndex = 12
        '
        'lstClientes
        '
        Me.lstClientes.FormattingEnabled = True
        Me.lstClientes.ItemHeight = 16
        Me.lstClientes.Location = New System.Drawing.Point(12, 141)
        Me.lstClientes.Name = "lstClientes"
        Me.lstClientes.Size = New System.Drawing.Size(375, 132)
        Me.lstClientes.TabIndex = 18
        Me.lstClientes.TabStop = False
        '
        'contenedor
        '
        Me.contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contenedor.Location = New System.Drawing.Point(0, 0)
        Me.contenedor.Name = "contenedor"
        '
        'contenedor.Panel1
        '
        Me.contenedor.Panel1.Controls.Add(Me.cmdVehiculos)
        Me.contenedor.Panel1.Controls.Add(Me.cmdClientes)
        Me.contenedor.Panel1.Controls.Add(Me.cmdOperaciones)
        '
        'contenedor.Panel2
        '
        Me.contenedor.Panel2.Controls.Add(Me.cmdOperDel)
        Me.contenedor.Panel2.Controls.Add(Me.cmdOperSave)
        Me.contenedor.Panel2.Controls.Add(Me.cmdOperEdit)
        Me.contenedor.Panel2.Controls.Add(Me.txtClienteApellido)
        Me.contenedor.Panel2.Controls.Add(Me.txtClienteDomicilio)
        Me.contenedor.Panel2.Controls.Add(Me.txtClienteNombre)
        Me.contenedor.Panel2.Controls.Add(Me.lblCliente)
        Me.contenedor.Panel2.Controls.Add(Me.lblOperacionesVehiculo)
        Me.contenedor.Panel2.Controls.Add(Me.lblOperacionesFecha)
        Me.contenedor.Panel2.Controls.Add(Me.dgvOperaciones)
        Me.contenedor.Panel2.Controls.Add(Me.lstOperVehiculo)
        Me.contenedor.Panel2.Controls.Add(Me.LstOperClientes)
        Me.contenedor.Panel2.Controls.Add(Me.lstClientes)
        Me.contenedor.Panel2.Controls.Add(Me.pckfecha)
        Me.contenedor.Size = New System.Drawing.Size(607, 290)
        Me.contenedor.SplitterDistance = 202
        Me.contenedor.TabIndex = 1
        '
        'cmdVehiculos
        '
        Me.cmdVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdVehiculos.Location = New System.Drawing.Point(12, 121)
        Me.cmdVehiculos.Name = "cmdVehiculos"
        Me.cmdVehiculos.Size = New System.Drawing.Size(132, 37)
        Me.cmdVehiculos.TabIndex = 2
        Me.cmdVehiculos.Text = "&Vehículos"
        Me.cmdVehiculos.UseVisualStyleBackColor = True
        '
        'cmdClientes
        '
        Me.cmdClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClientes.Location = New System.Drawing.Point(12, 78)
        Me.cmdClientes.Name = "cmdClientes"
        Me.cmdClientes.Size = New System.Drawing.Size(132, 37)
        Me.cmdClientes.TabIndex = 1
        Me.cmdClientes.Text = "&Clientes"
        Me.cmdClientes.UseVisualStyleBackColor = True
        '
        'cmdOperaciones
        '
        Me.cmdOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOperaciones.Location = New System.Drawing.Point(12, 35)
        Me.cmdOperaciones.Name = "cmdOperaciones"
        Me.cmdOperaciones.Size = New System.Drawing.Size(132, 37)
        Me.cmdOperaciones.TabIndex = 0
        Me.cmdOperaciones.Text = "&Operaciones"
        Me.cmdOperaciones.UseVisualStyleBackColor = True
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(9, 46)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(55, 17)
        Me.lblCliente.TabIndex = 24
        Me.lblCliente.Text = "Cliente:"
        '
        'lblOperacionesVehiculo
        '
        Me.lblOperacionesVehiculo.AutoSize = True
        Me.lblOperacionesVehiculo.Location = New System.Drawing.Point(9, 76)
        Me.lblOperacionesVehiculo.Name = "lblOperacionesVehiculo"
        Me.lblOperacionesVehiculo.Size = New System.Drawing.Size(66, 17)
        Me.lblOperacionesVehiculo.TabIndex = 23
        Me.lblOperacionesVehiculo.Text = "Vehículo:"
        '
        'lblOperacionesFecha
        '
        Me.lblOperacionesFecha.AutoSize = True
        Me.lblOperacionesFecha.Location = New System.Drawing.Point(9, 109)
        Me.lblOperacionesFecha.Name = "lblOperacionesFecha"
        Me.lblOperacionesFecha.Size = New System.Drawing.Size(99, 17)
        Me.lblOperacionesFecha.TabIndex = 22
        Me.lblOperacionesFecha.Text = "Fecha de Alta:"
        '
        'dgvOperaciones
        '
        Me.dgvOperaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOperaciones.Location = New System.Drawing.Point(12, 141)
        Me.dgvOperaciones.MultiSelect = False
        Me.dgvOperaciones.Name = "dgvOperaciones"
        Me.dgvOperaciones.ReadOnly = True
        Me.dgvOperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOperaciones.Size = New System.Drawing.Size(375, 137)
        Me.dgvOperaciones.TabIndex = 21
        Me.dgvOperaciones.TabStop = False
        '
        'lstOperVehiculo
        '
        Me.lstOperVehiculo.FormattingEnabled = True
        Me.lstOperVehiculo.Location = New System.Drawing.Point(119, 73)
        Me.lstOperVehiculo.Name = "lstOperVehiculo"
        Me.lstOperVehiculo.Size = New System.Drawing.Size(268, 24)
        Me.lstOperVehiculo.TabIndex = 19
        '
        'LstOperClientes
        '
        Me.LstOperClientes.FormattingEnabled = True
        Me.LstOperClientes.Location = New System.Drawing.Point(119, 43)
        Me.LstOperClientes.Name = "LstOperClientes"
        Me.LstOperClientes.Size = New System.Drawing.Size(268, 24)
        Me.LstOperClientes.TabIndex = 18
        '
        'pckfecha
        '
        Me.pckfecha.Checked = False
        Me.pckfecha.Location = New System.Drawing.Point(119, 104)
        Me.pckfecha.Name = "pckfecha"
        Me.pckfecha.ShowCheckBox = True
        Me.pckfecha.Size = New System.Drawing.Size(268, 23)
        Me.pckfecha.TabIndex = 20
        Me.pckfecha.Value = New Date(2021, 6, 15, 12, 44, 35, 0)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 290)
        Me.Controls.Add(Me.contenedor)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Control de Créditos para Vehículos"
        Me.contenedor.Panel1.ResumeLayout(False)
        Me.contenedor.Panel2.ResumeLayout(False)
        Me.contenedor.Panel2.PerformLayout()
        CType(Me.contenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contenedor.ResumeLayout(False)
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstClientes As ListBox
    Friend WithEvents cmdOperDel As Button
    Friend WithEvents cmdOperEdit As Button
    Friend WithEvents txtClienteNombre As TextBox
    Friend WithEvents txtClienteDomicilio As TextBox
    Friend WithEvents txtClienteApellido As TextBox
    Friend WithEvents cmdOperSave As Button
    Friend WithEvents contenedor As SplitContainer
    Friend WithEvents cmdVehiculos As Button
    Friend WithEvents cmdClientes As Button
    Friend WithEvents cmdOperaciones As Button
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblOperacionesVehiculo As Label
    Friend WithEvents lblOperacionesFecha As Label
    Friend WithEvents dgvOperaciones As DataGridView
    Friend WithEvents lstOperVehiculo As ComboBox
    Friend WithEvents LstOperClientes As ComboBox
    Friend WithEvents pckfecha As DateTimePicker
End Class
