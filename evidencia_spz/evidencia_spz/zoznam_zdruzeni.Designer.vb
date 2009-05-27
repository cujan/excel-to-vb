<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zoznam_zdruzeni
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.spz_evidencia_zoznam_zdruzeni = New evidencia_spz.spz_evidencia_zoznam_zdruzeni
        Me.zdruzenieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.zdruzenieTableAdapter = New evidencia_spz.spz_evidencia_zoznam_zdruzeniTableAdapters.zdruzenieTableAdapter
        CType(Me.spz_evidencia_zoznam_zdruzeni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zdruzenieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "spz_evidencia_zoznam_zdruzeni_zdruzenie"
        ReportDataSource1.Value = Me.zdruzenieBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "evidencia_spz.zoznam_zdruzeni_report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(795, 596)
        Me.ReportViewer1.TabIndex = 0
        '
        'spz_evidencia_zoznam_zdruzeni
        '
        Me.spz_evidencia_zoznam_zdruzeni.DataSetName = "spz_evidencia_zoznam_zdruzeni"
        Me.spz_evidencia_zoznam_zdruzeni.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'zdruzenieBindingSource
        '
        Me.zdruzenieBindingSource.DataMember = "zdruzenie"
        Me.zdruzenieBindingSource.DataSource = Me.spz_evidencia_zoznam_zdruzeni
        '
        'zdruzenieTableAdapter
        '
        Me.zdruzenieTableAdapter.ClearBeforeFill = True
        '
        'zoznam_zdruzeni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 596)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "zoznam_zdruzeni"
        Me.Text = "Zoznam združení"
        CType(Me.spz_evidencia_zoznam_zdruzeni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zdruzenieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents zdruzenieBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents spz_evidencia_zoznam_zdruzeni As evidencia_spz.spz_evidencia_zoznam_zdruzeni
    Friend WithEvents zdruzenieTableAdapter As evidencia_spz.spz_evidencia_zoznam_zdruzeniTableAdapters.zdruzenieTableAdapter
End Class
