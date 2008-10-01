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
        Dim IdLabel As System.Windows.Forms.Label
        Dim Id_odberatelLabel As System.Windows.Forms.Label
        Dim DatumLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dodak2))
        Me.Dodaci_listDataSet1 = New lesnictvo.dodaci_listDataSet1
        Me.Dodaci_listBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dodaci_listTableAdapter = New lesnictvo.dodaci_listDataSet1TableAdapters.dodaci_listTableAdapter
        Me.TableAdapterManager = New lesnictvo.dodaci_listDataSet1TableAdapters.TableAdapterManager
        Me.Dodaci_listBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Dodaci_listBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.IdTextBox = New System.Windows.Forms.TextBox
        Me.DatumDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Dodaci_list_detailyDataSet1 = New lesnictvo.dodaci_list_detailyDataSet1
        Me.Dodaci_list_detailyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dodaci_list_detailyTableAdapter = New lesnictvo.dodaci_list_detailyDataSet1TableAdapters.dodaci_list_detailyTableAdapter
        Me.TableAdapterManager1 = New lesnictvo.dodaci_list_detailyDataSet1TableAdapters.TableAdapterManager
        Me.Dodaci_list_detailyDataGridView = New System.Windows.Forms.DataGridView
        Me.pohlad_drevinaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pohlad_drevinaDataSet1 = New lesnictvo.pohlad_drevinaDataSet1
        Me.DrevinyTableAdapter = New lesnictvo.pohlad_drevinaDataSet1TableAdapters.drevinyTableAdapter
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.pohlad_odberatelBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pohlad_odberatelDataSet1 = New lesnictvo.pohlad_odberatelDataSet1
        Me.OdberateliaTableAdapter = New lesnictvo.pohlad_odberatelDataSet1TableAdapters.odberateliaTableAdapter
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        IdLabel = New System.Windows.Forms.Label
        Id_odberatelLabel = New System.Windows.Forms.Label
        DatumLabel = New System.Windows.Forms.Label
        CType(Me.Dodaci_listDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dodaci_listBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dodaci_listBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Dodaci_listBindingNavigator.SuspendLayout()
        CType(Me.Dodaci_list_detailyDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dodaci_list_detailyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dodaci_list_detailyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pohlad_drevinaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pohlad_drevinaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pohlad_odberatelBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pohlad_odberatelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(65, 50)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'Id_odberatelLabel
        '
        Id_odberatelLabel.AutoSize = True
        Id_odberatelLabel.Location = New System.Drawing.Point(65, 76)
        Id_odberatelLabel.Name = "Id_odberatelLabel"
        Id_odberatelLabel.Size = New System.Drawing.Size(65, 13)
        Id_odberatelLabel.TabIndex = 3
        Id_odberatelLabel.Text = "id odberatel:"
        '
        'DatumLabel
        '
        DatumLabel.AutoSize = True
        DatumLabel.Location = New System.Drawing.Point(65, 103)
        DatumLabel.Name = "DatumLabel"
        DatumLabel.Size = New System.Drawing.Size(39, 13)
        DatumLabel.TabIndex = 5
        DatumLabel.Text = "datum:"
        '
        'Dodaci_listDataSet1
        '
        Me.Dodaci_listDataSet1.DataSetName = "dodaci_listDataSet1"
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
        Me.TableAdapterManager.UpdateOrder = lesnictvo.dodaci_listDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.Dodaci_listBindingNavigator.Size = New System.Drawing.Size(941, 25)
        Me.Dodaci_listBindingNavigator.TabIndex = 0
        Me.Dodaci_listBindingNavigator.Text = "BindingNavigator1"
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
        'Dodaci_listBindingNavigatorSaveItem
        '
        Me.Dodaci_listBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Dodaci_listBindingNavigatorSaveItem.Image = CType(resources.GetObject("Dodaci_listBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Dodaci_listBindingNavigatorSaveItem.Name = "Dodaci_listBindingNavigatorSaveItem"
        Me.Dodaci_listBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Dodaci_listBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dodaci_listBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(136, 47)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'DatumDateTimePicker
        '
        Me.DatumDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Dodaci_listBindingSource, "datum", True))
        Me.DatumDateTimePicker.Location = New System.Drawing.Point(136, 99)
        Me.DatumDateTimePicker.Name = "DatumDateTimePicker"
        Me.DatumDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DatumDateTimePicker.TabIndex = 6
        '
        'Dodaci_list_detailyDataSet1
        '
        Me.Dodaci_list_detailyDataSet1.DataSetName = "dodaci_list_detailyDataSet1"
        Me.Dodaci_list_detailyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dodaci_list_detailyBindingSource
        '
        Me.Dodaci_list_detailyBindingSource.DataMember = "dodaci_list_detaily"
        Me.Dodaci_list_detailyBindingSource.DataSource = Me.Dodaci_list_detailyDataSet1
        '
        'Dodaci_list_detailyTableAdapter
        '
        Me.Dodaci_list_detailyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.dodaci_list_detailyTableAdapter = Me.Dodaci_list_detailyTableAdapter
        Me.TableAdapterManager1.UpdateOrder = lesnictvo.dodaci_list_detailyDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Dodaci_list_detailyDataGridView
        '
        Me.Dodaci_list_detailyDataGridView.AutoGenerateColumns = False
        Me.Dodaci_list_detailyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dodaci_list_detailyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Dodaci_list_detailyDataGridView.DataSource = Me.Dodaci_list_detailyBindingSource
        Me.Dodaci_list_detailyDataGridView.Location = New System.Drawing.Point(12, 190)
        Me.Dodaci_list_detailyDataGridView.Name = "Dodaci_list_detailyDataGridView"
        Me.Dodaci_list_detailyDataGridView.Size = New System.Drawing.Size(845, 220)
        Me.Dodaci_list_detailyDataGridView.TabIndex = 7
        '
        'pohlad_drevinaBindingSource1
        '
        Me.pohlad_drevinaBindingSource1.DataMember = "dreviny"
        Me.pohlad_drevinaBindingSource1.DataSource = Me.Pohlad_drevinaDataSet1
        '
        'Pohlad_drevinaDataSet1
        '
        Me.Pohlad_drevinaDataSet1.DataSetName = "pohlad_drevinaDataSet1"
        Me.Pohlad_drevinaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DrevinyTableAdapter
        '
        Me.DrevinyTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.pohlad_odberatelBindingSource1
        Me.ComboBox1.DisplayMember = "nazov"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(137, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(199, 21)
        Me.ComboBox1.TabIndex = 8
        Me.ComboBox1.ValueMember = "id"
        '
        'pohlad_odberatelBindingSource1
        '
        Me.pohlad_odberatelBindingSource1.DataMember = "odberatelia"
        Me.pohlad_odberatelBindingSource1.DataSource = Me.Pohlad_odberatelDataSet1
        '
        'Pohlad_odberatelDataSet1
        '
        Me.Pohlad_odberatelDataSet1.DataSetName = "pohlad_odberatelDataSet1"
        Me.Pohlad_odberatelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OdberateliaTableAdapter
        '
        Me.OdberateliaTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "drevinaID"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.pohlad_drevinaBindingSource1
        Me.DataGridViewTextBoxColumn3.DisplayMember = "skratka"
        Me.DataGridViewTextBoxColumn3.HeaderText = "drevinaID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "id"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "dlzka"
        Me.DataGridViewTextBoxColumn4.HeaderText = "dlzka"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "sirka"
        Me.DataGridViewTextBoxColumn5.HeaderText = "sirka"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "hrubka"
        Me.DataGridViewTextBoxColumn6.HeaderText = "hrubka"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "mnozstvo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "mnozstvo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cena"
        Me.DataGridViewTextBoxColumn8.HeaderText = "cena"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'dodak2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 529)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Dodaci_list_detailyDataGridView)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Id_odberatelLabel)
        Me.Controls.Add(DatumLabel)
        Me.Controls.Add(Me.DatumDateTimePicker)
        Me.Controls.Add(Me.Dodaci_listBindingNavigator)
        Me.Name = "dodak2"
        Me.Text = "dodak2"
        CType(Me.Dodaci_listDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dodaci_listBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dodaci_listBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Dodaci_listBindingNavigator.ResumeLayout(False)
        Me.Dodaci_listBindingNavigator.PerformLayout()
        CType(Me.Dodaci_list_detailyDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dodaci_list_detailyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dodaci_list_detailyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pohlad_drevinaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pohlad_drevinaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pohlad_odberatelBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pohlad_odberatelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dodaci_listDataSet1 As lesnictvo.dodaci_listDataSet1
    Friend WithEvents Dodaci_listBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dodaci_listTableAdapter As lesnictvo.dodaci_listDataSet1TableAdapters.dodaci_listTableAdapter
    Friend WithEvents TableAdapterManager As lesnictvo.dodaci_listDataSet1TableAdapters.TableAdapterManager
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
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatumDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dodaci_list_detailyDataSet1 As lesnictvo.dodaci_list_detailyDataSet1
    Friend WithEvents Dodaci_list_detailyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dodaci_list_detailyTableAdapter As lesnictvo.dodaci_list_detailyDataSet1TableAdapters.dodaci_list_detailyTableAdapter
    Friend WithEvents TableAdapterManager1 As lesnictvo.dodaci_list_detailyDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Dodaci_list_detailyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents pohlad_drevinaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Pohlad_drevinaDataSet1 As lesnictvo.pohlad_drevinaDataSet1
    Friend WithEvents DrevinyTableAdapter As lesnictvo.pohlad_drevinaDataSet1TableAdapters.drevinyTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents pohlad_odberatelBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Pohlad_odberatelDataSet1 As lesnictvo.pohlad_odberatelDataSet1
    Friend WithEvents OdberateliaTableAdapter As lesnictvo.pohlad_odberatelDataSet1TableAdapters.odberateliaTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
