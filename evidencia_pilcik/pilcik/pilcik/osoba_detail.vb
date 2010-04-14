Public Class osoba_detail

    Private Sub OsobaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OsobaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OsobaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PilcikdbDataSet)

    End Sub

    Private Sub osoba_detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PilcikdbDataSet.osoba' table. You can move, or remove it, as needed.
        Dim vybrana_osoba_id As Integer = osoba_pridaj.Label1.Text
        Me.OsobaTableAdapter.FillBy_id_clena(Me.PilcikdbDataSet.osoba, vybrana_osoba_id)
        Me.Clenovia_kurzuTableAdapter.Fill_osoba_id(Me.AbsolvovaneKurzyDataSet.clenovia_kurzu, vybrana_osoba_id)
        Me.MdiParent = hlavna_aplikacia
    End Sub

    Private Sub ulozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click
        Me.Validate()
        Me.OsobaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PilcikdbDataSet)

        osoba_pridaj.OsobaTableAdapter.Fill(osoba_pridaj.PilcikdbDataSet.osoba)
        MsgBox("Zmeny úspešne uložené.")
    End Sub

    Private Sub Fill_osoba_idToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
End Class