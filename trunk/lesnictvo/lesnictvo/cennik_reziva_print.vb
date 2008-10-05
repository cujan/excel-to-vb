Public Class cennik_reziva_print

    Private Sub Druh_rezivaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Druh_rezivaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Druh_rezivaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Cennik_reziva_print_db)

    End Sub

    Private Sub cennik_reziva_print_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cennik_reziva_print_db.druh_reziva' table. You can move, or remove it, as needed.
        Me.Druh_rezivaTableAdapter.Fill(Me.Cennik_reziva_print_db.druh_reziva)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Druh_rezivaBindingNavigator.Hide()
        Me.print_cennik_reziva.Form.BackColor = Color.White
        Me.print_cennik_reziva.PrinterSettings.DefaultPageSettings.Landscape = False
        Me.print_cennik_reziva.PrintAction = Printing.PrintAction.PrintToPreview
        Me.print_cennik_reziva.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        Me.Druh_rezivaBindingNavigator.Show()

    End Sub
End Class