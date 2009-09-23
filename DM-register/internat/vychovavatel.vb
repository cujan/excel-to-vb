Public Class vychovavatel

    Private Sub VychovavatelBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VychovavatelBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VychovavatelBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VychovavatelDataSet)



    End Sub

    Private Sub vychovavatel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Titul_predDataSet.titul_pred' table. You can move, or remove it, as needed.
        Me.Titul_predTableAdapter.Fill(Me.Titul_predDataSet.titul_pred)
        'TODO: This line of code loads data into the 'VychovavatelDataSet.vychovavatel' table. You can move, or remove it, as needed.
        Me.VychovavatelTableAdapter.Fill(Me.VychovavatelDataSet.vychovavatel)

        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        ciselniky.ciselniky_splitter.Panel2.Controls.Add(Me)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim titul As Integer = titul_predComboBox.SelectedValue
        Dim meno As String = menoTextBox.Text
        Dim priezvisko As String = priezviskoTextBox.Text
        Dim poznamka As String = poznamkaTextBox.Text



        Dim con As New SqlCeConnection("Data Source=|DataDirectory|\db_internat.sdf")
        con.Open()

        Dim com As New SqlCeCommand("insert into vychovavatel (priezvisko, meno, poznamka, titul) values ('" & priezvisko & "','" & meno & "','" & poznamka & "','" & titul & "')", con)
        com.ExecuteNonQuery()
        con.Close()

        Me.VychovavatelTableAdapter.Fill(Me.VychovavatelDataSet.vychovavatel)
    End Sub

    Private Sub zavriet_podkartu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_podkartu.Click
        Me.Close()

    End Sub
End Class