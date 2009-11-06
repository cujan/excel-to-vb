<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class typ_ubytovania
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
        Me.Typ_ubytovaniaDataSet = New internat.typ_ubytovaniaDataSet
        Me.Typ_ubytovaniaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Typ_ubytovaniaTableAdapter = New internat.typ_ubytovaniaDataSetTableAdapters.typ_ubytovaniaTableAdapter
        Me.TableAdapterManager = New internat.typ_ubytovaniaDataSetTableAdapters.TableAdapterManager
        Me.Typ_ubytovaniaDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vlozButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.typ_ubytovaniaTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.Typ_ubytovaniaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Typ_ubytovaniaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Typ_ubytovaniaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Typ_ubytovaniaDataSet
        '
        Me.Typ_ubytovaniaDataSet.DataSetName = "typ_ubytovaniaDataSet"
        Me.Typ_ubytovaniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Typ_ubytovaniaBindingSource
        '
        Me.Typ_ubytovaniaBindingSource.DataMember = "typ_ubytovania"
        Me.Typ_ubytovaniaBindingSource.DataSource = Me.Typ_ubytovaniaDataSet
        '
        'Typ_ubytovaniaTableAdapter
        '
        Me.Typ_ubytovaniaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.typ_ubytovaniaTableAdapter = Me.Typ_ubytovaniaTableAdapter
        Me.TableAdapterManager.UpdateOrder = internat.typ_ubytovaniaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Typ_ubytovaniaDataGridView
        '
        Me.Typ_ubytovaniaDataGridView.AutoGenerateColumns = False
        Me.Typ_ubytovaniaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Typ_ubytovaniaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Typ_ubytovaniaDataGridView.DataSource = Me.Typ_ubytovaniaBindingSource
        Me.Typ_ubytovaniaDataGridView.Location = New System.Drawing.Point(173, 101)
        Me.Typ_ubytovaniaDataGridView.Name = "Typ_ubytovaniaDataGridView"
        Me.Typ_ubytovaniaDataGridView.Size = New System.Drawing.Size(243, 152)
        Me.Typ_ubytovaniaDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "typ_ubytovania"
        Me.DataGridViewTextBoxColumn2.HeaderText = "typ_ubytovania"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'vlozButton
        '
        Me.vlozButton.BackColor = System.Drawing.Color.CornflowerBlue
        Me.vlozButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vlozButton.Location = New System.Drawing.Point(200, 9)
        Me.vlozButton.Name = "vlozButton"
        Me.vlozButton.Size = New System.Drawing.Size(75, 23)
        Me.vlozButton.TabIndex = 2
        Me.vlozButton.Text = "Vložiť"
        Me.vlozButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Typ ubytovania"
        '
        'typ_ubytovaniaTextBox
        '
        Me.typ_ubytovaniaTextBox.Location = New System.Drawing.Point(281, 53)
        Me.typ_ubytovaniaTextBox.Name = "typ_ubytovaniaTextBox"
        Me.typ_ubytovaniaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.typ_ubytovaniaTextBox.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(281, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Zavrieť podkartu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'typ_ubytovania
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(529, 415)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.typ_ubytovaniaTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vlozButton)
        Me.Controls.Add(Me.Typ_ubytovaniaDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "typ_ubytovania"
        Me.Text = "typ_ubytovania"
        CType(Me.Typ_ubytovaniaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Typ_ubytovaniaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Typ_ubytovaniaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Typ_ubytovaniaDataSet As internat.typ_ubytovaniaDataSet
    Friend WithEvents Typ_ubytovaniaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Typ_ubytovaniaTableAdapter As internat.typ_ubytovaniaDataSetTableAdapters.typ_ubytovaniaTableAdapter
    Friend WithEvents TableAdapterManager As internat.typ_ubytovaniaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Typ_ubytovaniaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vlozButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents typ_ubytovaniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
