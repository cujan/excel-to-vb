﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vychovavatel))
        Me.VychovavatelBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VychovavatelBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.VychovavatelDataGridView = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.menoTextBox = New System.Windows.Forms.TextBox
        Me.priezviskoTextBox = New System.Windows.Forms.TextBox
        Me.poznamkaTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.titul = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VychovavatelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VychovavatelDataSet = New internat.vychovavatelDataSet
        Me.VychovavatelTableAdapter = New internat.vychovavatelDataSetTableAdapters.vychovavatelTableAdapter
        Me.TableAdapterManager = New internat.vychovavatelDataSetTableAdapters.TableAdapterManager
        Me.Button1 = New System.Windows.Forms.Button
        Me.titul_predComboBox = New System.Windows.Forms.ComboBox
        Me.Titul_predDataSet = New internat.titul_predDataSet
        Me.TitulpredBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Titul_predTableAdapter = New internat.titul_predDataSetTableAdapters.titul_predTableAdapter
        CType(Me.VychovavatelBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VychovavatelBindingNavigator.SuspendLayout()
        CType(Me.VychovavatelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VychovavatelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VychovavatelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Titul_predDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitulpredBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VychovavatelBindingNavigator
        '
        Me.VychovavatelBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VychovavatelBindingNavigator.BindingSource = Me.VychovavatelBindingSource
        Me.VychovavatelBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VychovavatelBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VychovavatelBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VychovavatelBindingNavigatorSaveItem})
        Me.VychovavatelBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VychovavatelBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VychovavatelBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VychovavatelBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VychovavatelBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VychovavatelBindingNavigator.Name = "VychovavatelBindingNavigator"
        Me.VychovavatelBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VychovavatelBindingNavigator.Size = New System.Drawing.Size(649, 25)
        Me.VychovavatelBindingNavigator.TabIndex = 0
        Me.VychovavatelBindingNavigator.Text = "BindingNavigator1"
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
        'VychovavatelBindingNavigatorSaveItem
        '
        Me.VychovavatelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VychovavatelBindingNavigatorSaveItem.Image = CType(resources.GetObject("VychovavatelBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VychovavatelBindingNavigatorSaveItem.Name = "VychovavatelBindingNavigatorSaveItem"
        Me.VychovavatelBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VychovavatelBindingNavigatorSaveItem.Text = "Save Data"
        '
        'VychovavatelDataGridView
        '
        Me.VychovavatelDataGridView.AutoGenerateColumns = False
        Me.VychovavatelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VychovavatelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.titul, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.VychovavatelDataGridView.DataSource = Me.VychovavatelBindingSource
        Me.VychovavatelDataGridView.Location = New System.Drawing.Point(37, 163)
        Me.VychovavatelDataGridView.Name = "VychovavatelDataGridView"
        Me.VychovavatelDataGridView.Size = New System.Drawing.Size(520, 220)
        Me.VychovavatelDataGridView.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Meno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Priezvisko"
        '
        'menoTextBox
        '
        Me.menoTextBox.Location = New System.Drawing.Point(104, 71)
        Me.menoTextBox.Name = "menoTextBox"
        Me.menoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.menoTextBox.TabIndex = 4
        '
        'priezviskoTextBox
        '
        Me.priezviskoTextBox.Location = New System.Drawing.Point(104, 117)
        Me.priezviskoTextBox.Name = "priezviskoTextBox"
        Me.priezviskoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.priezviskoTextBox.TabIndex = 5
        '
        'poznamkaTextBox
        '
        Me.poznamkaTextBox.Location = New System.Drawing.Point(395, 54)
        Me.poznamkaTextBox.Multiline = True
        Me.poznamkaTextBox.Name = "poznamkaTextBox"
        Me.poznamkaTextBox.Size = New System.Drawing.Size(208, 79)
        Me.poznamkaTextBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(326, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "poznamka"
        '
        'titul
        '
        Me.titul.DataPropertyName = "titul"
        Me.titul.HeaderText = "titul"
        Me.titul.Name = "titul"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Titul"
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
        'VychovavatelTableAdapter
        '
        Me.VychovavatelTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = internat.vychovavatelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vychovavatelTableAdapter = Me.VychovavatelTableAdapter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(261, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Ulož"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'titul_predComboBox
        '
        Me.titul_predComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TitulpredBindingSource, "id", True))
        Me.titul_predComboBox.DataSource = Me.TitulpredBindingSource
        Me.titul_predComboBox.DisplayMember = "skratka"
        Me.titul_predComboBox.FormattingEnabled = True
        Me.titul_predComboBox.Location = New System.Drawing.Point(104, 35)
        Me.titul_predComboBox.Name = "titul_predComboBox"
        Me.titul_predComboBox.Size = New System.Drawing.Size(121, 21)
        Me.titul_predComboBox.TabIndex = 11
        Me.titul_predComboBox.ValueMember = "id"
        '
        'Titul_predDataSet
        '
        Me.Titul_predDataSet.DataSetName = "titul_predDataSet"
        Me.Titul_predDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TitulpredBindingSource
        '
        Me.TitulpredBindingSource.DataMember = "titul_pred"
        Me.TitulpredBindingSource.DataSource = Me.Titul_predDataSet
        '
        'Titul_predTableAdapter
        '
        Me.Titul_predTableAdapter.ClearBeforeFill = True
        '
        'vychovavatel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 407)
        Me.Controls.Add(Me.titul_predComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.poznamkaTextBox)
        Me.Controls.Add(Me.priezviskoTextBox)
        Me.Controls.Add(Me.menoTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VychovavatelDataGridView)
        Me.Controls.Add(Me.VychovavatelBindingNavigator)
        Me.Name = "vychovavatel"
        Me.Text = "vychovavatel"
        CType(Me.VychovavatelBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VychovavatelBindingNavigator.ResumeLayout(False)
        Me.VychovavatelBindingNavigator.PerformLayout()
        CType(Me.VychovavatelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VychovavatelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VychovavatelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Titul_predDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitulpredBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VychovavatelDataSet As internat.vychovavatelDataSet
    Friend WithEvents VychovavatelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VychovavatelTableAdapter As internat.vychovavatelDataSetTableAdapters.vychovavatelTableAdapter
    Friend WithEvents TableAdapterManager As internat.vychovavatelDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VychovavatelBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents VychovavatelBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents VychovavatelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents menoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents priezviskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents poznamkaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents titul As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents titul_predComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Titul_predDataSet As internat.titul_predDataSet
    Friend WithEvents TitulpredBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Titul_predTableAdapter As internat.titul_predDataSetTableAdapters.titul_predTableAdapter
End Class
