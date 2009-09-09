Public Class skupina

    Private Sub SkupinaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SkupinaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Skupina_vychovavatelDataSet1)

    End Sub

    Private Sub skupina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VychovavatelDataSet.vychovavatel' table. You can move, or remove it, as needed.
        Me.VychovavatelTableAdapter.Fill(Me.VychovavatelDataSet.vychovavatel)
        'TODO: This line of code loads data into the 'Skupina_vychovavatelDataSet1.skupina' table. You can move, or remove it, as needed.
        Me.SkupinaTableAdapter.Fill(Me.Skupina_vychovavatelDataSet1.skupina)
        'TODO: This line of code loads data into the 'VychovavatelDataSet.vychovavatel' table. You can move, or remove it, as needed.
        Me.VychovavatelTableAdapter.Fill(Me.VychovavatelDataSet.vychovavatel)
        'TODO: This line of code loads data into the 'SkupinaDataSet.skupina' table. You can move, or remove it, as needed.
        Me.SkupinaTableAdapter.Fill(Me.Skupina_vychovavatelDataSet1.skupina)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nazov As String = nazovTextBox.Text
        Dim vychovavatel As String = vychovavatelComboBox1.SelectedValue

        Dim con As New SqlCeConnection("Data Source=|DataDirectory|\db_internat.sdf")
        con.Open()

        Dim com As New SqlCeCommand("insert into skupina (nazov_skupiny,id_vychovavatel) values ('" & nazov & "','" & vychovavatel & "')", con)
        com.ExecuteNonQuery()
        con.Close()
        Me.SkupinaTableAdapter.Fill(Me.Skupina_vychovavatelDataSet1.skupina)
        'Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\spz_evidencia.accdb")
        'con.Open()

        'Dim com As New OleDb.OleDbCommand("INSERT INTO narodnost (skratka, nazov) VALUES ('" & skratka & "','" & nazov & "')", con)
        'com.ExecuteNonQuery()
        'con.Close()
    End Sub

    Private Sub SkupinaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkupinaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SkupinaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Skupina_vychovavatelDataSet1)

    End Sub
End Class