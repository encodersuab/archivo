<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteImagenes
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
        Me.mostrar_imagenes_por_CCNroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDArchivosDataSet = New Archivos.BDArchivosDataSet()
        Me.btnMostrarImagen = New System.Windows.Forms.Button()
        Me.txtCCNro = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.mostrar_imagenes_por_CCNroTableAdapter = New Archivos.BDArchivosDataSetTableAdapters.mostrar_imagenes_por_CCNroTableAdapter()
        CType(Me.mostrar_imagenes_por_CCNroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDArchivosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mostrar_imagenes_por_CCNroBindingSource
        '
        Me.mostrar_imagenes_por_CCNroBindingSource.DataMember = "mostrar_imagenes_por_CCNro"
        Me.mostrar_imagenes_por_CCNroBindingSource.DataSource = Me.BDArchivosDataSet
        '
        'BDArchivosDataSet
        '
        Me.BDArchivosDataSet.DataSetName = "BDArchivosDataSet"
        Me.BDArchivosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnMostrarImagen
        '
        Me.btnMostrarImagen.Location = New System.Drawing.Point(477, 30)
        Me.btnMostrarImagen.Name = "btnMostrarImagen"
        Me.btnMostrarImagen.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrarImagen.TabIndex = 0
        Me.btnMostrarImagen.Text = "Buscar"
        Me.btnMostrarImagen.UseVisualStyleBackColor = True
        '
        'txtCCNro
        '
        Me.txtCCNro.Location = New System.Drawing.Point(339, 30)
        Me.txtCCNro.Name = "txtCCNro"
        Me.txtCCNro.Size = New System.Drawing.Size(100, 20)
        Me.txtCCNro.TabIndex = 1
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_imagenes_por_CCNroBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Archivos.rptReporteImagen.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(738, 614)
        Me.ReportViewer1.TabIndex = 2
        '
        'mostrar_imagenes_por_CCNroTableAdapter
        '
        Me.mostrar_imagenes_por_CCNroTableAdapter.ClearBeforeFill = True
        '
        'frmReporteImagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 613)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtCCNro)
        Me.Controls.Add(Me.btnMostrarImagen)
        Me.MaximizeBox = False
        Me.Name = "frmReporteImagenes"
        Me.Text = "Formulario de Reporte de Imagen"
        CType(Me.mostrar_imagenes_por_CCNroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDArchivosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMostrarImagen As System.Windows.Forms.Button
    Friend WithEvents txtCCNro As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_imagenes_por_CCNroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BDArchivosDataSet As Archivos.BDArchivosDataSet
    Friend WithEvents mostrar_imagenes_por_CCNroTableAdapter As Archivos.BDArchivosDataSetTableAdapters.mostrar_imagenes_por_CCNroTableAdapter
End Class
