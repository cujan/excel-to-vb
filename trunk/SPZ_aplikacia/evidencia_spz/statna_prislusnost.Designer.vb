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
        Dim SkratkaLabel As System.Windows.Forms.Label
        Dim NazovLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(statna_prislusnost))
        Me.Button1 = New System.Windows.Forms.Button
        Me.uloz = New System.Windows.Forms.Button
        Me.SkratkaTextBox = New System.Windows.Forms.TextBox
        Me.NazovTextBox = New System.Windows.Forms.TextBox
        Me.pridaj = New System.Windows.Forms.Button
        Me.zmaz = New System.Windows.Forms.Button
        Me.SpzDataSet = New evidencia_spz.spzDataSet
        Me.Statna_prislusnostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Statna_prislusnostTableAdapter = New evidencia_spz.spzDataSetTableAdapters.statna_prislusnostTableAdapter
        Me.TableAdapterManager = New evidencia_spz.spzDataSetTableAdapters.TableAdapterManager
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
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        SkratkaLabel = New System.Windows.Forms.Label
        NazovLabel = New System.Windows.Forms.Label
        CType(Me.SpzDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Statna_prislusnostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Statna_prislusnostBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Statna_prislusnostBindingNavigator.SuspendLayout()
        CType(Me.Statna_prislusnostDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SkratkaLabel
        '
        SkratkaLabel.AutoSize = True
        SkratkaLabel.Location = New System.Drawing.Point(281, 37)
        SkratkaLabel.Name = "SkratkaLabel"
        SkratkaLabel.Size = New System.Drawing.Size(44, 13)
        SkratkaLabel.TabIndex = 6
        SkratkaLabel.Text = "Skratka"
        '
        'NazovLabel
        '
        NazovLabel.AutoSize = True
        NazovLabel.Location = New System.Drawing.Point(449, 37)
        NazovLabel.Name = "NazovLabel"
        NazovLabel.Size = New System.Drawing.Size(38, 13)
        NazovLabel.TabIndex = 8
        NazovLabel.Text = "Názov"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(493, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
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
        Me.NazovTextBox.Size = New System.Drawing.Size(97, 20)
        Me.NazovTextBox.TabIndex = 9
        '
        'pridaj
        '
        Me.pridaj.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.pridaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pridaj.Location = New System.Drawing.Point(250, 5)
        Me.pridaj.Name = "pridaj"
        Me.pridaj.Size = New System.Drawing.Size(75, 23)
        Me.pridaj.TabIndex = 10
        Me.pridaj.Text = "Pridať"
        Me.pridaj.UseVisualStyleBackColor = False
        '
        'zmaz
        '
        Me.zmaz.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.zmaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zmaz.Location = New System.Drawing.Point(331, 5)
        Me.zmaz.Name = "zmaz"
        Me.zmaz.Size = New System.Drawing.Size(75, 23)
        Me.zmaz.TabIndex = 11
        Me.zmaz.Text = "Zmazať"
        Me.zmaz.UseVisualStyleBackColor = False
        '
        'SpzDataSet
        '
        Me.SpzDataSet.DataSetName = "spzDataSet"
        Me.SpzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Statna_prislusnostBindingSource
        '
        Me.Statna_prislusnostBindingSource.DataMember = "statna_prislusnost"
        Me.Statna_prislusnostBindingSource.DataSource = Me.SpzDataSet
        '
        'Statna_prislusnostTableAdapter
        '
        Me.Statna_prislusnostTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.narodnostTableAdapter = Nothing
        Me.TableAdapterManager.statna_prislusnostTableAdapter = Me.Statna_prislusnostTableAdapter
        Me.TableAdapterManager.titul_predTableAdapter = Nothing
        Me.TableAdapterManager.titul_zaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.spzDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vseobecne_udajeTableAdapter = Nothing
        Me.TableAdapterManager.zdruzeniaTableAdapter = Nothing
        '
        'Statna_prislusnostBindingNavigator
        '
        Me.Statna_prislusnostBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Statna_prislusnostBindingNavigator.BindingSource = Me.Statna_prislusnostBindingSource
        Me.Statna_prislusnostBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Statna_prislusnostBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Statna_prislusnostBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Statna_prislusnostBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Statna_prislusnostBindingNavigatorSaveItem})
        Me.Statna_prislusnostBindingNavigator.Location = New System.Drawing.Point(0, 355)
        Me.Statna_prislusnostBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Statna_prislusnostBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Statna_prislusnostBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Statna_prislusnostBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Statna_prislusnostBindingNavigator.Name = "Statna_prislusnostBindingNavigator"
        Me.Statna_prislusnostBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Statna_prislusnostBindingNavigator.Size = New System.Drawing.Size(691, 25)
        Me.Statna_prislusnostBindingNavigator.TabIndex = 12
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
        Me.Statna_prislusnostDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Statna_prislusnostDataGridView.DataSource = Me.Statna_prislusnostBindingSource
        Me.Statna_prislusnostDataGridView.Location = New System.Drawing.Point(192, 76)
        Me.Statna_prislusnostDataGridView.Name = "Statna_prislusnostDataGridView"
        Me.Statna_prislusnostDataGridView.Size = New System.Drawing.Size(398, 220)
        Me.Statna_prislusnostDataGridView.TabIndex = 12
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
        'statna_prislusnost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(691, 380)
        Me.Controls.Add(Me.Statna_prislusnostDataGridView)
        Me.Controls.Add(Me.Statna_prislusnostBindingNavigator)
        Me.Controls.Add(Me.zmaz)
        Me.Controls.Add(Me.pridaj)
        Me.Controls.Add(SkratkaLabel)
        Me.Controls.Add(Me.SkratkaTextBox)
        Me.Controls.Add(NazovLabel)
        Me.Controls.Add(Me.NazovTextBox)
        Me.Controls.Add(Me.uloz)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "statna_prislusnost"
        Me.Text = "statna_prislusnost"
        CType(Me.SpzDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Statna_prislusnostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Statna_prislusnostBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Statna_prislusnostBindingNavigator.ResumeLayout(False)
        Me.Statna_prislusnostBindingNavigator.PerformLayout()
        CType(Me.Statna_prislusnostDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents uloz As System.Windows.Forms.Button
    Friend WithEvents SkratkaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents pridaj As System.Windows.Forms.Button
    Friend WithEvents zmaz As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpzDataSet As evidencia_spz.spzDataSet
    Friend WithEvents Statna_prislusnostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Statna_prislusnostTableAdapter As evidencia_spz.spzDataSetTableAdapters.statna_prislusnostTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.spzDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
