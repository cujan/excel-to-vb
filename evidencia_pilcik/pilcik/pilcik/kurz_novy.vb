Public Class kurz_novy

    Private Sub KurzBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KurzBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.KurzBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pilcik_dbDataSet)

    End Sub

    Private Sub kurz_novy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.kurz' table. You can move, or remove it, as needed.
        Me.KurzTableAdapter.Fill(Me.Pilcik_dbDataSet.kurz)

    End Sub
End Class