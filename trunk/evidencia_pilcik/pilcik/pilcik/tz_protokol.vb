Public Class tz_protokol

    Private Sub tz_protokol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim id_kurzu As Integer = tlacove_zostavy.protokol_kurzComboBox.SelectedValue

        'TODO: This line of code loads data into the 'Protokol_kurzDataSet.kurz' table. You can move, or remove it, as needed.
        Me.KurzTableAdapter.Fill(Me.Protokol_kurzDataSet.kurz, id_kurzu)
        'TODO: This line of code loads data into the 'pilcikdbDataSet.skusobna_komisia' table. You can move, or remove it, as needed.
        Me.skusobna_komisiaTableAdapter.Fill(Me.pilcikdbDataSet.skusobna_komisia)
        'TODO: This line of code loads data into the 'protokolDataSet.protokolDataTable' table. You can move, or remove it, as needed.
        Me.OsobaTableAdapter.Fill(Me.ProtokolDataSet.osoba, id_kurzu)




        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ReportViewer1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class