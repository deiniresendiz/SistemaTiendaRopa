<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevolucion
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
        Me.FechaDevolucion = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textIdDevolucion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.textSaldo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textTelefono = New System.Windows.Forms.TextBox()
        Me.textDomicilio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.textCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textTotal = New System.Windows.Forms.TextBox()
        Me.textIva = New System.Windows.Forms.TextBox()
        Me.textSub = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgVentas = New System.Windows.Forms.DataGridView()
        Me.IdVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdClienteC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVentaV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.textBusVenta = New System.Windows.Forms.TextBox()
        Me.fechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textIdVenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textMotivo = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dgDetalleVenta = New System.Windows.Forms.DataGridView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FechaDevolucion
        '
        Me.FechaDevolucion.Enabled = False
        Me.FechaDevolucion.Location = New System.Drawing.Point(739, 14)
        Me.FechaDevolucion.Name = "FechaDevolucion"
        Me.FechaDevolucion.Size = New System.Drawing.Size(200, 20)
        Me.FechaDevolucion.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(667, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Fecha:"
        '
        'textIdDevolucion
        '
        Me.textIdDevolucion.Location = New System.Drawing.Point(143, 12)
        Me.textIdDevolucion.Name = "textIdDevolucion"
        Me.textIdDevolucion.ReadOnly = True
        Me.textIdDevolucion.Size = New System.Drawing.Size(100, 20)
        Me.textIdDevolucion.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "IdDevolucion:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textSaldo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.textTelefono)
        Me.GroupBox1.Controls.Add(Me.textDomicilio)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.textCliente)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.textTotal)
        Me.GroupBox1.Controls.Add(Me.textIva)
        Me.GroupBox1.Controls.Add(Me.textSub)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.dgVentas)
        Me.GroupBox1.Controls.Add(Me.textBusVenta)
        Me.GroupBox1.Controls.Add(Me.fechaVenta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.textIdVenta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(927, 212)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Venta"
        '
        'textSaldo
        '
        Me.textSaldo.Location = New System.Drawing.Point(326, 127)
        Me.textSaldo.Name = "textSaldo"
        Me.textSaldo.ReadOnly = True
        Me.textSaldo.Size = New System.Drawing.Size(86, 20)
        Me.textSaldo.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(258, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 18)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Saldo:"
        '
        'textTelefono
        '
        Me.textTelefono.Location = New System.Drawing.Point(102, 124)
        Me.textTelefono.Name = "textTelefono"
        Me.textTelefono.ReadOnly = True
        Me.textTelefono.Size = New System.Drawing.Size(150, 20)
        Me.textTelefono.TabIndex = 47
        '
        'textDomicilio
        '
        Me.textDomicilio.Location = New System.Drawing.Point(102, 90)
        Me.textDomicilio.Name = "textDomicilio"
        Me.textDomicilio.ReadOnly = True
        Me.textDomicilio.Size = New System.Drawing.Size(310, 20)
        Me.textDomicilio.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 18)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Telefono:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 18)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Domicilio:"
        '
        'textCliente
        '
        Me.textCliente.Location = New System.Drawing.Point(86, 51)
        Me.textCliente.Name = "textCliente"
        Me.textCliente.ReadOnly = True
        Me.textCliente.Size = New System.Drawing.Size(326, 20)
        Me.textCliente.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Cliente:"
        '
        'textTotal
        '
        Me.textTotal.Location = New System.Drawing.Point(327, 172)
        Me.textTotal.Name = "textTotal"
        Me.textTotal.ReadOnly = True
        Me.textTotal.Size = New System.Drawing.Size(86, 20)
        Me.textTotal.TabIndex = 41
        '
        'textIva
        '
        Me.textIva.Location = New System.Drawing.Point(188, 172)
        Me.textIva.Name = "textIva"
        Me.textIva.ReadOnly = True
        Me.textIva.Size = New System.Drawing.Size(72, 20)
        Me.textIva.TabIndex = 40
        '
        'textSub
        '
        Me.textSub.Location = New System.Drawing.Point(52, 172)
        Me.textSub.Name = "textSub"
        Me.textSub.ReadOnly = True
        Me.textSub.Size = New System.Drawing.Size(86, 20)
        Me.textSub.TabIndex = 39
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(264, 174)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 18)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Total:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(142, 171)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 18)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Iva:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 18)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Sub:"
        '
        'dgVentas
        '
        Me.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdVenta, Me.Folio, Me.IdClienteC, Me.NombreC, Me.Domicilio, Me.Telefono, Me.Saldo, Me.FechaVentaV, Me.SubtotalV, Me.IvaC, Me.TotalV, Me.Empleado, Me.Estado})
        Me.dgVentas.Location = New System.Drawing.Point(418, 53)
        Me.dgVentas.Name = "dgVentas"
        Me.dgVentas.Size = New System.Drawing.Size(503, 153)
        Me.dgVentas.TabIndex = 24
        '
        'IdVenta
        '
        Me.IdVenta.FillWeight = 50.0!
        Me.IdVenta.HeaderText = "IdVenta"
        Me.IdVenta.Name = "IdVenta"
        Me.IdVenta.Width = 50
        '
        'Folio
        '
        Me.Folio.FillWeight = 60.0!
        Me.Folio.HeaderText = "Folio"
        Me.Folio.Name = "Folio"
        Me.Folio.Width = 60
        '
        'IdClienteC
        '
        Me.IdClienteC.FillWeight = 60.0!
        Me.IdClienteC.HeaderText = "IdCLiente"
        Me.IdClienteC.Name = "IdClienteC"
        Me.IdClienteC.Width = 60
        '
        'NombreC
        '
        Me.NombreC.HeaderText = "Nombre"
        Me.NombreC.Name = "NombreC"
        '
        'Domicilio
        '
        Me.Domicilio.HeaderText = "Domicilio"
        Me.Domicilio.Name = "Domicilio"
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        '
        'Saldo
        '
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        '
        'FechaVentaV
        '
        Me.FechaVentaV.HeaderText = "Fecha venta"
        Me.FechaVentaV.Name = "FechaVentaV"
        '
        'SubtotalV
        '
        Me.SubtotalV.HeaderText = "SubTotal"
        Me.SubtotalV.Name = "SubtotalV"
        '
        'IvaC
        '
        Me.IvaC.HeaderText = "Iva"
        Me.IvaC.Name = "IvaC"
        '
        'TotalV
        '
        Me.TotalV.HeaderText = "Total"
        Me.TotalV.Name = "TotalV"
        '
        'Empleado
        '
        Me.Empleado.HeaderText = "Empleado"
        Me.Empleado.Name = "Empleado"
        '
        'Estado
        '
        Me.Estado.FillWeight = 50.0!
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.Width = 50
        '
        'textBusVenta
        '
        Me.textBusVenta.Location = New System.Drawing.Point(581, 17)
        Me.textBusVenta.Name = "textBusVenta"
        Me.textBusVenta.Size = New System.Drawing.Size(330, 20)
        Me.textBusVenta.TabIndex = 25
        '
        'fechaVenta
        '
        Me.fechaVenta.Enabled = False
        Me.fechaVenta.Location = New System.Drawing.Point(211, 15)
        Me.fechaVenta.Name = "fechaVenta"
        Me.fechaVenta.Size = New System.Drawing.Size(201, 20)
        Me.fechaVenta.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(444, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Buscar Venta:"
        '
        'textIdVenta
        '
        Me.textIdVenta.Location = New System.Drawing.Point(38, 16)
        Me.textIdVenta.Name = "textIdVenta"
        Me.textIdVenta.ReadOnly = True
        Me.textIdVenta.Size = New System.Drawing.Size(100, 20)
        Me.textIdVenta.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(143, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 18)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Id:"
        '
        'textMotivo
        '
        Me.textMotivo.Location = New System.Drawing.Point(607, 277)
        Me.textMotivo.Multiline = True
        Me.textMotivo.Name = "textMotivo"
        Me.textMotivo.Size = New System.Drawing.Size(332, 178)
        Me.textMotivo.TabIndex = 23
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(604, 256)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Motivo:"
        '
        'dgDetalleVenta
        '
        Me.dgDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalleVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.idProducto, Me.Nombre, Me.Categoria, Me.Cantidad, Me.Precio, Me.SubTotal})
        Me.dgDetalleVenta.Location = New System.Drawing.Point(6, 21)
        Me.dgDetalleVenta.Name = "dgDetalleVenta"
        Me.dgDetalleVenta.Size = New System.Drawing.Size(569, 201)
        Me.dgDetalleVenta.TabIndex = 30
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(864, 461)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 39
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(607, 461)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 38
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgDetalleVenta)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(586, 228)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Venta"
        '
        'no
        '
        Me.no.FillWeight = 40.0!
        Me.no.HeaderText = "No"
        Me.no.Name = "no"
        Me.no.Width = 40
        '
        'idProducto
        '
        Me.idProducto.FillWeight = 70.0!
        Me.idProducto.HeaderText = "IdProducto"
        Me.idProducto.Name = "idProducto"
        Me.idProducto.Width = 70
        '
        'Nombre
        '
        Me.Nombre.FillWeight = 200.0!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 200
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        '
        'Cantidad
        '
        Me.Cantidad.FillWeight = 60.0!
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 60
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        '
        'frmDevolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 496)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.textMotivo)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FechaDevolucion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textIdDevolucion)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmDevolucion"
        Me.Text = "frmDevolucion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FechaDevolucion As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents textIdDevolucion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents textMotivo As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents dgVentas As DataGridView
    Friend WithEvents textBusVenta As TextBox
    Friend WithEvents fechaVenta As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents textIdVenta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents textTotal As TextBox
    Friend WithEvents textIva As TextBox
    Friend WithEvents textSub As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dgDetalleVenta As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents textTelefono As TextBox
    Friend WithEvents textDomicilio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents textCliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents textSaldo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents IdVenta As DataGridViewTextBoxColumn
    Friend WithEvents Folio As DataGridViewTextBoxColumn
    Friend WithEvents IdClienteC As DataGridViewTextBoxColumn
    Friend WithEvents NombreC As DataGridViewTextBoxColumn
    Friend WithEvents Domicilio As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents FechaVentaV As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalV As DataGridViewTextBoxColumn
    Friend WithEvents IvaC As DataGridViewTextBoxColumn
    Friend WithEvents TotalV As DataGridViewTextBoxColumn
    Friend WithEvents Empleado As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents idProducto As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
End Class
