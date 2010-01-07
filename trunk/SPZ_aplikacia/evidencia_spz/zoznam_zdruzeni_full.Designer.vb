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
        Me.vymera_check = New System.Windows.Forms.CheckBox
        Me.najomna_zmluva_check = New System.Windows.Forms.CheckBox
        Me.jelenia_check = New System.Windows.Forms.CheckBox
        Me.diviacia_check = New System.Windows.Forms.CheckBox
        Me.srncia_check = New System.Windows.Forms.CheckBox
        Me.bazant_check = New System.Windows.Forms.CheckBox
        Me.ina_check = New System.Windows.Forms.CheckBox
        Me.psy_plan_check = New System.Windows.Forms.CheckBox
        Me.psy_skutocnost_check = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.vymera_combo = New System.Windows.Forms.ComboBox
        Me.psy_plan_combo = New System.Windows.Forms.ComboBox
        Me.jelenia_combo = New System.Windows.Forms.ComboBox
        Me.psy_skutocnost_combo = New System.Windows.Forms.ComboBox
        Me.diviacia_combo = New System.Windows.Forms.ComboBox
        Me.srncia_combo = New System.Windows.Forms.ComboBox
        Me.bazant_combo = New System.Windows.Forms.ComboBox
        Me.ina_combo = New System.Windows.Forms.ComboBox
        Me.naj_zmluva_dt_picker = New System.Windows.Forms.DateTimePicker
        Me.refresh_button = New System.Windows.Forms.Button
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.SuspendLayout()
        '
        'vymera_check
        '
        Me.vymera_check.AutoSize = True
        Me.vymera_check.Location = New System.Drawing.Point(12, 22)
        Me.vymera_check.Name = "vymera_check"
        Me.vymera_check.Size = New System.Drawing.Size(93, 17)
        Me.vymera_check.TabIndex = 0
        Me.vymera_check.Text = "Výmera aspoň"
        Me.vymera_check.UseVisualStyleBackColor = True
        '
        'najomna_zmluva_check
        '
        Me.najomna_zmluva_check.AutoSize = True
        Me.najomna_zmluva_check.Location = New System.Drawing.Point(12, 48)
        Me.najomna_zmluva_check.Name = "najomna_zmluva_check"
        Me.najomna_zmluva_check.Size = New System.Drawing.Size(192, 17)
        Me.najomna_zmluva_check.TabIndex = 1
        Me.najomna_zmluva_check.Text = "Platnosť nájomnej zmluvy aspoń do"
        Me.najomna_zmluva_check.UseVisualStyleBackColor = True
        '
        'jelenia_check
        '
        Me.jelenia_check.AutoSize = True
        Me.jelenia_check.Location = New System.Drawing.Point(618, 22)
        Me.jelenia_check.Name = "jelenia_check"
        Me.jelenia_check.Size = New System.Drawing.Size(91, 17)
        Me.jelenia_check.TabIndex = 2
        Me.jelenia_check.Text = "Jelenia aspoń"
        Me.jelenia_check.UseVisualStyleBackColor = True
        '
        'diviacia_check
        '
        Me.diviacia_check.AutoSize = True
        Me.diviacia_check.Location = New System.Drawing.Point(618, 48)
        Me.diviacia_check.Name = "diviacia_check"
        Me.diviacia_check.Size = New System.Drawing.Size(96, 17)
        Me.diviacia_check.TabIndex = 3
        Me.diviacia_check.Text = "Diviačia aspoň"
        Me.diviacia_check.UseVisualStyleBackColor = True
        '
        'srncia_check
        '
        Me.srncia_check.AutoSize = True
        Me.srncia_check.Location = New System.Drawing.Point(618, 74)
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
        Me.psy_plan_check.Location = New System.Drawing.Point(381, 22)
        Me.psy_plan_check.Name = "psy_plan_check"
        Me.psy_plan_check.Size = New System.Drawing.Size(79, 17)
        Me.psy_plan_check.TabIndex = 7
        Me.psy_plan_check.Text = "Plán aspoň"
        Me.psy_plan_check.UseVisualStyleBackColor = True
        '
        'psy_skutocnost_check
        '
        Me.psy_skutocnost_check.AutoSize = True
        Me.psy_skutocnost_check.Location = New System.Drawing.Point(381, 48)
        Me.psy_skutocnost_check.Name = "psy_skutocnost_check"
        Me.psy_skutocnost_check.Size = New System.Drawing.Size(113, 17)
        Me.psy_skutocnost_check.TabIndex = 8
        Me.psy_skutocnost_check.Text = "Skutočnosť aspoň"
        Me.psy_skutocnost_check.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(378, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Psy"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(615, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Zver"
        '
        'vymera_combo
        '
        Me.vymera_combo.Enabled = False
        Me.vymera_combo.FormattingEnabled = True
        Me.vymera_combo.Location = New System.Drawing.Point(211, 20)
        Me.vymera_combo.Name = "vymera_combo"
        Me.vymera_combo.Size = New System.Drawing.Size(132, 21)
        Me.vymera_combo.TabIndex = 11
        '
        'psy_plan_combo
        '
        Me.psy_plan_combo.Enabled = False
        Me.psy_plan_combo.FormattingEnabled = True
        Me.psy_plan_combo.Location = New System.Drawing.Point(494, 20)
        Me.psy_plan_combo.Name = "psy_plan_combo"
        Me.psy_plan_combo.Size = New System.Drawing.Size(78, 21)
        Me.psy_plan_combo.TabIndex = 12
        '
        'jelenia_combo
        '
        Me.jelenia_combo.Enabled = False
        Me.jelenia_combo.FormattingEnabled = True
        Me.jelenia_combo.Location = New System.Drawing.Point(715, 20)
        Me.jelenia_combo.Name = "jelenia_combo"
        Me.jelenia_combo.Size = New System.Drawing.Size(66, 21)
        Me.jelenia_combo.TabIndex = 13
        '
        'psy_skutocnost_combo
        '
        Me.psy_skutocnost_combo.Enabled = False
        Me.psy_skutocnost_combo.FormattingEnabled = True
        Me.psy_skutocnost_combo.Location = New System.Drawing.Point(494, 46)
        Me.psy_skutocnost_combo.Name = "psy_skutocnost_combo"
        Me.psy_skutocnost_combo.Size = New System.Drawing.Size(78, 21)
        Me.psy_skutocnost_combo.TabIndex = 14
        '
        'diviacia_combo
        '
        Me.diviacia_combo.Enabled = False
        Me.diviacia_combo.FormattingEnabled = True
        Me.diviacia_combo.Location = New System.Drawing.Point(715, 46)
        Me.diviacia_combo.Name = "diviacia_combo"
        Me.diviacia_combo.Size = New System.Drawing.Size(66, 21)
        Me.diviacia_combo.TabIndex = 15
        '
        'srncia_combo
        '
        Me.srncia_combo.Enabled = False
        Me.srncia_combo.FormattingEnabled = True
        Me.srncia_combo.Location = New System.Drawing.Point(715, 72)
        Me.srncia_combo.Name = "srncia_combo"
        Me.srncia_combo.Size = New System.Drawing.Size(66, 21)
        Me.srncia_combo.TabIndex = 16
        '
        'bazant_combo
        '
        Me.bazant_combo.Enabled = False
        Me.bazant_combo.FormattingEnabled = True
        Me.bazant_combo.Location = New System.Drawing.Point(911, 20)
        Me.bazant_combo.Name = "bazant_combo"
        Me.bazant_combo.Size = New System.Drawing.Size(66, 21)
        Me.bazant_combo.TabIndex = 17
        '
        'ina_combo
        '
        Me.ina_combo.Enabled = False
        Me.ina_combo.FormattingEnabled = True
        Me.ina_combo.Location = New System.Drawing.Point(911, 46)
        Me.ina_combo.Name = "ina_combo"
        Me.ina_combo.Size = New System.Drawing.Size(66, 21)
        Me.ina_combo.TabIndex = 18
        '
        'naj_zmluva_dt_picker
        '
        Me.naj_zmluva_dt_picker.Enabled = False
        Me.naj_zmluva_dt_picker.Location = New System.Drawing.Point(211, 48)
        Me.naj_zmluva_dt_picker.Name = "naj_zmluva_dt_picker"
        Me.naj_zmluva_dt_picker.Size = New System.Drawing.Size(132, 20)
        Me.naj_zmluva_dt_picker.TabIndex = 19
        '
        'refresh_button
        '
        Me.refresh_button.Location = New System.Drawing.Point(459, 97)
        Me.refresh_button.Name = "refresh_button"
        Me.refresh_button.Size = New System.Drawing.Size(189, 23)
        Me.refresh_button.TabIndex = 20
        Me.refresh_button.Text = "Načítať tl. zostavu"
        Me.refresh_button.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(5, 134)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(986, 336)
        Me.ReportViewer1.TabIndex = 21
        '
        'zoznam_zdruzeni_full
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 474)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.refresh_button)
        Me.Controls.Add(Me.naj_zmluva_dt_picker)
        Me.Controls.Add(Me.ina_combo)
        Me.Controls.Add(Me.bazant_combo)
        Me.Controls.Add(Me.srncia_combo)
        Me.Controls.Add(Me.diviacia_combo)
        Me.Controls.Add(Me.psy_skutocnost_combo)
        Me.Controls.Add(Me.jelenia_combo)
        Me.Controls.Add(Me.psy_plan_combo)
        Me.Controls.Add(Me.vymera_combo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.psy_skutocnost_check)
        Me.Controls.Add(Me.psy_plan_check)
        Me.Controls.Add(Me.ina_check)
        Me.Controls.Add(Me.bazant_check)
        Me.Controls.Add(Me.srncia_check)
        Me.Controls.Add(Me.diviacia_check)
        Me.Controls.Add(Me.jelenia_check)
        Me.Controls.Add(Me.najomna_zmluva_check)
        Me.Controls.Add(Me.vymera_check)
        Me.Enabled = False
        Me.Name = "zoznam_zdruzeni_full"
        Me.Text = "Zoznam združení"
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents vymera_combo As System.Windows.Forms.ComboBox
    Friend WithEvents psy_plan_combo As System.Windows.Forms.ComboBox
    Friend WithEvents jelenia_combo As System.Windows.Forms.ComboBox
    Friend WithEvents psy_skutocnost_combo As System.Windows.Forms.ComboBox
    Friend WithEvents diviacia_combo As System.Windows.Forms.ComboBox
    Friend WithEvents srncia_combo As System.Windows.Forms.ComboBox
    Friend WithEvents bazant_combo As System.Windows.Forms.ComboBox
    Friend WithEvents ina_combo As System.Windows.Forms.ComboBox
    Friend WithEvents naj_zmluva_dt_picker As System.Windows.Forms.DateTimePicker
    Friend WithEvents refresh_button As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
