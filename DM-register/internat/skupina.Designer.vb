<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class skupina
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.nazovTextBox = New System.Windows.Forms.TextBox
        Me.vychovavatelComboBox1 = New System.Windows.Forms.ComboBox
        Me.VychovavatelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VychovavatelDataSet = New internat.vychovavatelDataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Skupina_vychovavatelDataSet1 = New internat.skupina_vychovavatelDataSet1
        Me.SkupinaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkupinaTableAdapter = New internat.skupina_vychovavatelDataSet1TableAdapters.skupinaTableAdapter
        Me.TableAdapterManager = New internat.skupina_vychovavatelDataSet1TableAdapters.TableAdapterManager
        Me.SkupinaDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.priezvisko = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VychovavatelTableAdapter = New internat.vychovavatelDataSetTableAdapters.vychovavatelTableAdapter
        Me.zavriet_podkartu = New System.Windows.Forms.Button
        CType(Me.VychovavatelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VychovavatelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Skupina_vychovavatelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkupinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkupinaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(225, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Vložiť"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'nazovTextBox
        '
        Me.nazovTextBox.Location = New System.Drawing.Point(306, 45)
        Me.nazovTextBox.Name = "nazovTextBox"
        Me.nazovTextBox.Size = New System.Drawing.Size(100, 20)
        Me.nazovTextBox.TabIndex = 3
        '
        'vychovavatelComboBox1
        '
        Me.vychovavatelComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VychovavatelBindingSource, "id", True))
        Me.vychovavatelComboBox1.DataSource = Me.VychovavatelBindingSource
        Me.vychovavatelComboBox1.DisplayMember = "priezvisko"
        Me.vychovavatelComboBox1.FormattingEnabled = True
        Me.vychovavatelComboBox1.Location = New System.Drawing.Point(306, 71)
        Me.vychovavatelComboBox1.Name = "vychovavatelComboBox1"
        Me.vychovavatelComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.vychovavatelComboBox1.TabIndex = 4
        Me.vychovavatelComboBox1.ValueMember = "id"
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
        Me.Label1.Location = New System.Drawing.Point(223, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nazov skupiny"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Vedúci skupiny"
        '
        'Skupina_vychovavatelDataSet1
        '
        Me.Skupina_vychovavatelDataSet1.DataSetName = "skupina_vychovavatelDataSet1"
        Me.Skupina_vychovavatelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SkupinaBindingSource
        '
        Me.SkupinaBindingSource.DataMember = "skupina"
        Me.SkupinaBindingSource.DataSource = Me.Skupina_vychovavatelDataSet1
        '
        'SkupinaTableAdapter
        '
        Me.SkupinaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = internat.skupina_vychovavatelDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vychovavatelTableAdapter = Nothing
        '
        'SkupinaDataGridView
        '
        Me.SkupinaDataGridView.AutoGenerateColumns = False
        Me.SkupinaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SkupinaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.priezvisko})
        Me.SkupinaDataGridView.DataSource = Me.SkupinaBindingSource
        Me.SkupinaDataGridView.Location = New System.Drawing.Point(193, 124)
        Me.SkupinaDataGridView.Name = "SkupinaDataGridView"
        Me.SkupinaDataGridView.Size = New System.Drawing.Size(444, 220)
        Me.SkupinaDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nazov_skupiny"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nazov_skupiny"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id_vychovavatel"
        Me.DataGridViewTextBoxColumn3.HeaderText = "id_vychovavatel"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'priezvisko
        '
        Me.priezvisko.DataPropertyName = "priezvisko"
        Me.priezvisko.HeaderText = "priezvisko"
        Me.priezvisko.Name = "priezvisko"
        Me.priezvisko.ReadOnly = True
        '
        'VychovavatelTableAdapter
        '
        Me.VychovavatelTableAdapter.ClearBeforeFill = True
        '
        'zavriet_podkartu
        '
        Me.zavriet_podkartu.BackColor = System.Drawing.Color.CornflowerBlue
        Me.zavriet_podkartu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zavriet_podkartu.Location = New System.Drawing.Point(306, 9)
        Me.zavriet_podkartu.Name = "zavriet_podkartu"
        Me.zavriet_podkartu.Size = New System.Drawing.Size(109, 23)
        Me.zavriet_podkartu.TabIndex = 8
        Me.zavriet_podkartu.Text = "Zavrieť podkartu"
        Me.zavriet_podkartu.UseVisualStyleBackColor = False
        '
        'skupina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(774, 420)
        Me.Controls.Add(Me.zavriet_podkartu)
        Me.Controls.Add(Me.SkupinaDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vychovavatelComboBox1)
        Me.Controls.Add(Me.nazovTextBox)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "skupina"
        Me.Text = "skupina"
        CType(Me.VychovavatelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VychovavatelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Skupina_vychovavatelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkupinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkupinaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents nazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents vychovavatelComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Skupina_vychovavatelDataSet1 As internat.skupina_vychovavatelDataSet1
    Friend WithEvents SkupinaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SkupinaTableAdapter As internat.skupina_vychovavatelDataSet1TableAdapters.skupinaTableAdapter
    Friend WithEvents TableAdapterManager As internat.skupina_vychovavatelDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents SkupinaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VychovavatelDataSet As internat.vychovavatelDataSet
    Friend WithEvents VychovavatelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VychovavatelTableAdapter As internat.vychovavatelDataSetTableAdapters.vychovavatelTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents priezvisko As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents zavriet_podkartu As System.Windows.Forms.Button
End Class
