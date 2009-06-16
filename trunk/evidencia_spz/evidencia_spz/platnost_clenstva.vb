Public Class platnost_clenstva


    Private Sub platnost_clenstva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'koniec_clenstvaDataSet1.clenovia' table. You can move, or remove it, as needed.
        Dim rok As String
        rok = Date.Today.Year.ToString
        'If ComboBox1.SelectedItem <> "" Then
        '    rok = ComboBox1.SelectedItem.ToString
        'End If
        ComboBox1.SelectedItem = rok
        Me.clenoviaTableAdapter.Fill(Me.koniec_clenstvaDataSet1.clenovia, rok)
        upozornenie.Text = "Upozornenie: Daný výstup zobrazí iba členov, ktorým členstvo končí v roku " & ComboBox1.SelectedItem.ToString & ". Členovia, ktorým členstvo končí v predchádzajúcich rokoch tu nie sú zobrazení!"
        'TODO: This line of code loads data into the 'Kontrolne_strelby_brokDataSet1.clenovia' table. You can move, or remove it, as needed.
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim rok As String
        rok = ComboBox1.SelectedItem.ToString
        Me.clenoviaTableAdapter.Fill(Me.koniec_clenstvaDataSet1.clenovia, rok)
        upozornenie.Text = "Upozornenie: Daný výstup zobrazí iba členov, ktorým členstvo končí v roku " & ComboBox1.SelectedItem.ToString & ". Členovia, ktorým členstvo končí v predchádzajúcich rokoch tu nie sú zobrazení!"
        'TODO: This line of code loads data into the 'Kontrolne_strelby_brokDataSet1.clenovia' table. You can move, or remove it, as needed.
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class