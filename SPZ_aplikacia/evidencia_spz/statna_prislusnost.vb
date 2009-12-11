Public Class statna_prislusnost

    Private Sub Statna_prislusnostBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub statna_prislusnost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpzDataSet.statna_prislusnost' table. You can move, or remove it, as needed.
        Me.Statna_prislusnostTableAdapter.Fill(Me.SpzDataSet.statna_prislusnost)
        'TODO: This line of code loads data into the 'Statna_prislusnostDataSet1.statna_prislusnost' table. You can move, or remove it, as needed.
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        ciselniky.ciselniky_splitter.Panel2.Controls.Add(Me)
    End Sub

    Private Sub Statna_prislusnostBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Statna_prislusnostBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uloz.Click
        Dim skratka As String = SkratkaTextBox.Text
        Dim nazov As String = NazovTextBox.Text

        Dim con As New SqlCeConnection(pripojovaci_retazec)
        con.Open()

        Dim com As New SqlCeCommand("INSERT INTO statna_prislusnost(skratka, nazov)VALUES (@skratka,@nazov)", con)
        With com.Parameters
            .AddWithValue("skratka", skratka)
            .AddWithValue("nazov", nazov)
        End With
        com.ExecuteNonQuery()
        con.Close()

        Me.pridaj.Visible = True
        Me.uloz.Visible = False
        Me.SkratkaTextBox.ReadOnly = True
        Me.NazovTextBox.ReadOnly = True
        Me.SkratkaTextBox.Text = ""
        Me.NazovTextBox.Text = ""

        Me.Statna_prislusnostTableAdapter.Fill(Me.SpzDataSet.statna_prislusnost)

    End Sub

    Private Sub pridaj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pridaj.Click
        Me.pridaj.Visible = False
        Me.SkratkaTextBox.ReadOnly = False
        Me.NazovTextBox.ReadOnly = False
        Me.uloz.Visible = True
    End Sub

    Private Sub zmaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zmaz.Click
        Me.Validate()
        Me.Statna_prislusnostBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.SpzDataSet)
    End Sub

    Private Sub Statna_prislusnostDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Statna_prislusnostDataGridView_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        'Me.Statna_prislusnostBindingSource.EndEdit()
    End Sub

    Private Sub Statna_prislusnostBindingNavigatorSaveItem_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Statna_prislusnostBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Statna_prislusnostBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpzDataSet)

    End Sub
End Class