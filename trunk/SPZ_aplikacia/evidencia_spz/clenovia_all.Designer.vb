<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clenovia_all
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clenovia_all))
        Me.All_clenoviaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.All_clenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.All_clenoviaDataSet = New evidencia_spz.all_clenoviaDataSet
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
        Me.All_clenoviaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.All_clenoviaDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ulica = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ulica_cislo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.mesto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.zavriet_kartu_button = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.All_clenoviaTableAdapter = New evidencia_spz.all_clenoviaDataSetTableAdapters.all_clenoviaTableAdapter
        Me.TableAdapterManager = New evidencia_spz.all_clenoviaDataSetTableAdapters.TableAdapterManager
        Me.Label5 = New System.Windows.Forms.Label
        Me.priezviskoTextBox = New System.Windows.Forms.TextBox
        CType(Me.All_clenoviaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.All_clenoviaBindingNavigator.SuspendLayout()
        CType(Me.All_clenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.All_clenoviaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.All_clenoviaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'All_clenoviaBindingNavigator
        '
        Me.All_clenoviaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.All_clenoviaBindingNavigator.BindingSource = Me.All_clenoviaBindingSource
        Me.All_clenoviaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.All_clenoviaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.All_clenoviaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.All_clenoviaBindingNavigatorSaveItem})
        Me.All_clenoviaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.All_clenoviaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.All_clenoviaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.All_clenoviaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.All_clenoviaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.All_clenoviaBindingNavigator.Name = "All_clenoviaBindingNavigator"
        Me.All_clenoviaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.All_clenoviaBindingNavigator.Size = New System.Drawing.Size(786, 25)
        Me.All_clenoviaBindingNavigator.TabIndex = 0
        Me.All_clenoviaBindingNavigator.Text = "BindingNavigator1"
        Me.All_clenoviaBindingNavigator.Visible = False
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
        'All_clenoviaBindingSource
        '
        Me.All_clenoviaBindingSource.DataMember = "all_clenovia"
        Me.All_clenoviaBindingSource.DataSource = Me.All_clenoviaDataSet
        '
        'All_clenoviaDataSet
        '
        Me.All_clenoviaDataSet.DataSetName = "all_clenoviaDataSet"
        Me.All_clenoviaDataSet.EnforceConstraints = False
        Me.All_clenoviaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'All_clenoviaBindingNavigatorSaveItem
        '
        Me.All_clenoviaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.All_clenoviaBindingNavigatorSaveItem.Image = CType(resources.GetObject("All_clenoviaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.All_clenoviaBindingNavigatorSaveItem.Name = "All_clenoviaBindingNavigatorSaveItem"
        Me.All_clenoviaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.All_clenoviaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'All_clenoviaDataGridView
        '
        Me.All_clenoviaDataGridView.AutoGenerateColumns = False
        Me.All_clenoviaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.All_clenoviaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.ulica, Me.ulica_cislo, Me.mesto})
        Me.All_clenoviaDataGridView.DataSource = Me.All_clenoviaBindingSource
        Me.All_clenoviaDataGridView.Location = New System.Drawing.Point(15, 83)
        Me.All_clenoviaDataGridView.Name = "All_clenoviaDataGridView"
        Me.All_clenoviaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.All_clenoviaDataGridView.Size = New System.Drawing.Size(857, 440)
        Me.All_clenoviaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "meno"
        Me.DataGridViewTextBoxColumn2.HeaderText = "meno"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "priezvisko"
        Me.DataGridViewTextBoxColumn3.HeaderText = "priezvisko"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "datum_narodenia"
        Me.DataGridViewTextBoxColumn4.HeaderText = "datum_narodenia"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'ulica
        '
        Me.ulica.DataPropertyName = "ulica"
        Me.ulica.HeaderText = "ulica"
        Me.ulica.Name = "ulica"
        '
        'ulica_cislo
        '
        Me.ulica_cislo.DataPropertyName = "ulica_cislo"
        Me.ulica_cislo.HeaderText = "ulica_cislo"
        Me.ulica_cislo.Name = "ulica_cislo"
        '
        'mesto
        '
        Me.mesto.DataPropertyName = "mesto"
        Me.mesto.HeaderText = "mesto"
        Me.mesto.Name = "mesto"
        '
        'zavriet_kartu_button
        '
        Me.zavriet_kartu_button.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.zavriet_kartu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zavriet_kartu_button.Location = New System.Drawing.Point(332, 16)
        Me.zavriet_kartu_button.Name = "zavriet_kartu_button"
        Me.zavriet_kartu_button.Size = New System.Drawing.Size(82, 23)
        Me.zavriet_kartu_button.TabIndex = 2
        Me.zavriet_kartu_button.Text = "Zavrieť kartu"
        Me.zavriet_kartu_button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(616, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(661, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(420, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Vymazať člena"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(722, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(767, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(606, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(311, 50)
        Me.Panel1.TabIndex = 8
        '
        'All_clenoviaTableAdapter
        '
        Me.All_clenoviaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.all_clenoviaTableAdapter = Me.All_clenoviaTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.all_clenoviaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Rýchle vyhľadávanie podľa priezviska:"
        '
        'priezviskoTextBox
        '
        Me.priezviskoTextBox.Location = New System.Drawing.Point(247, 57)
        Me.priezviskoTextBox.Name = "priezviskoTextBox"
        Me.priezviskoTextBox.Size = New System.Drawing.Size(116, 20)
        Me.priezviskoTextBox.TabIndex = 10
        '
        'clenovia_all
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(974, 535)
        Me.Controls.Add(Me.priezviskoTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.zavriet_kartu_button)
        Me.Controls.Add(Me.All_clenoviaDataGridView)
        Me.Controls.Add(Me.All_clenoviaBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "clenovia_all"
        Me.Text = "Zoznam členov"
        CType(Me.All_clenoviaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.All_clenoviaBindingNavigator.ResumeLayout(False)
        Me.All_clenoviaBindingNavigator.PerformLayout()
        CType(Me.All_clenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.All_clenoviaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.All_clenoviaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents All_clenoviaDataSet As evidencia_spz.all_clenoviaDataSet
    Friend WithEvents All_clenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents All_clenoviaTableAdapter As evidencia_spz.all_clenoviaDataSetTableAdapters.all_clenoviaTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.all_clenoviaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents All_clenoviaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents All_clenoviaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents All_clenoviaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents zavriet_kartu_button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents priezviskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ulica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ulica_cislo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mesto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
