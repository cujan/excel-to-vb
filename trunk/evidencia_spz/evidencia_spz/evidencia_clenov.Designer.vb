<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class evidencia_clenov
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(evidencia_clenov))
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ClenoviaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.ClenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Prehlad_clenovDataSet = New evidencia_spz.prehlad_clenovDataSet
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
        Me.ClenoviaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ClenoviaDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hladajTextBox1 = New System.Windows.Forms.TextBox
        Me.ClenoviaTableAdapter = New evidencia_spz.prehlad_clenovDataSetTableAdapters.clenoviaTableAdapter
        Me.TableAdapterManager = New evidencia_spz.prehlad_clenovDataSetTableAdapters.TableAdapterManager
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ZdruzenieDataSet = New evidencia_spz.zdruzenieDataSet
        Me.ZdruzenieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZdruzenieTableAdapter = New evidencia_spz.zdruzenieDataSetTableAdapters.zdruzenieTableAdapter
        CType(Me.ClenoviaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClenoviaBindingNavigator.SuspendLayout()
        CType(Me.ClenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Prehlad_clenovDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClenoviaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzenieDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzenieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(127, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(402, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Vymazať člena"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label1.Location = New System.Drawing.Point(662, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "N/A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(721, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "N/A"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(556, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ID vybraného člena"
        Me.Label3.Visible = False
        '
        'ClenoviaBindingNavigator
        '
        Me.ClenoviaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClenoviaBindingNavigator.BindingSource = Me.ClenoviaBindingSource
        Me.ClenoviaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClenoviaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClenoviaBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClenoviaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClenoviaBindingNavigatorSaveItem})
        Me.ClenoviaBindingNavigator.Location = New System.Drawing.Point(0, 399)
        Me.ClenoviaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClenoviaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClenoviaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClenoviaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClenoviaBindingNavigator.Name = "ClenoviaBindingNavigator"
        Me.ClenoviaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClenoviaBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.ClenoviaBindingNavigator.TabIndex = 10
        Me.ClenoviaBindingNavigator.Text = "BindingNavigator1"
        Me.ClenoviaBindingNavigator.Visible = False
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
        'ClenoviaBindingSource
        '
        Me.ClenoviaBindingSource.DataMember = "clenovia"
        Me.ClenoviaBindingSource.DataSource = Me.Prehlad_clenovDataSet
        '
        'Prehlad_clenovDataSet
        '
        Me.Prehlad_clenovDataSet.DataSetName = "prehlad_clenovDataSet"
        Me.Prehlad_clenovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ClenoviaBindingNavigatorSaveItem
        '
        Me.ClenoviaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClenoviaBindingNavigatorSaveItem.Enabled = False
        Me.ClenoviaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClenoviaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClenoviaBindingNavigatorSaveItem.Name = "ClenoviaBindingNavigatorSaveItem"
        Me.ClenoviaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClenoviaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ClenoviaDataGridView
        '
        Me.ClenoviaDataGridView.AllowUserToAddRows = False
        Me.ClenoviaDataGridView.AllowUserToDeleteRows = False
        Me.ClenoviaDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ClenoviaDataGridView.AutoGenerateColumns = False
        Me.ClenoviaDataGridView.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.ClenoviaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ClenoviaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClenoviaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn56})
        Me.ClenoviaDataGridView.DataSource = Me.ClenoviaBindingSource
        Me.ClenoviaDataGridView.Location = New System.Drawing.Point(81, 61)
        Me.ClenoviaDataGridView.Name = "ClenoviaDataGridView"
        Me.ClenoviaDataGridView.ReadOnly = True
        Me.ClenoviaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ClenoviaDataGridView.Size = New System.Drawing.Size(494, 351)
        Me.ClenoviaDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "meno"
        Me.DataGridViewTextBoxColumn47.HeaderText = "Meno"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "priezvisko"
        Me.DataGridViewTextBoxColumn48.HeaderText = "Priezvisko"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "rodne_cislo"
        Me.DataGridViewTextBoxColumn49.HeaderText = "RČ"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "Zdruzenie"
        Me.DataGridViewTextBoxColumn56.FillWeight = 140.0!
        Me.DataGridViewTextBoxColumn56.HeaderText = "Združenie"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.ReadOnly = True
        Me.DataGridViewTextBoxColumn56.Width = 140
        '
        'hladajTextBox1
        '
        Me.hladajTextBox1.Location = New System.Drawing.Point(255, 35)
        Me.hladajTextBox1.Name = "hladajTextBox1"
        Me.hladajTextBox1.Size = New System.Drawing.Size(274, 20)
        Me.hladajTextBox1.TabIndex = 11
        '
        'ClenoviaTableAdapter
        '
        Me.ClenoviaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.prehlad_clenovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(125, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Vyhľadať priezvisko:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ZdruzenieBindingSource
        Me.ComboBox1.DisplayMember = "nazov"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(559, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 13
        Me.ComboBox1.ValueMember = "ID"
        '
        'ZdruzenieDataSet
        '
        Me.ZdruzenieDataSet.DataSetName = "zdruzenieDataSet"
        Me.ZdruzenieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ZdruzenieBindingSource
        '
        Me.ZdruzenieBindingSource.DataMember = "zdruzenie"
        Me.ZdruzenieBindingSource.DataSource = Me.ZdruzenieDataSet
        '
        'ZdruzenieTableAdapter
        '
        Me.ZdruzenieTableAdapter.ClearBeforeFill = True
        '
        'evidencia_clenov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(792, 424)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.hladajTextBox1)
        Me.Controls.Add(Me.ClenoviaDataGridView)
        Me.Controls.Add(Me.ClenoviaBindingNavigator)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "evidencia_clenov"
        Me.Text = "evidencia_clenov"
        CType(Me.ClenoviaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClenoviaBindingNavigator.ResumeLayout(False)
        Me.ClenoviaBindingNavigator.PerformLayout()
        CType(Me.ClenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Prehlad_clenovDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClenoviaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzenieDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzenieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub



    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn88 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prehlad_clenovDataSet As evidencia_spz.prehlad_clenovDataSet
    Friend WithEvents ClenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClenoviaTableAdapter As evidencia_spz.prehlad_clenovDataSetTableAdapters.clenoviaTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.prehlad_clenovDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClenoviaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ClenoviaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClenoviaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents hladajTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ZdruzenieDataSet As evidencia_spz.zdruzenieDataSet
    Friend WithEvents ZdruzenieBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZdruzenieTableAdapter As evidencia_spz.zdruzenieDataSetTableAdapters.zdruzenieTableAdapter
End Class
