Public Class clenovia_all

    Private Sub All_clenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles All_clenoviaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.All_clenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.All_clenoviaDataSet)

    End Sub

    Private Sub clenovia_all_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'vytvori select pre kopirovanie tabuliek do velkej

        Dim query As String = "SELECT [ICO_clenovia] FROM zdruzenia"
        Dim conn As New SqlCeConnection(pripojovaci_retazec)
        Dim cmd As New SqlCeCommand(query, conn)
        Dim i As Integer
        Dim val1 As String
        Dim unionSelect As String
        Dim fromTabulky As String

        fromTabulky = ""
        unionSelect = "insert into ""all_clenovia"" "


        conn.Open()
        Dim rdr As SqlCeDataReader = cmd.ExecuteReader()
        i = 1
        Try
            ' Iterate through the results
            '
            While rdr.Read()
                val1 = rdr.GetString(0)
                If i = 1 Then
                    fromTabulky = fromTabulky + " select * from """ + val1 + """"
                    i = i + 1
                Else
                    fromTabulky = fromTabulky + " union select * from """ + val1 + """ "
                End If
            End While
        Finally
            ' Always call Close when done reading
            '
            rdr.Close()

            ' Always call Close when done reading
            '
            conn.Close()
        End Try

        unionSelect = unionSelect + fromTabulky + " "
        'MsgBox(unionSelect)

        'najprv vymaz tabulku all_clenovia
        Dim truncateTable As String
        truncateTable = "DELETE FROM ""all_clenovia"" "
        Dim connectionTruncate As New SqlCeConnection(pripojovaci_retazec)
        connectionTruncate.Open()
        Dim commandTruncate As New SqlCeCommand(truncateTable, connectionTruncate)
        commandTruncate.ExecuteNonQuery()
        connectionTruncate.Close()


        'vkopiruj tabulky do all_clenova pouzij unionSelect query
        Dim sqlReturn As New Integer
        Dim connection As New SqlCeConnection(pripojovaci_retazec)
        connection.Open()
        Dim command As New SqlCeCommand(unionSelect, connection)
        sqlReturn = command.ExecuteNonQuery()
        connection.Close()



        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)

        'TODO: This line of code loads data into the 'All_clenoviaDataSet.all_clenovia' table. You can move, or remove it, as needed.
        Me.All_clenoviaTableAdapter.Fill(Me.All_clenoviaDataSet.all_clenovia)

    End Sub

    Private Sub zavriet_kartu_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_kartu_button.Click
        Me.Close()

    End Sub
End Class