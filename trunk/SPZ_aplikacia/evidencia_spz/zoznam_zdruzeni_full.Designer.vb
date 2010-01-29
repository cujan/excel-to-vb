<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zoznam_zdruzeni_full
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.zdruzeniaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.zoznam_zdruzeni_report_full = New evidencia_spz.zoznam_zdruzeni_report_full
        Me.vymera_check = New System.Windows.Forms.CheckBox
        Me.najomna_zmluva_check = New System.Windows.Forms.CheckBox
        Me.jelenia_check = New System.Windows.Forms.CheckBox
        Me.diviacia_check = New System.Windows.Forms.CheckBox
        Me.srncia_check = New System.Windows.Forms.CheckBox
        Me.bazant_check = New System.Windows.Forms.CheckBox
        Me.ina_check = New System.Windows.Forms.CheckBox
        Me.psy_plan_check = New System.Windows.Forms.CheckBox
        Me.psy_skutocnost_check = New System.Windows.Forms.CheckBox
        Me.vymera_combo = New System.Windows.Forms.ComboBox
        Me.psy_plan_combo = New System.Windows.Forms.ComboBox
        Me.jelenia_combo = New System.Windows.Forms.ComboBox
        Me.psy_skutocnost_combo = New System.Windows.Forms.ComboBox
        Me.diviacia_combo = New System.Windows.Forms.ComboBox
        Me.srncia_combo = New System.Windows.Forms.ComboBox
        Me.bazant_combo = New System.Windows.Forms.ComboBox
        Me.ina_combo = New System.Windows.Forms.ComboBox
        Me.refresh_button = New System.Windows.Forms.Button
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.psy_typy_skutocnost_combo = New System.Windows.Forms.ComboBox
        Me.psy_typy_plan_combo = New System.Windows.Forms.ComboBox
        Me.psy_typy_skutocnost_check = New System.Windows.Forms.CheckBox
        Me.psy_typy_plan_check = New System.Windows.Forms.CheckBox
        Me.platnost_naj_zmluvy_combo = New System.Windows.Forms.ComboBox
        Me.RokyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Roky = New evidencia_spz.roky
        Me.RokyTableAdapter = New evidencia_spz.rokyTableAdapters.rokyTableAdapter
        Me.zdruzeniaTableAdapter = New evidencia_spz.zoznam_zdruzeni_report_fullTableAdapters.zdruzeniaTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        CType(Me.zdruzeniaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zoznam_zdruzeni_report_full, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RokyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Roky, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'zdruzeniaBindingSource
        '
        Me.zdruzeniaBindingSource.DataMember = "zdruzenia"
        Me.zdruzeniaBindingSource.DataSource = Me.zoznam_zdruzeni_report_full
        '
        'zoznam_zdruzeni_report_full
        '
        Me.zoznam_zdruzeni_report_full.DataSetName = "zoznam_zdruzeni_report_full"
        Me.zoznam_zdruzeni_report_full.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vymera_check
        '
        Me.vymera_check.AutoSize = True
        Me.vymera_check.Location = New System.Drawing.Point(11, 22)
        Me.vymera_check.Name = "vymera_check"
        Me.vymera_check.Size = New System.Drawing.Size(114, 17)
        Me.vymera_check.TabIndex = 0
        Me.vymera_check.Text = "Výmera aspoň (ha)"
        Me.vymera_check.UseVisualStyleBackColor = True
        '
        'najomna_zmluva_check
        '
        Me.najomna_zmluva_check.AutoSize = True
        Me.najomna_zmluva_check.Location = New System.Drawing.Point(11, 48)
        Me.najomna_zmluva_check.Name = "najomna_zmluva_check"
        Me.najomna_zmluva_check.Size = New System.Drawing.Size(192, 17)
        Me.najomna_zmluva_check.TabIndex = 1
        Me.najomna_zmluva_check.Text = "Platnosť nájomnej zmluvy aspoň do"
        Me.najomna_zmluva_check.UseVisualStyleBackColor = True
        '
        'jelenia_check
        '
        Me.jelenia_check.AutoSize = True
        Me.jelenia_check.Location = New System.Drawing.Point(9, 19)
        Me.jelenia_check.Name = "jelenia_check"
        Me.jelenia_check.Size = New System.Drawing.Size(91, 17)
        Me.jelenia_check.TabIndex = 2
        Me.jelenia_check.Text = "Jelenia aspoń"
        Me.jelenia_check.UseVisualStyleBackColor = True
        '
        'diviacia_check
        '
        Me.diviacia_check.AutoSize = True
        Me.diviacia_check.Location = New System.Drawing.Point(9, 45)
        Me.diviacia_check.Name = "diviacia_check"
        Me.diviacia_check.Size = New System.Drawing.Size(96, 17)
        Me.diviacia_check.TabIndex = 3
        Me.diviacia_check.Text = "Diviačia aspoň"
        Me.diviacia_check.UseVisualStyleBackColor = True
        '
        'srncia_check
        '
        Me.srncia_check.AutoSize = True
        Me.srncia_check.Location = New System.Drawing.Point(9, 71)
        Me.srncia_check.Name = "srncia_check"
        Me.srncia_check.Size = New System.Drawing.Size(88, 17)
        Me.srncia_check.TabIndex = 4
        Me.srncia_check.Text = "Srnčia aspoň"
        Me.srncia_check.UseVisualStyleBackColor = True
        '
        'bazant_check
        '
        Me.bazant_check.AutoSize = True
        Me.bazant_check.Location = New System.Drawing.Point(814, 22)
        Me.bazant_check.Name = "bazant_check"
        Me.bazant_check.Size = New System.Drawing.Size(91, 17)
        Me.bazant_check.TabIndex = 5
        Me.bazant_check.Text = "Bažant aspoň"
        Me.bazant_check.UseVisualStyleBackColor = True
        '
        'ina_check
        '
        Me.ina_check.AutoSize = True
        Me.ina_check.Location = New System.Drawing.Point(814, 48)
        Me.ina_check.Name = "ina_check"
        Me.ina_check.Size = New System.Drawing.Size(73, 17)
        Me.ina_check.TabIndex = 6
        Me.ina_check.Text = "Iná aspoň"
        Me.ina_check.UseVisualStyleBackColor = True
        '
        'psy_plan_check
        '
        Me.psy_plan_check.AutoSize = True
        Me.psy_plan_check.Location = New System.Drawing.Point(11, 19)
        Me.psy_plan_check.Name = "psy_plan_check"
        Me.psy_plan_check.Size = New System.Drawing.Size(79, 17)
        Me.psy_plan_check.TabIndex = 7
        Me.psy_plan_check.Text = "Plán aspoň"
        Me.psy_plan_check.UseVisualStyleBackColor = True
        '
        'psy_skutocnost_check
        '
        Me.psy_skutocnost_check.AutoSize = True
        Me.psy_skutocnost_check.Location = New System.Drawing.Point(11, 45)
        Me.psy_skutocnost_check.Name = "psy_skutocnost_check"
        Me.psy_skutocnost_check.Size = New System.Drawing.Size(113, 17)
        Me.psy_skutocnost_check.TabIndex = 8
        Me.psy_skutocnost_check.Text = "Skutočnosť aspoň"
        Me.psy_skutocnost_check.UseVisualStyleBackColor = True
        '
        'vymera_combo
        '
        Me.vymera_combo.Enabled = False
        Me.vymera_combo.FormattingEnabled = True
        Me.vymera_combo.Items.AddRange(New Object() {"1000", "975", "950", "925", "900", "875", "850", "825", "800", "775", "750", "725", "700", "675", "650", "625", "600", "575", "550", "525", "500", "475", "450", "425", "400", "375", "350", "325", "300", "275", "250", "225", "200", "175", "150", "125", "100", "75", "50", "25"})
        Me.vymera_combo.Location = New System.Drawing.Point(204, 20)
        Me.vymera_combo.Name = "vymera_combo"
        Me.vymera_combo.Size = New System.Drawing.Size(78, 21)
        Me.vymera_combo.TabIndex = 11
        '
        'psy_plan_combo
        '
        Me.psy_plan_combo.Enabled = False
        Me.psy_plan_combo.FormattingEnabled = True
        Me.psy_plan_combo.Items.AddRange(New Object() {"100", "95", "90", "85", "80", "75", "70", "65", "60", "55", "50", "45", "40", "35", "30", "25", "20", "15", "10", "5", "4", "3", "2", "1"})
        Me.psy_plan_combo.Location = New System.Drawing.Point(124, 17)
        Me.psy_plan_combo.Name = "psy_plan_combo"
        Me.psy_plan_combo.Size = New System.Drawing.Size(78, 21)
        Me.psy_plan_combo.TabIndex = 12
        '
        'jelenia_combo
        '
        Me.jelenia_combo.Enabled = False
        Me.jelenia_combo.FormattingEnabled = True
        Me.jelenia_combo.Items.AddRange(New Object() {"100", "95", "90", "85", "80", "75", "70", "65", "60", "55", "50", "45", "40", "35", "30", "25", "20", "15", "10", "5", "4", "3", "2", "1"})
        Me.jelenia_combo.Location = New System.Drawing.Point(106, 17)
        Me.jelenia_combo.Name = "jelenia_combo"
        Me.jelenia_combo.Size = New System.Drawing.Size(66, 21)
        Me.jelenia_combo.TabIndex = 13
        '
        'psy_skutocnost_combo
        '
        Me.psy_skutocnost_combo.Enabled = False
        Me.psy_skutocnost_combo.FormattingEnabled = True
        Me.psy_skutocnost_combo.Items.AddRange(New Object() {"100", "95", "90", "85", "80", "75", "70", "65", "60", "55", "50", "45", "40", "35", "30", "25", "20", "15", "10", "5", "4", "3", "2", "1"})
        Me.psy_skutocnost_combo.Location = New System.Drawing.Point(124, 43)
        Me.psy_skutocnost_combo.Name = "psy_skutocnost_combo"
        Me.psy_skutocnost_combo.Size = New System.Drawing.Size(78, 21)
        Me.psy_skutocnost_combo.TabIndex = 14
        '
        'diviacia_combo
        '
        Me.diviacia_combo.Enabled = False
        Me.diviacia_combo.FormattingEnabled = True
        Me.diviacia_combo.Items.AddRange(New Object() {"100", "95", "90", "85", "80", "75", "70", "65", "60", "55", "50", "45", "40", "35", "30", "25", "20", "15", "10", "5", "4", "3", "2", "1"})
        Me.diviacia_combo.Location = New System.Drawing.Point(106, 43)
        Me.diviacia_combo.Name = "diviacia_combo"
        Me.diviacia_combo.Size = New System.Drawing.Size(66, 21)
        Me.diviacia_combo.TabIndex = 15
        '
        'srncia_combo
        '
        Me.srncia_combo.Enabled = False
        Me.srncia_combo.FormattingEnabled = True
        Me.srncia_combo.Items.AddRange(New Object() {"100", "95", "90", "85", "80", "75", "70", "65", "60", "55", "50", "45", "40", "35", "30", "25", "20", "15", "10", "5", "4", "3", "2", "1"})
        Me.srncia_combo.Location = New System.Drawing.Point(106, 69)
        Me.srncia_combo.Name = "srncia_combo"
        Me.srncia_combo.Size = New System.Drawing.Size(66, 21)
        Me.srncia_combo.TabIndex = 16
        '
        'bazant_combo
        '
        Me.bazant_combo.Enabled = False
        Me.bazant_combo.FormattingEnabled = True
        Me.bazant_combo.Items.AddRange(New Object() {"100", "95", "90", "85", "80", "75", "70", "65", "60", "55", "50", "45", "40", "35", "30", "25", "20", "15", "10", "5", "4", "3", "2", "1"})
        Me.bazant_combo.Location = New System.Drawing.Point(911, 20)
        Me.bazant_combo.Name = "bazant_combo"
        Me.bazant_combo.Size = New System.Drawing.Size(66, 21)
        Me.bazant_combo.TabIndex = 17
        '
        'ina_combo
        '
        Me.ina_combo.Enabled = False
        Me.ina_combo.FormattingEnabled = True
        Me.ina_combo.Items.AddRange(New Object() {"100", "95", "90", "85", "80", "75", "70", "65", "60", "55", "50", "45", "40", "35", "30", "25", "20", "15", "10", "5", "4", "3", "2", "1"})
        Me.ina_combo.Location = New System.Drawing.Point(911, 46)
        Me.ina_combo.Name = "ina_combo"
        Me.ina_combo.Size = New System.Drawing.Size(66, 21)
        Me.ina_combo.TabIndex = 18
        '
        'refresh_button
        '
        Me.refresh_button.Location = New System.Drawing.Point(12, 98)
        Me.refresh_button.Name = "refresh_button"
        Me.refresh_button.Size = New System.Drawing.Size(290, 23)
        Me.refresh_button.TabIndex = 20
        Me.refresh_button.Text = "Načítať tl. zostavu"
        Me.refresh_button.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "zoznam_zdruzeni_report_full_zdruzenia"
        ReportDataSource2.Value = Me.zdruzeniaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "evidencia_spz.zoznam_zdruz_full_report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(5, 157)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1075, 450)
        Me.ReportViewer1.TabIndex = 21
        '
        'psy_typy_skutocnost_combo
        '
        Me.psy_typy_skutocnost_combo.Enabled = False
        Me.psy_typy_skutocnost_combo.FormattingEnabled = True
        Me.psy_typy_skutocnost_combo.Items.AddRange(New Object() {"100", "95", "90", "85", "80", "75", "70", "65", "60", "55", "50", "45", "40", "35", "30", "25", "20", "15", "10", "5", "4", "3", "2", "1"})
        Me.psy_typy_skutocnost_combo.Location = New System.Drawing.Point(120, 45)
        Me.psy_typy_skutocnost_combo.Name = "psy_typy_skutocnost_combo"
        Me.psy_typy_skutocnost_combo.Size = New System.Drawing.Size(78, 21)
        Me.psy_typy_skutocnost_combo.TabIndex = 26
        '
        'psy_typy_plan_combo
        '
        Me.psy_typy_plan_combo.Enabled = False
        Me.psy_typy_plan_combo.FormattingEnabled = True
        Me.psy_typy_plan_combo.Items.AddRange(New Object() {"100", "95", "90", "85", "80", "75", "70", "65", "60", "55", "50", "45", "40", "35", "30", "25", "20", "15", "10", "5", "4", "3", "2", "1"})
        Me.psy_typy_plan_combo.Location = New System.Drawing.Point(120, 19)
        Me.psy_typy_plan_combo.Name = "psy_typy_plan_combo"
        Me.psy_typy_plan_combo.Size = New System.Drawing.Size(78, 21)
        Me.psy_typy_plan_combo.TabIndex = 25
        '
        'psy_typy_skutocnost_check
        '
        Me.psy_typy_skutocnost_check.AutoSize = True
        Me.psy_typy_skutocnost_check.Location = New System.Drawing.Point(7, 47)
        Me.psy_typy_skutocnost_check.Name = "psy_typy_skutocnost_check"
        Me.psy_typy_skutocnost_check.Size = New System.Drawing.Size(113, 17)
        Me.psy_typy_skutocnost_check.TabIndex = 23
        Me.psy_typy_skutocnost_check.Text = "Skutočnosť aspoň"
        Me.psy_typy_skutocnost_check.UseVisualStyleBackColor = True
        '
        'psy_typy_plan_check
        '
        Me.psy_typy_plan_check.AutoSize = True
        Me.psy_typy_plan_check.Location = New System.Drawing.Point(7, 21)
        Me.psy_typy_plan_check.Name = "psy_typy_plan_check"
        Me.psy_typy_plan_check.Size = New System.Drawing.Size(79, 17)
        Me.psy_typy_plan_check.TabIndex = 22
        Me.psy_typy_plan_check.Text = "Plán aspoň"
        Me.psy_typy_plan_check.UseVisualStyleBackColor = True
        '
        'platnost_naj_zmluvy_combo
        '
        Me.platnost_naj_zmluvy_combo.DataSource = Me.RokyBindingSource
        Me.platnost_naj_zmluvy_combo.DisplayMember = "rok"
        Me.platnost_naj_zmluvy_combo.Enabled = False
        Me.platnost_naj_zmluvy_combo.FormattingEnabled = True
        Me.platnost_naj_zmluvy_combo.Location = New System.Drawing.Point(204, 46)
        Me.platnost_naj_zmluvy_combo.Name = "platnost_naj_zmluvy_combo"
        Me.platnost_naj_zmluvy_combo.Size = New System.Drawing.Size(78, 21)
        Me.platnost_naj_zmluvy_combo.TabIndex = 27
        Me.platnost_naj_zmluvy_combo.ValueMember = "rok"
        '
        'RokyBindingSource
        '
        Me.RokyBindingSource.DataMember = "roky"
        Me.RokyBindingSource.DataSource = Me.Roky
        '
        'Roky
        '
        Me.Roky.DataSetName = "roky"
        Me.Roky.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RokyTableAdapter
        '
        Me.RokyTableAdapter.ClearBeforeFill = True
        '
        'zdruzeniaTableAdapter
        '
        Me.zdruzeniaTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.psy_typy_plan_check)
        Me.GroupBox1.Controls.Add(Me.psy_typy_skutocnost_check)
        Me.GroupBox1.Controls.Add(Me.psy_typy_skutocnost_combo)
        Me.GroupBox1.Controls.Add(Me.psy_typy_plan_combo)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(343, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 74)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Typy psov"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.psy_skutocnost_check)
        Me.GroupBox2.Controls.Add(Me.psy_plan_check)
        Me.GroupBox2.Controls.Add(Me.psy_plan_combo)
        Me.GroupBox2.Controls.Add(Me.psy_skutocnost_combo)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(343, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 71)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Plemená psov"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.diviacia_check)
        Me.GroupBox3.Controls.Add(Me.jelenia_check)
        Me.GroupBox3.Controls.Add(Me.srncia_check)
        Me.GroupBox3.Controls.Add(Me.jelenia_combo)
        Me.GroupBox3.Controls.Add(Me.diviacia_combo)
        Me.GroupBox3.Controls.Add(Me.srncia_combo)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(586, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(190, 100)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Zver"
        '
        'zoznam_zdruzeni_full
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 619)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.platnost_naj_zmluvy_combo)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.refresh_button)
        Me.Controls.Add(Me.ina_combo)
        Me.Controls.Add(Me.bazant_combo)
        Me.Controls.Add(Me.vymera_combo)
        Me.Controls.Add(Me.ina_check)
        Me.Controls.Add(Me.bazant_check)
        Me.Controls.Add(Me.najomna_zmluva_check)
        Me.Controls.Add(Me.vymera_check)
        Me.Name = "zoznam_zdruzeni_full"
        Me.Text = "Zoznam združení"
        CType(Me.zdruzeniaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zoznam_zdruzeni_report_full, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RokyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Roky, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vymera_check As System.Windows.Forms.CheckBox
    Friend WithEvents najomna_zmluva_check As System.Windows.Forms.CheckBox
    Friend WithEvents jelenia_check As System.Windows.Forms.CheckBox
    Friend WithEvents diviacia_check As System.Windows.Forms.CheckBox
    Friend WithEvents srncia_check As System.Windows.Forms.CheckBox
    Friend WithEvents bazant_check As System.Windows.Forms.CheckBox
    Friend WithEvents ina_check As System.Windows.Forms.CheckBox
    Friend WithEvents psy_plan_check As System.Windows.Forms.CheckBox
    Friend WithEvents psy_skutocnost_check As System.Windows.Forms.CheckBox
    Friend WithEvents vymera_combo As System.Windows.Forms.ComboBox
    Friend WithEvents psy_plan_combo As System.Windows.Forms.ComboBox
    Friend WithEvents jelenia_combo As System.Windows.Forms.ComboBox
    Friend WithEvents psy_skutocnost_combo As System.Windows.Forms.ComboBox
    Friend WithEvents diviacia_combo As System.Windows.Forms.ComboBox
    Friend WithEvents srncia_combo As System.Windows.Forms.ComboBox
    Friend WithEvents bazant_combo As System.Windows.Forms.ComboBox
    Friend WithEvents ina_combo As System.Windows.Forms.ComboBox
    Friend WithEvents refresh_button As System.Windows.Forms.Button
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents psy_typy_skutocnost_combo As System.Windows.Forms.ComboBox
    Friend WithEvents psy_typy_plan_combo As System.Windows.Forms.ComboBox
    Friend WithEvents psy_typy_skutocnost_check As System.Windows.Forms.CheckBox
    Friend WithEvents psy_typy_plan_check As System.Windows.Forms.CheckBox
    Friend WithEvents platnost_naj_zmluvy_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Roky As evidencia_spz.roky
    Friend WithEvents RokyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RokyTableAdapter As evidencia_spz.rokyTableAdapters.rokyTableAdapter
    Friend WithEvents zdruzeniaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents zoznam_zdruzeni_report_full As evidencia_spz.zoznam_zdruzeni_report_full
    Friend WithEvents zdruzeniaTableAdapter As evidencia_spz.zoznam_zdruzeni_report_fullTableAdapters.zdruzeniaTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
