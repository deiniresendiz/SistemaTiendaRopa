Imports System.Data.SqlClient
Public Class frmApartado
    Dim connection As New SqlConnection("Data Source=DESKTOP-NC9ERBN;Initial Catalog=SistemaRopa; Integrated Security='True';")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub frmApartado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Close()
        connection.Open()
        iniRest()
    End Sub
    Sub limpiarEmpleados()
        textIdEmpleadoE.Text = String.Empty
        textNombreE.Text = String.Empty
        textNombreEmpleados.Text = String.Empty
        textPuestoE.Text = String.Empty
        textPuestoEmpleados.Text = String.Empty
        textCalleE.Text = String.Empty
        textColoniaE.Text = String.Empty
        textTelefonoEmpleados.Text = String.Empty
        textTelefonoE.Text = String.Empty
    End Sub
    Sub limpiarClientes()
        textIdClienteC.Text = String.Empty
        textNombreCliente.Text = String.Empty
        textNombreC.Text = String.Empty
        textSaldoC.Text = String.Empty
        textSaldoCliente.Text = String.Empty
        textCalleC.Text = String.Empty
        textColoniaC.Text = String.Empty
        textTelefonoC.Text = String.Empty
        textTelefonoCliente.Text = String.Empty
    End Sub
    Private Sub limpiarProducto()
        textExistencias.Text = String.Empty
        textExistenciaA.Text = String.Empty
        textPrecio.Text = String.Empty
        textMinimo.Text = String.Empty
        textMaximo.Text = String.Empty
        textTalla.Text = String.Empty
        textCantidad.Text = String.Empty
    End Sub
    Private Sub consEmpleados(ByVal s As String)
        limpiarEmpleados()
        dgDatosEmpleados.Rows.Clear()
        Dim r = "select * from Empleados  " + s + ";"
        comando = New SqlCommand(r, connection)
        lector = comando.ExecuteReader
        While lector.Read
            dgDatosEmpleados.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
        End While
        lector.Close()
    End Sub
    Private Sub consClientes(ByVal s As String)
        limpiarClientes()
        dgDatosClientes.Rows.Clear()
        Dim r = "select * from Clientes  " + s + ";"
        comando = New SqlCommand(r, connection)
        lector = comando.ExecuteReader
        While lector.Read
            dgDatosClientes.Rows.Add(lector(0), (lector(1) & " " & lector(2)), lector(7), lector(3), lector(4), lector(6))
        End While
        lector.Close()
    End Sub
    Private Sub consProducto(ByVal s As String)
        limpiarProducto()
        dgDatosProductos.Rows.Clear()
        Dim r = "select * from vwProductos  " + s + ";"
        comando = New SqlCommand(r, connection)
        lector = comando.ExecuteReader
        While lector.Read
            dgDatosProductos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9), lector(10), lector(11))
        End While
        lector.Close()
    End Sub
    Sub iniRest()
        limpiarClientes()
        limpiarEmpleados()
        limpiarProducto()
        gruopProducto.Visible = False
        grupClientes.Visible = False
        grupEmpleados.Visible = True
        grupProveedor.Visible = True
        GroupBox1.Visible = True
        dgDatosClientes.Rows.Clear()
        dgDatosEmpleados.Rows.Clear()
        dgDatosProductos.Rows.Clear()
        dgDatosCompra.Rows.Clear()
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
    End Sub
    Private Sub cargarDatosProducto()
        Dim i As Integer = dgDatosProductos.CurrentRow.Index
        Try
            textExistencias.Text = dgDatosProductos.Item(5, i).Value
            textExistenciaA.Text = dgDatosProductos.Item(6, i).Value
            textPrecio.Text = dgDatosProductos.Item(10, i).Value
            textMinimo.Text = dgDatosProductos.Item(8, i).Value
            textMaximo.Text = dgDatosProductos.Item(7, i).Value
            textTalla.Text = dgDatosProductos.Item(4, i).Value
            textProductoId.Text = dgDatosProductos.Item(0, i).Value
            textProductoNombre.Text = dgDatosProductos.Item(2, i).Value
        Catch ex As Exception
        End Try
        If Not textExistencias.Text = "" Then
            btnAgregar.Enabled = True
            textCantidad.Enabled = True
        Else
            btnAgregar.Enabled = False
            textCantidad.Enabled = False
        End If
        textCantidad.Text = String.Empty
    End Sub
    Private Sub cargarDatosEmpleado()
        Dim i As Integer = dgDatosEmpleados.CurrentRow.Index
        Try
            textIdEmpleadoE.Text = dgDatosEmpleados.Item(0, i).Value
            textNombreE.Text = dgDatosEmpleados.Item(1, i).Value
            textNombreEmpleados.Text = dgDatosEmpleados.Item(1, i).Value
            textPuestoE.Text = dgDatosEmpleados.Item(2, i).Value
            textPuestoEmpleados.Text = dgDatosEmpleados.Item(2, i).Value
            textCalleE.Text = dgDatosEmpleados.Item(3, i).Value
            textColoniaE.Text = dgDatosEmpleados.Item(3, i).Value
            textTelefonoEmpleados.Text = dgDatosEmpleados.Item(4, i).Value
            textTelefonoE.Text = dgDatosEmpleados.Item(4, i).Value
        Catch ex As Exception
        End Try
        If Not textIdEmpleadoE.Text = "" Then
            btnAceptarE.Enabled = True
        Else
            btnAceptarE.Enabled = False
        End If
    End Sub
    Private Sub cargarDatosCliente()
        Dim i As Integer = dgDatosClientes.CurrentRow.Index
        Try
            textIdClienteC.Text = dgDatosClientes.Item(0, i).Value
            textNombreCliente.Text = dgDatosClientes.Item(1, i).Value
            textNombreC.Text = dgDatosClientes.Item(1, i).Value
            textSaldoC.Text = dgDatosClientes.Item(2, i).Value
            textSaldoCliente.Text = dgDatosClientes.Item(2, i).Value
            textCalleC.Text = dgDatosClientes.Item(3, i).Value
            textColoniaC.Text = dgDatosClientes.Item(4, i).Value
            textTelefonoC.Text = dgDatosClientes.Item(5, i).Value
            textTelefonoCliente.Text = dgDatosClientes.Item(5, i).Value
        Catch ex As Exception
        End Try
        If Not textIdClienteC.Text = "" Then
            btnAceptarCliente.Enabled = True
        Else
            btnAceptarCliente.Enabled = False
        End If
    End Sub
    Sub calcularTotales()
        Dim subTotal As Double = 0
        For x = 0 To dgDatosCompra.Rows.Count - 2
            subTotal += CDbl(dgDatosCompra.Item(5, x).Value)
        Next
        textSubTotal.Text = subTotal
        textIva.Text = (subTotal * 0.16)
        textTotal.Text = (subTotal + CDbl(textIva.Text))
        calRestante()
    End Sub
    Sub agregarCompra()
        Dim ban As Boolean = True
        Dim c1 As Double
        Dim c2, d1, x As Integer
        x = dgDatosCompra.Rows.Count + 1
        c2 = Val(textCantidad.Text)
        d1 = Val(textProductoId.Text)
        c1 = CDbl(textPrecio.Text)
        For x = 0 To dgDatosCompra.Rows.Count - 2
            If dgDatosCompra.Item(1, x).Value = d1 Then
                ban = False
                dgDatosCompra.Item(3, x).Value += c2
                dgDatosCompra.Item(4, x).Value = c1
                dgDatosCompra.Item(5, x).Value = (CDbl(dgDatosCompra.Item(3, x).Value) * c1)
            End If
        Next
        If ban Then
            dgDatosCompra.Rows.Add(x + 1, d1, textProductoNombre.Text, c2, c1, (CDbl(c2) * c1))
        End If
        textCantidad.Text = ""
        textCantidad.Enabled = False
    End Sub
    Sub guradarDatos()
        Dim command As SqlCommand = connection.CreateCommand()
        Dim transaction As SqlTransaction
        transaction = connection.BeginTransaction("SampleTransaction")
        command.Connection = connection
        command.Transaction = transaction
        Try
            Dim fecha As String = dateFecha.Value.Year & "-" & dateFecha.Value.Month & "-" & dateFecha.Value.Day
            Dim fechaF As String = dateFecha.Value.Year & "-" & dateFecha.Value.Month & "-" & dateFecha.Value.Day
            command.CommandText = "insert into Apartados(IdApartado,IdEmpleado,IdCliente,FechaApartado,FechaActivo,SubTotal,Iva,Total,Estado) values ('" & Val(textIdApartado.Text) & "','" & Val(textIdEmpleadoE.Text) & "','" & Val(textIdClienteC.Text) & "','" & fecha & "','" & fechaF & "','" & CDbl(textSubTotal.Text) & "','" & CDbl(textIva.Text) & "','" & CDbl(textTotal.Text) & "','E')"
            command.ExecuteNonQuery()
            For x = 0 To dgDatosCompra.Rows.Count - 2
                Dim d1, d3 As Integer
                Dim c1 As Double
                d1 = Val(dgDatosCompra.Item(1, x).Value)
                d3 = Val(dgDatosCompra.Item(3, x).Value)
                c1 = CDbl(dgDatosCompra.Item(4, x).Value)
                command.CommandText = "insert into DetApartados(IdApartado,IdProducto,Cantidad,Precio) values(" & Val(textIdApartado.Text) & "," & d1 & "," & d3 & ",'" & c1 & "')"
                command.ExecuteNonQuery()
                command.CommandText = "declare @exiten integer; set @exiten =(select ExistenciaApartado from Productos where IdProducto = " & d1 & "); update Productos set ExistenciaApartado = (@exiten + " & d3 & ")  where IdProducto = " & d1 & ""
                command.ExecuteNonQuery()
            Next
            command.CommandText = "declare @saldo money; set @saldo =(select Saldo from Clientes where IdCliente = " & Val(textIdClienteC.Text) & "); update Clientes set Saldo = (@saldo + '" & CDbl(textTotal.Text) & "')  where IdCliente = " & Val(textIdClienteC.Text) & ""
            command.ExecuteNonQuery()
            If MsgBox("desea ejecutar transacción", MsgBoxStyle.YesNo, "ejecutar") = MsgBoxResult.Yes Then
                transaction.Commit()
                MsgBox("ok")

            Else
                transaction.Rollback()
                MsgBox("Transacción cancelada")
            End If
        Catch ex As Exception
            MsgBox("Commit Exception Type: {0}no se pudo insertar por error")

            Try
                transaction.Rollback()
            Catch ex2 As Exception

                MsgBox("Error Rollback")

            End Try
        End Try

    End Sub

    Private Sub txtBuscarEmpleados_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEmpleados.TextChanged
        Dim b As String = " where Nombre like '" & txtBuscarEmpleados.Text & "%' or Puesto like '" & txtBuscarEmpleados.Text & "%'"
        consEmpleados(b)
    End Sub

    Private Sub txtBuscarEmpleados_Click(sender As Object, e As EventArgs) Handles txtBuscarEmpleados.Click
        txtBuscarEmpleados.Text = String.Empty
    End Sub

    Private Sub textBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles textBuscarCliente.TextChanged
        Dim b As String = " where Nombre like '%" & textBuscarCliente.Text & "%' or Apellidos like '%" & textBuscarCliente.Text & "%'"
        consClientes(b)
    End Sub

    Private Sub textBuscarCliente_Click(sender As Object, e As EventArgs) Handles textBuscarCliente.Click
        textBuscarCliente.Text = String.Empty
    End Sub

    Private Sub textBuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles textBuscarProducto.TextChanged
        Dim b As String = " where vwProductos.Nombre like '" & textBuscarProducto.Text & "%' or vwProductos.Descripcion like '" & textBuscarProducto.Text & "%'"
        consProducto(b)
    End Sub

    Private Sub textBuscarProducto_Click(sender As Object, e As EventArgs) Handles textBuscarProducto.Click
        textBuscarProducto.Text = String.Empty
    End Sub

    Private Sub dgDatosProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDatosProductos.CellClick
        cargarDatosProducto()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        If Not textCantidad.Text = String.Empty Then
            If Val(textCantidad.Text) <= (Val(textExistencias.Text) - Val(textExistenciaA.Text)) Then
                agregarCompra()
                limpiarProducto()
                calcularTotales()
                btnAgregar.Enabled = False
                textCantidad.Enabled = False
                textCantidad.Text = String.Empty
            Else
                MessageBox.Show("No hay existencias suficiente")
            End If
        Else
            MessageBox.Show("Fata la cantidad")
        End If
    End Sub

    Private Sub btnAceptarE_Click(sender As Object, e As EventArgs) Handles btnAceptarE.Click
        gruopProducto.Visible = False
        grupClientes.Visible = True
        grupEmpleados.Visible = False
    End Sub

    Private Sub btnAceptarCliente_Click(sender As Object, e As EventArgs) Handles btnAceptarCliente.Click
        gruopProducto.Visible = True
        grupClientes.Visible = False
        grupEmpleados.Visible = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarEmpleados()
        limpiarProducto()
        calcularTotales()
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        gruopProducto.Visible = False
        grupClientes.Visible = False
        grupEmpleados.Visible = True
        grupEmpleados.Enabled = True
        dateFecha.Enabled = True
        Dim r As String = "select count(*) from Apartados"
        comando = New SqlCommand(r, connection)
        textIdApartado.Text = comando.ExecuteScalar + 1
    End Sub

    Private Sub dgDatosEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDatosEmpleados.CellClick
        cargarDatosEmpleado()
    End Sub

    Private Sub dgDatosClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDatosClientes.CellClick
        cargarDatosCliente()
    End Sub

    Private Sub btnAtrasE_Click(sender As Object, e As EventArgs) Handles btnAtrasE.Click
        gruopProducto.Visible = False
        grupClientes.Visible = False
        grupEmpleados.Visible = True
    End Sub

    Private Sub btnAtrasCliente_Click(sender As Object, e As EventArgs) Handles btnAtrasCliente.Click
        gruopProducto.Visible = False
        grupClientes.Visible = True
        grupEmpleados.Visible = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        guradarDatos()
        iniRest()
    End Sub

    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not textCantidad.Text = String.Empty Then
            If Val(textCantidad.Text) <= (Val(textExistencias.Text) - Val(textExistenciaA.Text)) Then
                agregarCompra()
                limpiarProducto()
                calcularTotales()
                btnAgregar.Enabled = False
                textCantidad.Enabled = False
                textCantidad.Text = String.Empty
            Else
                MessageBox.Show("No hay existencias suficiente")
            End If
        Else
            MessageBox.Show("Fata la cantidad")
        End If
    End Sub

    Private Sub textAnticipo_TextChanged(sender As Object, e As EventArgs)
        calRestante()
    End Sub
    Sub calRestante()
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub textAnticipo_Click(sender As Object, e As EventArgs)

    End Sub
End Class