<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Me.textTelefono = New System.Windows.Forms.TextBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiendaRopaDataSet = New SistemaVenta.TiendaRopaDataSet()
        Me.textCp = New System.Windows.Forms.TextBox()
        Me.textColonia = New System.Windows.Forms.TextBox()
        Me.textDomicilio = New System.Windows.Forms.TextBox()
        Me.textRfc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textIdProveedor = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomicilioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColoniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.ProveedoresTableAdapter = New SistemaVenta.TiendaRopaDataSetTableAdapters.ProveedoresTableAdapter()
        Me.btnModificar = New System.Windows.Forms.Button()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiendaRopaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textTelefono
        '
        Me.textTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Telefono", True))
        Me.textTelefono.Location = New System.Drawing.Point(475, 104)
        Me.textTelefono.Name = "textTelefono"
        Me.textTelefono.Size = New System.Drawing.Size(255, 20)
        Me.textTelefono.TabIndex = 35
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.TiendaRopaDataSet
        '
        'TiendaRopaDataSet
        '
        Me.TiendaRopaDataSet.DataSetName = "TiendaRopaDataSet"
        Me.TiendaRopaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'textCp
        '
        Me.textCp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Cp", True))
        Me.textCp.Location = New System.Drawing.Point(475, 73)
        Me.textCp.Name = "textCp"
        Me.textCp.Size = New System.Drawing.Size(100, 20)
        Me.textCp.TabIndex = 34
        '
        'textColonia
        '
        Me.textColonia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Colonia", True))
        Me.textColonia.Location = New System.Drawing.Point(475, 43)
        Me.textColonia.Name = "textColonia"
        Me.textColonia.Size = New System.Drawing.Size(255, 20)
        Me.textColonia.TabIndex = 33
        '
        'textDomicilio
        '
        Me.textDomicilio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Domicilio", True))
        Me.textDomicilio.Location = New System.Drawing.Point(120, 102)
        Me.textDomicilio.Name = "textDomicilio"
        Me.textDomicilio.Size = New System.Drawing.Size(255, 20)
        Me.textDomicilio.TabIndex = 32
        '
        'textRfc
        '
        Me.textRfc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "RFC", True))
        Me.textRfc.Location = New System.Drawing.Point(120, 73)
        Me.textRfc.Name = "textRfc"
        Me.textRfc.Size = New System.Drawing.Size(255, 20)
        Me.textRfc.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(431, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 18)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "CP:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(396, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Colonia:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(383, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 18)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Telefono:"
        '
        'textNombre
        '
        Me.textNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Nombre", True))
        Me.textNombre.Location = New System.Drawing.Point(120, 42)
        Me.textNombre.Name = "textNombre"
        Me.textNombre.Size = New System.Drawing.Size(255, 20)
        Me.textNombre.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "RFC:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 18)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Domicilio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "IdProveedor:"
        '
        'textIdProveedor
        '
        Me.textIdProveedor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "IdProveedor", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.textIdProveedor.Location = New System.Drawing.Point(120, 16)
        Me.textIdProveedor.Name = "textIdProveedor"
        Me.textIdProveedor.ReadOnly = True
        Me.textIdProveedor.Size = New System.Drawing.Size(100, 20)
        Me.textIdProveedor.TabIndex = 22
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(399, 431)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(127, 38)
        Me.btnGuardar.TabIndex = 21
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(602, 431)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(127, 38)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(9, 431)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.RFCDataGridViewTextBoxColumn, Me.DomicilioDataGridViewTextBoxColumn, Me.ColoniaDataGridViewTextBoxColumn, Me.CpDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProveedoresBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 154)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(720, 267)
        Me.DataGridView1.TabIndex = 18
        '
        'IdProveedorDataGridViewTextBoxColumn
        '
        Me.IdProveedorDataGridViewTextBoxColumn.DataPropertyName = "IdProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.HeaderText = "IdProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.Name = "IdProveedorDataGridViewTextBoxColumn"
        Me.IdProveedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RFCDataGridViewTextBoxColumn
        '
        Me.RFCDataGridViewTextBoxColumn.DataPropertyName = "RFC"
        Me.RFCDataGridViewTextBoxColumn.HeaderText = "RFC"
        Me.RFCDataGridViewTextBoxColumn.Name = "RFCDataGridViewTextBoxColumn"
        Me.RFCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DomicilioDataGridViewTextBoxColumn
        '
        Me.DomicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.Name = "DomicilioDataGridViewTextBoxColumn"
        Me.DomicilioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ColoniaDataGridViewTextBoxColumn
        '
        Me.ColoniaDataGridViewTextBoxColumn.DataPropertyName = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.HeaderText = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.Name = "ColoniaDataGridViewTextBoxColumn"
        Me.ColoniaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CpDataGridViewTextBoxColumn
        '
        Me.CpDataGridViewTextBoxColumn.DataPropertyName = "Cp"
        Me.CpDataGridViewTextBoxColumn.HeaderText = "Cp"
        Me.CpDataGridViewTextBoxColumn.Name = "CpDataGridViewTextBoxColumn"
        Me.CpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        Proveedores.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Proveedores"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=DESKTOP-NC9ERBN;Initial Catalog=TiendaRopa;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdProveedor", System.Data.SqlDbType.Int, 0, "IdProveedor"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 0, "Nombre"), New System.Data.SqlClient.SqlParameter("@RFC", System.Data.SqlDbType.VarChar, 0, "RFC"), New System.Data.SqlClient.SqlParameter("@Domicilio", System.Data.SqlDbType.VarChar, 0, "Domicilio"), New System.Data.SqlClient.SqlParameter("@Colonia", System.Data.SqlDbType.VarChar, 0, "Colonia"), New System.Data.SqlClient.SqlParameter("@Cp", System.Data.SqlDbType.VarChar, 0, "Cp"), New System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 0, "Telefono")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdProveedor", System.Data.SqlDbType.Int, 0, "IdProveedor"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 0, "Nombre"), New System.Data.SqlClient.SqlParameter("@RFC", System.Data.SqlDbType.VarChar, 0, "RFC"), New System.Data.SqlClient.SqlParameter("@Domicilio", System.Data.SqlDbType.VarChar, 0, "Domicilio"), New System.Data.SqlClient.SqlParameter("@Colonia", System.Data.SqlDbType.VarChar, 0, "Colonia"), New System.Data.SqlClient.SqlParameter("@Cp", System.Data.SqlDbType.VarChar, 0, "Cp"), New System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 0, "Telefono"), New System.Data.SqlClient.SqlParameter("@Original_IdProveedor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdProveedor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RFC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RFC", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RFC", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RFC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Domicilio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Domicilio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Domicilio", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Domicilio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Colonia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Colonia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Colonia", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Colonia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Cp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Cp", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Cp", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cp", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Telefono", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_IdProveedor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdProveedor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_RFC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RFC", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_RFC", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RFC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Domicilio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Domicilio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Domicilio", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Domicilio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Colonia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Colonia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Colonia", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Colonia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Cp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Cp", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Cp", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cp", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Telefono", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Proveedores", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdProveedor", "IdProveedor"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("RFC", "RFC"), New System.Data.Common.DataColumnMapping("Domicilio", "Domicilio"), New System.Data.Common.DataColumnMapping("Colonia", "Colonia"), New System.Data.Common.DataColumnMapping("Cp", "Cp"), New System.Data.Common.DataColumnMapping("Telefono", "Telefono")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(211, 431)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(127, 38)
        Me.btnModificar.TabIndex = 51
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 484)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.textTelefono)
        Me.Controls.Add(Me.textCp)
        Me.Controls.Add(Me.textColonia)
        Me.Controls.Add(Me.textDomicilio)
        Me.Controls.Add(Me.textRfc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textIdProveedor)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmProveedores"
        Me.Text = "Proveedores"
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiendaRopaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textTelefono As TextBox
    Friend WithEvents textCp As TextBox
    Friend WithEvents textColonia As TextBox
    Friend WithEvents textDomicilio As TextBox
    Friend WithEvents textRfc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents textNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents textIdProveedor As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents TiendaRopaDataSet As TiendaRopaDataSet
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As TiendaRopaDataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RFCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomicilioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnModificar As Button
End Class
