Imports System.Windows.Forms

Public Class frmCardadoImagen

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            If dlg.ShowDialog() = DialogResult.OK Then
                Imagen.BackgroundImage = Nothing
                Imagen.Image = New Bitmap(dlg.FileName)
                Imagen.SizeMode = PictureBoxSizeMode.StretchImage

            End If
        Catch ex As Exception
            MessageBox.Show("El formato es incorrecto ", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmCardadoImagen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Imagen.Image = Nothing
        Imagen.BackgroundImage = My.Resources.fondo_transparente_fotos
        Imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente Desea Guardar la Imagen", "Guardando Imagen", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                Dim dts As New vImagen
                Dim func As New fImagen


                dts.gCCNro = txtCCNro.Text
                dts.gDescripcion = txtDescripcion.Text
                dts.gIdRegistro = txtIdRegistro.Text


                Dim ms As New IO.MemoryStream()
                If Not Imagen.Image Is Nothing Then
                    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                Else
                    Imagen.Image = My.Resources.fondo_transparente_fotos
                    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                End If

                dts.gImagen = ms.GetBuffer

                If func.insertar(dts) Then
                    MessageBox.Show("Producto registrado correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    limpiar()
                Else
                    MessageBox.Show("Producto no fue registrado", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    limpiar()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

      
    End Sub

    Public Sub limpiar()
        txtDescripcion.Text = ""
    

        Imagen.Image = Nothing
        Imagen.BackgroundImage = My.Resources.fondo_transparente_fotos
        Imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub


    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()

    End Sub
End Class