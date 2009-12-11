<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registracia_aplikacie
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
        Dim Reg_cisloLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registracia_aplikacie))
        Me.infoText = New System.Windows.Forms.Label
        Me.ica_label = New System.Windows.Forms.Label
        Me.registruj = New System.Windows.Forms.Button
        Me.zavriet = New System.Windows.Forms.Button
        Me.reg_cislo = New System.Windows.Forms.TextBox
        Me.ica = New System.Windows.Forms.TextBox
        Me.kontakt = New System.Windows.Forms.Button
        Reg_cisloLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Reg_cisloLabel
        '
        Reg_cisloLabel.AutoSize = True
        Reg_cisloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Reg_cisloLabel.Location = New System.Drawing.Point(356, 206)
        Reg_cisloLabel.Name = "Reg_cisloLabel"
        Reg_cisloLabel.Size = New System.Drawing.Size(111, 13)
        Reg_cisloLabel.TabIndex = 1
        Reg_cisloLabel.Text = "Registračné číslo:"
        '
        'infoText
        '
        Me.infoText.Location = New System.Drawing.Point(293, 115)
        Me.infoText.Name = "infoText"
        Me.infoText.Size = New System.Drawing.Size(438, 64)
        Me.infoText.TabIndex = 3
        Me.infoText.Text = resources.GetString("infoText.Text")
        Me.infoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ica_label
        '
        Me.ica_label.AutoSize = True
        Me.ica_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ica_label.ForeColor = System.Drawing.Color.DarkRed
        Me.ica_label.Location = New System.Drawing.Point(263, 183)
        Me.ica_label.Name = "ica_label"
        Me.ica_label.Size = New System.Drawing.Size(204, 13)
        Me.ica_label.TabIndex = 4
        Me.ica_label.Text = "Identifikačné číslo aplikácie (IČA):"
        '
        'registruj
        '
        Me.registruj.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.registruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registruj.Location = New System.Drawing.Point(308, 244)
        Me.registruj.Name = "registruj"
        Me.registruj.Size = New System.Drawing.Size(171, 23)
        Me.registruj.TabIndex = 6
        Me.registruj.Text = "REGISTRUJ"
        Me.registruj.UseVisualStyleBackColor = False
        '
        'zavriet
        '
        Me.zavriet.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.zavriet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zavriet.Location = New System.Drawing.Point(645, 244)
        Me.zavriet.Name = "zavriet"
        Me.zavriet.Size = New System.Drawing.Size(86, 23)
        Me.zavriet.TabIndex = 7
        Me.zavriet.Text = "Zavrieť kartu"
        Me.zavriet.UseVisualStyleBackColor = False
        '
        'reg_cislo
        '
        Me.reg_cislo.Location = New System.Drawing.Point(476, 203)
        Me.reg_cislo.Name = "reg_cislo"
        Me.reg_cislo.Size = New System.Drawing.Size(210, 20)
        Me.reg_cislo.TabIndex = 8
        '
        'ica
        '
        Me.ica.BackColor = System.Drawing.Color.PaleGreen
        Me.ica.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ica.ForeColor = System.Drawing.Color.DarkRed
        Me.ica.Location = New System.Drawing.Point(476, 183)
        Me.ica.Name = "ica"
        Me.ica.ReadOnly = True
        Me.ica.Size = New System.Drawing.Size(210, 13)
        Me.ica.TabIndex = 9
        '
        'kontakt
        '
        Me.kontakt.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.kontakt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.kontakt.Location = New System.Drawing.Point(485, 244)
        Me.kontakt.Name = "kontakt"
        Me.kontakt.Size = New System.Drawing.Size(154, 23)
        Me.kontakt.TabIndex = 10
        Me.kontakt.Text = "Kontakt - tvorcovia aplikacie"
        Me.kontakt.UseVisualStyleBackColor = False
        '
        'registracia_aplikacie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(950, 290)
        Me.Controls.Add(Me.kontakt)
        Me.Controls.Add(Me.ica)
        Me.Controls.Add(Me.reg_cislo)
        Me.Controls.Add(Me.zavriet)
        Me.Controls.Add(Me.registruj)
        Me.Controls.Add(Me.ica_label)
        Me.Controls.Add(Me.infoText)
        Me.Controls.Add(Reg_cisloLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "registracia_aplikacie"
        Me.Text = "registracia_aplikacie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents infoText As System.Windows.Forms.Label
    Friend WithEvents ica_label As System.Windows.Forms.Label
    Friend WithEvents registruj As System.Windows.Forms.Button
    Friend WithEvents zavriet As System.Windows.Forms.Button
    Friend WithEvents reg_cislo As System.Windows.Forms.TextBox
    Friend WithEvents ica As System.Windows.Forms.TextBox
    Friend WithEvents kontakt As System.Windows.Forms.Button
End Class
