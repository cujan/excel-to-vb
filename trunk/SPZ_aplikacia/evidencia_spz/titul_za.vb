Public Class titul_za

    Private Sub Titul_zaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub titul_za_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpzDataSet.titul_za' table. You can move, or remove it, as needed.
        Me.Titul_zaTableAdapter.Fill(Me.SpzDataSet.titul_za)
        'TODO: This line of code loads data into the 'TitulzaDataSet.titul_za' table. You can move, or remove it, as needed.
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

        Dim con As New SqlCeConnection(pripojovaci_retazec)
        con.Open()

        Dim com As New SqlCeCommand("INSERT INTO titul_za (skratka, nazov) VALUES(@skratka,@nazov)", con)
        With com.Parameters
            .AddWithValue("skratka", skratka)
            .AddWithValue("nazov", nazov)
        End With

        com.ExecuteNonQuery()
        con.Close()

        Me.uloz.Visible = False
        Me.NazovTextBox.ReadOnly = True
        Me.SkratkaTextBox.ReadOnly = True
        Me.pridaj.Visible = True
        Me.NazovTextBox.Text = ""
        Me.SkratkaTextBox.Text = ""

        Me.Titul_zaTableAdapter.Fill(Me.SpzDataSet.titul_za)
    End Sub

    Private Sub zmaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zmaz.Click
        Me.Validate()
        Me.Titul_zaBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.SpzDataSet)

    End Sub

    Private Sub Titul_zaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Titul_zaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Titul_zaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpzDataSet)

    End Sub
End Class