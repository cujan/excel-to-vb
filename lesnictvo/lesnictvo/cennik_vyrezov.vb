Public Class cennik_vyrezov

    Private Sub Druh_rezivaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub cennik_vyrezov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cennik_vyrezovDataSet1.vyrezy' table. You can move, or remove it, as needed.
        Me.VyrezyTableAdapter.Fill(Me.Cennik_vyrezovDataSet1.vyrezy)

    End Sub

    Private Sub VyrezyBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VyrezyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VyrezyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Cennik_vyrezovDataSet1)

    End Sub

    Private Sub tlacit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlacit.Click
        cennik_vyrezov_print.Show()

    End Sub
End Class