Public Class clen_kurzu_pridaj

    Private Sub clen_kurzu_pridaj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OsobaComboDataSet.osoba' table. You can move, or remove it, as needed.
        Me.OsobaTableAdapter.Fill(Me.OsobaComboDataSet.osoba)
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vybrany_kurz_id As Integer = kurz_novy.Label2.Text
        Dim vybrany_clen_id As Integer = Me.ComboBox1.SelectedValue

        Dim con As New SqlCeConnection(pripojovaci_retazec)
        Dim com As New SqlCeCommand("INSERT INTO clenovia_kurzu (kurz_id, clen_id) VALUES (@kurz_id,@clen_id)", con)
        com.Parameters.AddWithValue("kurz_id", vybrany_kurz_id)
        com.Parameters.AddWithValue("clen_id", vybrany_clen_id)
        con.Open()
        com.ExecuteNonQuery()
        con.Close()
        kurz_detail.Clenovia_kurzuTableAdapter.FillBy_parameter(kurz_detail.Clenovia_kurzuDataSet.clenovia_kurzu, vybrany_kurz_id)
    End Sub
End Class