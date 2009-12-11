<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class titul
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(titul))
        Me.TitulDataGridView = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.uloz = New System.Windows.Forms.Button
        Me.SkratkaTextBox = New System.Windows.Forms.TextBox
        Me.NazovTextBox = New System.Windows.Forms.TextBox
        Me.pridaj_titul = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.zmaz = New System.Windows.Forms.Button
        Me.SpzDataSet = New evidencia_spz.spzDataSet
        Me.Titul_predBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Titul_predTableAdapter = New evidencia_spz.spzDataSetTableAdapters.titul_predTableAdapter
        Me.TableAdapterManager = New evidencia_spz.spzDataSetTableAdapters.TableAdapterManager
        Me.Titul_predBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Titul_predBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Titul_predDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.TitulDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpzDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Titul_predBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Titul_predBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Titul_predBindingNavigator.SuspendLayout()
        CType(Me.Titul_predDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitulDataGridView
        '
        Me.TitulDataGridView.AllowUserToAddRows = False
        Me.TitulDataGridView.AllowUserToDeleteRows = False
        Me.TitulDataGridView.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.TitulDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TitulDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TitulDataGridView.Location = New System.Drawing.Point(320, 60)
        Me.TitulDataGridView.Name = "TitulDataGridView"
        Me.TitulDataGridView.ReadOnly = True
        Me.TitulDataGridView.Size = New System.Drawing.Size(228, 268)
        Me.TitulDataGridView.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(493, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Zavrieť podkartu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uloz
        '
        Me.uloz.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.uloz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uloz.Location = New System.Drawing.Point(412, 5)
        Me.uloz.Name = "uloz"
        Me.uloz.Size = New System.Drawing.Size(75, 23)
        Me.uloz.TabIndex = 3
        Me.uloz.Text = "Uložiť"
        Me.uloz.UseVisualStyleBackColor = False
        Me.uloz.Visible = False
        '
        'SkratkaTextBox
        '
        Me.SkratkaTextBox.Location = New System.Drawing.Point(331, 34)
        Me.SkratkaTextBox.Name = "SkratkaTextBox"
        Me.SkratkaTextBox.ReadOnly = True
        Me.SkratkaTextBox.Size = New System.Drawing.Size(75, 20)
        Me.SkratkaTextBox.TabIndex = 7
        '
        'NazovTextBox
        '
        Me.NazovTextBox.Location = New System.Drawing.Point(493, 34)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.ReadOnly = True
        Me.NazovTextBox.Size = New System.Drawing.Size(98, 20)
        Me.NazovTextBox.TabIndex = 9
        '
        'pridaj_titul
        '
        Me.pridaj_titul.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.pridaj_titul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pridaj_titul.Location = New System.Drawing.Point(250, 5)
        Me.pridaj_titul.Name = "pridaj_titul"
        Me.pridaj_titul.Size = New System.Drawing.Size(75, 23)
        Me.pridaj_titul.TabIndex = 10
        Me.pridaj_titul.Text = "Pridať"
        Me.pridaj_titul.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(281, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Skratka"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(449, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Názov"
        '
        'zmaz
        '
        Me.zmaz.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.zmaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zmaz.Location = New System.Drawing.Point(331, 5)
        Me.zmaz.Name = "zmaz"
        Me.zmaz.Size = New System.Drawing.Size(75, 23)
        Me.zmaz.TabIndex = 13
        Me.zmaz.Text = "Zmazať"
        Me.zmaz.UseVisualStyleBackColor = False
        '
        'SpzDataSet
        '
        Me.SpzDataSet.DataSetName = "spzDataSet"
        Me.SpzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Titul_predBindingSource
        '
        Me.Titul_predBindingSource.DataMember = "titul_pred"
        Me.Titul_predBindingSource.DataSource = Me.SpzDataSet
        '
        'Titul_predTableAdapter
        '
        Me.Titul_predTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ICO_clenoviaTableAdapter = Nothing
        Me.TableAdapterManager.narodnostTableAdapter = Nothing
        Me.TableAdapterManager.statna_prislusnostTableAdapter = Nothing
        Me.TableAdapterManager.titul_predTableAdapter = Me.Titul_predTableAdapter
        Me.TableAdapterManager.titul_zaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.spzDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vseobecne_udajeTableAdapter = Nothing
        Me.TableAdapterManager.zdruzeniaTableAdapter = Nothing
        '
        'Titul_predBindingNavigator
        '
        Me.Titul_predBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Titul_predBindingNavigator.BindingSource = Me.Titul_predBindingSource
        Me.Titul_predBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Titul_predBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Titul_predBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Titul_predBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Titul_predBindingNavigatorSaveItem})
        Me.Titul_predBindingNavigator.Location = New System.Drawing.Point(0, 463)
        Me.Titul_predBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Titul_predBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Titul_predBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Titul_predBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Titul_predBindingNavigator.Name = "Titul_predBindingNavigator"
        Me.Titul_predBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Titul_predBindingNavigator.Size = New System.Drawing.Size(766, 25)
        Me.Titul_predBindingNavigator.TabIndex = 14
        Me.Titul_predBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Titul_predBindingNavigatorSaveItem
        '
        Me.Titul_predBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Titul_predBindingNavigatorSaveItem.Image = CType(resources.GetObject("Titul_predBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Titul_predBindingNavigatorSaveItem.Name = "Titul_predBindingNavigatorSaveItem"
        Me.Titul_predBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Titul_predBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Titul_predDataGridView
        '
        Me.Titul_predDataGridView.AutoGenerateColumns = False
        Me.Titul_predDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Titul_predDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Titul_predDataGridView.DataSource = Me.Titul_predBindingSource
        Me.Titul_predDataGridView.Location = New System.Drawing.Point(225, 93)
        Me.Titul_predDataGridView.Name = "Titul_predDataGridView"
        Me.Titul_predDataGridView.Size = New System.Drawing.Size(345, 220)
        Me.Titul_predDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "skratka"
        Me.DataGridViewTextBoxColumn4.HeaderText = "skratka"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nazov"
        Me.DataGridViewTextBoxColumn5.HeaderText = "nazov"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'titul
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(766, 488)
        Me.Controls.Add(Me.Titul_predDataGridView)
        Me.Controls.Add(Me.Titul_predBindingNavigator)
        Me.Controls.Add(Me.zmaz)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pridaj_titul)
        Me.Controls.Add(Me.SkratkaTextBox)
        Me.Controls.Add(Me.NazovTextBox)
        Me.Controls.Add(Me.uloz)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TitulDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "titul"
        Me.Text = "titul"
        CType(Me.TitulDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpzDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Titul_predBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Titul_predBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Titul_predBindingNavigator.ResumeLayout(False)
        Me.Titul_predBindingNavigator.PerformLayout()
        CType(Me.Titul_predDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitulDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents uloz As System.Windows.Forms.Button
    Friend WithEvents SkratkaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents pridaj_titul As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents zmaz As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpzDataSet As evidencia_spz.spzDataSet
    Friend WithEvents Titul_predBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Titul_predTableAdapter As evidencia_spz.spzDataSetTableAdapters.titul_predTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.spzDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Titul_predBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Titul_predBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Titul_predDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
