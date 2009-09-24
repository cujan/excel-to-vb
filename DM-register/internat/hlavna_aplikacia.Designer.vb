<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hlavna_aplikacia
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
        Me.components = New System.ComponentModel.Container
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.hlavny_splitter = New System.Windows.Forms.SplitContainer
        Me.nastavenia_splitter = New System.Windows.Forms.SplitContainer
        Me.nastavenia_button = New System.Windows.Forms.Button
        Me.nastavenia_label = New System.Windows.Forms.Label
        Me.ciselniky_button = New System.Windows.Forms.Button
        Me.tl_zostavy_splitter = New System.Windows.Forms.SplitContainer
        Me.tl_zostavy_button = New System.Windows.Forms.Button
        Me.tl_zostavy_label = New System.Windows.Forms.Label
        Me.prehlad_ubytovanych_splitter = New System.Windows.Forms.SplitContainer
        Me.sprava_ubytovanych_button = New System.Windows.Forms.Button
        Me.prehlad_ubytovanych_label = New System.Windows.Forms.Label
        Me.novy_student_button = New System.Windows.Forms.Button
        Me.evidencia_studentov_button = New System.Windows.Forms.Button
        Me.StatusStrip.SuspendLayout()
        Me.hlavny_splitter.Panel1.SuspendLayout()
        Me.hlavny_splitter.SuspendLayout()
        Me.nastavenia_splitter.Panel1.SuspendLayout()
        Me.nastavenia_splitter.Panel2.SuspendLayout()
        Me.nastavenia_splitter.SuspendLayout()
        Me.tl_zostavy_splitter.Panel1.SuspendLayout()
        Me.tl_zostavy_splitter.SuspendLayout()
        Me.prehlad_ubytovanych_splitter.Panel1.SuspendLayout()
        Me.prehlad_ubytovanych_splitter.Panel2.SuspendLayout()
        Me.prehlad_ubytovanych_splitter.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 497)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(790, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(37, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'hlavny_splitter
        '
        Me.hlavny_splitter.BackColor = System.Drawing.Color.RoyalBlue
        Me.hlavny_splitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hlavny_splitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.hlavny_splitter.IsSplitterFixed = True
        Me.hlavny_splitter.Location = New System.Drawing.Point(0, 0)
        Me.hlavny_splitter.Name = "hlavny_splitter"
        '
        'hlavny_splitter.Panel1
        '
        Me.hlavny_splitter.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.hlavny_splitter.Panel1.Controls.Add(Me.nastavenia_splitter)
        Me.hlavny_splitter.Panel1.Controls.Add(Me.tl_zostavy_splitter)
        Me.hlavny_splitter.Panel1.Controls.Add(Me.prehlad_ubytovanych_splitter)
        '
        'hlavny_splitter.Panel2
        '
        Me.hlavny_splitter.Panel2.AutoScroll = True
        Me.hlavny_splitter.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.hlavny_splitter.Size = New System.Drawing.Size(790, 497)
        Me.hlavny_splitter.SplitterDistance = 160
        Me.hlavny_splitter.SplitterWidth = 1
        Me.hlavny_splitter.TabIndex = 9
        '
        'nastavenia_splitter
        '
        Me.nastavenia_splitter.BackColor = System.Drawing.Color.LightSteelBlue
        Me.nastavenia_splitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.nastavenia_splitter.Location = New System.Drawing.Point(8, 86)
        Me.nastavenia_splitter.Name = "nastavenia_splitter"
        Me.nastavenia_splitter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'nastavenia_splitter.Panel1
        '
        Me.nastavenia_splitter.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.nastavenia_splitter.Panel1.Controls.Add(Me.nastavenia_button)
        Me.nastavenia_splitter.Panel1.Controls.Add(Me.nastavenia_label)
        '
        'nastavenia_splitter.Panel2
        '
        Me.nastavenia_splitter.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.nastavenia_splitter.Panel2.Controls.Add(Me.ciselniky_button)
        Me.nastavenia_splitter.Panel2Collapsed = True
        Me.nastavenia_splitter.Size = New System.Drawing.Size(140, 100)
        Me.nastavenia_splitter.SplitterDistance = 25
        Me.nastavenia_splitter.SplitterWidth = 1
        Me.nastavenia_splitter.TabIndex = 0
        '
        'nastavenia_button
        '
        Me.nastavenia_button.BackColor = System.Drawing.Color.CornflowerBlue
        Me.nastavenia_button.FlatAppearance.BorderSize = 0
        Me.nastavenia_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nastavenia_button.Location = New System.Drawing.Point(125, 1)
        Me.nastavenia_button.Margin = New System.Windows.Forms.Padding(0)
        Me.nastavenia_button.Name = "nastavenia_button"
        Me.nastavenia_button.Size = New System.Drawing.Size(14, 22)
        Me.nastavenia_button.TabIndex = 1
        Me.nastavenia_button.Text = "v"
        Me.nastavenia_button.UseVisualStyleBackColor = False
        '
        'nastavenia_label
        '
        Me.nastavenia_label.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.nastavenia_label.BackColor = System.Drawing.Color.MediumBlue
        Me.nastavenia_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nastavenia_label.ForeColor = System.Drawing.Color.White
        Me.nastavenia_label.Location = New System.Drawing.Point(0, 0)
        Me.nastavenia_label.Name = "nastavenia_label"
        Me.nastavenia_label.Size = New System.Drawing.Size(140, 25)
        Me.nastavenia_label.TabIndex = 0
        Me.nastavenia_label.Text = "Nastavenia"
        Me.nastavenia_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ciselniky_button
        '
        Me.ciselniky_button.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ciselniky_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ciselniky_button.Location = New System.Drawing.Point(4, 6)
        Me.ciselniky_button.Name = "ciselniky_button"
        Me.ciselniky_button.Size = New System.Drawing.Size(132, 23)
        Me.ciselniky_button.TabIndex = 0
        Me.ciselniky_button.Text = "Číselníky"
        Me.ciselniky_button.UseVisualStyleBackColor = False
        '
        'tl_zostavy_splitter
        '
        Me.tl_zostavy_splitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.tl_zostavy_splitter.IsSplitterFixed = True
        Me.tl_zostavy_splitter.Location = New System.Drawing.Point(7, 49)
        Me.tl_zostavy_splitter.Name = "tl_zostavy_splitter"
        Me.tl_zostavy_splitter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'tl_zostavy_splitter.Panel1
        '
        Me.tl_zostavy_splitter.Panel1.Controls.Add(Me.tl_zostavy_button)
        Me.tl_zostavy_splitter.Panel1.Controls.Add(Me.tl_zostavy_label)
        '
        'tl_zostavy_splitter.Panel2
        '
        Me.tl_zostavy_splitter.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tl_zostavy_splitter.Panel2Collapsed = True
        Me.tl_zostavy_splitter.Size = New System.Drawing.Size(140, 100)
        Me.tl_zostavy_splitter.SplitterDistance = 25
        Me.tl_zostavy_splitter.SplitterWidth = 1
        Me.tl_zostavy_splitter.TabIndex = 1
        '
        'tl_zostavy_button
        '
        Me.tl_zostavy_button.BackColor = System.Drawing.Color.CornflowerBlue
        Me.tl_zostavy_button.FlatAppearance.BorderSize = 0
        Me.tl_zostavy_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tl_zostavy_button.Location = New System.Drawing.Point(124, 2)
        Me.tl_zostavy_button.Name = "tl_zostavy_button"
        Me.tl_zostavy_button.Size = New System.Drawing.Size(14, 22)
        Me.tl_zostavy_button.TabIndex = 1
        Me.tl_zostavy_button.Text = "v"
        Me.tl_zostavy_button.UseVisualStyleBackColor = False
        '
        'tl_zostavy_label
        '
        Me.tl_zostavy_label.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tl_zostavy_label.BackColor = System.Drawing.Color.MediumBlue
        Me.tl_zostavy_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tl_zostavy_label.ForeColor = System.Drawing.Color.White
        Me.tl_zostavy_label.Location = New System.Drawing.Point(-1, 0)
        Me.tl_zostavy_label.Name = "tl_zostavy_label"
        Me.tl_zostavy_label.Size = New System.Drawing.Size(140, 25)
        Me.tl_zostavy_label.TabIndex = 0
        Me.tl_zostavy_label.Text = "Tlačové zostavy"
        Me.tl_zostavy_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'prehlad_ubytovanych_splitter
        '
        Me.prehlad_ubytovanych_splitter.BackColor = System.Drawing.Color.LightSteelBlue
        Me.prehlad_ubytovanych_splitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.prehlad_ubytovanych_splitter.Location = New System.Drawing.Point(7, 12)
        Me.prehlad_ubytovanych_splitter.Name = "prehlad_ubytovanych_splitter"
        Me.prehlad_ubytovanych_splitter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'prehlad_ubytovanych_splitter.Panel1
        '
        Me.prehlad_ubytovanych_splitter.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.prehlad_ubytovanych_splitter.Panel1.Controls.Add(Me.sprava_ubytovanych_button)
        Me.prehlad_ubytovanych_splitter.Panel1.Controls.Add(Me.prehlad_ubytovanych_label)
        '
        'prehlad_ubytovanych_splitter.Panel2
        '
        Me.prehlad_ubytovanych_splitter.Panel2.Controls.Add(Me.evidencia_studentov_button)
        Me.prehlad_ubytovanych_splitter.Panel2.Controls.Add(Me.novy_student_button)
        Me.prehlad_ubytovanych_splitter.Panel2Collapsed = True
        Me.prehlad_ubytovanych_splitter.Size = New System.Drawing.Size(140, 113)
        Me.prehlad_ubytovanych_splitter.SplitterDistance = 25
        Me.prehlad_ubytovanych_splitter.SplitterWidth = 1
        Me.prehlad_ubytovanych_splitter.TabIndex = 2
        '
        'sprava_ubytovanych_button
        '
        Me.sprava_ubytovanych_button.BackColor = System.Drawing.Color.CornflowerBlue
        Me.sprava_ubytovanych_button.FlatAppearance.BorderSize = 0
        Me.sprava_ubytovanych_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sprava_ubytovanych_button.Location = New System.Drawing.Point(124, 1)
        Me.sprava_ubytovanych_button.Name = "sprava_ubytovanych_button"
        Me.sprava_ubytovanych_button.Size = New System.Drawing.Size(14, 22)
        Me.sprava_ubytovanych_button.TabIndex = 2
        Me.sprava_ubytovanych_button.Text = "v"
        Me.sprava_ubytovanych_button.UseVisualStyleBackColor = False
        '
        'prehlad_ubytovanych_label
        '
        Me.prehlad_ubytovanych_label.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.prehlad_ubytovanych_label.BackColor = System.Drawing.Color.MediumBlue
        Me.prehlad_ubytovanych_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prehlad_ubytovanych_label.ForeColor = System.Drawing.Color.White
        Me.prehlad_ubytovanych_label.Location = New System.Drawing.Point(0, 0)
        Me.prehlad_ubytovanych_label.Name = "prehlad_ubytovanych_label"
        Me.prehlad_ubytovanych_label.Size = New System.Drawing.Size(139, 25)
        Me.prehlad_ubytovanych_label.TabIndex = 0
        Me.prehlad_ubytovanych_label.Text = "Správa ubytovaných"
        Me.prehlad_ubytovanych_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'novy_student_button
        '
        Me.novy_student_button.BackColor = System.Drawing.Color.CornflowerBlue
        Me.novy_student_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.novy_student_button.Location = New System.Drawing.Point(5, 7)
        Me.novy_student_button.Name = "novy_student_button"
        Me.novy_student_button.Size = New System.Drawing.Size(132, 23)
        Me.novy_student_button.TabIndex = 0
        Me.novy_student_button.Text = "Nový študent"
        Me.novy_student_button.UseVisualStyleBackColor = False
        '
        'evidencia_studentov_button
        '
        Me.evidencia_studentov_button.BackColor = System.Drawing.Color.CornflowerBlue
        Me.evidencia_studentov_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.evidencia_studentov_button.Location = New System.Drawing.Point(5, 32)
        Me.evidencia_studentov_button.Name = "evidencia_studentov_button"
        Me.evidencia_studentov_button.Size = New System.Drawing.Size(132, 23)
        Me.evidencia_studentov_button.TabIndex = 1
        Me.evidencia_studentov_button.Text = "Evidencia študentov"
        Me.evidencia_studentov_button.UseVisualStyleBackColor = False
        '
        'hlavna_aplikacia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(790, 519)
        Me.Controls.Add(Me.hlavny_splitter)
        Me.Controls.Add(Me.StatusStrip)
        Me.Name = "hlavna_aplikacia"
        Me.Text = "Register ubytovaných"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.hlavny_splitter.Panel1.ResumeLayout(False)
        Me.hlavny_splitter.ResumeLayout(False)
        Me.nastavenia_splitter.Panel1.ResumeLayout(False)
        Me.nastavenia_splitter.Panel2.ResumeLayout(False)
        Me.nastavenia_splitter.ResumeLayout(False)
        Me.tl_zostavy_splitter.Panel1.ResumeLayout(False)
        Me.tl_zostavy_splitter.ResumeLayout(False)
        Me.prehlad_ubytovanych_splitter.Panel1.ResumeLayout(False)
        Me.prehlad_ubytovanych_splitter.Panel2.ResumeLayout(False)
        Me.prehlad_ubytovanych_splitter.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents hlavny_splitter As System.Windows.Forms.SplitContainer
    Friend WithEvents nastavenia_splitter As System.Windows.Forms.SplitContainer
    Friend WithEvents nastavenia_button As System.Windows.Forms.Button
    Friend WithEvents nastavenia_label As System.Windows.Forms.Label
    Friend WithEvents tl_zostavy_splitter As System.Windows.Forms.SplitContainer
    Friend WithEvents tl_zostavy_label As System.Windows.Forms.Label
    Friend WithEvents tl_zostavy_button As System.Windows.Forms.Button
    Friend WithEvents prehlad_ubytovanych_splitter As System.Windows.Forms.SplitContainer
    Friend WithEvents prehlad_ubytovanych_label As System.Windows.Forms.Label
    Friend WithEvents sprava_ubytovanych_button As System.Windows.Forms.Button
    Friend WithEvents ciselniky_button As System.Windows.Forms.Button
    Friend WithEvents novy_student_button As System.Windows.Forms.Button
    Friend WithEvents evidencia_studentov_button As System.Windows.Forms.Button

End Class
