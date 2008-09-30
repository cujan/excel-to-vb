<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dodak2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dodak2))
        Me.Dodaci_listDataSet1 = New lesnictvo.Dodaci_listDataSet1
        Me.Dodaci_listBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dodaci_listTableAdapter = New lesnictvo.Dodaci_listDataSet1TableAdapters.dodaci_listTableAdapter
        Me.TableAdapterManager = New lesnictvo.Dodaci_listDataSet1TableAdapters.TableAdapterManager
        Me.Dodaci_listBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Dodaci_listBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Dodaci_listDataGridView = New System.Windows.Forms.DataGridView
        Me.drevina_pohladBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Drevina_pohladDataSet1 = New lesnictvo.drevina_pohladDataSet1
        Me.DrevinyTableAdapter = New lesnictvo.drevina_pohladDataSet1TableAdapters.drevinyTableAdapter
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.Dodaci_listDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dodaci_listBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dodaci_listBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Dodaci_listBindingNavigator.SuspendLayout()
        CType(Me.Dodaci_listDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drevina_pohladBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Drevina_pohladDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dodaci_listDataSet1
        '
        Me.Dodaci_listDataSet1.DataSetName = "Dodaci_listDataSet1"
        Me.Dodaci_listDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dodaci_listBindingSource
        '
        Me.Dodaci_listBindingSource.DataMember = "dodaci_list"
        Me.Dodaci_listBindingSource.DataSource = Me.Dodaci_listDataSet1
        '
        'Dodaci_listTableAdapter
        '
        Me.Dodaci_listTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dodaci_listTableAdapter = Me.Dodaci_listTableAdapter
        Me.TableAdapterManager.UpdateOrder = lesnictvo.Dodaci_listDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Dodaci_listBindingNavigator
        '
        Me.Dodaci_listBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Dodaci_listBindingNavigator.BindingSource = Me.Dodaci_listBindingSource
        Me.Dodaci_listBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Dodaci_listBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Dodaci_listBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Dodaci_listBindingNavigatorSaveItem})
        Me.Dodaci_listBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Dodaci_listBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Dodaci_listBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Dodaci_listBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Dodaci_listBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Dodaci_listBindingNavigator.Name = "Dodaci_listBindingNavigator"
        Me.Dodaci_listBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Dodaci_listBindingNavigator.Size = New System.Drawing.Size(664, 25)
        Me.Dodaci_listBindingNavigator.TabIndex = 0
        Me.Dodaci_listBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Dodaci_listBindingNavigatorSaveItem
        '
        Me.Dodaci_listBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Dodaci_listBindingNavigatorSaveItem.Image = CType(resources.GetObject("Dodaci_listBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Dodaci_listBindingNavigatorSaveItem.Name = "Dodaci_listBindingNavigatorSaveItem"
        Me.Dodaci_listBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Dodaci_listBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Dodaci_listDataGridView
        '
        Me.Dodaci_listDataGridView.AutoGenerateColumns = False
        Me.Dodaci_listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dodaci_listDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Dodaci_listDataGridView.DataSource = Me.Dodaci_listBindingSource
        Me.Dodaci_listDataGridView.Location = New System.Drawing.Point(12, 130)
        Me.Dodaci_listDataGridView.Name = "Dodaci_listDataGridView"
        Me.Dodaci_listDataGridView.Size = New System.Drawing.Size(640, 220)
        Me.Dodaci_listDataGridView.TabIndex = 1
        '
        'drevina_pohladBindingSource1
        '
        Me.drevina_pohladBindingSource1.DataMember = "dreviny"
        Me.drevina_pohladBindingSource1.DataSource = Me.Drevina_pohladDataSet1
        '
        'Drevina_pohladDataSet1
        '
        Me.Drevina_pohladDataSet1.DataSetName = "drevina_pohladDataSet1"
        Me.Drevina_pohladDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DrevinyTableAdapter
        '
        Me.DrevinyTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "drevina"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.drevina_pohladBindingSource1
        Me.DataGridViewTextBoxColumn2.DisplayMember = "nazov"
        Me.DataGridViewTextBoxColumn2.HeaderText = "drevina"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "dlzka"
        Me.DataGridViewTextBoxColumn3.HeaderText = "dlzka"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "sirka"
        Me.DataGridViewTextBoxColumn4.HeaderText = "sirka"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "hrubka"
        Me.DataGridViewTextBoxColumn5.HeaderText = "hrubka"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "mnozstvo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "mnozstvo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'dodak2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 529)
        Me.Controls.Add(Me.Dodaci_listDataGridView)
        Me.Controls.Add(Me.Dodaci_listBindingNavigator)
        Me.Name = "dodak2"
        Me.Text = "dodak2"
        CType(Me.Dodaci_listDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dodaci_listBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dodaci_listBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Dodaci_listBindingNavigator.ResumeLayout(False)
        Me.Dodaci_listBindingNavigator.PerformLayout()
        CType(Me.Dodaci_listDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drevina_pohladBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Drevina_pohladDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dodaci_listDataSet1 As lesnictvo.Dodaci_listDataSet1
    Friend WithEvents Dodaci_listBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dodaci_listTableAdapter As lesnictvo.Dodaci_listDataSet1TableAdapters.dodaci_listTableAdapter
    Friend WithEvents TableAdapterManager As lesnictvo.Dodaci_listDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Dodaci_listBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Dodaci_listBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Dodaci_listDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents drevina_pohladBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Drevina_pohladDataSet1 As lesnictvo.drevina_pohladDataSet1
    Friend WithEvents DrevinyTableAdapter As lesnictvo.drevina_pohladDataSet1TableAdapters.drevinyTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
