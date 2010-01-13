<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zoznam_chybajuce_kont_strelby
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
        Me.all_clenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.zoznam_kontStrelby = New evidencia_spz.zoznam_kontStrelby
        Me.podla_zbrane_check = New System.Windows.Forms.CheckBox
        Me.podla_zbrane_combo = New System.Windows.Forms.ComboBox
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.all_clenoviaTableAdapter = New evidencia_spz.zoznam_kontStrelbyTableAdapters.all_clenoviaTableAdapter
        CType(Me.all_clenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zoznam_kontStrelby, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'all_clenoviaBindingSource
        '
        Me.all_clenoviaBindingSource.DataMember = "all_clenovia"
        Me.all_clenoviaBindingSource.DataSource = Me.zoznam_kontStrelby
        '
        'zoznam_kontStrelby
        '
        Me.zoznam_kontStrelby.DataSetName = "zoznam_kontStrelby"
        Me.zoznam_kontStrelby.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'podla_zbrane_check
        '
        Me.podla_zbrane_check.AutoSize = True
        Me.podla_zbrane_check.Location = New System.Drawing.Point(31, 12)
        Me.podla_zbrane_check.Name = "podla_zbrane_check"
        Me.podla_zbrane_check.Size = New System.Drawing.Size(188, 17)
        Me.podla_zbrane_check.TabIndex = 0
        Me.podla_zbrane_check.Text = "Vytvoriťzostavu podľa typu zbrane"
        Me.podla_zbrane_check.UseVisualStyleBackColor = True
        '
        'podla_zbrane_combo
        '
        Me.podla_zbrane_combo.Enabled = False
        Me.podla_zbrane_combo.FormattingEnabled = True
        Me.podla_zbrane_combo.Items.AddRange(New Object() {"Broková zbraň", "Guľová zbraň"})
        Me.podla_zbrane_combo.Location = New System.Drawing.Point(225, 10)
        Me.podla_zbrane_combo.Name = "podla_zbrane_combo"
        Me.podla_zbrane_combo.Size = New System.Drawing.Size(120, 21)
        Me.podla_zbrane_combo.TabIndex = 1
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "zoznam_kontStrelby_all_clenovia"
        ReportDataSource1.Value = Me.all_clenoviaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "evidencia_spz.zoznam_kont_strelby_report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 39)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(977, 319)
        Me.ReportViewer1.TabIndex = 2
        '
        'all_clenoviaTableAdapter
        '
        Me.all_clenoviaTableAdapter.ClearBeforeFill = True
        '
        'zoznam_chybajuce_kont_strelby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 370)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.podla_zbrane_combo)
        Me.Controls.Add(Me.podla_zbrane_check)
        Me.Name = "zoznam_chybajuce_kont_strelby"
        Me.Text = "Chýbajúce kont. streľby"
        CType(Me.all_clenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zoznam_kontStrelby, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents podla_zbrane_check As System.Windows.Forms.CheckBox
    Friend WithEvents podla_zbrane_combo As System.Windows.Forms.ComboBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents all_clenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents zoznam_kontStrelby As evidencia_spz.zoznam_kontStrelby
    Friend WithEvents all_clenoviaTableAdapter As evidencia_spz.zoznam_kontStrelbyTableAdapters.all_clenoviaTableAdapter
End Class
