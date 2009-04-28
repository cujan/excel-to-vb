Public Class kontrolne_strelby_gula

    Private Sub ClenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClenoviaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kontrolne_strelby_gulaDataSet1)

    End Sub

    Private Sub kontrolne_strelby_gula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kontrolne_strelby_gulaDataSet1.clenovia' table. You can move, or remove it, as needed.
        Me.ClenoviaTableAdapter.Fill(Me.Kontrolne_strelby_gulaDataSet1.clenovia)

    End Sub
End Class