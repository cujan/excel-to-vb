﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(skupina))
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
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.nazovTextBox = New System.Windows.Forms.TextBox
        Me.vychovavatelComboBox1 = New System.Windows.Forms.ComboBox
        Me.VychovavatelDataSet = New internat.vychovavatelDataSet
        Me.VychovavatelDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VychovavatelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VychovavatelTableAdapter = New internat.vychovavatelDataSetTableAdapters.vychovavatelTableAdapter
        CType(Me.SkupinaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkupinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkupinaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SkupinaBindingNavigator.SuspendLayout()
        CType(Me.SkupinaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VychovavatelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VychovavatelDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VychovavatelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.skupinaTableAdapter = Me.SkupinaTableAdapter
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
        Me.SkupinaBindingNavigator.Size = New System.Drawing.Size(525, 25)
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
        'SkupinaBindingNavigatorSaveItem
        '
        Me.SkupinaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SkupinaBindingNavigatorSaveItem.Image = CType(resources.GetObject("SkupinaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SkupinaBindingNavigatorSaveItem.Name = "SkupinaBindingNavigatorSaveItem"
        Me.SkupinaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SkupinaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SkupinaDataGridView
        '
        Me.SkupinaDataGridView.AutoGenerateColumns = False
        Me.SkupinaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SkupinaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.SkupinaDataGridView.DataSource = Me.SkupinaBindingSource
        Me.SkupinaDataGridView.Location = New System.Drawing.Point(12, 133)
        Me.SkupinaDataGridView.Name = "SkupinaDataGridView"
        Me.SkupinaDataGridView.Size = New System.Drawing.Size(504, 220)
        Me.SkupinaDataGridView.TabIndex = 1
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(210, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nazovTextBox
        '
        Me.nazovTextBox.Location = New System.Drawing.Point(110, 43)
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
        Me.vychovavatelComboBox1.Location = New System.Drawing.Point(262, 41)
        Me.vychovavatelComboBox1.Name = "vychovavatelComboBox1"
        Me.vychovavatelComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.vychovavatelComboBox1.TabIndex = 4
        Me.vychovavatelComboBox1.ValueMember = "id"
        '
        'VychovavatelDataSet
        '
        Me.VychovavatelDataSet.DataSetName = "vychovavatelDataSet"
        Me.VychovavatelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VychovavatelDataSetBindingSource
        '
        Me.VychovavatelDataSetBindingSource.DataSource = Me.VychovavatelDataSet
        Me.VychovavatelDataSetBindingSource.Position = 0
        '
        'VychovavatelBindingSource
        '
        Me.VychovavatelBindingSource.DataMember = "vychovavatel"
        Me.VychovavatelBindingSource.DataSource = Me.VychovavatelDataSetBindingSource
        '
        'VychovavatelTableAdapter
        '
        Me.VychovavatelTableAdapter.ClearBeforeFill = True
        '
        'skupina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 396)
        Me.Controls.Add(Me.vychovavatelComboBox1)
        Me.Controls.Add(Me.nazovTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SkupinaDataGridView)
        Me.Controls.Add(Me.SkupinaBindingNavigator)
        Me.Name = "skupina"
        Me.Text = "skupina"
        CType(Me.SkupinaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkupinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkupinaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SkupinaBindingNavigator.ResumeLayout(False)
        Me.SkupinaBindingNavigator.PerformLayout()
        CType(Me.SkupinaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VychovavatelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VychovavatelDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VychovavatelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents nazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents vychovavatelComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents VychovavatelDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VychovavatelDataSet As internat.vychovavatelDataSet
    Friend WithEvents VychovavatelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VychovavatelTableAdapter As internat.vychovavatelDataSetTableAdapters.vychovavatelTableAdapter
End Class
