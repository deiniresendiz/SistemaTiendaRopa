<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmApartado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gruopProducto = New System.Windows.Forms.GroupBox()
        Me.textProductoId = New System.Windows.Forms.TextBox()
        Me.textProductoNombre = New System.Windows.Forms.TextBox()
        Me.textBuscarProducto = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dgDatosProductos = New System.Windows.Forms.DataGridView()
        Me.idProductoProductos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Talla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Existencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciasApartado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Maximo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Minimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioProdcuto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltiFechaComp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.textCantidad = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.textTalla = New System.Windows.Forms.TextBox()
        Me.textMaximo = New System.Windows.Forms.TextBox()
        Me.textMinimo = New System.Windows.Forms.TextBox()
        Me.textExistenciaA = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.textExistencias = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.textPrecio = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.grupEmpleados = New System.Windows.Forms.GroupBox()
        Me.txtBuscarEmpleados = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgDatosEmpleados = New System.Windows.Forms.DataGridView()
        Me.IdEmpleados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colonia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAceptarE = New System.Windows.Forms.Button()
        Me.textNombreEmpleados = New System.Windows.Forms.TextBox()
        Me.textTelefonoEmpleados = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textPuestoEmpleados = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.grupClientes = New System.Windows.Forms.GroupBox()
        Me.textBuscarCliente = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dgDatosClientes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAceptarCliente = New System.Windows.Forms.Button()
        Me.textNombreCliente = New System.Windows.Forms.TextBox()
        Me.textTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.textSaldoCliente = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.textIdApartado = New System.Windows.Forms.TextBox()
        Me.grupProveedor = New System.Windows.Forms.GroupBox()
        Me.btnAtrasE = New System.Windows.Forms.Button()
        Me.textNombreE = New System.Windows.Forms.TextBox()
        Me.textColoniaE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textTelefonoE = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.textCalleE = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textPuestoE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textIdEmpleadoE = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dateFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAtrasCliente = New System.Windows.Forms.Button()
        Me.textNombreC = New System.Windows.Forms.TextBox()
        Me.textColoniaC = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.textTelefonoC = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.textCalleC = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.textSaldoC = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.textIdClienteC = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.fechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.textTotal = New System.Windows.Forms.TextBox()
        Me.textIva = New System.Windows.Forms.TextBox()
        Me.textSubTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgDatosCompra = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CsotoCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.textAnticipo = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.textRestante = New System.Windows.Forms.TextBox()
        Me.gruopProducto.SuspendLayout()
        CType(Me.dgDatosProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupEmpleados.SuspendLayout()
        CType(Me.dgDatosEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupClientes.SuspendLayout()
        CType(Me.dgDatosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupProveedor.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDatosCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gruopProducto
        '
        Me.gruopProducto.Controls.Add(Me.textProductoId)
        Me.gruopProducto.Controls.Add(Me.textProductoNombre)
        Me.gruopProducto.Controls.Add(Me.textBuscarProducto)
        Me.gruopProducto.Controls.Add(Me.Label25)
        Me.gruopProducto.Controls.Add(Me.dgDatosProductos)
        Me.gruopProducto.Controls.Add(Me.btnAgregar)
        Me.gruopProducto.Controls.Add(Me.textCantidad)
        Me.gruopProducto.Controls.Add(Me.Label27)
        Me.gruopProducto.Controls.Add(Me.textTalla)
        Me.gruopProducto.Controls.Add(Me.textMaximo)
        Me.gruopProducto.Controls.Add(Me.textMinimo)
        Me.gruopProducto.Controls.Add(Me.textExistenciaA)
        Me.gruopProducto.Controls.Add(Me.Label30)
        Me.gruopProducto.Controls.Add(Me.textExistencias)
        Me.gruopProducto.Controls.Add(Me.Label31)
        Me.gruopProducto.Controls.Add(Me.Label32)
        Me.gruopProducto.Controls.Add(Me.Label33)
        Me.gruopProducto.Controls.Add(Me.textPrecio)
        Me.gruopProducto.Controls.Add(Me.Label34)
        Me.gruopProducto.Controls.Add(Me.Label35)
        Me.gruopProducto.Location = New System.Drawing.Point(12, 189)
        Me.gruopProducto.Name = "gruopProducto"
        Me.gruopProducto.Size = New System.Drawing.Size(923, 165)
        Me.gruopProducto.TabIndex = 68
        Me.gruopProducto.TabStop = False
        Me.gruopProducto.Text = "Producto"
        Me.gruopProducto.Visible = False
        '
        'textProductoId
        '
        Me.textProductoId.Location = New System.Drawing.Point(64, 131)
        Me.textProductoId.Name = "textProductoId"
        Me.textProductoId.ReadOnly = True
        Me.textProductoId.Size = New System.Drawing.Size(26, 20)
        Me.textProductoId.TabIndex = 36
        Me.textProductoId.Visible = False
        '
        'textProductoNombre
        '
        Me.textProductoNombre.Location = New System.Drawing.Point(9, 131)
        Me.textProductoNombre.Name = "textProductoNombre"
        Me.textProductoNombre.ReadOnly = True
        Me.textProductoNombre.Size = New System.Drawing.Size(26, 20)
        Me.textProductoNombre.TabIndex = 35
        Me.textProductoNombre.Visible = False
        '
        'textBuscarProducto
        '
        Me.textBuscarProducto.Location = New System.Drawing.Point(512, 11)
        Me.textBuscarProducto.Name = "textBuscarProducto"
        Me.textBuscarProducto.Size = New System.Drawing.Size(333, 20)
        Me.textBuscarProducto.TabIndex = 22
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(347, 13)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(159, 18)
        Me.Label25.TabIndex = 24
        Me.Label25.Text = "Buscar Producto:"
        '
        'dgDatosProductos
        '
        Me.dgDatosProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatosProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProductoProductos, Me.Categoria, Me.NombreProducto, Me.Descripcion, Me.Talla, Me.Existencias, Me.ExistenciasApartado, Me.Maximo, Me.Minimo, Me.Costo, Me.PrecioProdcuto, Me.UltiFechaComp})
        Me.dgDatosProductos.Location = New System.Drawing.Point(347, 40)
        Me.dgDatosProductos.Name = "dgDatosProductos"
        Me.dgDatosProductos.ReadOnly = True
        Me.dgDatosProductos.Size = New System.Drawing.Size(554, 124)
        Me.dgDatosProductos.TabIndex = 34
        '
        'idProductoProductos
        '
        Me.idProductoProductos.HeaderText = "idProducto"
        Me.idProductoProductos.Name = "idProductoProductos"
        Me.idProductoProductos.ReadOnly = True
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        '
        'NombreProducto
        '
        Me.NombreProducto.HeaderText = "Nombre"
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.FillWeight = 250.0!
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 250
        '
        'Talla
        '
        Me.Talla.HeaderText = "Talla"
        Me.Talla.Name = "Talla"
        Me.Talla.ReadOnly = True
        '
        'Existencias
        '
        Me.Existencias.HeaderText = "Existencias"
        Me.Existencias.Name = "Existencias"
        Me.Existencias.ReadOnly = True
        '
        'ExistenciasApartado
        '
        Me.ExistenciasApartado.HeaderText = "ExistenciasA"
        Me.ExistenciasApartado.Name = "ExistenciasApartado"
        Me.ExistenciasApartado.ReadOnly = True
        '
        'Maximo
        '
        Me.Maximo.HeaderText = "Maximo"
        Me.Maximo.Name = "Maximo"
        Me.Maximo.ReadOnly = True
        '
        'Minimo
        '
        Me.Minimo.HeaderText = "Minimo"
        Me.Minimo.Name = "Minimo"
        Me.Minimo.ReadOnly = True
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        '
        'PrecioProdcuto
        '
        Me.PrecioProdcuto.HeaderText = "Precio"
        Me.PrecioProdcuto.Name = "PrecioProdcuto"
        Me.PrecioProdcuto.ReadOnly = True
        '
        'UltiFechaComp
        '
        Me.UltiFechaComp.HeaderText = "ULtiFecCom"
        Me.UltiFechaComp.Name = "UltiFechaComp"
        Me.UltiFechaComp.ReadOnly = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(111, 125)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(109, 28)
        Me.btnAgregar.TabIndex = 22
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'textCantidad
        '
        Me.textCantidad.Enabled = False
        Me.textCantidad.Location = New System.Drawing.Point(257, 99)
        Me.textCantidad.Name = "textCantidad"
        Me.textCantidad.Size = New System.Drawing.Size(84, 20)
        Me.textCantidad.TabIndex = 33
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(166, 98)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(92, 18)
        Me.Label27.TabIndex = 32
        Me.Label27.Text = "Cantidad:"
        '
        'textTalla
        '
        Me.textTalla.Location = New System.Drawing.Point(228, 70)
        Me.textTalla.Name = "textTalla"
        Me.textTalla.ReadOnly = True
        Me.textTalla.Size = New System.Drawing.Size(113, 20)
        Me.textTalla.TabIndex = 30
        '
        'textMaximo
        '
        Me.textMaximo.Location = New System.Drawing.Point(91, 39)
        Me.textMaximo.Name = "textMaximo"
        Me.textMaximo.ReadOnly = True
        Me.textMaximo.Size = New System.Drawing.Size(77, 20)
        Me.textMaximo.TabIndex = 29
        '
        'textMinimo
        '
        Me.textMinimo.Location = New System.Drawing.Point(264, 40)
        Me.textMinimo.Name = "textMinimo"
        Me.textMinimo.ReadOnly = True
        Me.textMinimo.Size = New System.Drawing.Size(77, 20)
        Me.textMinimo.TabIndex = 28
        '
        'textExistenciaA
        '
        Me.textExistenciaA.Location = New System.Drawing.Point(287, 14)
        Me.textExistenciaA.Name = "textExistenciaA"
        Me.textExistenciaA.ReadOnly = True
        Me.textExistenciaA.Size = New System.Drawing.Size(54, 20)
        Me.textExistenciaA.TabIndex = 27
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(131, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(149, 18)
        Me.Label30.TabIndex = 26
        Me.Label30.Text = "ExisteApartado:"
        '
        'textExistencias
        '
        Me.textExistencias.Location = New System.Drawing.Point(74, 14)
        Me.textExistencias.Name = "textExistencias"
        Me.textExistencias.ReadOnly = True
        Me.textExistencias.Size = New System.Drawing.Size(54, 20)
        Me.textExistencias.TabIndex = 25
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(6, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(67, 18)
        Me.Label31.TabIndex = 24
        Me.Label31.Text = "Existe:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(166, 72)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(56, 18)
        Me.Label32.TabIndex = 18
        Me.Label32.Text = "Talla:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(6, 71)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(69, 18)
        Me.Label33.TabIndex = 10
        Me.Label33.Text = "Precio:"
        '
        'textPrecio
        '
        Me.textPrecio.Location = New System.Drawing.Point(76, 73)
        Me.textPrecio.Name = "textPrecio"
        Me.textPrecio.ReadOnly = True
        Me.textPrecio.Size = New System.Drawing.Size(86, 20)
        Me.textPrecio.TabIndex = 11
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(174, 41)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(75, 18)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "Minimo:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(6, 41)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(82, 18)
        Me.Label35.TabIndex = 13
        Me.Label35.Text = "Maximo:"
        '
        'grupEmpleados
        '
        Me.grupEmpleados.Controls.Add(Me.txtBuscarEmpleados)
        Me.grupEmpleados.Controls.Add(Me.Label2)
        Me.grupEmpleados.Controls.Add(Me.dgDatosEmpleados)
        Me.grupEmpleados.Controls.Add(Me.btnAceptarE)
        Me.grupEmpleados.Controls.Add(Me.textNombreEmpleados)
        Me.grupEmpleados.Controls.Add(Me.textTelefonoEmpleados)
        Me.grupEmpleados.Controls.Add(Me.Label3)
        Me.grupEmpleados.Controls.Add(Me.textPuestoEmpleados)
        Me.grupEmpleados.Controls.Add(Me.Label26)
        Me.grupEmpleados.Controls.Add(Me.Label28)
        Me.grupEmpleados.Enabled = False
        Me.grupEmpleados.Location = New System.Drawing.Point(12, 38)
        Me.grupEmpleados.Name = "grupEmpleados"
        Me.grupEmpleados.Size = New System.Drawing.Size(918, 183)
        Me.grupEmpleados.TabIndex = 64
        Me.grupEmpleados.TabStop = False
        Me.grupEmpleados.Text = "Empleados"
        '
        'txtBuscarEmpleados
        '
        Me.txtBuscarEmpleados.Location = New System.Drawing.Point(462, 15)
        Me.txtBuscarEmpleados.Name = "txtBuscarEmpleados"
        Me.txtBuscarEmpleados.Size = New System.Drawing.Size(333, 20)
        Me.txtBuscarEmpleados.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Buscar Empleado:"
        '
        'dgDatosEmpleados
        '
        Me.dgDatosEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatosEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpleados, Me.NombreP, Me.Puesto, Me.Calle, Me.Colonia, Me.Telefono})
        Me.dgDatosEmpleados.Location = New System.Drawing.Point(287, 37)
        Me.dgDatosEmpleados.Name = "dgDatosEmpleados"
        Me.dgDatosEmpleados.ReadOnly = True
        Me.dgDatosEmpleados.Size = New System.Drawing.Size(611, 140)
        Me.dgDatosEmpleados.TabIndex = 22
        '
        'IdEmpleados
        '
        Me.IdEmpleados.HeaderText = "IdEmpleado"
        Me.IdEmpleados.Name = "IdEmpleados"
        Me.IdEmpleados.ReadOnly = True
        '
        'NombreP
        '
        Me.NombreP.FillWeight = 200.0!
        Me.NombreP.HeaderText = "Nombre"
        Me.NombreP.Name = "NombreP"
        Me.NombreP.ReadOnly = True
        Me.NombreP.Width = 200
        '
        'Puesto
        '
        Me.Puesto.HeaderText = "Puesto"
        Me.Puesto.Name = "Puesto"
        Me.Puesto.ReadOnly = True
        '
        'Calle
        '
        Me.Calle.HeaderText = "Calle"
        Me.Calle.Name = "Calle"
        Me.Calle.ReadOnly = True
        '
        'Colonia
        '
        Me.Colonia.HeaderText = "Colonia"
        Me.Colonia.Name = "Colonia"
        Me.Colonia.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'btnAceptarE
        '
        Me.btnAceptarE.Enabled = False
        Me.btnAceptarE.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarE.Location = New System.Drawing.Point(96, 129)
        Me.btnAceptarE.Name = "btnAceptarE"
        Me.btnAceptarE.Size = New System.Drawing.Size(109, 28)
        Me.btnAceptarE.TabIndex = 21
        Me.btnAceptarE.Text = "Aceptar"
        Me.btnAceptarE.UseVisualStyleBackColor = True
        '
        'textNombreEmpleados
        '
        Me.textNombreEmpleados.Location = New System.Drawing.Point(96, 13)
        Me.textNombreEmpleados.Name = "textNombreEmpleados"
        Me.textNombreEmpleados.ReadOnly = True
        Me.textNombreEmpleados.Size = New System.Drawing.Size(182, 20)
        Me.textNombreEmpleados.TabIndex = 12
        '
        'textTelefonoEmpleados
        '
        Me.textTelefonoEmpleados.Location = New System.Drawing.Point(105, 86)
        Me.textTelefonoEmpleados.Name = "textTelefonoEmpleados"
        Me.textTelefonoEmpleados.ReadOnly = True
        Me.textTelefonoEmpleados.Size = New System.Drawing.Size(173, 20)
        Me.textTelefonoEmpleados.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Telefono:"
        '
        'textPuestoEmpleados
        '
        Me.textPuestoEmpleados.Location = New System.Drawing.Point(105, 50)
        Me.textPuestoEmpleados.Name = "textPuestoEmpleados"
        Me.textPuestoEmpleados.ReadOnly = True
        Me.textPuestoEmpleados.Size = New System.Drawing.Size(173, 20)
        Me.textPuestoEmpleados.TabIndex = 5
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 49)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(75, 18)
        Me.Label26.TabIndex = 4
        Me.Label26.Text = "Puesto:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(84, 18)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Nombre:"
        '
        'grupClientes
        '
        Me.grupClientes.Controls.Add(Me.textBuscarCliente)
        Me.grupClientes.Controls.Add(Me.Label21)
        Me.grupClientes.Controls.Add(Me.dgDatosClientes)
        Me.grupClientes.Controls.Add(Me.btnAceptarCliente)
        Me.grupClientes.Controls.Add(Me.textNombreCliente)
        Me.grupClientes.Controls.Add(Me.textTelefonoCliente)
        Me.grupClientes.Controls.Add(Me.Label22)
        Me.grupClientes.Controls.Add(Me.textSaldoCliente)
        Me.grupClientes.Controls.Add(Me.Label23)
        Me.grupClientes.Controls.Add(Me.Label24)
        Me.grupClientes.Location = New System.Drawing.Point(18, 36)
        Me.grupClientes.Name = "grupClientes"
        Me.grupClientes.Size = New System.Drawing.Size(918, 183)
        Me.grupClientes.TabIndex = 65
        Me.grupClientes.TabStop = False
        Me.grupClientes.Text = "Clientes"
        '
        'textBuscarCliente
        '
        Me.textBuscarCliente.Location = New System.Drawing.Point(420, 16)
        Me.textBuscarCliente.Name = "textBuscarCliente"
        Me.textBuscarCliente.Size = New System.Drawing.Size(478, 20)
        Me.textBuscarCliente.TabIndex = 21
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(284, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(139, 18)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "Buscar Cliente:"
        '
        'dgDatosClientes
        '
        Me.dgDatosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatosClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgDatosClientes.Location = New System.Drawing.Point(287, 37)
        Me.dgDatosClientes.Name = "dgDatosClientes"
        Me.dgDatosClientes.ReadOnly = True
        Me.dgDatosClientes.Size = New System.Drawing.Size(611, 140)
        Me.dgDatosClientes.TabIndex = 22
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "idCliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Saldo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Calle"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Colonia"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'btnAceptarCliente
        '
        Me.btnAceptarCliente.Enabled = False
        Me.btnAceptarCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarCliente.Location = New System.Drawing.Point(96, 129)
        Me.btnAceptarCliente.Name = "btnAceptarCliente"
        Me.btnAceptarCliente.Size = New System.Drawing.Size(109, 28)
        Me.btnAceptarCliente.TabIndex = 21
        Me.btnAceptarCliente.Text = "Aceptar"
        Me.btnAceptarCliente.UseVisualStyleBackColor = True
        '
        'textNombreCliente
        '
        Me.textNombreCliente.Location = New System.Drawing.Point(96, 13)
        Me.textNombreCliente.Name = "textNombreCliente"
        Me.textNombreCliente.ReadOnly = True
        Me.textNombreCliente.Size = New System.Drawing.Size(182, 20)
        Me.textNombreCliente.TabIndex = 12
        '
        'textTelefonoCliente
        '
        Me.textTelefonoCliente.Location = New System.Drawing.Point(105, 86)
        Me.textTelefonoCliente.Name = "textTelefonoCliente"
        Me.textTelefonoCliente.ReadOnly = True
        Me.textTelefonoCliente.Size = New System.Drawing.Size(173, 20)
        Me.textTelefonoCliente.TabIndex = 9
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(7, 86)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(92, 18)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Telefono:"
        '
        'textSaldoCliente
        '
        Me.textSaldoCliente.Location = New System.Drawing.Point(105, 50)
        Me.textSaldoCliente.Name = "textSaldoCliente"
        Me.textSaldoCliente.ReadOnly = True
        Me.textSaldoCliente.Size = New System.Drawing.Size(173, 20)
        Me.textSaldoCliente.TabIndex = 5
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(28, 52)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 18)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Saldo:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(6, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(84, 18)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Nombre:"
        '
        'textIdApartado
        '
        Me.textIdApartado.Location = New System.Drawing.Point(130, 10)
        Me.textIdApartado.Name = "textIdApartado"
        Me.textIdApartado.ReadOnly = True
        Me.textIdApartado.Size = New System.Drawing.Size(93, 20)
        Me.textIdApartado.TabIndex = 66
        '
        'grupProveedor
        '
        Me.grupProveedor.Controls.Add(Me.btnAtrasE)
        Me.grupProveedor.Controls.Add(Me.textNombreE)
        Me.grupProveedor.Controls.Add(Me.textColoniaE)
        Me.grupProveedor.Controls.Add(Me.Label1)
        Me.grupProveedor.Controls.Add(Me.textTelefonoE)
        Me.grupProveedor.Controls.Add(Me.Label10)
        Me.grupProveedor.Controls.Add(Me.textCalleE)
        Me.grupProveedor.Controls.Add(Me.Label9)
        Me.grupProveedor.Controls.Add(Me.textPuestoE)
        Me.grupProveedor.Controls.Add(Me.Label6)
        Me.grupProveedor.Controls.Add(Me.textIdEmpleadoE)
        Me.grupProveedor.Controls.Add(Me.Label7)
        Me.grupProveedor.Controls.Add(Me.Label8)
        Me.grupProveedor.Location = New System.Drawing.Point(18, 38)
        Me.grupProveedor.Name = "grupProveedor"
        Me.grupProveedor.Size = New System.Drawing.Size(900, 72)
        Me.grupProveedor.TabIndex = 59
        Me.grupProveedor.TabStop = False
        Me.grupProveedor.Text = "Empleado"
        Me.grupProveedor.Visible = False
        '
        'btnAtrasE
        '
        Me.btnAtrasE.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtrasE.Location = New System.Drawing.Point(806, 39)
        Me.btnAtrasE.Name = "btnAtrasE"
        Me.btnAtrasE.Size = New System.Drawing.Size(84, 28)
        Me.btnAtrasE.TabIndex = 20
        Me.btnAtrasE.Text = "Atras"
        Me.btnAtrasE.UseVisualStyleBackColor = True
        '
        'textNombreE
        '
        Me.textNombreE.Location = New System.Drawing.Point(96, 13)
        Me.textNombreE.Name = "textNombreE"
        Me.textNombreE.ReadOnly = True
        Me.textNombreE.Size = New System.Drawing.Size(288, 20)
        Me.textNombreE.TabIndex = 12
        '
        'textColoniaE
        '
        Me.textColoniaE.Location = New System.Drawing.Point(305, 44)
        Me.textColoniaE.Name = "textColoniaE"
        Me.textColoniaE.ReadOnly = True
        Me.textColoniaE.Size = New System.Drawing.Size(147, 20)
        Me.textColoniaE.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Colonia:"
        '
        'textTelefonoE
        '
        Me.textTelefonoE.Location = New System.Drawing.Point(556, 46)
        Me.textTelefonoE.Name = "textTelefonoE"
        Me.textTelefonoE.ReadOnly = True
        Me.textTelefonoE.Size = New System.Drawing.Size(141, 20)
        Me.textTelefonoE.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(458, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 18)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Telefono:"
        '
        'textCalleE
        '
        Me.textCalleE.Location = New System.Drawing.Point(68, 44)
        Me.textCalleE.Name = "textCalleE"
        Me.textCalleE.ReadOnly = True
        Me.textCalleE.Size = New System.Drawing.Size(147, 20)
        Me.textCalleE.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Calle:"
        '
        'textPuestoE
        '
        Me.textPuestoE.Location = New System.Drawing.Point(710, 14)
        Me.textPuestoE.Name = "textPuestoE"
        Me.textPuestoE.ReadOnly = True
        Me.textPuestoE.Size = New System.Drawing.Size(147, 20)
        Me.textPuestoE.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(629, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Puesto:"
        '
        'textIdEmpleadoE
        '
        Me.textIdEmpleadoE.Location = New System.Drawing.Point(516, 13)
        Me.textIdEmpleadoE.Name = "textIdEmpleadoE"
        Me.textIdEmpleadoE.ReadOnly = True
        Me.textIdEmpleadoE.Size = New System.Drawing.Size(100, 20)
        Me.textIdEmpleadoE.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(390, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "IdEmpleado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nombre:"
        '
        'dateFecha
        '
        Me.dateFecha.Enabled = False
        Me.dateFecha.Location = New System.Drawing.Point(348, 10)
        Me.dateFecha.Name = "dateFecha"
        Me.dateFecha.Size = New System.Drawing.Size(200, 20)
        Me.dateFecha.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(229, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 18)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "FechaInicio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 18)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "IdApartado:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAtrasCliente)
        Me.GroupBox1.Controls.Add(Me.textNombreC)
        Me.GroupBox1.Controls.Add(Me.textColoniaC)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.textTelefonoC)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.textCalleC)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.textSaldoC)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.textIdClienteC)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(898, 72)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        Me.GroupBox1.Visible = False
        '
        'btnAtrasCliente
        '
        Me.btnAtrasCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtrasCliente.Location = New System.Drawing.Point(804, 39)
        Me.btnAtrasCliente.Name = "btnAtrasCliente"
        Me.btnAtrasCliente.Size = New System.Drawing.Size(84, 28)
        Me.btnAtrasCliente.TabIndex = 20
        Me.btnAtrasCliente.Text = "Atras"
        Me.btnAtrasCliente.UseVisualStyleBackColor = True
        '
        'textNombreC
        '
        Me.textNombreC.Location = New System.Drawing.Point(96, 13)
        Me.textNombreC.Name = "textNombreC"
        Me.textNombreC.ReadOnly = True
        Me.textNombreC.Size = New System.Drawing.Size(288, 20)
        Me.textNombreC.TabIndex = 12
        '
        'textColoniaC
        '
        Me.textColoniaC.Location = New System.Drawing.Point(305, 44)
        Me.textColoniaC.Name = "textColoniaC"
        Me.textColoniaC.ReadOnly = True
        Me.textColoniaC.Size = New System.Drawing.Size(147, 20)
        Me.textColoniaC.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(221, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 18)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Colonia:"
        '
        'textTelefonoC
        '
        Me.textTelefonoC.Location = New System.Drawing.Point(556, 46)
        Me.textTelefonoC.Name = "textTelefonoC"
        Me.textTelefonoC.ReadOnly = True
        Me.textTelefonoC.Size = New System.Drawing.Size(141, 20)
        Me.textTelefonoC.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(458, 44)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 18)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Telefono:"
        '
        'textCalleC
        '
        Me.textCalleC.Location = New System.Drawing.Point(68, 44)
        Me.textCalleC.Name = "textCalleC"
        Me.textCalleC.ReadOnly = True
        Me.textCalleC.Size = New System.Drawing.Size(147, 20)
        Me.textCalleC.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 44)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 18)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Calle:"
        '
        'textSaldoC
        '
        Me.textSaldoC.Location = New System.Drawing.Point(710, 14)
        Me.textSaldoC.Name = "textSaldoC"
        Me.textSaldoC.ReadOnly = True
        Me.textSaldoC.Size = New System.Drawing.Size(147, 20)
        Me.textSaldoC.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(642, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 18)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Saldo:"
        '
        'textIdClienteC
        '
        Me.textIdClienteC.Location = New System.Drawing.Point(516, 13)
        Me.textIdClienteC.Name = "textIdClienteC"
        Me.textIdClienteC.ReadOnly = True
        Me.textIdClienteC.Size = New System.Drawing.Size(100, 20)
        Me.textIdClienteC.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(417, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 18)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "IdCliente:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 18)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Nombre:"
        '
        'fechaHasta
        '
        Me.fechaHasta.Enabled = False
        Me.fechaHasta.Location = New System.Drawing.Point(736, 10)
        Me.fechaHasta.Name = "fechaHasta"
        Me.fechaHasta.Size = New System.Drawing.Size(200, 20)
        Me.fechaHasta.TabIndex = 70
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(662, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 18)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Hasta:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(835, 524)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 28)
        Me.btnGuardar.TabIndex = 79
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(721, 524)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(97, 28)
        Me.btnNuevo.TabIndex = 78
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'textTotal
        '
        Me.textTotal.Location = New System.Drawing.Point(813, 447)
        Me.textTotal.Name = "textTotal"
        Me.textTotal.ReadOnly = True
        Me.textTotal.Size = New System.Drawing.Size(117, 20)
        Me.textTotal.TabIndex = 77
        Me.textTotal.Text = "0"
        '
        'textIva
        '
        Me.textIva.Location = New System.Drawing.Point(813, 418)
        Me.textIva.Name = "textIva"
        Me.textIva.ReadOnly = True
        Me.textIva.Size = New System.Drawing.Size(117, 20)
        Me.textIva.TabIndex = 76
        Me.textIva.Text = "0"
        '
        'textSubTotal
        '
        Me.textSubTotal.Location = New System.Drawing.Point(811, 389)
        Me.textSubTotal.Name = "textSubTotal"
        Me.textSubTotal.ReadOnly = True
        Me.textSubTotal.Size = New System.Drawing.Size(117, 20)
        Me.textSubTotal.TabIndex = 75
        Me.textSubTotal.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(745, 447)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 18)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "Total:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(761, 417)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 18)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Iva:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(713, 388)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 18)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "SubTotal:"
        '
        'dgDatosCompra
        '
        Me.dgDatosCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatosCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.IdProducto, Me.Nombre, Me.Cantidad, Me.CsotoCompra, Me.SubTotal})
        Me.dgDatosCompra.Location = New System.Drawing.Point(12, 360)
        Me.dgDatosCompra.Name = "dgDatosCompra"
        Me.dgDatosCompra.ReadOnly = True
        Me.dgDatosCompra.Size = New System.Drawing.Size(700, 192)
        Me.dgDatosCompra.TabIndex = 71
        '
        'no
        '
        Me.no.FillWeight = 70.0!
        Me.no.HeaderText = "No"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 70
        '
        'IdProducto
        '
        Me.IdProducto.HeaderText = "IdProducto"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.FillWeight = 200.0!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 200
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'CsotoCompra
        '
        Me.CsotoCompra.HeaderText = "Costo"
        Me.CsotoCompra.Name = "CsotoCompra"
        Me.CsotoCompra.ReadOnly = True
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(721, 360)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(83, 18)
        Me.Label29.TabIndex = 80
        Me.Label29.Text = "Anticipo:"
        '
        'textAnticipo
        '
        Me.textAnticipo.Enabled = False
        Me.textAnticipo.Location = New System.Drawing.Point(813, 360)
        Me.textAnticipo.Name = "textAnticipo"
        Me.textAnticipo.Size = New System.Drawing.Size(117, 20)
        Me.textAnticipo.TabIndex = 81
        Me.textAnticipo.Text = "0"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(718, 479)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(94, 18)
        Me.Label36.TabIndex = 82
        Me.Label36.Text = "Restante:"
        '
        'textRestante
        '
        Me.textRestante.Location = New System.Drawing.Point(813, 477)
        Me.textRestante.Name = "textRestante"
        Me.textRestante.ReadOnly = True
        Me.textRestante.Size = New System.Drawing.Size(117, 20)
        Me.textRestante.TabIndex = 83
        Me.textRestante.Text = "0"
        '
        'frmApartado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 561)
        Me.Controls.Add(Me.textRestante)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.textAnticipo)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.textTotal)
        Me.Controls.Add(Me.textIva)
        Me.Controls.Add(Me.textSubTotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgDatosCompra)
        Me.Controls.Add(Me.fechaHasta)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.gruopProducto)
        Me.Controls.Add(Me.grupEmpleados)
        Me.Controls.Add(Me.grupClientes)
        Me.Controls.Add(Me.textIdApartado)
        Me.Controls.Add(Me.grupProveedor)
        Me.Controls.Add(Me.dateFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmApartado"
        Me.Text = "frmApartado"
        Me.gruopProducto.ResumeLayout(False)
        Me.gruopProducto.PerformLayout()
        CType(Me.dgDatosProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupEmpleados.ResumeLayout(False)
        Me.grupEmpleados.PerformLayout()
        CType(Me.dgDatosEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupClientes.ResumeLayout(False)
        Me.grupClientes.PerformLayout()
        CType(Me.dgDatosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupProveedor.ResumeLayout(False)
        Me.grupProveedor.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgDatosCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gruopProducto As GroupBox
    Friend WithEvents textProductoId As TextBox
    Friend WithEvents textProductoNombre As TextBox
    Friend WithEvents textBuscarProducto As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents dgDatosProductos As DataGridView
    Friend WithEvents idProductoProductos As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents NombreProducto As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Talla As DataGridViewTextBoxColumn
    Friend WithEvents Existencias As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciasApartado As DataGridViewTextBoxColumn
    Friend WithEvents Maximo As DataGridViewTextBoxColumn
    Friend WithEvents Minimo As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents PrecioProdcuto As DataGridViewTextBoxColumn
    Friend WithEvents UltiFechaComp As DataGridViewTextBoxColumn
    Friend WithEvents btnAgregar As Button
    Friend WithEvents textCantidad As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents textTalla As TextBox
    Friend WithEvents textMaximo As TextBox
    Friend WithEvents textMinimo As TextBox
    Friend WithEvents textExistenciaA As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents textExistencias As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents textPrecio As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents grupEmpleados As GroupBox
    Friend WithEvents txtBuscarEmpleados As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgDatosEmpleados As DataGridView
    Friend WithEvents IdEmpleados As DataGridViewTextBoxColumn
    Friend WithEvents NombreP As DataGridViewTextBoxColumn
    Friend WithEvents Puesto As DataGridViewTextBoxColumn
    Friend WithEvents Calle As DataGridViewTextBoxColumn
    Friend WithEvents Colonia As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents btnAceptarE As Button
    Friend WithEvents textNombreEmpleados As TextBox
    Friend WithEvents textTelefonoEmpleados As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textPuestoEmpleados As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents grupClientes As GroupBox
    Friend WithEvents textBuscarCliente As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents dgDatosClientes As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents btnAceptarCliente As Button
    Friend WithEvents textNombreCliente As TextBox
    Friend WithEvents textTelefonoCliente As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents textSaldoCliente As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents textIdApartado As TextBox
    Friend WithEvents grupProveedor As GroupBox
    Friend WithEvents btnAtrasE As Button
    Friend WithEvents textNombreE As TextBox
    Friend WithEvents textColoniaE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents textTelefonoE As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents textCalleE As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents textPuestoE As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents textIdEmpleadoE As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dateFecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAtrasCliente As Button
    Friend WithEvents textNombreC As TextBox
    Friend WithEvents textColoniaC As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents textTelefonoC As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents textCalleC As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents textSaldoC As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents textIdClienteC As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents fechaHasta As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents textTotal As TextBox
    Friend WithEvents textIva As TextBox
    Friend WithEvents textSubTotal As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dgDatosCompra As DataGridView
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents IdProducto As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents CsotoCompra As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents Label29 As Label
    Friend WithEvents textAnticipo As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents textRestante As TextBox
End Class
