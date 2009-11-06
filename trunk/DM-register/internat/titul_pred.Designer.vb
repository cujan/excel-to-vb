<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class titul_pred
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
        Me.Titul_predDataSet = New internat.titul_predDataSet
        Me.Titul_predBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Titul_predTableAdapter = New internat.titul_predDataSetTableAdapters.titul_predTableAdapter
        Me.TableAdapterManager = New internat.titul_predDataSetTableAdapters.TableAdapterManager
        Me.Titul_predDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.skratkaTextBox = New System.Windows.Forms.TextBox
        Me.nazovTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.zavriet_podkartu = New System.Windows.Forms.Button
        CType(Me.Titul_predDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Titul_predBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Titul_predDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Titul_predDataSet
        '
        Me.Titul_predDataSet.DataSetName = "titul_predDataSet"
        Me.Titul_predDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Titul_predBindingSource
        '
        Me.Titul_predBindingSource.DataMember = "titul_pred"
        Me.Titul_predBindingSource.DataSource = Me.Titul_predDataSet
        '
        'Titul_predTableAdapter
        '
        Me.Titul_predTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.titul_predTableAdapter = Me.Titul_predTableAdapter
        Me.TableAdapterManager.UpdateOrder = internat.titul_predDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Titul_predDataGridView
        '
        Me.Titul_predDataGridView.AutoGenerateColumns = False
        Me.Titul_predDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Titul_predDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Titul_predDataGridView.DataSource = Me.Titul_predBindingSource
        Me.Titul_predDataGridView.Location = New System.Drawing.Point(157, 129)
        Me.Titul_predDataGridView.Name = "Titul_predDataGridView"
        Me.Titul_predDataGridView.Size = New System.Drawing.Size(346, 220)
        Me.Titul_predDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "skratka"
        Me.DataGridViewTextBoxColumn2.HeaderText = "skratka"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nazov"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nazov"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Skratka"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Názov"
        '
        'skratkaTextBox
        '
        Me.skratkaTextBox.Location = New System.Drawing.Point(285, 58)
        Me.skratkaTextBox.Name = "skratkaTextBox"
        Me.skratkaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.skratkaTextBox.TabIndex = 4
        '
        'nazovTextBox
        '
        Me.nazovTextBox.Location = New System.Drawing.Point(285, 84)
        Me.nazovTextBox.Name = "nazovTextBox"
        Me.nazovTextBox.Size = New System.Drawing.Size(100, 20)
        Me.nazovTextBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(204, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Vložiť"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'zavriet_podkartu
        '
        Me.zavriet_podkartu.BackColor = System.Drawing.Color.CornflowerBlue
        Me.zavriet_podkartu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zavriet_podkartu.Location = New System.Drawing.Point(285, 12)
        Me.zavriet_podkartu.Name = "zavriet_podkartu"
        Me.zavriet_podkartu.Size = New System.Drawing.Size(97, 23)
        Me.zavriet_podkartu.TabIndex = 7
        Me.zavriet_podkartu.Text = "Zavrieť podkartu"
        Me.zavriet_podkartu.UseVisualStyleBackColor = False
        '
        'titul_pred
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(803, 457)
        Me.Controls.Add(Me.zavriet_podkartu)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nazovTextBox)
        Me.Controls.Add(Me.skratkaTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Titul_predDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "titul_pred"
        Me.Text = "titul_pred"
        CType(Me.Titul_predDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Titul_predBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Titul_predDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Titul_predDataSet As internat.titul_predDataSet
    Friend WithEvents Titul_predBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Titul_predTableAdapter As internat.titul_predDataSetTableAdapters.titul_predTableAdapter
    Friend WithEvents TableAdapterManager As internat.titul_predDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Titul_predDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents skratkaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents nazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents zavriet_podkartu As System.Windows.Forms.Button
End Class
