Public Class detail_clena1

    Private Sub ClenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClenoviaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DetailClenaDataSet)

    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Me.ClenoviaTableAdapter.Fill(Me.DetailClenaDataSet.clenovia, CType(IdToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        'CType(IdToolStripTextBox.Text, Integer
    End Sub

    Private Sub detail_clena1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim id_clena As Integer = evidencia_clenov.Label1.Text
        Me.ClenoviaTableAdapter.Fill(Me.DetailClenaDataSet.clenovia, id_clena)
    End Sub
End Class