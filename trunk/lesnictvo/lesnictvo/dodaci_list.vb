﻿Public Class dodaci_list
    Private Sub dodaci_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OdberateliaDataSet1.odberatelia' table. You can move, or remove it, as needed.
        Me.OdberateliaTableAdapter.Fill(Me.OdberateliaDataSet1.odberatelia)
        Me.MdiParent = MDIParent1
    End Sub

    Private Sub OdberateliaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OdberateliaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OdberateliaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OdberateliaDataSet1)

    End Sub
End Class