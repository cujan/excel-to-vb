<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prehlad_zdruzeni
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(prehlad_zdruzeni))
        Me.prehlad_clenov_splitter = New System.Windows.Forms.SplitContainer
        Me.karta_clena_tlac_button = New System.Windows.Forms.Button
        Me.button_report_zoznam_clenov = New System.Windows.Forms.Button
        Me.zavriet_kartu = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ZdruzenieDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ZdruzenieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZdruzenieDataSet = New evidencia_spz.zdruzenieDataSet
        Me.ZdruzenieTableAdapter = New evidencia_spz.zdruzenieDataSetTableAdapters.zdruzenieTableAdapter
        Me.TableAdapterManager = New evidencia_spz.zdruzenieDataSetTableAdapters.TableAdapterManager
        Me.ZdruzenieBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ZdruzenieBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.prehlad_clenov_splitter.Panel1.SuspendLayout()
        Me.prehlad_clenov_splitter.Panel2.SuspendLayout()
        Me.prehlad_clenov_splitter.SuspendLayout()
        CType(Me.ZdruzenieDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzenieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzenieDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzenieBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ZdruzenieBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'prehlad_clenov_splitter
        '
        Me.prehlad_clenov_splitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.prehlad_clenov_splitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.prehlad_clenov_splitter.Location = New System.Drawing.Point(0, 0)
        Me.prehlad_clenov_splitter.Name = "prehlad_clenov_splitter"
        Me.prehlad_clenov_splitter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'prehlad_clenov_splitter.Panel1
        '
        Me.prehlad_clenov_splitter.Panel1.Controls.Add(Me.karta_clena_tlac_button)
        Me.prehlad_clenov_splitter.Panel1.Controls.Add(Me.button_report_zoznam_clenov)
        Me.prehlad_clenov_splitter.Panel1.Controls.Add(Me.zavriet_kartu)
        '
        'prehlad_clenov_splitter.Panel2
        '
        Me.prehlad_clenov_splitter.Panel2.Controls.Add(Me.Label3)
        Me.prehlad_clenov_splitter.Panel2.Controls.Add(Me.Label2)
        Me.prehlad_clenov_splitter.Panel2.Controls.Add(Me.Label1)
        Me.prehlad_clenov_splitter.Panel2.Controls.Add(Me.Button1)
        Me.prehlad_clenov_splitter.Panel2.Controls.Add(Me.ZdruzenieDataGridView)
        Me.prehlad_clenov_splitter.Size = New System.Drawing.Size(762, 400)
        Me.prehlad_clenov_splitter.SplitterDistance = 48
        Me.prehlad_clenov_splitter.TabIndex = 0
        '
        'karta_clena_tlac_button
        '
        Me.karta_clena_tlac_button.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.karta_clena_tlac_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.karta_clena_tlac_button.Location = New System.Drawing.Point(300, 20)
        Me.karta_clena_tlac_button.Name = "karta_clena_tlac_button"
        Me.karta_clena_tlac_button.Size = New System.Drawing.Size(139, 23)
        Me.karta_clena_tlac_button.TabIndex = 9
        Me.karta_clena_tlac_button.Text = "Vytvoriť karty združení"
        Me.karta_clena_tlac_button.UseVisualStyleBackColor = False
        '
        'button_report_zoznam_clenov
        '
        Me.button_report_zoznam_clenov.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.button_report_zoznam_clenov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_report_zoznam_clenov.Location = New System.Drawing.Point(127, 20)
        Me.button_report_zoznam_clenov.Name = "button_report_zoznam_clenov"
        Me.button_report_zoznam_clenov.Size = New System.Drawing.Size(167, 23)
        Me.button_report_zoznam_clenov.TabIndex = 8
        Me.button_report_zoznam_clenov.Text = "Vytvoriť tlačovú formu zoznamu členov"
        Me.button_report_zoznam_clenov.UseVisualStyleBackColor = False
        '
        'zavriet_kartu
        '
        Me.zavriet_kartu.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.zavriet_kartu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zavriet_kartu.Location = New System.Drawing.Point(445, 20)
        Me.zavriet_kartu.Name = "zavriet_kartu"
        Me.zavriet_kartu.Size = New System.Drawing.Size(82, 23)
        Me.zavriet_kartu.TabIndex = 0
        Me.zavriet_kartu.Text = "Zavrieť kartu"
        Me.zavriet_kartu.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(544, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID vybraného združenia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(723, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "N/A"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(669, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "N/A"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(127, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(400, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Vymazať združenie"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ZdruzenieDataGridView
        '
        Me.ZdruzenieDataGridView.AllowUserToAddRows = False
        Me.ZdruzenieDataGridView.AllowUserToDeleteRows = False
        Me.ZdruzenieDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZdruzenieDataGridView.AutoGenerateColumns = False
        Me.ZdruzenieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ZdruzenieDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.ZdruzenieDataGridView.DataSource = Me.ZdruzenieBindingSource
        Me.ZdruzenieDataGridView.Location = New System.Drawing.Point(12, 34)
        Me.ZdruzenieDataGridView.Name = "ZdruzenieDataGridView"
        Me.ZdruzenieDataGridView.ReadOnly = True
        Me.ZdruzenieDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ZdruzenieDataGridView.Size = New System.Drawing.Size(726, 302)
        Me.ZdruzenieDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nazov"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Názov"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "sidlo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sídlo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "predseda"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Predseda"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "polovnicky_hospodar"
        Me.DataGridViewTextBoxColumn6.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Poľovnícky hospodár"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ico"
        Me.DataGridViewTextBoxColumn8.HeaderText = "IČO"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "dic"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DIČ"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'ZdruzenieBindingSource
        '
        Me.ZdruzenieBindingSource.DataMember = "zdruzenie"
        Me.ZdruzenieBindingSource.DataSource = Me.ZdruzenieDataSet
        '
        'ZdruzenieDataSet
        '
        Me.ZdruzenieDataSet.DataSetName = "zdruzenieDataSet"
        Me.ZdruzenieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ZdruzenieTableAdapter
        '
        Me.ZdruzenieTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.zdruzenieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.zdruzenieTableAdapter = Me.ZdruzenieTableAdapter
        '
        'ZdruzenieBindingNavigator
        '
        Me.ZdruzenieBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ZdruzenieBindingNavigator.BindingSource = Me.ZdruzenieBindingSource
        Me.ZdruzenieBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ZdruzenieBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ZdruzenieBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ZdruzenieBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ZdruzenieBindingNavigatorSaveItem})
        Me.ZdruzenieBindingNavigator.Location = New System.Drawing.Point(0, 375)
        Me.ZdruzenieBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ZdruzenieBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ZdruzenieBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ZdruzenieBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ZdruzenieBindingNavigator.Name = "ZdruzenieBindingNavigator"
        Me.ZdruzenieBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ZdruzenieBindingNavigator.Size = New System.Drawing.Size(762, 25)
        Me.ZdruzenieBindingNavigator.TabIndex = 1
        Me.ZdruzenieBindingNavigator.Text = "BindingNavigator1"
        Me.ZdruzenieBindingNavigator.Visible = False
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
        'ZdruzenieBindingNavigatorSaveItem
        '
        Me.ZdruzenieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ZdruzenieBindingNavigatorSaveItem.Image = CType(resources.GetObject("ZdruzenieBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ZdruzenieBindingNavigatorSaveItem.Name = "ZdruzenieBindingNavigatorSaveItem"
        Me.ZdruzenieBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ZdruzenieBindingNavigatorSaveItem.Text = "Save Data"
        '
        'prehlad_zdruzeni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(762, 400)
        Me.Controls.Add(Me.ZdruzenieBindingNavigator)
        Me.Controls.Add(Me.prehlad_clenov_splitter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "prehlad_zdruzeni"
        Me.Text = "prehlad_clenov"
        Me.prehlad_clenov_splitter.Panel1.ResumeLayout(False)
        Me.prehlad_clenov_splitter.Panel2.ResumeLayout(False)
        Me.prehlad_clenov_splitter.Panel2.PerformLayout()
        Me.prehlad_clenov_splitter.ResumeLayout(False)
        CType(Me.ZdruzenieDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzenieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzenieDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzenieBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ZdruzenieBindingNavigator.ResumeLayout(False)
        Me.ZdruzenieBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents prehlad_clenov_splitter As System.Windows.Forms.SplitContainer
    Friend WithEvents zavriet_kartu As System.Windows.Forms.Button
    Friend WithEvents karta_clena_tlac_button As System.Windows.Forms.Button
    Friend WithEvents button_report_zoznam_clenov As System.Windows.Forms.Button
    Friend WithEvents ZdruzenieDataSet As evidencia_spz.zdruzenieDataSet
    Friend WithEvents ZdruzenieBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZdruzenieTableAdapter As evidencia_spz.zdruzenieDataSetTableAdapters.zdruzenieTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.zdruzenieDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ZdruzenieBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ZdruzenieBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ZdruzenieDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
