﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(odberatelia))
        Dim IdLabel As System.Windows.Forms.Label
        Dim NazovLabel As System.Windows.Forms.Label
        Dim UlicaLabel As System.Windows.Forms.Label
        Dim MestoLabel As System.Windows.Forms.Label
        Dim PscLabel As System.Windows.Forms.Label
        Dim IcoLabel As System.Windows.Forms.Label
        Dim DicLabel As System.Windows.Forms.Label
        Dim Cislo_uctuLabel As System.Windows.Forms.Label
        Me.OdberateliaDataSet1 = New lesnictvo.odberateliaDataSet1
        Me.OdberateliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OdberateliaTableAdapter = New lesnictvo.odberateliaDataSet1TableAdapters.odberateliaTableAdapter
        Me.TableAdapterManager = New lesnictvo.odberateliaDataSet1TableAdapters.TableAdapterManager
        Me.OdberateliaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.OdberateliaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.OdberateliaDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdTextBox = New System.Windows.Forms.TextBox
        Me.NazovComboBox = New System.Windows.Forms.ComboBox
        Me.UlicaTextBox = New System.Windows.Forms.TextBox
        Me.MestoTextBox = New System.Windows.Forms.TextBox
        Me.PscTextBox = New System.Windows.Forms.TextBox
        Me.IcoTextBox = New System.Windows.Forms.TextBox
        Me.DicTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_uctuTextBox = New System.Windows.Forms.TextBox
        IdLabel = New System.Windows.Forms.Label
        NazovLabel = New System.Windows.Forms.Label
        UlicaLabel = New System.Windows.Forms.Label
        MestoLabel = New System.Windows.Forms.Label
        PscLabel = New System.Windows.Forms.Label
        IcoLabel = New System.Windows.Forms.Label
        DicLabel = New System.Windows.Forms.Label
        Cislo_uctuLabel = New System.Windows.Forms.Label
        CType(Me.OdberateliaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OdberateliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OdberateliaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OdberateliaBindingNavigator.SuspendLayout()
        CType(Me.OdberateliaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OdberateliaDataSet1
        '
        Me.OdberateliaDataSet1.DataSetName = "odberateliaDataSet1"
        Me.OdberateliaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OdberateliaBindingSource
        '
        Me.OdberateliaBindingSource.DataMember = "odberatelia"
        Me.OdberateliaBindingSource.DataSource = Me.OdberateliaDataSet1
        '
        'OdberateliaTableAdapter
        '
        Me.OdberateliaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.odberateliaTableAdapter = Me.OdberateliaTableAdapter
        Me.TableAdapterManager.UpdateOrder = lesnictvo.odberateliaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OdberateliaBindingNavigator
        '
        Me.OdberateliaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OdberateliaBindingNavigator.BindingSource = Me.OdberateliaBindingSource
        Me.OdberateliaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OdberateliaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OdberateliaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OdberateliaBindingNavigatorSaveItem})
        Me.OdberateliaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OdberateliaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OdberateliaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OdberateliaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OdberateliaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OdberateliaBindingNavigator.Name = "OdberateliaBindingNavigator"
        Me.OdberateliaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OdberateliaBindingNavigator.Size = New System.Drawing.Size(814, 25)
        Me.OdberateliaBindingNavigator.TabIndex = 0
        Me.OdberateliaBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'OdberateliaBindingNavigatorSaveItem
        '
        Me.OdberateliaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OdberateliaBindingNavigatorSaveItem.Image = CType(resources.GetObject("OdberateliaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OdberateliaBindingNavigatorSaveItem.Name = "OdberateliaBindingNavigatorSaveItem"
        Me.OdberateliaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.OdberateliaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'OdberateliaDataGridView
        '
        Me.OdberateliaDataGridView.AutoGenerateColumns = False
        Me.OdberateliaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OdberateliaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.OdberateliaDataGridView.DataSource = Me.OdberateliaBindingSource
        Me.OdberateliaDataGridView.Location = New System.Drawing.Point(12, 312)
        Me.OdberateliaDataGridView.Name = "OdberateliaDataGridView"
        Me.OdberateliaDataGridView.Size = New System.Drawing.Size(782, 220)
        Me.OdberateliaDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nazov"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nazov"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ulica"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ulica"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "mesto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "mesto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "psc"
        Me.DataGridViewTextBoxColumn5.HeaderText = "psc"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ico"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ico"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "dic"
        Me.DataGridViewTextBoxColumn7.HeaderText = "dic"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cislo_uctu"
        Me.DataGridViewTextBoxColumn8.HeaderText = "cislo_uctu"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(132, 73)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 2
        IdLabel.Text = "id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OdberateliaBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(193, 70)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IdTextBox.TabIndex = 3
        '
        'NazovLabel
        '
        NazovLabel.AutoSize = True
        NazovLabel.Location = New System.Drawing.Point(132, 99)
        NazovLabel.Name = "NazovLabel"
        NazovLabel.Size = New System.Drawing.Size(39, 13)
        NazovLabel.TabIndex = 4
        NazovLabel.Text = "nazov:"
        '
        'NazovComboBox
        '
        Me.NazovComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OdberateliaBindingSource, "nazov", True))
        Me.NazovComboBox.DataSource = Me.OdberateliaBindingSource
        Me.NazovComboBox.DisplayMember = "nazov"
        Me.NazovComboBox.FormattingEnabled = True
        Me.NazovComboBox.Location = New System.Drawing.Point(193, 96)
        Me.NazovComboBox.Name = "NazovComboBox"
        Me.NazovComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NazovComboBox.TabIndex = 5
        '
        'UlicaLabel
        '
        UlicaLabel.AutoSize = True
        UlicaLabel.Location = New System.Drawing.Point(132, 126)
        UlicaLabel.Name = "UlicaLabel"
        UlicaLabel.Size = New System.Drawing.Size(32, 13)
        UlicaLabel.TabIndex = 6
        UlicaLabel.Text = "ulica:"
        '
        'UlicaTextBox
        '
        Me.UlicaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OdberateliaBindingSource, "ulica", True))
        Me.UlicaTextBox.Location = New System.Drawing.Point(193, 123)
        Me.UlicaTextBox.Name = "UlicaTextBox"
        Me.UlicaTextBox.Size = New System.Drawing.Size(121, 20)
        Me.UlicaTextBox.TabIndex = 7
        '
        'MestoLabel
        '
        MestoLabel.AutoSize = True
        MestoLabel.Location = New System.Drawing.Point(132, 152)
        MestoLabel.Name = "MestoLabel"
        MestoLabel.Size = New System.Drawing.Size(38, 13)
        MestoLabel.TabIndex = 8
        MestoLabel.Text = "mesto:"
        '
        'MestoTextBox
        '
        Me.MestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OdberateliaBindingSource, "mesto", True))
        Me.MestoTextBox.Location = New System.Drawing.Point(193, 149)
        Me.MestoTextBox.Name = "MestoTextBox"
        Me.MestoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.MestoTextBox.TabIndex = 9
        '
        'PscLabel
        '
        PscLabel.AutoSize = True
        PscLabel.Location = New System.Drawing.Point(132, 178)
        PscLabel.Name = "PscLabel"
        PscLabel.Size = New System.Drawing.Size(27, 13)
        PscLabel.TabIndex = 10
        PscLabel.Text = "psc:"
        '
        'PscTextBox
        '
        Me.PscTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OdberateliaBindingSource, "psc", True))
        Me.PscTextBox.Location = New System.Drawing.Point(193, 175)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PscTextBox.TabIndex = 11
        '
        'IcoLabel
        '
        IcoLabel.AutoSize = True
        IcoLabel.Location = New System.Drawing.Point(132, 204)
        IcoLabel.Name = "IcoLabel"
        IcoLabel.Size = New System.Drawing.Size(24, 13)
        IcoLabel.TabIndex = 12
        IcoLabel.Text = "ico:"
        '
        'IcoTextBox
        '
        Me.IcoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OdberateliaBindingSource, "ico", True))
        Me.IcoTextBox.Location = New System.Drawing.Point(193, 201)
        Me.IcoTextBox.Name = "IcoTextBox"
        Me.IcoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IcoTextBox.TabIndex = 13
        '
        'DicLabel
        '
        DicLabel.AutoSize = True
        DicLabel.Location = New System.Drawing.Point(132, 230)
        DicLabel.Name = "DicLabel"
        DicLabel.Size = New System.Drawing.Size(24, 13)
        DicLabel.TabIndex = 14
        DicLabel.Text = "dic:"
        '
        'DicTextBox
        '
        Me.DicTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OdberateliaBindingSource, "dic", True))
        Me.DicTextBox.Location = New System.Drawing.Point(193, 227)
        Me.DicTextBox.Name = "DicTextBox"
        Me.DicTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DicTextBox.TabIndex = 15
        '
        'Cislo_uctuLabel
        '
        Cislo_uctuLabel.AutoSize = True
        Cislo_uctuLabel.Location = New System.Drawing.Point(132, 256)
        Cislo_uctuLabel.Name = "Cislo_uctuLabel"
        Cislo_uctuLabel.Size = New System.Drawing.Size(55, 13)
        Cislo_uctuLabel.TabIndex = 16
        Cislo_uctuLabel.Text = "cislo uctu:"
        '
        'Cislo_uctuTextBox
        '
        Me.Cislo_uctuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OdberateliaBindingSource, "cislo_uctu", True))
        Me.Cislo_uctuTextBox.Location = New System.Drawing.Point(193, 253)
        Me.Cislo_uctuTextBox.Name = "Cislo_uctuTextBox"
        Me.Cislo_uctuTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Cislo_uctuTextBox.TabIndex = 17
        '
        'odberatelia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 555)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(NazovLabel)
        Me.Controls.Add(Me.NazovComboBox)
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
        Me.Controls.Add(Cislo_uctuLabel)
        Me.Controls.Add(Me.Cislo_uctuTextBox)
        Me.Controls.Add(Me.OdberateliaDataGridView)
        Me.Controls.Add(Me.OdberateliaBindingNavigator)
        Me.Name = "odberatelia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Odberatelia"
        CType(Me.OdberateliaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OdberateliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OdberateliaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OdberateliaBindingNavigator.ResumeLayout(False)
        Me.OdberateliaBindingNavigator.PerformLayout()
        CType(Me.OdberateliaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OdberateliaDataSet1 As lesnictvo.odberateliaDataSet1
    Friend WithEvents OdberateliaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OdberateliaTableAdapter As lesnictvo.odberateliaDataSet1TableAdapters.odberateliaTableAdapter
    Friend WithEvents TableAdapterManager As lesnictvo.odberateliaDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents OdberateliaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents OdberateliaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OdberateliaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NazovComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UlicaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PscTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IcoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DicTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_uctuTextBox As System.Windows.Forms.TextBox

End Class
