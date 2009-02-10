Public Class titul

    Private Sub TitulBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitulBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TitulBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TitulDataSet1)

    End Sub

    Private Sub titul_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TitulDataSet1.titul' table. You can move, or remove it, as needed.
        Me.TitulTableAdapter.Fill(Me.TitulDataSet1.titul)
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        ciselniky.ciselniky_splitter.Panel2.Controls.Add(Me)
        'hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uloz.Click
        Me.Validate()
        Me.TitulBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TitulDataSet1)
        Me.pridaj_titul.Visible = True
        Me.uloz.Visible = False
        Me.SkratkaTextBox.ReadOnly = True
        Me.NazovTextBox.ReadOnly = True

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pridaj_titul.Click
        Me.TitulBindingSource.AddNew()
        Me.uloz.Visible = True
        Me.SkratkaTextBox.ReadOnly = False
        Me.NazovTextBox.ReadOnly = False
        Me.pridaj_titul.Visible = False


    End Sub

    Private Sub uprav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.SkratkaTextBox.ReadOnly = False
        Me.NazovTextBox.ReadOnly = False
        Me.uloz.Visible = True
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub zmaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zmaz.Click
        Me.TitulBindingSource.RemoveCurrent()
        Me.Validate()
        Me.TitulBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TitulDataSet1)
    End Sub
End Class