<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hlavny_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hlavny_form))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.zavriet = New System.Windows.Forms.Button
        Me.instaluj = New System.Windows.Forms.Button
        Me.hotovo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 53)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Čakajte prosím, kotrolujem či máte nainštalované potrebné programy"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(286, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "microsoft"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(352, 61)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'zavriet
        '
        Me.zavriet.Location = New System.Drawing.Point(232, 94)
        Me.zavriet.Name = "zavriet"
        Me.zavriet.Size = New System.Drawing.Size(120, 25)
        Me.zavriet.TabIndex = 5
        Me.zavriet.Text = "Zavrieť"
        Me.zavriet.UseVisualStyleBackColor = True
        Me.zavriet.Visible = False
        '
        'instaluj
        '
        Me.instaluj.Location = New System.Drawing.Point(106, 94)
        Me.instaluj.Name = "instaluj"
        Me.instaluj.Size = New System.Drawing.Size(120, 25)
        Me.instaluj.TabIndex = 4
        Me.instaluj.Text = "Inštaluj"
        Me.instaluj.UseVisualStyleBackColor = True
        Me.instaluj.Visible = False
        '
        'hotovo
        '
        Me.hotovo.Location = New System.Drawing.Point(106, 77)
        Me.hotovo.Name = "hotovo"
        Me.hotovo.Size = New System.Drawing.Size(272, 23)
        Me.hotovo.TabIndex = 8
        Me.hotovo.Text = "Hotovo"
        Me.hotovo.UseVisualStyleBackColor = True
        Me.hotovo.Visible = False
        '
        'hlavny_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 149)
        Me.Controls.Add(Me.hotovo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.zavriet)
        Me.Controls.Add(Me.instaluj)
        Me.Controls.Add(Me.Label1)
        Me.Name = "hlavny_form"
        Me.Text = "Kontrola závislostí"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents zavriet As System.Windows.Forms.Button
    Friend WithEvents instaluj As System.Windows.Forms.Button
    Friend WithEvents hotovo As System.Windows.Forms.Button

End Class
