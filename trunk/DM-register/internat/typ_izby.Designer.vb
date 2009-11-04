<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class typ_izby
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(typ_izby))
        Me.Typ_izbyDataSet = New internat.typ_izbyDataSet
        Me.Typ_izbyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Typ_izbyTableAdapter = New internat.typ_izbyDataSetTableAdapters.typ_izbyTableAdapter
        Me.TableAdapterManager = New internat.typ_izbyDataSetTableAdapters.TableAdapterManager
        Me.Typ_izbyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Typ_izbyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Typ_izbyDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.typizbyTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.vlozButton = New System.Windows.Forms.Button
        Me.zatvor = New System.Windows.Forms.Button
        CType(Me.Typ_izbyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Typ_izbyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Typ_izbyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Typ_izbyBindingNavigator.SuspendLayout()
        CType(Me.Typ_izbyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Typ_izbyDataSet
        '
        Me.Typ_izbyDataSet.DataSetName = "typ_izbyDataSet"
        Me.Typ_izbyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Typ_izbyBindingSource
        '
        Me.Typ_izbyBindingSource.DataMember = "typ_izby"
        Me.Typ_izbyBindingSource.DataSource = Me.Typ_izbyDataSet
        '
        'Typ_izbyTableAdapter
        '
        Me.Typ_izbyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.typ_izbyTableAdapter = Me.Typ_izbyTableAdapter
        Me.TableAdapterManager.UpdateOrder = internat.typ_izbyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Typ_izbyBindingNavigator
        '
        Me.Typ_izbyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Typ_izbyBindingNavigator.BindingSource = Me.Typ_izbyBindingSource
        Me.Typ_izbyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Typ_izbyBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Typ_izbyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Typ_izbyBindingNavigatorSaveItem})
        Me.Typ_izbyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Typ_izbyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Typ_izbyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Typ_izbyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Typ_izbyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Typ_izbyBindingNavigator.Name = "Typ_izbyBindingNavigator"
        Me.Typ_izbyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Typ_izbyBindingNavigator.Size = New System.Drawing.Size(425, 25)
        Me.Typ_izbyBindingNavigator.TabIndex = 0
        Me.Typ_izbyBindingNavigator.Text = "BindingNavigator1"
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
        'Typ_izbyBindingNavigatorSaveItem
        '
        Me.Typ_izbyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Typ_izbyBindingNavigatorSaveItem.Image = CType(resources.GetObject("Typ_izbyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Typ_izbyBindingNavigatorSaveItem.Name = "Typ_izbyBindingNavigatorSaveItem"
        Me.Typ_izbyBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Typ_izbyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Typ_izbyDataGridView
        '
        Me.Typ_izbyDataGridView.AutoGenerateColumns = False
        Me.Typ_izbyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Typ_izbyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Typ_izbyDataGridView.DataSource = Me.Typ_izbyBindingSource
        Me.Typ_izbyDataGridView.Location = New System.Drawing.Point(12, 156)
        Me.Typ_izbyDataGridView.Name = "Typ_izbyDataGridView"
        Me.Typ_izbyDataGridView.Size = New System.Drawing.Size(401, 220)
        Me.Typ_izbyDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "typ_izby"
        Me.DataGridViewTextBoxColumn2.HeaderText = "typ_izby"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'typizbyTextBox
        '
        Me.typizbyTextBox.Location = New System.Drawing.Point(126, 51)
        Me.typizbyTextBox.Name = "typizbyTextBox"
        Me.typizbyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.typizbyTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Typ izby"
        '
        'vlozButton
        '
        Me.vlozButton.Location = New System.Drawing.Point(253, 92)
        Me.vlozButton.Name = "vlozButton"
        Me.vlozButton.Size = New System.Drawing.Size(75, 23)
        Me.vlozButton.TabIndex = 4
        Me.vlozButton.Text = "vloz"
        Me.vlozButton.UseVisualStyleBackColor = True
        '
        'zatvor
        '
        Me.zatvor.Location = New System.Drawing.Point(253, 51)
        Me.zatvor.Name = "zatvor"
        Me.zatvor.Size = New System.Drawing.Size(75, 23)
        Me.zatvor.TabIndex = 5
        Me.zatvor.Text = "zatvor"
        Me.zatvor.UseVisualStyleBackColor = True
        '
        'typ_izby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 388)
        Me.Controls.Add(Me.zatvor)
        Me.Controls.Add(Me.vlozButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.typizbyTextBox)
        Me.Controls.Add(Me.Typ_izbyDataGridView)
        Me.Controls.Add(Me.Typ_izbyBindingNavigator)
        Me.Name = "typ_izby"
        Me.Text = "typ_izby"
        CType(Me.Typ_izbyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Typ_izbyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Typ_izbyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Typ_izbyBindingNavigator.ResumeLayout(False)
        Me.Typ_izbyBindingNavigator.PerformLayout()
        CType(Me.Typ_izbyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Typ_izbyDataSet As internat.typ_izbyDataSet
    Friend WithEvents Typ_izbyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Typ_izbyTableAdapter As internat.typ_izbyDataSetTableAdapters.typ_izbyTableAdapter
    Friend WithEvents TableAdapterManager As internat.typ_izbyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Typ_izbyBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Typ_izbyBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Typ_izbyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents typizbyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents vlozButton As System.Windows.Forms.Button
    Friend WithEvents zatvor As System.Windows.Forms.Button
End Class
