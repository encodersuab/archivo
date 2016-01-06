Public Class frmReporte
    Private dt As New DataTable
    Private Sub frmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub
   

    Private Sub mostrar()
        Try
            Dim func As New fRegistro
            dt = func.mostrar

            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtBuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                Inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                txtBuscar.Enabled = False
                datalistado.ColumnHeadersVisible = True
                Inexistente.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
      

        Buscar()

    End Sub

    Private Sub Buscar()

        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cbxListadoClientes.Text & " Like '" & txtBuscar.Text & "%'"

            If dv.Count <> 0 Then
                Inexistente.Visible = False
                datalistado.DataSource = dv
                '    ocultar_columnas()
            Else
                Inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()

    End Sub







    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtId.Text = datalistado.SelectedCells.Item(1).Value
        txtNumeroFormulario.Text = datalistado.SelectedCells.Item(2).Value
        txtBoleto.Text = datalistado.SelectedCells.Item(3).Value
        txtNombreBeneficiario.Text = datalistado.SelectedCells.Item(4).Value
        txtMomentoContable.Text = datalistado.SelectedCells.Item(5).Value
        txtNumeroTomo.Text = datalistado.SelectedCells.Item(6).Value
        txtGestion.Text = datalistado.SelectedCells.Item(7).Value
        txtPeriodoAdeudado.Text = datalistado.SelectedCells.Item(8).Value
        txtFechaPago.Text = datalistado.SelectedCells.Item(9).Value
        txtTipo.Text = datalistado.SelectedCells.Item(10).Value
        txtImporteAdeudado.Text = datalistado.SelectedCells.Item(11).Value
        txtDescripcionDeuda.Text = datalistado.SelectedCells.Item(12).Value
        txtCCNro.Text = datalistado.SelectedCells.Item(13).Value
        txtCCFechaPago.Text = datalistado.SelectedCells.Item(14).Value
        txtCCImporteAdeudado.Text = datalistado.SelectedCells.Item(15).Value
        txtCHNro.Text = datalistado.SelectedCells.Item(16).Value
        txtFechaCobro.Text = datalistado.SelectedCells.Item(17).Value
        txtImporteCheque.Text = datalistado.SelectedCells.Item(18).Value




    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

      

        frmCardadoImagen.txtCCNro.Text = Me.txtCCNro.Text
        frmCardadoImagen.txtIdRegistro.Text = Me.txtId.Text
        frmCardadoImagen.ShowDialog()



    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub datalistado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick

    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        frmReporteImagenes.txtCCNro.Text = Me.txtCCNro.Text
        frmReporteImagenes.Show()
    End Sub
End Class