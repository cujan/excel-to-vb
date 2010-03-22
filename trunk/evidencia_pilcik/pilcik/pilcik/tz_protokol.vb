Public Class tz_protokol

    Private Sub tz_protokol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'protokolDataSet.protokolDataTable' table. You can move, or remove it, as needed.
        Dim id_kurzu As Integer = tlacove_zostavy.protokol_kurzComboBox.SelectedValue
        Me.protokolDataTableTableAdapter.Fill(Me.protokolDataSet.protokolDataTable, id_kurzu)



        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class