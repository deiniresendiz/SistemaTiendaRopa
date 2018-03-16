Imports System.Data.SqlClient
Public Class frmCompraProducto
    Dim connection As New SqlConnection("Data Source=DESKTOP-NC9ERBN;Initial Catalog=SistemaRopa; Integrated Security='True';")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub frmCompraProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Close()
        connection.Open()
    End Sub

    Private Sub limpiarProveedor()
        textNombreProveedor.Text = ""
        textRfcProveedores.Text = ""
        textTelefonoProveedores.Text = ""
        textIdProveedor.Text = ""
        textNombreP.Text = ""
        textRfcP.Text = ""
        textCallep.Text = ""
        textColoniaP.Text = ""
        textTelefonoP.Text = ""
    End Sub

    Private Sub limpiarProducto()
        textExistencias.Text = ""
        textExistenciaA.Text = ""
        textCostoAnterio.Text = ""
        textMinimo.Text = ""
        textMaximo.Text = ""
        textTalla.Text = ""
        textCosto.Text = ""
        textCantidad.Text = ""
    End Sub

    Private Sub consProveedor(ByVal s As String)
        limpiarProveedor()
        dgDatosProveedores.Rows.Clear()
        Dim r = "select * from Proveedores  " + s + ";"
        comando = New SqlCommand(r, connection)
        lector = comando.ExecuteReader
        While lector.Read
            dgDatosProveedores.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
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
    Private Sub cargarDatosProveedor()
        Dim i As Integer = dgDatosProveedores.CurrentRow.Index
        Try
            textNombreProveedor.Text = dgDatosProveedores.Item(1, i).Value
            textRfcProveedores.Text = dgDatosProveedores.Item(2, i).Value
            textTelefonoProveedores.Text = dgDatosProveedores.Item(5, i).Value
            textIdProveedor.Text = dgDatosProveedores.Item(0, i).Value
            textNombreP.Text = dgDatosProveedores.Item(1, i).Value
            textRfcP.Text = dgDatosProveedores.Item(2, i).Value
            textCallep.Text = dgDatosProveedores.Item(3, i).Value
            textColoniaP.Text = dgDatosProveedores.Item(4, i).Value
            textTelefonoP.Text = dgDatosProveedores.Item(5, i).Value
        Catch ex As Exception
        End Try
        If Not textNombreProveedor.Text = "" Then
            btnAceptar.Enabled = True
        Else
            btnAceptar.Enabled = False
        End If
    End Sub

    Private Sub cargarDatosProducto()
        Dim i As Integer = dgDatosProductos.CurrentRow.Index
        Try
            textExistencias.Text = dgDatosProductos.Item(5, i).Value
            textExistenciaA.Text = dgDatosProductos.Item(6, i).Value
            textCostoAnterio.Text = dgDatosProductos.Item(9, i).Value
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
            textCosto.Enabled = True
        Else
            btnAgregar.Enabled = False
            textCantidad.Enabled = False
            textCosto.Enabled = False
        End If
        textCantidad.Text = ""
        textCosto.Text = ""
    End Sub
    Private Sub dgDatosProveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDatosProveedores.CellClick
        cargarDatosProveedor()
    End Sub

    Private Sub txtBuscarProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProveedor.TextChanged
        Dim b As String
        b = " where Nombre like '" & txtBuscarProveedor.Text & "%' or RFC like '" & txtBuscarProveedor.Text & "%'"
        consProveedor(b)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        grupProveedores.Visible = False
        grupProveedor.Visible = True
        gruopProducto.Visible = True
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        grupProveedores.Visible = True
        grupProveedor.Visible = False
        gruopProducto.Visible = False
        txtBuscarProveedor.Text = ""
        btnAceptar.Enabled = False
    End Sub

    Private Sub textBuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles textBuscarProducto.TextChanged
        Dim b As String
        b = " where vwProductos.Nombre like '" & textBuscarProducto.Text & "%' or vwProductos.Descripcion like '" & textBuscarProducto.Text & "%'"
        consProducto(b)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Not textCantidad.Text = "" Then
            agregarCompra()
            limpiarProducto()
            calcularTotales()
            btnAgregar.Enabled = False
        Else
            MessageBox.Show("Fata la cantidad")
        End If
    End Sub

    Private Sub dgDatosProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDatosProductos.CellClick
        cargarDatosProducto()
    End Sub
    Sub calcularTotales()
        Dim subTotal As Double = 0
        For x = 0 To dgDatosCompra.Rows.Count - 2
            subTotal += CDbl(dgDatosCompra.Item(5, x).Value)
        Next
        textSubTotal.Text = subTotal
        textIva.Text = (subTotal * 0.16)
        textTotal.Text = (subTotal + CDbl(textIva.Text))
    End Sub
    Sub agregarCompra()
        Dim ban As Boolean = True
        Dim c1 As Double
        Dim c2, d1, x As Integer
        x = dgDatosCompra.Rows.Count + 1
        c2 = Val(textCantidad.Text)
        d1 = Val(textProductoId.Text)
        If textCosto.Text = "" Then
            c1 = CDbl(textCostoAnterio.Text)
        Else
            c1 = CDbl(textCosto.Text)
        End If
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
        textCosto.Text = ""
        textCantidad.Enabled = False
        textCosto.Enabled = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarProveedor()
        limpiarProducto()
        calcularTotales()
        textFactura.Enabled = True
        textFactura.Text = String.Empty
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        grupProveedores.Enabled = True
        grupProveedores.Visible = True
        grupProveedor.Visible = False
        txtBuscarProveedor.Enabled = True
        Dim r As String = "select count(*) from Compras"
        comando = New SqlCommand(r, connection)
        textIdCompraC.Text = comando.ExecuteScalar + 1
        'textFactura.Text = Val(textIdCompraC.Text).ToString("[000-00000]")
        'textFactura.Text = Format(2, "000")
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        guradarDatos()
        limpiarProveedor()
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        grupProveedores.Visible = True
        gruopProducto.Visible = False
        textFactura.Enabled = False
        textFactura.Text = String.Empty
        textCantidad.Text = String.Empty
        textCosto.Text = String.Empty
        textBuscarProducto.Text = String.Empty
        txtBuscarProveedor.Text = String.Empty
        txtBuscarProveedor.Enabled = False
        textSubTotal.Text = String.Empty
        textIva.Text = String.Empty
        textTotal.Text = String.Empty
        btnAgregar.Enabled = False
        btnAceptar.Enabled = False
        dgDatosCompra.Rows.Clear()
        dgDatosProductos.Rows.Clear()
        dgDatosProveedores.Rows.Clear()
        grupProveedor.Visible = False
    End Sub
    Sub guradarDatos()
        Dim command As SqlCommand = connection.CreateCommand()
        Dim transaction As SqlTransaction
        transaction = connection.BeginTransaction("SampleTransaction")

        command.Connection = connection
        Command.Transaction = transaction
        Try
            Dim fecha As String = dateFecha.Value.Year & "-" & dateFecha.Value.Month & "-" & dateFecha.Value.Day
            command.CommandText = "insert into Compras(IdCompra,IdProveedor,Factura,FechaCompra,SubTotal,Iva,Total) values (" & Val(textIdCompraC.Text) & "," & Val(textIdProveedor.Text) & ",'" & textFactura.Text & "','" & fecha & "','" & CDbl(textSubTotal.Text) & "','" & CDbl(textIva.Text) & "','" & CDbl(textTotal.Text) & "')"
            command.ExecuteNonQuery()
            For x = 0 To dgDatosCompra.Rows.Count - 2
                Dim d1, d3 As Integer
                Dim c1 As Double
                d1 = Val(dgDatosCompra.Item(1, x).Value)
                d3 = Val(dgDatosCompra.Item(3, x).Value)
                c1 = CDbl(dgDatosCompra.Item(4, x).Value)
                command.CommandText = "insert into DetCompras(IdCompra,IdProducto,Cantidad,Costo) values(" & Val(textIdCompraC.Text) & "," & d1 & "," & d3 & ",'" & c1 & "')"
                command.ExecuteNonQuery()
                command.CommandText = "declare @exiten integer; set @exiten =(select Existencia from Productos where IdProducto = " & d1 & "); update Productos set Existencia = (@exiten +" & d3 & ") , UltFecCompra = '" & fecha & "', Costo = '" & c1 & "' where IdProducto = " & d1 & ""
                command.ExecuteNonQuery()
            Next

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

    Private Sub txtBuscarProveedor_Click(sender As Object, e As EventArgs) Handles txtBuscarProveedor.Click
        txtBuscarProveedor.Text = ""
    End Sub

    Private Sub textBuscarProducto_Click(sender As Object, e As EventArgs) Handles textBuscarProducto.Click
        textBuscarProducto.Text = ""
    End Sub
End Class