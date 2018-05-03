Module opcionReporte
    Public FI, FF As String
    Public conFecha As Boolean = False
    Public reporteOpcion As Integer
    Public estado As Boolean = False
    Public venta As Boolean = False
    Public reporte = New String() {"REPORTEPROVEEDORES", "REPORTEEMPLEADOS", "REPORTECOMPRA", "REPORTECLIENTES", "REPORTEPRODUCTOS", "REPORTEVENTAS", "REPORTEAPARTADOS", "REPORTEDEVOLUCIONES", "REPORTEVENTASPERIODO", "REPORTEAPARTADOSPERIODO", "REPORTECOMPRASPERIODO", "REPORTEDEVOLUCIONESPERIODO", "REPORTEVENTASPERIODOESTADO", "REPORTEAPARTADOSPERIODOESTADO"}

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

End Module
