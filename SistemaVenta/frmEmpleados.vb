Public Class frmEmpleados
    'Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    campActi(False)
    '    'TODO: esta línea de código carga datos en la tabla 'TiendaRopaDataSet1.Empleados' Puede moverla o quitarla según sea necesario.
    '    Me.EmpleadosTableAdapter.Fill(Me.TiendaRopaDataSet1.Empleados)

    'End Sub

    'Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
    '    EmpleadosTableAdapter.Update(TiendaRopaDataSet1.Empleados)
    '    Dispose()
    'End Sub

    'Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
    '    EmpleadosBindingSource.AddNew()
    '    textIdEmpleado.Text = EmpleadosBindingSource.Count + 1
    '    campActi(True)
    'End Sub
    'Private Sub campActi(ByVal ban As Boolean)
    '    textNombre.Enabled = ban
    '    textPuesto.Enabled = ban
    '    textDomicilio.Enabled = ban
    '    textColonia.Enabled = ban
    '    TextCp.Enabled = ban
    '    textTelefono.Enabled = ban
    '    btnGuardar.Enabled = ban
    '    btnNuevo.Enabled = Not ban
    '    btnModificar.Enabled = Not ban
    'End Sub

    'Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
    '    campActi(False)
    '    Try
    '        EmpleadosBindingSource.EndEdit()
    '        EmpleadosTableAdapter.Update(TiendaRopaDataSet1.Empleados)
    '        SqlDataAdapter1.Update(TiendaRopaDataSet1.Empleados)
    '        TiendaRopaDataSet1.Clear()
    '        SqlDataAdapter1.Fill(TiendaRopaDataSet1.Empleados)
    '    Catch ex As Exception
    '        MessageBox.Show("Tabla Bloqueada")
    '    End Try
    '    TiendaRopaDataSet1.Clear()
    '    SqlDataAdapter1.Fill(TiendaRopaDataSet1.Empleados)
    'End Sub
    'Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlClient.SqlRowUpdatedEventArgs) 
    '    If e.Status = UpdateStatus.ErrorsOccurred Then
    '        MessageBox.Show(e.Errors.Message)
    '        e.Status = UpdateStatus.SkipCurrentRow
    '    End If
    'End Sub

    'Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
    '    campActi(True)
    'End Sub
End Class