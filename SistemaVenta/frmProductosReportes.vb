Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Public Class frmProductosReportes
    Dim Conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)

    Private Sub frmProdcutosReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Conexion.Close()
            Conexion.Open()
            Dim Cmd As New SqlCommand(reporte(reporteOpcion), Conexion)
            Dim Adaptador As New SqlDataAdapter(Cmd)
            Dim Data As New Data.DataSet
            ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.RefreshReport()
            ReportViewer1.Clear()
            ReportViewer1.RefreshReport()
            ReportViewer1.LocalReport.Refresh()
            Cmd.CommandType = CommandType.StoredProcedure
            Adaptador.Fill(Data)
            Data.DataSetName = "DataSet1"
            Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
            Me.ReportViewer1.LocalReport.DataSources.Add(Reportes)
            Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\NETXBAX\Google Drive\SystemaRopa\SistemaTiendaRopa\SistemaVenta\" & reporte(reporteOpcion) & ".rdlc"
        ReportViewer1.LocalReport.Refresh()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class