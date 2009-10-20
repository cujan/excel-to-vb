Public Class evidencia_studentov

    Private Sub StudentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

    End Sub

    Private Sub evidencia_studentov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.StudentDataSet.student)

        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)

        'pri nacitani nie je oynacenz ziaden riadok
        Me.StudentDataGridView.CurrentCell = Nothing
    End Sub

    Private Sub zavriet_kartu_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_kartu_button.Click
        Me.Close()

    End Sub

    Private Sub StudentDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StudentDataGridView.CellClick
        Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "id", True))
    End Sub

    Private Sub StudentDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StudentDataGridView.CellContentClick

    End Sub

    Private Sub StudentDataGridView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StudentDataGridView.CellContentDoubleClick

    End Sub

    Private Sub StudentDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StudentDataGridView.CellDoubleClick
       
    End Sub
End Class