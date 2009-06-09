Public Class zoznam_clenov_report

    Private Sub zoznam_clenov_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'spz_zoznam_clenov_reportDataSet1.clenovia' table. You can move, or remove it, as needed.
        Me.clenoviaTableAdapter.Fill(Me.spz_zoznam_clenov_reportDataSet1.clenovia)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class