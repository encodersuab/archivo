Public Class frmReportePorTomoMomento

    Private Sub cbMomentoContable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMomentoContable.SelectedIndexChanged

    End Sub

    Private Sub frmReportePorTomoMomento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'TODO: esta línea de código carga datos en la tabla 'BDArchivosDataSet.mostrar_registro_por_tomo_momentocontable' Puede moverla o quitarla según sea necesario.
        Me.mostrar_registro_por_tomo_momentocontableTableAdapter.Fill(Me.BDArchivosDataSet.mostrar_registro_por_tomo_momentocontable, cbMomentoContable.Text, txtNroTomo.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class