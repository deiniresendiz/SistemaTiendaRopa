Imports System.Data.SqlClient
Public Class PagoAbono

    Dim connection As New SqlConnection("Data Source=DESKTOP-NC9ERBN;Initial Catalog=SistemaRopa; Integrated Security='True';")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub PagoAbono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Close()
        connection.Open()
        iniRest()
        habiComp(False)
        limpiarDg()
    End Sub

    Sub habiComp(ByVal ban As Boolean)
        textAbono.Enabled = ban
        btnNuevo.Enabled = Not ban
        btnGuardar.Enabled = ban
        textAbono.Enabled = ban
        txtBus.Enabled = ban
    End Sub

    Private Sub txtBus_TextChanged(sender As Object, e As EventArgs) Handles txtBus.TextChanged
        Dim b As String = " where Nombre like '" & txtBus.Text & "%' or Apellidos like '%" & txtBus.Text & "%' or IdApartado like '%" & txtBus.Text & "'"
        consApartado(b)
    End Sub
    Sub limpiarApartado()
        textIdApartado.Text = String.Empty
        textAbonos.Text = String.Empty
        textTotal.Text = String.Empty
        textCliente.Text = String.Empty
        textTotal.Text = String.Empty
        fechaApartadoF.Value = Date.Today
        fechaApartadoI.Value = Date.Today
        textSaldar.Text = String.Empty
    End Sub

    Sub limpiarAbono()
        textAbono.Text = String.Empty
        textSaldoNuevo.Text = String.Empty
        FechaAbono.Value = Date.Today
    End Sub
    Sub limpiarDg()
        dgDatos.Rows.Clear()
        dgApartados.Rows.Clear()
    End Sub
    Sub iniRest()
        limpiarAbono()
        limpiarApartado()
    End Sub
    Private Sub consApartado(ByVal s As String)
        connection.Close()
        connection.Open()
        dgApartados.Rows.Clear()
        Dim r = "select * from vwApartados  " + s + " ;"
        comando = New SqlCommand(r, connection)
        lector = comando.ExecuteReader
        While lector.Read
            If lector(8) = "E" Then
                dgApartados.Rows.Add(lector(0), (lector(1) & " " & lector(2)), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8))
            End If
        End While
        lector.Close()

    End Sub


    Sub consDetApartado(ByVal s As String)
        connection.Close()
        connection.Open()
        dgDatos.Rows.Clear()
        Dim r = "select * from vwDetApartado where IdApartado =  '" + s + "';"
        comando = New SqlCommand(r, connection)
        lector = comando.ExecuteReader

        Dim x As Integer = 1
        While lector.Read
            dgDatos.Rows.Add(x, lector(1), lector(2), lector(3), lector(4), (lector(3) * lector(4)))
            x = x + 1
        End While
        lector.Close()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        connection.Close()
        connection.Open()
        habiComp(True)
        iniRest()
        Dim r As String = "select count(*) from Abonos"
        comando = New SqlCommand(r, connection)
        textIdAbono.Text = comando.ExecuteScalar + 1
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        guradarDatos()
        habiComp(False)
        iniRest()
        limpiarDg()
        limpiarAbono()
        limpiarApartado()
    End Sub
    Sub guradarDatos()
        Dim command As SqlCommand = connection.CreateCommand()
        Dim transaction As SqlTransaction
        transaction = connection.BeginTransaction("SampleTransaction")
        command.Connection = connection
        command.Transaction = transaction
        Try
            Dim fecha As String = FechaAbono.Value.Year & "-" & FechaAbono.Value.Month & "-" & FechaAbono.Value.Day
            command.CommandText = "declare @x integer; set @x = (select count(*) from Abonos) +1; insert into Abonos(IdAbono,IdApartado,FechaAbono,Importe) values(@x," & Val(textIdApartado.Text) & ",'" & fecha & "','" & CDbl(textAbono.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "declare @idCliente integer;set @idCliente = (select IdCliente from Apartados where IdApartado = '" & Val(textIdApartado.Text) & "');declare @saldo money; set @saldo =(select Saldo from Clientes where IdCliente = @idCliente); update Clientes set Saldo = (@saldo - '" & CDbl(textAbono.Text) & "')  where IdCliente = @idCliente;"
            command.ExecuteNonQuery()
            If textSaldoNuevo.Text = "0" Then
                command.CommandText = "update Apartados set Estado = 'P' where IdApartado =  " & Val(textIdApartado.Text) & ""
                command.ExecuteNonQuery()
                For x = 0 To dgDatos.Rows.Count - 2
                    Dim d1, d3 As Integer
                    Dim c1 As Double
                    d1 = Val(dgDatos.Item(1, x).Value)
                    d3 = Val(dgDatos.Item(3, x).Value)
                    c1 = CDbl(dgDatos.Item(4, x).Value)
                    command.CommandText = "declare @exiten integer; set @exiten =(select ExistenciaApartado from Productos where IdProducto = " & d1 & "); update Productos set ExistenciaApartado = (@exiten - " & d3 & ")  where IdProducto = " & d1 & ""
                    command.ExecuteNonQuery()
                    command.CommandText = "declare @exiten integer; set @exiten =(select Existencia from Productos where IdProducto = " & d1 & "); update Productos set Existencia = (@exiten - " & d3 & ")  where IdProducto = " & d1 & ""
                    command.ExecuteNonQuery()
                Next

            End If

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

    Private Sub dgApartados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgApartados.CellClick
        dgDatos.Rows.Clear()
        limpiarApartado()
        Try
            Dim i As Integer = dgApartados.CurrentRow.Index
            textIdApartado.Text = dgApartados.Item(0, i).Value
            textCliente.Text = dgApartados.Item(1, i).Value
            fechaApartadoI.Text = dgApartados.Item(2, i).Value
            fechaApartadoF.Text = dgApartados.Item(3, i).Value
            textTotal.Text = dgApartados.Item(6, i).Value
            consDetApartado(dgApartados.Item(0, i).Value)
            Dim r = "select sum(Importe) from Abonos where IdApartado = '" & Val(textIdApartado.Text) & "';"
            comando = New SqlCommand(r, connection)
            Dim a As String = "" & comando.ExecuteScalar
            If a = String.Empty Then
                a = "0"
            End If
            textAbonos.Text = a
            textSaldar.Text = (CDbl(textTotal.Text) - CDbl(textAbonos.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBus_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBus.MouseClick
        txtBus.Text = ""
    End Sub
    Private Sub textAbono_TextChanged(sender As Object, e As EventArgs) Handles textAbono.TextChanged
        Try
            If Not textAbono.Text = String.Empty Then
                textSaldoNuevo.Text = (CDbl(textSaldar.Text) - CDbl(textAbono.Text))
            Else
                textSaldar.Text = textAbonos.Text
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub textAbono_Click(sender As Object, e As EventArgs) Handles textAbono.Click
        textAbono.Text = String.Empty
    End Sub
End Class