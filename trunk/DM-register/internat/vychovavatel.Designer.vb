<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vychovavatel
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
        Me.VychovavatelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VychovavatelDataSet = New internat.vychovavatelDataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.menoTextBox = New System.Windows.Forms.TextBox
        Me.priezviskoTextBox = New System.Windows.Forms.TextBox
        Me.poznamkaTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.VychovavatelTableAdapter = New internat.vychovavatelDataSetTableAdapters.vychovavatelTableAdapter
        Me.TableAdapterManager = New internat.vychovavatelDataSetTableAdapters.TableAdapterManager
        Me.Button1 = New System.Windows.Forms.Button
        Me.titul_predComboBox = New System.Windows.Forms.ComboBox
        Me.TitulpredBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Titul_predDataSet = New internat.titul_predDataSet
        Me.Titul_predTableAdapter = New internat.titul_predDataSetTableAdapters.titul_predTableAdapter
        Me.VychovavatelDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.zavriet_podkartu = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.VychovavatelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VychovavatelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitulpredBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Titul_predDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VychovavatelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VychovavatelBindingSource
        '
        Me.VychovavatelBindingSource.DataMember = "vychovavatel"
        Me.VychovavatelBindingSource.DataSource = Me.VychovavatelDataSet
        '
        'VychovavatelDataSet
        '
        Me.VychovavatelDataSet.DataSetName = "vychovavatelDataSet"
        Me.VychovavatelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Meno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Priezvisko"
        '
        'menoTextBox
        '
        Me.menoTextBox.Location = New System.Drawing.Point(234, 78)
        Me.menoTextBox.Name = "menoTextBox"
        Me.menoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.menoTextBox.TabIndex = 4
        '
        'priezviskoTextBox
        '
        Me.priezviskoTextBox.Location = New System.Drawing.Point(234, 102)
        Me.priezviskoTextBox.Name = "priezviskoTextBox"
        Me.priezviskoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.priezviskoTextBox.TabIndex = 5
        '
        'poznamkaTextBox
        '
        Me.poznamkaTextBox.Location = New System.Drawing.Point(425, 54)
        Me.poznamkaTextBox.Multiline = True
        Me.poznamkaTextBox.Name = "poznamkaTextBox"
        Me.poznamkaTextBox.Size = New System.Drawing.Size(208, 68)
        Me.poznamkaTextBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(362, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Poznámka"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(201, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Titul"
        '
        'VychovavatelTableAdapter
        '
        Me.VychovavatelTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.titul_predTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = internat.vychovavatelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(234, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Vložiť"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'titul_predComboBox
        '
        Me.titul_predComboBox.DataSource = Me.TitulpredBindingSource
        Me.titul_predComboBox.DisplayMember = "skratka"
        Me.titul_predComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.titul_predComboBox.FormattingEnabled = True
        Me.titul_predComboBox.Location = New System.Drawing.Point(234, 51)
        Me.titul_predComboBox.Name = "titul_predComboBox"
        Me.titul_predComboBox.Size = New System.Drawing.Size(100, 21)
        Me.titul_predComboBox.TabIndex = 11
        Me.titul_predComboBox.ValueMember = "id"
        '
        'TitulpredBindingSource
        '
        Me.TitulpredBindingSource.DataMember = "titul_pred"
        Me.TitulpredBindingSource.DataSource = Me.Titul_predDataSet
        '
        'Titul_predDataSet
        '
        Me.Titul_predDataSet.DataSetName = "titul_predDataSet"
        Me.Titul_predDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Titul_predTableAdapter
        '
        Me.Titul_predTableAdapter.ClearBeforeFill = True
        '
        'VychovavatelDataGridView
        '
        Me.VychovavatelDataGridView.AutoGenerateColumns = False
        Me.VychovavatelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VychovavatelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.VychovavatelDataGridView.DataSource = Me.VychovavatelBindingSource
        Me.VychovavatelDataGridView.Location = New System.Drawing.Point(120, 147)
        Me.VychovavatelDataGridView.Name = "VychovavatelDataGridView"
        Me.VychovavatelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VychovavatelDataGridView.Size = New System.Drawing.Size(646, 250)
        Me.VychovavatelDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "titul1"
        Me.DataGridViewTextBoxColumn6.HeaderText = "titul1"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "skratka"
        Me.DataGridViewTextBoxColumn7.HeaderText = "skratka"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "priezvisko"
        Me.DataGridViewTextBoxColumn2.HeaderText = "priezvisko"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "meno"
        Me.DataGridViewTextBoxColumn3.HeaderText = "meno"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "poznamka"
        Me.DataGridViewTextBoxColumn4.HeaderText = "poznamka"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'zavriet_podkartu
        '
        Me.zavriet_podkartu.BackColor = System.Drawing.Color.CornflowerBlue
        Me.zavriet_podkartu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zavriet_podkartu.Location = New System.Drawing.Point(396, 12)
        Me.zavriet_podkartu.Name = "zavriet_podkartu"
        Me.zavriet_podkartu.Size = New System.Drawing.Size(98, 23)
        Me.zavriet_podkartu.TabIndex = 12
        Me.zavriet_podkartu.Text = "Zavrieť podkartu"
        Me.zavriet_podkartu.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(315, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Zmazať"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'vychovavatel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(796, 475)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.zavriet_podkartu)
        Me.Controls.Add(Me.VychovavatelDataGridView)
        Me.Controls.Add(Me.titul_predComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.poznamkaTextBox)
        Me.Controls.Add(Me.priezviskoTextBox)
        Me.Controls.Add(Me.menoTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "vychovavatel"
        Me.Text = "vychovavatel"
        CType(Me.VychovavatelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VychovavatelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitulpredBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Titul_predDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VychovavatelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VychovavatelDataSet As internat.vychovavatelDataSet
    Friend WithEvents VychovavatelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VychovavatelTableAdapter As internat.vychovavatelDataSetTableAdapters.vychovavatelTableAdapter
    Friend WithEvents TableAdapterManager As internat.vychovavatelDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents menoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents priezviskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents poznamkaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents titul_predComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Titul_predDataSet As internat.titul_predDataSet
    Friend WithEvents TitulpredBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Titul_predTableAdapter As internat.titul_predDataSetTableAdapters.titul_predTableAdapter
    Friend WithEvents VychovavatelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents zavriet_podkartu As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
