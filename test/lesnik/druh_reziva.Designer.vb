<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class druh_reziva
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
        Dim KodLabel As System.Windows.Forms.Label
        Dim DruRezivaLabel As System.Windows.Forms.Label
        Dim CenaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(druh_reziva))
        Me.DruhrezivaDataSet1 = New lesnik.druhrezivaDataSet1
        Me.Druh_rezivaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Druh_rezivaTableAdapter = New lesnik.druhrezivaDataSet1TableAdapters.druh_rezivaTableAdapter
        Me.TableAdapterManager = New lesnik.druhrezivaDataSet1TableAdapters.TableAdapterManager
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
        Me.DruRezivaTextBox = New System.Windows.Forms.TextBox
        Me.CenaTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        KodLabel = New System.Windows.Forms.Label
        DruRezivaLabel = New System.Windows.Forms.Label
        CenaLabel = New System.Windows.Forms.Label
        CType(Me.DruhrezivaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Druh_rezivaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Druh_rezivaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Druh_rezivaBindingNavigator.SuspendLayout()
        CType(Me.Druh_rezivaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KodLabel
        '
        KodLabel.AutoSize = True
        KodLabel.Location = New System.Drawing.Point(9, 36)
        KodLabel.Name = "KodLabel"
        KodLabel.Size = New System.Drawing.Size(28, 13)
        KodLabel.TabIndex = 4
        KodLabel.Text = "kod:"
        '
        'DruRezivaLabel
        '
        DruRezivaLabel.AutoSize = True
        DruRezivaLabel.Location = New System.Drawing.Point(102, 39)
        DruRezivaLabel.Name = "DruRezivaLabel"
        DruRezivaLabel.Size = New System.Drawing.Size(63, 13)
        DruRezivaLabel.TabIndex = 6
        DruRezivaLabel.Text = "Dru Reziva:"
        '
        'CenaLabel
        '
        CenaLabel.AutoSize = True
        CenaLabel.Location = New System.Drawing.Point(325, 39)
        CenaLabel.Name = "CenaLabel"
        CenaLabel.Size = New System.Drawing.Size(34, 13)
        CenaLabel.TabIndex = 8
        CenaLabel.Text = "cena:"
        '
        'DruhrezivaDataSet1
        '
        Me.DruhrezivaDataSet1.DataSetName = "druhrezivaDataSet1"
        Me.DruhrezivaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Druh_rezivaBindingSource
        '
        Me.Druh_rezivaBindingSource.DataMember = "druh reziva"
        Me.Druh_rezivaBindingSource.DataSource = Me.DruhrezivaDataSet1
        '
        'Druh_rezivaTableAdapter
        '
        Me.Druh_rezivaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.druh_rezivaTableAdapter = Me.Druh_rezivaTableAdapter
        Me.TableAdapterManager.UpdateOrder = lesnik.druhrezivaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.Druh_rezivaBindingNavigator.Size = New System.Drawing.Size(483, 25)
        Me.Druh_rezivaBindingNavigator.TabIndex = 0
        Me.Druh_rezivaBindingNavigator.Text = "BindingNavigator1"
        Me.Druh_rezivaBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.ToolTipText = "Pridaj novy"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(33, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Celkový počet položiek"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.ToolTipText = "Zmaž"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        Me.BindingNavigatorMoveFirstItem.ToolTipText = "Prvá položka"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        Me.BindingNavigatorMovePreviousItem.ToolTipText = "Predchádzajúca položka"
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
        Me.BindingNavigatorPositionItem.ToolTipText = "Aktuálna pozícia"
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
        Me.BindingNavigatorMoveNextItem.ToolTipText = "Nasledujúca položka"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        Me.BindingNavigatorMoveLastItem.ToolTipText = "Posledná položka"
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
        Me.Druh_rezivaBindingNavigatorSaveItem.ToolTipText = "Ulož položku"
        '
        'Druh_rezivaDataGridView
        '
        Me.Druh_rezivaDataGridView.AllowUserToAddRows = False
        Me.Druh_rezivaDataGridView.AllowUserToDeleteRows = False
        Me.Druh_rezivaDataGridView.AutoGenerateColumns = False
        Me.Druh_rezivaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Druh_rezivaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Druh_rezivaDataGridView.DataSource = Me.Druh_rezivaBindingSource
        Me.Druh_rezivaDataGridView.Location = New System.Drawing.Point(12, 105)
        Me.Druh_rezivaDataGridView.Name = "Druh_rezivaDataGridView"
        Me.Druh_rezivaDataGridView.ReadOnly = True
        Me.Druh_rezivaDataGridView.Size = New System.Drawing.Size(446, 220)
        Me.Druh_rezivaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "kod"
        Me.DataGridViewTextBoxColumn2.HeaderText = "kod"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DruReziva"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DruReziva"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cena"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cena"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'KodTextBox
        '
        Me.KodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Druh_rezivaBindingSource, "kod", True))
        Me.KodTextBox.Location = New System.Drawing.Point(43, 36)
        Me.KodTextBox.Name = "KodTextBox"
        Me.KodTextBox.Size = New System.Drawing.Size(53, 20)
        Me.KodTextBox.TabIndex = 5
        '
        'DruRezivaTextBox
        '
        Me.DruRezivaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Druh_rezivaBindingSource, "DruReziva", True))
        Me.DruRezivaTextBox.Location = New System.Drawing.Point(162, 36)
        Me.DruRezivaTextBox.Name = "DruRezivaTextBox"
        Me.DruRezivaTextBox.Size = New System.Drawing.Size(157, 20)
        Me.DruRezivaTextBox.TabIndex = 7
        '
        'CenaTextBox
        '
        Me.CenaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Druh_rezivaBindingSource, "cena", True))
        Me.CenaTextBox.Location = New System.Drawing.Point(365, 36)
        Me.CenaTextBox.Name = "CenaTextBox"
        Me.CenaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CenaTextBox.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(365, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "uloz"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "cau marek"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nazdar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(253, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "dalsi label"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "dalsi label 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Label 5 -2"
        '
        'druh_reziva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 345)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(KodLabel)
        Me.Controls.Add(Me.KodTextBox)
        Me.Controls.Add(DruRezivaLabel)
        Me.Controls.Add(Me.DruRezivaTextBox)
        Me.Controls.Add(CenaLabel)
        Me.Controls.Add(Me.CenaTextBox)
        Me.Controls.Add(Me.Druh_rezivaDataGridView)
        Me.Controls.Add(Me.Druh_rezivaBindingNavigator)
        Me.Name = "druh_reziva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "druh_reziva"
        CType(Me.DruhrezivaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Druh_rezivaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Druh_rezivaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Druh_rezivaBindingNavigator.ResumeLayout(False)
        Me.Druh_rezivaBindingNavigator.PerformLayout()
        CType(Me.Druh_rezivaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DruhrezivaDataSet1 As lesnik.druhrezivaDataSet1
    Friend WithEvents Druh_rezivaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Druh_rezivaTableAdapter As lesnik.druhrezivaDataSet1TableAdapters.druh_rezivaTableAdapter
    Friend WithEvents TableAdapterManager As lesnik.druhrezivaDataSet1TableAdapters.TableAdapterManager
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
    Friend WithEvents DruRezivaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CenaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
