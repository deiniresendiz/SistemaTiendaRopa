Imports System.Data.SqlClient
Public Class frmConsultaVenta
    Dim connection As New SqlConnection("Data Source=DESKTOP-NC9ERBN;Initial Catalog=SistemaRopa; Integrated Security='True';")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub frmConsultaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Close()
        connection.Open()
        consVenta("")
    End Sub

    Private Sub textBusVenta_TextChanged(sender As Object, e As EventArgs) Handles textBusVenta.TextChanged
        Dim b As String = " where Nombre like '" & textBusVenta.Text & "%' or Apellidos like '%" & textBusVenta.Text & "%' or Folio like '%" & textBusVenta.Text & "%' or IdCliente like '%" & textBusVenta.Text & "%'"
        consVenta(b)
    End Sub

    Private Sub textBusVenta_Click(sender As Object, e As EventArgs) Handles textBusVenta.Click
        textBusVenta.Text = String.Empty
    End Sub
    Private Sub consVenta(ByVal s As String)
        dgVentas.Rows.Clear()
        Dim r = "select * from vwVenta  " + s + ";"
        comando = New SqlCommand(r, connection)
        lector = comando.ExecuteReader
        While lector.Read
            If lector(15) = "R" Then
                dgVentas.Rows.Add(lector(0), lector(1), (lector(3) & " " & lector(4)), lector(9), lector(10), lector(11), lector(12), lector(14), lector(15))
            End If
        End While
        lector.Close()
    End Sub

    Private Sub dgVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVentas.CellClick
        dgDetalleVenta.Rows.Clear()

        Try
            Dim i As Integer = dgVentas.CurrentRow.Index
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
            dgDetalleVenta.Rows.Add(x, lector(1), lector(2), lector(3), lector(4), lector(5), (lector(4) * lector(5)))
            x = x + 1
        End While
        lector.Close()

    End Sub
End Class