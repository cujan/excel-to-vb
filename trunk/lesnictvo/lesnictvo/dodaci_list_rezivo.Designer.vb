<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dodaci_list_rezivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dodaci_list_rezivo))
        Dim IdLabel As System.Windows.Forms.Label
        Dim OdberatelIDLabel As System.Windows.Forms.Label
        Dim DatumLabel As System.Windows.Forms.Label
        Me.Dodaci_list_rezivoDataSet1 = New lesnictvo.dodaci_list_rezivoDataSet1
        Me.Dodaci_list_rezivoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dodaci_list_rezivoTableAdapter = New lesnictvo.dodaci_list_rezivoDataSet1TableAdapters.dodaci_list_rezivoTableAdapter
        Me.TableAdapterManager = New lesnictvo.dodaci_list_rezivoDataSet1TableAdapters.TableAdapterManager
        Me.Dodaci_list_rezivoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Dodaci_list_rezivoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.IdTextBox = New System.Windows.Forms.TextBox
        Me.OdberatelIDTextBox = New System.Windows.Forms.TextBox
        Me.DatumDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Dodaci_list_rezivo_detailyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dodaci_list_rezivo_detailyTableAdapter = New lesnictvo.dodaci_list_rezivoDataSet1TableAdapters.dodaci_list_rezivo_detailyTableAdapter
        Me.Dodaci_list_rezivo_detailyDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        IdLabel = New System.Windows.Forms.Label
        OdberatelIDLabel = New System.Windows.Forms.Label
        DatumLabel = New System.Windows.Forms.Label
        CType(Me.Dodaci_list_rezivoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dodaci_list_rezivoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dodaci_list_rezivoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Dodaci_list_rezivoBindingNavigator.SuspendLayout()
        CType(Me.Dodaci_list_rezivo_detailyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dodaci_list_rezivo_detailyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dodaci_list_rezivoDataSet1
        '
        Me.Dodaci_list_rezivoDataSet1.DataSetName = "dodaci_list_rezivoDataSet1"
        Me.Dodaci_list_rezivoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dodaci_list_rezivoBindingSource
        '
        Me.Dodaci_list_rezivoBindingSource.DataMember = "dodaci_list_rezivo"
        Me.Dodaci_list_rezivoBindingSource.DataSource = Me.Dodaci_list_rezivoDataSet1
        '
        'Dodaci_list_rezivoTableAdapter
        '
        Me.Dodaci_list_rezivoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dodaci_list_rezivo_detailyTableAdapter = Me.Dodaci_list_rezivo_detailyTableAdapter
        Me.TableAdapterManager.dodaci_list_rezivoTableAdapter = Me.Dodaci_list_rezivoTableAdapter
        Me.TableAdapterManager.UpdateOrder = lesnictvo.dodaci_list_rezivoDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Dodaci_list_rezivoBindingNavigator
        '
        Me.Dodaci_list_rezivoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Dodaci_list_rezivoBindingNavigator.BindingSource = Me.Dodaci_list_rezivoBindingSource
        Me.Dodaci_list_rezivoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Dodaci_list_rezivoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Dodaci_list_rezivoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Dodaci_list_rezivoBindingNavigatorSaveItem})
        Me.Dodaci_list_rezivoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Dodaci_list_rezivoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Dodaci_list_rezivoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Dodaci_list_rezivoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Dodaci_list_rezivoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Dodaci_list_rezivoBindingNavigator.Name = "Dodaci_list_rezivoBindingNavigator"
        Me.Dodaci_list_rezivoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Dodaci_list_rezivoBindingNavigator.Size = New System.Drawing.Size(992, 25)
        Me.Dodaci_list_rezivoBindingNavigator.TabIndex = 0
        Me.Dodaci_list_rezivoBindingNavigator.Text = "BindingNavigator1"
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
        'Dodaci_list_rezivoBindingNavigatorSaveItem
        '
        Me.Dodaci_list_rezivoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Dodaci_list_rezivoBindingNavigatorSaveItem.Image = CType(resources.GetObject("Dodaci_list_rezivoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Dodaci_list_rezivoBindingNavigatorSaveItem.Name = "Dodaci_list_rezivoBindingNavigatorSaveItem"
        Me.Dodaci_list_rezivoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Dodaci_list_rezivoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(117, 72)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dodaci_list_rezivoBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(191, 69)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'OdberatelIDLabel
        '
        OdberatelIDLabel.AutoSize = True
        OdberatelIDLabel.Location = New System.Drawing.Point(117, 98)
        OdberatelIDLabel.Name = "OdberatelIDLabel"
        OdberatelIDLabel.Size = New System.Drawing.Size(68, 13)
        OdberatelIDLabel.TabIndex = 3
        OdberatelIDLabel.Text = "odberatel ID:"
        '
        'OdberatelIDTextBox
        '
        Me.OdberatelIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dodaci_list_rezivoBindingSource, "odberatelID", True))
        Me.OdberatelIDTextBox.Location = New System.Drawing.Point(191, 95)
        Me.OdberatelIDTextBox.Name = "OdberatelIDTextBox"
        Me.OdberatelIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OdberatelIDTextBox.TabIndex = 4
        '
        'DatumLabel
        '
        DatumLabel.AutoSize = True
        DatumLabel.Location = New System.Drawing.Point(117, 125)
        DatumLabel.Name = "DatumLabel"
        DatumLabel.Size = New System.Drawing.Size(39, 13)
        DatumLabel.TabIndex = 5
        DatumLabel.Text = "datum:"
        '
        'DatumDateTimePicker
        '
        Me.DatumDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Dodaci_list_rezivoBindingSource, "datum", True))
        Me.DatumDateTimePicker.Location = New System.Drawing.Point(191, 121)
        Me.DatumDateTimePicker.Name = "DatumDateTimePicker"
        Me.DatumDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DatumDateTimePicker.TabIndex = 6
        '
        'Dodaci_list_rezivo_detailyBindingSource
        '
        Me.Dodaci_list_rezivo_detailyBindingSource.DataMember = "dodaciListrezivo_dodacilistrezivodetaily"
        Me.Dodaci_list_rezivo_detailyBindingSource.DataSource = Me.Dodaci_list_rezivoBindingSource
        '
        'Dodaci_list_rezivo_detailyTableAdapter
        '
        Me.Dodaci_list_rezivo_detailyTableAdapter.ClearBeforeFill = True
        '
        'Dodaci_list_rezivo_detailyDataGridView
        '
        Me.Dodaci_list_rezivo_detailyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dodaci_list_rezivo_detailyDataGridView.AutoGenerateColumns = False
        Me.Dodaci_list_rezivo_detailyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dodaci_list_rezivo_detailyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.Dodaci_list_rezivo_detailyDataGridView.DataSource = Me.Dodaci_list_rezivo_detailyBindingSource
        Me.Dodaci_list_rezivo_detailyDataGridView.Location = New System.Drawing.Point(12, 240)
        Me.Dodaci_list_rezivo_detailyDataGridView.Name = "Dodaci_list_rezivo_detailyDataGridView"
        Me.Dodaci_list_rezivo_detailyDataGridView.Size = New System.Drawing.Size(899, 220)
        Me.Dodaci_list_rezivo_detailyDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "rezivoID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "rezivoID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "pocet_ks"
        Me.DataGridViewTextBoxColumn4.HeaderText = "pocet_ks"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "dlzka"
        Me.DataGridViewTextBoxColumn5.HeaderText = "dlzka"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "sirka"
        Me.DataGridViewTextBoxColumn6.HeaderText = "sirka"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "hrubka"
        Me.DataGridViewTextBoxColumn7.HeaderText = "hrubka"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "objem"
        Me.DataGridViewTextBoxColumn8.HeaderText = "objem"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "cena_m3"
        Me.DataGridViewTextBoxColumn9.HeaderText = "cena_m3"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "cenacelkom"
        Me.DataGridViewTextBoxColumn10.HeaderText = "cenacelkom"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'dodaci_list_rezivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 562)
        Me.Controls.Add(Me.Dodaci_list_rezivo_detailyDataGridView)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(OdberatelIDLabel)
        Me.Controls.Add(Me.OdberatelIDTextBox)
        Me.Controls.Add(DatumLabel)
        Me.Controls.Add(Me.DatumDateTimePicker)
        Me.Controls.Add(Me.Dodaci_list_rezivoBindingNavigator)
        Me.Name = "dodaci_list_rezivo"
        Me.Text = "dodaci_list_rezivo"
        CType(Me.Dodaci_list_rezivoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dodaci_list_rezivoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dodaci_list_rezivoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Dodaci_list_rezivoBindingNavigator.ResumeLayout(False)
        Me.Dodaci_list_rezivoBindingNavigator.PerformLayout()
        CType(Me.Dodaci_list_rezivo_detailyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dodaci_list_rezivo_detailyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dodaci_list_rezivoDataSet1 As lesnictvo.dodaci_list_rezivoDataSet1
    Friend WithEvents Dodaci_list_rezivoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dodaci_list_rezivoTableAdapter As lesnictvo.dodaci_list_rezivoDataSet1TableAdapters.dodaci_list_rezivoTableAdapter
    Friend WithEvents TableAdapterManager As lesnictvo.dodaci_list_rezivoDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Dodaci_list_rezivoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Dodaci_list_rezivoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OdberatelIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatumDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dodaci_list_rezivo_detailyTableAdapter As lesnictvo.dodaci_list_rezivoDataSet1TableAdapters.dodaci_list_rezivo_detailyTableAdapter
    Friend WithEvents Dodaci_list_rezivo_detailyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dodaci_list_rezivo_detailyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
