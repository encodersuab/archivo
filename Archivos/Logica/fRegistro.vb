
Imports System.Data.SqlClient
Public Class fRegistro
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function insertar(ByVal dts As vRegistro) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_registro")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@FormularioNro", dts.gFormularioNro)
            cmd.Parameters.AddWithValue("@Boleto", dts.gBoleto)
            cmd.Parameters.AddWithValue("@NombreBeneficiario", dts.gNombreBeneficiario)
            cmd.Parameters.AddWithValue("@MomentoContable", dts.gMomentoContable)
            cmd.Parameters.AddWithValue("@NroTomo", dts.gNroTomo)
            cmd.Parameters.AddWithValue("@Gestion", dts.gGestion)
            cmd.Parameters.AddWithValue("@PeriodoAdeudado", dts.gPeriodoAdeudado)
            cmd.Parameters.AddWithValue("@FechaPago", dts.gFechaPago)
            cmd.Parameters.AddWithValue("@Tipo", dts.gTipo)
            cmd.Parameters.AddWithValue("@ImporteAdeudado", dts.gImporteAdeudado)
            cmd.Parameters.AddWithValue("@DescripcionDeuda", dts.gDescripcionDeuda)
            cmd.Parameters.AddWithValue("@CCNro", dts.gCCNro)
            cmd.Parameters.AddWithValue("@CCFechaPago", dts.gCCFechaPago)
            cmd.Parameters.AddWithValue("@CCImporteAdeudado", dts.gCCImporteAdeudado)
            cmd.Parameters.AddWithValue("@CHNro", dts.gCHNro)
            cmd.Parameters.AddWithValue("@CHFechaCobro", dts.gCHFechaCobro)
            cmd.Parameters.AddWithValue("@CHImporteCheque", dts.gCHImporteCheque)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function editar(ByVal dts As vRegistro) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_registro")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@FormularioNro", dts.gFormularioNro)
            cmd.Parameters.AddWithValue("@Boleto", dts.gBoleto)
            cmd.Parameters.AddWithValue("@NombreBeneficiario", dts.gNombreBeneficiario)
            cmd.Parameters.AddWithValue("@Id", dts.gid)
            cmd.Parameters.AddWithValue("@MomentoContable", dts.gMomentoContable)
            cmd.Parameters.AddWithValue("@NroTomo", dts.gNroTomo)
            cmd.Parameters.AddWithValue("@Gestion", dts.gGestion)
            cmd.Parameters.AddWithValue("@PeriodoAdeudado", dts.gPeriodoAdeudado)
            cmd.Parameters.AddWithValue("@FechaPago", dts.gFechaPago)
            cmd.Parameters.AddWithValue("@Tipo", dts.gTipo)
            cmd.Parameters.AddWithValue("@ImporteAdeudado", dts.gImporteAdeudado)
            cmd.Parameters.AddWithValue("@DescripcionDeuda", dts.gDescripcionDeuda)
            cmd.Parameters.AddWithValue("@CCNro", dts.gCCNro)
            cmd.Parameters.AddWithValue("@CCFechaPago", dts.gCCFechaPago)
            cmd.Parameters.AddWithValue("@CCImporteAdeudado", dts.gCCImporteAdeudado)
            cmd.Parameters.AddWithValue("@CHNro", dts.gCHNro)
            cmd.Parameters.AddWithValue("@CHFechaCobro", dts.gCHFechaCobro)
            cmd.Parameters.AddWithValue("@CHImporteCheque", dts.gCHImporteCheque)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function


    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_registro")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()

        End Try
    End Function
End Class
