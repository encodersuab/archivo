Public Class frmReportePorNroCheque

    Private Sub frmReportePorNroCheque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.mostrar_registro_por_numero_chequeTableAdapter.Fill(Me.BDArchivosDataSet.mostrar_registro_por_numero_cheque, txtNumeroCheque.Text)

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        'TODO: esta línea de código carga datos en la tabla 'BDArchivosDataSet.mostrar_registro_por_numero_cheque' Puede moverla o quitarla según sea necesario.
        Me.mostrar_registro_por_numero_chequeTableAdapter.Fill(Me.BDArchivosDataSet.mostrar_registro_por_numero_cheque, txtNumeroCheque.Text)

        Me.ReportViewer1.RefreshReport()



    End Sub

    Private Sub txtNumeroCheque_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroCheque.TextChanged

    End Sub

    Private Sub txtNumeroCheque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroCheque.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        Me.txtNumeroCheque.Text = Trim(Replace(Me.txtNumeroCheque.Text, "  ", " "))
        txtNumeroCheque.Select(txtNumeroCheque.Text.Length, 0)
    End Sub
End Class