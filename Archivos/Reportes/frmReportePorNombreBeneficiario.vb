Public Class frmReportePorNombreBeneficiario

    Private Sub frmReportePorNombreBeneficiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'TODO: esta línea de código carga datos en la tabla 'BDArchivosDataSet.mostrar_registro_por_nombre_beneficiario' Puede moverla o quitarla según sea necesario.
        Me.mostrar_registro_por_nombre_beneficiarioTableAdapter.Fill(Me.BDArchivosDataSet.mostrar_registro_por_nombre_beneficiario, txtNombreBeneficiario.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class