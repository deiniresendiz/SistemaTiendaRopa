<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompraProducto
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dateFecha = New System.Windows.Forms.DateTimePicker()
        Me.grupProveedor = New System.Windows.Forms.GroupBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.textNombreP = New System.Windows.Forms.TextBox()
        Me.textColoniaP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textTelefonoP = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.textCallep = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textRfcP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textIdProveedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.textCostoAnterio = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.textFactura = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.textSubTotal = New System.Windows.Forms.TextBox()
        Me.textIva = New System.Windows.Forms.TextBox()
        Me.textTotal = New System.Windows.Forms.TextBox()
        Me.grupProveedores = New System.Windows.Forms.GroupBox()
        Me.txtBuscarProveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgDatosProveedores = New System.Windows.Forms.DataGridView()
        Me.IdProveedorp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colonia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.textNombreProveedor = New System.Windows.Forms.TextBox()
        Me.textTelefonoProveedores = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textRfcProveedores = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.gruopProducto = New System.Windows.Forms.GroupBox()
        Me.textProductoId = New System.Windows.Forms.TextBox()
        Me.textProductoNombre = New System.Windows.Forms.TextBox()
        Me.textBuscarProducto = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
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
        Me.textCosto = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.textTalla = New System.Windows.Forms.TextBox()
        Me.textMaximo = New System.Windows.Forms.TextBox()
        Me.textMinimo = New System.Windows.Forms.TextBox()
        Me.textExistenciaA = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.textExistencias = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dgDatosCompra = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CsotoCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.textIdCompraC = New System.Windows.Forms.TextBox()
        Me.grupProveedor.SuspendLayout()
        Me.grupProveedores.SuspendLayout()
        CType(Me.dgDatosProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gruopProducto.SuspendLayout()
        CType(Me.dgDatosProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDatosCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "IdCompra:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(459, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Fecha:"
        '
        'dateFecha
        '
        Me.dateFecha.Enabled = False
        Me.dateFecha.Location = New System.Drawing.Point(531, 13)
        Me.dateFecha.Name = "dateFecha"
        Me.dateFecha.Size = New System.Drawing.Size(200, 20)
        Me.dateFecha.TabIndex = 8
        '
        'grupProveedor
        '
        Me.grupProveedor.Controls.Add(Me.btnAtras)
        Me.grupProveedor.Controls.Add(Me.textNombreP)
        Me.grupProveedor.Controls.Add(Me.textColoniaP)
        Me.grupProveedor.Controls.Add(Me.Label1)
        Me.grupProveedor.Controls.Add(Me.textTelefonoP)
        Me.grupProveedor.Controls.Add(Me.Label10)
        Me.grupProveedor.Controls.Add(Me.textCallep)
        Me.grupProveedor.Controls.Add(Me.Label9)
        Me.grupProveedor.Controls.Add(Me.textRfcP)
        Me.grupProveedor.Controls.Add(Me.Label6)
        Me.grupProveedor.Controls.Add(Me.textIdProveedor)
        Me.grupProveedor.Controls.Add(Me.Label7)
        Me.grupProveedor.Controls.Add(Me.Label8)
        Me.grupProveedor.Location = New System.Drawing.Point(15, 34)
        Me.grupProveedor.Name = "grupProveedor"
        Me.grupProveedor.Size = New System.Drawing.Size(910, 72)
        Me.grupProveedor.TabIndex = 6
        Me.grupProveedor.TabStop = False
        Me.grupProveedor.Text = "Proveedor"
        Me.grupProveedor.Visible = False
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(826, 39)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(84, 28)
        Me.btnAtras.TabIndex = 20
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'textNombreP
        '
        Me.textNombreP.Location = New System.Drawing.Point(96, 13)
        Me.textNombreP.Name = "textNombreP"
        Me.textNombreP.ReadOnly = True
        Me.textNombreP.Size = New System.Drawing.Size(288, 20)
        Me.textNombreP.TabIndex = 12
        '
        'textColoniaP
        '
        Me.textColoniaP.Location = New System.Drawing.Point(305, 44)
        Me.textColoniaP.Name = "textColoniaP"
        Me.textColoniaP.ReadOnly = True
        Me.textColoniaP.Size = New System.Drawing.Size(147, 20)
        Me.textColoniaP.TabIndex = 11
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
        'textTelefonoP
        '
        Me.textTelefonoP.Location = New System.Drawing.Point(556, 46)
        Me.textTelefonoP.Name = "textTelefonoP"
        Me.textTelefonoP.ReadOnly = True
        Me.textTelefonoP.Size = New System.Drawing.Size(141, 20)
        Me.textTelefonoP.TabIndex = 9
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
        'textCallep
        '
        Me.textCallep.Location = New System.Drawing.Point(68, 44)
        Me.textCallep.Name = "textCallep"
        Me.textCallep.ReadOnly = True
        Me.textCallep.Size = New System.Drawing.Size(147, 20)
        Me.textCallep.TabIndex = 7
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
        'textRfcP
        '
        Me.textRfcP.Location = New System.Drawing.Point(684, 13)
        Me.textRfcP.Name = "textRfcP"
        Me.textRfcP.ReadOnly = True
        Me.textRfcP.Size = New System.Drawing.Size(147, 20)
        Me.textRfcP.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(629, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "RFC:"
        '
        'textIdProveedor
        '
        Me.textIdProveedor.Location = New System.Drawing.Point(516, 13)
        Me.textIdProveedor.Name = "textIdProveedor"
        Me.textIdProveedor.ReadOnly = True
        Me.textIdProveedor.Size = New System.Drawing.Size(100, 20)
        Me.textIdProveedor.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(390, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "IdProveedor"
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
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(166, 72)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 18)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "Talla:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 72)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 18)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "Max:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(214, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 18)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Min:"
        '
        'textCostoAnterio
        '
        Me.textCostoAnterio.Location = New System.Drawing.Point(136, 40)
        Me.textCostoAnterio.Name = "textCostoAnterio"
        Me.textCostoAnterio.ReadOnly = True
        Me.textCostoAnterio.Size = New System.Drawing.Size(64, 20)
        Me.textCostoAnterio.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(133, 18)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Costo Anterio:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(737, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Fractura:"
        '
        'textFactura
        '
        Me.textFactura.Enabled = False
        Me.textFactura.Location = New System.Drawing.Point(832, 11)
        Me.textFactura.Name = "textFactura"
        Me.textFactura.Size = New System.Drawing.Size(100, 20)
        Me.textFactura.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(715, 316)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 18)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "SubTotal:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(763, 345)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 18)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Iva:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(747, 375)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 18)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Total:"
        '
        'textSubTotal
        '
        Me.textSubTotal.Location = New System.Drawing.Point(813, 317)
        Me.textSubTotal.Name = "textSubTotal"
        Me.textSubTotal.ReadOnly = True
        Me.textSubTotal.Size = New System.Drawing.Size(117, 20)
        Me.textSubTotal.TabIndex = 15
        '
        'textIva
        '
        Me.textIva.Location = New System.Drawing.Point(815, 346)
        Me.textIva.Name = "textIva"
        Me.textIva.ReadOnly = True
        Me.textIva.Size = New System.Drawing.Size(117, 20)
        Me.textIva.TabIndex = 16
        '
        'textTotal
        '
        Me.textTotal.Location = New System.Drawing.Point(815, 375)
        Me.textTotal.Name = "textTotal"
        Me.textTotal.ReadOnly = True
        Me.textTotal.Size = New System.Drawing.Size(117, 20)
        Me.textTotal.TabIndex = 17
        '
        'grupProveedores
        '
        Me.grupProveedores.Controls.Add(Me.txtBuscarProveedor)
        Me.grupProveedores.Controls.Add(Me.Label2)
        Me.grupProveedores.Controls.Add(Me.dgDatosProveedores)
        Me.grupProveedores.Controls.Add(Me.btnAceptar)
        Me.grupProveedores.Controls.Add(Me.textNombreProveedor)
        Me.grupProveedores.Controls.Add(Me.textTelefonoProveedores)
        Me.grupProveedores.Controls.Add(Me.Label3)
        Me.grupProveedores.Controls.Add(Me.textRfcProveedores)
        Me.grupProveedores.Controls.Add(Me.Label26)
        Me.grupProveedores.Controls.Add(Me.Label28)
        Me.grupProveedores.Enabled = False
        Me.grupProveedores.Location = New System.Drawing.Point(12, 34)
        Me.grupProveedores.Name = "grupProveedores"
        Me.grupProveedores.Size = New System.Drawing.Size(907, 183)
        Me.grupProveedores.TabIndex = 20
        Me.grupProveedores.TabStop = False
        Me.grupProveedores.Text = "Proveedores"
        '
        'txtBuscarProveedor
        '
        Me.txtBuscarProveedor.Location = New System.Drawing.Point(462, 15)
        Me.txtBuscarProveedor.Name = "txtBuscarProveedor"
        Me.txtBuscarProveedor.Size = New System.Drawing.Size(333, 20)
        Me.txtBuscarProveedor.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Buscar Proveedor:"
        '
        'dgDatosProveedores
        '
        Me.dgDatosProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatosProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedorp, Me.NombreP, Me.RFC, Me.Calle, Me.Colonia, Me.Telefono})
        Me.dgDatosProveedores.Location = New System.Drawing.Point(287, 37)
        Me.dgDatosProveedores.Name = "dgDatosProveedores"
        Me.dgDatosProveedores.ReadOnly = True
        Me.dgDatosProveedores.Size = New System.Drawing.Size(611, 140)
        Me.dgDatosProveedores.TabIndex = 22
        '
        'IdProveedorp
        '
        Me.IdProveedorp.HeaderText = "IdProveedor"
        Me.IdProveedorp.Name = "IdProveedorp"
        Me.IdProveedorp.ReadOnly = True
        '
        'NombreP
        '
        Me.NombreP.HeaderText = "Nombre"
        Me.NombreP.Name = "NombreP"
        Me.NombreP.ReadOnly = True
        '
        'RFC
        '
        Me.RFC.HeaderText = "RFC"
        Me.RFC.Name = "RFC"
        Me.RFC.ReadOnly = True
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
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(96, 129)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(109, 28)
        Me.btnAceptar.TabIndex = 21
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'textNombreProveedor
        '
        Me.textNombreProveedor.Location = New System.Drawing.Point(96, 13)
        Me.textNombreProveedor.Name = "textNombreProveedor"
        Me.textNombreProveedor.ReadOnly = True
        Me.textNombreProveedor.Size = New System.Drawing.Size(182, 20)
        Me.textNombreProveedor.TabIndex = 12
        '
        'textTelefonoProveedores
        '
        Me.textTelefonoProveedores.Location = New System.Drawing.Point(105, 86)
        Me.textTelefonoProveedores.Name = "textTelefonoProveedores"
        Me.textTelefonoProveedores.ReadOnly = True
        Me.textTelefonoProveedores.Size = New System.Drawing.Size(173, 20)
        Me.textTelefonoProveedores.TabIndex = 9
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
        'textRfcProveedores
        '
        Me.textRfcProveedores.Location = New System.Drawing.Point(61, 50)
        Me.textRfcProveedores.Name = "textRfcProveedores"
        Me.textRfcProveedores.ReadOnly = True
        Me.textRfcProveedores.Size = New System.Drawing.Size(217, 20)
        Me.textRfcProveedores.TabIndex = 5
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 49)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(49, 18)
        Me.Label26.TabIndex = 4
        Me.Label26.Text = "RFC:"
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
        'gruopProducto
        '
        Me.gruopProducto.Controls.Add(Me.textProductoId)
        Me.gruopProducto.Controls.Add(Me.textProductoNombre)
        Me.gruopProducto.Controls.Add(Me.textBuscarProducto)
        Me.gruopProducto.Controls.Add(Me.Label17)
        Me.gruopProducto.Controls.Add(Me.dgDatosProductos)
        Me.gruopProducto.Controls.Add(Me.btnAgregar)
        Me.gruopProducto.Controls.Add(Me.textCantidad)
        Me.gruopProducto.Controls.Add(Me.textCosto)
        Me.gruopProducto.Controls.Add(Me.Label16)
        Me.gruopProducto.Controls.Add(Me.Label15)
        Me.gruopProducto.Controls.Add(Me.textTalla)
        Me.gruopProducto.Controls.Add(Me.textMaximo)
        Me.gruopProducto.Controls.Add(Me.textMinimo)
        Me.gruopProducto.Controls.Add(Me.textExistenciaA)
        Me.gruopProducto.Controls.Add(Me.Label27)
        Me.gruopProducto.Controls.Add(Me.textExistencias)
        Me.gruopProducto.Controls.Add(Me.Label25)
        Me.gruopProducto.Controls.Add(Me.Label22)
        Me.gruopProducto.Controls.Add(Me.Label18)
        Me.gruopProducto.Controls.Add(Me.textCostoAnterio)
        Me.gruopProducto.Controls.Add(Me.Label19)
        Me.gruopProducto.Controls.Add(Me.Label20)
        Me.gruopProducto.Location = New System.Drawing.Point(9, 112)
        Me.gruopProducto.Name = "gruopProducto"
        Me.gruopProducto.Size = New System.Drawing.Size(916, 165)
        Me.gruopProducto.TabIndex = 21
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
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(347, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(159, 18)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Buscar Producto:"
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
        'textCosto
        '
        Me.textCosto.Enabled = False
        Me.textCosto.Location = New System.Drawing.Point(76, 99)
        Me.textCosto.Name = "textCosto"
        Me.textCosto.Size = New System.Drawing.Size(84, 20)
        Me.textCosto.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(166, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 18)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Cantidad:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 18)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Costo:"
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
        Me.textMaximo.Location = New System.Drawing.Point(64, 70)
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
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(131, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(149, 18)
        Me.Label27.TabIndex = 26
        Me.Label27.Text = "ExisteApartado:"
        '
        'textExistencias
        '
        Me.textExistencias.Location = New System.Drawing.Point(74, 14)
        Me.textExistencias.Name = "textExistencias"
        Me.textExistencias.ReadOnly = True
        Me.textExistencias.Size = New System.Drawing.Size(54, 20)
        Me.textExistencias.TabIndex = 25
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(67, 18)
        Me.Label25.TabIndex = 24
        Me.Label25.Text = "Existe:"
        '
        'dgDatosCompra
        '
        Me.dgDatosCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatosCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.IdProducto, Me.Nombre, Me.Cantidad, Me.CsotoCompra, Me.SubTotal})
        Me.dgDatosCompra.Location = New System.Drawing.Point(9, 283)
        Me.dgDatosCompra.Name = "dgDatosCompra"
        Me.dgDatosCompra.ReadOnly = True
        Me.dgDatosCompra.Size = New System.Drawing.Size(700, 226)
        Me.dgDatosCompra.TabIndex = 11
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
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(718, 481)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(97, 28)
        Me.btnNuevo.TabIndex = 35
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(832, 481)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 28)
        Me.btnGuardar.TabIndex = 36
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'textIdCompraC
        '
        Me.textIdCompraC.Location = New System.Drawing.Point(120, 8)
        Me.textIdCompraC.Name = "textIdCompraC"
        Me.textIdCompraC.Size = New System.Drawing.Size(121, 20)
        Me.textIdCompraC.TabIndex = 37
        '
        'frmCompraProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 532)
        Me.Controls.Add(Me.textIdCompraC)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.gruopProducto)
        Me.Controls.Add(Me.grupProveedores)
        Me.Controls.Add(Me.textTotal)
        Me.Controls.Add(Me.textIva)
        Me.Controls.Add(Me.textSubTotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgDatosCompra)
        Me.Controls.Add(Me.textFactura)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.grupProveedor)
        Me.Controls.Add(Me.dateFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmCompraProducto"
        Me.Text = "frmCompraProducto"
        Me.grupProveedor.ResumeLayout(False)
        Me.grupProveedor.PerformLayout()
        Me.grupProveedores.ResumeLayout(False)
        Me.grupProveedores.PerformLayout()
        CType(Me.dgDatosProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gruopProducto.ResumeLayout(False)
        Me.gruopProducto.PerformLayout()
        CType(Me.dgDatosProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDatosCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dateFecha As DateTimePicker
    Friend WithEvents grupProveedor As GroupBox
    Friend WithEvents textTelefonoP As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents textCallep As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents textRfcP As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents textIdProveedor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents textCostoAnterio As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents textFactura As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents textSubTotal As TextBox
    Friend WithEvents textIva As TextBox
    Friend WithEvents textTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents textNombreP As TextBox
    Friend WithEvents textColoniaP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grupProveedores As GroupBox
    Friend WithEvents txtBuscarProveedor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgDatosProveedores As DataGridView
    Friend WithEvents IdProveedorp As DataGridViewTextBoxColumn
    Friend WithEvents NombreP As DataGridViewTextBoxColumn
    Friend WithEvents RFC As DataGridViewTextBoxColumn
    Friend WithEvents Calle As DataGridViewTextBoxColumn
    Friend WithEvents Colonia As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents btnAceptar As Button
    Friend WithEvents textNombreProveedor As TextBox
    Friend WithEvents textTelefonoProveedores As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textRfcProveedores As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents gruopProducto As GroupBox
    Friend WithEvents textBuscarProducto As TextBox
    Friend WithEvents Label17 As Label
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
    Friend WithEvents textCosto As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents textTalla As TextBox
    Friend WithEvents textMaximo As TextBox
    Friend WithEvents textMinimo As TextBox
    Friend WithEvents textExistenciaA As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents textExistencias As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents dgDatosCompra As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents textProductoId As TextBox
    Friend WithEvents textProductoNombre As TextBox
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents IdProducto As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents CsotoCompra As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents textIdCompraC As TextBox
End Class
