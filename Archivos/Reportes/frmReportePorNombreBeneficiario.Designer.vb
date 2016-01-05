<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportePorNombreBeneficiario
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BDArchivosDataSet = New Archivos.BDArchivosDataSet()
        Me.mostrar_registro_por_nombre_beneficiarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_registro_por_nombre_beneficiarioTableAdapter = New Archivos.BDArchivosDataSetTableAdapters.mostrar_registro_por_nombre_beneficiarioTableAdapter()
        Me.txtNombreBeneficiario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.BDArchivosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_registro_por_nombre_beneficiarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_registro_por_nombre_beneficiarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Archivos.rptReportepórNombreCliente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 82)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1124, 388)
        Me.ReportViewer1.TabIndex = 0
        '
        'BDArchivosDataSet
        '
        Me.BDArchivosDataSet.DataSetName = "BDArchivosDataSet"
        Me.BDArchivosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_registro_por_nombre_beneficiarioBindingSource
        '
        Me.mostrar_registro_por_nombre_beneficiarioBindingSource.DataMember = "mostrar_registro_por_nombre_beneficiario"
        Me.mostrar_registro_por_nombre_beneficiarioBindingSource.DataSource = Me.BDArchivosDataSet
        '
        'mostrar_registro_por_nombre_beneficiarioTableAdapter
        '
        Me.mostrar_registro_por_nombre_beneficiarioTableAdapter.ClearBeforeFill = True
        '
        'txtNombreBeneficiario
        '
        Me.txtNombreBeneficiario.Location = New System.Drawing.Point(188, 42)
        Me.txtNombreBeneficiario.MaxLength = 20
        Me.txtNombreBeneficiario.Name = "txtNombreBeneficiario"
        Me.txtNombreBeneficiario.Size = New System.Drawing.Size(144, 20)
        Me.txtNombreBeneficiario.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre del Beneficiario"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(356, 39)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frmReportePorNombreBeneficiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 470)
        Me.Controls.Add(Me.txtNombreBeneficiario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReportePorNombreBeneficiario"
        Me.Text = "frmReportePorNombreBeneficiario"
        CType(Me.BDArchivosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_registro_por_nombre_beneficiarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_registro_por_nombre_beneficiarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BDArchivosDataSet As Archivos.BDArchivosDataSet
    Friend WithEvents mostrar_registro_por_nombre_beneficiarioTableAdapter As Archivos.BDArchivosDataSetTableAdapters.mostrar_registro_por_nombre_beneficiarioTableAdapter
    Friend WithEvents txtNombreBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
