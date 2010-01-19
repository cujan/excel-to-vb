Public Class zoznam_zdruzeni_full
    Dim vymera As Long
    Dim najomna_zmluva As Integer
    Dim psy_plan As Integer
    Dim psy_typy_plan As Integer
    Dim psy_typy_skutocnost As Integer
    Dim psy_skutocnost As Integer
    Dim jelenia As Integer
    Dim srncia As Integer
    Dim diviacia As Integer
    Dim bazant As Integer
    Dim ina As Integer
    Dim zaciatok_datum As Date

    Private Sub zoznam_zdruzeni_full_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Roky._roky' table. You can move, or remove it, as needed.
        Me.RokyTableAdapter.Fill(Me.Roky._roky)
        'TODO: This line of code loads data into the 'zoznam_zdruzeni_report_full.zdruzenia' table. You can move, or remove it, as needed.
        hlavna_aplikacia.vytvor_all_clenovia()

        vymera = 0

        najomna_zmluva = 1900
        psy_plan = 0
        psy_typy_plan = 0
        psy_typy_skutocnost = 0
        psy_skutocnost = 0
        jelenia = 0
        srncia = 0
        diviacia = 0
        bazant = 0
        ina = 0

        Me.zdruzeniaTableAdapter.Fill(Me.zoznam_zdruzeni_report_full.zdruzenia, vymera, najomna_zmluva, psy_plan, psy_typy_plan, psy_typy_skutocnost, psy_skutocnost, jelenia, srncia, diviacia, bazant, ina)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub vymera_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vymera_check.CheckedChanged
        If vymera_check.Checked Then
            vymera_combo.Enabled = True
            vymera_combo.SelectedValue = ""
        Else
            vymera_combo.Enabled = False
            vymera = 0
        End If
    End Sub

    Private Sub najomna_zmluva_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles najomna_zmluva_check.CheckedChanged
        If najomna_zmluva_check.Checked Then
            platnost_naj_zmluvy_combo.Enabled = True
            'platnost_naj_zmluvy_combo.SelectedValue = Nullable

        Else
            platnost_naj_zmluvy_combo.Enabled = False
            najomna_zmluva = 1900
        End If
    End Sub

    Private Sub psy_plan_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles psy_plan_check.CheckedChanged
        If psy_plan_check.Checked Then
            psy_plan_combo.Enabled = True
            psy_plan_combo.SelectedValue = ""
        Else
            psy_plan_combo.Enabled = False
            psy_plan = 0
        End If
    End Sub

    Private Sub psy_skutocnost_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles psy_skutocnost_check.CheckedChanged
        If psy_skutocnost_check.Checked Then
            psy_skutocnost_combo.Enabled = True
            psy_skutocnost_combo.SelectedValue = ""
        Else
            psy_skutocnost_combo.Enabled = False
            psy_skutocnost = 0
        End If
    End Sub

    Private Sub jelenia_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jelenia_check.CheckedChanged
        If jelenia_check.Checked Then
            jelenia_combo.Enabled = True
            jelenia_combo.SelectedValue = ""
        Else
            jelenia_combo.Enabled = False
            jelenia = 0
        End If
    End Sub

    Private Sub diviacia_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles diviacia_check.CheckedChanged
        If diviacia_check.Checked Then
            diviacia_combo.Enabled = True
            diviacia_combo.SelectedValue = ""
        Else
            diviacia_combo.Enabled = False
            diviacia = 0
        End If
    End Sub

    Private Sub srncia_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles srncia_check.CheckedChanged
        If srncia_check.Checked Then
            srncia_combo.Enabled = True
            srncia_combo.SelectedValue = ""
        Else
            srncia_combo.Enabled = False
            srncia = 0
        End If
    End Sub

    Private Sub bazant_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bazant_check.CheckedChanged
        If bazant_check.Checked Then
            bazant_combo.Enabled = True
            bazant_combo.SelectedValue = ""
        Else
            bazant_combo.Enabled = False
            bazant = 0
        End If
    End Sub

    Private Sub ina_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ina_check.CheckedChanged
        If ina_check.Checked Then
            ina_combo.Enabled = True
            ina_combo.SelectedValue = ""
        Else
            ina_combo.Enabled = False
            ina = 0
        End If
    End Sub

    Private Sub vymera_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vymera_combo.SelectedIndexChanged
        vymera = vymera_combo.SelectedItem
        Me.zdruzeniaTableAdapter.Fill(Me.zoznam_zdruzeni_report_full.zdruzenia, vymera, najomna_zmluva, psy_plan, psy_typy_plan, psy_typy_skutocnost, psy_skutocnost, jelenia, srncia, diviacia, bazant, ina)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub psy_plan_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles psy_plan_combo.SelectedIndexChanged
        If psy_plan_combo.SelectedItem <> "" Then
            psy_plan = psy_plan_combo.SelectedItem
            Me.zdruzeniaTableAdapter.Fill(Me.zoznam_zdruzeni_report_full.zdruzenia, vymera, najomna_zmluva, psy_plan, psy_typy_plan, psy_typy_skutocnost, psy_skutocnost, jelenia, srncia, diviacia, bazant, ina)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub psy_skutocnost_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles psy_skutocnost_combo.SelectedIndexChanged
        If psy_skutocnost_combo.SelectedItem <> "" Then
            psy_skutocnost = psy_skutocnost_combo.SelectedItem
            Me.zdruzeniaTableAdapter.Fill(Me.zoznam_zdruzeni_report_full.zdruzenia, vymera, najomna_zmluva, psy_plan, psy_typy_plan, psy_typy_skutocnost, psy_skutocnost, jelenia, srncia, diviacia, bazant, ina)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub jelenia_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jelenia_combo.SelectedIndexChanged
        If jelenia_combo.SelectedItem <> "" Then
            jelenia = jelenia_combo.SelectedItem
            Me.zdruzeniaTableAdapter.Fill(Me.zoznam_zdruzeni_report_full.zdruzenia, vymera, najomna_zmluva, psy_plan, psy_typy_plan, psy_typy_skutocnost, psy_skutocnost, jelenia, srncia, diviacia, bazant, ina)
            Me.ReportViewer1.RefreshReport()

        End If
    End Sub

    Private Sub diviacia_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles diviacia_combo.SelectedIndexChanged
        If diviacia_combo.SelectedItem <> "" Then
            diviacia = diviacia_combo.SelectedItem
            Me.zdruzeniaTableAdapter.Fill(Me.zoznam_zdruzeni_report_full.zdruzenia, vymera, najomna_zmluva, psy_plan, psy_typy_plan, psy_typy_skutocnost, psy_skutocnost, jelenia, srncia, diviacia, bazant, ina)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub srncia_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles srncia_combo.SelectedIndexChanged
        If srncia_combo.SelectedItem <> "" Then
            srncia = srncia_combo.SelectedItem
            Me.zdruzeniaTableAdapter.Fill(Me.zoznam_zdruzeni_report_full.zdruzenia, vymera, najomna_zmluva, psy_plan, psy_typy_plan, psy_typy_skutocnost, psy_skutocnost, jelenia, srncia, diviacia, bazant, ina)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub bazant_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bazant_combo.SelectedIndexChanged
        If bazant_combo.SelectedItem <> "" Then
            bazant = bazant_combo.SelectedItem
            Me.zdruzeniaTableAdapter.Fill(Me.zoznam_zdruzeni_report_full.zdruzenia, vymera, najomna_zmluva, psy_plan, psy_typy_plan, psy_typy_skutocnost, psy_skutocnost, jelenia, srncia, diviacia, bazant, ina)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub ina_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ina_combo.SelectedIndexChanged
        If ina_combo.SelectedItem <> "" Then
            ina = ina_combo.SelectedItem
            Me.zdruzeniaTableAdapter.Fill(Me.zoznam_zdruzeni_report_full.zdruzenia, vymera, najomna_zmluva, psy_plan, psy_typy_plan, psy_typy_skutocnost, psy_skutocnost, jelenia, srncia, diviacia, bazant, ina)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub psy_typy_plan_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles psy_typy_plan_check.CheckedChanged
        If psy_typy_plan_check.Checked Then
            psy_typy_plan_combo.Enabled = True
            psy_typy_plan_combo.SelectedValue = ""
        Else
            psy_typy_plan_combo.Enabled = False
            psy_typy_plan = 0
        End If
    End Sub

    Private Sub psy_typy_skutocnost_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles psy_typy_skutocnost_check.CheckedChanged
        If psy_typy_skutocnost_check.Checked Then
            psy_typy_skutocnost_combo.Enabled = True
            psy_typy_skutocnost_combo.SelectedValue = ""
        Else
            psy_typy_skutocnost_combo.Enabled = False
            psy_typy_skutocnost = 0
        End If
    End Sub

    Private Sub psy_typy_plan_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles psy_typy_plan_combo.SelectedIndexChanged
        If psy_typy_plan_combo.SelectedItem <> "" Then
            psy_typy_plan = psy_typy_plan_combo.SelectedItem
            Me.zdruzeniaTableAdapter.Fill(Me.zoznam_zdruzeni_report_full.zdruzenia, vymera, najomna_zmluva, psy_plan, psy_typy_plan, psy_typy_skutocnost, psy_skutocnost, jelenia, srncia, diviacia, bazant, ina)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub psy_typy_skutocnost_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles psy_typy_skutocnost_combo.SelectedIndexChanged
        If psy_typy_skutocnost_combo.SelectedItem <> "" Then
            psy_typy_skutocnost = psy_typy_skutocnost_combo.SelectedItem
            Me.zdruzeniaTableAdapter.Fill(Me.zoznam_zdruzeni_report_full.zdruzenia, vymera, najomna_zmluva, psy_plan, psy_typy_plan, psy_typy_skutocnost, psy_skutocnost, jelenia, srncia, diviacia, bazant, ina)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub platnost_naj_zmluvy_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles platnost_naj_zmluvy_combo.SelectedIndexChanged

        najomna_zmluva = platnost_naj_zmluvy_combo.SelectedValue

        Me.zdruzeniaTableAdapter.Fill(Me.zoznam_zdruzeni_report_full.zdruzenia, vymera, najomna_zmluva, psy_plan, psy_typy_plan, psy_typy_skutocnost, psy_skutocnost, jelenia, srncia, diviacia, bazant, ina)
        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub refresh_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refresh_button.Click
        Me.zdruzeniaTableAdapter.Fill(Me.zoznam_zdruzeni_report_full.zdruzenia, vymera, najomna_zmluva, psy_plan, psy_typy_plan, psy_typy_skutocnost, psy_skutocnost, jelenia, srncia, diviacia, bazant, ina)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class