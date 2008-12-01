<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class statna_prislusnost
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(statna_prislusnost))
        Me.Statna_prislusnostDataSet = New evidencia_spz.statna_prislusnostDataSet
        Me.Statna_prislusnostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Statna_prislusnostTableAdapter = New evidencia_spz.statna_prislusnostDataSetTableAdapters.statna_prislusnostTableAdapter
        Me.TableAdapterManager = New evidencia_spz.statna_prislusnostDataSetTableAdapters.TableAdapterManager
        Me.Statna_prislusnostBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Statna_prislusnostBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Statna_prislusnostDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.Statna_prislusnostDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Statna_prislusnostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Statna_prislusnostBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Statna_prislusnostBindingNavigator.SuspendLayout()
        CType(Me.Statna_prislusnostDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Statna_prislusnostDataSet
        '
        Me.Statna_prislusnostDataSet.DataSetName = "statna_prislusnostDataSet"
        Me.Statna_prislusnostDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Statna_prislusnostBindingSource
        '
        Me.Statna_prislusnostBindingSource.DataMember = "statna_prislusnost"
        Me.Statna_prislusnostBindingSource.DataSource = Me.Statna_prislusnostDataSet
        '
        'Statna_prislusnostTableAdapter
        '
        Me.Statna_prislusnostTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.statna_prislusnostTableAdapter = Me.Statna_prislusnostTableAdapter
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.statna_prislusnostDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Statna_prislusnostBindingNavigator
        '
        Me.Statna_prislusnostBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Statna_prislusnostBindingNavigator.BindingSource = Me.Statna_prislusnostBindingSource
        Me.Statna_prislusnostBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Statna_prislusnostBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Statna_prislusnostBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Statna_prislusnostBindingNavigatorSaveItem})
        Me.Statna_prislusnostBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Statna_prislusnostBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Statna_prislusnostBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Statna_prislusnostBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Statna_prislusnostBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Statna_prislusnostBindingNavigator.Name = "Statna_prislusnostBindingNavigator"
        Me.Statna_prislusnostBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Statna_prislusnostBindingNavigator.Size = New System.Drawing.Size(680, 25)
        Me.Statna_prislusnostBindingNavigator.TabIndex = 0
        Me.Statna_prislusnostBindingNavigator.Text = "BindingNavigator1"
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
        'Statna_prislusnostBindingNavigatorSaveItem
        '
        Me.Statna_prislusnostBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Statna_prislusnostBindingNavigatorSaveItem.Image = CType(resources.GetObject("Statna_prislusnostBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Statna_prislusnostBindingNavigatorSaveItem.Name = "Statna_prislusnostBindingNavigatorSaveItem"
        Me.Statna_prislusnostBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Statna_prislusnostBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Statna_prislusnostDataGridView
        '
        Me.Statna_prislusnostDataGridView.AutoGenerateColumns = False
        Me.Statna_prislusnostDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Statna_prislusnostDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Statna_prislusnostDataGridView.DataSource = Me.Statna_prislusnostBindingSource
        Me.Statna_prislusnostDataGridView.Location = New System.Drawing.Point(12, 77)
        Me.Statna_prislusnostDataGridView.Name = "Statna_prislusnostDataGridView"
        Me.Statna_prislusnostDataGridView.Size = New System.Drawing.Size(656, 266)
        Me.Statna_prislusnostDataGridView.TabIndex = 1
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
        'statna_prislusnost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 355)
        Me.Controls.Add(Me.Statna_prislusnostDataGridView)
        Me.Controls.Add(Me.Statna_prislusnostBindingNavigator)
        Me.Name = "statna_prislusnost"
        Me.Text = "statna_prislusnost"
        CType(Me.Statna_prislusnostDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Statna_prislusnostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Statna_prislusnostBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Statna_prislusnostBindingNavigator.ResumeLayout(False)
        Me.Statna_prislusnostBindingNavigator.PerformLayout()
        CType(Me.Statna_prislusnostDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Statna_prislusnostDataSet As evidencia_spz.statna_prislusnostDataSet
    Friend WithEvents Statna_prislusnostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Statna_prislusnostTableAdapter As evidencia_spz.statna_prislusnostDataSetTableAdapters.statna_prislusnostTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.statna_prislusnostDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Statna_prislusnostBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Statna_prislusnostBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Statna_prislusnostDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
