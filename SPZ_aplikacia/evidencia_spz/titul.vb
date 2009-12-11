Public Class titul

    Private Sub TitulBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        


    End Sub

    Private Sub titul_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpzDataSet.titul_pred' table. You can move, or remove it, as needed.
        Me.Titul_predTableAdapter.Fill(Me.SpzDataSet.titul_pred)
        'TODO: This line of code loads data into the 'TitulDataSet1.titul' table. You can move, or remove it, as needed.
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        ciselniky.ciselniky_splitter.Panel2.Controls.Add(Me)
        'hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uloz.Click

        Dim skratka As String = SkratkaTextBox.Text
        Dim nazov As String = NazovTextBox.Text

        Dim con As New SqlCeConnection(pripojovaci_retazec)
        con.Open()

        Dim com As New SqlCeCommand("INSERT INTO titul_pred (skratka, nazov) VALUES(@skratka,@nazov)", con)
        With com.Parameters
            .AddWithValue("skratka", skratka)
            .AddWithValue("nazov", nazov)
        End With

        com.ExecuteNonQuery()
        con.Close()


        Me.pridaj_titul.Visible = True
        Me.uloz.Visible = False
        Me.SkratkaTextBox.ReadOnly = True
        Me.NazovTextBox.ReadOnly = True
        Me.SkratkaTextBox.Text = ""
        Me.NazovTextBox.Text = ""
        Me.Titul_predTableAdapter.Fill(Me.SpzDataSet.titul_pred)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pridaj_titul.Click
        
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

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub zmaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zmaz.Click
        Me.Validate()
        Me.Titul_predBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.SpzDataSet)
    End Sub

    Private Sub TitulDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TitulDataGridView.CellContentClick

    End Sub

    Private Sub TitulDataGridView_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TitulDataGridView.Enter

    End Sub

    Private Sub Titul_predBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Titul_predBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Titul_predBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpzDataSet)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub
End Class