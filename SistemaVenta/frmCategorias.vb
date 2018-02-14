Public Class frmCategorias
    Private Sub campActi(ByVal ban As Boolean)
        textNombre.Enabled = ban
        textDescripcion.Enabled = ban
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        campActi(True)
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
        textIdCategoria.Text = CategoriasBindingSource.Count + 1
        CategoriasBindingSource.AddNew()
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlClient.SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated
        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf & e.Row.Item("NOMBRE", DataRowVersion.Original) & vbCrLf & e.Row.Item("NOMBRE", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub

    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TiendaRopaDataSet.Categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.TiendaRopaDataSet.Categorias)
        campActi(False)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        campActi(False)
        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
        CategoriasBindingSource.Current(0) = CInt(textIdCategoria.Text)
        CategoriasBindingSource.Current(1) = textNombre.Text
        CategoriasBindingSource.Current(2) = textDescripcion.Text
        CategoriasBindingSource.EndEdit()
        SqlDataAdapter1.Update(TiendaRopaDataSet.Categorias)
        TiendaRopaDataSet.Clear()
        SqlDataAdapter1.Fill(TiendaRopaDataSet.Categorias)
        dgDatos.Refresh()
    End Sub


End Class