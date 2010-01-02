Public Class clenovia_all

    Private Sub All_clenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles All_clenoviaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.All_clenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.All_clenoviaDataSet)

    End Sub

    Private Sub clenovia_all_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        hlavna_aplikacia.vytvor_all_clenovia()


        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)

        'TODO: This line of code loads data into the 'All_clenoviaDataSet.all_clenovia' table. You can move, or remove it, as needed.
        Me.All_clenoviaTableAdapter.Fill(Me.All_clenoviaDataSet.all_clenovia)

    End Sub

    Private Sub zavriet_kartu_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_kartu_button.Click
        Me.Close()

    End Sub

    Private Sub All_clenoviaDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles All_clenoviaDataGridView.CellClick
        Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.All_clenoviaBindingSource, "rodne_cislo", True))
        Label2.Text = Label1.Text
        Label1.DataBindings.Clear()
    End Sub

    Private Sub All_clenoviaDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles All_clenoviaDataGridView.CellContentClick

    End Sub

    Private Sub All_clenoviaDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles All_clenoviaDataGridView.CellDoubleClick
        clen_edituj.Show()
        clen_edituj.BringToFront()
    End Sub
End Class