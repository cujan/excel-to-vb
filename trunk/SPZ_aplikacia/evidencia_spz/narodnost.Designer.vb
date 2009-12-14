<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class narodnost
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(narodnost))
        Me.SkratkaTextBox = New System.Windows.Forms.TextBox
        Me.NazovTextBox = New System.Windows.Forms.TextBox
        Me.koniec = New System.Windows.Forms.Button
        Me.pridajButton = New System.Windows.Forms.Button
        Me.ulozButton = New System.Windows.Forms.Button
        Me.zmazButton = New System.Windows.Forms.Button
        Me.SpzDataSet = New evidencia_spz.spzDataSet
        Me.NarodnostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NarodnostTableAdapter = New evidencia_spz.spzDataSetTableAdapters.narodnostTableAdapter
        Me.TableAdapterManager = New evidencia_spz.spzDataSetTableAdapters.TableAdapterManager
        Me.NarodnostBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.NarodnostBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.NarodnostDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        SkratkaLabel = New System.Windows.Forms.Label
        NazovLabel = New System.Windows.Forms.Label
        CType(Me.SpzDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NarodnostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NarodnostBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NarodnostBindingNavigator.SuspendLayout()
        CType(Me.NarodnostDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SkratkaLabel
        '
        SkratkaLabel.AutoSize = True
        SkratkaLabel.Location = New System.Drawing.Point(281, 37)
        SkratkaLabel.Name = "SkratkaLabel"
        SkratkaLabel.Size = New System.Drawing.Size(44, 13)
        SkratkaLabel.TabIndex = 4
        SkratkaLabel.Text = "Skratka"
        '
        'NazovLabel
        '
        NazovLabel.AutoSize = True
        NazovLabel.Location = New System.Drawing.Point(449, 37)
        NazovLabel.Name = "NazovLabel"
        NazovLabel.Size = New System.Drawing.Size(38, 13)
        NazovLabel.TabIndex = 6
        NazovLabel.Text = "Názov"
        '
        'SkratkaTextBox
        '
        Me.SkratkaTextBox.Location = New System.Drawing.Point(331, 34)
        Me.SkratkaTextBox.Name = "SkratkaTextBox"
        Me.SkratkaTextBox.ReadOnly = True
        Me.SkratkaTextBox.Size = New System.Drawing.Size(75, 20)
        Me.SkratkaTextBox.TabIndex = 5
        '
        'NazovTextBox
        '
        Me.NazovTextBox.Location = New System.Drawing.Point(493, 34)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.ReadOnly = True
        Me.NazovTextBox.Size = New System.Drawing.Size(97, 20)
        Me.NazovTextBox.TabIndex = 7
        '
        'koniec
        '
        Me.koniec.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.koniec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.koniec.Location = New System.Drawing.Point(493, 5)
        Me.koniec.Name = "koniec"
        Me.koniec.Size = New System.Drawing.Size(97, 23)
        Me.koniec.TabIndex = 8
        Me.koniec.Text = "Zavrieť podkartu"
        Me.koniec.UseVisualStyleBackColor = False
        '
        'pridajButton
        '
        Me.pridajButton.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.pridajButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pridajButton.Location = New System.Drawing.Point(250, 5)
        Me.pridajButton.Name = "pridajButton"
        Me.pridajButton.Size = New System.Drawing.Size(75, 23)
        Me.pridajButton.TabIndex = 9
        Me.pridajButton.Text = "Pridať"
        Me.pridajButton.UseVisualStyleBackColor = False
        '
        'ulozButton
        '
        Me.ulozButton.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ulozButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ulozButton.Location = New System.Drawing.Point(412, 5)
        Me.ulozButton.Name = "ulozButton"
        Me.ulozButton.Size = New System.Drawing.Size(75, 23)
        Me.ulozButton.TabIndex = 10
        Me.ulozButton.Text = "Uložiť"
        Me.ulozButton.UseVisualStyleBackColor = False
        Me.ulozButton.Visible = False
        '
        'zmazButton
        '
        Me.zmazButton.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.zmazButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zmazButton.Location = New System.Drawing.Point(331, 5)
        Me.zmazButton.Name = "zmazButton"
        Me.zmazButton.Size = New System.Drawing.Size(75, 23)
        Me.zmazButton.TabIndex = 11
        Me.zmazButton.Text = "Zmazať"
        Me.zmazButton.UseVisualStyleBackColor = False
        '
        'SpzDataSet
        '
        Me.SpzDataSet.DataSetName = "spzDataSet"
        Me.SpzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NarodnostBindingSource
        '
        Me.NarodnostBindingSource.DataMember = "narodnost"
        Me.NarodnostBindingSource.DataSource = Me.SpzDataSet
        '
        'NarodnostTableAdapter
        '
        Me.NarodnostTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.narodnostTableAdapter = Me.NarodnostTableAdapter
        Me.TableAdapterManager.statna_prislusnostTableAdapter = Nothing
        Me.TableAdapterManager.titul_predTableAdapter = Nothing
        Me.TableAdapterManager.titul_zaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.spzDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vseobecne_udajeTableAdapter = Nothing
        Me.TableAdapterManager.zdruzeniaTableAdapter = Nothing
        '
        'NarodnostBindingNavigator
        '
        Me.NarodnostBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.NarodnostBindingNavigator.BindingSource = Me.NarodnostBindingSource
        Me.NarodnostBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.NarodnostBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.NarodnostBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NarodnostBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.NarodnostBindingNavigatorSaveItem})
        Me.NarodnostBindingNavigator.Location = New System.Drawing.Point(0, 412)
        Me.NarodnostBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.NarodnostBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.NarodnostBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.NarodnostBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.NarodnostBindingNavigator.Name = "NarodnostBindingNavigator"
        Me.NarodnostBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.NarodnostBindingNavigator.Size = New System.Drawing.Size(779, 25)
        Me.NarodnostBindingNavigator.TabIndex = 12
        Me.NarodnostBindingNavigator.Text = "BindingNavigator1"
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
        'NarodnostBindingNavigatorSaveItem
        '
        Me.NarodnostBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NarodnostBindingNavigatorSaveItem.Image = CType(resources.GetObject("NarodnostBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.NarodnostBindingNavigatorSaveItem.Name = "NarodnostBindingNavigatorSaveItem"
        Me.NarodnostBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.NarodnostBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NarodnostDataGridView
        '
        Me.NarodnostDataGridView.AutoGenerateColumns = False
        Me.NarodnostDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NarodnostDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.NarodnostDataGridView.DataSource = Me.NarodnostBindingSource
        Me.NarodnostDataGridView.Location = New System.Drawing.Point(239, 104)
        Me.NarodnostDataGridView.Name = "NarodnostDataGridView"
        Me.NarodnostDataGridView.Size = New System.Drawing.Size(358, 220)
        Me.NarodnostDataGridView.TabIndex = 12
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
        'narodnost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(779, 437)
        Me.Controls.Add(Me.NarodnostDataGridView)
        Me.Controls.Add(Me.NarodnostBindingNavigator)
        Me.Controls.Add(Me.zmazButton)
        Me.Controls.Add(Me.ulozButton)
        Me.Controls.Add(Me.pridajButton)
        Me.Controls.Add(Me.koniec)
        Me.Controls.Add(SkratkaLabel)
        Me.Controls.Add(Me.SkratkaTextBox)
        Me.Controls.Add(NazovLabel)
        Me.Controls.Add(Me.NazovTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "narodnost"
        Me.Text = "narodnost"
        CType(Me.SpzDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NarodnostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NarodnostBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NarodnostBindingNavigator.ResumeLayout(False)
        Me.NarodnostBindingNavigator.PerformLayout()
        CType(Me.NarodnostDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SkratkaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents koniec As System.Windows.Forms.Button
    Friend WithEvents pridajButton As System.Windows.Forms.Button
    Friend WithEvents ulozButton As System.Windows.Forms.Button
    Friend WithEvents zmazButton As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpzDataSet As evidencia_spz.spzDataSet
    Friend WithEvents NarodnostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NarodnostTableAdapter As evidencia_spz.spzDataSetTableAdapters.narodnostTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.spzDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NarodnostBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents NarodnostBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NarodnostDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
