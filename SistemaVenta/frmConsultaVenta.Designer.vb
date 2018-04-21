<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultaVenta
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
        Me.dgVentas = New System.Windows.Forms.DataGridView()
        Me.IdVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVentaV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgDetalleVenta = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.textBusVenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgVentas
        '
        Me.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdVenta, Me.Folio, Me.NombreC, Me.FechaVentaV, Me.SubtotalV, Me.IvaC, Me.TotalV, Me.Empleado, Me.Estado})
        Me.dgVentas.Location = New System.Drawing.Point(12, 50)
        Me.dgVentas.Name = "dgVentas"
        Me.dgVentas.Size = New System.Drawing.Size(746, 153)
        Me.dgVentas.TabIndex = 25
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
        'NombreC
        '
        Me.NombreC.HeaderText = "Nombre"
        Me.NombreC.Name = "NombreC"
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
        'dgDetalleVenta
        '
        Me.dgDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalleVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.idProducto, Me.Nombre, Me.Categoria, Me.Cantidad, Me.Precio, Me.SubTotal})
        Me.dgDetalleVenta.Location = New System.Drawing.Point(12, 226)
        Me.dgDetalleVenta.Name = "dgDetalleVenta"
        Me.dgDetalleVenta.Size = New System.Drawing.Size(746, 201)
        Me.dgDetalleVenta.TabIndex = 31
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
        'textBusVenta
        '
        Me.textBusVenta.Location = New System.Drawing.Point(281, 12)
        Me.textBusVenta.Name = "textBusVenta"
        Me.textBusVenta.Size = New System.Drawing.Size(330, 20)
        Me.textBusVenta.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(144, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 18)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Buscar Venta:"
        '
        'frmConsultaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 450)
        Me.Controls.Add(Me.textBusVenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgDetalleVenta)
        Me.Controls.Add(Me.dgVentas)
        Me.Name = "frmConsultaVenta"
        Me.Text = "frmConsultaVenta"
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgVentas As DataGridView
    Friend WithEvents IdVenta As DataGridViewTextBoxColumn
    Friend WithEvents Folio As DataGridViewTextBoxColumn
    Friend WithEvents NombreC As DataGridViewTextBoxColumn
    Friend WithEvents FechaVentaV As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalV As DataGridViewTextBoxColumn
    Friend WithEvents IvaC As DataGridViewTextBoxColumn
    Friend WithEvents TotalV As DataGridViewTextBoxColumn
    Friend WithEvents Empleado As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents dgDetalleVenta As DataGridView
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents idProducto As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents textBusVenta As TextBox
    Friend WithEvents Label3 As Label
End Class
