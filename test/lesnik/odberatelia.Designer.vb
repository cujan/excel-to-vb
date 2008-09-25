<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class odberatelia
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
        Dim UlicaLabel As System.Windows.Forms.Label
        Dim MestoLabel As System.Windows.Forms.Label
        Dim PscLabel As System.Windows.Forms.Label
        Dim IcoLabel As System.Windows.Forms.Label
        Dim DicLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(odberatelia))
        Me.OdberateliaDataSet1 = New lesnik.odberateliaDataSet1
        Me.OdberatelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OdberatelTableAdapter = New lesnik.odberateliaDataSet1TableAdapters.odberatelTableAdapter
        Me.TableAdapterManager = New lesnik.odberateliaDataSet1TableAdapters.TableAdapterManager
        Me.OdberatelBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.OdberatelBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.OdberatelDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NazovTextBox = New System.Windows.Forms.TextBox
        Me.UlicaTextBox = New System.Windows.Forms.TextBox
        Me.MestoTextBox = New System.Windows.Forms.TextBox
        Me.PscTextBox = New System.Windows.Forms.TextBox
        Me.IcoTextBox = New System.Windows.Forms.TextBox
        Me.DicTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        NazovLabel = New System.Windows.Forms.Label
        UlicaLabel = New System.Windows.Forms.Label
        MestoLabel = New System.Windows.Forms.Label
        PscLabel = New System.Windows.Forms.Label
        IcoLabel = New System.Windows.Forms.Label
        DicLabel = New System.Windows.Forms.Label
        CType(Me.OdberateliaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OdberatelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OdberatelBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OdberatelBindingNavigator.SuspendLayout()
        CType(Me.OdberatelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NazovLabel
        '
        NazovLabel.AutoSize = True
        NazovLabel.Location = New System.Drawing.Point(34, 56)
        NazovLabel.Name = "NazovLabel"
        NazovLabel.Size = New System.Drawing.Size(39, 13)
        NazovLabel.TabIndex = 4
        NazovLabel.Text = "nazov:"
        '
        'UlicaLabel
        '
        UlicaLabel.AutoSize = True
        UlicaLabel.Location = New System.Drawing.Point(339, 56)
        UlicaLabel.Name = "UlicaLabel"
        UlicaLabel.Size = New System.Drawing.Size(32, 13)
        UlicaLabel.TabIndex = 6
        UlicaLabel.Text = "ulica:"
        '
        'MestoLabel
        '
        MestoLabel.AutoSize = True
        MestoLabel.Location = New System.Drawing.Point(333, 110)
        MestoLabel.Name = "MestoLabel"
        MestoLabel.Size = New System.Drawing.Size(38, 13)
        MestoLabel.TabIndex = 8
        MestoLabel.Text = "mesto:"
        '
        'PscLabel
        '
        PscLabel.AutoSize = True
        PscLabel.Location = New System.Drawing.Point(333, 146)
        PscLabel.Name = "PscLabel"
        PscLabel.Size = New System.Drawing.Size(27, 13)
        PscLabel.TabIndex = 10
        PscLabel.Text = "psc:"
        '
        'IcoLabel
        '
        IcoLabel.AutoSize = True
        IcoLabel.Location = New System.Drawing.Point(584, 52)
        IcoLabel.Name = "IcoLabel"
        IcoLabel.Size = New System.Drawing.Size(24, 13)
        IcoLabel.TabIndex = 12
        IcoLabel.Text = "ico:"
        '
        'DicLabel
        '
        DicLabel.AutoSize = True
        DicLabel.Location = New System.Drawing.Point(584, 117)
        DicLabel.Name = "DicLabel"
        DicLabel.Size = New System.Drawing.Size(24, 13)
        DicLabel.TabIndex = 14
        DicLabel.Text = "dic:"
        '
        'OdberateliaDataSet1
        '
        Me.OdberateliaDataSet1.DataSetName = "odberateliaDataSet1"
        Me.OdberateliaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OdberatelBindingSource
        '
        Me.OdberatelBindingSource.DataMember = "odberatel"
        Me.OdberatelBindingSource.DataSource = Me.OdberateliaDataSet1
        '
        'OdberatelTableAdapter
        '
        Me.OdberatelTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.odberatelTableAdapter = Me.OdberatelTableAdapter
        Me.TableAdapterManager.UpdateOrder = lesnik.odberateliaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OdberatelBindingNavigator
        '
        Me.OdberatelBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OdberatelBindingNavigator.BindingSource = Me.OdberatelBindingSource
        Me.OdberatelBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OdberatelBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OdberatelBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OdberatelBindingNavigatorSaveItem})
        Me.OdberatelBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OdberatelBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OdberatelBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OdberatelBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OdberatelBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OdberatelBindingNavigator.Name = "OdberatelBindingNavigator"
        Me.OdberatelBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OdberatelBindingNavigator.Size = New System.Drawing.Size(775, 25)
        Me.OdberatelBindingNavigator.TabIndex = 0
        Me.OdberatelBindingNavigator.Text = "BindingNavigator1"
        Me.OdberatelBindingNavigator.Visible = False
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
        'OdberatelBindingNavigatorSaveItem
        '
        Me.OdberatelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OdberatelBindingNavigatorSaveItem.Image = CType(resources.GetObject("OdberatelBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OdberatelBindingNavigatorSaveItem.Name = "OdberatelBindingNavigatorSaveItem"
        Me.OdberatelBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OdberatelBindingNavigatorSaveItem.Text = "Save Data"
        '
        'OdberatelDataGridView
        '
        Me.OdberatelDataGridView.AllowUserToAddRows = False
        Me.OdberatelDataGridView.AllowUserToDeleteRows = False
        Me.OdberatelDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OdberatelDataGridView.AutoGenerateColumns = False
        Me.OdberatelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OdberatelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.OdberatelDataGridView.DataSource = Me.OdberatelBindingSource
        Me.OdberatelDataGridView.Location = New System.Drawing.Point(13, 198)
        Me.OdberatelDataGridView.Name = "OdberatelDataGridView"
        Me.OdberatelDataGridView.ReadOnly = True
        Me.OdberatelDataGridView.Size = New System.Drawing.Size(751, 220)
        Me.OdberatelDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nazov"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nazov"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ulica"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ulica"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "mesto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "mesto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "psc"
        Me.DataGridViewTextBoxColumn5.HeaderText = "psc"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ico"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ico"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "dic"
        Me.DataGridViewTextBoxColumn7.HeaderText = "dic"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'NazovTextBox
        '
        Me.NazovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OdberatelBindingSource, "nazov", True))
        Me.NazovTextBox.Location = New System.Drawing.Point(94, 56)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NazovTextBox.TabIndex = 5
        '
        'UlicaTextBox
        '
        Me.UlicaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OdberatelBindingSource, "ulica", True))
        Me.UlicaTextBox.Location = New System.Drawing.Point(377, 49)
        Me.UlicaTextBox.Name = "UlicaTextBox"
        Me.UlicaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UlicaTextBox.TabIndex = 7
        '
        'MestoTextBox
        '
        Me.MestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OdberatelBindingSource, "mesto", True))
        Me.MestoTextBox.Location = New System.Drawing.Point(377, 107)
        Me.MestoTextBox.Name = "MestoTextBox"
        Me.MestoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MestoTextBox.TabIndex = 9
        '
        'PscTextBox
        '
        Me.PscTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OdberatelBindingSource, "psc", True))
        Me.PscTextBox.Location = New System.Drawing.Point(377, 143)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PscTextBox.TabIndex = 11
        '
        'IcoTextBox
        '
        Me.IcoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OdberatelBindingSource, "ico", True))
        Me.IcoTextBox.Location = New System.Drawing.Point(614, 49)
        Me.IcoTextBox.Name = "IcoTextBox"
        Me.IcoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IcoTextBox.TabIndex = 13
        '
        'DicTextBox
        '
        Me.DicTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OdberatelBindingSource, "dic", True))
        Me.DicTextBox.Location = New System.Drawing.Point(614, 110)
        Me.DicTextBox.Name = "DicTextBox"
        Me.DicTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DicTextBox.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(614, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "uloz"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'odberatelia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 434)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(NazovLabel)
        Me.Controls.Add(Me.NazovTextBox)
        Me.Controls.Add(UlicaLabel)
        Me.Controls.Add(Me.UlicaTextBox)
        Me.Controls.Add(MestoLabel)
        Me.Controls.Add(Me.MestoTextBox)
        Me.Controls.Add(PscLabel)
        Me.Controls.Add(Me.PscTextBox)
        Me.Controls.Add(IcoLabel)
        Me.Controls.Add(Me.IcoTextBox)
        Me.Controls.Add(DicLabel)
        Me.Controls.Add(Me.DicTextBox)
        Me.Controls.Add(Me.OdberatelDataGridView)
        Me.Controls.Add(Me.OdberatelBindingNavigator)
        Me.Name = "odberatelia"
        Me.Text = "odberatelia"
        CType(Me.OdberateliaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OdberatelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OdberatelBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OdberatelBindingNavigator.ResumeLayout(False)
        Me.OdberatelBindingNavigator.PerformLayout()
        CType(Me.OdberatelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OdberateliaDataSet1 As lesnik.odberateliaDataSet1
    Friend WithEvents OdberatelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OdberatelTableAdapter As lesnik.odberateliaDataSet1TableAdapters.odberatelTableAdapter
    Friend WithEvents TableAdapterManager As lesnik.odberateliaDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents OdberatelBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents OdberatelBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OdberatelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UlicaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PscTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IcoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DicTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
