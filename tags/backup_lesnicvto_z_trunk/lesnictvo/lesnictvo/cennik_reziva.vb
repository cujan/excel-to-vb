Public Class cennik_reziva

    Private Sub Druh_rezivaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Druh_rezivaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Druh_rezivaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RezivoDataSet1)

    End Sub

    Private Sub cennik_reziva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RezivoDataSet1.druh_reziva' table. You can move, or remove it, as needed.
        Me.Druh_rezivaTableAdapter.Fill(Me.RezivoDataSet1.druh_reziva)
        Me.MdiParent = MDIParent1
        KodTextBox.ReadOnly = False
        Druh_rezivaTextBox.ReadOnly = False
        CenaTextBox.ReadOnly = False

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Druh_rezivaBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If KodTextBox.ReadOnly = False Then
            Me.Validate()
            Me.Druh_rezivaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.RezivoDataSet1)
        Else
            MsgBox("Nemôžete uložit zmeny, zatiaľ ste žiadne neuskutočnili!!!", MsgBoxStyle.OkCancel)
        End If
    End Sub

    Private Sub Druh_rezivaDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Druh_rezivaDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Druh_rezivaBindingSource.AddNew()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlacit.Click
        cennik_reziva_print.Show()

    End Sub
End Class