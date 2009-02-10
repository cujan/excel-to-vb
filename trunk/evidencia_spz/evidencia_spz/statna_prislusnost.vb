Public Class statna_prislusnost

    Private Sub Statna_prislusnostBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub statna_prislusnost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Statna_prislusnostDataSet1.statna_prislusnost' table. You can move, or remove it, as needed.
        Me.Statna_prislusnostTableAdapter.Fill(Me.Statna_prislusnostDataSet1.statna_prislusnost)
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        ciselniky.ciselniky_splitter.Panel2.Controls.Add(Me)
    End Sub

    Private Sub Statna_prislusnostBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Statna_prislusnostBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Statna_prislusnostBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Statna_prislusnostBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Statna_prislusnostDataSet1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uloz.Click
        Me.Validate()
        Me.Statna_prislusnostBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Statna_prislusnostDataSet1)

        Me.pridaj.Visible = True
        Me.uloz.Visible = False
        Me.SkratkaTextBox.ReadOnly = True
        Me.NazovTextBox.ReadOnly = True
        Me.Close()

    End Sub

    Private Sub pridaj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pridaj.Click
        Me.Statna_prislusnostBindingSource.AddNew()
        Me.pridaj.Visible = False
        Me.SkratkaTextBox.ReadOnly = False
        Me.NazovTextBox.ReadOnly = False
        Me.uloz.Visible = True
    End Sub

    Private Sub zmaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zmaz.Click
        Me.Statna_prislusnostBindingSource.RemoveCurrent()
        Me.Validate()
        Me.Statna_prislusnostBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Statna_prislusnostDataSet1)
    End Sub

    Private Sub Statna_prislusnostDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Statna_prislusnostDataGridView.CellContentClick

    End Sub

    Private Sub Statna_prislusnostDataGridView_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Statna_prislusnostDataGridView.Enter
        'Me.Statna_prislusnostBindingSource.EndEdit()
    End Sub
End Class