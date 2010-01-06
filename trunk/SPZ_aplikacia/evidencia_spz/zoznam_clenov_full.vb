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

        zdruzenie = "'%'"
        d_narodenia = CDate(datum_zaciatok)
        narodnost = "'%'"
        st_prislusnost = "'%'"
        clen_od = 1900
        clenske_do = 2100
        pl_vydany_po = CDate(datum_zaciatok)
        zp_vydany_po = CDate(datum_zaciatok)


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

    Private Sub clen_spz_od_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clen_spz_od_combo.SelectedIndexChanged
        If clen_spz_od_combo.SelectedIndex <> -1 Then
            MsgBox("Selected value is " + clen_spz_od_combo.SelectedValue.ToString)
        End If
    End Sub

    Private Sub zdruzenia_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zdruzenia_combo.SelectedIndexChanged
        If zdruzenia_combo.SelectedIndex <> -1 Then
            MsgBox("Selected value is " + zdruzenia_combo.SelectedValue.ToString)
        End If
    End Sub

    Private Sub narodnost_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles narodnost_combo.SelectedIndexChanged
        If narodnost_combo.SelectedIndex <> -1 Then
            MsgBox("Selected value is " + narodnost_combo.SelectedValue.ToString)
        End If
    End Sub

    Private Sub st_prislusnost_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_prislusnost_combo.SelectedIndexChanged
        If st_prislusnost_combo.SelectedIndex <> -1 Then
            MsgBox("Selected value is " + st_prislusnost_combo.SelectedValue.ToString)
        End If
    End Sub
End Class