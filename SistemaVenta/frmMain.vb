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
End Class