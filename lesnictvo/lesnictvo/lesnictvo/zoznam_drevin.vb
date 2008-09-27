Public Class zoznam_drevin
    Private Sub zoznam_drevin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Zoznam_drevinDataSet1.dreviny' table. You can move, or remove it, as needed.
        Me.DrevinyTableAdapter.Fill(Me.Zoznam_drevinDataSet1.dreviny)
        Me.MdiParent = MDIParent1
    End Sub

    Private Sub DrevinyBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrevinyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DrevinyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Zoznam_drevinDataSet1)

    End Sub
End Class