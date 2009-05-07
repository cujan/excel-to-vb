Public Class narodnost

    Private Sub NarodnostBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NarodnostBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NarodnostBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NarodnostDataSet)

    End Sub

    Private Sub narodnost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NarodnostDataSet.narodnost' table. You can move, or remove it, as needed.
        Me.NarodnostTableAdapter.Fill(Me.NarodnostDataSet.narodnost)
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        ciselniky.ciselniky_splitter.Panel2.Controls.Add(Me)
    End Sub

    Private Sub koniec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles koniec.Click
        Me.Close()
    End Sub

    Private Sub pridajButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pridajButton.Click
        Me.SkratkaTextBox.ReadOnly = False
        Me.NazovTextBox.ReadOnly = False
        Me.ulozButton.Visible = True
        Me.pridajButton.Visible = False
    End Sub

    Private Sub ulozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click

        Dim skratka As String = SkratkaTextBox.Text
        Dim nazov As String = NazovTextBox.Text

        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\spz_evidencia.accdb")
        con.Open()

        Dim com As New OleDb.OleDbCommand("INSERT INTO narodnost (skratka, nazov) VALUES ('" & skratka & "','" & nazov & "')", con)
        com.ExecuteNonQuery()
        con.Close()

        Me.NarodnostTableAdapter.Fill(Me.NarodnostDataSet.narodnost)

        Me.ulozButton.Visible = False
        Me.pridajButton.Visible = True
        Me.SkratkaTextBox.ReadOnly = True
        Me.NazovTextBox.ReadOnly = True

    End Sub

    Private Sub zmazButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zmazButton.Click
        Me.NarodnostBindingSource.RemoveCurrent()
        Me.Validate()
        Me.NarodnostBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NarodnostDataSet)
    End Sub
End Class