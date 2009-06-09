<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zoznam_clenov_podla_zdruzenia
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
        Me.Zoznam_clenov_podla_zdruzeniaDataSet = New evidencia_spz.zoznam_clenov_podla_zdruzeniaDataSet
        Me.ClenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClenoviaTableAdapter = New evidencia_spz.zoznam_clenov_podla_zdruzeniaDataSetTableAdapters.clenoviaTableAdapter
        Me.TableAdapterManager = New evidencia_spz.zoznam_clenov_podla_zdruzeniaDataSetTableAdapters.TableAdapterManager
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ZdruzenieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZdruzenieDataSet = New evidencia_spz.zdruzenieDataSet
        Me.ZdruzenieTableAdapter = New evidencia_spz.zdruzenieDataSetTableAdapters.zdruzenieTableAdapter
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.podla_zdruzenia = New System.Windows.Forms.Label
        CType(Me.Zoznam_clenov_podla_zdruzeniaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzenieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzenieDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Zoznam_clenov_podla_zdruzeniaDataSet
        '
        Me.Zoznam_clenov_podla_zdruzeniaDataSet.DataSetName = "zoznam_clenov_podla_zdruzeniaDataSet"
        Me.Zoznam_clenov_podla_zdruzeniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClenoviaBindingSource
        '
        Me.ClenoviaBindingSource.DataMember = "clenovia"
        Me.ClenoviaBindingSource.DataSource = Me.Zoznam_clenov_podla_zdruzeniaDataSet
        '
        'ClenoviaTableAdapter
        '
        Me.ClenoviaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.zoznam_clenov_podla_zdruzeniaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ZdruzenieBindingSource
        Me.ComboBox1.DisplayMember = "nazov"
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(245, 10)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "ID"
        '
        'ZdruzenieBindingSource
        '
        Me.ZdruzenieBindingSource.DataMember = "zdruzenie"
        Me.ZdruzenieBindingSource.DataSource = Me.ZdruzenieDataSet
        '
        'ZdruzenieDataSet
        '
        Me.ZdruzenieDataSet.DataSetName = "zdruzenieDataSet"
        Me.ZdruzenieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ZdruzenieTableAdapter
        '
        Me.ZdruzenieTableAdapter.ClearBeforeFill = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(224, 13)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "zoznam_clenov_podla_zdruzeniaDataSet_clenovia"
        ReportDataSource1.Value = Me.ClenoviaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "evidencia_spz.zoznam_clenov_podla_zdruzenia_report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 41)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(846, 562)
        Me.ReportViewer1.TabIndex = 4
        '
        'podla_zdruzenia
        '
        Me.podla_zdruzenia.AutoSize = True
        Me.podla_zdruzenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.podla_zdruzenia.Location = New System.Drawing.Point(29, 13)
        Me.podla_zdruzenia.Name = "podla_zdruzenia"
        Me.podla_zdruzenia.Size = New System.Drawing.Size(189, 13)
        Me.podla_zdruzenia.TabIndex = 16
        Me.podla_zdruzenia.Text = "Prehľad členov podľa združenia"
        '
        'zoznam_clenov_podla_zdruzenia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 615)
        Me.Controls.Add(Me.podla_zdruzenia)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "zoznam_clenov_podla_zdruzenia"
        Me.Text = "Zoznam členov"
        CType(Me.Zoznam_clenov_podla_zdruzeniaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzenieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzenieDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Zoznam_clenov_podla_zdruzeniaDataSet As evidencia_spz.zoznam_clenov_podla_zdruzeniaDataSet
    Friend WithEvents ClenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClenoviaTableAdapter As evidencia_spz.zoznam_clenov_podla_zdruzeniaDataSetTableAdapters.clenoviaTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.zoznam_clenov_podla_zdruzeniaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ZdruzenieDataSet As evidencia_spz.zdruzenieDataSet
    Friend WithEvents ZdruzenieBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZdruzenieTableAdapter As evidencia_spz.zdruzenieDataSetTableAdapters.zdruzenieTableAdapter
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents podla_zdruzenia As System.Windows.Forms.Label
End Class
