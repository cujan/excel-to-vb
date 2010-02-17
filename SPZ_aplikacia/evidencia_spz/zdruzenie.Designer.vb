<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zdruzenie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(zdruzenie))
        Me.ZdruzeniaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.ZdruzeniaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpzDataSet = New evidencia_spz.spzDataSet
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
        Me.ZdruzeniaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ZdruzeniaDataGridView = New System.Windows.Forms.DataGridView
        Me.zavriet_kartu_button = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ZdruzeniaTableAdapter = New evidencia_spz.spzDataSetTableAdapters.zdruzeniaTableAdapter
        Me.TableAdapterManager = New evidencia_spz.spzDataSetTableAdapters.TableAdapterManager
        Me.Label3 = New System.Windows.Forms.Label
        Me.nazovTextBox = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.NazovDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SidloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IcoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PredsedaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PolovnyhospodarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ZdruzeniaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ZdruzeniaBindingNavigator.SuspendLayout()
        CType(Me.ZdruzeniaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpzDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzeniaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ZdruzeniaBindingNavigator
        '
        Me.ZdruzeniaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ZdruzeniaBindingNavigator.BindingSource = Me.ZdruzeniaBindingSource
        Me.ZdruzeniaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ZdruzeniaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ZdruzeniaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ZdruzeniaBindingNavigatorSaveItem})
        Me.ZdruzeniaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ZdruzeniaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ZdruzeniaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ZdruzeniaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ZdruzeniaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ZdruzeniaBindingNavigator.Name = "ZdruzeniaBindingNavigator"
        Me.ZdruzeniaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ZdruzeniaBindingNavigator.Size = New System.Drawing.Size(961, 25)
        Me.ZdruzeniaBindingNavigator.TabIndex = 0
        Me.ZdruzeniaBindingNavigator.Text = "BindingNavigator1"
        Me.ZdruzeniaBindingNavigator.Visible = False
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
        'ZdruzeniaBindingSource
        '
        Me.ZdruzeniaBindingSource.DataMember = "zdruzenia"
        Me.ZdruzeniaBindingSource.DataSource = Me.SpzDataSet
        '
        'SpzDataSet
        '
        Me.SpzDataSet.DataSetName = "spzDataSet"
        Me.SpzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
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
        'ZdruzeniaBindingNavigatorSaveItem
        '
        Me.ZdruzeniaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ZdruzeniaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ZdruzeniaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ZdruzeniaBindingNavigatorSaveItem.Name = "ZdruzeniaBindingNavigatorSaveItem"
        Me.ZdruzeniaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ZdruzeniaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ZdruzeniaDataGridView
        '
        Me.ZdruzeniaDataGridView.AllowUserToAddRows = False
        Me.ZdruzeniaDataGridView.AllowUserToDeleteRows = False
        Me.ZdruzeniaDataGridView.AllowUserToOrderColumns = True
        Me.ZdruzeniaDataGridView.AutoGenerateColumns = False
        Me.ZdruzeniaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ZdruzeniaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NazovDataGridViewTextBoxColumn, Me.SidloDataGridViewTextBoxColumn, Me.IcoDataGridViewTextBoxColumn, Me.DicDataGridViewTextBoxColumn, Me.PredsedaDataGridViewTextBoxColumn, Me.PolovnyhospodarDataGridViewTextBoxColumn})
        Me.ZdruzeniaDataGridView.DataSource = Me.ZdruzeniaBindingSource
        Me.ZdruzeniaDataGridView.Location = New System.Drawing.Point(12, 80)
        Me.ZdruzeniaDataGridView.Name = "ZdruzeniaDataGridView"
        Me.ZdruzeniaDataGridView.ReadOnly = True
        Me.ZdruzeniaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ZdruzeniaDataGridView.Size = New System.Drawing.Size(645, 363)
        Me.ZdruzeniaDataGridView.TabIndex = 1
        '
        'zavriet_kartu_button
        '
        Me.zavriet_kartu_button.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.zavriet_kartu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zavriet_kartu_button.Location = New System.Drawing.Point(336, 15)
        Me.zavriet_kartu_button.Name = "zavriet_kartu_button"
        Me.zavriet_kartu_button.Size = New System.Drawing.Size(79, 23)
        Me.zavriet_kartu_button.TabIndex = 2
        Me.zavriet_kartu_button.Text = "Zavrieť kartu"
        Me.zavriet_kartu_button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(663, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(727, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(421, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Vymazať združenie"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ZdruzeniaTableAdapter
        '
        Me.ZdruzeniaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._123_clenoviaTableAdapter = Nothing
        Me.TableAdapterManager._456_clenoviaTableAdapter = Nothing
        Me.TableAdapterManager.all_clenoviaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ciselnik_obceTableAdapter = Nothing
        Me.TableAdapterManager.narodnostTableAdapter = Nothing
        Me.TableAdapterManager.rokyTableAdapter = Nothing
        Me.TableAdapterManager.statna_prislusnostTableAdapter = Nothing
        Me.TableAdapterManager.titul_predTableAdapter = Nothing
        Me.TableAdapterManager.titul_zaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.spzDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vseobecne_udajeTableAdapter = Nothing
        Me.TableAdapterManager.zdruzeniaTableAdapter = Me.ZdruzeniaTableAdapter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Rýchle vyhľadávanie podľa názvu združenia:"
        '
        'nazovTextBox
        '
        Me.nazovTextBox.Location = New System.Drawing.Point(279, 54)
        Me.nazovTextBox.Name = "nazovTextBox"
        Me.nazovTextBox.Size = New System.Drawing.Size(111, 20)
        Me.nazovTextBox.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(632, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(217, 49)
        Me.Panel1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(755, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "chovatelska_oblast"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(668, 124)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'NazovDataGridViewTextBoxColumn
        '
        Me.NazovDataGridViewTextBoxColumn.DataPropertyName = "nazov"
        Me.NazovDataGridViewTextBoxColumn.HeaderText = "nazov"
        Me.NazovDataGridViewTextBoxColumn.Name = "NazovDataGridViewTextBoxColumn"
        Me.NazovDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SidloDataGridViewTextBoxColumn
        '
        Me.SidloDataGridViewTextBoxColumn.DataPropertyName = "sidlo"
        Me.SidloDataGridViewTextBoxColumn.HeaderText = "sidlo"
        Me.SidloDataGridViewTextBoxColumn.Name = "SidloDataGridViewTextBoxColumn"
        Me.SidloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IcoDataGridViewTextBoxColumn
        '
        Me.IcoDataGridViewTextBoxColumn.DataPropertyName = "ico"
        Me.IcoDataGridViewTextBoxColumn.HeaderText = "ico"
        Me.IcoDataGridViewTextBoxColumn.Name = "IcoDataGridViewTextBoxColumn"
        Me.IcoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DicDataGridViewTextBoxColumn
        '
        Me.DicDataGridViewTextBoxColumn.DataPropertyName = "dic"
        Me.DicDataGridViewTextBoxColumn.HeaderText = "dic"
        Me.DicDataGridViewTextBoxColumn.Name = "DicDataGridViewTextBoxColumn"
        Me.DicDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PredsedaDataGridViewTextBoxColumn
        '
        Me.PredsedaDataGridViewTextBoxColumn.DataPropertyName = "predseda"
        Me.PredsedaDataGridViewTextBoxColumn.HeaderText = "predseda"
        Me.PredsedaDataGridViewTextBoxColumn.Name = "PredsedaDataGridViewTextBoxColumn"
        Me.PredsedaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PolovnyhospodarDataGridViewTextBoxColumn
        '
        Me.PolovnyhospodarDataGridViewTextBoxColumn.DataPropertyName = "polovny_hospodar"
        Me.PolovnyhospodarDataGridViewTextBoxColumn.HeaderText = "polovny_hospodar"
        Me.PolovnyhospodarDataGridViewTextBoxColumn.Name = "PolovnyhospodarDataGridViewTextBoxColumn"
        Me.PolovnyhospodarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'zdruzenie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(961, 602)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.nazovTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.zavriet_kartu_button)
        Me.Controls.Add(Me.ZdruzeniaDataGridView)
        Me.Controls.Add(Me.ZdruzeniaBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "zdruzenie"
        Me.Text = "Zoznam združení"
        CType(Me.ZdruzeniaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ZdruzeniaBindingNavigator.ResumeLayout(False)
        Me.ZdruzeniaBindingNavigator.PerformLayout()
        CType(Me.ZdruzeniaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpzDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzeniaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SpzDataSet As evidencia_spz.spzDataSet
    Friend WithEvents ZdruzeniaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZdruzeniaTableAdapter As evidencia_spz.spzDataSetTableAdapters.zdruzeniaTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.spzDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ZdruzeniaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ZdruzeniaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ZdruzeniaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents zavriet_kartu_button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents NazovDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SidloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IcoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DicDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PredsedaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PolovnyhospodarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
