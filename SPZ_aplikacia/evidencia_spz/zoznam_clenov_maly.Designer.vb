﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zoznam_clenov_maly
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
        Me.kartyClenov = New evidencia_spz.kartyClenov
        Me.karty_clenovBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.karty_clenovTableAdapter = New evidencia_spz.kartyClenovTableAdapters.karty_clenovTableAdapter
        CType(Me.kartyClenov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.karty_clenovBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "kartyClenov_karty_clenov"
        ReportDataSource1.Value = Me.karty_clenovBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "evidencia_spz.zoznam_clenov_maly_report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(972, 495)
        Me.ReportViewer1.TabIndex = 0
        '
        'kartyClenov
        '
        Me.kartyClenov.DataSetName = "kartyClenov"
        Me.kartyClenov.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'karty_clenovBindingSource
        '
        Me.karty_clenovBindingSource.DataMember = "karty_clenov"
        Me.karty_clenovBindingSource.DataSource = Me.kartyClenov
        '
        'karty_clenovTableAdapter
        '
        Me.karty_clenovTableAdapter.ClearBeforeFill = True
        '
        'zoznam_clenov_maly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 495)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "zoznam_clenov_maly"
        Me.Text = "Zoznam členov"
        CType(Me.kartyClenov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.karty_clenovBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents karty_clenovBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents kartyClenov As evidencia_spz.kartyClenov
    Friend WithEvents karty_clenovTableAdapter As evidencia_spz.kartyClenovTableAdapters.karty_clenovTableAdapter
End Class