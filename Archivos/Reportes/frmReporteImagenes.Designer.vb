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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCCNro = New System.Windows.Forms.TextBox()
        Me.BDArchivosDataSet1 = New Archivos.BDArchivosDataSet1()
        Me.mostrar_imagenes_por_CCNroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_imagenes_por_CCNroTableAdapter = New Archivos.BDArchivosDataSet1TableAdapters.mostrar_imagenes_por_CCNroTableAdapter()
        CType(Me.BDArchivosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_imagenes_por_CCNroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSImagenes"
        ReportDataSource1.Value = Me.mostrar_imagenes_por_CCNroBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Archivos.rptReporteImagenes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(835, 448)
        Me.ReportViewer1.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(361, 42)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Numero de Comprobante de Contabilidad"
        '
        'txtCCNro
        '
        Me.txtCCNro.Location = New System.Drawing.Point(236, 42)
        Me.txtCCNro.Name = "txtCCNro"
        Me.txtCCNro.Size = New System.Drawing.Size(100, 20)
        Me.txtCCNro.TabIndex = 3
        '
        'BDArchivosDataSet1
        '
        Me.BDArchivosDataSet1.DataSetName = "BDArchivosDataSet1"
        Me.BDArchivosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_imagenes_por_CCNroBindingSource
        '
        Me.mostrar_imagenes_por_CCNroBindingSource.DataMember = "mostrar_imagenes_por_CCNro"
        Me.mostrar_imagenes_por_CCNroBindingSource.DataSource = Me.BDArchivosDataSet1
        '
        'mostrar_imagenes_por_CCNroTableAdapter
        '
        Me.mostrar_imagenes_por_CCNroTableAdapter.ClearBeforeFill = True
        '
        'frmReporteImagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 448)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtCCNro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Name = "frmReporteImagenes"
        Me.Text = "frmReporteImagenes"
        CType(Me.BDArchivosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_imagenes_por_CCNroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_imagenes_por_CCNroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BDArchivosDataSet1 As Archivos.BDArchivosDataSet1
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCCNro As System.Windows.Forms.TextBox
    Friend WithEvents mostrar_imagenes_por_CCNroTableAdapter As Archivos.BDArchivosDataSet1TableAdapters.mostrar_imagenes_por_CCNroTableAdapter
End Class
