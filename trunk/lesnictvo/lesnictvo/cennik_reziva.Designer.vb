<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cennik_reziva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cennik_reziva))
        Dim KodLabel As System.Windows.Forms.Label
        Dim Druh_rezivaLabel As System.Windows.Forms.Label
        Dim CenaLabel As System.Windows.Forms.Label
        Me.RezivoDataSet1 = New lesnictvo.rezivoDataSet1
        Me.Druh_rezivaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Druh_rezivaTableAdapter = New lesnictvo.rezivoDataSet1TableAdapters.druh_rezivaTableAdapter
        Me.TableAdapterManager = New lesnictvo.rezivoDataSet1TableAdapters.TableAdapterManager
        Me.Druh_rezivaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Druh_rezivaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Druh_rezivaDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KodTextBox = New System.Windows.Forms.TextBox
        Me.Druh_rezivaTextBox = New System.Windows.Forms.TextBox
        Me.CenaTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        KodLabel = New System.Windows.Forms.Label
        Druh_rezivaLabel = New System.Windows.Forms.Label
        CenaLabel = New System.Windows.Forms.Label
        CType(Me.RezivoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Druh_rezivaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Druh_rezivaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Druh_rezivaBindingNavigator.SuspendLayout()
        CType(Me.Druh_rezivaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RezivoDataSet1
        '
        Me.RezivoDataSet1.DataSetName = "rezivoDataSet1"
        Me.RezivoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Druh_rezivaBindingSource
        '
        Me.Druh_rezivaBindingSource.DataMember = "druh_reziva"
        Me.Druh_rezivaBindingSource.DataSource = Me.RezivoDataSet1
        '
        'Druh_rezivaTableAdapter
        '
        Me.Druh_rezivaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.druh_rezivaTableAdapter = Me.Druh_rezivaTableAdapter
        Me.TableAdapterManager.UpdateOrder = lesnictvo.rezivoDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Druh_rezivaBindingNavigator
        '
        Me.Druh_rezivaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Druh_rezivaBindingNavigator.BindingSource = Me.Druh_rezivaBindingSource
        Me.Druh_rezivaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Druh_rezivaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Druh_rezivaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Druh_rezivaBindingNavigatorSaveItem})
        Me.Druh_rezivaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Druh_rezivaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Druh_rezivaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Druh_rezivaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Druh_rezivaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Druh_rezivaBindingNavigator.Name = "Druh_rezivaBindingNavigator"
        Me.Druh_rezivaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Druh_rezivaBindingNavigator.Size = New System.Drawing.Size(727, 25)
        Me.Druh_rezivaBindingNavigator.TabIndex = 0
        Me.Druh_rezivaBindingNavigator.Text = "BindingNavigator1"
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
        'Druh_rezivaBindingNavigatorSaveItem
        '
        Me.Druh_rezivaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Druh_rezivaBindingNavigatorSaveItem.Image = CType(resources.GetObject("Druh_rezivaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Druh_rezivaBindingNavigatorSaveItem.Name = "Druh_rezivaBindingNavigatorSaveItem"
        Me.Druh_rezivaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Druh_rezivaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Druh_rezivaDataGridView
        '
        Me.Druh_rezivaDataGridView.AutoGenerateColumns = False
        Me.Druh_rezivaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Druh_rezivaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Druh_rezivaDataGridView.DataSource = Me.Druh_rezivaBindingSource
        Me.Druh_rezivaDataGridView.Location = New System.Drawing.Point(15, 175)
        Me.Druh_rezivaDataGridView.Name = "Druh_rezivaDataGridView"
        Me.Druh_rezivaDataGridView.Size = New System.Drawing.Size(553, 220)
        Me.Druh_rezivaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "kod"
        Me.DataGridViewTextBoxColumn2.HeaderText = "kod"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "druh_reziva"
        Me.DataGridViewTextBoxColumn3.HeaderText = "druh_reziva"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cena"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cena"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'KodLabel
        '
        KodLabel.AutoSize = True
        KodLabel.Location = New System.Drawing.Point(12, 78)
        KodLabel.Name = "KodLabel"
        KodLabel.Size = New System.Drawing.Size(28, 13)
        KodLabel.TabIndex = 4
        KodLabel.Text = "kod:"
        '
        'KodTextBox
        '
        Me.KodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Druh_rezivaBindingSource, "kod", True))
        Me.KodTextBox.Location = New System.Drawing.Point(46, 71)
        Me.KodTextBox.Name = "KodTextBox"
        Me.KodTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KodTextBox.TabIndex = 5
        '
        'Druh_rezivaLabel
        '
        Druh_rezivaLabel.AutoSize = True
        Druh_rezivaLabel.Location = New System.Drawing.Point(152, 74)
        Druh_rezivaLabel.Name = "Druh_rezivaLabel"
        Druh_rezivaLabel.Size = New System.Drawing.Size(62, 13)
        Druh_rezivaLabel.TabIndex = 6
        Druh_rezivaLabel.Text = "druh reziva:"
        '
        'Druh_rezivaTextBox
        '
        Me.Druh_rezivaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Druh_rezivaBindingSource, "druh_reziva", True))
        Me.Druh_rezivaTextBox.Location = New System.Drawing.Point(220, 71)
        Me.Druh_rezivaTextBox.Name = "Druh_rezivaTextBox"
        Me.Druh_rezivaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Druh_rezivaTextBox.TabIndex = 7
        '
        'CenaLabel
        '
        CenaLabel.AutoSize = True
        CenaLabel.Location = New System.Drawing.Point(326, 74)
        CenaLabel.Name = "CenaLabel"
        CenaLabel.Size = New System.Drawing.Size(34, 13)
        CenaLabel.TabIndex = 8
        CenaLabel.Text = "cena:"
        '
        'CenaTextBox
        '
        Me.CenaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Druh_rezivaBindingSource, "cena", True))
        Me.CenaTextBox.Location = New System.Drawing.Point(366, 71)
        Me.CenaTextBox.Name = "CenaTextBox"
        Me.CenaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CenaTextBox.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(577, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Pridaj"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(577, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Uprav"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(577, 104)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Ulož"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(577, 134)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Zmaž"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cennik_reziva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 407)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(KodLabel)
        Me.Controls.Add(Me.KodTextBox)
        Me.Controls.Add(Druh_rezivaLabel)
        Me.Controls.Add(Me.Druh_rezivaTextBox)
        Me.Controls.Add(CenaLabel)
        Me.Controls.Add(Me.CenaTextBox)
        Me.Controls.Add(Me.Druh_rezivaDataGridView)
        Me.Controls.Add(Me.Druh_rezivaBindingNavigator)
        Me.Name = "cennik_reziva"
        Me.Text = "cennik_reziva"
        CType(Me.RezivoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Druh_rezivaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Druh_rezivaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Druh_rezivaBindingNavigator.ResumeLayout(False)
        Me.Druh_rezivaBindingNavigator.PerformLayout()
        CType(Me.Druh_rezivaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RezivoDataSet1 As lesnictvo.rezivoDataSet1
    Friend WithEvents Druh_rezivaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Druh_rezivaTableAdapter As lesnictvo.rezivoDataSet1TableAdapters.druh_rezivaTableAdapter
    Friend WithEvents TableAdapterManager As lesnictvo.rezivoDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Druh_rezivaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Druh_rezivaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Druh_rezivaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Druh_rezivaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CenaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
