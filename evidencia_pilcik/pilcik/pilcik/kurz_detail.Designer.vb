<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kurz_detail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(kurz_detail))
        Dim NazovLabel As System.Windows.Forms.Label
        Dim Zaciatok_kurzuLabel As System.Windows.Forms.Label
        Dim Koniec_kurzuLabel As System.Windows.Forms.Label
        Dim TypLabel As System.Windows.Forms.Label
        Dim Miesto_konaniaLabel As System.Windows.Forms.Label
        Dim PocetLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Me.PilcikdbDataSet = New pilcik.pilcikdbDataSet
        Me.KurzBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KurzTableAdapter = New pilcik.pilcikdbDataSetTableAdapters.kurzTableAdapter
        Me.TableAdapterManager = New pilcik.pilcikdbDataSetTableAdapters.TableAdapterManager
        Me.KurzBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.KurzBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.KurzBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KurzComboDataSet = New pilcik.kurzComboDataSet
        Me.Clenovia_kurzuDataSet = New pilcik.clenovia_kurzuDataSet
        Me.Clenovia_kurzuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Clenovia_kurzuTableAdapter = New pilcik.clenovia_kurzuDataSetTableAdapters.clenovia_kurzuTableAdapter
        Me.TableAdapterManager2 = New pilcik.clenovia_kurzuDataSetTableAdapters.TableAdapterManager
        Me.Clenovia_kurzuDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.pridaj_clenaButton = New System.Windows.Forms.Button
        Me.KurzTableAdapter1 = New pilcik.kurzComboDataSetTableAdapters.kurzTableAdapter
        Me.TableAdapterManager1 = New pilcik.kurzComboDataSetTableAdapters.TableAdapterManager
        Me.NazovTextBox = New System.Windows.Forms.TextBox
        Me.Zaciatok_kurzuDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Koniec_kurzuDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.TypTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_konaniaTextBox = New System.Windows.Forms.TextBox
        Me.PocetTextBox = New System.Windows.Forms.TextBox
        Me.IdTextBox = New System.Windows.Forms.TextBox
        NazovLabel = New System.Windows.Forms.Label
        Zaciatok_kurzuLabel = New System.Windows.Forms.Label
        Koniec_kurzuLabel = New System.Windows.Forms.Label
        TypLabel = New System.Windows.Forms.Label
        Miesto_konaniaLabel = New System.Windows.Forms.Label
        PocetLabel = New System.Windows.Forms.Label
        IdLabel = New System.Windows.Forms.Label
        CType(Me.PilcikdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KurzBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KurzBindingNavigator.SuspendLayout()
        CType(Me.KurzBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KurzComboDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clenovia_kurzuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clenovia_kurzuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clenovia_kurzuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PilcikdbDataSet
        '
        Me.PilcikdbDataSet.DataSetName = "pilcikdbDataSet"
        Me.PilcikdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KurzBindingSource
        '
        Me.KurzBindingSource.DataMember = "kurz"
        Me.KurzBindingSource.DataSource = Me.PilcikdbDataSet
        '
        'KurzTableAdapter
        '
        Me.KurzTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clenovia_kurzuTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.osobaTableAdapter = Nothing
        Me.TableAdapterManager.skusobna_komisiaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pilcik.pilcikdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KurzBindingNavigator
        '
        Me.KurzBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.KurzBindingNavigator.BindingSource = Me.KurzBindingSource
        Me.KurzBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.KurzBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.KurzBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.KurzBindingNavigatorSaveItem})
        Me.KurzBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.KurzBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.KurzBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.KurzBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.KurzBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.KurzBindingNavigator.Name = "KurzBindingNavigator"
        Me.KurzBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.KurzBindingNavigator.Size = New System.Drawing.Size(1093, 25)
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
        'KurzBindingNavigatorSaveItem
        '
        Me.KurzBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KurzBindingNavigatorSaveItem.Image = CType(resources.GetObject("KurzBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.KurzBindingNavigatorSaveItem.Name = "KurzBindingNavigatorSaveItem"
        Me.KurzBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.KurzBindingNavigatorSaveItem.Text = "Save Data"
        '
        'KurzBindingSource1
        '
        Me.KurzBindingSource1.DataMember = "kurz"
        Me.KurzBindingSource1.DataSource = Me.KurzComboDataSet
        '
        'KurzComboDataSet
        '
        Me.KurzComboDataSet.DataSetName = "kurzComboDataSet"
        Me.KurzComboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Clenovia_kurzuDataSet
        '
        Me.Clenovia_kurzuDataSet.DataSetName = "clenovia_kurzuDataSet"
        Me.Clenovia_kurzuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Clenovia_kurzuBindingSource
        '
        Me.Clenovia_kurzuBindingSource.DataMember = "clenovia_kurzu"
        Me.Clenovia_kurzuBindingSource.DataSource = Me.Clenovia_kurzuDataSet
        '
        'Clenovia_kurzuTableAdapter
        '
        Me.Clenovia_kurzuTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = pilcik.clenovia_kurzuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Clenovia_kurzuDataGridView
        '
        Me.Clenovia_kurzuDataGridView.AllowUserToAddRows = False
        Me.Clenovia_kurzuDataGridView.AllowUserToDeleteRows = False
        Me.Clenovia_kurzuDataGridView.AutoGenerateColumns = False
        Me.Clenovia_kurzuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Clenovia_kurzuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6})
        Me.Clenovia_kurzuDataGridView.DataSource = Me.Clenovia_kurzuBindingSource
        Me.Clenovia_kurzuDataGridView.Location = New System.Drawing.Point(42, 400)
        Me.Clenovia_kurzuDataGridView.Name = "Clenovia_kurzuDataGridView"
        Me.Clenovia_kurzuDataGridView.ReadOnly = True
        Me.Clenovia_kurzuDataGridView.Size = New System.Drawing.Size(792, 220)
        Me.Clenovia_kurzuDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "priezvisko"
        Me.DataGridViewTextBoxColumn4.HeaderText = "priezvisko"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "meno"
        Me.DataGridViewTextBoxColumn6.HeaderText = "meno"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(569, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pridaj_clenaButton
        '
        Me.pridaj_clenaButton.Location = New System.Drawing.Point(42, 371)
        Me.pridaj_clenaButton.Name = "pridaj_clenaButton"
        Me.pridaj_clenaButton.Size = New System.Drawing.Size(75, 23)
        Me.pridaj_clenaButton.TabIndex = 15
        Me.pridaj_clenaButton.Text = "Pridaj člena"
        Me.pridaj_clenaButton.UseVisualStyleBackColor = True
        '
        'KurzTableAdapter1
        '
        Me.KurzTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.kurzTableAdapter = Me.KurzTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = pilcik.kurzComboDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NazovLabel
        '
        NazovLabel.AutoSize = True
        NazovLabel.Location = New System.Drawing.Point(88, 91)
        NazovLabel.Name = "NazovLabel"
        NazovLabel.Size = New System.Drawing.Size(39, 13)
        NazovLabel.TabIndex = 15
        NazovLabel.Text = "nazov:"
        '
        'NazovTextBox
        '
        Me.NazovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "nazov", True))
        Me.NazovTextBox.Location = New System.Drawing.Point(175, 88)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NazovTextBox.TabIndex = 16
        '
        'Zaciatok_kurzuLabel
        '
        Zaciatok_kurzuLabel.AutoSize = True
        Zaciatok_kurzuLabel.Location = New System.Drawing.Point(88, 118)
        Zaciatok_kurzuLabel.Name = "Zaciatok_kurzuLabel"
        Zaciatok_kurzuLabel.Size = New System.Drawing.Size(79, 13)
        Zaciatok_kurzuLabel.TabIndex = 17
        Zaciatok_kurzuLabel.Text = "zaciatok kurzu:"
        '
        'Zaciatok_kurzuDateTimePicker
        '
        Me.Zaciatok_kurzuDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.KurzBindingSource, "zaciatok_kurzu", True))
        Me.Zaciatok_kurzuDateTimePicker.Location = New System.Drawing.Point(175, 114)
        Me.Zaciatok_kurzuDateTimePicker.Name = "Zaciatok_kurzuDateTimePicker"
        Me.Zaciatok_kurzuDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Zaciatok_kurzuDateTimePicker.TabIndex = 18
        '
        'Koniec_kurzuLabel
        '
        Koniec_kurzuLabel.AutoSize = True
        Koniec_kurzuLabel.Location = New System.Drawing.Point(88, 144)
        Koniec_kurzuLabel.Name = "Koniec_kurzuLabel"
        Koniec_kurzuLabel.Size = New System.Drawing.Size(71, 13)
        Koniec_kurzuLabel.TabIndex = 19
        Koniec_kurzuLabel.Text = "koniec kurzu:"
        '
        'Koniec_kurzuDateTimePicker
        '
        Me.Koniec_kurzuDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.KurzBindingSource, "koniec_kurzu", True))
        Me.Koniec_kurzuDateTimePicker.Location = New System.Drawing.Point(175, 140)
        Me.Koniec_kurzuDateTimePicker.Name = "Koniec_kurzuDateTimePicker"
        Me.Koniec_kurzuDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Koniec_kurzuDateTimePicker.TabIndex = 20
        '
        'TypLabel
        '
        TypLabel.AutoSize = True
        TypLabel.Location = New System.Drawing.Point(88, 169)
        TypLabel.Name = "TypLabel"
        TypLabel.Size = New System.Drawing.Size(24, 13)
        TypLabel.TabIndex = 21
        TypLabel.Text = "typ:"
        '
        'TypTextBox
        '
        Me.TypTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "typ", True))
        Me.TypTextBox.Location = New System.Drawing.Point(175, 166)
        Me.TypTextBox.Name = "TypTextBox"
        Me.TypTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TypTextBox.TabIndex = 22
        '
        'Miesto_konaniaLabel
        '
        Miesto_konaniaLabel.AutoSize = True
        Miesto_konaniaLabel.Location = New System.Drawing.Point(88, 195)
        Miesto_konaniaLabel.Name = "Miesto_konaniaLabel"
        Miesto_konaniaLabel.Size = New System.Drawing.Size(81, 13)
        Miesto_konaniaLabel.TabIndex = 23
        Miesto_konaniaLabel.Text = "miesto konania:"
        '
        'Miesto_konaniaTextBox
        '
        Me.Miesto_konaniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "miesto_konania", True))
        Me.Miesto_konaniaTextBox.Location = New System.Drawing.Point(175, 192)
        Me.Miesto_konaniaTextBox.Name = "Miesto_konaniaTextBox"
        Me.Miesto_konaniaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Miesto_konaniaTextBox.TabIndex = 24
        '
        'PocetLabel
        '
        PocetLabel.AutoSize = True
        PocetLabel.Location = New System.Drawing.Point(88, 221)
        PocetLabel.Name = "PocetLabel"
        PocetLabel.Size = New System.Drawing.Size(37, 13)
        PocetLabel.TabIndex = 25
        PocetLabel.Text = "pocet:"
        '
        'PocetTextBox
        '
        Me.PocetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "pocet", True))
        Me.PocetTextBox.Location = New System.Drawing.Point(175, 218)
        Me.PocetTextBox.Name = "PocetTextBox"
        Me.PocetTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PocetTextBox.TabIndex = 26
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(88, 247)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 27
        IdLabel.Text = "id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(175, 244)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 28
        '
        'kurz_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 702)
        Me.Controls.Add(NazovLabel)
        Me.Controls.Add(Me.NazovTextBox)
        Me.Controls.Add(Zaciatok_kurzuLabel)
        Me.Controls.Add(Me.Zaciatok_kurzuDateTimePicker)
        Me.Controls.Add(Koniec_kurzuLabel)
        Me.Controls.Add(Me.Koniec_kurzuDateTimePicker)
        Me.Controls.Add(TypLabel)
        Me.Controls.Add(Me.TypTextBox)
        Me.Controls.Add(Miesto_konaniaLabel)
        Me.Controls.Add(Me.Miesto_konaniaTextBox)
        Me.Controls.Add(PocetLabel)
        Me.Controls.Add(Me.PocetTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.pridaj_clenaButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Clenovia_kurzuDataGridView)
        Me.Controls.Add(Me.KurzBindingNavigator)
        Me.Name = "kurz_detail"
        Me.Text = "kurz_detail"
        CType(Me.PilcikdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KurzBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KurzBindingNavigator.ResumeLayout(False)
        Me.KurzBindingNavigator.PerformLayout()
        CType(Me.KurzBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KurzComboDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clenovia_kurzuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clenovia_kurzuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clenovia_kurzuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents KurzComboDataSet As pilcik.kurzComboDataSet
    Friend WithEvents KurzBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents KurzTableAdapter1 As pilcik.kurzComboDataSetTableAdapters.kurzTableAdapter
    Friend WithEvents TableAdapterManager1 As pilcik.kurzComboDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Clenovia_kurzuDataSet As pilcik.clenovia_kurzuDataSet
    Friend WithEvents Clenovia_kurzuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Clenovia_kurzuTableAdapter As pilcik.clenovia_kurzuDataSetTableAdapters.clenovia_kurzuTableAdapter
    Friend WithEvents TableAdapterManager2 As pilcik.clenovia_kurzuDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Clenovia_kurzuDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pridaj_clenaButton As System.Windows.Forms.Button
    Friend WithEvents NazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zaciatok_kurzuDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Koniec_kurzuDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TypTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_konaniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PocetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
End Class
