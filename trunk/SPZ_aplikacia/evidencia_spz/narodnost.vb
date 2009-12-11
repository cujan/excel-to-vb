Public Class narodnost

    Private Sub NarodnostBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()



    End Sub

    Private Sub narodnost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpzDataSet.narodnost' table. You can move, or remove it, as needed.
        Me.NarodnostTableAdapter.Fill(Me.SpzDataSet.narodnost)
        'TODO: This line of code loads data into the 'NarodnostDataSet.narodnost' table. You can move, or remove it, as needed.

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

        Dim con As New SqlCeConnection(pripojovaci_retazec)
        con.Open()

        Dim com As New SqlCeCommand("INSERT INTO narodnost (skratka, nazov) VALUES(@skratka,@nazov)", con)

        With com.Parameters
            .AddWithValue("skratka", skratka)
            .AddWithValue("nazov", nazov)
        End With


        com.ExecuteNonQuery()
        con.Close()



        Me.ulozButton.Visible = False
        Me.pridajButton.Visible = True
        Me.SkratkaTextBox.ReadOnly = True
        Me.NazovTextBox.ReadOnly = True
        Me.SkratkaTextBox.Text = ""
        Me.NazovTextBox.Text = ""

        Me.NarodnostTableAdapter.Fill(Me.SpzDataSet.narodnost)

    End Sub

    Private Sub zmazButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zmazButton.Click
      
        Me.Validate()
        Me.NarodnostBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.SpzDataSet)
    End Sub

    Private Sub NarodnostBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NarodnostBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NarodnostBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpzDataSet)

    End Sub
End Class