Public Class frmProveedores
    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TiendaRopaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.TiendaRopaDataSet.Proveedores)
        campAct(False)
    End Sub
    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlClient.SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated
        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message)
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub
    Sub campAct(ByVal ban As Boolean)
        textIdProveedor.Enabled = ban
        textNombre.Enabled = ban
        textRfc.Enabled = ban
        textDomicilio.Enabled = ban
        textColonia.Enabled = ban
        textCp.Enabled = ban
        textTelefono.Enabled = ban
        btnGuardar.Enabled = ban
        btnNuevo.Enabled = Not ban
        btnModificar.Enabled = Not ban
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ProveedoresBindingSource.AddNew()
        textIdProveedor.Text = ProveedoresBindingSource.Count + 1
        campAct(True)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        campAct(True)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        campAct(False)
        Try
            ProveedoresBindingSource.EndEdit()
            SqlDataAdapter1.Update(TiendaRopaDataSet.Proveedores)
            TiendaRopaDataSet.Clear()
            SqlDataAdapter1.Fill(TiendaRopaDataSet.Proveedores)
        Catch ex As Exception
            MessageBox.Show("Tabla bloqueada")
        End Try
        TiendaRopaDataSet.Clear()
        SqlDataAdapter1.Fill(TiendaRopaDataSet.Proveedores)
    End Sub
End Class