<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class platnost_clenstva
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
        Me.clenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.koniec_clenstvaDataSet1 = New evidencia_spz.koniec_clenstvaDataSet1
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.clenoviaTableAdapter = New evidencia_spz.koniec_clenstvaDataSet1TableAdapters.clenoviaTableAdapter
        Me.upozornenie = New System.Windows.Forms.Label
        CType(Me.clenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.koniec_clenstvaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clenoviaBindingSource
        '
        Me.clenoviaBindingSource.DataMember = "clenovia"
        Me.clenoviaBindingSource.DataSource = Me.koniec_clenstvaDataSet1
        '
        'koniec_clenstvaDataSet1
        '
        Me.koniec_clenstvaDataSet1.DataSetName = "koniec_clenstvaDataSet1"
        Me.koniec_clenstvaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Plastnosť členstva do:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.ComboBox1.Location = New System.Drawing.Point(149, 10)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(71, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "koniec_clenstvaDataSet1_clenovia"
        ReportDataSource1.Value = Me.clenoviaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "evidencia_spz.platnost_clenstva.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 61)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(869, 491)
        Me.ReportViewer1.TabIndex = 3
        '
        'clenoviaTableAdapter
        '
        Me.clenoviaTableAdapter.ClearBeforeFill = True
        '
        'upozornenie
        '
        Me.upozornenie.AutoSize = True
        Me.upozornenie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.upozornenie.ForeColor = System.Drawing.Color.DarkRed
        Me.upozornenie.Location = New System.Drawing.Point(10, 37)
        Me.upozornenie.Name = "upozornenie"
        Me.upozornenie.Size = New System.Drawing.Size(752, 13)
        Me.upozornenie.TabIndex = 4
        Me.upozornenie.Text = "Upozornenie: Daný výstup zobrazí iba členov, ktorým členstvo končí v roku. Členov" & _
            "ia, ktorým členstvo končí v predchádzajúcich rokoch tu nie sú zobrazení!"
        '
        'platnost_clenstva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 564)
        Me.Controls.Add(Me.upozornenie)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "platnost_clenstva"
        Me.Text = "Platnosť členstva"
        CType(Me.clenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.koniec_clenstvaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents clenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents koniec_clenstvaDataSet1 As evidencia_spz.koniec_clenstvaDataSet1
    Friend WithEvents clenoviaTableAdapter As evidencia_spz.koniec_clenstvaDataSet1TableAdapters.clenoviaTableAdapter
    Friend WithEvents upozornenie As System.Windows.Forms.Label
End Class
