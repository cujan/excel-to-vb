<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chybajuce_kontrolne_strelby_brok
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
        Me.Kontrolne_strelby_brokDataSet1 = New evidencia_spz.Kontrolne_strelby_brokDataSet1
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.clenoviaTableAdapter = New evidencia_spz.Kontrolne_strelby_brokDataSet1TableAdapters.clenoviaTableAdapter
        CType(Me.clenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kontrolne_strelby_brokDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clenoviaBindingSource
        '
        Me.clenoviaBindingSource.DataMember = "clenovia"
        Me.clenoviaBindingSource.DataSource = Me.Kontrolne_strelby_brokDataSet1
        '
        'Kontrolne_strelby_brokDataSet1
        '
        Me.Kontrolne_strelby_brokDataSet1.DataSetName = "Kontrolne_strelby_brokDataSet1"
        Me.Kontrolne_strelby_brokDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "Kontrolne_strelby_brokDataSet1_clenovia"
        ReportDataSource1.Value = Me.clenoviaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "evidencia_spz.chybajuce_kontr_strelby_brok.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(760, 382)
        Me.ReportViewer1.TabIndex = 0
        '
        'clenoviaTableAdapter
        '
        Me.clenoviaTableAdapter.ClearBeforeFill = True
        '
        'chybajuce_kontrolne_strelby_brok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 382)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "chybajuce_kontrolne_strelby_brok"
        Me.Text = "Chýbajúce kontrolné streľby - Brok"
        CType(Me.clenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kontrolne_strelby_brokDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents clenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Kontrolne_strelby_brokDataSet1 As evidencia_spz.Kontrolne_strelby_brokDataSet1
    Friend WithEvents clenoviaTableAdapter As evidencia_spz.Kontrolne_strelby_brokDataSet1TableAdapters.clenoviaTableAdapter
End Class
