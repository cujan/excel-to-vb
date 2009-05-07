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
        Me.pridaj.Visible = False
        Me.uloz.Visible = True
        Me.NazovTextBox.ReadOnly = False
        Me.SkratkaTextBox.ReadOnly = False
    End Sub

    Private Sub uloz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uloz.Click
        Dim nazov As String = NazovTextBox.Text
        Dim skratka As String = SkratkaTextBox.Text

        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\spz_evidencia.accdb")
        con.Open()

        Dim com As New OleDb.OleDbCommand("INSERT INTO titul_za (nazov, skratka) VALUES ('" & nazov & "','" & skratka & "')", con)
        com.ExecuteNonQuery()
        con.Close()

        Me.Titul_zaTableAdapter.Fill(Me.TitulzaDataSet.titul_za)

        Me.uloz.Visible = False
        Me.NazovTextBox.ReadOnly = True
        Me.SkratkaTextBox.ReadOnly = True
        Me.pridaj.Visible = True
        Me.NazovTextBox.Text = ""
        Me.SkratkaTextBox.Text = ""
    End Sub

    Private Sub zmaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zmaz.Click
        Me.Titul_zaBindingSource.RemoveCurrent()
        Me.Validate()
        Me.Titul_zaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TitulzaDataSet)
    End Sub
End Class