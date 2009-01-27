Public Class tlacovy_vystup_clen_1

    Private Sub tlacovy_vystup_clen_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'spz_evidenciaDataSet.clenovia' table. You can move, or remove it, as needed.
        Me.clenoviaTableAdapter.Fill(Me.spz_evidenciaDataSet.clenovia)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class