<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class titul_za
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(titul_za))
        Dim NazovLabel As System.Windows.Forms.Label
        Me.TitulzaDataSet = New evidencia_spz.titulzaDataSet
        Me.Titul_zaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Titul_zaTableAdapter = New evidencia_spz.titulzaDataSetTableAdapters.titul_zaTableAdapter
        Me.TableAdapterManager = New evidencia_spz.titulzaDataSetTableAdapters.TableAdapterManager
        Me.Titul_zaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Titul_zaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Titul_zaDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.koniec = New System.Windows.Forms.Button
        Me.pridaj = New System.Windows.Forms.Button
        Me.uloz = New System.Windows.Forms.Button
        Me.zmaz = New System.Windows.Forms.Button
        Me.NazovTextBox = New System.Windows.Forms.TextBox
        NazovLabel = New System.Windows.Forms.Label
        CType(Me.TitulzaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Titul_zaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Titul_zaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Titul_zaBindingNavigator.SuspendLayout()
        CType(Me.Titul_zaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitulzaDataSet
        '
        Me.TitulzaDataSet.DataSetName = "titulzaDataSet"
        Me.TitulzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Titul_zaBindingSource
        '
        Me.Titul_zaBindingSource.DataMember = "titul_za"
        Me.Titul_zaBindingSource.DataSource = Me.TitulzaDataSet
        '
        'Titul_zaTableAdapter
        '
        Me.Titul_zaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.titul_zaTableAdapter = Me.Titul_zaTableAdapter
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.titulzaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Titul_zaBindingNavigator
        '
        Me.Titul_zaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Titul_zaBindingNavigator.BindingSource = Me.Titul_zaBindingSource
        Me.Titul_zaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Titul_zaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Titul_zaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Titul_zaBindingNavigatorSaveItem})
        Me.Titul_zaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Titul_zaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Titul_zaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Titul_zaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Titul_zaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Titul_zaBindingNavigator.Name = "Titul_zaBindingNavigator"
        Me.Titul_zaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Titul_zaBindingNavigator.Size = New System.Drawing.Size(633, 25)
        Me.Titul_zaBindingNavigator.TabIndex = 0
        Me.Titul_zaBindingNavigator.Text = "BindingNavigator1"
        Me.Titul_zaBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Titul_zaBindingNavigatorSaveItem
        '
        Me.Titul_zaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Titul_zaBindingNavigatorSaveItem.Image = CType(resources.GetObject("Titul_zaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Titul_zaBindingNavigatorSaveItem.Name = "Titul_zaBindingNavigatorSaveItem"
        Me.Titul_zaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Titul_zaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Titul_zaDataGridView
        '
        Me.Titul_zaDataGridView.AllowUserToAddRows = False
        Me.Titul_zaDataGridView.AllowUserToDeleteRows = False
        Me.Titul_zaDataGridView.AutoGenerateColumns = False
        Me.Titul_zaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Titul_zaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.Titul_zaDataGridView.DataSource = Me.Titul_zaBindingSource
        Me.Titul_zaDataGridView.Location = New System.Drawing.Point(12, 176)
        Me.Titul_zaDataGridView.Name = "Titul_zaDataGridView"
        Me.Titul_zaDataGridView.ReadOnly = True
        Me.Titul_zaDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.Titul_zaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nazov"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nazov"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'koniec
        '
        Me.koniec.Location = New System.Drawing.Point(435, 65)
        Me.koniec.Name = "koniec"
        Me.koniec.Size = New System.Drawing.Size(75, 23)
        Me.koniec.TabIndex = 2
        Me.koniec.Text = "koniec"
        Me.koniec.UseVisualStyleBackColor = True
        '
        'pridaj
        '
        Me.pridaj.Location = New System.Drawing.Point(435, 95)
        Me.pridaj.Name = "pridaj"
        Me.pridaj.Size = New System.Drawing.Size(75, 23)
        Me.pridaj.TabIndex = 3
        Me.pridaj.Text = "Pridaj"
        Me.pridaj.UseVisualStyleBackColor = True
        '
        'uloz
        '
        Me.uloz.Location = New System.Drawing.Point(435, 125)
        Me.uloz.Name = "uloz"
        Me.uloz.Size = New System.Drawing.Size(75, 23)
        Me.uloz.TabIndex = 4
        Me.uloz.Text = "Uloz"
        Me.uloz.UseVisualStyleBackColor = True
        Me.uloz.Visible = False
        '
        'zmaz
        '
        Me.zmaz.Location = New System.Drawing.Point(435, 155)
        Me.zmaz.Name = "zmaz"
        Me.zmaz.Size = New System.Drawing.Size(75, 23)
        Me.zmaz.TabIndex = 5
        Me.zmaz.Text = "zmaz"
        Me.zmaz.UseVisualStyleBackColor = True
        '
        'NazovLabel
        '
        NazovLabel.AutoSize = True
        NazovLabel.Location = New System.Drawing.Point(78, 96)
        NazovLabel.Name = "NazovLabel"
        NazovLabel.Size = New System.Drawing.Size(39, 13)
        NazovLabel.TabIndex = 8
        NazovLabel.Text = "nazov:"
        '
        'NazovTextBox
        '
        Me.NazovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Titul_zaBindingSource, "nazov", True))
        Me.NazovTextBox.Location = New System.Drawing.Point(123, 93)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.ReadOnly = True
        Me.NazovTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NazovTextBox.TabIndex = 9
        '
        'titul_za
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(633, 519)
        Me.Controls.Add(NazovLabel)
        Me.Controls.Add(Me.NazovTextBox)
        Me.Controls.Add(Me.zmaz)
        Me.Controls.Add(Me.uloz)
        Me.Controls.Add(Me.pridaj)
        Me.Controls.Add(Me.koniec)
        Me.Controls.Add(Me.Titul_zaDataGridView)
        Me.Controls.Add(Me.Titul_zaBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "titul_za"
        Me.Text = "titul_za"
        CType(Me.TitulzaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Titul_zaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Titul_zaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Titul_zaBindingNavigator.ResumeLayout(False)
        Me.Titul_zaBindingNavigator.PerformLayout()
        CType(Me.Titul_zaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitulzaDataSet As evidencia_spz.titulzaDataSet
    Friend WithEvents Titul_zaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Titul_zaTableAdapter As evidencia_spz.titulzaDataSetTableAdapters.titul_zaTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.titulzaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Titul_zaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Titul_zaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Titul_zaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents koniec As System.Windows.Forms.Button
    Friend WithEvents pridaj As System.Windows.Forms.Button
    Friend WithEvents uloz As System.Windows.Forms.Button
    Friend WithEvents zmaz As System.Windows.Forms.Button
    Friend WithEvents NazovTextBox As System.Windows.Forms.TextBox
End Class
