Public Class zoznam_clenov_full
    Dim zdruzenie As String
    Dim d_narodenia As Date
    Dim narodnost As String
    Dim st_prislusnost As String
    Dim clen_od As Integer
    Dim clenske_do As Integer
    Dim pl_vydany_po As Date
    Dim zp_vydany_po As Date
    Dim datum_zaciatok = "01.01.1900"



    Private Sub zoznam_clenov_full_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'TODO: This line of code loads data into the 'St_prislusnost_combo1.statna_prislusnost' table. You can move, or remove it, as needed.
        Me.Statna_prislusnostTableAdapter.Fill(Me.St_prislusnost_combo1.statna_prislusnost)
        'TODO: This line of code loads data into the 'Narodnost_combo1.narodnost' table. You can move, or remove it, as needed.
        Me.NarodnostTableAdapter.Fill(Me.Narodnost_combo1.narodnost)
        'TODO: This line of code loads data into the 'Zoznam_zdruzeni_combo.zdruzenia' table. You can move, or remove it, as needed.
        Me.ZdruzeniaTableAdapter.Fill(Me.Zoznam_zdruzeni_combo.zdruzenia)
        'TODO: This line of code loads data into the 'Roky._roky' table. You can move, or remove it, as needed.
        Me.RokyTableAdapter.Fill(Me.Roky._roky)
        hlavna_aplikacia.vytvor_all_clenovia()

        zdruzenie = "%"
        d_narodenia = CDate(datum_zaciatok)
        narodnost = "%"
        st_prislusnost = "%"
        clen_od = 1900
        clenske_do = 2100
        pl_vydany_po = CDate(datum_zaciatok)
        zp_vydany_po = CDate(datum_zaciatok)

        Me.all_clenoviaTableAdapter.Fill(Me.zoznam_clenov.all_clenovia, d_narodenia, pl_vydany_po, zp_vydany_po, clen_od, clenske_do, zdruzenie, st_prislusnost, narodnost)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub zdruzenie_checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zdruzenie_checkbox.CheckedChanged
        If Me.zdruzenie_checkbox.Checked Then
            zdruzenia_combo.Enabled = True
            zdruzenia_combo.SelectedValue = ""
        Else
            zdruzenia_combo.Enabled = False
            zdruzenie = "%"
        End If
    End Sub

    Private Sub clen_spz_od_checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clen_spz_od_checkbox.CheckedChanged
        If Me.clen_spz_od_checkbox.Checked Then
            clen_spz_od_combo.Enabled = True
            clen_spz_od_combo.SelectedValue = 1900
        Else
            clen_spz_od_combo.Enabled = False
            clen_od = 1900
        End If
    End Sub

    Private Sub clenske_do_checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clenske_do_checkbox.CheckedChanged
        If clenske_do_checkbox.Checked Then
            clenske_do_combo.Enabled = True
            clenske_do_combo.SelectedValue = 1900
        Else
            clenske_do_combo.Enabled = False
            clenske_do = 2100
        End If
    End Sub

    Private Sub dat_narodenia_checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dat_narodenia_checkbox.CheckedChanged
        If dat_narodenia_checkbox.Checked Then
            dat_narodenia_dt_picker.Enabled = True
            dat_narodenia_dt_picker.Value = datum_zaciatok
        Else
            dat_narodenia_dt_picker.Enabled = False
            d_narodenia = CDate(datum_zaciatok)
        End If
    End Sub

    Private Sub narodnost_checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles narodnost_checkbox.CheckedChanged
        If narodnost_checkbox.Checked Then
            narodnost_combo.Enabled = True
            narodnost_combo.SelectedValue = ""
        Else
            narodnost_combo.Enabled = False
            narodnost = "%"
        End If
    End Sub

    Private Sub st_prislusnost_checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_prislusnost_checkbox.CheckedChanged
        If st_prislusnost_checkbox.Checked Then
            st_prislusnost_combo.Enabled = True
            st_prislusnost_combo.SelectedValue = ""
        Else
            st_prislusnost_combo.Enabled = False
            st_prislusnost = "%"
        End If
    End Sub

    Private Sub pl_vydany_po_checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pl_vydany_po_checkbox.CheckedChanged
        If pl_vydany_po_checkbox.Checked Then
            pl_vydany_po_dt_picker.Enabled = True
            pl_vydany_po_dt_picker.Value = datum_zaciatok
        Else
            pl_vydany_po_dt_picker.Enabled = False
            pl_vydany_po = CDate(datum_zaciatok)
        End If
    End Sub

    Private Sub zp_vydany_po_checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zp_vydany_po_checkbox.CheckedChanged
        If zp_vydany_po_checkbox.Checked Then
            zp_vydany_po_dt_picker.Enabled = True
            zp_vydany_po_dt_picker.Value = datum_zaciatok
        Else
            zp_vydany_po_dt_picker.Enabled = False
            zp_vydany_po = CDate(datum_zaciatok)
        End If
    End Sub

    Private Sub clen_spz_od_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clen_spz_od_combo.SelectedIndexChanged
        If clen_spz_od_combo.SelectedIndex <> -1 Then
            clen_od = clen_spz_od_combo.SelectedValue.ToString
            Me.all_clenoviaTableAdapter.Fill(Me.zoznam_clenov.all_clenovia, d_narodenia, pl_vydany_po, zp_vydany_po, clen_od, clenske_do, zdruzenie, st_prislusnost, narodnost)
            Me.ReportViewer1.RefreshReport()
            'MsgBox("Selected values are " + vbNewLine + " zdruzenie = " + zdruzenie + vbNewLine + "Clen od = " + clen_od.ToString + vbNewLine + "Clenske do = " + clenske_do.ToString + vbNewLine + "narodnost = " + narodnost + vbNewLine + "St prisl = " + st_prislusnost + vbNewLine + "dat narodenia = " + d_narodenia + vbNewLine + "pl vydany = " + pl_vydany_po.ToString + vbNewLine + "zp vydany = " + zp_vydany_po.ToString)
        End If
    End Sub

    Private Sub zdruzenia_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zdruzenia_combo.SelectedIndexChanged
        If zdruzenia_combo.SelectedIndex <> -1 Then
            zdruzenie = zdruzenia_combo.SelectedValue.ToString
            Me.all_clenoviaTableAdapter.Fill(Me.zoznam_clenov.all_clenovia, d_narodenia, pl_vydany_po, zp_vydany_po, clen_od, clenske_do, zdruzenie, st_prislusnost, narodnost)
            Me.ReportViewer1.RefreshReport()
            'MsgBox("Selected values are " + vbNewLine + " zdruzenie = " + zdruzenie + vbNewLine + "Clen od = " + clen_od.ToString + vbNewLine + "Clenske do = " + clenske_do.ToString + vbNewLine + "narodnost = " + narodnost + vbNewLine + "St prisl = " + st_prislusnost + vbNewLine + "dat narodenia = " + d_narodenia + vbNewLine + "pl vydany = " + pl_vydany_po.ToString + vbNewLine + "zp vydany = " + zp_vydany_po.ToString)
        End If
    End Sub

    Private Sub narodnost_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles narodnost_combo.SelectedIndexChanged
        If narodnost_combo.SelectedIndex <> -1 Then
            narodnost = narodnost_combo.SelectedValue.ToString
            Me.all_clenoviaTableAdapter.Fill(Me.zoznam_clenov.all_clenovia, d_narodenia, pl_vydany_po, zp_vydany_po, clen_od, clenske_do, zdruzenie, st_prislusnost, narodnost)
            Me.ReportViewer1.RefreshReport()
            'MsgBox("Selected values are " + vbNewLine + " zdruzenie = " + zdruzenie + vbNewLine + "Clen od = " + clen_od.ToString + vbNewLine + "Clenske do = " + clenske_do.ToString + vbNewLine + "narodnost = " + narodnost + vbNewLine + "St prisl = " + st_prislusnost + vbNewLine + "dat narodenia = " + d_narodenia + vbNewLine + "pl vydany = " + pl_vydany_po.ToString + vbNewLine + "zp vydany = " + zp_vydany_po.ToString)
        End If
    End Sub

    Private Sub st_prislusnost_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_prislusnost_combo.SelectedIndexChanged
        If st_prislusnost_combo.SelectedIndex <> -1 Then
            st_prislusnost = st_prislusnost_combo.SelectedValue.ToString
            Me.all_clenoviaTableAdapter.Fill(Me.zoznam_clenov.all_clenovia, d_narodenia, pl_vydany_po, zp_vydany_po, clen_od, clenske_do, zdruzenie, st_prislusnost, narodnost)
            Me.ReportViewer1.RefreshReport()
            'MsgBox("Selected values are " + vbNewLine + " zdruzenie = " + zdruzenie + vbNewLine + "Clen od = " + clen_od.ToString + vbNewLine + "Clenske do = " + clenske_do.ToString + vbNewLine + "narodnost = " + narodnost + vbNewLine + "St prisl = " + st_prislusnost + vbNewLine + "dat narodenia = " + d_narodenia + vbNewLine + "pl vydany = " + pl_vydany_po.ToString + vbNewLine + "zp vydany = " + zp_vydany_po.ToString)
        End If
    End Sub

    Private Sub clenske_do_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clenske_do_combo.SelectedIndexChanged
        If clenske_do_combo.SelectedIndex <> -1 Then
            clenske_do = clenske_do_combo.SelectedValue.ToString
            Me.all_clenoviaTableAdapter.Fill(Me.zoznam_clenov.all_clenovia, d_narodenia, pl_vydany_po, zp_vydany_po, clen_od, clenske_do, zdruzenie, st_prislusnost, narodnost)
            Me.ReportViewer1.RefreshReport()
            'MsgBox("Selected values are " + vbNewLine + " zdruzenie = " + zdruzenie + vbNewLine + "Clen od = " + clen_od.ToString + vbNewLine + "Clenske do = " + clenske_do.ToString + vbNewLine + "narodnost = " + narodnost + vbNewLine + "St prisl = " + st_prislusnost + vbNewLine + "dat narodenia = " + d_narodenia + vbNewLine + "pl vydany = " + pl_vydany_po.ToString + vbNewLine + "zp vydany = " + zp_vydany_po.ToString)
        End If
    End Sub

    Private Sub dat_narodenia_dt_picker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dat_narodenia_dt_picker.ValueChanged
        If dat_narodenia_dt_picker.Value <> datum_zaciatok Then
            d_narodenia = dat_narodenia_dt_picker.Value
            Me.all_clenoviaTableAdapter.Fill(Me.zoznam_clenov.all_clenovia, d_narodenia, pl_vydany_po, zp_vydany_po, clen_od, clenske_do, zdruzenie, st_prislusnost, narodnost)
            Me.ReportViewer1.RefreshReport()
            'MsgBox("Selected values are " + vbNewLine + " zdruzenie = " + zdruzenie + vbNewLine + "Clen od = " + clen_od.ToString + vbNewLine + "Clenske do = " + clenske_do.ToString + vbNewLine + "narodnost = " + narodnost + vbNewLine + "St prisl = " + st_prislusnost + vbNewLine + "dat narodenia = " + d_narodenia + vbNewLine + "pl vydany = " + pl_vydany_po.ToString + vbNewLine + "zp vydany = " + zp_vydany_po.ToString)
        End If
    End Sub

    Private Sub pl_vydany_po_dt_picker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pl_vydany_po_dt_picker.ValueChanged
        If pl_vydany_po_dt_picker.Value <> datum_zaciatok Then
            pl_vydany_po = pl_vydany_po_dt_picker.Value
            Me.all_clenoviaTableAdapter.Fill(Me.zoznam_clenov.all_clenovia, d_narodenia, pl_vydany_po, zp_vydany_po, clen_od, clenske_do, zdruzenie, st_prislusnost, narodnost)
            Me.ReportViewer1.RefreshReport()
            'MsgBox("Selected values are " + vbNewLine + " zdruzenie = " + zdruzenie + vbNewLine + "Clen od = " + clen_od.ToString + vbNewLine + "Clenske do = " + clenske_do.ToString + vbNewLine + "narodnost = " + narodnost + vbNewLine + "St prisl = " + st_prislusnost + vbNewLine + "dat narodenia = " + d_narodenia + vbNewLine + "pl vydany = " + pl_vydany_po.ToString + vbNewLine + "zp vydany = " + zp_vydany_po.ToString)
        End If
    End Sub

    Private Sub zp_vydany_po_dt_picker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zp_vydany_po_dt_picker.ValueChanged
        If zp_vydany_po_dt_picker.Value <> datum_zaciatok Then
            zp_vydany_po = zp_vydany_po_dt_picker.Value
            Me.all_clenoviaTableAdapter.Fill(Me.zoznam_clenov.all_clenovia, d_narodenia, pl_vydany_po, zp_vydany_po, clen_od, clenske_do, zdruzenie, st_prislusnost, narodnost)
            Me.ReportViewer1.RefreshReport()
            'MsgBox("Selected values are " + vbNewLine + " zdruzenie = " + zdruzenie + vbNewLine + "Clen od = " + clen_od.ToString + vbNewLine + "Clenske do = " + clenske_do.ToString + vbNewLine + "narodnost = " + narodnost + vbNewLine + "St prisl = " + st_prislusnost + vbNewLine + "dat narodenia = " + d_narodenia + vbNewLine + "pl vydany = " + pl_vydany_po.ToString + vbNewLine + "zp vydany = " + zp_vydany_po.ToString)
        End If
    End Sub

    Private Sub generuj_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generuj_button.Click
        Me.all_clenoviaTableAdapter.Fill(Me.zoznam_clenov.all_clenovia, d_narodenia, pl_vydany_po, zp_vydany_po, clen_od, clenske_do, zdruzenie, st_prislusnost, narodnost)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class