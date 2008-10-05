<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cennik_reziva_print
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cennik_reziva_print))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Cennik_reziva_print_db = New lesnictvo.cennik_reziva_print_db
        Me.Druh_rezivaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Druh_rezivaTableAdapter = New lesnictvo.cennik_reziva_print_dbTableAdapters.druh_rezivaTableAdapter
        Me.TableAdapterManager = New lesnictvo.cennik_reziva_print_dbTableAdapters.TableAdapterManager
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
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.cennik_reziva_tlacovy_vystup = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.print_cennik_reziva = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.Cennik_reziva_print_db, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Druh_rezivaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Druh_rezivaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Druh_rezivaBindingNavigator.SuspendLayout()
        CType(Me.cennik_reziva_tlacovy_vystup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cennik_reziva_print_db
        '
        Me.Cennik_reziva_print_db.DataSetName = "cennik_reziva_print_db"
        Me.Cennik_reziva_print_db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Druh_rezivaBindingSource
        '
        Me.Druh_rezivaBindingSource.DataMember = "druh_reziva"
        Me.Druh_rezivaBindingSource.DataSource = Me.Cennik_reziva_print_db
        '
        'Druh_rezivaTableAdapter
        '
        Me.Druh_rezivaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.druh_rezivaTableAdapter = Me.Druh_rezivaTableAdapter
        Me.TableAdapterManager.UpdateOrder = lesnictvo.cennik_reziva_print_dbTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Druh_rezivaBindingNavigator
        '
        Me.Druh_rezivaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Druh_rezivaBindingNavigator.BindingSource = Me.Druh_rezivaBindingSource
        Me.Druh_rezivaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Druh_rezivaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Druh_rezivaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Druh_rezivaBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.Druh_rezivaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Druh_rezivaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Druh_rezivaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Druh_rezivaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Druh_rezivaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Druh_rezivaBindingNavigator.Name = "Druh_rezivaBindingNavigator"
        Me.Druh_rezivaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Druh_rezivaBindingNavigator.Size = New System.Drawing.Size(390, 25)
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Tlačiť"
        '
        'cennik_reziva_tlacovy_vystup
        '
        Me.cennik_reziva_tlacovy_vystup.AutoGenerateColumns = False
        Me.cennik_reziva_tlacovy_vystup.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cennik_reziva_tlacovy_vystup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cennik_reziva_tlacovy_vystup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cennik_reziva_tlacovy_vystup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.cennik_reziva_tlacovy_vystup.DataSource = Me.Druh_rezivaBindingSource
        Me.cennik_reziva_tlacovy_vystup.Location = New System.Drawing.Point(0, 28)
        Me.cennik_reziva_tlacovy_vystup.Name = "cennik_reziva_tlacovy_vystup"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cennik_reziva_tlacovy_vystup.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.cennik_reziva_tlacovy_vystup.Size = New System.Drawing.Size(344, 220)
        Me.cennik_reziva_tlacovy_vystup.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "kod"
        Me.DataGridViewTextBoxColumn1.HeaderText = "kod"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "druh_reziva"
        Me.DataGridViewTextBoxColumn2.HeaderText = "druh_reziva"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cena"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cena"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'print_cennik_reziva
        '
        Me.print_cennik_reziva.DocumentName = "document"
        Me.print_cennik_reziva.Form = Me
        Me.print_cennik_reziva.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.print_cennik_reziva.PrinterSettings = CType(resources.GetObject("print_cennik_reziva.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.print_cennik_reziva.PrintFileName = Nothing
        '
        'cennik_reziva_print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 319)
        Me.Controls.Add(Me.cennik_reziva_tlacovy_vystup)
        Me.Controls.Add(Me.Druh_rezivaBindingNavigator)
        Me.Name = "cennik_reziva_print"
        Me.Text = "Tlačová zostava - Cenník reziva"
        CType(Me.Cennik_reziva_print_db, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Druh_rezivaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Druh_rezivaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Druh_rezivaBindingNavigator.ResumeLayout(False)
        Me.Druh_rezivaBindingNavigator.PerformLayout()
        CType(Me.cennik_reziva_tlacovy_vystup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cennik_reziva_print_db As lesnictvo.cennik_reziva_print_db
    Friend WithEvents Druh_rezivaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Druh_rezivaTableAdapter As lesnictvo.cennik_reziva_print_dbTableAdapters.druh_rezivaTableAdapter
    Friend WithEvents TableAdapterManager As lesnictvo.cennik_reziva_print_dbTableAdapters.TableAdapterManager
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
    Friend WithEvents cennik_reziva_tlacovy_vystup As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents print_cennik_reziva As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
