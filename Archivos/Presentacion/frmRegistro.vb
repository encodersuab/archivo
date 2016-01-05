Public Class frmRegistro
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim dts As New vRegistro
            Dim func As New fRegistro

            dts.gFormularioNro = txtFormularioNro.Text
            dts.gBoleto = txtBoleto.Text
            dts.gNombreBeneficiario = txtNombreBeneficiario.Text
            dts.gNroTomo = txtNroTomo.Text
            dts.gGestion = txtGestion.Text
            dts.gCCNro = txtCCNro.Text
            dts.gCHNro = txtCHNro.Text
            dts.gMomentoContable = txtMomentoContable.Text
            dts.gPeriodoAdeudado = txtPeriodoAdeudado.Text
            dts.gTipo = txtTipo.Text
            dts.gDescripcionDeuda = txtDescripcionDeuda.Text
            dts.gFechaPago = dtpFechaPago.Value
            dts.gCCFechaPago = dtpCCFechaPago.Value
            dts.gCHFechaCobro = dtpCHFechaCobro.Value
            dts.gImporteAdeudado = txtImporteAdeudado.Text
            dts.gCCImporteAdeudado = txtCCImporteAdeudado.Text
            dts.gCHImporteCheque = txtCHImporteCheque.Text

            If func.insertar(dts) Then
                MessageBox.Show("Archivo Registrado Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'mostrar()
                limpiar()
            Else
                MessageBox.Show("Archivo NO Registrado", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'mostrar()
                limpiar()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub limpiar()

        txtFormularioNro.Text = ""
        txtBoleto.Text = ""
        txtNroTomo.Text = ""
        txtGestion.Text = ""
        txtCCNro.Text = ""
        txtCHNro.Text = ""
        txtMomentoContable.Text = ""
        txtPeriodoAdeudado.Text = ""
        txtTipo.Text = ""
        txtDescripcionDeuda.Text = ""

        txtImporteAdeudado.Text = ""
        txtCCImporteAdeudado.Text = ""
        txtCHImporteCheque.Text = ""

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()

    End Sub

    Private Sub frmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCCNro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCCNro.KeyPress
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

        Me.txtCCNro.Text = Trim(Replace(Me.txtCCNro.Text, "  ", " "))
        txtCCNro.Select(txtCCNro.Text.Length, 0)
    End Sub

    Private Sub txtNroTomo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroTomo.KeyPress
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

        Me.txtNroTomo.Text = Trim(Replace(Me.txtNroTomo.Text, "  ", " "))
        txtNroTomo.Select(txtNroTomo.Text.Length, 0)
    End Sub

    Private Sub txtCHNro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCHNro.KeyPress
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

        Me.txtCHNro.Text = Trim(Replace(Me.txtCHNro.Text, "  ", " "))
        txtCHNro.Select(txtCHNro.Text.Length, 0)
    End Sub

    Private Sub txtFormularioNro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFormularioNro.KeyPress
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

        Me.txtFormularioNro.Text = Trim(Replace(Me.txtFormularioNro.Text, "  ", " "))
        txtFormularioNro.Select(txtFormularioNro.Text.Length, 0)
    End Sub

    Private Sub txtImporteAdeudado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporteAdeudado.KeyPress
         If Char.IsDigit(e.KeyChar) Then 
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," And Not txtImporteAdeudado.Text.IndexOf(",") Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtCCImporteAdeudado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCCImporteAdeudado.KeyPress
       If Char.IsDigit(e.KeyChar) Then 
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," And Not txtCCImporteAdeudado.Text.IndexOf(",") Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCHImporteCheque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCHImporteCheque.KeyPress
    If Char.IsDigit(e.KeyChar) Then 
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," And Not txtCHImporteCheque.Text.IndexOf(",") Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombreBeneficiario_TextChanged(sender As Object, e As EventArgs) Handles txtNombreBeneficiario.TextChanged

    End Sub
End Class