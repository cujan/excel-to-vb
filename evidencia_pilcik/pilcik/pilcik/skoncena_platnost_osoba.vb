Public Class skoncena_platnost_osoba

    Private Sub OsobaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OsobaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OsobaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Vyprsanie_platnosti_preukazuDataSet)

    End Sub

    Private Sub skoncena_platnost_osoba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Vyprsanie_platnosti_preukazuDataSet.osoba' table. You can move, or remove it, as needed.
        Me.OsobaTableAdapter.FillBy_skoncena_platnost(Me.Vyprsanie_platnosti_preukazuDataSet.osoba)

    End Sub
End Class