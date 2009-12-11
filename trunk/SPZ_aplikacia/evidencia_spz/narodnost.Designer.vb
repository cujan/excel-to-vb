<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class narodnost
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
        Me.NarodnostDataGridView = New System.Windows.Forms.DataGridView
        Me.SkratkaTextBox = New System.Windows.Forms.TextBox
        Me.NazovTextBox = New System.Windows.Forms.TextBox
        Me.koniec = New System.Windows.Forms.Button
        Me.pridajButton = New System.Windows.Forms.Button
        Me.ulozButton = New System.Windows.Forms.Button
        Me.zmazButton = New System.Windows.Forms.Button
        SkratkaLabel = New System.Windows.Forms.Label
        NazovLabel = New System.Windows.Forms.Label
        CType(Me.NarodnostDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SkratkaLabel
        '
        SkratkaLabel.AutoSize = True
        SkratkaLabel.Location = New System.Drawing.Point(281, 37)
        SkratkaLabel.Name = "SkratkaLabel"
        SkratkaLabel.Size = New System.Drawing.Size(44, 13)
        SkratkaLabel.TabIndex = 4
        SkratkaLabel.Text = "Skratka"
        '
        'NazovLabel
        '
        NazovLabel.AutoSize = True
        NazovLabel.Location = New System.Drawing.Point(449, 37)
        NazovLabel.Name = "NazovLabel"
        NazovLabel.Size = New System.Drawing.Size(38, 13)
        NazovLabel.TabIndex = 6
        NazovLabel.Text = "Názov"
        '
        'NarodnostDataGridView
        '
        Me.NarodnostDataGridView.AllowUserToAddRows = False
        Me.NarodnostDataGridView.AllowUserToDeleteRows = False
        Me.NarodnostDataGridView.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.NarodnostDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NarodnostDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NarodnostDataGridView.Location = New System.Drawing.Point(318, 60)
        Me.NarodnostDataGridView.Name = "NarodnostDataGridView"
        Me.NarodnostDataGridView.ReadOnly = True
        Me.NarodnostDataGridView.Size = New System.Drawing.Size(231, 239)
        Me.NarodnostDataGridView.TabIndex = 1
        '
        'SkratkaTextBox
        '
        Me.SkratkaTextBox.Location = New System.Drawing.Point(331, 34)
        Me.SkratkaTextBox.Name = "SkratkaTextBox"
        Me.SkratkaTextBox.ReadOnly = True
        Me.SkratkaTextBox.Size = New System.Drawing.Size(75, 20)
        Me.SkratkaTextBox.TabIndex = 5
        '
        'NazovTextBox
        '
        Me.NazovTextBox.Location = New System.Drawing.Point(493, 34)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.ReadOnly = True
        Me.NazovTextBox.Size = New System.Drawing.Size(97, 20)
        Me.NazovTextBox.TabIndex = 7
        '
        'koniec
        '
        Me.koniec.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.koniec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.koniec.Location = New System.Drawing.Point(493, 5)
        Me.koniec.Name = "koniec"
        Me.koniec.Size = New System.Drawing.Size(97, 23)
        Me.koniec.TabIndex = 8
        Me.koniec.Text = "Zavrieť podkartu"
        Me.koniec.UseVisualStyleBackColor = False
        '
        'pridajButton
        '
        Me.pridajButton.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.pridajButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pridajButton.Location = New System.Drawing.Point(250, 5)
        Me.pridajButton.Name = "pridajButton"
        Me.pridajButton.Size = New System.Drawing.Size(75, 23)
        Me.pridajButton.TabIndex = 9
        Me.pridajButton.Text = "Pridať"
        Me.pridajButton.UseVisualStyleBackColor = False
        '
        'ulozButton
        '
        Me.ulozButton.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ulozButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ulozButton.Location = New System.Drawing.Point(412, 5)
        Me.ulozButton.Name = "ulozButton"
        Me.ulozButton.Size = New System.Drawing.Size(75, 23)
        Me.ulozButton.TabIndex = 10
        Me.ulozButton.Text = "Uložiť"
        Me.ulozButton.UseVisualStyleBackColor = False
        Me.ulozButton.Visible = False
        '
        'zmazButton
        '
        Me.zmazButton.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.zmazButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zmazButton.Location = New System.Drawing.Point(331, 5)
        Me.zmazButton.Name = "zmazButton"
        Me.zmazButton.Size = New System.Drawing.Size(75, 23)
        Me.zmazButton.TabIndex = 11
        Me.zmazButton.Text = "Zmazať"
        Me.zmazButton.UseVisualStyleBackColor = False
        '
        'narodnost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(779, 437)
        Me.Controls.Add(Me.zmazButton)
        Me.Controls.Add(Me.ulozButton)
        Me.Controls.Add(Me.pridajButton)
        Me.Controls.Add(Me.koniec)
        Me.Controls.Add(SkratkaLabel)
        Me.Controls.Add(Me.SkratkaTextBox)
        Me.Controls.Add(NazovLabel)
        Me.Controls.Add(Me.NazovTextBox)
        Me.Controls.Add(Me.NarodnostDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "narodnost"
        Me.Text = "narodnost"
        CType(Me.NarodnostDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NarodnostDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SkratkaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents koniec As System.Windows.Forms.Button
    Friend WithEvents pridajButton As System.Windows.Forms.Button
    Friend WithEvents ulozButton As System.Windows.Forms.Button
    Friend WithEvents zmazButton As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
