<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class o_aplikacii
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
        Me.uvod = New System.Windows.Forms.Label
        Me.tvorca = New System.Windows.Forms.Label
        Me.tvorca_detail = New System.Windows.Forms.Label
        Me.kontakt = New System.Windows.Forms.Label
        Me.tel = New System.Windows.Forms.Label
        Me.email = New System.Windows.Forms.Label
        Me.tel_hodnota = New System.Windows.Forms.Label
        Me.email_hodnota = New System.Windows.Forms.Label
        Me.zavriet = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'uvod
        '
        Me.uvod.Location = New System.Drawing.Point(279, 42)
        Me.uvod.Name = "uvod"
        Me.uvod.Size = New System.Drawing.Size(322, 63)
        Me.uvod.TabIndex = 0
        Me.uvod.Text = "Aplikácia ""Administrácia SPZ"" je určená pre správu agendy poľovníckych združení z" & _
            "astrešovaných pod Slovenským poľovníckym zväzom."
        Me.uvod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tvorca
        '
        Me.tvorca.AutoSize = True
        Me.tvorca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvorca.Location = New System.Drawing.Point(275, 133)
        Me.tvorca.Name = "tvorca"
        Me.tvorca.Size = New System.Drawing.Size(115, 17)
        Me.tvorca.TabIndex = 1
        Me.tvorca.Text = "Tvorca aplikácie:"
        '
        'tvorca_detail
        '
        Me.tvorca_detail.AutoSize = True
        Me.tvorca_detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvorca_detail.Location = New System.Drawing.Point(396, 127)
        Me.tvorca_detail.Name = "tvorca_detail"
        Me.tvorca_detail.Size = New System.Drawing.Size(208, 24)
        Me.tvorca_detail.TabIndex = 2
        Me.tvorca_detail.Text = "H&&K Software Solutions"
        '
        'kontakt
        '
        Me.kontakt.AutoSize = True
        Me.kontakt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kontakt.Location = New System.Drawing.Point(334, 173)
        Me.kontakt.Name = "kontakt"
        Me.kontakt.Size = New System.Drawing.Size(56, 17)
        Me.kontakt.TabIndex = 3
        Me.kontakt.Text = "Kontakt"
        '
        'tel
        '
        Me.tel.AutoSize = True
        Me.tel.Location = New System.Drawing.Point(362, 206)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(28, 13)
        Me.tel.TabIndex = 4
        Me.tel.Text = "Tel.:"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Location = New System.Drawing.Point(352, 243)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(38, 13)
        Me.email.TabIndex = 5
        Me.email.Text = "E-mail:"
        '
        'tel_hodnota
        '
        Me.tel_hodnota.AutoSize = True
        Me.tel_hodnota.Location = New System.Drawing.Point(397, 206)
        Me.tel_hodnota.Name = "tel_hodnota"
        Me.tel_hodnota.Size = New System.Drawing.Size(43, 13)
        Me.tel_hodnota.TabIndex = 6
        Me.tel_hodnota.Text = "??????"
        '
        'email_hodnota
        '
        Me.email_hodnota.AutoSize = True
        Me.email_hodnota.Location = New System.Drawing.Point(397, 243)
        Me.email_hodnota.Name = "email_hodnota"
        Me.email_hodnota.Size = New System.Drawing.Size(55, 13)
        Me.email_hodnota.TabIndex = 7
        Me.email_hodnota.Text = "????????"
        '
        'zavriet
        '
        Me.zavriet.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.zavriet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zavriet.Location = New System.Drawing.Point(511, 270)
        Me.zavriet.Name = "zavriet"
        Me.zavriet.Size = New System.Drawing.Size(90, 23)
        Me.zavriet.TabIndex = 8
        Me.zavriet.Text = "Zavrieť kartu"
        Me.zavriet.UseVisualStyleBackColor = False
        '
        'o_aplikacii
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(708, 330)
        Me.Controls.Add(Me.zavriet)
        Me.Controls.Add(Me.email_hodnota)
        Me.Controls.Add(Me.tel_hodnota)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.tel)
        Me.Controls.Add(Me.kontakt)
        Me.Controls.Add(Me.tvorca_detail)
        Me.Controls.Add(Me.tvorca)
        Me.Controls.Add(Me.uvod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "o_aplikacii"
        Me.Text = "o_aplikacii"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uvod As System.Windows.Forms.Label
    Friend WithEvents tvorca As System.Windows.Forms.Label
    Friend WithEvents tvorca_detail As System.Windows.Forms.Label
    Friend WithEvents kontakt As System.Windows.Forms.Label
    Friend WithEvents tel As System.Windows.Forms.Label
    Friend WithEvents email As System.Windows.Forms.Label
    Friend WithEvents tel_hodnota As System.Windows.Forms.Label
    Friend WithEvents email_hodnota As System.Windows.Forms.Label
    Friend WithEvents zavriet As System.Windows.Forms.Button
End Class
