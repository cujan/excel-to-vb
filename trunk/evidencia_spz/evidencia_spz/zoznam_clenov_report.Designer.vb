<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zoznam_clenov_report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.clenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.spz_zoznam_clenov_reportDataSet1 = New evidencia_spz.spz_zoznam_clenov_reportDataSet1
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.clenoviaTableAdapter = New evidencia_spz.spz_zoznam_clenov_reportDataSet1TableAdapters.clenoviaTableAdapter
        Me.spz_evidenciaDataSet = New evidencia_spz.spz_evidenciaDataSet
        Me.spz_clenovia_report_a4 = New evidencia_spz.spz_clenovia_report_a4
        CType(Me.clenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spz_zoznam_clenov_reportDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spz_evidenciaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spz_clenovia_report_a4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clenoviaBindingSource
        '
        Me.clenoviaBindingSource.DataMember = "clenovia"
        Me.clenoviaBindingSource.DataSource = Me.spz_zoznam_clenov_reportDataSet1
        '
        'spz_zoznam_clenov_reportDataSet1
        '
        Me.spz_zoznam_clenov_reportDataSet1.DataSetName = "spz_zoznam_clenov_reportDataSet1"
        Me.spz_zoznam_clenov_reportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "spz_zoznam_clenov_reportDataSet1_clenovia"
        ReportDataSource1.Value = Me.clenoviaBindingSource
        ReportDataSource2.Name = "spz_clenovia_report_a4_clenovia"
        ReportDataSource2.Value = Me.clenoviaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "evidencia_spz.zoznam_clenov_report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(805, 521)
        Me.ReportViewer1.TabIndex = 0
        '
        'clenoviaTableAdapter
        '
        Me.clenoviaTableAdapter.ClearBeforeFill = True
        '
        'spz_evidenciaDataSet
        '
        Me.spz_evidenciaDataSet.DataSetName = "spz_evidenciaDataSet"
        Me.spz_evidenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spz_clenovia_report_a4
        '
        Me.spz_clenovia_report_a4.DataSetName = "spz_clenovia_report_a4"
        Me.spz_clenovia_report_a4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'zoznam_clenov_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 521)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "zoznam_clenov_report"
        Me.Text = "Zoznam členov SPZ"
        CType(Me.clenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spz_zoznam_clenov_reportDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spz_evidenciaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spz_clenovia_report_a4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents clenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents spz_zoznam_clenov_reportDataSet1 As evidencia_spz.spz_zoznam_clenov_reportDataSet1
    Friend WithEvents clenoviaTableAdapter As evidencia_spz.spz_zoznam_clenov_reportDataSet1TableAdapters.clenoviaTableAdapter
    Friend WithEvents spz_evidenciaDataSet As evidencia_spz.spz_evidenciaDataSet
    Friend WithEvents spz_clenovia_report_a4 As evidencia_spz.spz_clenovia_report_a4
End Class
