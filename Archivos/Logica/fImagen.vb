Imports System.Data.SqlClient
Public Class fImagen
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_producto_emfopesbe")
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

    Public Function insertar(ByVal dts As vImagen) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_imagen")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@IdRegistro", dts.gIdRegistro)
            cmd.Parameters.AddWithValue("@CCNro", dts.gCCNro)
            cmd.Parameters.AddWithValue("@Descripcion", dts.gDescripcion)
            cmd.Parameters.AddWithValue("@imagen", dts.gimagen)
        
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function editar(ByVal dts As vImagen) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_imagen")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Id", dts.gid)
            cmd.Parameters.AddWithValue("@IdRegistro", dts.gIdRegistro)
            cmd.Parameters.AddWithValue("@CCNro", dts.gCCNro)
            cmd.Parameters.AddWithValue("@Descripcion", dts.gDescripcion)
            cmd.Parameters.AddWithValue("@imagen", dts.gImagen)

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
    Public Function eliminar(ByVal dts As vImagen) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_imagen")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@Id", SqlDbType.NVarChar, 50).Value = dts.gid

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
