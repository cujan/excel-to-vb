Public Class registracia_aplikacie

    Private Sub Vseobecne_udajeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vseobecne_udajeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Vseobecne_udajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Spz_vseobecne_udaje)

    End Sub

    Private Sub registracia_aplikacie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Spz_vseobecne_udaje.vseobecne_udaje' table. You can move, or remove it, as needed.
        Me.Vseobecne_udajeTableAdapter.Fill(Me.Spz_vseobecne_udaje.vseobecne_udaje)

    End Sub
End Class