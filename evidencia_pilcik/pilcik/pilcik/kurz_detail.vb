Public Class kurz_detail

    Private Sub KurzBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub kurz_detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = hlavna_aplikacia
        Dim id_vybrateho_kurzu As Integer = kurz_novy.Label2.Text
        'TODO: This line of code loads data into the 'Clenovia_kurzuDataSet.clenovia_kurzu' table. You can move, or remove it, as needed.
        Me.Clenovia_kurzuTableAdapter.FillBy_parameter(Me.Clenovia_kurzuDataSet.clenovia_kurzu, id_vybrateho_kurzu)

        'TODO: This line of code loads data into the 'PilcikdbDataSet.kurz' table. You can move, or remove it, as needed.
        Me.KurzTableAdapter.FillBy_id_kurzu(Me.PilcikdbDataSet.kurz, id_vybrateho_kurzu)

        'TODO: This line of code loads data into the 'Clenovia_kurzuDataSet.clenovia_kurzu' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'KurzComboDataSet.kurz' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'PilcikdbDataSet.kurz' table. You can move, or remove it, as needed.
        Label1.BringToFront()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(kurz_novy.Label2.Text)
    End Sub

    Private Sub pridaj_clenaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pridaj_clenaButton.Click
        clen_kurzu_pridaj.Show()
    End Sub

    Private Sub Clenovia_kurzuDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Clenovia_kurzuDataGridView.CellClick
        Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clenovia_kurzuBindingSource, "osoba_id", True))
        Label3.Text = Label2.Text
        Label2.DataBindings.Clear()
    End Sub

    Private Sub Clenovia_kurzuDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Clenovia_kurzuDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Label2.Text <> "" Then
            If MsgBox("Naozaj chcete odobrať  vybraného člena z kurzu ?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim id_clen As Integer = Label2.Text
                Dim id_kurz As Integer = IdLabel1.Text

                Dim con As New SqlCeConnection(pripojovaci_retazec)
                Dim com As New SqlCeCommand("DELETE FROM clenovia_kurzu WHERE(kurz_id = @id_kurz) AND (clen_id = @id_clen)", con)
                com.Parameters.AddWithValue("id_clen", id_clen)
                com.Parameters.AddWithValue("id_kurz", id_kurz)

                con.Open()
                com.ExecuteNonQuery()
                con.Close()
                Me.Clenovia_kurzuTableAdapter.FillBy_parameter(Me.Clenovia_kurzuDataSet.clenovia_kurzu, id_kurz)
                kurz_novy.KurzTableAdapter.Fill(kurz_novy.Kurz_pocetDataSet.kurz)
            End If
        Else
            MsgBox("Nemáte vybraného žiadneho člena.")
        End If
    End Sub

    Private Sub KurzBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KurzBindingNavigatorSaveItem.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class