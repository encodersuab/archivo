Public Class frmReporteImagenes

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'BDArchivosDataSet.mostrar_imagenes_por_CCNro' Puede moverla o quitarla según sea necesario.
        Me.mostrar_imagenes_por_CCNroTableAdapter.Fill(Me.BDArchivosDataSet.mostrar_imagenes_por_CCNro, CInt(txtCCNro.Text))

        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub btnMostrarImagen_Click(sender As Object, e As EventArgs) Handles btnMostrarImagen.Click
        'TODO: esta línea de código carga datos en la tabla 'BDArchivosDataSet.mostrar_imagenes_por_CCNro' Puede moverla o quitarla según sea necesario.
        Me.mostrar_imagenes_por_CCNroTableAdapter.Fill(Me.BDArchivosDataSet.mostrar_imagenes_por_CCNro, CInt(txtCCNro.Text))

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class