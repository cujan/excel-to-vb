<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prehlad_clenov
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
        Me.prehlad_clenov_splitter = New System.Windows.Forms.SplitContainer
        Me.karta_clena_tlac_button = New System.Windows.Forms.Button
        Me.button_report_zoznam_clenov = New System.Windows.Forms.Button
        Me.zavriet_kartu = New System.Windows.Forms.Button
        Me.prehlad_clenov_splitter.Panel1.SuspendLayout()
        Me.prehlad_clenov_splitter.SuspendLayout()
        Me.SuspendLayout()
        '
        'prehlad_clenov_splitter
        '
        Me.prehlad_clenov_splitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.prehlad_clenov_splitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.prehlad_clenov_splitter.Location = New System.Drawing.Point(0, 0)
        Me.prehlad_clenov_splitter.Name = "prehlad_clenov_splitter"
        Me.prehlad_clenov_splitter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'prehlad_clenov_splitter.Panel1
        '
        Me.prehlad_clenov_splitter.Panel1.Controls.Add(Me.karta_clena_tlac_button)
        Me.prehlad_clenov_splitter.Panel1.Controls.Add(Me.button_report_zoznam_clenov)
        Me.prehlad_clenov_splitter.Panel1.Controls.Add(Me.zavriet_kartu)
        Me.prehlad_clenov_splitter.Size = New System.Drawing.Size(762, 400)
        Me.prehlad_clenov_splitter.SplitterDistance = 48
        Me.prehlad_clenov_splitter.TabIndex = 0
        '
        'karta_clena_tlac_button
        '
        Me.karta_clena_tlac_button.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.karta_clena_tlac_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.karta_clena_tlac_button.Location = New System.Drawing.Point(300, 20)
        Me.karta_clena_tlac_button.Name = "karta_clena_tlac_button"
        Me.karta_clena_tlac_button.Size = New System.Drawing.Size(139, 23)
        Me.karta_clena_tlac_button.TabIndex = 9
        Me.karta_clena_tlac_button.Text = "Vytvoriť karty členov"
        Me.karta_clena_tlac_button.UseVisualStyleBackColor = False
        '
        'button_report_zoznam_clenov
        '
        Me.button_report_zoznam_clenov.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.button_report_zoznam_clenov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_report_zoznam_clenov.Location = New System.Drawing.Point(127, 20)
        Me.button_report_zoznam_clenov.Name = "button_report_zoznam_clenov"
        Me.button_report_zoznam_clenov.Size = New System.Drawing.Size(167, 23)
        Me.button_report_zoznam_clenov.TabIndex = 8
        Me.button_report_zoznam_clenov.Text = "Vytvoriť tlačovú formu zoznamu členov"
        Me.button_report_zoznam_clenov.UseVisualStyleBackColor = False
        '
        'zavriet_kartu
        '
        Me.zavriet_kartu.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.zavriet_kartu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zavriet_kartu.Location = New System.Drawing.Point(445, 20)
        Me.zavriet_kartu.Name = "zavriet_kartu"
        Me.zavriet_kartu.Size = New System.Drawing.Size(82, 23)
        Me.zavriet_kartu.TabIndex = 0
        Me.zavriet_kartu.Text = "Zavrieť kartu"
        Me.zavriet_kartu.UseVisualStyleBackColor = False
        '
        'prehlad_clenov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(762, 400)
        Me.Controls.Add(Me.prehlad_clenov_splitter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "prehlad_clenov"
        Me.Text = "prehlad_clenov"
        Me.prehlad_clenov_splitter.Panel1.ResumeLayout(False)
        Me.prehlad_clenov_splitter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents prehlad_clenov_splitter As System.Windows.Forms.SplitContainer
    Friend WithEvents zavriet_kartu As System.Windows.Forms.Button
    Friend WithEvents karta_clena_tlac_button As System.Windows.Forms.Button
    Friend WithEvents button_report_zoznam_clenov As System.Windows.Forms.Button
End Class
