Public Class frmMain
    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        frmEmpleados.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        frmProveedores.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmClientes.ShowDialog()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        frmCategorias.ShowDialog()
    End Sub

    Private Sub ProdcutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdcutosToolStripMenuItem.Click
        frmProductos.ShowDialog()
    End Sub

    Private Sub VentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem.Click
        frmVentas.ShowDialog()
    End Sub

    Private Sub DevolucionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolucionToolStripMenuItem.Click
        frmDevolucion.ShowDialog()
    End Sub

    Private Sub CompraProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraProductoToolStripMenuItem.Click
        frmCompraProducto.ShowDialog()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        frmConsultaCompra.ShowDialog()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        frmConsultaVenta.ShowDialog()
    End Sub

    Private Sub DevolucionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolucionesToolStripMenuItem.Click
        frmConsultaDevolucion.ShowDialog()
    End Sub

    Private Sub ApartadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApartadosToolStripMenuItem.Click
        frmApartado.ShowDialog()
    End Sub

    Private Sub AbonoApartadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbonoApartadoToolStripMenuItem.Click
        PagoAbono.ShowDialog()
    End Sub

    Private Sub ApartadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ApartadosToolStripMenuItem1.Click
        frmConsultaApartado.ShowDialog()
    End Sub

    Private Sub PagoAbonosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagoAbonosToolStripMenuItem.Click
        frmConsultaPagoAbono.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        reporteOpcion = 0
        conFecha = False
        frmReporte.ShowDialog()
    End Sub

    Private Sub EmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem1.Click
        reporteOpcion = 1
        conFecha = False
        frmReporte.ShowDialog()
    End Sub

    Private Sub ComprasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem1.Click
        reporteOpcion = 3
        conFecha = False
        frmReporte.ShowDialog()
    End Sub

    Private Sub ComprasToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem2.Click
        reporteOpcion = 4
        conFecha = False
        'frmReporte.ShowDialog()
        frmProductosReportes.ShowDialog()
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem1.Click
        reporteOpcion = 2
        conFecha = False
        frmReporte.ShowDialog()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        reporteOpcion = 5
        conFecha = False
        frmReporte.ShowDialog()
    End Sub

    Private Sub ApartadosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ApartadosToolStripMenuItem2.Click
        reporteOpcion = 6
        conFecha = False
        frmReporte.ShowDialog()
    End Sub

    Private Sub DevolucionesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DevolucionesToolStripMenuItem1.Click
        reporteOpcion = 7
        conFecha = False
        frmReporte.ShowDialog()
    End Sub

    Private Sub VentasEnUnPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasEnUnPeriodoToolStripMenuItem.Click
        reporteOpcion = 8
        Fecha.ShowDialog()
    End Sub

    Private Sub ApartadosEnUnPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApartadosEnUnPeriodoToolStripMenuItem.Click
        reporteOpcion = 9
        Fecha.ShowDialog()
    End Sub

    Private Sub DevolucionesEnUnPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolucionesEnUnPeriodoToolStripMenuItem.Click
        reporteOpcion = 11
        Fecha.ShowDialog()
    End Sub

    Private Sub CompraEnUnPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraEnUnPeriodoToolStripMenuItem.Click
        reporteOpcion = 10
        Fecha.ShowDialog()
    End Sub
End Class