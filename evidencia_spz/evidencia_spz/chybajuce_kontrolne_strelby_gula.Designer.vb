﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chybajuce_kontrolne_strelby_gula
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
        Me.kontrolne_strelby_gulaDataSet1 = New evidencia_spz.kontrolne_strelby_gulaDataSet1
        Me.clenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clenoviaTableAdapter = New evidencia_spz.kontrolne_strelby_gulaDataSet1TableAdapters.clenoviaTableAdapter
        CType(Me.kontrolne_strelby_gulaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "kontrolne_strelby_gulaDataSet1_clenovia"
        ReportDataSource1.Value = Me.clenoviaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "evidencia_spz.chybajuce_kont_strelby.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(742, 368)
        Me.ReportViewer1.TabIndex = 0
        '
        'kontrolne_strelby_gulaDataSet1
        '
        Me.kontrolne_strelby_gulaDataSet1.DataSetName = "kontrolne_strelby_gulaDataSet1"
        Me.kontrolne_strelby_gulaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'clenoviaBindingSource
        '
        Me.clenoviaBindingSource.DataMember = "clenovia"
        Me.clenoviaBindingSource.DataSource = Me.kontrolne_strelby_gulaDataSet1
        '
        'clenoviaTableAdapter
        '
        Me.clenoviaTableAdapter.ClearBeforeFill = True
        '
        'chybajuce_kontrolne_strelby_gula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 368)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "chybajuce_kontrolne_strelby_gula"
        Me.Text = "Chýbajúce kontrolné streľby - Guľa"
        CType(Me.kontrolne_strelby_gulaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents clenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents kontrolne_strelby_gulaDataSet1 As evidencia_spz.kontrolne_strelby_gulaDataSet1
    Friend WithEvents clenoviaTableAdapter As evidencia_spz.kontrolne_strelby_gulaDataSet1TableAdapters.clenoviaTableAdapter
End Class
