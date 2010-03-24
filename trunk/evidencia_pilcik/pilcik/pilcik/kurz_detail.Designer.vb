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
        Dim IdLabel As System.Windows.Forms.Label
        Dim NazovLabel As System.Windows.Forms.Label
        Dim Zaciatok_kurzuLabel As System.Windows.Forms.Label
        Dim Koniec_kurzuLabel As System.Windows.Forms.Label
        Dim TypLabel As System.Windows.Forms.Label
        Dim Miesto_konaniaLabel As System.Windows.Forms.Label
        Me.PilcikdbDataSet = New pilcik.pilcikdbDataSet
        Me.KurzBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KurzTableAdapter = New pilcik.pilcikdbDataSetTableAdapters.kurzTableAdapter
        Me.TableAdapterManager = New pilcik.pilcikdbDataSetTableAdapters.TableAdapterManager
        Me.KurzBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.KurzBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.IdTextBox = New System.Windows.Forms.TextBox
        Me.NazovTextBox = New System.Windows.Forms.TextBox
        Me.Zaciatok_kurzuDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Koniec_kurzuDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.TypComboBox = New System.Windows.Forms.ComboBox
        Me.Miesto_konaniaComboBox = New System.Windows.Forms.ComboBox
        IdLabel = New System.Windows.Forms.Label
        NazovLabel = New System.Windows.Forms.Label
        Zaciatok_kurzuLabel = New System.Windows.Forms.Label
        Koniec_kurzuLabel = New System.Windows.Forms.Label
        TypLabel = New System.Windows.Forms.Label
        Miesto_konaniaLabel = New System.Windows.Forms.Label
        CType(Me.PilcikdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KurzBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KurzBindingNavigator.SuspendLayout()
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
        Me.TableAdapterManager.kurzTableAdapter = Me.KurzTableAdapter

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
        Me.KurzBindingNavigator.Size = New System.Drawing.Size(608, 25)
        Me.KurzBindingNavigator.TabIndex = 0
        Me.KurzBindingNavigator.Text = "BindingNavigator1"
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
        'KurzBindingNavigatorSaveItem
        '
        Me.KurzBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KurzBindingNavigatorSaveItem.Image = CType(resources.GetObject("KurzBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.KurzBindingNavigatorSaveItem.Name = "KurzBindingNavigatorSaveItem"
        Me.KurzBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.KurzBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(122, 83)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(209, 80)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'NazovLabel
        '
        NazovLabel.AutoSize = True
        NazovLabel.Location = New System.Drawing.Point(122, 109)
        NazovLabel.Name = "NazovLabel"
        NazovLabel.Size = New System.Drawing.Size(39, 13)
        NazovLabel.TabIndex = 3
        NazovLabel.Text = "nazov:"
        '
        'NazovTextBox
        '
        Me.NazovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "nazov", True))
        Me.NazovTextBox.Location = New System.Drawing.Point(209, 106)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NazovTextBox.TabIndex = 4
        '
        'Zaciatok_kurzuLabel
        '
        Zaciatok_kurzuLabel.AutoSize = True
        Zaciatok_kurzuLabel.Location = New System.Drawing.Point(122, 136)
        Zaciatok_kurzuLabel.Name = "Zaciatok_kurzuLabel"
        Zaciatok_kurzuLabel.Size = New System.Drawing.Size(79, 13)
        Zaciatok_kurzuLabel.TabIndex = 5
        Zaciatok_kurzuLabel.Text = "zaciatok kurzu:"
        '
        'Zaciatok_kurzuDateTimePicker
        '
        Me.Zaciatok_kurzuDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.KurzBindingSource, "zaciatok_kurzu", True))
        Me.Zaciatok_kurzuDateTimePicker.Location = New System.Drawing.Point(209, 132)
        Me.Zaciatok_kurzuDateTimePicker.Name = "Zaciatok_kurzuDateTimePicker"
        Me.Zaciatok_kurzuDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Zaciatok_kurzuDateTimePicker.TabIndex = 6
        '
        'Koniec_kurzuLabel
        '
        Koniec_kurzuLabel.AutoSize = True
        Koniec_kurzuLabel.Location = New System.Drawing.Point(122, 162)
        Koniec_kurzuLabel.Name = "Koniec_kurzuLabel"
        Koniec_kurzuLabel.Size = New System.Drawing.Size(71, 13)
        Koniec_kurzuLabel.TabIndex = 7
        Koniec_kurzuLabel.Text = "koniec kurzu:"
        '
        'Koniec_kurzuDateTimePicker
        '
        Me.Koniec_kurzuDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.KurzBindingSource, "koniec_kurzu", True))
        Me.Koniec_kurzuDateTimePicker.Location = New System.Drawing.Point(209, 158)
        Me.Koniec_kurzuDateTimePicker.Name = "Koniec_kurzuDateTimePicker"
        Me.Koniec_kurzuDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Koniec_kurzuDateTimePicker.TabIndex = 8
        '
        'TypLabel
        '
        TypLabel.AutoSize = True
        TypLabel.Location = New System.Drawing.Point(122, 187)
        TypLabel.Name = "TypLabel"
        TypLabel.Size = New System.Drawing.Size(24, 13)
        TypLabel.TabIndex = 9
        TypLabel.Text = "typ:"
        '
        'TypComboBox
        '
        Me.TypComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "typ", True))
        Me.TypComboBox.FormattingEnabled = True
        Me.TypComboBox.Location = New System.Drawing.Point(209, 184)
        Me.TypComboBox.Name = "TypComboBox"
        Me.TypComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TypComboBox.TabIndex = 10
        '
        'Miesto_konaniaLabel
        '
        Miesto_konaniaLabel.AutoSize = True
        Miesto_konaniaLabel.Location = New System.Drawing.Point(122, 214)
        Miesto_konaniaLabel.Name = "Miesto_konaniaLabel"
        Miesto_konaniaLabel.Size = New System.Drawing.Size(81, 13)
        Miesto_konaniaLabel.TabIndex = 11
        Miesto_konaniaLabel.Text = "miesto konania:"
        '
        'Miesto_konaniaComboBox
        '
        Me.Miesto_konaniaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "miesto_konania", True))
        Me.Miesto_konaniaComboBox.FormattingEnabled = True
        Me.Miesto_konaniaComboBox.Location = New System.Drawing.Point(209, 211)
        Me.Miesto_konaniaComboBox.Name = "Miesto_konaniaComboBox"
        Me.Miesto_konaniaComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Miesto_konaniaComboBox.TabIndex = 12
        '
        'kurz_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 320)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(NazovLabel)
        Me.Controls.Add(Me.NazovTextBox)
        Me.Controls.Add(Zaciatok_kurzuLabel)
        Me.Controls.Add(Me.Zaciatok_kurzuDateTimePicker)
        Me.Controls.Add(Koniec_kurzuLabel)
        Me.Controls.Add(Me.Koniec_kurzuDateTimePicker)
        Me.Controls.Add(TypLabel)
        Me.Controls.Add(Me.TypComboBox)
        Me.Controls.Add(Miesto_konaniaLabel)
        Me.Controls.Add(Me.Miesto_konaniaComboBox)
        Me.Controls.Add(Me.KurzBindingNavigator)
        Me.Name = "kurz_detail"
        Me.Text = "kurz_detail"
        CType(Me.PilcikdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KurzBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KurzBindingNavigator.ResumeLayout(False)
        Me.KurzBindingNavigator.PerformLayout()
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
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zaciatok_kurzuDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Koniec_kurzuDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TypComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Miesto_konaniaComboBox As System.Windows.Forms.ComboBox
End Class
