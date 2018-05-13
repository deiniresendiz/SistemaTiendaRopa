Public Class Fecha
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conFecha = True
        conEstado = False
        FI = drpFechaDesde.Value.Day & "/" & drpFechaDesde.Value.Month & "/" & drpFechaDesde.Value.Year
        FF = drpFechaHasta.Value.Day & "/" & drpFechaHasta.Value.Month & "/" & drpFechaHasta.Value.Year
        frmReporte.ShowDialog()
        Dispose()
    End Sub

    Private Sub Fecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class