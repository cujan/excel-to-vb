Public Class zoznam_zdruzeni

    Private Sub zoznam_zdruzeni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'spz_evidencia_zoznam_zdruzeni.zdruzenie' table. You can move, or remove it, as needed.
        Me.zdruzenieTableAdapter.Fill(Me.spz_evidencia_zoznam_zdruzeni.zdruzenie)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class