Public Class skusobna_komisia

    Private Sub Skusobna_komisiaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Skusobna_komisiaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Skusobna_komisiaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PilcikdbDataSet)

    End Sub

    Private Sub skusobna_komisia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PilcikdbDataSet.skusobna_komisia' table. You can move, or remove it, as needed.
        Me.Skusobna_komisiaTableAdapter.Fill(Me.PilcikdbDataSet.skusobna_komisia)

        Me.MdiParent = hlavna_aplikacia
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.Skusobna_komisiaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PilcikdbDataSet)
    End Sub
End Class