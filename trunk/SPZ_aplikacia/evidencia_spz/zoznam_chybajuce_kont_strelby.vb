Public Class zoznam_chybajuce_kont_strelby
    Dim podla_zbrane_gula As String
    Dim podla_zbrane_brok As String
    Dim rok As Integer
    Private Sub podla_zbrane_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles podla_zbrane_check.CheckedChanged
        If podla_zbrane_check.Checked Then
            podla_zbrane_combo.Enabled = True
        Else
            podla_zbrane_combo.Enabled = False
            podla_zbrane_gula = "ÁNO"
            podla_zbrane_brok = "ÁNO"
        End If

    End Sub

    Private Sub chybajuce_kont_strelby_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'zoznam_kontStrelby.all_clenovia' table. You can move, or remove it, as needed.
        hlavna_aplikacia.vytvor_all_clenovia()

        podla_zbrane_gula = "ÁNO"
        podla_zbrane_brok = "ÁNO"
        Me.all_clenoviaTableAdapter.Fill(Me.zoznam_kontStrelby.all_clenovia, podla_zbrane_brok, podla_zbrane_gula)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub podla_zbrane_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles podla_zbrane_combo.SelectedIndexChanged
        If podla_zbrane_combo.SelectedIndex = 0 Then
            podla_zbrane_brok = "ÁNO"
            podla_zbrane_gula = "Vypnut"
            Me.all_clenoviaTableAdapter.Fill(Me.zoznam_kontStrelby.all_clenovia, podla_zbrane_brok, podla_zbrane_gula)
            Me.ReportViewer1.RefreshReport()
        ElseIf podla_zbrane_combo.SelectedIndex = 1 Then
            podla_zbrane_brok = "Vypnut"
            podla_zbrane_gula = "ÁNO"
            Me.all_clenoviaTableAdapter.Fill(Me.zoznam_kontStrelby.all_clenovia, podla_zbrane_brok, podla_zbrane_gula)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub
End Class