Imports System.Data.SqlClient
Public Class frmConsultaCompra
    Dim connection As New SqlConnection("Data Source=DESKTOP-NC9ERBN;Initial Catalog=SistemaRopa; Integrated Security='True';")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub frmConsultaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Close()
        connection.Open()
        textBus.Text = String.Empty
        dgCompras.Rows.Clear()
        dgDetCompras.Rows.Clear()
    End Sub

    Private Sub textBus_TextChanged(sender As Object, e As EventArgs) Handles textBus.TextChanged
        Dim b As String = " where Nombre like '" & textBus.Text & "%' or Factura like '%" & textBus.Text & "%' or IdCompra like '%" & textBus.Text & "%'"
        consCompra(b)
    End Sub
    Private Sub consCompra(ByVal s As String)
        dgCompras.Rows.Clear()
        dgDetCompras.Rows.Clear()
        Dim r = "select * from vwCompras  " + s + ";"
        comando = New SqlCommand(r, connection)
        lector = comando.ExecuteReader
        While lector.Read
            dgCompras.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
        End While
        lector.Close()
    End Sub
    Private Sub dgCompras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCompras.CellClick
        Try
            consDetCompra(dgCompras.CurrentRow.Index)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub consDetCompra(ByVal s As String)
        dgDetCompras.Rows.Clear()
        Dim r = "select * from vwDetalleCompras where IdCompra =  '" + s + "';"
        comando = New SqlCommand(r, connection)
        lector = comando.ExecuteReader
        While lector.Read
            dgDetCompras.Rows.Add(lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7))
        End While
        lector.Close()
    End Sub

    Private Sub textBus_Click(sender As Object, e As EventArgs) Handles textBus.Click
        textBus.Text = String.Empty
    End Sub
End Class