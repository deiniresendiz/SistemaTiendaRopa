Public Class frmProductos
    'Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'TODO: esta línea de código carga datos en la tabla 'TiendaRopaDataSet.Categorias' Puede moverla o quitarla según sea necesario.
    '    Me.CategoriasTableAdapter.Fill(Me.TiendaRopaDataSet.Categorias)
    '    'TODO: esta línea de código carga datos en la tabla 'TiendaRopaDataSet.Productos' Puede moverla o quitarla según sea necesario.
    '    Me.ProductosTableAdapter.Fill(Me.TiendaRopaDataSet.Productos)
    '    DataFecha.Value = Date.Today
    '    campAct(False)
    'End Sub
    'Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlClient.SqlRowUpdatedEventArgs) 
    '    If e.Status = UpdateStatus.ErrorsOccurred Then
    '        MessageBox.Show(e.Errors.Message)
    '        e.Status = UpdateStatus.SkipCurrentRow
    '    End If
    'End Sub
    'Sub campAct(ByVal ban As Boolean)
    '    comCategoria.Enabled = ban
    '    textNombre.Enabled = ban
    '    textDescripcion.Enabled = ban
    '    textTalla.Enabled = ban
    '    textExistencia.Enabled = ban
    '    textMaximo.Enabled = ban
    '    textMinimo.Enabled = ban
    '    textCosto.Enabled = ban
    '    textPrecio.Enabled = ban
    '    DataFecha.Enabled = ban
    '    btnGuardar.Enabled = ban
    '    btnModificar.Enabled = Not ban
    '    btnNuevo.Enabled = Not ban
    'End Sub

    'Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
    '    ProductosBindingSource.AddNew()
    '    textIdProducto.Text = ProductosBindingSource.Count + 1
    '    campAct(True)
    'End Sub

    'Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
    '    campAct(True)
    'End Sub

    'Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
    '    campAct(False)
    '    Try
    '        ProductosBindingSource.EndEdit()
    '        SqlDataAdapter1.Update(TiendaRopaDataSet.Productos)
    '        TiendaRopaDataSet.Clear()
    '        SqlDataAdapter1.Fill(TiendaRopaDataSet.Productos)
    '    Catch ex As Exception
    '        MessageBox.Show("Tabla Bloqueada")
    '    End Try
    '    TiendaRopaDataSet.Clear()
    '    SqlDataAdapter1.Fill(TiendaRopaDataSet.Productos)
    'End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DataSet1.Productos)

    End Sub
End Class