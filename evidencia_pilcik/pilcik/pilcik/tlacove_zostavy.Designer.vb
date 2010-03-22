<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tlacove_zostavy
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
        Me.protokolCheckBox = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.protokol_kurzComboBox = New System.Windows.Forms.ComboBox
        Me.PilcikdbDataSet = New pilcik.pilcikdbDataSet
        Me.KurzBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KurzTableAdapter = New pilcik.pilcikdbDataSetTableAdapters.kurzTableAdapter
        CType(Me.PilcikdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'protokolCheckBox
        '
        Me.protokolCheckBox.AutoSize = True
        Me.protokolCheckBox.Location = New System.Drawing.Point(12, 81)
        Me.protokolCheckBox.Name = "protokolCheckBox"
        Me.protokolCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.protokolCheckBox.TabIndex = 0
        Me.protokolCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Protokol"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(276, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ukáž"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'protokol_kurzComboBox
        '
        Me.protokol_kurzComboBox.DataSource = Me.KurzBindingSource
        Me.protokol_kurzComboBox.DisplayMember = "nazov"
        Me.protokol_kurzComboBox.FormattingEnabled = True
        Me.protokol_kurzComboBox.Location = New System.Drawing.Point(94, 78)
        Me.protokol_kurzComboBox.Name = "protokol_kurzComboBox"
        Me.protokol_kurzComboBox.Size = New System.Drawing.Size(121, 21)
        Me.protokol_kurzComboBox.TabIndex = 3
        Me.protokol_kurzComboBox.ValueMember = "id"
        Me.protokol_kurzComboBox.Visible = False
        '
        'PilcikdbDataSet
        '
        Me.PilcikdbDataSet.DataSetName = "pilcikdbDataSet"
        Me.PilcikdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KurzBindingSource
        '
        Me.KurzBindingSource.DataMember = "kurz"
        Me.KurzBindingSource.DataSource = Me.PilcikdbDataSet
        '
        'KurzTableAdapter
        '
        Me.KurzTableAdapter.ClearBeforeFill = True
        '
        'tlacove_zostavy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 547)
        Me.Controls.Add(Me.protokol_kurzComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.protokolCheckBox)
        Me.Name = "tlacove_zostavy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "tlacove_zostavy"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PilcikdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents protokolCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents protokol_kurzComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PilcikdbDataSet As pilcik.pilcikdbDataSet
    Friend WithEvents KurzBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KurzTableAdapter As pilcik.pilcikdbDataSetTableAdapters.kurzTableAdapter
End Class
