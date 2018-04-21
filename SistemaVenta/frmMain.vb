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
End Class