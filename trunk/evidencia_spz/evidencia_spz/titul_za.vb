Public Class titul_za

    Private Sub Titul_zaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Titul_zaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Titul_zaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TitulzaDataSet)

    End Sub

    Private Sub titul_za_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TitulzaDataSet.titul_za' table. You can move, or remove it, as needed.
        Me.Titul_zaTableAdapter.Fill(Me.TitulzaDataSet.titul_za)
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        ciselniky.ciselniky_splitter.Panel2.Controls.Add(Me)
    End Sub

    Private Sub koniec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles koniec.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pridaj.Click
        Me.Titul_zaBindingSource.AddNew()
        Me.pridaj.Visible = False
        Me.uloz.Visible = True
        Me.NazovTextBox.ReadOnly = False
    End Sub

    Private Sub uloz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uloz.Click
        Me.Validate()
        Me.Titul_zaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TitulzaDataSet)
        Me.uloz.Visible = False
        Me.NazovTextBox.ReadOnly = True
        Me.pridaj.Visible = True
        Me.Close()
    End Sub

    Private Sub zmaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zmaz.Click
        Me.Titul_zaBindingSource.RemoveCurrent()
        Me.Validate()
        Me.Titul_zaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TitulzaDataSet)
    End Sub
End Class