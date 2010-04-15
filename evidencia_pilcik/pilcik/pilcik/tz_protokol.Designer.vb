<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tz_protokol
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.pilcikdbDataSet = New pilcik.pilcikdbDataSet
        Me.skusobna_komisiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.skusobna_komisiaTableAdapter = New pilcik.pilcikdbDataSetTableAdapters.skusobna_komisiaTableAdapter
        Me.KurzBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Protokol_kurzDataSet = New pilcik.protokol_kurzDataSet
        Me.KurzTableAdapter = New pilcik.protokol_kurzDataSetTableAdapters.kurzTableAdapter
        Me.ProtokolDataSet = New pilcik.protokolDataSet
        Me.OsobaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OsobaTableAdapter = New pilcik.protokolDataSetTableAdapters.osobaTableAdapter
        CType(Me.pilcikdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skusobna_komisiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Protokol_kurzDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProtokolDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsobaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "pilcikdbDataSet_skusobna_komisia"
        ReportDataSource1.Value = Me.skusobna_komisiaBindingSource
        ReportDataSource2.Name = "protokol_kurzDataSet_kurz"
        ReportDataSource2.Value = Me.KurzBindingSource
        ReportDataSource3.Name = "protokolDataSet_osoba"
        ReportDataSource3.Value = Me.OsobaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "pilcik.protokol_Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(726, 756)
        Me.ReportViewer1.TabIndex = 0
        '
        'pilcikdbDataSet
        '
        Me.pilcikdbDataSet.DataSetName = "pilcikdbDataSet"
        Me.pilcikdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'skusobna_komisiaBindingSource
        '
        Me.skusobna_komisiaBindingSource.DataMember = "skusobna_komisia"
        Me.skusobna_komisiaBindingSource.DataSource = Me.pilcikdbDataSet
        '
        'skusobna_komisiaTableAdapter
        '
        Me.skusobna_komisiaTableAdapter.ClearBeforeFill = True
        '
        'KurzBindingSource
        '
        Me.KurzBindingSource.DataMember = "kurz"
        Me.KurzBindingSource.DataSource = Me.Protokol_kurzDataSet
        '
        'Protokol_kurzDataSet
        '
        Me.Protokol_kurzDataSet.DataSetName = "protokol_kurzDataSet"
        Me.Protokol_kurzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KurzTableAdapter
        '
        Me.KurzTableAdapter.ClearBeforeFill = True
        '
        'ProtokolDataSet
        '
        Me.ProtokolDataSet.DataSetName = "protokolDataSet"
        Me.ProtokolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OsobaBindingSource
        '
        Me.OsobaBindingSource.DataMember = "osoba"
        Me.OsobaBindingSource.DataSource = Me.ProtokolDataSet
        '
        'OsobaTableAdapter
        '
        Me.OsobaTableAdapter.ClearBeforeFill = True
        '
        'tz_protokol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 756)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "tz_protokol"
        Me.Text = "tz_protokol"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pilcikdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skusobna_komisiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Protokol_kurzDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProtokolDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsobaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents skusobna_komisiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents pilcikdbDataSet As pilcik.pilcikdbDataSet
    Friend WithEvents skusobna_komisiaTableAdapter As pilcik.pilcikdbDataSetTableAdapters.skusobna_komisiaTableAdapter
    Friend WithEvents Protokol_kurzDataSet As pilcik.protokol_kurzDataSet
    Friend WithEvents KurzBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KurzTableAdapter As pilcik.protokol_kurzDataSetTableAdapters.kurzTableAdapter
    Friend WithEvents OsobaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProtokolDataSet As pilcik.protokolDataSet
    Friend WithEvents OsobaTableAdapter As pilcik.protokolDataSetTableAdapters.osobaTableAdapter

End Class
