Public Class zoznam_clenov_full
    Dim zdruzenie As Integer
    Dim d_narodenia As Date
    Dim narodnost As Integer
    Dim st_prislusnost As Integer
    Dim clen_od As Integer
    Dim clenske_do As Integer
    Dim pl_vydany_po As Date
    Dim zp_vydany_po As Date
    Dim datum_zaciatok = "01.01.1900"



    Private Sub zoznam_clenov_full_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        hlavna_aplikacia.vytvor_all_clenovia()

        zdruzenie = 123
        d_narodenia = CDate(datum_zaciatok)
        narodnost = 1
        st_prislusnost = 1
        clen_od = 1900
        clenske_do = 2100
        pl_vydany_po = CDate(datum_zaciatok)
        zp_vydany_po = CDate(datum_zaciatok)
        Me.all_clenoviaTableAdapter.Fill(Me.zoznam_clenov.all_clenovia, zdruzenie, st_prislusnost, narodnost, d_narodenia, pl_vydany_po, zp_vydany_po, clen_od, clenske_do)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub zdruzenie_checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zdruzenie_checkbox.CheckedChanged
        If Me.zdruzenie_checkbox.Checked Then
            zdruzenia_combo.Enabled = True
        Else
            zdruzenia_combo.Enabled = False
        End If
    End Sub

    Private Sub clen_spz_od_checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clen_spz_od_checkbox.CheckedChanged
        If Me.clen_spz_od_checkbox.Checked Then
            clen_spz_od_combo.Enabled = True
        Else
            clen_spz_od_combo.Enabled = False
        End If
    End Sub

    Private Sub clenske_do_checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clenske_do_checkbox.CheckedChanged
        If clenske_do_checkbox.Checked Then
            clenske_do_combo.Enabled = True
        Else
            clenske_do_combo.Enabled = False
        End If
    End Sub

    Private Sub dat_narodenia_checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dat_narodenia_checkbox.CheckedChanged
        If dat_narodenia_checkbox.Checked Then
            dat_narodenia_dt_picker.Enabled = True

        Else
            dat_narodenia_dt_picker.Enabled = False
        End If
    End Sub

    Private Sub narodnost_checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles narodnost_checkbox.CheckedChanged
        If narodnost_checkbox.Checked Then
            narodnost_combo.Enabled = True
        Else
            narodnost_combo.Enabled = False
        End If
    End Sub

    Private Sub st_prislusnost_checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_prislusnost_checkbox.CheckedChanged
        If st_prislusnost_checkbox.Checked Then
            st_prislusnost_combo.Enabled = True
        Else
            st_prislusnost_combo.Enabled = False
        End If
    End Sub

    Private Sub pl_vydany_po_checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pl_vydany_po_checkbox.CheckedChanged
        If pl_vydany_po_checkbox.Checked Then
            pl_vydany_po_dt_picker.Enabled = True

        Else
            pl_vydany_po_dt_picker.Enabled = False
        End If
    End Sub

    Private Sub zp_vydany_po_checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zp_vydany_po_checkbox.CheckedChanged
        If zp_vydany_po_checkbox.Checked Then
            zp_vydany_po_dt_picker.Enabled = True
        Else
            zp_vydany_po_dt_picker.Enabled = False
        End If
    End Sub
End Class