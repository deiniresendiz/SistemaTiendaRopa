Imports System.Data.SqlClient
Public Class frmDevolucion
    Dim connection As New SqlConnection("Data Source=DESKTOP-NC9ERBN;Initial Catalog=SistemaRopa; Integrated Security='True';")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub frmDevolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Close()
        connection.Open()
        iniRest()
        habiComp(False)
        limpiarDg()
    End Sub
    Sub habiComp(ByVal ban As Boolean)
        FechaDevolucion.Enabled = ban
        textMotivo.Enabled = ban
        textBusVenta.Enabled = ban
        btnNuevo.Enabled = Not ban
        btnGuardar.Enabled = ban
    End Sub
    Sub limpiarVenta()
        textIdVenta.Text = String.Empty
        textCliente.Text = String.Empty
        textDomicilio.Text = String.Empty
        textTelefono.Text = String.Empty
        textSaldo.Text = String.Empty
        textSub.Text = String.Empty
        textIva.Text = String.Empty
        textTotal.Text = String.Empty
        fechaVenta.Value = Date.Today
    End Sub
    Sub limpiarDevolucion()
        FechaDevolucion.Value = Date.Today
        textMotivo.Text = String.Empty
        textIdDevolucion.Text = String.Empty
    End Sub
    Sub limpiarDg()
        dgVentas.Rows.Clear()
        dgDetalleVenta.Rows.Clear()
    End Sub
    Sub iniRest()
        limpiarVenta()
        limpiarDevolucion()
    End Sub
    Private Sub consVenta(ByVal s As String)
        limpiarVenta()
        dgVentas.Rows.Clear()
        Dim r = "select * from vwVenta  " + s + ";"
        comando = New SqlCommand(r, connection)
        lector = comando.ExecuteReader
        While lector.Read
            If lector(15) = "R" Then
                dgVentas.Rows.Add(lector(0), lector(1), lector(2), (lector(3) & " " & lector(4)), (lector(5) & " " & lector(6)), lector(7), lector(8), lector(9), lector(10), lector(11), lector(12), lector(14), lector(15))
            End If
        End While
        lector.Close()
    End Sub
    Private Sub textBusVenta_TextChanged(sender As Object, e As EventArgs) Handles textBusVenta.TextChanged
        Dim b As String = " where Nombre like '" & textBusVenta.Text & "%' or Apellidos like '%" & textBusVenta.Text & "%' or Folio like '%" & textBusVenta.Text & "%' or IdCliente like '%" & textBusVenta.Text & "%'"
        consVenta(b)
    End Sub
    Private Sub textBusVenta_Click(sender As Object, e As EventArgs) Handles textBusVenta.Click
        textBusVenta.Text = String.Empty
    End Sub

    Private Sub dgVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVentas.CellClick
        dgDetalleVenta.Rows.Clear()
        limpiarVenta()
        Try
            Dim i As Integer = dgVentas.CurrentRow.Index
            textIdVenta.Text = dgVentas.Item(0, i).Value
            textCliente.Text = dgVentas.Item(3, i).Value
            textDomicilio.Text = dgVentas.Item(4, i).Value
            textTelefono.Text = dgVentas.Item(5, i).Value
            textSaldo.Text = dgVentas.Item(6, i).Value
            fechaVenta.Value = dgVentas.Item(7, i).Value
            textSub.Text = dgVentas.Item(8, i).Value
            textIva.Text = dgVentas.Item(9, i).Value
            textTotal.Text = dgVentas.Item(10, i).Value
            consDetVenta(dgVentas.Item(0, i).Value)
        Catch ex As Exception

        End Try
    End Sub
    Sub consDetVenta(ByVal s As String)
        dgDetalleVenta.Rows.Clear()
        Dim r = "select * from vwDetVenta where IdVenta =  '" + s + "';"
        comando = New SqlCommand(r, connection)
        lector = comando.ExecuteReader

        Dim x As Integer = 1
        While lector.Read
            dgDetalleVenta.Rows.Add(x, lector(1), lector(2), lector(3), lector(4), lector(5))
            x = x + 1
        End While
        lector.Close()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        habiComp(True)
        iniRest()
        Dim r As String = "select count(*) from Devoluciones"
        comando = New SqlCommand(r, connection)
        textIdDevolucion.Text = comando.ExecuteScalar + 1
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        guradarDatos()
        habiComp(False)
        iniRest()
        limpiarDg()
    End Sub
    Sub guradarDatos()
        Dim command As SqlCommand = connection.CreateCommand()
        Dim transaction As SqlTransaction
        transaction = connection.BeginTransaction("SampleTransaction")
        command.Connection = connection
        command.Transaction = transaction
        Try
            Dim fecha As String = FechaDevolucion.Value.Year & "-" & FechaDevolucion.Value.Month & "-" & FechaDevolucion.Value.Day
            command.CommandText = "insert into Devoluciones(IdDevolucion,IdVenta,FechaDevolucion,Motivo) values ('" & Val(textIdDevolucion.Text) & "','" & Val(textIdVenta.Text) & "','" & fecha & "','" & textMotivo.Text & "')"
            command.ExecuteNonQuery()

            command.CommandText = "update Ventas set Estado = 'C'  where IdVenta = " & Val(textIdVenta.Text) & ""
            command.ExecuteNonQuery()

            For x = 0 To dgDetalleVenta.Rows.Count - 2
                Dim d1, d3 As Integer
                d1 = Val(dgDetalleVenta.Item(1, x).Value)
                d3 = Val(dgDetalleVenta.Item(4, x).Value)
                command.CommandText = "insert into DetDevoluciones(IdDevolucion,IdProducto,Cantidad) values(" & Val(textIdDevolucion.Text) & "," & d1 & ",'" & d3 & "')"
                command.ExecuteNonQuery()
                MsgBox(d3)
                command.CommandText = "declare @exiten integer; set @exiten =(select Existencia from Productos where IdProducto = " & d1 & "); update Productos set Existencia = (@exiten +" & d3 & ")  where IdProducto = " & d1 & ""
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
End Class