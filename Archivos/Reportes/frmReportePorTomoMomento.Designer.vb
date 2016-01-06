<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportePorTomoMomento
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMomentoContable = New System.Windows.Forms.ComboBox()
        Me.txtNroTomo = New System.Windows.Forms.NumericUpDown()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BDArchivosDataSet = New Archivos.BDArchivosDataSet()
        Me.mostrar_registro_por_tomo_momentocontableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_registro_por_tomo_momentocontableTableAdapter = New Archivos.BDArchivosDataSetTableAdapters.mostrar_registro_por_tomo_momentocontableTableAdapter()
        CType(Me.txtNroTomo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDArchivosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_registro_por_tomo_momentocontableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Numero de Tomo "
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(483, 25)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 30)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Momento Contable"
        '
        'cbMomentoContable
        '
        Me.cbMomentoContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMomentoContable.FormattingEnabled = True
        Me.cbMomentoContable.Items.AddRange(New Object() {"PREVENTIVO", "DEVENGADO"})
        Me.cbMomentoContable.Location = New System.Drawing.Point(309, 31)
        Me.cbMomentoContable.Name = "cbMomentoContable"
        Me.cbMomentoContable.Size = New System.Drawing.Size(121, 21)
        Me.cbMomentoContable.TabIndex = 9
        '
        'txtNroTomo
        '
        Me.txtNroTomo.Location = New System.Drawing.Point(124, 32)
        Me.txtNroTomo.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txtNroTomo.Name = "txtNroTomo"
        Me.txtNroTomo.Size = New System.Drawing.Size(62, 20)
        Me.txtNroTomo.TabIndex = 10
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_registro_por_tomo_momentocontableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Archivos.rptReportePorTomoMomento.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 73)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(679, 370)
        Me.ReportViewer1.TabIndex = 11
        '
        'BDArchivosDataSet
        '
        Me.BDArchivosDataSet.DataSetName = "BDArchivosDataSet"
        Me.BDArchivosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_registro_por_tomo_momentocontableBindingSource
        '
        Me.mostrar_registro_por_tomo_momentocontableBindingSource.DataMember = "mostrar_registro_por_tomo_momentocontable"
        Me.mostrar_registro_por_tomo_momentocontableBindingSource.DataSource = Me.BDArchivosDataSet
        '
        'mostrar_registro_por_tomo_momentocontableTableAdapter
        '
        Me.mostrar_registro_por_tomo_momentocontableTableAdapter.ClearBeforeFill = True
        '
        'frmReportePorTomoMomento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 444)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtNroTomo)
        Me.Controls.Add(Me.cbMomentoContable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Name = "frmReportePorTomoMomento"
        Me.Text = "frmReportePorTomoMomento"
        CType(Me.txtNroTomo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDArchivosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_registro_por_tomo_momentocontableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbMomentoContable As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroTomo As System.Windows.Forms.NumericUpDown
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_registro_por_tomo_momentocontableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BDArchivosDataSet As Archivos.BDArchivosDataSet
    Friend WithEvents mostrar_registro_por_tomo_momentocontableTableAdapter As Archivos.BDArchivosDataSetTableAdapters.mostrar_registro_por_tomo_momentocontableTableAdapter
End Class
