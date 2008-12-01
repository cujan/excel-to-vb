Public Class titul

    Private Sub TitulBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitulBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TitulBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TitulDataSet)


    End Sub

    Private Sub titul_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TitulDataSet.titul' table. You can move, or remove it, as needed.
        Me.TitulTableAdapter.Fill(Me.TitulDataSet.titul)

    End Sub
End Class