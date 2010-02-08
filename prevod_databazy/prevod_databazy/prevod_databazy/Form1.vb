Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'pripojenie pre sdf
        Dim con As New SqlCeConnection(pripojovaci_retazec_sdf)
        con.Open()
        Dim com As New SqlCeCommand("select * from zdruzenia", con)
        com.ExecuteNonQuery()
        con.Close()
        'pripojenie pre accdb
        Dim con1 As New OleDb.OleDbConnection(pripojovaci_retazec_accdb)
        con.Open()

        Dim com1 As New OleDb.OleDbCommand("DELETE FROM clenovia WHERE id = 1", con1)

        com.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            'upratni tabulku zdruzenia - prida hodnoty do ico_clenovia, ico_psy, ico_trofeje
            updateZdruzenia()

        ElseIf RadioButton2.Checked Then
            'rozhod tabulky na viac
            rozhodTabulky()
        Else
            'rozhod clenov
            rozhodClenov()
        End If
    End Sub

    Private Sub updateZdruzenia()
        Label1.Text = "Start"
        Dim query As String = "SELECT [ico] FROM zdruzenia"
        Dim conn As New SqlCeConnection(pripojovaci_retazec_sdf)
        Dim cmd As New SqlCeCommand(query, conn)
        Dim i As Integer
        Dim val1 As String
        Dim val2 As String
        Dim val3 As String
        Dim zoznamICO As New Collection
        val2 = ""
        conn.Open()
        Dim rdr As SqlCeDataReader = cmd.ExecuteReader()
        i = 0
        Try
            ' Iterate through the results
            '
            While rdr.Read()
                val1 = rdr.GetString(0)
                zoznamICO.Add(val1)
            End While
        Finally
            ' Always call Close when done reading
            '
            rdr.Close()

            ' Always call Close when done reading
            '
            conn.Close()
        End Try

        For j As Integer = 1 To zoznamICO.Count
            Dim con As New SqlCeConnection(pripojovaci_retazec_sdf)
            con.Open()

            'MsgBox("update zdruzenia set ""ICO_clenovia""= '" + zoznamICO.Item(j) + "_clenovia', ""ICO_psy""= '" + zoznamICO.Item(j) + "_psy', ""ICO_trofeje"" ='" + zoznamICO.Item(j) + "_trofeje' where ico like '" + zoznamICO.Item(j) + "'")
            Dim com As New SqlCeCommand("update zdruzenia set ""ICO_clenovia""= '" + zoznamICO.Item(j) + "_clenovia', ""ICO_psy""= '" + zoznamICO.Item(j) + "_psy', ""ICO_trofeje"" ='" + zoznamICO.Item(j) + "_trofeje' where ico like '" + zoznamICO.Item(j) + "'", con)
            com.ExecuteNonQuery()
            con.Close()
        Next
        Label1.Text = "Tabulka updatnuta"


    End Sub

    Private Sub rozhodTabulky()
        Label1.Text = "Start"
        Dim query As String = "SELECT [ico], [nazov] FROM zdruzenia"
        Dim conn As New SqlCeConnection(pripojovaci_retazec_sdf)
        Dim cmd As New SqlCeCommand(query, conn)
        Dim i As Integer
        Dim val1 As String
        Dim val2 As String
        Dim val3 As String
        Dim cmdtext As String
        Dim zoznamICO As New Collection
        Dim zoznamICO_nazov As New Collection
        val3 = ""
        conn.Open()
        Dim rdr As SqlCeDataReader = cmd.ExecuteReader()
        i = 0
        Try
            ' Iterate through the results
            '
            While rdr.Read()
                val1 = rdr.GetString(0)
                val2 = rdr.GetString(1)
                zoznamICO.Add(val1)
                zoznamICO_nazov.Add(val2)
            End While
        Finally
            ' Always call Close when done reading
            '
            rdr.Close()

            ' Always call Close when done reading
            '
            conn.Close()
        End Try

        Dim con As New SqlCeConnection(pripojovaci_retazec_sdf)
        'For j As Integer = 1 To zoznamICO.Count


        '    val3 = "drop table """ & zoznamICO.Item(j) & "_clenovia"""

        '    con.Open()
        '    Dim com As New SqlCeCommand(val3, con)
        '    com.ExecuteNonQuery()
        '    con.Close()

        'Next


        For j As Integer = 1 To zoznamICO.Count


            val3 = "CREATE TABLE """ & zoznamICO.Item(j) & "_clenovia""  (cislo_pl  NVARCHAR(45) NOT NULL ,meno  NVARCHAR(45) NULL ,priezvisko  NVARCHAR(45) NULL , datum_narodenia  DATETIME NULL ,rodne_cislo  NVARCHAR(45) NOT NULL ,miesto_narodenia  NVARCHAR(45) NULL ,okres_narodenia  NVARCHAR(45) NULL ,okres_bydliska  NVARCHAR(45) NULL ,psc  NVARCHAR(45) NULL ,telefon  NVARCHAR(45) NULL ,cislo_op  NVARCHAR(45) NULL ,datum_vydania_op  DATETIME NULL ,datum_vydania_pl  DATETIME NULL ,cislo_zp  NVARCHAR(45) NULL ,datum_vydania_zp  DATETIME NULL ,cislo_clenskeho_preukazu_spz  NVARCHAR(45) NULL ,clen_spz_od  INT NULL ,clenske_do  INT NULL ,cislo_dokladu_clenske  NVARCHAR(45) NULL ,clen_pz  BIGINT NULL ,skuska_z_polovnictva  DATETIME NULL ,miesto_skusky_z_polovnictva  NVARCHAR(45) NULL ,skuska_pre_polovnych_hospodarov  DATETIME NULL ,miesto_skusky_pre_polovnych_hospodarov  NVARCHAR(45) NULL ,vyzsia_skuska_z_polovnictva  DATETIME NULL ,miesto_vyzsej_skusky_z_polovnictva  NVARCHAR(45) NULL ,brokova_zbran  NVARCHAR(45) NULL ,kontrolne_strelby_brok  INT NULL ,gulova_zbran  NVARCHAR(45) NULL ,kontrolne_strelby_gula  INT NULL ,najvyzsie_vyznamenanie  NVARCHAR(45) NULL ,vyznamenanie_kedy  DATETIME NULL ,udelene_tresty  NVARCHAR(255) NULL ,poznamky  NVARCHAR(120) NULL ,titul_pred_id  INT NOT NULL ,titul_za_id  INT NOT NULL ,narodnost_id  INT NOT NULL ,statna_prislusnost_id  INT NOT NULL ,ico_clenovia  NVARCHAR(45) NOT NULL ,mesto  NVARCHAR(45) NULL ,ulica  NVARCHAR(45) NULL ,ulica_cislo  NVARCHAR(45) NULL ,PRIMARY KEY ( cislo_pl ,  rodne_cislo ))"

            con.Open()
            Dim com As New SqlCeCommand(val3, con)
            com.ExecuteNonQuery()
            con.Close()

        Next

        Label1.Text = "Tabulky vytvorene. Pokracujem ..."
    End Sub

    Private Sub rozhodClenov()
        Label1.Text = "Start"
        Dim query As String = "SELECT [ico], [nazov] FROM zdruzenia"
        Dim conn As New SqlCeConnection(pripojovaci_retazec_sdf)
        Dim cmd As New SqlCeCommand(query, conn)
        Dim i As Integer
        Dim val1 As String
        Dim val2 As String
        Dim val3 As String
        Dim cmdtext As String
        Dim zoznamICO As New Collection
        Dim zoznamICO_nazov As New Collection
        val3 = ""
        conn.Open()
        Dim rdr As SqlCeDataReader = cmd.ExecuteReader()
        i = 0
        Try
            ' Iterate through the results
            '
            While rdr.Read()
                val1 = rdr.GetString(0)
                val2 = rdr.GetString(1)
                zoznamICO.Add(val1)
                zoznamICO_nazov.Add(val2)
            End While
        Finally
            ' Always call Close when done reading
            '
            rdr.Close()

            ' Always call Close when done reading
            '
            conn.Close()
        End Try

        Dim con As New SqlCeConnection(pripojovaci_retazec_sdf)
        For j As Integer = 1 To zoznamICO.Count

            con.Open()
            'cmdtext = "update ""all_clenovia"" set ""clen_pz""= '" + zoznamICO.Item(j) + "', ""ico_clenovia""= """ + zoznamICO.Item(j) + "_clenovia"" where ""clen_pz"" like '" + zoznamICO_nazov.Item(j) + "'"
            'MsgBox(cmdtext)
            Dim com As New SqlCeCommand("update ""all_clenovia"" set ""clen_pz""= '" + zoznamICO.Item(j) + "', ""ico_clenovia""= '" + zoznamICO.Item(j) + "_clenovia' where ""clen_pz"" like '" + zoznamICO_nazov.Item(j) + "'", con)
            com.ExecuteNonQuery()
            con.Close()

        Next

        For j As Integer = 1 To zoznamICO.Count

            con.Open()
            'cmdtext = "update ""all_clenovia"" set ""clen_pz""= '" + zoznamICO.Item(j) + "', ""ico_clenovia""= """ + zoznamICO.Item(j) + "_clenovia"" where ""clen_pz"" like '" + zoznamICO_nazov.Item(j) + "'"
            'MsgBox(cmdtext)
            Dim com As New SqlCeCommand("delete from """ + zoznamICO.Item(j) + "_clenovia""", con)
            com.ExecuteNonQuery()
            con.Close()

        Next

        Label1.Text = "all_clenovia updatnuta"
        MsgBox("insert into """ + zoznamICO.Item(1) + "_clenovia"" select * from ""all_clenovia"" where ""clen_pz"" like '" + zoznamICO.Item(1) + "'")
        For j As Integer = 1 To zoznamICO.Count
            MsgBox(j.ToString + " " + zoznamICO.Item(j))
            con.Open()
            Dim com As New SqlCeCommand("insert into """ + zoznamICO.Item(j) + "_clenovia"" select * from ""all_clenovia"" where ""clen_pz"" like '" + zoznamICO.Item(j) + "'", con)
            com.ExecuteNonQuery()
            con.Close()

        Next
        Label1.Text = "clenovia rozdeleni"
    End Sub
End Class
