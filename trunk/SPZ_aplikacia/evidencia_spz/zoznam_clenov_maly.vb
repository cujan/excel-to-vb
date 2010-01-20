Public Class zoznam_clenov_maly

    Private Sub zoznam_clenov_maly_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'kartyClenov.karty_clenov' table. You can move, or remove it, as needed.

        hlavna_aplikacia.vytvor_all_clenovia()
        Me.karty_clenovTableAdapter.Fill(Me.kartyClenov.karty_clenov)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class