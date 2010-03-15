Public Class osoba_prehlad

    Private Sub osoba_prehlad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PilcikdbDataSet.osoba' table. You can move, or remove it, as needed.
        Me.OsobaTableAdapter.Fill(Me.PilcikdbDataSet.osoba)
        Me.MdiParent = hlavna_aplikacia
    End Sub

    Private Sub OsobaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OsobaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OsobaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PilcikdbDataSet)

    End Sub

    Private Sub priezviskoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles priezviskoTextBox.TextChanged
        Dim priezvisko As String = priezviskoTextBox.Text & "%"
        Me.OsobaTableAdapter.FillBy_priezvisko(Me.PilcikdbDataSet.osoba, priezvisko)
    End Sub
End Class