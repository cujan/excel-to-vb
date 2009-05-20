Public Class tlac_clen_a4

    Private Sub tlac_clen_a4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'spz_clenovia_report_a4.clenovia' table. You can move, or remove it, as needed.
        Me.clenoviaTableAdapter.Fill(Me.spz_clenovia_report_a4.clenovia)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class