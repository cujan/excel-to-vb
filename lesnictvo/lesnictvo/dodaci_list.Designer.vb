<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dodaci_list
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
        Me.text_odberatel = New System.Windows.Forms.Label
        Me.vybrat_odberatela = New System.Windows.Forms.Button
        Me.odberatel = New System.Windows.Forms.Label
        Me.text_drevina = New System.Windows.Forms.Label
        Me.drevina = New System.Windows.Forms.Label
        Me.vybrat_drevinu = New System.Windows.Forms.Button
        Me.text_cena = New System.Windows.Forms.Label
        Me.cena = New System.Windows.Forms.Label
        Me.vybrat_cenu = New System.Windows.Forms.Button
        Me.text_mnozstvo = New System.Windows.Forms.Label
        Me.monozstvo = New System.Windows.Forms.TextBox
        Me.text_suma_celkom = New System.Windows.Forms.Label
        Me.suma_celkom = New System.Windows.Forms.Label
        Me.zobrazit_fakturu = New System.Windows.Forms.Button
        Me.zobrazit_ppd = New System.Windows.Forms.Button
        Me.ulozit_dodaci_list = New System.Windows.Forms.Button
        Me.text_cislo_d_listu = New System.Windows.Forms.Label
        Me.cislo_d_listu = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'text_odberatel
        '
        Me.text_odberatel.AutoSize = True
        Me.text_odberatel.Location = New System.Drawing.Point(54, 42)
        Me.text_odberatel.Name = "text_odberatel"
        Me.text_odberatel.Size = New System.Drawing.Size(58, 13)
        Me.text_odberatel.TabIndex = 0
        Me.text_odberatel.Text = "Odberateľ:"
        '
        'vybrat_odberatela
        '
        Me.vybrat_odberatela.Location = New System.Drawing.Point(461, 37)
        Me.vybrat_odberatela.Name = "vybrat_odberatela"
        Me.vybrat_odberatela.Size = New System.Drawing.Size(134, 23)
        Me.vybrat_odberatela.TabIndex = 1
        Me.vybrat_odberatela.Text = "Vyberte odberateľa"
        Me.vybrat_odberatela.UseVisualStyleBackColor = True
        '
        'odberatel
        '
        Me.odberatel.AutoSize = True
        Me.odberatel.Location = New System.Drawing.Point(119, 42)
        Me.odberatel.Name = "odberatel"
        Me.odberatel.Size = New System.Drawing.Size(44, 13)
        Me.odberatel.TabIndex = 2
        Me.odberatel.Text = "prázdny"
        '
        'text_drevina
        '
        Me.text_drevina.AutoSize = True
        Me.text_drevina.Location = New System.Drawing.Point(47, 71)
        Me.text_drevina.Name = "text_drevina"
        Me.text_drevina.Size = New System.Drawing.Size(65, 13)
        Me.text_drevina.TabIndex = 3
        Me.text_drevina.Text = "Typ dreviny:"
        '
        'drevina
        '
        Me.drevina.AutoSize = True
        Me.drevina.Location = New System.Drawing.Point(118, 71)
        Me.drevina.Name = "drevina"
        Me.drevina.Size = New System.Drawing.Size(44, 13)
        Me.drevina.TabIndex = 4
        Me.drevina.Text = "prázdny"
        '
        'vybrat_drevinu
        '
        Me.vybrat_drevinu.Location = New System.Drawing.Point(461, 66)
        Me.vybrat_drevinu.Name = "vybrat_drevinu"
        Me.vybrat_drevinu.Size = New System.Drawing.Size(134, 23)
        Me.vybrat_drevinu.TabIndex = 5
        Me.vybrat_drevinu.Text = "Vyberte drevinu"
        Me.vybrat_drevinu.UseVisualStyleBackColor = True
        '
        'text_cena
        '
        Me.text_cena.AutoSize = True
        Me.text_cena.Location = New System.Drawing.Point(19, 98)
        Me.text_cena.Name = "text_cena"
        Me.text_cena.Size = New System.Drawing.Size(93, 13)
        Me.text_cena.TabIndex = 6
        Me.text_cena.Text = "Jednotková cena:"
        '
        'cena
        '
        Me.cena.AutoSize = True
        Me.cena.Location = New System.Drawing.Point(119, 98)
        Me.cena.Name = "cena"
        Me.cena.Size = New System.Drawing.Size(44, 13)
        Me.cena.TabIndex = 7
        Me.cena.Text = "prázdny"
        '
        'vybrat_cenu
        '
        Me.vybrat_cenu.Location = New System.Drawing.Point(462, 95)
        Me.vybrat_cenu.Name = "vybrat_cenu"
        Me.vybrat_cenu.Size = New System.Drawing.Size(133, 23)
        Me.vybrat_cenu.TabIndex = 8
        Me.vybrat_cenu.Text = "Vyberte cenu"
        Me.vybrat_cenu.UseVisualStyleBackColor = True
        '
        'text_mnozstvo
        '
        Me.text_mnozstvo.AutoSize = True
        Me.text_mnozstvo.Location = New System.Drawing.Point(294, 97)
        Me.text_mnozstvo.Name = "text_mnozstvo"
        Me.text_mnozstvo.Size = New System.Drawing.Size(56, 13)
        Me.text_mnozstvo.TabIndex = 9
        Me.text_mnozstvo.Text = "Množstvo:"
        '
        'monozstvo
        '
        Me.monozstvo.Location = New System.Drawing.Point(356, 94)
        Me.monozstvo.Name = "monozstvo"
        Me.monozstvo.Size = New System.Drawing.Size(50, 20)
        Me.monozstvo.TabIndex = 10
        Me.monozstvo.Text = "0"
        '
        'text_suma_celkom
        '
        Me.text_suma_celkom.AutoSize = True
        Me.text_suma_celkom.Location = New System.Drawing.Point(38, 147)
        Me.text_suma_celkom.Name = "text_suma_celkom"
        Me.text_suma_celkom.Size = New System.Drawing.Size(74, 13)
        Me.text_suma_celkom.TabIndex = 11
        Me.text_suma_celkom.Text = "Suma celkom:"
        '
        'suma_celkom
        '
        Me.suma_celkom.AutoSize = True
        Me.suma_celkom.Location = New System.Drawing.Point(119, 147)
        Me.suma_celkom.Name = "suma_celkom"
        Me.suma_celkom.Size = New System.Drawing.Size(44, 13)
        Me.suma_celkom.TabIndex = 12
        Me.suma_celkom.Text = "prázdny"
        '
        'zobrazit_fakturu
        '
        Me.zobrazit_fakturu.Location = New System.Drawing.Point(100, 193)
        Me.zobrazit_fakturu.Name = "zobrazit_fakturu"
        Me.zobrazit_fakturu.Size = New System.Drawing.Size(103, 23)
        Me.zobrazit_fakturu.TabIndex = 13
        Me.zobrazit_fakturu.Text = "Zobraziť faktúru"
        Me.zobrazit_fakturu.UseVisualStyleBackColor = True
        '
        'zobrazit_ppd
        '
        Me.zobrazit_ppd.Location = New System.Drawing.Point(218, 193)
        Me.zobrazit_ppd.Name = "zobrazit_ppd"
        Me.zobrazit_ppd.Size = New System.Drawing.Size(142, 23)
        Me.zobrazit_ppd.TabIndex = 14
        Me.zobrazit_ppd.Text = "Zobraziť preukaz pôvodu dreva"
        Me.zobrazit_ppd.UseVisualStyleBackColor = True
        '
        'ulozit_dodaci_list
        '
        Me.ulozit_dodaci_list.Location = New System.Drawing.Point(374, 193)
        Me.ulozit_dodaci_list.Name = "ulozit_dodaci_list"
        Me.ulozit_dodaci_list.Size = New System.Drawing.Size(105, 23)
        Me.ulozit_dodaci_list.TabIndex = 15
        Me.ulozit_dodaci_list.Text = "Uložiť dodací list"
        Me.ulozit_dodaci_list.UseVisualStyleBackColor = True
        '
        'text_cislo_d_listu
        '
        Me.text_cislo_d_listu.AutoSize = True
        Me.text_cislo_d_listu.Location = New System.Drawing.Point(4, 18)
        Me.text_cislo_d_listu.Name = "text_cislo_d_listu"
        Me.text_cislo_d_listu.Size = New System.Drawing.Size(108, 13)
        Me.text_cislo_d_listu.TabIndex = 16
        Me.text_cislo_d_listu.Text = "Číslo dodacieho listu:"
        '
        'cislo_d_listu
        '
        Me.cislo_d_listu.AutoSize = True
        Me.cislo_d_listu.Location = New System.Drawing.Point(119, 18)
        Me.cislo_d_listu.Name = "cislo_d_listu"
        Me.cislo_d_listu.Size = New System.Drawing.Size(44, 13)
        Me.cislo_d_listu.TabIndex = 17
        Me.cislo_d_listu.Text = "prázdny"
        '
        'dodaci_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 233)
        Me.Controls.Add(Me.cislo_d_listu)
        Me.Controls.Add(Me.text_cislo_d_listu)
        Me.Controls.Add(Me.ulozit_dodaci_list)
        Me.Controls.Add(Me.zobrazit_ppd)
        Me.Controls.Add(Me.zobrazit_fakturu)
        Me.Controls.Add(Me.suma_celkom)
        Me.Controls.Add(Me.text_suma_celkom)
        Me.Controls.Add(Me.monozstvo)
        Me.Controls.Add(Me.text_mnozstvo)
        Me.Controls.Add(Me.vybrat_cenu)
        Me.Controls.Add(Me.cena)
        Me.Controls.Add(Me.text_cena)
        Me.Controls.Add(Me.vybrat_drevinu)
        Me.Controls.Add(Me.drevina)
        Me.Controls.Add(Me.text_drevina)
        Me.Controls.Add(Me.odberatel)
        Me.Controls.Add(Me.vybrat_odberatela)
        Me.Controls.Add(Me.text_odberatel)
        Me.Name = "dodaci_list"
        Me.Text = "Dodací list"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents text_odberatel As System.Windows.Forms.Label
    Friend WithEvents vybrat_odberatela As System.Windows.Forms.Button
    Friend WithEvents odberatel As System.Windows.Forms.Label
    Friend WithEvents text_drevina As System.Windows.Forms.Label
    Friend WithEvents drevina As System.Windows.Forms.Label
    Friend WithEvents vybrat_drevinu As System.Windows.Forms.Button
    Friend WithEvents text_cena As System.Windows.Forms.Label
    Friend WithEvents cena As System.Windows.Forms.Label
    Friend WithEvents vybrat_cenu As System.Windows.Forms.Button
    Friend WithEvents text_mnozstvo As System.Windows.Forms.Label
    Friend WithEvents monozstvo As System.Windows.Forms.TextBox
    Friend WithEvents text_suma_celkom As System.Windows.Forms.Label
    Friend WithEvents suma_celkom As System.Windows.Forms.Label
    Friend WithEvents zobrazit_fakturu As System.Windows.Forms.Button
    Friend WithEvents zobrazit_ppd As System.Windows.Forms.Button
    Friend WithEvents ulozit_dodaci_list As System.Windows.Forms.Button
    Friend WithEvents text_cislo_d_listu As System.Windows.Forms.Label
    Friend WithEvents cislo_d_listu As System.Windows.Forms.Label
End Class
