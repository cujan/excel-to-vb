﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim NazovLabel As System.Windows.Forms.Label
        Dim Zaciatok_kurzuLabel As System.Windows.Forms.Label
        Dim Koniec_kurzuLabel As System.Windows.Forms.Label
        Dim TypLabel As System.Windows.Forms.Label
        Dim Miesto_konaniaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(kurz_detail))
        Me.pridaj_clenaButton = New System.Windows.Forms.Button
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
        Me.NazovTextBox = New System.Windows.Forms.TextBox
        Me.Zaciatok_kurzuDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Koniec_kurzuDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.TypTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_konaniaTextBox = New System.Windows.Forms.TextBox
        Me.Clenovia_kurzuDataGridView = New System.Windows.Forms.DataGridView
        Me.Clenovia_kurzuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Clenovia_kurzuDataSet = New pilcik.clenovia_kurzuDataSet
        Me.Clenovia_kurzuTableAdapter = New pilcik.clenovia_kurzuDataSetTableAdapters.clenovia_kurzuTableAdapter
        Me.TableAdapterManager1 = New pilcik.clenovia_kurzuDataSetTableAdapters.TableAdapterManager
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.datum_narodenia = New System.Windows.Forms.DataGridViewTextBoxColumn
        NazovLabel = New System.Windows.Forms.Label
        Zaciatok_kurzuLabel = New System.Windows.Forms.Label
        Koniec_kurzuLabel = New System.Windows.Forms.Label
        TypLabel = New System.Windows.Forms.Label
        Miesto_konaniaLabel = New System.Windows.Forms.Label
        CType(Me.PilcikdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KurzBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KurzBindingNavigator.SuspendLayout()
        CType(Me.Clenovia_kurzuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clenovia_kurzuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clenovia_kurzuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NazovLabel
        '
        NazovLabel.AutoSize = True
        NazovLabel.Location = New System.Drawing.Point(154, 48)
        NazovLabel.Name = "NazovLabel"
        NazovLabel.Size = New System.Drawing.Size(39, 13)
        NazovLabel.TabIndex = 16
        NazovLabel.Text = "nazov:"
        '
        'Zaciatok_kurzuLabel
        '
        Zaciatok_kurzuLabel.AutoSize = True
        Zaciatok_kurzuLabel.Location = New System.Drawing.Point(154, 75)
        Zaciatok_kurzuLabel.Name = "Zaciatok_kurzuLabel"
        Zaciatok_kurzuLabel.Size = New System.Drawing.Size(79, 13)
        Zaciatok_kurzuLabel.TabIndex = 18
        Zaciatok_kurzuLabel.Text = "zaciatok kurzu:"
        '
        'Koniec_kurzuLabel
        '
        Koniec_kurzuLabel.AutoSize = True
        Koniec_kurzuLabel.Location = New System.Drawing.Point(154, 101)
        Koniec_kurzuLabel.Name = "Koniec_kurzuLabel"
        Koniec_kurzuLabel.Size = New System.Drawing.Size(71, 13)
        Koniec_kurzuLabel.TabIndex = 20
        Koniec_kurzuLabel.Text = "koniec kurzu:"
        '
        'TypLabel
        '
        TypLabel.AutoSize = True
        TypLabel.Location = New System.Drawing.Point(154, 126)
        TypLabel.Name = "TypLabel"
        TypLabel.Size = New System.Drawing.Size(24, 13)
        TypLabel.TabIndex = 22
        TypLabel.Text = "typ:"
        '
        'Miesto_konaniaLabel
        '
        Miesto_konaniaLabel.AutoSize = True
        Miesto_konaniaLabel.Location = New System.Drawing.Point(154, 152)
        Miesto_konaniaLabel.Name = "Miesto_konaniaLabel"
        Miesto_konaniaLabel.Size = New System.Drawing.Size(81, 13)
        Miesto_konaniaLabel.TabIndex = 24
        Miesto_konaniaLabel.Text = "miesto konania:"
        '
        'pridaj_clenaButton
        '
        Me.pridaj_clenaButton.Location = New System.Drawing.Point(49, 216)
        Me.pridaj_clenaButton.Name = "pridaj_clenaButton"
        Me.pridaj_clenaButton.Size = New System.Drawing.Size(75, 23)
        Me.pridaj_clenaButton.TabIndex = 15
        Me.pridaj_clenaButton.Text = "Pridaj člena"
        Me.pridaj_clenaButton.UseVisualStyleBackColor = True
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
        Me.KurzBindingNavigator.TabIndex = 16
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
        'KurzBindingNavigatorSaveItem
        '
        Me.KurzBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KurzBindingNavigatorSaveItem.Enabled = False
        Me.KurzBindingNavigatorSaveItem.Image = CType(resources.GetObject("KurzBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.KurzBindingNavigatorSaveItem.Name = "KurzBindingNavigatorSaveItem"
        Me.KurzBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.KurzBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NazovTextBox
        '
        Me.NazovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "nazov", True))
        Me.NazovTextBox.Location = New System.Drawing.Point(241, 45)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NazovTextBox.TabIndex = 17
        '
        'Zaciatok_kurzuDateTimePicker
        '
        Me.Zaciatok_kurzuDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.KurzBindingSource, "zaciatok_kurzu", True))
        Me.Zaciatok_kurzuDateTimePicker.Location = New System.Drawing.Point(241, 71)
        Me.Zaciatok_kurzuDateTimePicker.Name = "Zaciatok_kurzuDateTimePicker"
        Me.Zaciatok_kurzuDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Zaciatok_kurzuDateTimePicker.TabIndex = 19
        '
        'Koniec_kurzuDateTimePicker
        '
        Me.Koniec_kurzuDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.KurzBindingSource, "koniec_kurzu", True))
        Me.Koniec_kurzuDateTimePicker.Location = New System.Drawing.Point(241, 97)
        Me.Koniec_kurzuDateTimePicker.Name = "Koniec_kurzuDateTimePicker"
        Me.Koniec_kurzuDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Koniec_kurzuDateTimePicker.TabIndex = 21
        '
        'TypTextBox
        '
        Me.TypTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "typ", True))
        Me.TypTextBox.Location = New System.Drawing.Point(241, 123)
        Me.TypTextBox.Name = "TypTextBox"
        Me.TypTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TypTextBox.TabIndex = 23
        '
        'Miesto_konaniaTextBox
        '
        Me.Miesto_konaniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "miesto_konania", True))
        Me.Miesto_konaniaTextBox.Location = New System.Drawing.Point(241, 149)
        Me.Miesto_konaniaTextBox.Name = "Miesto_konaniaTextBox"
        Me.Miesto_konaniaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Miesto_konaniaTextBox.TabIndex = 25
        '
        'Clenovia_kurzuDataGridView
        '
        Me.Clenovia_kurzuDataGridView.AllowUserToAddRows = False
        Me.Clenovia_kurzuDataGridView.AllowUserToDeleteRows = False
        Me.Clenovia_kurzuDataGridView.AutoGenerateColumns = False
        Me.Clenovia_kurzuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Clenovia_kurzuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.datum_narodenia})
        Me.Clenovia_kurzuDataGridView.DataSource = Me.Clenovia_kurzuBindingSource
        Me.Clenovia_kurzuDataGridView.Location = New System.Drawing.Point(12, 256)
        Me.Clenovia_kurzuDataGridView.Name = "Clenovia_kurzuDataGridView"
        Me.Clenovia_kurzuDataGridView.ReadOnly = True
        Me.Clenovia_kurzuDataGridView.Size = New System.Drawing.Size(921, 220)
        Me.Clenovia_kurzuDataGridView.TabIndex = 25
        '
        'Clenovia_kurzuBindingSource
        '
        Me.Clenovia_kurzuBindingSource.DataMember = "clenovia_kurzu"
        Me.Clenovia_kurzuBindingSource.DataSource = Me.Clenovia_kurzuDataSet
        '
        'Clenovia_kurzuDataSet
        '
        Me.Clenovia_kurzuDataSet.DataSetName = "clenovia_kurzuDataSet"
        Me.Clenovia_kurzuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Clenovia_kurzuTableAdapter
        '
        Me.Clenovia_kurzuTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = pilcik.clenovia_kurzuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'datum_narodenia
        '
        Me.datum_narodenia.DataPropertyName = "datum_narodenia"
        Me.datum_narodenia.HeaderText = "datum_narodenia"
        Me.datum_narodenia.Name = "datum_narodenia"
        Me.datum_narodenia.ReadOnly = True
        '
        'kurz_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 702)
        Me.Controls.Add(Me.Clenovia_kurzuDataGridView)
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
        Me.Controls.Add(Me.KurzBindingNavigator)
        Me.Controls.Add(Me.pridaj_clenaButton)
        Me.Name = "kurz_detail"
        Me.Text = "kurz_detail"
        CType(Me.PilcikdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KurzBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KurzBindingNavigator.ResumeLayout(False)
        Me.KurzBindingNavigator.PerformLayout()
        CType(Me.Clenovia_kurzuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clenovia_kurzuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clenovia_kurzuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pridaj_clenaButton As System.Windows.Forms.Button
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
    Friend WithEvents NazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zaciatok_kurzuDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Koniec_kurzuDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TypTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_konaniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Clenovia_kurzuDataSet As pilcik.clenovia_kurzuDataSet
    Friend WithEvents Clenovia_kurzuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Clenovia_kurzuTableAdapter As pilcik.clenovia_kurzuDataSetTableAdapters.clenovia_kurzuTableAdapter
    Friend WithEvents TableAdapterManager1 As pilcik.clenovia_kurzuDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Clenovia_kurzuDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datum_narodenia As System.Windows.Forms.DataGridViewTextBoxColumn
End Class