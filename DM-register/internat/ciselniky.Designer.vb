<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ciselniky
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
        Me.ciselniky_splitter = New System.Windows.Forms.SplitContainer
        Me.typ_ubytovania_button = New System.Windows.Forms.Button
        Me.zavriet_kartu = New System.Windows.Forms.Button
        Me.titul_pred_button = New System.Windows.Forms.Button
        Me.skupiny = New System.Windows.Forms.Button
        Me.vychovavatelia = New System.Windows.Forms.Button
        Me.typ_izby_button = New System.Windows.Forms.Button
        Me.ciselniky_splitter.Panel1.SuspendLayout()
        Me.ciselniky_splitter.SuspendLayout()
        Me.SuspendLayout()
        '
        'ciselniky_splitter
        '
        Me.ciselniky_splitter.BackColor = System.Drawing.Color.Lavender
        Me.ciselniky_splitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ciselniky_splitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.ciselniky_splitter.IsSplitterFixed = True
        Me.ciselniky_splitter.Location = New System.Drawing.Point(0, 0)
        Me.ciselniky_splitter.Name = "ciselniky_splitter"
        Me.ciselniky_splitter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'ciselniky_splitter.Panel1
        '
        Me.ciselniky_splitter.Panel1.Controls.Add(Me.typ_izby_button)
        Me.ciselniky_splitter.Panel1.Controls.Add(Me.typ_ubytovania_button)
        Me.ciselniky_splitter.Panel1.Controls.Add(Me.zavriet_kartu)
        Me.ciselniky_splitter.Panel1.Controls.Add(Me.titul_pred_button)
        Me.ciselniky_splitter.Panel1.Controls.Add(Me.skupiny)
        Me.ciselniky_splitter.Panel1.Controls.Add(Me.vychovavatelia)
        Me.ciselniky_splitter.Size = New System.Drawing.Size(744, 372)
        Me.ciselniky_splitter.SplitterDistance = 76
        Me.ciselniky_splitter.SplitterWidth = 1
        Me.ciselniky_splitter.TabIndex = 0
        '
        'typ_ubytovania_button
        '
        Me.typ_ubytovania_button.BackColor = System.Drawing.Color.CornflowerBlue
        Me.typ_ubytovania_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.typ_ubytovania_button.Location = New System.Drawing.Point(391, 30)
        Me.typ_ubytovania_button.Name = "typ_ubytovania_button"
        Me.typ_ubytovania_button.Size = New System.Drawing.Size(90, 23)
        Me.typ_ubytovania_button.TabIndex = 4
        Me.typ_ubytovania_button.Text = "Typ ubytovania"
        Me.typ_ubytovania_button.UseVisualStyleBackColor = False
        '
        'zavriet_kartu
        '
        Me.zavriet_kartu.BackColor = System.Drawing.Color.CornflowerBlue
        Me.zavriet_kartu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zavriet_kartu.Location = New System.Drawing.Point(568, 30)
        Me.zavriet_kartu.Name = "zavriet_kartu"
        Me.zavriet_kartu.Size = New System.Drawing.Size(85, 23)
        Me.zavriet_kartu.TabIndex = 3
        Me.zavriet_kartu.Text = "Zavrieť kartu"
        Me.zavriet_kartu.UseVisualStyleBackColor = False
        '
        'titul_pred_button
        '
        Me.titul_pred_button.BackColor = System.Drawing.Color.CornflowerBlue
        Me.titul_pred_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.titul_pred_button.Location = New System.Drawing.Point(310, 30)
        Me.titul_pred_button.Name = "titul_pred_button"
        Me.titul_pred_button.Size = New System.Drawing.Size(75, 23)
        Me.titul_pred_button.TabIndex = 2
        Me.titul_pred_button.Text = "Titul pred"
        Me.titul_pred_button.UseVisualStyleBackColor = False
        '
        'skupiny
        '
        Me.skupiny.BackColor = System.Drawing.Color.CornflowerBlue
        Me.skupiny.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.skupiny.Location = New System.Drawing.Point(229, 30)
        Me.skupiny.Name = "skupiny"
        Me.skupiny.Size = New System.Drawing.Size(75, 23)
        Me.skupiny.TabIndex = 1
        Me.skupiny.Text = "Skupiny"
        Me.skupiny.UseVisualStyleBackColor = False
        '
        'vychovavatelia
        '
        Me.vychovavatelia.BackColor = System.Drawing.Color.CornflowerBlue
        Me.vychovavatelia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vychovavatelia.Location = New System.Drawing.Point(126, 30)
        Me.vychovavatelia.Name = "vychovavatelia"
        Me.vychovavatelia.Size = New System.Drawing.Size(97, 23)
        Me.vychovavatelia.TabIndex = 0
        Me.vychovavatelia.Text = "Vychovávatelia"
        Me.vychovavatelia.UseVisualStyleBackColor = False
        '
        'typ_izby_button
        '
        Me.typ_izby_button.BackColor = System.Drawing.Color.CornflowerBlue
        Me.typ_izby_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.typ_izby_button.Location = New System.Drawing.Point(487, 30)
        Me.typ_izby_button.Name = "typ_izby_button"
        Me.typ_izby_button.Size = New System.Drawing.Size(75, 23)
        Me.typ_izby_button.TabIndex = 5
        Me.typ_izby_button.Text = "Typ izby"
        Me.typ_izby_button.UseVisualStyleBackColor = False
        '
        'ciselniky
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 372)
        Me.Controls.Add(Me.ciselniky_splitter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ciselniky"
        Me.Text = "Číselníky"
        Me.ciselniky_splitter.Panel1.ResumeLayout(False)
        Me.ciselniky_splitter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ciselniky_splitter As System.Windows.Forms.SplitContainer
    Friend WithEvents titul_pred_button As System.Windows.Forms.Button
    Friend WithEvents skupiny As System.Windows.Forms.Button
    Friend WithEvents vychovavatelia As System.Windows.Forms.Button
    Friend WithEvents zavriet_kartu As System.Windows.Forms.Button
    Friend WithEvents typ_ubytovania_button As System.Windows.Forms.Button
    Friend WithEvents typ_izby_button As System.Windows.Forms.Button
End Class
