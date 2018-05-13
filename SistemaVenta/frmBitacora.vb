Imports System.Data.SqlClient
Public Class frmBitacora
    Dim conexionBitacora = OpenBitacora()
    Dim BitacoraComando As SqlCommand = conexionBitacora.CreateCommand()
    Dim lector As SqlDataReader
    Private Sub frmBitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consBitacora()
    End Sub
    Private Sub consBitacora()
        Try
            cerrarBitacora()
            conexionBitacora.open()
            dgDatos.Rows.Clear()
            Dim r = "select * from Bitacora"
            BitacoraComando = New SqlCommand(r, conexionBitacora)
            lector = BitacoraComando.ExecuteReader
            While lector.Read
                dgDatos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
            lector.Close()
            cerrarBitacora()
        Catch ex As Exception

        End Try
    End Sub
End Class