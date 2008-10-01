Public Class odberatelia_print

    Private Sub OdberateliaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OdberateliaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OdberateliaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Odberatelia_print_Dataset)

    End Sub

    Private Sub odberatelia_print_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Odberatelia_print_Dataset.odberatelia' table. You can move, or remove it, as needed.
        Me.OdberateliaTableAdapter.Fill(Me.Odberatelia_print_Dataset.odberatelia)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.OdberateliaBindingNavigator.Hide()
        Me.print_odberatelia.Form.BackColor = Color.White
        Me.print_odberatelia.PrinterSettings.DefaultPageSettings.Landscape = False

        Me.print_odberatelia.PrintAction = Printing.PrintAction.PrintToPreview
        Me.print_odberatelia.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        Me.OdberateliaBindingNavigator.Show()


    End Sub
End Class