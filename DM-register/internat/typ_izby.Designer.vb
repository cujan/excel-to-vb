<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class typ_izby
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
        Me.Typ_izbyDataSet = New internat.typ_izbyDataSet
        Me.Typ_izbyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Typ_izbyTableAdapter = New internat.typ_izbyDataSetTableAdapters.typ_izbyTableAdapter
        Me.TableAdapterManager = New internat.typ_izbyDataSetTableAdapters.TableAdapterManager
        Me.Typ_izbyDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.typizbyTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.vlozButton = New System.Windows.Forms.Button
        Me.zatvor_button = New System.Windows.Forms.Button
        CType(Me.Typ_izbyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Typ_izbyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Typ_izbyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Typ_izbyDataSet
        '
        Me.Typ_izbyDataSet.DataSetName = "typ_izbyDataSet"
        Me.Typ_izbyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Typ_izbyBindingSource
        '
        Me.Typ_izbyBindingSource.DataMember = "typ_izby"
        Me.Typ_izbyBindingSource.DataSource = Me.Typ_izbyDataSet
        '
        'Typ_izbyTableAdapter
        '
        Me.Typ_izbyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.typ_izbyTableAdapter = Me.Typ_izbyTableAdapter
        Me.TableAdapterManager.UpdateOrder = internat.typ_izbyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Typ_izbyDataGridView
        '
        Me.Typ_izbyDataGridView.AutoGenerateColumns = False
        Me.Typ_izbyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Typ_izbyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Typ_izbyDataGridView.DataSource = Me.Typ_izbyBindingSource
        Me.Typ_izbyDataGridView.Location = New System.Drawing.Point(210, 92)
        Me.Typ_izbyDataGridView.Name = "Typ_izbyDataGridView"
        Me.Typ_izbyDataGridView.Size = New System.Drawing.Size(243, 137)
        Me.Typ_izbyDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "typ_izby"
        Me.DataGridViewTextBoxColumn2.HeaderText = "typ_izby"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'typizbyTextBox
        '
        Me.typizbyTextBox.Location = New System.Drawing.Point(304, 52)
        Me.typizbyTextBox.Name = "typizbyTextBox"
        Me.typizbyTextBox.Size = New System.Drawing.Size(91, 20)
        Me.typizbyTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(252, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Typ izby"
        '
        'vlozButton
        '
        Me.vlozButton.BackColor = System.Drawing.Color.CornflowerBlue
        Me.vlozButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vlozButton.Location = New System.Drawing.Point(223, 17)
        Me.vlozButton.Name = "vlozButton"
        Me.vlozButton.Size = New System.Drawing.Size(75, 23)
        Me.vlozButton.TabIndex = 4
        Me.vlozButton.Text = "Vložiť"
        Me.vlozButton.UseVisualStyleBackColor = False
        '
        'zatvor_button
        '
        Me.zatvor_button.BackColor = System.Drawing.Color.CornflowerBlue
        Me.zatvor_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zatvor_button.Location = New System.Drawing.Point(304, 17)
        Me.zatvor_button.Name = "zatvor_button"
        Me.zatvor_button.Size = New System.Drawing.Size(96, 23)
        Me.zatvor_button.TabIndex = 5
        Me.zatvor_button.Text = "Zavrieť podkartu"
        Me.zatvor_button.UseVisualStyleBackColor = False
        '
        'typ_izby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(593, 388)
        Me.Controls.Add(Me.zatvor_button)
        Me.Controls.Add(Me.vlozButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.typizbyTextBox)
        Me.Controls.Add(Me.Typ_izbyDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "typ_izby"
        Me.Text = "typ_izby"
        CType(Me.Typ_izbyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Typ_izbyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Typ_izbyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Typ_izbyDataSet As internat.typ_izbyDataSet
    Friend WithEvents Typ_izbyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Typ_izbyTableAdapter As internat.typ_izbyDataSetTableAdapters.typ_izbyTableAdapter
    Friend WithEvents TableAdapterManager As internat.typ_izbyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Typ_izbyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents typizbyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents vlozButton As System.Windows.Forms.Button
    Friend WithEvents zatvor_button As System.Windows.Forms.Button
End Class
