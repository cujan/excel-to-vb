﻿Public Class zoznam_chybajuce_kont_strelby
    Dim podla_zbrane_gula As String
    Dim podla_zbrane_brok As String
    Dim rok As Integer
    Private Sub podla_zbrane_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles podla_zbrane_check.CheckedChanged
        If podla_zbrane_check.Checked Then
            podla_zbrane_combo.Enabled = True
        Else
            podla_zbrane_combo.Enabled = False
            podla_zbrane_gula = "Áno"
            podla_zbrane_brok = "Áno"
        End If

    End Sub

    Private Sub chybajuce_kont_strelby_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'zoznam_kontStrelby.all_clenovia' table. You can move, or remove it, as needed.
        Me.all_clenoviaTableAdapter.Fill(Me.zoznam_kontStrelby.all_clenovia, podla_zbrane_brok, podla_zbrane_gula)
        
        podla_zbrane_gula = "Áno"
        podla_zbrane_brok = "Áno"

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub podla_zbrane_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles podla_zbrane_combo.SelectedIndexChanged
        If podla_zbrane_combo.SelectedValue = "Broková zbraň" Then
            podla_zbrane_brok = "Áno"
            podla_zbrane_gula = "Vypnut"
            Me.all_clenoviaTableAdapter.Fill(Me.zoznam_kontStrelby.all_clenovia, podla_zbrane_brok, podla_zbrane_gula)
            Me.ReportViewer1.RefreshReport()
        ElseIf podla_zbrane_combo.SelectedValue = "Guľová zbraň" Then
            podla_zbrane_brok = "Vypnut"
            podla_zbrane_gula = "Áno"
            Me.all_clenoviaTableAdapter.Fill(Me.zoznam_kontStrelby.all_clenovia, podla_zbrane_brok, podla_zbrane_gula)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub
End Class