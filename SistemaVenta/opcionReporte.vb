Imports System.Data.SqlClient
Imports System.Configuration
Module opcionReporte
    Public FI, FF, EDO As String
    Public conFecha As Boolean = False
    Public conEstado As Boolean = False
    Public reporteOpcion As Integer
    Public venta As Boolean = False
    Public reporte = New String() {"REPORTEPROVEEDORES", "REPORTEEMPLEADOS", "REPORTECOMPRA", "REPORTECLIENTES", "REPORTEPRODUCTOS", "REPORTEVENTAS", "REPORTEAPARTADOS", "REPORTEDEVOLUCIONES", "REPORTEVENTASPERIODO", "REPORTEAPARTADOSPERIODO", "REPORTECOMPRASPERIODO", "REPORTEDEVOLUCIONESPERIODO", "REPORTEVENTASPERIODOESTADO", "REPORTEAPARTADOSPERIODOESTADO"}
    Public estado As String = ""

    'CREATE PROCEDURE REPORTEPROVEEDORES As Select * FROM Proveedores
    'CREATE PROCEDURE REPORTEEMPLEADOS As Select * FROM Empleados 
    'CREATE PROCEDURE REPORTECLIENTES As Select * FROM Clientes
    'CREATE PROCEDURE REPORTECOMPRA As Select * FROM vwCompras
    'CREATE PROCEDURE REPORTEPRODUCTOS As Select * FROM vwProductos
    'CREATE PROCEDURE REPORTEVENTAS As Select * FROM vwVenta 
    'CREATE PROCEDURE REPORTEAPARTADOS As Select * FROM vwApartados 
    'CREATE PROCEDURE REPORTEDEVOLUCIONES As Select * FROM Devoluciones
    'CREATE PROCEDURE REPORTEVENTASPERIODOESTADO (@FI date, @FF date,@EDO varchar(1)) As Select * FROM vwVenta where vwVenta.FechaVenta between @FI and @FF and vwVenta.Estado = @EDO
    'CREATE PROCEDURE REPORTEAPARTADOSPERIODO (@FI date, @FF date) As Select * FROM vwApartados where vwApartados.FechaActivo between @FI and @FF
    'CREATE PROCEDURE REPORTECOMPRASPERIODO (@FI date, @FF date) As Select * FROM vwCompras where vwCompras.FechaCompra between @FI and @FF
    'CREATE PROCEDURE REPORTEDEVOLUCIONESPERIODO (@FI date, @FF date) As Select * FROM Devoluciones where Devoluciones.FechaDevolucion between @FI and @FF
    'CREATE PROCEDURE REPORTEAPARTADOSPERIODOESTADO (@FI date, @FF date,@EDO varchar(1)) As Select * FROM vwApartados where vwApartados.FechaActivo between @FI and @FF and vwApartados.Estado = @EDO

    Public Function openConnection()
        Dim conexionsql As SqlConnection
        conexionsql = New SqlConnection("Data Source=DESKTOP-NC9ERBN;Initial Catalog=SistemaRopa; Integrated Security='True';")

        Return conexionsql
    End Function
    Public Function cerrarConexion()
        Dim conexionsql As SqlConnection
        conexionsql = New SqlConnection("Data Source=DESKTOP-NC9ERBN;Initial Catalog=SistemaRopa; Integrated Security='True';")

        conexionsql.Close()

        Return conexionsql
    End Function
    Public Function OpenMaster()
        'Dim conexionBitacora As New SqlConnection("Data Source=DESKTOP-NC9ERBN;Initial Catalog=master; Integrated Security='True';")
        Dim conexionBitacora As New SqlConnection("Data Source = DESKTOP-NC9ERBN; initial catalog='master'; Integrated Security = True")

        Return conexionBitacora
    End Function
    Public Function OpenBitacora()
        Dim conexionBitacora As New SqlConnection("Data Source = DESKTOP-NC9ERBN; initial catalog='BitacoraSistemaRopa'; Integrated Security = True")

        Return conexionBitacora
    End Function

    Public Function cerrarBitacora()
        Dim conexionBitacora As New SqlConnection("Data Source = DESKTOP-NC9ERBN; initial catalog='BitacoraSistemaRopa'; Integrated Security = True")

        conexionBitacora.Close()

        Return conexionBitacora
    End Function
    Public Function cerrarMaster()
        Dim conexionBitacora As New SqlConnection("Data Source = DESKTOP-NC9ERBN; initial catalog='master'; Integrated Security = True")

        conexionBitacora.Close()

        Return conexionBitacora
    End Function
    Public Function quitarComillas(message As String)
        While message.Contains("'")
            Dim x As Integer = message.IndexOf("'")
            message = message.Remove(x, 1)
        End While
        Return message
    End Function
    Public moduloUsuario As String
    Public Function OpenHistorico()
        Dim conexionBitacora As New SqlConnection("Data Source =DESKTOP-NC9ERBN; initial catalog='hSistemaRopa'; Integrated Security = True")

        Return conexionBitacora
    End Function

    Public Function cerrarHistorico()
        Dim conexionBitacora As New SqlConnection("Data Source = DESKTOP-NC9ERBN; initial catalog='SistemaRopa'; Integrated Security = True")

        conexionBitacora.Close()

        Return conexionBitacora
    End Function
End Module
