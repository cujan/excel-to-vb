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
        Me.zdruzenie_check = New System.Windows.Forms.CheckBox
        Me.zdruzenie_combo = New System.Windows.Forms.ComboBox
        Me.ZdruzeniaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Zoznam_zdruzeni_combo = New evidencia_spz.zoznam_zdruzeni_combo
        Me.ZoznamzdruzenicomboBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZdruzeniaTableAdapter = New evidencia_spz.zoznam_zdruzeni_comboTableAdapters.zdruzeniaTableAdapter
        Me.nacitat_button = New System.Windows.Forms.Button
        CType(Me.all_clenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zoznam_kontStrelby, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzeniaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zoznam_zdruzeni_combo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZoznamzdruzenicomboBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.podla_zbrane_check.Size = New System.Drawing.Size(109, 17)
        Me.podla_zbrane_check.TabIndex = 0
        Me.podla_zbrane_check.Text = "Vzbrať typ zbrane"
        Me.podla_zbrane_check.UseVisualStyleBackColor = True
        '
        'podla_zbrane_combo
        '
        Me.podla_zbrane_combo.Enabled = False
        Me.podla_zbrane_combo.FormattingEnabled = True
        Me.podla_zbrane_combo.Items.AddRange(New Object() {"Broková zbraň", "Guľová zbraň"})
        Me.podla_zbrane_combo.Location = New System.Drawing.Point(146, 10)
        Me.podla_zbrane_combo.Name = "podla_zbrane_combo"
        Me.podla_zbrane_combo.Size = New System.Drawing.Size(97, 21)
        Me.podla_zbrane_combo.TabIndex = 1
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "zoznam_kontStrelby_all_clenovia"
        ReportDataSource1.Value = Me.all_clenoviaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "evidencia_spz.zoznam_kont_strelby_report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 64)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(977, 481)
        Me.ReportViewer1.TabIndex = 2
        '
        'all_clenoviaTableAdapter
        '
        Me.all_clenoviaTableAdapter.ClearBeforeFill = True
        '
        'zdruzenie_check
        '
        Me.zdruzenie_check.AutoSize = True
        Me.zdruzenie_check.Location = New System.Drawing.Point(31, 39)
        Me.zdruzenie_check.Name = "zdruzenie_check"
        Me.zdruzenie_check.Size = New System.Drawing.Size(101, 17)
        Me.zdruzenie_check.TabIndex = 3
        Me.zdruzenie_check.Text = "Vyber združenie"
        Me.zdruzenie_check.UseVisualStyleBackColor = True
        '
        'zdruzenie_combo
        '
        Me.zdruzenie_combo.DataSource = Me.ZdruzeniaBindingSource
        Me.zdruzenie_combo.DisplayMember = "nazov"
        Me.zdruzenie_combo.Enabled = False
        Me.zdruzenie_combo.FormattingEnabled = True
        Me.zdruzenie_combo.Location = New System.Drawing.Point(146, 37)
        Me.zdruzenie_combo.Name = "zdruzenie_combo"
        Me.zdruzenie_combo.Size = New System.Drawing.Size(97, 21)
        Me.zdruzenie_combo.TabIndex = 4
        Me.zdruzenie_combo.ValueMember = "nazov"
        '
        'ZdruzeniaBindingSource
        '
        Me.ZdruzeniaBindingSource.DataMember = "zdruzenia"
        Me.ZdruzeniaBindingSource.DataSource = Me.Zoznam_zdruzeni_combo
        '
        'Zoznam_zdruzeni_combo
        '
        Me.Zoznam_zdruzeni_combo.DataSetName = "zoznam_zdruzeni_combo"
        Me.Zoznam_zdruzeni_combo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ZoznamzdruzenicomboBindingSource
        '
        Me.ZoznamzdruzenicomboBindingSource.DataSource = Me.Zoznam_zdruzeni_combo
        Me.ZoznamzdruzenicomboBindingSource.Position = 0
        '
        'ZdruzeniaTableAdapter
        '
        Me.ZdruzeniaTableAdapter.ClearBeforeFill = True
        '
        'nacitat_button
        '
        Me.nacitat_button.Location = New System.Drawing.Point(270, 22)
        Me.nacitat_button.Name = "nacitat_button"
        Me.nacitat_button.Size = New System.Drawing.Size(158, 23)
        Me.nacitat_button.TabIndex = 5
        Me.nacitat_button.Text = "Načítať tl. zostavu"
        Me.nacitat_button.UseVisualStyleBackColor = True
        '
        'zoznam_chybajuce_kont_strelby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 557)
        Me.Controls.Add(Me.nacitat_button)
        Me.Controls.Add(Me.zdruzenie_combo)
        Me.Controls.Add(Me.zdruzenie_check)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.podla_zbrane_combo)
        Me.Controls.Add(Me.podla_zbrane_check)
        Me.Name = "zoznam_chybajuce_kont_strelby"
        Me.Text = "Chýbajúce kont. streľby"
        CType(Me.all_clenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zoznam_kontStrelby, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzeniaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zoznam_zdruzeni_combo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZoznamzdruzenicomboBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents podla_zbrane_check As System.Windows.Forms.CheckBox
    Friend WithEvents podla_zbrane_combo As System.Windows.Forms.ComboBox
    Friend WithEvents all_clenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents zoznam_kontStrelby As evidencia_spz.zoznam_kontStrelby
    Friend WithEvents all_clenoviaTableAdapter As evidencia_spz.zoznam_kontStrelbyTableAdapters.all_clenoviaTableAdapter
    Friend WithEvents zdruzenie_check As System.Windows.Forms.CheckBox
    Friend WithEvents zdruzenie_combo As System.Windows.Forms.ComboBox
    Friend WithEvents ZoznamzdruzenicomboBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Zoznam_zdruzeni_combo As evidencia_spz.zoznam_zdruzeni_combo
    Friend WithEvents ZdruzeniaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZdruzeniaTableAdapter As evidencia_spz.zoznam_zdruzeni_comboTableAdapters.zdruzeniaTableAdapter
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents nacitat_button As System.Windows.Forms.Button
End Class
