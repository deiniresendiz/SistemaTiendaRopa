Public Class Fecha
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conFecha = True
        FI = drpFechaDesde.Value.Day & "/" & drpFechaDesde.Value.Month & "/" & drpFechaDesde.Value.Year
        FF = drpFechaHasta.Value.Day & "/" & drpFechaHasta.Value.Month & "/" & drpFechaHasta.Value.Year
        frmReporte.ShowDialog()
        Dispose()
    End Sub
End Class