<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tl_zostava_clenske
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
        Me.clenske_do_label = New System.Windows.Forms.Label
        Me.clenske_do_combo = New System.Windows.Forms.ComboBox
        Me.clenske_do_dataset = New evidencia_spz.clenske_do_dataset
        Me.all_clenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.all_clenoviaTableAdapter = New evidencia_spz.clenske_do_datasetTableAdapters.all_clenoviaTableAdapter
        CType(Me.clenske_do_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.all_clenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "clenske_do_dataset_all_clenovia"
        ReportDataSource1.Value = Me.all_clenoviaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "evidencia_spz.tl_zostava_clenske_do.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 33)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(902, 474)
        Me.ReportViewer1.TabIndex = 0
        '
        'clenske_do_label
        '
        Me.clenske_do_label.AutoSize = True
        Me.clenske_do_label.Location = New System.Drawing.Point(12, 9)
        Me.clenske_do_label.Name = "clenske_do_label"
        Me.clenske_do_label.Size = New System.Drawing.Size(100, 13)
        Me.clenske_do_label.TabIndex = 1
        Me.clenske_do_label.Text = "Členské najviac do:"
        '
        'clenske_do_combo
        '
        Me.clenske_do_combo.FormattingEnabled = True
        Me.clenske_do_combo.Items.AddRange(New Object() {"2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.clenske_do_combo.Location = New System.Drawing.Point(118, 6)
        Me.clenske_do_combo.Name = "clenske_do_combo"
        Me.clenske_do_combo.Size = New System.Drawing.Size(94, 21)
        Me.clenske_do_combo.TabIndex = 2
        '
        'clenske_do_dataset
        '
        Me.clenske_do_dataset.DataSetName = "clenske_do_dataset"
        Me.clenske_do_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'all_clenoviaBindingSource
        '
        Me.all_clenoviaBindingSource.DataMember = "all_clenovia"
        Me.all_clenoviaBindingSource.DataSource = Me.clenske_do_dataset
        '
        'all_clenoviaTableAdapter
        '
        Me.all_clenoviaTableAdapter.ClearBeforeFill = True
        '
        'tl_zostava_clenske
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 519)
        Me.Controls.Add(Me.clenske_do_combo)
        Me.Controls.Add(Me.clenske_do_label)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "tl_zostava_clenske"
        Me.Text = "Tl. zostava -Členské do"
        CType(Me.clenske_do_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.all_clenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents clenske_do_label As System.Windows.Forms.Label
    Friend WithEvents clenske_do_combo As System.Windows.Forms.ComboBox
    Friend WithEvents all_clenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents clenske_do_dataset As evidencia_spz.clenske_do_dataset
    Friend WithEvents all_clenoviaTableAdapter As evidencia_spz.clenske_do_datasetTableAdapters.all_clenoviaTableAdapter
End Class
