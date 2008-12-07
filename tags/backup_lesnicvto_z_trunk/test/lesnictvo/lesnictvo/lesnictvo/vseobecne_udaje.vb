Public Class vseobecne_udaje

    Private Sub Vseobecne_udajeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Vseobecne_udajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Vseobecne_udajeDataSet1)

    End Sub

    Private Sub vseobecne_udaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Vseobecne_udajeDataSet1.vseobecne_udaje' table. You can move, or remove it, as needed.
        Me.Vseobecne_udajeTableAdapter.Fill(Me.Vseobecne_udajeDataSet1.vseobecne_udaje)
        'TODO: This line of code loads data into the 'Vseobecne_udajeDataSet1.vseobecne_udaje' table. You can move, or remove it, as needed.
        Me.Vseobecne_udajeTableAdapter.Fill(Me.Vseobecne_udajeDataSet1.vseobecne_udaje)
        'TODO: This line of code loads data into the 'Vseobecne_udajeDataSet1.vseobecne_udaje' table. You can move, or remove it, as needed.
        Me.Vseobecne_udajeTableAdapter.Fill(Me.Vseobecne_udajeDataSet1.vseobecne_udaje)
        Me.MdiParent = MDIParent1
    End Sub

    Private Sub Vseobecne_udajeBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Vseobecne_udajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Vseobecne_udajeDataSet1)

    End Sub

    Private Sub Vseobecne_udajeBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vseobecne_udajeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Vseobecne_udajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Vseobecne_udajeDataSet1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.Vseobecne_udajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Vseobecne_udajeDataSet1)
        Me.Close()
    End Sub
End Class