﻿Public Class tlacove_zostavy

    Private Sub tlacove_zostavy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PilcikdbDataSet.kurz' table. You can move, or remove it, as needed.
        Me.KurzTableAdapter.Fill(Me.PilcikdbDataSet.kurz)
        Me.MdiParent = hlavna_aplikacia
        protokol_kurzComboBox.SelectedIndex = -1
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If protokolCheckBox.CheckState = CheckState.Checked And protokol_kurzComboBox.SelectedIndex <> -1 Then
            Dim id_kurzu As Integer = protokol_kurzComboBox.SelectedValue

            tz_protokol.Show()
        End If
    End Sub

    Private Sub protokolCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles protokolCheckBox.CheckedChanged
        If protokolCheckBox.CheckState = CheckState.Checked Then
            protokol_kurzComboBox.Visible = True
            Label2.Visible = True
        End If
    End Sub

    Private Sub protokol_kurzComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles protokol_kurzComboBox.SelectedIndexChanged
        Label2.Visible = False
    End Sub
End Class