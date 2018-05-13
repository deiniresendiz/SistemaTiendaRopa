Public Class FechaEstado
    Private Sub FechaEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comEstado.Items.Clear()

        If venta Then
            comEstado.Items.Add("Registada")
            comEstado.Items.Add("Cancelada")
        Else
            comEstado.Items.Add("Pagado")
            comEstado.Items.Add("Pendiente")
        End If
        comEstado.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conEstado = True
        FI = drpFechaDesde.Value.Day & "/" & drpFechaDesde.Value.Month & "/" & drpFechaDesde.Value.Year
        FF = drpFechaHasta.Value.Day & "/" & drpFechaHasta.Value.Month & "/" & drpFechaHasta.Value.Year
        If venta Then

            If comEstado.Text = "Registada" Then
                EDO = "R"
            Else
                EDO = "C"
            End If
        Else
            If comEstado.Text = "Pagado" Then
                EDO = "P"
            Else
                EDO = "E"
            End If
        End If
        frmReporte.ShowDialog()
        Dispose()
    End Sub
End Class