Public Class cennik_vyrezov_print

    Private Sub VyrezyBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VyrezyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VyrezyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Cennik_vyrezov_print_db)

    End Sub

    Private Sub cennik_vyrezov_print_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cennik_vyrezov_print_db.vyrezy' table. You can move, or remove it, as needed.
        Me.VyrezyTableAdapter.Fill(Me.Cennik_vyrezov_print_db.vyrezy)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.VyrezyBindingNavigator.Hide()
        Me.print_cennik_vyrezov.Form.BackColor = Color.White
        Me.print_cennik_vyrezov.PrinterSettings.DefaultPageSettings.Landscape = True
        Me.print_cennik_vyrezov.PrintAction = Printing.PrintAction.PrintToPreview
        Me.print_cennik_vyrezov.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        Me.VyrezyBindingNavigator.Show()

    End Sub
End Class