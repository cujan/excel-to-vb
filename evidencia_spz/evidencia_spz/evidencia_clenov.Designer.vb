<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class evidencia_clenov
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.button_report_zoznam_clenov = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(99, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Koniec"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(212, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Ulož"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'button_report_zoznam_clenov
        '
        Me.button_report_zoznam_clenov.Location = New System.Drawing.Point(346, 53)
        Me.button_report_zoznam_clenov.Name = "button_report_zoznam_clenov"
        Me.button_report_zoznam_clenov.Size = New System.Drawing.Size(185, 23)
        Me.button_report_zoznam_clenov.TabIndex = 4
        Me.button_report_zoznam_clenov.Text = "Vytvor tlačovú formu zoznamu členov"
        Me.button_report_zoznam_clenov.UseVisualStyleBackColor = True
        '
        'evidencia_clenov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 354)
        Me.Controls.Add(Me.button_report_zoznam_clenov)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "evidencia_clenov"
        Me.Text = "evidencia_clenov"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents button_report_zoznam_clenov As System.Windows.Forms.Button
End Class
