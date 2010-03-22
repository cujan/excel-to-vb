Public Class kurz_detail

    Private Sub KurzBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KurzBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.KurzBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PilcikdbDataSet)

    End Sub

    Private Sub kurz_detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PilcikdbDataSet.kurz' table. You can move, or remove it, as needed.
        Me.KurzTableAdapter.FillBy_id(Me.PilcikdbDataSet.kurz, kurz_novy.Label2.Text)

    End Sub
End Class