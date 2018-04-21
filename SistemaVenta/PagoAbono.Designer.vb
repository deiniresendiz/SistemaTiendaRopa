<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagoAbono
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgDatos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.textSaldar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fechaApartadoF = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textTotal = New System.Windows.Forms.TextBox()
        Me.textAbonos = New System.Windows.Forms.TextBox()
        Me.textCliente = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgApartados = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaApartado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaLimite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBus = New System.Windows.Forms.TextBox()
        Me.fechaApartadoI = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textIdApartado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textAbono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.textIdAbono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FechaAbono = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textSaldoNuevo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProductoDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgApartados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgDatos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(630, 228)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Apartado"
        '
        'dgDatos
        '
        Me.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.IdProductoDetalle, Me.Nombre, Me.Cantidad, Me.Precio, Me.Importe})
        Me.dgDatos.Location = New System.Drawing.Point(6, 21)
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.ReadOnly = True
        Me.dgDatos.Size = New System.Drawing.Size(618, 201)
        Me.dgDatos.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.textSaldar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.fechaApartadoF)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.textTotal)
        Me.GroupBox1.Controls.Add(Me.textAbonos)
        Me.GroupBox1.Controls.Add(Me.textCliente)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.dgApartados)
        Me.GroupBox1.Controls.Add(Me.txtBus)
        Me.GroupBox1.Controls.Add(Me.fechaApartadoI)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.textIdApartado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(833, 203)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Apartado"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 122)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 18)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Abonado:"
        '
        'textSaldar
        '
        Me.textSaldar.Location = New System.Drawing.Point(118, 175)
        Me.textSaldar.Name = "textSaldar"
        Me.textSaldar.ReadOnly = True
        Me.textSaldar.Size = New System.Drawing.Size(109, 20)
        Me.textSaldar.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 18)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Saldar con:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Cliente:"
        '
        'fechaApartadoF
        '
        Me.fechaApartadoF.Enabled = False
        Me.fechaApartadoF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaApartadoF.Location = New System.Drawing.Point(118, 97)
        Me.fechaApartadoF.Name = "fechaApartadoF"
        Me.fechaApartadoF.Size = New System.Drawing.Size(109, 20)
        Me.fechaApartadoF.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 18)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "F Limite:"
        '
        'textTotal
        '
        Me.textTotal.Location = New System.Drawing.Point(118, 149)
        Me.textTotal.Name = "textTotal"
        Me.textTotal.ReadOnly = True
        Me.textTotal.Size = New System.Drawing.Size(109, 20)
        Me.textTotal.TabIndex = 41
        '
        'textAbonos
        '
        Me.textAbonos.Location = New System.Drawing.Point(118, 123)
        Me.textAbonos.Name = "textAbonos"
        Me.textAbonos.ReadOnly = True
        Me.textAbonos.Size = New System.Drawing.Size(109, 20)
        Me.textAbonos.TabIndex = 40
        '
        'textCliente
        '
        Me.textCliente.Location = New System.Drawing.Point(115, 71)
        Me.textCliente.Name = "textCliente"
        Me.textCliente.ReadOnly = True
        Me.textCliente.Size = New System.Drawing.Size(112, 20)
        Me.textCliente.TabIndex = 39
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(53, 149)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 18)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Total:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(-1, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 18)
        Me.Label12.TabIndex = 36
        '
        'dgApartados
        '
        Me.dgApartados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgApartados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Cliente, Me.FechaApartado, Me.FechaLimite, Me.SubtotalA, Me.Iva, Me.TotalA, Me.Estado})
        Me.dgApartados.Location = New System.Drawing.Point(233, 44)
        Me.dgApartados.Name = "dgApartados"
        Me.dgApartados.ReadOnly = True
        Me.dgApartados.Size = New System.Drawing.Size(594, 150)
        Me.dgApartados.TabIndex = 24
        '
        'Id
        '
        Me.Id.FillWeight = 60.0!
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 60
        '
        'Cliente
        '
        Me.Cliente.FillWeight = 200.0!
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 200
        '
        'FechaApartado
        '
        Me.FechaApartado.FillWeight = 120.0!
        Me.FechaApartado.HeaderText = "Fecha Apartado"
        Me.FechaApartado.Name = "FechaApartado"
        Me.FechaApartado.ReadOnly = True
        Me.FechaApartado.Width = 120
        '
        'FechaLimite
        '
        Me.FechaLimite.HeaderText = "Fecha Limite"
        Me.FechaLimite.Name = "FechaLimite"
        Me.FechaLimite.ReadOnly = True
        '
        'SubtotalA
        '
        Me.SubtotalA.HeaderText = "Subtotal"
        Me.SubtotalA.Name = "SubtotalA"
        Me.SubtotalA.ReadOnly = True
        '
        'Iva
        '
        Me.Iva.HeaderText = "Iva"
        Me.Iva.Name = "Iva"
        Me.Iva.ReadOnly = True
        '
        'TotalA
        '
        Me.TotalA.HeaderText = "Total"
        Me.TotalA.Name = "TotalA"
        Me.TotalA.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'txtBus
        '
        Me.txtBus.Location = New System.Drawing.Point(555, 19)
        Me.txtBus.Name = "txtBus"
        Me.txtBus.Size = New System.Drawing.Size(270, 20)
        Me.txtBus.TabIndex = 25
        Me.txtBus.Text = "  "
        '
        'fechaApartadoI
        '
        Me.fechaApartadoI.Enabled = False
        Me.fechaApartadoI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaApartadoI.Location = New System.Drawing.Point(115, 45)
        Me.fechaApartadoI.Name = "fechaApartadoI"
        Me.fechaApartadoI.Size = New System.Drawing.Size(112, 20)
        Me.fechaApartadoI.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(388, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Buscar Apartado:"
        '
        'textIdApartado
        '
        Me.textIdApartado.Location = New System.Drawing.Point(127, 18)
        Me.textIdApartado.Name = "textIdApartado"
        Me.textIdApartado.ReadOnly = True
        Me.textIdApartado.Size = New System.Drawing.Size(100, 20)
        Me.textIdApartado.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 18)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "IdApartado:"
        '
        'textAbono
        '
        Me.textAbono.Location = New System.Drawing.Point(746, 269)
        Me.textAbono.Name = "textAbono"
        Me.textAbono.Size = New System.Drawing.Size(99, 20)
        Me.textAbono.TabIndex = 43
        Me.textAbono.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(670, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Abono:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(770, 415)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 49
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(665, 415)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 48
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'textIdAbono
        '
        Me.textIdAbono.Location = New System.Drawing.Point(109, 7)
        Me.textIdAbono.Name = "textIdAbono"
        Me.textIdAbono.ReadOnly = True
        Me.textIdAbono.Size = New System.Drawing.Size(100, 20)
        Me.textIdAbono.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 18)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "IdAbono:"
        '
        'FechaAbono
        '
        Me.FechaAbono.Enabled = False
        Me.FechaAbono.Location = New System.Drawing.Point(512, 7)
        Me.FechaAbono.Name = "FechaAbono"
        Me.FechaAbono.Size = New System.Drawing.Size(200, 20)
        Me.FechaAbono.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(440, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 18)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Fecha:"
        '
        'textSaldoNuevo
        '
        Me.textSaldoNuevo.Location = New System.Drawing.Point(746, 307)
        Me.textSaldoNuevo.Name = "textSaldoNuevo"
        Me.textSaldoNuevo.ReadOnly = True
        Me.textSaldoNuevo.Size = New System.Drawing.Size(99, 20)
        Me.textSaldoNuevo.TabIndex = 47
        Me.textSaldoNuevo.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(648, 309)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 18)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Restante:"
        '
        'no
        '
        Me.no.FillWeight = 60.0!
        Me.no.HeaderText = "No"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 60
        '
        'IdProductoDetalle
        '
        Me.IdProductoDetalle.HeaderText = "Id"
        Me.IdProductoDetalle.Name = "IdProductoDetalle"
        Me.IdProductoDetalle.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'PagoAbono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 480)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.textSaldoNuevo)
        Me.Controls.Add(Me.FechaAbono)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.textIdAbono)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.textAbono)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PagoAbono"
        Me.Text = "PagoAbono"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgApartados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgDatos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents fechaApartadoF As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents textTotal As TextBox
    Friend WithEvents textAbonos As TextBox
    Friend WithEvents textCliente As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dgApartados As DataGridView
    Friend WithEvents txtBus As TextBox
    Friend WithEvents fechaApartadoI As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents textIdApartado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents textAbono As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents textIdAbono As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents FechaAbono As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents textSaldar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents textSaldoNuevo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents FechaApartado As DataGridViewTextBoxColumn
    Friend WithEvents FechaLimite As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalA As DataGridViewTextBoxColumn
    Friend WithEvents Iva As DataGridViewTextBoxColumn
    Friend WithEvents TotalA As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Label13 As Label
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents IdProductoDetalle As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
End Class
