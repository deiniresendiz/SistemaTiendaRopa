Public Class frmEmpleados
    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TiendaRopaDataSet1.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.TiendaRopaDataSet1.Empleados)
        campActi(False)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        EmpleadosTableAdapter.Update(TiendaRopaDataSet1.Empleados)
        Dispose()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        textIdEmpleado.Text = EmpleadosBindingSource.Count + 1
        EmpleadosBindingSource.AddNew()
        campActi(True)
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
    End Sub
    Private Sub campActi(ByVal ban As Boolean)
        textNombre.Enabled = ban
        textPuesto.Enabled = ban
        textDomicilio.Enabled = ban
        textColonia.Enabled = ban
        TextCp.Enabled = ban
        textTelefono.Enabled = ban
    End Sub
    Private Sub campDat()
        textIdEmpleado.Text = EmpleadosBindingSource.Current(0)
        textNombre.Text = EmpleadosBindingSource.Current(1)
        textPuesto.Text = EmpleadosBindingSource.Current(2)
        textDomicilio.Text = EmpleadosBindingSource.Current(3)
        textColonia.Text = EmpleadosBindingSource.Current(4)
        TextCp.Text = EmpleadosBindingSource.Current(5)
        textTelefono.Text = EmpleadosBindingSource.Current(6)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        campActi(False)
        EmpleadosBindingSource.Current(0) = CInt(textIdEmpleado.Text)
        EmpleadosBindingSource.Current(1) = textNombre.Text
        EmpleadosBindingSource.Current(2) = textPuesto.Text
        EmpleadosBindingSource.Current(3) = textDomicilio.Text
        EmpleadosBindingSource.Current(4) = textColonia.Text
        EmpleadosBindingSource.Current(5) = TextCp.Text
        EmpleadosBindingSource.Current(6) = textTelefono.Text
        EmpleadosBindingSource.EndEdit()
        EmpleadosTableAdapter.Update(TiendaRopaDataSet1.Empleados)
        textIdEmpleado.Text = ""
        dgDatos.Refresh()
        btnNuevo.Enabled = False
        btnGuardar.Enabled = False
    End Sub
    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlClient.SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated
        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf &
           e.Row.Item("NOMBRE", DataRowVersion.Original) & vbCrLf &
           e.Row.Item("NOMBRE", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub

End Class