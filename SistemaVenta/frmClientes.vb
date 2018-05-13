Public Class frmClientes
    Private Sub campActi(ByVal ban As Boolean)
        textNombre.Enabled = ban
        textApellidos.Enabled = ban
        textColonia.Enabled = ban
        textDomicilio.Enabled = ban
        textCp.Enabled = ban
        textTelefono.Enabled = ban
        btnGuardar.Enabled = ban
        btnNuevo.Enabled = Not ban
        btnModificar.Enabled = Not ban
    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DataSet1.Clientes)

    End Sub
    'Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'TODO: esta línea de código carga datos en la tabla 'TiendaRopaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
    '    Me.ClientesTableAdapter.Fill(Me.TiendaRopaDataSet.Clientes)
    '    campActi(False)
    'End Sub
    'Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlClient.SqlRowUpdatedEventArgs) 
    '    If e.Status = UpdateStatus.ErrorsOccurred Then
    '        MessageBox.Show(e.Errors.Message)
    '        e.Status = UpdateStatus.SkipCurrentRow
    '    End If
    'End Sub
    'Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
    '    Dispose()
    'End Sub

    'Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
    '    campActi(True)
    '    ClientesBindingSource.AddNew()
    '    textIdCliente.Text = ClientesBindingSource.Count + 1
    'End Sub

    'Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
    '    campActi(True)
    'End Sub

    'Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
    '    campActi(False)
    '    Try
    '        ClientesBindingSource.EndEdit()
    '        SqlDataAdapter1.Update(TiendaRopaDataSet.Clientes)
    '        TiendaRopaDataSet.Clear()
    '        SqlDataAdapter1.Fill(TiendaRopaDataSet.Clientes)
    '    Catch ex As Exception
    '        MessageBox.Show("tabla bloqueada")
    '    End Try
    '    TiendaRopaDataSet.Clear()
    '    SqlDataAdapter1.Fill(TiendaRopaDataSet.Clientes)
    'End Sub
End Class