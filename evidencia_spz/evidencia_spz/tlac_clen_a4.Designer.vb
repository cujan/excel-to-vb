﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tlac_clen_a4
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.spz_clenovia_report_a4 = New evidencia_spz.spz_clenovia_report_a4
        Me.clenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clenoviaTableAdapter = New evidencia_spz.spz_clenovia_report_a4TableAdapters.clenoviaTableAdapter
        CType(Me.spz_clenovia_report_a4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "spz_clenovia_report_a4_clenovia"
        ReportDataSource1.Value = Me.clenoviaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "evidencia_spz.a4_report_2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(829, 778)
        Me.ReportViewer1.TabIndex = 0
        '
        'spz_clenovia_report_a4
        '
        Me.spz_clenovia_report_a4.DataSetName = "spz_clenovia_report_a4"
        Me.spz_clenovia_report_a4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'clenoviaBindingSource
        '
        Me.clenoviaBindingSource.DataMember = "clenovia"
        Me.clenoviaBindingSource.DataSource = Me.spz_clenovia_report_a4
        '
        'clenoviaTableAdapter
        '
        Me.clenoviaTableAdapter.ClearBeforeFill = True
        '
        'tlac_clen_a4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 778)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "tlac_clen_a4"
        Me.Text = "Tlačový výstup - Člen"
        CType(Me.spz_clenovia_report_a4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents clenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents spz_clenovia_report_a4 As evidencia_spz.spz_clenovia_report_a4
    Friend WithEvents clenoviaTableAdapter As evidencia_spz.spz_clenovia_report_a4TableAdapters.clenoviaTableAdapter
End Class