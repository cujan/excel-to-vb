<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zoznam_narodeniny
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
        Me.narodeniny_check = New System.Windows.Forms.CheckBox
        Me.mesiace_combo = New System.Windows.Forms.ComboBox
        Me.zdruzenia_check = New System.Windows.Forms.CheckBox
        Me.zdruzenia_combo = New System.Windows.Forms.ComboBox
        Me.Zoznam_zdruzeni_combo = New evidencia_spz.zoznam_zdruzeni_combo
        Me.ZdruzeniaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZdruzeniaTableAdapter = New evidencia_spz.zoznam_zdruzeni_comboTableAdapters.zdruzeniaTableAdapter
        CType(Me.Zoznam_zdruzeni_combo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzeniaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'narodeniny_check
        '
        Me.narodeniny_check.AutoSize = True
        Me.narodeniny_check.Location = New System.Drawing.Point(12, 12)
        Me.narodeniny_check.Name = "narodeniny_check"
        Me.narodeniny_check.Size = New System.Drawing.Size(133, 17)
        Me.narodeniny_check.TabIndex = 0
        Me.narodeniny_check.Text = "Zoznam po mesiacoch"
        Me.narodeniny_check.UseVisualStyleBackColor = True
        '
        'mesiace_combo
        '
        Me.mesiace_combo.Enabled = False
        Me.mesiace_combo.FormattingEnabled = True
        Me.mesiace_combo.Items.AddRange(New Object() {"Január", "Február", "Marec", "Apríl", "Máj", "Jún", "Júl", "August", "September", "Október", "November", "December"})
        Me.mesiace_combo.Location = New System.Drawing.Point(12, 35)
        Me.mesiace_combo.Name = "mesiace_combo"
        Me.mesiace_combo.Size = New System.Drawing.Size(133, 21)
        Me.mesiace_combo.TabIndex = 1
        '
        'zdruzenia_check
        '
        Me.zdruzenia_check.AutoSize = True
        Me.zdruzenia_check.Location = New System.Drawing.Point(223, 12)
        Me.zdruzenia_check.Name = "zdruzenia_check"
        Me.zdruzenia_check.Size = New System.Drawing.Size(139, 17)
        Me.zdruzenia_check.TabIndex = 2
        Me.zdruzenia_check.Text = "Zoznam po združeniach"
        Me.zdruzenia_check.UseVisualStyleBackColor = True
        '
        'zdruzenia_combo
        '
        Me.zdruzenia_combo.DataSource = Me.ZdruzeniaBindingSource
        Me.zdruzenia_combo.DisplayMember = "nazov"
        Me.zdruzenia_combo.Enabled = False
        Me.zdruzenia_combo.FormattingEnabled = True
        Me.zdruzenia_combo.Location = New System.Drawing.Point(223, 35)
        Me.zdruzenia_combo.Name = "zdruzenia_combo"
        Me.zdruzenia_combo.Size = New System.Drawing.Size(139, 21)
        Me.zdruzenia_combo.TabIndex = 3
        Me.zdruzenia_combo.ValueMember = "nazov"
        '
        'Zoznam_zdruzeni_combo
        '
        Me.Zoznam_zdruzeni_combo.DataSetName = "zoznam_zdruzeni_combo"
        Me.Zoznam_zdruzeni_combo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ZdruzeniaBindingSource
        '
        Me.ZdruzeniaBindingSource.DataMember = "zdruzenia"
        Me.ZdruzeniaBindingSource.DataSource = Me.Zoznam_zdruzeni_combo
        '
        'ZdruzeniaTableAdapter
        '
        Me.ZdruzeniaTableAdapter.ClearBeforeFill = True
        '
        'zoznam_narodeniny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 528)
        Me.Controls.Add(Me.zdruzenia_combo)
        Me.Controls.Add(Me.zdruzenia_check)
        Me.Controls.Add(Me.mesiace_combo)
        Me.Controls.Add(Me.narodeniny_check)
        Me.Name = "zoznam_narodeniny"
        Me.Text = "Zoznam narodenín členov"
        CType(Me.Zoznam_zdruzeni_combo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzeniaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents narodeniny_check As System.Windows.Forms.CheckBox
    Friend WithEvents mesiace_combo As System.Windows.Forms.ComboBox
    Friend WithEvents zdruzenia_check As System.Windows.Forms.CheckBox
    Friend WithEvents zdruzenia_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Zoznam_zdruzeni_combo As evidencia_spz.zoznam_zdruzeni_combo
    Friend WithEvents ZdruzeniaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZdruzeniaTableAdapter As evidencia_spz.zoznam_zdruzeni_comboTableAdapters.zdruzeniaTableAdapter
End Class
