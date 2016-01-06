Public Class frmReporteImagenes

    Private Sub frmReporteImagenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDArchivosDataSet1.mostrar_imagenes_por_CCNro' Puede moverla o quitarla según sea necesario.
        Me.mostrar_imagenes_por_CCNroTableAdapter.Fill(Me.BDArchivosDataSet1.mostrar_imagenes_por_CCNro, txtCCNro.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'TODO: esta línea de código carga datos en la tabla 'BDArchivosDataSet1.mostrar_imagenes_por_CCNro' Puede moverla o quitarla según sea necesario.
        Me.mostrar_imagenes_por_CCNroTableAdapter.Fill(Me.BDArchivosDataSet1.mostrar_imagenes_por_CCNro, txtCCNro.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class