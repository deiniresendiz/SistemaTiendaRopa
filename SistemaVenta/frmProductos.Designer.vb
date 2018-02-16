<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Me.textMinimo = New System.Windows.Forms.TextBox()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiendaRopaDataSet = New SistemaVenta.TiendaRopaDataSet()
        Me.textMaximo = New System.Windows.Forms.TextBox()
        Me.textExistencia = New System.Windows.Forms.TextBox()
        Me.textTalla = New System.Windows.Forms.TextBox()
        Me.textDescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fufu = New System.Windows.Forms.Label()
        Me.textIdProducto = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TallaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExisstenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaximoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinimoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltFecCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.comCategoria = New System.Windows.Forms.ComboBox()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.ProductosTableAdapter = New SistemaVenta.TiendaRopaDataSetTableAdapters.ProductosTableAdapter()
        Me.CategoriasTableAdapter = New SistemaVenta.TiendaRopaDataSetTableAdapters.CategoriasTableAdapter()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.textCosto = New System.Windows.Forms.TextBox()
        Me.textPrecio = New System.Windows.Forms.TextBox()
        Me.DataFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand = New System.Data.SqlClient.SqlCommand()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiendaRopaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textMinimo
        '
        Me.textMinimo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Minimo", True))
        Me.textMinimo.Location = New System.Drawing.Point(519, 80)
        Me.textMinimo.Name = "textMinimo"
        Me.textMinimo.Size = New System.Drawing.Size(194, 20)
        Me.textMinimo.TabIndex = 35
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.TiendaRopaDataSet
        '
        'TiendaRopaDataSet
        '
        Me.TiendaRopaDataSet.DataSetName = "TiendaRopaDataSet"
        Me.TiendaRopaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'textMaximo
        '
        Me.textMaximo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Maximo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.textMaximo.Location = New System.Drawing.Point(519, 50)
        Me.textMaximo.Name = "textMaximo"
        Me.textMaximo.Size = New System.Drawing.Size(194, 20)
        Me.textMaximo.TabIndex = 34
        '
        'textExistencia
        '
        Me.textExistencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Exisstencia", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.textExistencia.Location = New System.Drawing.Point(124, 170)
        Me.textExistencia.Name = "textExistencia"
        Me.textExistencia.Size = New System.Drawing.Size(255, 20)
        Me.textExistencia.TabIndex = 33
        '
        'textTalla
        '
        Me.textTalla.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Talla", True))
        Me.textTalla.Location = New System.Drawing.Point(124, 141)
        Me.textTalla.Name = "textTalla"
        Me.textTalla.Size = New System.Drawing.Size(255, 20)
        Me.textTalla.TabIndex = 32
        '
        'textDescripcion
        '
        Me.textDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Descripcion", True))
        Me.textDescripcion.Location = New System.Drawing.Point(124, 112)
        Me.textDescripcion.Name = "textDescripcion"
        Me.textDescripcion.Size = New System.Drawing.Size(255, 20)
        Me.textDescripcion.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(435, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 18)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Maximo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Existencias:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(441, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Minimo:"
        '
        'textNombre
        '
        Me.textNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Nombre", True))
        Me.textNombre.Location = New System.Drawing.Point(124, 81)
        Me.textNombre.Name = "textNombre"
        Me.textNombre.Size = New System.Drawing.Size(255, 20)
        Me.textNombre.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 18)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Descripcion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Talla:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nombre:"
        '
        'fufu
        '
        Me.fufu.AutoSize = True
        Me.fufu.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fufu.Location = New System.Drawing.Point(6, 20)
        Me.fufu.Name = "fufu"
        Me.fufu.Size = New System.Drawing.Size(105, 18)
        Me.fufu.TabIndex = 23
        Me.fufu.Text = "IdProducto:"
        '
        'textIdProducto
        '
        Me.textIdProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "IdProducto", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.textIdProducto.Location = New System.Drawing.Point(124, 21)
        Me.textIdProducto.Name = "textIdProducto"
        Me.textIdProducto.ReadOnly = True
        Me.textIdProducto.Size = New System.Drawing.Size(100, 20)
        Me.textIdProducto.TabIndex = 22
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(438, 436)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(127, 38)
        Me.btnGuardar.TabIndex = 21
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(606, 436)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(127, 38)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(13, 436)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(127, 38)
        Me.btnNuevo.TabIndex = 19
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.IdCategoriaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.TallaDataGridViewTextBoxColumn, Me.ExisstenciaDataGridViewTextBoxColumn, Me.MaximoDataGridViewTextBoxColumn, Me.MinimoDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.UltFecCompraDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 231)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(720, 195)
        Me.DataGridView1.TabIndex = 18
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCategoriaDataGridViewTextBoxColumn
        '
        Me.IdCategoriaDataGridViewTextBoxColumn.DataPropertyName = "IdCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.HeaderText = "IdCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.Name = "IdCategoriaDataGridViewTextBoxColumn"
        Me.IdCategoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TallaDataGridViewTextBoxColumn
        '
        Me.TallaDataGridViewTextBoxColumn.DataPropertyName = "Talla"
        Me.TallaDataGridViewTextBoxColumn.HeaderText = "Talla"
        Me.TallaDataGridViewTextBoxColumn.Name = "TallaDataGridViewTextBoxColumn"
        Me.TallaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExisstenciaDataGridViewTextBoxColumn
        '
        Me.ExisstenciaDataGridViewTextBoxColumn.DataPropertyName = "Exisstencia"
        Me.ExisstenciaDataGridViewTextBoxColumn.HeaderText = "Exisstencia"
        Me.ExisstenciaDataGridViewTextBoxColumn.Name = "ExisstenciaDataGridViewTextBoxColumn"
        Me.ExisstenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaximoDataGridViewTextBoxColumn
        '
        Me.MaximoDataGridViewTextBoxColumn.DataPropertyName = "Maximo"
        Me.MaximoDataGridViewTextBoxColumn.HeaderText = "Maximo"
        Me.MaximoDataGridViewTextBoxColumn.Name = "MaximoDataGridViewTextBoxColumn"
        Me.MaximoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MinimoDataGridViewTextBoxColumn
        '
        Me.MinimoDataGridViewTextBoxColumn.DataPropertyName = "Minimo"
        Me.MinimoDataGridViewTextBoxColumn.HeaderText = "Minimo"
        Me.MinimoDataGridViewTextBoxColumn.Name = "MinimoDataGridViewTextBoxColumn"
        Me.MinimoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "Costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UltFecCompraDataGridViewTextBoxColumn
        '
        Me.UltFecCompraDataGridViewTextBoxColumn.DataPropertyName = "UltFecCompra"
        Me.UltFecCompraDataGridViewTextBoxColumn.HeaderText = "UltFecCompra"
        Me.UltFecCompraDataGridViewTextBoxColumn.Name = "UltFecCompraDataGridViewTextBoxColumn"
        Me.UltFecCompraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 18)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Categoria:"
        '
        'comCategoria
        '
        Me.comCategoria.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "IdCategoria", True))
        Me.comCategoria.DataSource = Me.CategoriasBindingSource
        Me.comCategoria.DisplayMember = "Nombre"
        Me.comCategoria.FormattingEnabled = True
        Me.comCategoria.Location = New System.Drawing.Point(124, 53)
        Me.comCategoria.Name = "comCategoria"
        Me.comCategoria.Size = New System.Drawing.Size(255, 21)
        Me.comCategoria.TabIndex = 37
        Me.comCategoria.ValueMember = "IdCategoria"
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "Categorias"
        Me.CategoriasBindingSource.DataSource = Me.TiendaRopaDataSet
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        Productos.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Productos"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=DESKTOP-NC9ERBN;Initial Catalog=TiendaRopa;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Productos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdProducto", "IdProducto"), New System.Data.Common.DataColumnMapping("IdCategoria", "IdCategoria"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Talla", "Talla"), New System.Data.Common.DataColumnMapping("Exisstencia", "Exisstencia"), New System.Data.Common.DataColumnMapping("Maximo", "Maximo"), New System.Data.Common.DataColumnMapping("Minimo", "Minimo"), New System.Data.Common.DataColumnMapping("Costo", "Costo"), New System.Data.Common.DataColumnMapping("Precio", "Precio"), New System.Data.Common.DataColumnMapping("UltFecCompra", "UltFecCompra")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(452, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 18)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Costo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(397, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 18)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Ultima fecha:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(449, 140)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 18)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Precio:"
        '
        'textCosto
        '
        Me.textCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Costo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"))
        Me.textCosto.Location = New System.Drawing.Point(519, 112)
        Me.textCosto.Name = "textCosto"
        Me.textCosto.Size = New System.Drawing.Size(194, 20)
        Me.textCosto.TabIndex = 41
        '
        'textPrecio
        '
        Me.textPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Precio", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"))
        Me.textPrecio.Location = New System.Drawing.Point(519, 141)
        Me.textPrecio.Name = "textPrecio"
        Me.textPrecio.Size = New System.Drawing.Size(194, 20)
        Me.textPrecio.TabIndex = 42
        '
        'DataFecha
        '
        Me.DataFecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductosBindingSource, "UltFecCompra", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.DataFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataFecha.Location = New System.Drawing.Point(519, 169)
        Me.DataFecha.Name = "DataFecha"
        Me.DataFecha.Size = New System.Drawing.Size(194, 20)
        Me.DataFecha.TabIndex = 43
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(231, 436)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(127, 38)
        Me.btnModificar.TabIndex = 44
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'SqlInsertCommand
        '
        Me.SqlInsertCommand.CommandText = resources.GetString("SqlInsertCommand.CommandText")
        Me.SqlInsertCommand.Connection = Me.SqlConnection1
        Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdProducto", System.Data.SqlDbType.Int, 0, "IdProducto"), New System.Data.SqlClient.SqlParameter("@IdCategoria", System.Data.SqlDbType.Int, 0, "IdCategoria"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 0, "Nombre"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 0, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Talla", System.Data.SqlDbType.VarChar, 0, "Talla"), New System.Data.SqlClient.SqlParameter("@Exisstencia", System.Data.SqlDbType.Int, 0, "Exisstencia"), New System.Data.SqlClient.SqlParameter("@Maximo", System.Data.SqlDbType.Int, 0, "Maximo"), New System.Data.SqlClient.SqlParameter("@Minimo", System.Data.SqlDbType.Int, 0, "Minimo"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Money, 0, "Costo"), New System.Data.SqlClient.SqlParameter("@Precio", System.Data.SqlDbType.Money, 0, "Precio"), New System.Data.SqlClient.SqlParameter("@UltFecCompra", System.Data.SqlDbType.[Date], 0, "UltFecCompra")})
        '
        'SqlUpdateCommand
        '
        Me.SqlUpdateCommand.CommandText = resources.GetString("SqlUpdateCommand.CommandText")
        Me.SqlUpdateCommand.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdProducto", System.Data.SqlDbType.Int, 0, "IdProducto"), New System.Data.SqlClient.SqlParameter("@IdCategoria", System.Data.SqlDbType.Int, 0, "IdCategoria"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 0, "Nombre"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 0, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Talla", System.Data.SqlDbType.VarChar, 0, "Talla"), New System.Data.SqlClient.SqlParameter("@Exisstencia", System.Data.SqlDbType.Int, 0, "Exisstencia"), New System.Data.SqlClient.SqlParameter("@Maximo", System.Data.SqlDbType.Int, 0, "Maximo"), New System.Data.SqlClient.SqlParameter("@Minimo", System.Data.SqlDbType.Int, 0, "Minimo"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Money, 0, "Costo"), New System.Data.SqlClient.SqlParameter("@Precio", System.Data.SqlDbType.Money, 0, "Precio"), New System.Data.SqlClient.SqlParameter("@UltFecCompra", System.Data.SqlDbType.[Date], 0, "UltFecCompra"), New System.Data.SqlClient.SqlParameter("@Original_IdProducto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdProducto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdCategoria", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCategoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Descripcion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Talla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Talla", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Talla", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Talla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Exisstencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Exisstencia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Exisstencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exisstencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Maximo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Maximo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Maximo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Maximo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Minimo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Minimo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Minimo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Minimo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Costo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Precio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Precio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Precio", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UltFecCompra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UltFecCompra", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UltFecCompra", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UltFecCompra", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand
        '
        Me.SqlDeleteCommand.CommandText = resources.GetString("SqlDeleteCommand.CommandText")
        Me.SqlDeleteCommand.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_IdProducto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdProducto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdCategoria", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCategoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Descripcion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Talla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Talla", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Talla", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Talla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Exisstencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Exisstencia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Exisstencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exisstencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Maximo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Maximo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Maximo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Maximo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Minimo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Minimo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Minimo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Minimo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Costo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Precio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Precio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Precio", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UltFecCompra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UltFecCompra", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UltFecCompra", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UltFecCompra", System.Data.DataRowVersion.Original, Nothing)})
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 494)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.DataFecha)
        Me.Controls.Add(Me.textPrecio)
        Me.Controls.Add(Me.textCosto)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.comCategoria)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.textMinimo)
        Me.Controls.Add(Me.textMaximo)
        Me.Controls.Add(Me.textExistencia)
        Me.Controls.Add(Me.textTalla)
        Me.Controls.Add(Me.textDescripcion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fufu)
        Me.Controls.Add(Me.textIdProducto)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmProductos"
        Me.Text = "Productos"
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiendaRopaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textMinimo As TextBox
    Friend WithEvents textMaximo As TextBox
    Friend WithEvents textExistencia As TextBox
    Friend WithEvents textTalla As TextBox
    Friend WithEvents textDescripcion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents textNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents fufu As Label
    Friend WithEvents textIdProducto As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents comCategoria As ComboBox
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents TiendaRopaDataSet As TiendaRopaDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As TiendaRopaDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TallaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExisstenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaximoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinimoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UltFecCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriasBindingSource As BindingSource
    Friend WithEvents CategoriasTableAdapter As TiendaRopaDataSetTableAdapters.CategoriasTableAdapter
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents textCosto As TextBox
    Friend WithEvents textPrecio As TextBox
    Friend WithEvents DataFecha As DateTimePicker
    Friend WithEvents btnModificar As Button
    Friend WithEvents SqlDeleteCommand As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand As SqlClient.SqlCommand
End Class
