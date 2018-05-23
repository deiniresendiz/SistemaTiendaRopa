Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Public Class frmMain
    Dim Conexion As SqlConnection
    Dim conexionBitacora = OpenBitacora()
    Dim BitacoraComando As SqlCommand = conexionBitacora.CreateCommand()
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
        conEstado = False
        frmReporte.ShowDialog()
    End Sub

    Private Sub EmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem1.Click
        reporteOpcion = 1
        conFecha = False
        conEstado = False
        frmReporte.ShowDialog()
    End Sub

    Private Sub ComprasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem1.Click
        reporteOpcion = 3
        conFecha = False
        conEstado = False
        frmReporte.ShowDialog()
    End Sub

    Private Sub ComprasToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem2.Click
        reporteOpcion = 4
        conFecha = False
        conEstado = False
        'frmReporte.ShowDialog()
        frmProductosReportes.ShowDialog()
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem1.Click
        reporteOpcion = 2
        conFecha = False
        conEstado = False
        frmReporte.ShowDialog()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        reporteOpcion = 5
        conFecha = False
        conEstado = False
        frmReporte.ShowDialog()
    End Sub

    Private Sub ApartadosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ApartadosToolStripMenuItem2.Click
        reporteOpcion = 6
        conFecha = False
        conEstado = False
        frmReporte.ShowDialog()
    End Sub

    Private Sub DevolucionesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DevolucionesToolStripMenuItem1.Click
        reporteOpcion = 7
        conFecha = False
        conEstado = False
        frmReporte.ShowDialog()
    End Sub

    Private Sub VentasEnUnPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasEnUnPeriodoToolStripMenuItem.Click
        reporteOpcion = 12
        venta = True
        FechaEstado.ShowDialog()
    End Sub

    Private Sub ApartadosEnUnPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApartadosEnUnPeriodoToolStripMenuItem.Click
        reporteOpcion = 13
        venta = False
        FechaEstado.ShowDialog()
    End Sub

    Private Sub DevolucionesEnUnPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolucionesEnUnPeriodoToolStripMenuItem.Click
        reporteOpcion = 11
        Fecha.ShowDialog()
    End Sub

    Private Sub CompraEnUnPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraEnUnPeriodoToolStripMenuItem.Click
        reporteOpcion = 10
        Fecha.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        System.Diagnostics.Process.Start("C:\Users\NETXBAX\Google Drive\SystemaRopa\SistemaTiendaRopa\SistemaVenta\help.chm")
    End Sub

    Private Sub RespaldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RespaldoToolStripMenuItem.Click
        cerrarConexion()
        Try
            SqlConnection.ClearAllPools()
            Dim res As DialogResult
            SaveFileDialog1.FileName = ".bak"
            res = SaveFileDialog1.ShowDialog()
            If res = DialogResult.OK Then
                Dim path As String = SaveFileDialog1.FileName
                Conexion = openConnection()
                Conexion.Open()
                Dim command As New SqlCommand
                command.Connection = Conexion
                MsgBox(path)
                command.CommandText = "backup Database SistemaRopa to disk = '" & path & "' with format "
                command.ExecuteNonQuery()
                MsgBox("El respaldo se hizo exitosamente.")
                Conexion.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al respaldar")
            Dim errMessage As String = quitarComillas(ex.Message)
            conexionBitacora.open
            BitacoraComando.CommandText = "declare @x integer; set @x = (select count(*) from Bitacora) +1;INSERT INTO Bitacora VALUES(@x, '" & Err.Number & "', '" & errMessage & "','ffrmMain','" & Now.Date & "')"
            BitacoraComando.ExecuteNonQuery()
            conexionBitacora = cerrarBitacora()
        End Try
    End Sub

    Private Sub RestaurarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaurarToolStripMenuItem.Click
        Try
            Dim res As DialogResult
            res = OpenFileDialog1.ShowDialog()
            If res = DialogResult.OK Then
                Dim path As String = OpenFileDialog1.FileName
                Conexion = OpenMaster()
                Conexion.Open()
                Dim command As New SqlCommand
                command.Connection = Conexion
                'command.CommandText = "ALTER DATABASE SistemaRopa SET SINGLE_USER WITH ROLLBACK IMMEDIATE"
                'command.ExecuteNonQuery()
                'command.CommandText = "ALTER DATABASE SistemaRopa SET MULTI_USER"
                'command.ExecuteNonQuery()
                command.CommandText = " restore database SistemaRopa FROM disk = '" & path & "' WITH REPLACE"
                command.ExecuteNonQuery()
                MsgBox("restauración exitosa.")
                Conexion.Close()
            End If
        Catch ex As Exception
            conexionBitacora.open()

            MsgBox("Error al restaurar")
            Dim errMessage As String = quitarComillas(ex.Message)
            BitacoraComando.CommandText = "declare @x integer; set @x = (select count(*) from Bitacora) +1;INSERT INTO Bitacora VALUES( @x, '" & Err.Number & "', '" & errMessage & "','ffrmMain','" & Now.Date & "')"
            BitacoraComando.ExecuteNonQuery()

            conexionBitacora = cerrarBitacora()
        End Try
    End Sub

    Private Sub BitacoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitacoraToolStripMenuItem.Click
        frmBitacora.ShowDialog()
    End Sub

    Private Sub HisttoriscoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HisttoriscoToolStripMenuItem.Click
        FechaHistorico.ShowDialog()
    End Sub
End Class