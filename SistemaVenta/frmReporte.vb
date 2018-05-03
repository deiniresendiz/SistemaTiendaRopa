Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration

Public Class frmReporte
    Dim Conexion As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)


    Private Sub frmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        If conFecha Then
            Adaptador.SelectCommand = New SqlCommand
            Adaptador.SelectCommand.Connection = Conexion
            Adaptador.SelectCommand.CommandText = reporte(reporteOpcion)
            Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@FI", SqlDbType.Date)
            Dim param2 = New SqlParameter("@FF", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(FI)
            param2.Value = CDate(FF)
            Adaptador.SelectCommand.Parameters.Add(param1)
            Adaptador.SelectCommand.Parameters.Add(param2)
            Adaptador.Fill(Data)
            Data.DataSetName = "Data1"
            Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
            Reportes.Name = "DataSet1"
            Reportes.Value = Data.Tables(0)
            Dim p1 As New ReportParameter("FI", FI)
            Dim p2 As New ReportParameter("FF", FF)
            Me.ReportViewer1.LocalReport.DataSources.Add(Reportes)
            Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\NETXBAX\Google Drive\SystemaRopa\SistemaTiendaRopa\SistemaVenta\" & reporte(reporteOpcion) & ".rdlc"
            ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})

        Else

            Cmd.CommandType = CommandType.StoredProcedure
            Adaptador.Fill(Data)
            Data.DataSetName = "DataSet1"
            Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
            Me.ReportViewer1.LocalReport.DataSources.Add(Reportes)
            Me.ReportViewer1.LocalReport.ReportPath = "C:\Users\NETXBAX\Google Drive\SystemaRopa\SistemaTiendaRopa\SistemaVenta\" & reporte(reporteOpcion) & ".rdlc"

        End If
        ReportViewer1.LocalReport.Refresh()
        Me.ReportViewer1.RefreshReport()

        'MsgBox(reporte(reporteOpcion))
    End Sub
End Class