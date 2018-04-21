<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaApartado
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgDatos = New System.Windows.Forms.DataGridView()
        Me.textSaldar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textTotal = New System.Windows.Forms.TextBox()
        Me.textAbonos = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgApartados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgApartados
        '
        Me.dgApartados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgApartados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Cliente, Me.FechaApartado, Me.FechaLimite, Me.SubtotalA, Me.Iva, Me.TotalA, Me.Estado})
        Me.dgApartados.Location = New System.Drawing.Point(12, 38)
        Me.dgApartados.Name = "dgApartados"
        Me.dgApartados.Size = New System.Drawing.Size(823, 180)
        Me.dgApartados.TabIndex = 24
        '
        'Id
        '
        Me.Id.FillWeight = 60.0!
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.Width = 60
        '
        'Cliente
        '
        Me.Cliente.FillWeight = 200.0!
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Width = 200
        '
        'FechaApartado
        '
        Me.FechaApartado.FillWeight = 120.0!
        Me.FechaApartado.HeaderText = "Fecha Apartado"
        Me.FechaApartado.Name = "FechaApartado"
        Me.FechaApartado.Width = 120
        '
        'FechaLimite
        '
        Me.FechaLimite.HeaderText = "Fecha Limite"
        Me.FechaLimite.Name = "FechaLimite"
        '
        'SubtotalA
        '
        Me.SubtotalA.HeaderText = "Subtotal"
        Me.SubtotalA.Name = "SubtotalA"
        '
        'Iva
        '
        Me.Iva.HeaderText = "Iva"
        Me.Iva.Name = "Iva"
        '
        'TotalA
        '
        Me.TotalA.HeaderText = "Total"
        Me.TotalA.Name = "TotalA"
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'txtBus
        '
        Me.txtBus.Location = New System.Drawing.Point(441, 12)
        Me.txtBus.Name = "txtBus"
        Me.txtBus.Size = New System.Drawing.Size(394, 20)
        Me.txtBus.TabIndex = 25
        Me.txtBus.Text = "  "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(274, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Buscar Apartado:"
        '
        'dgDatos
        '
        Me.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.Nombre, Me.Cantidad, Me.Precio, Me.Importe})
        Me.dgDatos.Location = New System.Drawing.Point(12, 243)
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(596, 201)
        Me.dgDatos.TabIndex = 31
        '
        'textSaldar
        '
        Me.textSaldar.Location = New System.Drawing.Point(726, 295)
        Me.textSaldar.Name = "textSaldar"
        Me.textSaldar.ReadOnly = True
        Me.textSaldar.Size = New System.Drawing.Size(109, 20)
        Me.textSaldar.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(614, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 18)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Saldar con:"
        '
        'textTotal
        '
        Me.textTotal.Location = New System.Drawing.Point(726, 269)
        Me.textTotal.Name = "textTotal"
        Me.textTotal.ReadOnly = True
        Me.textTotal.Size = New System.Drawing.Size(109, 20)
        Me.textTotal.TabIndex = 41
        '
        'textAbonos
        '
        Me.textAbonos.Location = New System.Drawing.Point(726, 243)
        Me.textAbonos.Name = "textAbonos"
        Me.textAbonos.ReadOnly = True
        Me.textAbonos.Size = New System.Drawing.Size(109, 20)
        Me.textAbonos.TabIndex = 40
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(661, 269)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 18)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Total:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(628, 245)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 18)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Abonado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Estato:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Espera", "Pagado"})
        Me.ComboBox1.Location = New System.Drawing.Point(88, 10)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(180, 21)
        Me.ComboBox1.TabIndex = 51
        '
        'no
        '
        Me.no.FillWeight = 60.0!
        Me.no.HeaderText = "No"
        Me.no.Name = "no"
        Me.no.Width = 60
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        '
        'frmConsultaApartado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 456)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textSaldar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgDatos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBus)
        Me.Controls.Add(Me.textTotal)
        Me.Controls.Add(Me.dgApartados)
        Me.Controls.Add(Me.textAbonos)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Name = "frmConsultaApartado"
        Me.Text = "frmConsultaApartados"
        CType(Me.dgApartados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgApartados As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents FechaApartado As DataGridViewTextBoxColumn
    Friend WithEvents FechaLimite As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalA As DataGridViewTextBoxColumn
    Friend WithEvents Iva As DataGridViewTextBoxColumn
    Friend WithEvents TotalA As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents txtBus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgDatos As DataGridView
    Friend WithEvents textSaldar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents textTotal As TextBox
    Friend WithEvents textAbonos As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
End Class
