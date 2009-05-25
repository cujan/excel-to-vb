<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class generacia_registracii
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
        Me.ica = New System.Windows.Forms.Label
        Me.regcislo = New System.Windows.Forms.Label
        Me.ica_textbox = New System.Windows.Forms.TextBox
        Me.reg_cislo = New System.Windows.Forms.TextBox
        Me.generuj = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ica
        '
        Me.ica.AutoSize = True
        Me.ica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ica.Location = New System.Drawing.Point(12, 18)
        Me.ica.Name = "ica"
        Me.ica.Size = New System.Drawing.Size(206, 13)
        Me.ica.TabIndex = 0
        Me.ica.Text = "Identifikačné Číslo Aplikácie (IČA):"
        '
        'regcislo
        '
        Me.regcislo.AutoSize = True
        Me.regcislo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regcislo.Location = New System.Drawing.Point(107, 44)
        Me.regcislo.Name = "regcislo"
        Me.regcislo.Size = New System.Drawing.Size(111, 13)
        Me.regcislo.TabIndex = 1
        Me.regcislo.Text = "Registračné číslo:"
        '
        'ica_textbox
        '
        Me.ica_textbox.Location = New System.Drawing.Point(224, 15)
        Me.ica_textbox.Name = "ica_textbox"
        Me.ica_textbox.Size = New System.Drawing.Size(150, 20)
        Me.ica_textbox.TabIndex = 2
        '
        'reg_cislo
        '
        Me.reg_cislo.Location = New System.Drawing.Point(224, 41)
        Me.reg_cislo.Name = "reg_cislo"
        Me.reg_cislo.Size = New System.Drawing.Size(150, 20)
        Me.reg_cislo.TabIndex = 3
        '
        'generuj
        '
        Me.generuj.Location = New System.Drawing.Point(224, 67)
        Me.generuj.Name = "generuj"
        Me.generuj.Size = New System.Drawing.Size(150, 23)
        Me.generuj.TabIndex = 4
        Me.generuj.Text = "Generuj"
        Me.generuj.UseVisualStyleBackColor = True
        '
        'generacia_registracii
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 104)
        Me.Controls.Add(Me.generuj)
        Me.Controls.Add(Me.reg_cislo)
        Me.Controls.Add(Me.ica_textbox)
        Me.Controls.Add(Me.regcislo)
        Me.Controls.Add(Me.ica)
        Me.Name = "generacia_registracii"
        Me.Text = "Generovanie registračných čísel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ica As System.Windows.Forms.Label
    Friend WithEvents regcislo As System.Windows.Forms.Label
    Friend WithEvents ica_textbox As System.Windows.Forms.TextBox
    Friend WithEvents reg_cislo As System.Windows.Forms.TextBox
    Friend WithEvents generuj As System.Windows.Forms.Button

End Class
