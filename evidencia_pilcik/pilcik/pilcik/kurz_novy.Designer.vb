<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kurz_novy
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
        Dim NazovLabel As System.Windows.Forms.Label
        Dim Zaciatok_kurzuLabel As System.Windows.Forms.Label
        Dim Koniec_kurzuLabel As System.Windows.Forms.Label
        Dim TypLabel As System.Windows.Forms.Label
        Dim Miesto_konaniaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(kurz_novy))
        Me.KurzBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.KurzBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PilcikdbDataSet = New pilcik.pilcikdbDataSet
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
        Me.KurzBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.KurzDataGridView = New System.Windows.Forms.DataGridView
        Me.NazovTextBox = New System.Windows.Forms.TextBox
        Me.Zaciatok_kurzuDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Koniec_kurzuDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ulozButton = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Miesto_konaniaTextBox = New System.Windows.Forms.TextBox
        Me.TypComboBox = New System.Windows.Forms.ComboBox
        Me.KurzTableAdapter = New pilcik.pilcikdbDataSetTableAdapters.kurzTableAdapter
        Me.TableAdapterManager = New pilcik.pilcikdbDataSetTableAdapters.TableAdapterManager
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.typ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.miesto_konania = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        NazovLabel = New System.Windows.Forms.Label
        Zaciatok_kurzuLabel = New System.Windows.Forms.Label
        Koniec_kurzuLabel = New System.Windows.Forms.Label
        TypLabel = New System.Windows.Forms.Label
        Miesto_konaniaLabel = New System.Windows.Forms.Label
        CType(Me.KurzBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KurzBindingNavigator.SuspendLayout()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PilcikdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KurzDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NazovLabel
        '
        NazovLabel.AutoSize = True
        NazovLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        NazovLabel.Location = New System.Drawing.Point(120, 64)
        NazovLabel.Name = "NazovLabel"
        NazovLabel.Size = New System.Drawing.Size(82, 13)
        NazovLabel.TabIndex = 4
        NazovLabel.Text = "Názov kurzu:"
        '
        'Zaciatok_kurzuLabel
        '
        Zaciatok_kurzuLabel.AutoSize = True
        Zaciatok_kurzuLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Zaciatok_kurzuLabel.Location = New System.Drawing.Point(120, 91)
        Zaciatok_kurzuLabel.Name = "Zaciatok_kurzuLabel"
        Zaciatok_kurzuLabel.Size = New System.Drawing.Size(96, 13)
        Zaciatok_kurzuLabel.TabIndex = 6
        Zaciatok_kurzuLabel.Text = "Začiatok kurzu:"
        '
        'Koniec_kurzuLabel
        '
        Koniec_kurzuLabel.AutoSize = True
        Koniec_kurzuLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Koniec_kurzuLabel.Location = New System.Drawing.Point(120, 117)
        Koniec_kurzuLabel.Name = "Koniec_kurzuLabel"
        Koniec_kurzuLabel.Size = New System.Drawing.Size(85, 13)
        Koniec_kurzuLabel.TabIndex = 8
        Koniec_kurzuLabel.Text = "Koniec kurzu:"
        '
        'TypLabel
        '
        TypLabel.AutoSize = True
        TypLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        TypLabel.Location = New System.Drawing.Point(120, 144)
        TypLabel.Name = "TypLabel"
        TypLabel.Size = New System.Drawing.Size(32, 13)
        TypLabel.TabIndex = 13
        TypLabel.Text = "Typ:"
        '
        'Miesto_konaniaLabel
        '
        Miesto_konaniaLabel.AutoSize = True
        Miesto_konaniaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Miesto_konaniaLabel.Location = New System.Drawing.Point(120, 185)
        Miesto_konaniaLabel.Name = "Miesto_konaniaLabel"
        Miesto_konaniaLabel.Size = New System.Drawing.Size(97, 13)
        Miesto_konaniaLabel.TabIndex = 14
        Miesto_konaniaLabel.Text = "Miesto konania:"
        '
        'KurzBindingNavigator
        '
        Me.KurzBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.KurzBindingNavigator.BindingSource = Me.KurzBindingSource
        Me.KurzBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.KurzBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.KurzBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KurzBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.KurzBindingNavigatorSaveItem})
        Me.KurzBindingNavigator.Location = New System.Drawing.Point(0, 686)
        Me.KurzBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.KurzBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.KurzBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.KurzBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.KurzBindingNavigator.Name = "KurzBindingNavigator"
        Me.KurzBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.KurzBindingNavigator.Size = New System.Drawing.Size(1127, 25)
        Me.KurzBindingNavigator.TabIndex = 0
        Me.KurzBindingNavigator.Text = "BindingNavigator1"
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
        'KurzBindingSource
        '
        Me.KurzBindingSource.DataMember = "kurz"
        Me.KurzBindingSource.DataSource = Me.PilcikdbDataSet
        '
        'PilcikdbDataSet
        '
        Me.PilcikdbDataSet.DataSetName = "pilcikdbDataSet"
        Me.PilcikdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 21)
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
        'KurzBindingNavigatorSaveItem
        '
        Me.KurzBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KurzBindingNavigatorSaveItem.Image = CType(resources.GetObject("KurzBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.KurzBindingNavigatorSaveItem.Name = "KurzBindingNavigatorSaveItem"
        Me.KurzBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.KurzBindingNavigatorSaveItem.Text = "Save Data"
        '
        'KurzDataGridView
        '
        Me.KurzDataGridView.AllowUserToAddRows = False
        Me.KurzDataGridView.AllowUserToDeleteRows = False
        Me.KurzDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KurzDataGridView.AutoGenerateColumns = False
        Me.KurzDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KurzDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.typ, Me.miesto_konania})
        Me.KurzDataGridView.DataSource = Me.KurzBindingSource
        Me.KurzDataGridView.Location = New System.Drawing.Point(14, 221)
        Me.KurzDataGridView.Name = "KurzDataGridView"
        Me.KurzDataGridView.ReadOnly = True
        Me.KurzDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.KurzDataGridView.Size = New System.Drawing.Size(1099, 462)
        Me.KurzDataGridView.TabIndex = 1
        '
        'NazovTextBox
        '
        Me.NazovTextBox.Location = New System.Drawing.Point(219, 61)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.Size = New System.Drawing.Size(233, 20)
        Me.NazovTextBox.TabIndex = 0
        '
        'Zaciatok_kurzuDateTimePicker
        '
        Me.Zaciatok_kurzuDateTimePicker.Checked = False
        Me.Zaciatok_kurzuDateTimePicker.Location = New System.Drawing.Point(219, 87)
        Me.Zaciatok_kurzuDateTimePicker.Name = "Zaciatok_kurzuDateTimePicker"
        Me.Zaciatok_kurzuDateTimePicker.ShowCheckBox = True
        Me.Zaciatok_kurzuDateTimePicker.Size = New System.Drawing.Size(233, 20)
        Me.Zaciatok_kurzuDateTimePicker.TabIndex = 1
        '
        'Koniec_kurzuDateTimePicker
        '
        Me.Koniec_kurzuDateTimePicker.Checked = False
        Me.Koniec_kurzuDateTimePicker.Location = New System.Drawing.Point(219, 113)
        Me.Koniec_kurzuDateTimePicker.Name = "Koniec_kurzuDateTimePicker"
        Me.Koniec_kurzuDateTimePicker.ShowCheckBox = True
        Me.Koniec_kurzuDateTimePicker.Size = New System.Drawing.Size(233, 20)
        Me.Koniec_kurzuDateTimePicker.TabIndex = 2
        '
        'ulozButton
        '
        Me.ulozButton.Location = New System.Drawing.Point(850, 81)
        Me.ulozButton.Name = "ulozButton"
        Me.ulozButton.Size = New System.Drawing.Size(87, 23)
        Me.ulozButton.TabIndex = 5
        Me.ulozButton.Text = "Ulož"
        Me.ulozButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(850, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Zmaž kurz"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(630, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(681, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Label2"
        '
        'Miesto_konaniaTextBox
        '
        Me.Miesto_konaniaTextBox.Location = New System.Drawing.Point(222, 182)
        Me.Miesto_konaniaTextBox.Name = "Miesto_konaniaTextBox"
        Me.Miesto_konaniaTextBox.Size = New System.Drawing.Size(230, 20)
        Me.Miesto_konaniaTextBox.TabIndex = 4
        Me.Miesto_konaniaTextBox.Text = "SŠ Prešov, ŠH Cemjata"
        '
        'TypComboBox
        '
        Me.TypComboBox.FormattingEnabled = True
        Me.TypComboBox.Items.AddRange(New Object() {"základný", "školenie"})
        Me.TypComboBox.Location = New System.Drawing.Point(219, 146)
        Me.TypComboBox.Name = "TypComboBox"
        Me.TypComboBox.Size = New System.Drawing.Size(140, 21)
        Me.TypComboBox.TabIndex = 3
        '
        'KurzTableAdapter
        '
        Me.KurzTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.kurzTableAdapter = Me.KurzTableAdapter

        Me.TableAdapterManager.skusobna_komisiaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pilcik.pilcikdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nazov"
        Me.DataGridViewTextBoxColumn5.HeaderText = "nazov"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "zaciatok_kurzu"
        Me.DataGridViewTextBoxColumn6.HeaderText = "zaciatok_kurzu"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "koniec_kurzu"
        Me.DataGridViewTextBoxColumn7.HeaderText = "koniec_kurzu"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'typ
        '
        Me.typ.DataPropertyName = "typ"
        Me.typ.HeaderText = "typ"
        Me.typ.Name = "typ"
        Me.typ.ReadOnly = True
        '
        'miesto_konania
        '
        Me.miesto_konania.DataPropertyName = "miesto_konania"
        Me.miesto_konania.HeaderText = "miesto_konania"
        Me.miesto_konania.Name = "miesto_konania"
        Me.miesto_konania.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(599, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Evidencia kurzov"
        '
        'kurz_novy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 711)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TypComboBox)
        Me.Controls.Add(Miesto_konaniaLabel)
        Me.Controls.Add(Me.Miesto_konaniaTextBox)
        Me.Controls.Add(TypLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ulozButton)
        Me.Controls.Add(NazovLabel)
        Me.Controls.Add(Me.NazovTextBox)
        Me.Controls.Add(Zaciatok_kurzuLabel)
        Me.Controls.Add(Me.Zaciatok_kurzuDateTimePicker)
        Me.Controls.Add(Koniec_kurzuLabel)
        Me.Controls.Add(Me.Koniec_kurzuDateTimePicker)
        Me.Controls.Add(Me.KurzDataGridView)
        Me.Controls.Add(Me.KurzBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Name = "kurz_novy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "kurz"
        CType(Me.KurzBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KurzBindingNavigator.ResumeLayout(False)
        Me.KurzBindingNavigator.PerformLayout()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PilcikdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KurzDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PilcikdbDataSet As pilcik.pilcikdbDataSet
    Friend WithEvents KurzBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KurzTableAdapter As pilcik.pilcikdbDataSetTableAdapters.kurzTableAdapter
    Friend WithEvents TableAdapterManager As pilcik.pilcikdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KurzBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents KurzBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents KurzDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zaciatok_kurzuDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Koniec_kurzuDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ulozButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Miesto_konaniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TypComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents typ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents miesto_konania As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
