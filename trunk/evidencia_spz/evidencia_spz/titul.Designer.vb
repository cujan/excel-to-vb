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
        Me.TitulDataSet1 = New evidencia_spz.titulDataSet1
        Me.TitulBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TitulTableAdapter = New evidencia_spz.titulDataSet1TableAdapters.titulTableAdapter
        Me.TableAdapterManager = New evidencia_spz.titulDataSet1TableAdapters.TableAdapterManager
        Me.TitulBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TitulBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TitulDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.uloz = New System.Windows.Forms.Button
        Me.SkratkaTextBox = New System.Windows.Forms.TextBox
        Me.NazovTextBox = New System.Windows.Forms.TextBox
        Me.pridaj_titul = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.zmaz = New System.Windows.Forms.Button
        CType(Me.TitulDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitulBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitulBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitulBindingNavigator.SuspendLayout()
        CType(Me.TitulDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitulDataSet1
        '
        Me.TitulDataSet1.DataSetName = "titulDataSet1"
        Me.TitulDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TitulBindingSource
        '
        Me.TitulBindingSource.DataMember = "titul"
        Me.TitulBindingSource.DataSource = Me.TitulDataSet1
        '
        'TitulTableAdapter
        '
        Me.TitulTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.titulTableAdapter = Me.TitulTableAdapter
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.titulDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TitulBindingNavigator
        '
        Me.TitulBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TitulBindingNavigator.BindingSource = Me.TitulBindingSource
        Me.TitulBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TitulBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TitulBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TitulBindingNavigatorSaveItem})
        Me.TitulBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TitulBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TitulBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TitulBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TitulBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TitulBindingNavigator.Name = "TitulBindingNavigator"
        Me.TitulBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TitulBindingNavigator.Size = New System.Drawing.Size(766, 25)
        Me.TitulBindingNavigator.TabIndex = 0
        Me.TitulBindingNavigator.Text = "BindingNavigator1"
        Me.TitulBindingNavigator.Visible = False
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
        'TitulBindingNavigatorSaveItem
        '
        Me.TitulBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TitulBindingNavigatorSaveItem.Image = CType(resources.GetObject("TitulBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TitulBindingNavigatorSaveItem.Name = "TitulBindingNavigatorSaveItem"
        Me.TitulBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TitulBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TitulDataGridView
        '
        Me.TitulDataGridView.AllowUserToAddRows = False
        Me.TitulDataGridView.AllowUserToDeleteRows = False
        Me.TitulDataGridView.AutoGenerateColumns = False
        Me.TitulDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TitulDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TitulDataGridView.DataSource = Me.TitulBindingSource
        Me.TitulDataGridView.Location = New System.Drawing.Point(318, 67)
        Me.TitulDataGridView.Name = "TitulDataGridView"
        Me.TitulDataGridView.ReadOnly = True
        Me.TitulDataGridView.Size = New System.Drawing.Size(214, 123)
        Me.TitulDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "skratka"
        Me.DataGridViewTextBoxColumn2.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Skratka"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nazov"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Názov"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
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
        Me.uloz.Text = "Ulož"
        Me.uloz.UseVisualStyleBackColor = False
        Me.uloz.Visible = False
        '
        'SkratkaTextBox
        '
        Me.SkratkaTextBox.Location = New System.Drawing.Point(318, 39)
        Me.SkratkaTextBox.Name = "SkratkaTextBox"
        Me.SkratkaTextBox.ReadOnly = True
        Me.SkratkaTextBox.Size = New System.Drawing.Size(81, 20)
        Me.SkratkaTextBox.TabIndex = 7
        '
        'NazovTextBox
        '
        Me.NazovTextBox.Location = New System.Drawing.Point(480, 39)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.ReadOnly = True
        Me.NazovTextBox.Size = New System.Drawing.Size(81, 20)
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
        Me.pridaj_titul.Text = "Pridaj titul"
        Me.pridaj_titul.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(268, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Skratka"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(436, 42)
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
        Me.zmaz.Text = "Zmaž titul"
        Me.zmaz.UseVisualStyleBackColor = False
        '
        'titul
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(766, 488)
        Me.Controls.Add(Me.zmaz)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pridaj_titul)
        Me.Controls.Add(Me.SkratkaTextBox)
        Me.Controls.Add(Me.NazovTextBox)
        Me.Controls.Add(Me.uloz)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TitulDataGridView)
        Me.Controls.Add(Me.TitulBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "titul"
        Me.Text = "titul"
        CType(Me.TitulDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitulBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitulBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitulBindingNavigator.ResumeLayout(False)
        Me.TitulBindingNavigator.PerformLayout()
        CType(Me.TitulDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitulDataSet1 As evidencia_spz.titulDataSet1
    Friend WithEvents TitulBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TitulTableAdapter As evidencia_spz.titulDataSet1TableAdapters.titulTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.titulDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TitulBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TitulBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
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
End Class
