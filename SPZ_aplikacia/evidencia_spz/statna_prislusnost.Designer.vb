<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class statna_prislusnost
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
        Dim SkratkaLabel As System.Windows.Forms.Label
        Dim NazovLabel As System.Windows.Forms.Label
        Me.Statna_prislusnostDataGridView = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.uloz = New System.Windows.Forms.Button
        Me.SkratkaTextBox = New System.Windows.Forms.TextBox
        Me.NazovTextBox = New System.Windows.Forms.TextBox
        Me.pridaj = New System.Windows.Forms.Button
        Me.zmaz = New System.Windows.Forms.Button
        SkratkaLabel = New System.Windows.Forms.Label
        NazovLabel = New System.Windows.Forms.Label
        CType(Me.Statna_prislusnostDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SkratkaLabel
        '
        SkratkaLabel.AutoSize = True
        SkratkaLabel.Location = New System.Drawing.Point(281, 37)
        SkratkaLabel.Name = "SkratkaLabel"
        SkratkaLabel.Size = New System.Drawing.Size(44, 13)
        SkratkaLabel.TabIndex = 6
        SkratkaLabel.Text = "Skratka"
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
        'Statna_prislusnostDataGridView
        '
        Me.Statna_prislusnostDataGridView.AllowUserToAddRows = False
        Me.Statna_prislusnostDataGridView.AllowUserToDeleteRows = False
        Me.Statna_prislusnostDataGridView.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.Statna_prislusnostDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Statna_prislusnostDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Statna_prislusnostDataGridView.Location = New System.Drawing.Point(312, 60)
        Me.Statna_prislusnostDataGridView.Name = "Statna_prislusnostDataGridView"
        Me.Statna_prislusnostDataGridView.ReadOnly = True
        Me.Statna_prislusnostDataGridView.Size = New System.Drawing.Size(231, 271)
        Me.Statna_prislusnostDataGridView.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(493, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Zavrieť podkartu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uloz
        '
        Me.uloz.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.uloz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uloz.Location = New System.Drawing.Point(412, 5)
        Me.uloz.Name = "uloz"
        Me.uloz.Size = New System.Drawing.Size(75, 23)
        Me.uloz.TabIndex = 3
        Me.uloz.Text = "Uložiť"
        Me.uloz.UseVisualStyleBackColor = False
        Me.uloz.Visible = False
        '
        'SkratkaTextBox
        '
        Me.SkratkaTextBox.Location = New System.Drawing.Point(331, 34)
        Me.SkratkaTextBox.Name = "SkratkaTextBox"
        Me.SkratkaTextBox.ReadOnly = True
        Me.SkratkaTextBox.Size = New System.Drawing.Size(75, 20)
        Me.SkratkaTextBox.TabIndex = 7
        '
        'NazovTextBox
        '
        Me.NazovTextBox.Location = New System.Drawing.Point(493, 34)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.ReadOnly = True
        Me.NazovTextBox.Size = New System.Drawing.Size(97, 20)
        Me.NazovTextBox.TabIndex = 9
        '
        'pridaj
        '
        Me.pridaj.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.pridaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pridaj.Location = New System.Drawing.Point(250, 5)
        Me.pridaj.Name = "pridaj"
        Me.pridaj.Size = New System.Drawing.Size(75, 23)
        Me.pridaj.TabIndex = 10
        Me.pridaj.Text = "Pridať"
        Me.pridaj.UseVisualStyleBackColor = False
        '
        'zmaz
        '
        Me.zmaz.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.zmaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zmaz.Location = New System.Drawing.Point(331, 5)
        Me.zmaz.Name = "zmaz"
        Me.zmaz.Size = New System.Drawing.Size(75, 23)
        Me.zmaz.TabIndex = 11
        Me.zmaz.Text = "Zmazať"
        Me.zmaz.UseVisualStyleBackColor = False
        '
        'statna_prislusnost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(691, 364)
        Me.Controls.Add(Me.zmaz)
        Me.Controls.Add(Me.pridaj)
        Me.Controls.Add(SkratkaLabel)
        Me.Controls.Add(Me.SkratkaTextBox)
        Me.Controls.Add(NazovLabel)
        Me.Controls.Add(Me.NazovTextBox)
        Me.Controls.Add(Me.uloz)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Statna_prislusnostDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "statna_prislusnost"
        Me.Text = "statna_prislusnost"
        CType(Me.Statna_prislusnostDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Statna_prislusnostDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents uloz As System.Windows.Forms.Button
    Friend WithEvents SkratkaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents pridaj As System.Windows.Forms.Button
    Friend WithEvents zmaz As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
