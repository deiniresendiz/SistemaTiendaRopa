Public Class frmCategorias
    Private Sub campActi(ByVal ban As Boolean)
        textNombre.Enabled = ban
        textDescripcion.Enabled = ban
        btnGuardar.Enabled = ban
        btnModificar.Enabled = Not ban
        btnNuevo.Enabled = Not ban
    End Sub

    'Private Sub btnnuevo_click(sender As Object, e As EventArgs) Handles btnNuevo.Click
    '    campActi(True)
    '    categoriasbindingsource.addnew()
    '    textIdCategoria.Text = categoriasbindingsource.count + 1
    'End Sub

    'Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlClient.SqlRowUpdatedEventArgs)
    '    If e.Status = UpdateStatus.ErrorsOccurred Then
    '        MessageBox.Show(e.Errors.Message)
    '        e.Status = UpdateStatus.SkipCurrentRow
    '    End If
    'End Sub

    'Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'TODO: esta línea de código carga datos en la tabla 'SistemaRopaDataSet.Categorias' Puede moverla o quitarla según sea necesario.
    '    Me.CategoriasTableAdapter.Fill(Me.SistemaRopaDataSet.Categorias)
    '    'TODO: esta línea de código carga datos en la tabla 'TiendaRopaDataSet.Categorias' Puede moverla o quitarla según sea necesario.
    '    Me.CategoriasTableAdapter.Fill(Me.TiendaRopaDataSet.Categorias)
    '    campActi(False)
    'End Sub

    'Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
    '    campActi(False)
    '    Try
    '        CategoriasBindingSource.EndEdit()
    '        SqlDataAdapter1.Update(TiendaRopaDataSet.Categorias)
    '        TiendaRopaDataSet.Clear()
    '        SqlDataAdapter1.Fill(TiendaRopaDataSet.Categorias)
    '    Catch ex As Exception
    '        MessageBox.Show("Tabla bloqueada")
    '    End Try
    '    TiendaRopaDataSet.Clear()
    '    SqlDataAdapter1.Fill(TiendaRopaDataSet.Categorias)
    'End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        campActi(True)
    End Sub
End Class