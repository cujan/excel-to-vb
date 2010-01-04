<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zoznam_clenov_full
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
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.zdruzenia_combo = New System.Windows.Forms.ComboBox
        Me.zdruzenie_checkbox = New System.Windows.Forms.CheckBox
        Me.narodnost_checkbox = New System.Windows.Forms.CheckBox
        Me.narodnost_combo = New System.Windows.Forms.ComboBox
        Me.st_prislusnost_checkbox = New System.Windows.Forms.CheckBox
        Me.st_prislusnost_combo = New System.Windows.Forms.ComboBox
        Me.dat_narodenia_checkbox = New System.Windows.Forms.CheckBox
        Me.dat_narodenia_dt_picker = New System.Windows.Forms.DateTimePicker
        Me.pl_vydany_po_checkbox = New System.Windows.Forms.CheckBox
        Me.pl_vydany_po_dt_picker = New System.Windows.Forms.DateTimePicker
        Me.zp_vydany_po_checkbox = New System.Windows.Forms.CheckBox
        Me.zp_vydany_po_dt_picker = New System.Windows.Forms.DateTimePicker
        Me.clen_spz_od_checkbox = New System.Windows.Forms.CheckBox
        Me.clenske_do_checkbox = New System.Windows.Forms.CheckBox
        Me.clen_spz_od_combo = New System.Windows.Forms.ComboBox
        Me.clenske_do_combo = New System.Windows.Forms.ComboBox
        Me.zoznam_clenov = New evidencia_spz.zoznam_clenov
        Me.all_clenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.all_clenoviaTableAdapter = New evidencia_spz.zoznam_clenovTableAdapters.all_clenoviaTableAdapter
        CType(Me.zoznam_clenov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.all_clenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource6.Name = "zoznam_clenov_all_clenovia"
        ReportDataSource6.Value = Me.all_clenoviaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "evidencia_spz.zoznam_clenov_full.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 109)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(863, 292)
        Me.ReportViewer1.TabIndex = 0
        '
        'zdruzenia_combo
        '
        Me.zdruzenia_combo.Enabled = False
        Me.zdruzenia_combo.FormattingEnabled = True
        Me.zdruzenia_combo.Location = New System.Drawing.Point(142, 4)
        Me.zdruzenia_combo.Name = "zdruzenia_combo"
        Me.zdruzenia_combo.Size = New System.Drawing.Size(101, 21)
        Me.zdruzenia_combo.TabIndex = 1
        '
        'zdruzenie_checkbox
        '
        Me.zdruzenie_checkbox.AutoSize = True
        Me.zdruzenie_checkbox.Location = New System.Drawing.Point(19, 6)
        Me.zdruzenie_checkbox.Name = "zdruzenie_checkbox"
        Me.zdruzenie_checkbox.Size = New System.Drawing.Size(101, 17)
        Me.zdruzenie_checkbox.TabIndex = 3
        Me.zdruzenie_checkbox.Text = "Vyber združenie"
        Me.zdruzenie_checkbox.UseVisualStyleBackColor = True
        '
        'narodnost_checkbox
        '
        Me.narodnost_checkbox.AutoSize = True
        Me.narodnost_checkbox.Location = New System.Drawing.Point(280, 35)
        Me.narodnost_checkbox.Name = "narodnost_checkbox"
        Me.narodnost_checkbox.Size = New System.Drawing.Size(104, 17)
        Me.narodnost_checkbox.TabIndex = 4
        Me.narodnost_checkbox.Text = "Vyber národnosť"
        Me.narodnost_checkbox.UseVisualStyleBackColor = True
        '
        'narodnost_combo
        '
        Me.narodnost_combo.Enabled = False
        Me.narodnost_combo.FormattingEnabled = True
        Me.narodnost_combo.Location = New System.Drawing.Point(421, 31)
        Me.narodnost_combo.Name = "narodnost_combo"
        Me.narodnost_combo.Size = New System.Drawing.Size(61, 21)
        Me.narodnost_combo.TabIndex = 5
        '
        'st_prislusnost_checkbox
        '
        Me.st_prislusnost_checkbox.AutoSize = True
        Me.st_prislusnost_checkbox.Location = New System.Drawing.Point(280, 64)
        Me.st_prislusnost_checkbox.Name = "st_prislusnost_checkbox"
        Me.st_prislusnost_checkbox.Size = New System.Drawing.Size(124, 17)
        Me.st_prislusnost_checkbox.TabIndex = 6
        Me.st_prislusnost_checkbox.Text = "Vyber Št. príslušnosť"
        Me.st_prislusnost_checkbox.UseVisualStyleBackColor = True
        '
        'st_prislusnost_combo
        '
        Me.st_prislusnost_combo.Enabled = False
        Me.st_prislusnost_combo.FormattingEnabled = True
        Me.st_prislusnost_combo.Location = New System.Drawing.Point(421, 60)
        Me.st_prislusnost_combo.Name = "st_prislusnost_combo"
        Me.st_prislusnost_combo.Size = New System.Drawing.Size(56, 21)
        Me.st_prislusnost_combo.TabIndex = 7
        '
        'dat_narodenia_checkbox
        '
        Me.dat_narodenia_checkbox.AutoSize = True
        Me.dat_narodenia_checkbox.Location = New System.Drawing.Point(280, 10)
        Me.dat_narodenia_checkbox.Name = "dat_narodenia_checkbox"
        Me.dat_narodenia_checkbox.Size = New System.Drawing.Size(135, 17)
        Me.dat_narodenia_checkbox.TabIndex = 8
        Me.dat_narodenia_checkbox.Text = "Vyber dátum narodenia"
        Me.dat_narodenia_checkbox.UseVisualStyleBackColor = True
        '
        'dat_narodenia_dt_picker
        '
        Me.dat_narodenia_dt_picker.Enabled = False
        Me.dat_narodenia_dt_picker.Location = New System.Drawing.Point(421, 5)
        Me.dat_narodenia_dt_picker.Name = "dat_narodenia_dt_picker"
        Me.dat_narodenia_dt_picker.Size = New System.Drawing.Size(135, 20)
        Me.dat_narodenia_dt_picker.TabIndex = 9
        '
        'pl_vydany_po_checkbox
        '
        Me.pl_vydany_po_checkbox.AutoSize = True
        Me.pl_vydany_po_checkbox.Location = New System.Drawing.Point(601, 8)
        Me.pl_vydany_po_checkbox.Name = "pl_vydany_po_checkbox"
        Me.pl_vydany_po_checkbox.Size = New System.Drawing.Size(91, 17)
        Me.pl_vydany_po_checkbox.TabIndex = 10
        Me.pl_vydany_po_checkbox.Text = "PL vydaný po"
        Me.pl_vydany_po_checkbox.UseVisualStyleBackColor = True
        '
        'pl_vydany_po_dt_picker
        '
        Me.pl_vydany_po_dt_picker.Enabled = False
        Me.pl_vydany_po_dt_picker.Location = New System.Drawing.Point(698, 5)
        Me.pl_vydany_po_dt_picker.Name = "pl_vydany_po_dt_picker"
        Me.pl_vydany_po_dt_picker.Size = New System.Drawing.Size(129, 20)
        Me.pl_vydany_po_dt_picker.TabIndex = 11
        '
        'zp_vydany_po_checkbox
        '
        Me.zp_vydany_po_checkbox.AutoSize = True
        Me.zp_vydany_po_checkbox.Location = New System.Drawing.Point(601, 35)
        Me.zp_vydany_po_checkbox.Name = "zp_vydany_po_checkbox"
        Me.zp_vydany_po_checkbox.Size = New System.Drawing.Size(92, 17)
        Me.zp_vydany_po_checkbox.TabIndex = 12
        Me.zp_vydany_po_checkbox.Text = "ZP vydaný po"
        Me.zp_vydany_po_checkbox.UseVisualStyleBackColor = True
        '
        'zp_vydany_po_dt_picker
        '
        Me.zp_vydany_po_dt_picker.Enabled = False
        Me.zp_vydany_po_dt_picker.Location = New System.Drawing.Point(698, 32)
        Me.zp_vydany_po_dt_picker.Name = "zp_vydany_po_dt_picker"
        Me.zp_vydany_po_dt_picker.Size = New System.Drawing.Size(129, 20)
        Me.zp_vydany_po_dt_picker.TabIndex = 13
        '
        'clen_spz_od_checkbox
        '
        Me.clen_spz_od_checkbox.AutoSize = True
        Me.clen_spz_od_checkbox.Location = New System.Drawing.Point(19, 35)
        Me.clen_spz_od_checkbox.Name = "clen_spz_od_checkbox"
        Me.clen_spz_od_checkbox.Size = New System.Drawing.Size(115, 17)
        Me.clen_spz_od_checkbox.TabIndex = 14
        Me.clen_spz_od_checkbox.Text = "Vyber člen SPZ od"
        Me.clen_spz_od_checkbox.UseVisualStyleBackColor = True
        '
        'clenske_do_checkbox
        '
        Me.clenske_do_checkbox.AutoSize = True
        Me.clenske_do_checkbox.Location = New System.Drawing.Point(19, 64)
        Me.clenske_do_checkbox.Name = "clenske_do_checkbox"
        Me.clenske_do_checkbox.Size = New System.Drawing.Size(108, 17)
        Me.clenske_do_checkbox.TabIndex = 15
        Me.clenske_do_checkbox.Text = "Vyber členské do"
        Me.clenske_do_checkbox.UseVisualStyleBackColor = True
        '
        'clen_spz_od_combo
        '
        Me.clen_spz_od_combo.Enabled = False
        Me.clen_spz_od_combo.FormattingEnabled = True
        Me.clen_spz_od_combo.Location = New System.Drawing.Point(142, 33)
        Me.clen_spz_od_combo.Name = "clen_spz_od_combo"
        Me.clen_spz_od_combo.Size = New System.Drawing.Size(70, 21)
        Me.clen_spz_od_combo.TabIndex = 16
        '
        'clenske_do_combo
        '
        Me.clenske_do_combo.Enabled = False
        Me.clenske_do_combo.FormattingEnabled = True
        Me.clenske_do_combo.Location = New System.Drawing.Point(142, 62)
        Me.clenske_do_combo.Name = "clenske_do_combo"
        Me.clenske_do_combo.Size = New System.Drawing.Size(70, 21)
        Me.clenske_do_combo.TabIndex = 17
        '
        'zoznam_clenov
        '
        Me.zoznam_clenov.DataSetName = "zoznam_clenov"
        Me.zoznam_clenov.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'all_clenoviaBindingSource
        '
        Me.all_clenoviaBindingSource.DataMember = "all_clenovia"
        Me.all_clenoviaBindingSource.DataSource = Me.zoznam_clenov
        '
        'all_clenoviaTableAdapter
        '
        Me.all_clenoviaTableAdapter.ClearBeforeFill = True
        '
        'zoznam_clenov_full
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 413)
        Me.Controls.Add(Me.clenske_do_combo)
        Me.Controls.Add(Me.clen_spz_od_combo)
        Me.Controls.Add(Me.clenske_do_checkbox)
        Me.Controls.Add(Me.clen_spz_od_checkbox)
        Me.Controls.Add(Me.zp_vydany_po_dt_picker)
        Me.Controls.Add(Me.zp_vydany_po_checkbox)
        Me.Controls.Add(Me.pl_vydany_po_dt_picker)
        Me.Controls.Add(Me.pl_vydany_po_checkbox)
        Me.Controls.Add(Me.dat_narodenia_dt_picker)
        Me.Controls.Add(Me.dat_narodenia_checkbox)
        Me.Controls.Add(Me.st_prislusnost_combo)
        Me.Controls.Add(Me.st_prislusnost_checkbox)
        Me.Controls.Add(Me.narodnost_combo)
        Me.Controls.Add(Me.narodnost_checkbox)
        Me.Controls.Add(Me.zdruzenie_checkbox)
        Me.Controls.Add(Me.zdruzenia_combo)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "zoznam_clenov_full"
        Me.Text = "Zoznam členov"
        CType(Me.zoznam_clenov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.all_clenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents zdruzenia_combo As System.Windows.Forms.ComboBox
    Friend WithEvents zdruzenie_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents narodnost_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents narodnost_combo As System.Windows.Forms.ComboBox
    Friend WithEvents st_prislusnost_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents st_prislusnost_combo As System.Windows.Forms.ComboBox
    Friend WithEvents dat_narodenia_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents dat_narodenia_dt_picker As System.Windows.Forms.DateTimePicker
    Friend WithEvents pl_vydany_po_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents pl_vydany_po_dt_picker As System.Windows.Forms.DateTimePicker
    Friend WithEvents zp_vydany_po_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents zp_vydany_po_dt_picker As System.Windows.Forms.DateTimePicker
    Friend WithEvents clen_spz_od_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents clenske_do_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents clen_spz_od_combo As System.Windows.Forms.ComboBox
    Friend WithEvents clenske_do_combo As System.Windows.Forms.ComboBox
    Friend WithEvents all_clenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents zoznam_clenov As evidencia_spz.zoznam_clenov
    Friend WithEvents all_clenoviaTableAdapter As evidencia_spz.zoznam_clenovTableAdapters.all_clenoviaTableAdapter
End Class
