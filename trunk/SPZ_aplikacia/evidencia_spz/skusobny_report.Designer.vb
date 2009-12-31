<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class skusobny_report
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
        Me.all_clenoviaDataSet = New evidencia_spz.all_clenoviaDataSet
        Me.all_clenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.all_clenoviaTableAdapter = New evidencia_spz.all_clenoviaDataSetTableAdapters.all_clenoviaTableAdapter
        CType(Me.all_clenoviaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.all_clenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "all_clenoviaDataSet_all_clenovia"
        ReportDataSource1.Value = Me.all_clenoviaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "evidencia_spz.skusobny_report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(866, 515)
        Me.ReportViewer1.TabIndex = 0
        '
        'all_clenoviaDataSet
        '
        Me.all_clenoviaDataSet.DataSetName = "all_clenoviaDataSet"
        Me.all_clenoviaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'all_clenoviaBindingSource
        '
        Me.all_clenoviaBindingSource.DataMember = "all_clenovia"
        Me.all_clenoviaBindingSource.DataSource = Me.all_clenoviaDataSet
        '
        'all_clenoviaTableAdapter
        '
        Me.all_clenoviaTableAdapter.ClearBeforeFill = True
        '
        'skusobny_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 515)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "skusobny_report"
        Me.Text = "skusobny_report"
        CType(Me.all_clenoviaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.all_clenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents all_clenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents all_clenoviaDataSet As evidencia_spz.all_clenoviaDataSet
    Friend WithEvents all_clenoviaTableAdapter As evidencia_spz.all_clenoviaDataSetTableAdapters.all_clenoviaTableAdapter
End Class
