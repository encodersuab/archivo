<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportePorNroCheque
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
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumeroCheque = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BDArchivosDataSet = New Archivos.BDArchivosDataSet()
        Me.mostrar_registro_por_numero_chequeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_registro_por_numero_chequeTableAdapter = New Archivos.BDArchivosDataSetTableAdapters.mostrar_registro_por_numero_chequeTableAdapter()
        CType(Me.BDArchivosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_registro_por_numero_chequeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(315, 26)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Numero de Cheque"
        '
        'txtNumeroCheque
        '
        Me.txtNumeroCheque.Location = New System.Drawing.Point(147, 29)
        Me.txtNumeroCheque.MaxLength = 20
        Me.txtNumeroCheque.Name = "txtNumeroCheque"
        Me.txtNumeroCheque.Size = New System.Drawing.Size(144, 20)
        Me.txtNumeroCheque.TabIndex = 3
        '
        'ReportViewer1
        '
        ReportDataSource7.Name = "DataSet1"
        ReportDataSource7.Value = Me.mostrar_registro_por_numero_chequeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Archivos.rptReportePorNroCheque.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 55)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1056, 420)
        Me.ReportViewer1.TabIndex = 4
        '
        'BDArchivosDataSet
        '
        Me.BDArchivosDataSet.DataSetName = "BDArchivosDataSet"
        Me.BDArchivosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_registro_por_numero_chequeBindingSource
        '
        Me.mostrar_registro_por_numero_chequeBindingSource.DataMember = "mostrar_registro_por_numero_cheque"
        Me.mostrar_registro_por_numero_chequeBindingSource.DataSource = Me.BDArchivosDataSet
        '
        'mostrar_registro_por_numero_chequeTableAdapter
        '
        Me.mostrar_registro_por_numero_chequeTableAdapter.ClearBeforeFill = True
        '
        'frmReportePorNroCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 475)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtNumeroCheque)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Name = "frmReportePorNroCheque"
        Me.Text = "frmReportePorNroCheque"
        CType(Me.BDArchivosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_registro_por_numero_chequeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroCheque As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_registro_por_numero_chequeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BDArchivosDataSet As Archivos.BDArchivosDataSet
    Friend WithEvents mostrar_registro_por_numero_chequeTableAdapter As Archivos.BDArchivosDataSetTableAdapters.mostrar_registro_por_numero_chequeTableAdapter
End Class
