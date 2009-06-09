Public Class koniec_clenstva

    Private Sub ClenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClenoviaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Koniec_clenstvaDataSet1)

    End Sub

    Private Sub koniec_clenstva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Koniec_clenstvaDataSet1.clenovia' table. You can move, or remove it, as needed.
        Me.ClenoviaTableAdapter.Fill(Me.Koniec_clenstvaDataSet1.clenovia, "2009")

    End Sub
End Class