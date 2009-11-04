Public Class typ_ubytovania

    Private Sub Typ_ubytovaniaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Typ_ubytovaniaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Typ_ubytovaniaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Typ_ubytovaniaDataSet)

    End Sub

    Private Sub typ_ubytovania_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Typ_ubytovaniaDataSet.typ_ubytovania' table. You can move, or remove it, as needed.
        Me.Typ_ubytovaniaTableAdapter.Fill(Me.Typ_ubytovaniaDataSet.typ_ubytovania)

    End Sub
End Class