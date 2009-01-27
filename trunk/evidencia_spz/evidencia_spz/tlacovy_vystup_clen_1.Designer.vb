<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tlacovy_vystup_clen_1
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
        Me.clenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.spz_evidenciaDataSet = New evidencia_spz.spz_evidenciaDataSet
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.clenoviaTableAdapter = New evidencia_spz.spz_evidenciaDataSetTableAdapters.clenoviaTableAdapter
        CType(Me.clenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spz_evidenciaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clenoviaBindingSource
        '
        Me.clenoviaBindingSource.DataMember = "clenovia"
        Me.clenoviaBindingSource.DataSource = Me.spz_evidenciaDataSet
        '
        'spz_evidenciaDataSet
        '
        Me.spz_evidenciaDataSet.DataSetName = "spz_evidenciaDataSet"
        Me.spz_evidenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "spz_evidenciaDataSet_clenovia"
        ReportDataSource1.Value = Me.clenoviaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "evidencia_spz.tlacovy_vystup_clen_report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(829, 598)
        Me.ReportViewer1.TabIndex = 0
        '
        'clenoviaTableAdapter
        '
        Me.clenoviaTableAdapter.ClearBeforeFill = True
        '
        'tlacovy_vystup_clen_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 598)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "tlacovy_vystup_clen_1"
        Me.Text = "Tlačový výstup - Člen"
        Me.TopMost = True
        CType(Me.clenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spz_evidenciaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents clenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents spz_evidenciaDataSet As evidencia_spz.spz_evidenciaDataSet
    Friend WithEvents clenoviaTableAdapter As evidencia_spz.spz_evidenciaDataSetTableAdapters.clenoviaTableAdapter
End Class
