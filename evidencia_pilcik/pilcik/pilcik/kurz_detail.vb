﻿Public Class kurz_detail

    Private Sub KurzBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KurzBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.KurzBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PilcikdbDataSet)

    End Sub

    Private Sub kurz_detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim id_vybrateho_kurzu As Integer = kurz_novy.Label2.Text
        'TODO: This line of code loads data into the 'Clenovia_kurzuDataSet.clenovia_kurzu' table. You can move, or remove it, as needed.
        Me.Clenovia_kurzuTableAdapter.FillBy_parameter(Me.Clenovia_kurzuDataSet.clenovia_kurzu, id_vybrateho_kurzu)
        'TODO: This line of code loads data into the 'KurzComboDataSet.kurz' table. You can move, or remove it, as needed.
        Me.KurzTableAdapter1.Fill(Me.KurzComboDataSet.kurz)
        'TODO: This line of code loads data into the 'PilcikdbDataSet.kurz' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(kurz_novy.Label2.Text)
    End Sub

    Private Sub pridaj_clenaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pridaj_clenaButton.Click
        clen_kurzu_pridaj.Show()
    End Sub
End Class