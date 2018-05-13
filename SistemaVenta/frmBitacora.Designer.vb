<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBitacora
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
        Me.dgDatos = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumError = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Formulario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaError = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDatos
        '
        Me.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.NumError, Me.Descripcion, Me.Formulario, Me.FechaError})
        Me.dgDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDatos.Location = New System.Drawing.Point(0, 0)
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.ReadOnly = True
        Me.dgDatos.Size = New System.Drawing.Size(800, 450)
        Me.dgDatos.TabIndex = 0
        '
        'No
        '
        Me.No.FillWeight = 50.0!
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 50
        '
        'NumError
        '
        Me.NumError.HeaderText = "Numero Error"
        Me.NumError.Name = "NumError"
        Me.NumError.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.FillWeight = 300.0!
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 300
        '
        'Formulario
        '
        Me.Formulario.FillWeight = 150.0!
        Me.Formulario.HeaderText = "Formulario"
        Me.Formulario.Name = "Formulario"
        Me.Formulario.ReadOnly = True
        Me.Formulario.Width = 150
        '
        'FechaError
        '
        Me.FechaError.FillWeight = 200.0!
        Me.FechaError.HeaderText = "Fecha de Error"
        Me.FechaError.Name = "FechaError"
        Me.FechaError.ReadOnly = True
        Me.FechaError.Width = 200
        '
        'frmBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgDatos)
        Me.Name = "frmBitacora"
        Me.Text = "Bitacora"
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgDatos As DataGridView
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents NumError As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Formulario As DataGridViewTextBoxColumn
    Friend WithEvents FechaError As DataGridViewTextBoxColumn
End Class
