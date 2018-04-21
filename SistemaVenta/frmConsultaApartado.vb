Imports System.Data.SqlClient
Public Class frmConsultaApartado
    Dim connection As New SqlConnection("Data Source=DESKTOP-NC9ERBN;Initial Catalog=SistemaRopa; Integrated Security='True';")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub frmConsultaApartado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Close()
        connection.Open()
    End Sub
    Private Sub txtBus_TextChanged(sender As Object, e As EventArgs) Handles txtBus.TextChanged
        Dim b As String = " where Nombre like '" & txtBus.Text & "%' or Apellidos like '%" & txtBus.Text & "%' or IdApartado like '%" & txtBus.Text & "'"
        consApartado(b)
    End Sub
    Private Sub consApartado(ByVal s As String)
        connection.Close()
        connection.Open()
        dgApartados.Rows.Clear()
        Dim r = "select * from vwApartados  " + s + " ;"
        comando = New SqlCommand(r, connection)
        lector = comando.ExecuteReader
        While lector.Read
            dgApartados.Rows.Add(lector(0), (lector(1) & " " & lector(2)), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8))
        End While
        lector.Close()

    End Sub


    Sub consDetApartado(ByVal s As String)
        dgDatos.Rows.Clear()
        Dim r = "select * from vwDetApartado where IdApartado =  '" + s + "';"
        comando = New SqlCommand(r, connection)
        lector = comando.ExecuteReader

        Dim x As Integer = 1
        While lector.Read
            dgDatos.Rows.Add(x, lector(2), lector(3), lector(4), (lector(3) * lector(4)))
            x = x + 1
        End While
        lector.Close()

    End Sub

    Private Sub txtBus_Click(sender As Object, e As EventArgs) Handles txtBus.Click
        txtBus.Text = String.Empty
    End Sub

    Private Sub dgApartados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgApartados.CellClick
        dgDatos.Rows.Clear()
        Try
            Dim i As Integer = dgApartados.CurrentRow.Index
            textTotal.Text = dgApartados.Item(6, i).Value
            consDetApartado(dgApartados.Item(0, i).Value)
            Dim r = "select sum(Importe) from Abonos where IdApartado = '" & Val(dgApartados.Item(0, i).Value) & "';"
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
End Class