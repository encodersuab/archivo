Public Class frmEditarRegistro
    Private dt As New DataTable
    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDArchivosDataSet1.mostrar_registro' Puede moverla o quitarla según sea necesario.
        Me.Mostrar_registroTableAdapter.Fill(Me.BDArchivosDataSet1.mostrar_registro)
        mostrar()

    End Sub
    'Public Sub limpiar()
    '    btnGuardar.Visible = True
    '    btnEditar.Visible = False
    '    txtIdUsuario.Text = ""
    '    txtNombre.Text = ""
    '    txtApellido.Text = ""
    '    txtDireccion.Text = ""
    '    txtTelefono.Text = ""
    '    txtCi.Text = ""
    '    txtLogin.Text = ""
    '    txtContraceña.Text = ""
    '    txtAcceso.Text = ""
    '    txtRol.Text = "Administrador"


    'End Sub

    Private Sub mostrar()
        Try
            Dim func As New fRegistro
            dt = func.mostrar
            'datalistado.Columns.Item("Eliminar").Visible = False

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
        'btnNuevo.Visible = True
        btnEditar.Visible = False

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

   

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Esta Seguro en Realizar los Cambios?", "Modificardo registro", MessageBoxButtons.OKCancel)

        If result = DialogResult.OK Then

            '    If Me.ValidateChildren = True And txtNombre.Text <> "" And txtApellido.Text <> "" And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtCi.Text <> "" And txtIdUsuario.Text <> "" And txtLogin.Text <> "" And txtContraceña.Text <> "" And txtAcceso.Text <> "" And txtRol.Text <> "" Then
            Try
                Dim dts As New vRegistro
                Dim func As New fRegistro

                dts.gid = txtId.Text
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

                If func.editar(dts) Then
                    MessageBox.Show("Registro  Modificado Correctamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    'limpiar()
                Else
                    MessageBox.Show("Registro  NO Modificado", "Intente de Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    'limpiar()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'Else
            '    MessageBox.Show("error de datos faltante", "error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        'End If
    End Sub

    'Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
    '    'limpiar()
    '    mostrar()

    'End Sub

    'Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
    '    Me.Close()
    'End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick

        txtId.Text = datalistado.SelectedCells.Item(0).Value
        txtFormularioNro.Text = datalistado.SelectedCells.Item(1).Value
        txtBoleto.Text = datalistado.SelectedCells.Item(2).Value
        txtNombreBeneficiario.Text = datalistado.SelectedCells.Item(3).Value
        txtMomentoContable.Text = datalistado.SelectedCells.Item(4).Value
        txtNroTomo.Text = datalistado.SelectedCells.Item(5).Value
        txtGestion.Text = datalistado.SelectedCells.Item(6).Value
        txtPeriodoAdeudado.Text = datalistado.SelectedCells.Item(7).Value
        dtpFechaPago.Text = datalistado.SelectedCells.Item(8).Value
        txtTipo.Text = datalistado.SelectedCells.Item(9).Value
        txtImporteAdeudado.Text = datalistado.SelectedCells.Item(10).Value
        txtDescripcionDeuda.Text = datalistado.SelectedCells.Item(11).Value
        txtCCNro.Text = datalistado.SelectedCells.Item(12).Value
        dtpCCFechaPago.Text = datalistado.SelectedCells.Item(13).Value
        txtCCImporteAdeudado.Text = datalistado.SelectedCells.Item(14).Value
        txtCHNro.Text = datalistado.SelectedCells.Item(15).Value
        dtpCHFechaCobro.Text = datalistado.SelectedCells.Item(16).Value
        txtCHImporteCheque.Text = datalistado.SelectedCells.Item(17).Value

        btnEditar.Visible = True
        'btnGuardar.Visible = False

    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    'Private Sub btnEliminar_Click(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub txtIdUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtIdUsuario.TextChanged

    'End Sub

    'Private Sub txtIdUsuario_Validated(sender As Object, e As EventArgs) Handles txtIdUsuario.Validated

    'End Sub

    'Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    'End Sub

    'Private Sub txtNombre_Validated(sender As Object, e As EventArgs) Handles txtNombre.Validated
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.erroricono.SetError(sender, "")
    '    Else
    '        Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
    '    End If
    'End Sub

    'Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    'End Sub

    'Private Sub txtApellido_Validated(sender As Object, e As EventArgs) Handles txtApellido.Validated
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.erroricono.SetError(sender, "")
    '    Else
    '        Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
    '    End If
    'End Sub

    'Private Sub txtCi_TextChanged(sender As Object, e As EventArgs) Handles txtCi.TextChanged

    'End Sub

    'Private Sub txtCi_Validated(sender As Object, e As EventArgs) Handles txtCi.Validated
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.erroricono.SetError(sender, "")
    '    Else
    '        Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
    '    End If
    'End Sub

    'Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged

    'End Sub

    'Private Sub txtDireccion_Validated(sender As Object, e As EventArgs) Handles txtDireccion.Validated
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.erroricono.SetError(sender, "")
    '    Else
    '        Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
    '    End If
    'End Sub

    'Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged

    'End Sub

    'Private Sub txtTelefono_Validated(sender As Object, e As EventArgs) Handles txtTelefono.Validated
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.erroricono.SetError(sender, "")
    '    Else
    '        Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
    '    End If
    'End Sub

    'Private Sub txtLogin_TextChanged(sender As Object, e As EventArgs) Handles txtLogin.TextChanged

    'End Sub

    'Private Sub txtLogin_Validated(sender As Object, e As EventArgs) Handles txtLogin.Validated
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.erroricono.SetError(sender, "")
    '    Else
    '        Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
    '    End If
    'End Sub

    'Private Sub txtContraceña_TextChanged(sender As Object, e As EventArgs) Handles txtContraceña.TextChanged

    'End Sub

    'Private Sub txtContraceña_Validated(sender As Object, e As EventArgs) Handles txtContraceña.Validated
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.erroricono.SetError(sender, "")
    '    Else
    '        Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
    '    End If
    'End Sub

    'Private Sub txtAcceso_TextChanged(sender As Object, e As EventArgs) Handles txtAcceso.TextChanged

    'End Sub

    'Private Sub txtAcceso_Validated(sender As Object, e As EventArgs) Handles txtAcceso.Validated
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.erroricono.SetError(sender, "")
    '    Else
    '        Me.erroricono.SetError(sender, "ingrese el nombre del cliente, ese dato es obligatorio")
    '    End If
    'End Sub

    'Private Sub txtRol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtRol.SelectedIndexChanged

    'End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        'Me.Close()
    End Sub


    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub


    Private Sub txtNroTomo_TextChanged(sender As Object, e As EventArgs) Handles txtNroTomo.TextChanged

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
End Class


