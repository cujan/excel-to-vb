<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class narodky
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.narodeniny_DataSet = New evidencia_spz.narodeniny_DataSet
        Me.clenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clenoviaTableAdapter = New evidencia_spz.narodeniny_DataSetTableAdapters.clenoviaTableAdapter
        Me.mesiac_label = New System.Windows.Forms.Label
        Me.mesiac = New System.Windows.Forms.ComboBox
        CType(Me.narodeniny_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "narodeniny_DataSet_clenovia"
        ReportDataSource3.Value = Me.clenoviaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "evidencia_spz.narodeniny_clenov.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 41)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(747, 451)
        Me.ReportViewer1.TabIndex = 0
        '
        'narodeniny_DataSet
        '
        Me.narodeniny_DataSet.DataSetName = "narodeniny_DataSet"
        Me.narodeniny_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'clenoviaBindingSource
        '
        Me.clenoviaBindingSource.DataMember = "clenovia"
        Me.clenoviaBindingSource.DataSource = Me.narodeniny_DataSet
        '
        'clenoviaTableAdapter
        '
        Me.clenoviaTableAdapter.ClearBeforeFill = True
        '
        'mesiac_label
        '
        Me.mesiac_label.AutoSize = True
        Me.mesiac_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mesiac_label.Location = New System.Drawing.Point(35, 15)
        Me.mesiac_label.Name = "mesiac_label"
        Me.mesiac_label.Size = New System.Drawing.Size(97, 13)
        Me.mesiac_label.TabIndex = 1
        Me.mesiac_label.Text = "Vyberte mesiac:"
        '
        'mesiac
        '
        Me.mesiac.FormattingEnabled = True
        Me.mesiac.Items.AddRange(New Object() {"Január", "Február", "Marec", "Apríl", "Máj", "Jún", "Júl", "August", "September", "Október", "November", "December"})
        Me.mesiac.Location = New System.Drawing.Point(138, 12)
        Me.mesiac.Name = "mesiac"
        Me.mesiac.Size = New System.Drawing.Size(91, 21)
        Me.mesiac.TabIndex = 2
        '
        'narodky
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 504)
        Me.Controls.Add(Me.mesiac)
        Me.Controls.Add(Me.mesiac_label)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "narodky"
        Me.Text = "Narodeniny členov"
        CType(Me.narodeniny_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents clenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents narodeniny_DataSet As evidencia_spz.narodeniny_DataSet
    Friend WithEvents clenoviaTableAdapter As evidencia_spz.narodeniny_DataSetTableAdapters.clenoviaTableAdapter
    Friend WithEvents mesiac_label As System.Windows.Forms.Label
    Friend WithEvents mesiac As System.Windows.Forms.ComboBox
End Class
