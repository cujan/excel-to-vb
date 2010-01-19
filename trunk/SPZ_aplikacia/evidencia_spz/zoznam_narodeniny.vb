Public Class zoznam_narodeniny
    Dim mesiac As String
    Dim zdruzenie As String
    Private Sub narodeniny_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles narodeniny_check.CheckedChanged
        If mesiace_combo.Enabled = False Then
            mesiace_combo.Enabled = True
            mesiace_combo.SelectedValue = ""
        Else
            mesiace_combo.Enabled = False
            mesiac = "%"
        End If
    End Sub

    Private Sub mesiace_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mesiace_combo.SelectedIndexChanged
        mesiac = (mesiace_combo.SelectedIndex + 1).ToString
        MsgBox(mesiac + " " + mesiace_combo.SelectedText)
    End Sub

    Private Sub zoznam_narodeniny_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Zoznam_zdruzeni_combo.zdruzenia' table. You can move, or remove it, as needed.
        Me.ZdruzeniaTableAdapter.Fill(Me.Zoznam_zdruzeni_combo.zdruzenia)
        mesiac = "%"
        zdruzenie = "%"
    End Sub

    Private Sub zdruzenia_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zdruzenia_check.CheckedChanged
        If zdruzenia_combo.Enabled = False Then
            zdruzenia_combo.Enabled = True
            zdruzenia_combo.SelectedValue = ""
        Else
            zdruzenia_combo.Enabled = False
            zdruzenie = "%"
        End If
    End Sub

    Private Sub zdruzenia_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zdruzenia_combo.SelectedIndexChanged
        zdruzenie = zdruzenia_combo.SelectedValue
        MsgBox(zdruzenie)
    End Sub
End Class