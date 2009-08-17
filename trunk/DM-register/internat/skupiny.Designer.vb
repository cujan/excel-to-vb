<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class skupiny
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(skupiny))
        Me.SkupinaDataSet = New internat.skupinaDataSet
        Me.SkupinaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkupinaTableAdapter = New internat.skupinaDataSetTableAdapters.skupinaTableAdapter
        Me.TableAdapterManager = New internat.skupinaDataSetTableAdapters.TableAdapterManager
        Me.SkupinaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.SkupinaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.SkupinaDataGridView = New System.Windows.Forms.DataGridView
        Me.VychovavateliaDataSet = New internat.vychovavateliaDataSet
        Me.VychovavateliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VychovavateliaTableAdapter = New internat.vychovavateliaDataSetTableAdapters.vychovavateliaTableAdapter
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.SkupinaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkupinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkupinaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SkupinaBindingNavigator.SuspendLayout()
        CType(Me.SkupinaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VychovavateliaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VychovavateliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SkupinaDataSet
        '
        Me.SkupinaDataSet.DataSetName = "skupinaDataSet"
        Me.SkupinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SkupinaBindingSource
        '
        Me.SkupinaBindingSource.DataMember = "skupina"
        Me.SkupinaBindingSource.DataSource = Me.SkupinaDataSet
        '
        'SkupinaTableAdapter
        '
        Me.SkupinaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = internat.skupinaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SkupinaBindingNavigator
        '
        Me.SkupinaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SkupinaBindingNavigator.BindingSource = Me.SkupinaBindingSource
        Me.SkupinaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SkupinaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SkupinaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SkupinaBindingNavigatorSaveItem})
        Me.SkupinaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SkupinaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SkupinaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SkupinaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SkupinaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SkupinaBindingNavigator.Name = "SkupinaBindingNavigator"
        Me.SkupinaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SkupinaBindingNavigator.Size = New System.Drawing.Size(664, 25)
        Me.SkupinaBindingNavigator.TabIndex = 0
        Me.SkupinaBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'SkupinaBindingNavigatorSaveItem
        '
        Me.SkupinaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SkupinaBindingNavigatorSaveItem.Enabled = False
        Me.SkupinaBindingNavigatorSaveItem.Image = CType(resources.GetObject("SkupinaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SkupinaBindingNavigatorSaveItem.Name = "SkupinaBindingNavigatorSaveItem"
        Me.SkupinaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.SkupinaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SkupinaDataGridView
        '
        Me.SkupinaDataGridView.AutoGenerateColumns = False
        Me.SkupinaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SkupinaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.SkupinaDataGridView.DataSource = Me.SkupinaBindingSource
        Me.SkupinaDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.SkupinaDataGridView.Name = "SkupinaDataGridView"
        Me.SkupinaDataGridView.Size = New System.Drawing.Size(640, 276)
        Me.SkupinaDataGridView.TabIndex = 1
        '
        'VychovavateliaDataSet
        '
        Me.VychovavateliaDataSet.DataSetName = "vychovavateliaDataSet"
        Me.VychovavateliaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VychovavateliaBindingSource
        '
        Me.VychovavateliaBindingSource.DataMember = "vychovavatelia"
        Me.VychovavateliaBindingSource.DataSource = Me.VychovavateliaDataSet
        '
        'VychovavateliaTableAdapter
        '
        Me.VychovavateliaTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nazov"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nazov"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id_vychovavatel"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.VychovavateliaBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "priezvisko"
        Me.DataGridViewTextBoxColumn3.HeaderText = "id_vychovavatel"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "ID"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "priezvisko"
        Me.DataGridViewTextBoxColumn4.HeaderText = "priezvisko"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'skupiny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 316)
        Me.Controls.Add(Me.SkupinaDataGridView)
        Me.Controls.Add(Me.SkupinaBindingNavigator)
        Me.Name = "skupiny"
        Me.Text = "skupiny"
        CType(Me.SkupinaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkupinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkupinaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SkupinaBindingNavigator.ResumeLayout(False)
        Me.SkupinaBindingNavigator.PerformLayout()
        CType(Me.SkupinaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VychovavateliaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VychovavateliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SkupinaDataSet As internat.skupinaDataSet
    Friend WithEvents SkupinaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SkupinaTableAdapter As internat.skupinaDataSetTableAdapters.skupinaTableAdapter
    Friend WithEvents TableAdapterManager As internat.skupinaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SkupinaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SkupinaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SkupinaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VychovavateliaDataSet As internat.vychovavateliaDataSet
    Friend WithEvents VychovavateliaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VychovavateliaTableAdapter As internat.vychovavateliaDataSetTableAdapters.vychovavateliaTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
