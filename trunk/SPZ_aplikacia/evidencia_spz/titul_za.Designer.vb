<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class titul_za
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
        Dim NazovLabel As System.Windows.Forms.Label
        Dim SkratkaLabel As System.Windows.Forms.Label
        Me.Titul_zaDataGridView = New System.Windows.Forms.DataGridView
        Me.skratka = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.koniec = New System.Windows.Forms.Button
        Me.pridaj = New System.Windows.Forms.Button
        Me.uloz = New System.Windows.Forms.Button
        Me.zmaz = New System.Windows.Forms.Button
        Me.NazovTextBox = New System.Windows.Forms.TextBox
        Me.SkratkaTextBox = New System.Windows.Forms.TextBox
        NazovLabel = New System.Windows.Forms.Label
        SkratkaLabel = New System.Windows.Forms.Label
        CType(Me.Titul_zaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NazovLabel
        '
        NazovLabel.AutoSize = True
        NazovLabel.Location = New System.Drawing.Point(449, 37)
        NazovLabel.Name = "NazovLabel"
        NazovLabel.Size = New System.Drawing.Size(38, 13)
        NazovLabel.TabIndex = 8
        NazovLabel.Text = "Názov"
        '
        'SkratkaLabel
        '
        SkratkaLabel.AutoSize = True
        SkratkaLabel.Location = New System.Drawing.Point(281, 37)
        SkratkaLabel.Name = "SkratkaLabel"
        SkratkaLabel.Size = New System.Drawing.Size(44, 13)
        SkratkaLabel.TabIndex = 9
        SkratkaLabel.Text = "Skratka"
        '
        'Titul_zaDataGridView
        '
        Me.Titul_zaDataGridView.AllowUserToAddRows = False
        Me.Titul_zaDataGridView.AllowUserToDeleteRows = False
        Me.Titul_zaDataGridView.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.Titul_zaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Titul_zaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Titul_zaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.skratka})
        Me.Titul_zaDataGridView.Location = New System.Drawing.Point(305, 60)
        Me.Titul_zaDataGridView.Name = "Titul_zaDataGridView"
        Me.Titul_zaDataGridView.ReadOnly = True
        Me.Titul_zaDataGridView.Size = New System.Drawing.Size(261, 376)
        Me.Titul_zaDataGridView.TabIndex = 1
        '
        'skratka
        '
        Me.skratka.DataPropertyName = "skratka"
        Me.skratka.HeaderText = "Skratka"
        Me.skratka.Name = "skratka"
        Me.skratka.ReadOnly = True
        '
        'koniec
        '
        Me.koniec.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.koniec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.koniec.Location = New System.Drawing.Point(493, 5)
        Me.koniec.Name = "koniec"
        Me.koniec.Size = New System.Drawing.Size(97, 23)
        Me.koniec.TabIndex = 2
        Me.koniec.Text = "Zavrieť podkartu"
        Me.koniec.UseVisualStyleBackColor = False
        '
        'pridaj
        '
        Me.pridaj.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.pridaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pridaj.Location = New System.Drawing.Point(250, 5)
        Me.pridaj.Name = "pridaj"
        Me.pridaj.Size = New System.Drawing.Size(75, 23)
        Me.pridaj.TabIndex = 3
        Me.pridaj.Text = "Pridať"
        Me.pridaj.UseVisualStyleBackColor = False
        '
        'uloz
        '
        Me.uloz.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.uloz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uloz.Location = New System.Drawing.Point(412, 5)
        Me.uloz.Name = "uloz"
        Me.uloz.Size = New System.Drawing.Size(75, 23)
        Me.uloz.TabIndex = 4
        Me.uloz.Text = "Uložiť"
        Me.uloz.UseVisualStyleBackColor = False
        Me.uloz.Visible = False
        '
        'zmaz
        '
        Me.zmaz.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.zmaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zmaz.Location = New System.Drawing.Point(331, 5)
        Me.zmaz.Name = "zmaz"
        Me.zmaz.Size = New System.Drawing.Size(75, 23)
        Me.zmaz.TabIndex = 5
        Me.zmaz.Text = "Zmazať"
        Me.zmaz.UseVisualStyleBackColor = False
        '
        'NazovTextBox
        '
        Me.NazovTextBox.Location = New System.Drawing.Point(493, 34)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.ReadOnly = True
        Me.NazovTextBox.Size = New System.Drawing.Size(97, 20)
        Me.NazovTextBox.TabIndex = 9
        '
        'SkratkaTextBox
        '
        Me.SkratkaTextBox.Location = New System.Drawing.Point(331, 34)
        Me.SkratkaTextBox.Name = "SkratkaTextBox"
        Me.SkratkaTextBox.ReadOnly = True
        Me.SkratkaTextBox.Size = New System.Drawing.Size(75, 20)
        Me.SkratkaTextBox.TabIndex = 10
        '
        'titul_za
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(774, 519)
        Me.Controls.Add(SkratkaLabel)
        Me.Controls.Add(Me.SkratkaTextBox)
        Me.Controls.Add(NazovLabel)
        Me.Controls.Add(Me.NazovTextBox)
        Me.Controls.Add(Me.zmaz)
        Me.Controls.Add(Me.uloz)
        Me.Controls.Add(Me.pridaj)
        Me.Controls.Add(Me.koniec)
        Me.Controls.Add(Me.Titul_zaDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "titul_za"
        Me.Text = "titul_za"
        CType(Me.Titul_zaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Titul_zaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents koniec As System.Windows.Forms.Button
    Friend WithEvents pridaj As System.Windows.Forms.Button
    Friend WithEvents uloz As System.Windows.Forms.Button
    Friend WithEvents zmaz As System.Windows.Forms.Button
    Friend WithEvents NazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SkratkaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents skratka As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
