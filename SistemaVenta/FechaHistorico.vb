Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Public Class FechaHistorico
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try
        Dim dateYear As String = fecha.Value.Year
            Dim conexionH = OpenHistorico()
            Dim commandH As SqlCommand = conexionH.CreateCommand()
            Dim conexionN = openConnection()
            Dim command As SqlCommand = conexionN.CreateCommand()
            Dim lector As SqlDataReader
            conexionN.close
            conexionH.close
            conexionN.open
            conexionH.open()

            'TRASPASO HISTORICO CATALOGOS
            'Pasa categorias
            commandH.CommandText = "DELETE Categorias"
            commandH.ExecuteNonQuery()

            command.CommandText = "SELECT * FROM Categorias"
            lector = command.ExecuteReader()
            While lector.Read
                commandH.CommandText = "INSERT INTO Categorias VALUES(" & lector(0) & ", '" & lector(1) & "', '" & lector(2) & "')"
                commandH.ExecuteNonQuery()
            End While
            lector.Close()

            'Pasa clientes
            commandH.CommandText = "DELETE Clientes"
            commandH.ExecuteNonQuery()
            command.CommandText = "SELECT * FROM Clientes"
            lector = command.ExecuteReader()
            While lector.Read
                commandH.CommandText = "INSERT INTO Clientes VALUES(@IdCliente, @Nombre, @Apellidos, @Calle, @Colonia, @Cp, @telefono, @Saldo)"
                commandH.Parameters.AddWithValue("@IdCliente", lector(0))
                commandH.Parameters.AddWithValue("@Nombre", lector(1))
                commandH.Parameters.AddWithValue("@Apellidos", lector(2))
                commandH.Parameters.AddWithValue("@Calle", lector(3))
                commandH.Parameters.AddWithValue("@Colonia", lector(4))
                commandH.Parameters.AddWithValue("@Cp", lector(5))
                commandH.Parameters.AddWithValue("@Telefono", lector(6))
                commandH.Parameters.AddWithValue("@Saldo", lector(7))

                commandH.ExecuteNonQuery()
                commandH.Parameters.Clear()

            End While
            lector.Close()

            'Pasa Productos
            commandH.CommandText = "DELETE Productos"
            commandH.ExecuteNonQuery()
            command.CommandText = "SELECT * FROM Productos"
            lector = command.ExecuteReader()
            While lector.Read
                commandH.CommandText = "INSERT INTO Productos VALUES(@IdProducto, @IdCategoria, @Nombre, @Descripcion, @Talla, @Existencia, @ExistenciaApartado, @Maximo, @Minimo, @Costo, @Precio, @UltFecCompra)"
                commandH.Parameters.AddWithValue("@IdProducto", lector(0))
                commandH.Parameters.AddWithValue("@IdCategoria", lector(1))
                commandH.Parameters.AddWithValue("@Nombre", lector(2))
                commandH.Parameters.AddWithValue("@Descripcion", lector(3))
                commandH.Parameters.AddWithValue("@Talla", lector(4))
                commandH.Parameters.AddWithValue("@Existencia", lector(5))
                commandH.Parameters.AddWithValue("@ExistenciaApartado", lector(6))
                commandH.Parameters.AddWithValue("@Maximo", lector(7))
                commandH.Parameters.AddWithValue("@Minimo", lector(8))
                commandH.Parameters.AddWithValue("@Costo", lector(9))
                commandH.Parameters.AddWithValue("@Precio", lector(10))
                commandH.Parameters.AddWithValue("@UltFecCompra", lector(11))
                commandH.ExecuteNonQuery()
                commandH.Parameters.Clear()

            End While
            lector.Close()

            'Pasa Proveedores
            commandH.CommandText = "TRUNCATE TABLE Proveedores"
            commandH.ExecuteNonQuery()
            commandH.CommandText = "DELETE Proveedores"
            commandH.ExecuteNonQuery()
            command.CommandText = "SELECT * FROM Proveedores"
            lector = command.ExecuteReader()
            While lector.Read
                commandH.CommandText = "INSERT INTO Proveedores VALUES(@IdProveedor, @Nombre, @RFC, @Calle, @Colonia, @Cp,@Telefono)"
                commandH.Parameters.AddWithValue("@IdProveedor", lector(0))
                commandH.Parameters.AddWithValue("@Nombre", lector(1))
                commandH.Parameters.AddWithValue("@RFC", lector(2))
                commandH.Parameters.AddWithValue("@Calle", lector(3))
                commandH.Parameters.AddWithValue("@Colonia", lector(4))
                commandH.Parameters.AddWithValue("@Cp", lector(5))
                commandH.Parameters.AddWithValue("@Telefono", lector(6))
                commandH.ExecuteNonQuery()
                commandH.Parameters.Clear()

            End While
            lector.Close()
            'TRASPASO HISTORICO DE MOVIMIENTOS Y DETALLES
            'Pasa compras
            command.CommandText = "select * from Compras where year(Compras.FechaCompra) =" & dateYear
            lector = command.ExecuteReader()
            While lector.Read()
                commandH.CommandText = "insert into Compras values(" & lector(0) & "," & lector(1) & ", '" & lector(2) & "','" & lector(3) & "','" & lector(4) & "','" & lector(5) & "','" & lector(6) & "')"
                commandH.ExecuteNonQuery()
            End While
            lector.Close()

            'Pasa DetCompras
            command.CommandText = "select DetCompras.IdCompra,DetCompras.IdProducto,DetCompras.Cantidad,DetCompras.Costo from DetCompras inner join Compras on DetCompras.IdCompra = Compras.IdCompra and year(Compras.FechaCompra) =" & dateYear
            lector = command.ExecuteReader()
            While lector.Read()
                commandH.CommandText = "insert into DetCompras values('" & lector(0) & "','" & lector(1) & "', '" & lector(2) & "','" & lector(3) & "')"
                commandH.ExecuteNonQuery()
            End While
            lector.Close()

            'Pasa Devoluciones
            command.CommandText = "select * from Devoluciones where year(Devoluciones.FechaDevolucion) = " & dateYear
            lector = command.ExecuteReader()
            While lector.Read()
                commandH.CommandText = "insert into Devoluciones values(" & lector(0) & "," & lector(1) & ", '" & lector(2) & "','" & lector(3) & "')"
                commandH.ExecuteNonQuery()
            End While
            lector.Close()

            'Pasa DetDevoluciones
            command.CommandText = "select DetDevoluciones.IdDevolucion,DetDevoluciones.IdProducto,DetDevoluciones.Cantidad from DetDevoluciones inner join Devoluciones on DetDevoluciones.IdDevolucion = Devoluciones.IdDevolucion and year(Devoluciones.FechaDevolucion) = " & dateYear
            lector = command.ExecuteReader()
            While lector.Read()
            commandH.CommandText = "insert into DetDevoluciones values(" & lector(0) & "," & lector(1) & ", '" & lector(2) & "')"
            commandH.ExecuteNonQuery()
            End While
            lector.Close()

            'Pasa ventas
            command.CommandText = "select * from Ventas where year(Ventas.FechaVenta) = " & dateYear
            lector = command.ExecuteReader()
            While lector.Read()
                commandH.CommandText = "insert into Ventas values('" & lector(0) & "','" & lector(1) & "', '" & lector(2) & "','" & lector(3) & "','" & lector(4) & "','" & lector(5) & "','" & lector(6) & "','" & lector(7) & "','" & lector(8) & "')"
                commandH.ExecuteNonQuery()
            End While
            lector.Close()

            'Pasa DetVentas
            command.CommandText = "select DetVentas.IdVenta,IdProducto,Cantidad,Precio from DetVentas inner join Ventas on DetVentas.IdVenta = Ventas.IdVenta and year(Ventas.FechaVenta) = " & dateYear
            lector = command.ExecuteReader()
            While lector.Read()
                commandH.CommandText = "insert into DetVentas values(" & lector(0) & "," & lector(1) & ", '" & lector(2) & "','" & lector(3) & "')"
                commandH.ExecuteNonQuery()
            End While
            lector.Close()

            'Pasa apartados
            command.CommandText = "select * from Apartados where Apartados.Estado = 'P' and year(Apartados.FechaApartado) = " & dateYear
            lector = command.ExecuteReader()
            While lector.Read()
                commandH.CommandText = "insert into Apartados values('" & lector(0) & "','" & lector(1) & "', '" & lector(2) & "','" & lector(3) & "','" & lector(4) & "','" & lector(5) & "','" & lector(6) & "','" & lector(7) & "','" & lector(8) & "')"
                commandH.ExecuteNonQuery()
            End While
            lector.Close()

            'Pasa DetApartados
            command.CommandText = "select DetApartados.IdApartado,DetApartados.IdProducto,DetApartados.Cantidad,DetApartados.Precio from DetApartados inner join Apartados on DetApartados.IdApartado = Apartados.IdApartado and Apartados.Estado = 'P' and year(Apartados.FechaApartado) = " & dateYear
            lector = command.ExecuteReader()
            While lector.Read()
            commandH.CommandText = "insert into DetApartados values(" & lector(0) & "," & lector(1) & ", '" & lector(2) & "','" & lector(3) & "')"
            commandH.ExecuteNonQuery()
            End While
            lector.Close()

            'Pasa Abonos Apartados
            command.CommandText = "select * from Abonos where year(Abonos.FechaAbono) = " & dateYear
            lector = command.ExecuteReader()
            While lector.Read()
                commandH.CommandText = "insert into Abonos values(" & lector(0) & "," & lector(1) & ", '" & lector(2) & "'," & lector(3) & ")"
                commandH.ExecuteNonQuery()
            End While
            lector.Close()

            'Eliminar tablas de movimientos
            'eliminar compras
            commandH.CommandText = "select Compras.IdCompra from Compras where year(Compras.FechaCompra) =" & dateYear
            lector = commandH.ExecuteReader()
            While lector.Read()
                command.CommandText = "delete DetCompras where DetCompras.IdCompra = " & lector(0)
                command.ExecuteNonQuery()
            command.CommandText = "delete Compras where Compras.IdCompra = " & lector(0)
            command.ExecuteNonQuery()
            End While
        lector.Close()

        'eliminar Devoluviones
        commandH.CommandText = "select Devoluciones.IdDevolucion from Devoluciones where year(Devoluciones.FechaDevolucion) =" & dateYear
        lector = commandH.ExecuteReader()
        While lector.Read()
            command.CommandText = "delete DetDevoluciones where DetDevoluciones.IdDevolucion = " & lector(0)
            command.ExecuteNonQuery()
            command.CommandText = "delete Devoluciones where Devoluciones.IdDevolucion =" & lector(0)
            command.ExecuteNonQuery()
        End While
        lector.Close()

        'eliminar ventas
        commandH.CommandText = "select Ventas.IdVenta from Ventas where year(Ventas.FechaVenta) =" & dateYear
        lector = commandH.ExecuteReader()
            While lector.Read()
                command.CommandText = "delete DetVentas where DetVentas.IdVenta = " & lector(0)
                command.ExecuteNonQuery()
            command.CommandText = "delete Ventas where Ventas.IdVenta = " & lector(0)
            command.ExecuteNonQuery()
            End While
        lector.Close()

        'eliminar Abonos
        commandH.CommandText = "select Abonos.IdAbono from Abonos where year(Abonos.FechaAbono) =" & dateYear
        lector = commandH.ExecuteReader()
        While lector.Read()
            command.CommandText = "delete Abonos where Abonos.IdAbono =" & lector(0)
            command.ExecuteNonQuery()
        End While
        lector.Close()

        'eliminar apartados
        commandH.CommandText = "select Apartados.IdApartado from Apartados where Apartados.Estado = 'P' and YEAR(Apartados.FechaApartado) =" & dateYear
            lector = commandH.ExecuteReader()
            While lector.Read()
                command.CommandText = "delete DetApartados where DetApartados.IdApartado = " & lector(0)
                command.ExecuteNonQuery()
                command.CommandText = "delete Apartados where Apartados.IdApartado =" & lector(0)
                command.ExecuteNonQuery()
            End While
        lector.Close()



        MsgBox("Finalizado!")
        'Catch ex As Exception

        'End Try
    End Sub
End Class