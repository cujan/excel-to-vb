<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zoznam_chybajuce_kont_strelby
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
        Me.podla_zbrane_check = New System.Windows.Forms.CheckBox
        Me.podla_zbrane_combo = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'podla_zbrane_check
        '
        Me.podla_zbrane_check.AutoSize = True
        Me.podla_zbrane_check.Location = New System.Drawing.Point(31, 12)
        Me.podla_zbrane_check.Name = "podla_zbrane_check"
        Me.podla_zbrane_check.Size = New System.Drawing.Size(188, 17)
        Me.podla_zbrane_check.TabIndex = 0
        Me.podla_zbrane_check.Text = "Vytvoriťzostavu podľa typu zbrane"
        Me.podla_zbrane_check.UseVisualStyleBackColor = True
        '
        'podla_zbrane_combo
        '
        Me.podla_zbrane_combo.Enabled = False
        Me.podla_zbrane_combo.FormattingEnabled = True
        Me.podla_zbrane_combo.Items.AddRange(New Object() {"Broková zbraň", "Guľová zbraň"})
        Me.podla_zbrane_combo.Location = New System.Drawing.Point(225, 10)
        Me.podla_zbrane_combo.Name = "podla_zbrane_combo"
        Me.podla_zbrane_combo.Size = New System.Drawing.Size(75, 21)
        Me.podla_zbrane_combo.TabIndex = 1
        '
        'chybajuce_kont_strelby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 301)
        Me.Controls.Add(Me.podla_zbrane_combo)
        Me.Controls.Add(Me.podla_zbrane_check)
        Me.Name = "chybajuce_kont_strelby"
        Me.Text = "Chýbajúce kont. streľby"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents podla_zbrane_check As System.Windows.Forms.CheckBox
    Friend WithEvents podla_zbrane_combo As System.Windows.Forms.ComboBox
End Class
