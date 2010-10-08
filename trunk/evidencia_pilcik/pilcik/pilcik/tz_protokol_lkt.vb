Public Class tz_protokol_lkt

    Private Sub tz_protokol_lkt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim id_kurzu As Integer = tlacove_zostavy.protokol_kurzComboBox.SelectedValue()


        'TODO: This line of code loads data into the 'protokolDataSet.kurz' table. You can move, or remove it, as needed.
        Me.kurzTableAdapter.Fill(Me.protokolDataSet.kurz, id_kurzu)
        'TODO: This line of code loads data into the 'protokolDataSet.skusobna_komisia' table. You can move, or remove it, as needed.
        Me.skusobna_komisiaTableAdapter.Fill(Me.protokolDataSet.skusobna_komisia)
        'TODO: This line of code loads data into the 'protokolDataSet.osoba' table. You can move, or remove it, as needed.
        Me.osobaTableAdapter.Fill(Me.protokolDataSet.osoba, id_kurzu)
        'TODO: This line of code loads data into the 'pocet_clenov_kurzuDataSet.clenovia_kurzu' table. You can move, or remove it, as needed.
        Me.clenovia_kurzuTableAdapter.Fill(Me.pocet_clenov_kurzuDataSet.clenovia_kurzu, id_kurzu)
        'TODO: This line of code loads data into the 'vseobecne_udajeDataSet.vseobecne_udaje' table. You can move, or remove it, as needed.
        Me.vseobecne_udajeTableAdapter.Fill(Me.vseobecne_udajeDataSet.vseobecne_udaje)


        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class