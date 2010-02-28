Module kniznica
    Dim chyba As String
    Public Function pripojovaci_retazec() As String

        Dim pripojovaci_retazec_string As String = "Data Source=|DataDirectory|\spz.sdf"


        Return pripojovaci_retazec_string
    End Function

    'kontrola rodneho cisla
    Public Function kontrola_rc(ByVal rc As String, ByRef strError As String) As Boolean
        'ak nie je zadane rodne cislo, tak nie je co kontrolovat
        'If rc.Length = 0 Then Return True

        'kontrola dlzky rodneho cisla
        If rc.Length <> 11 And rc.Length <> 10 Then
            strError = "Neplatna dlzka rodneho cisla"
            Return False
        End If

        'ak je vsetko v poriadku
        Return True
    End Function

    'kontrola PSC
    Public Function kontrola_psc(ByVal psc As String, ByRef strError As String) As Boolean

        'ak nie je zadane psc tak nie je co kontrolovat
        If psc.Length = 0 Then Return True

        'kontrola dlzky psc

        If psc.Length <> 5 Then
            strError = "neplatna dlzka PSC"
            Return False
        End If

        'ak je vsetko v poriadku
        Return True
    End Function

    'kontrola priezviska
    Public Function kontrola_priezviska(ByVal priezvisko As String, ByRef strError As String) As Boolean

        'kontrola dlzky priezviska
        If priezvisko.Length = 0 Then
            strError = "Nezadali ste priezvisko !!!"
            Return False
        End If

        'ak je vsetko v poriadku
        Return True
    End Function

    'kontrola nazvu zdruzenia
    Public Function kontrola_nazvu_zdruzenia(ByVal nazov_zdruzenia As String, ByRef strError As String) As Boolean

        'kontrola dlzky priezviska
        If nazov_zdruzenia.Length = 0 Then
            strError = "Nezadali ste nazov zdruzenia !!!"
            Return False
        End If

        'ak je vsetko v poriadku
        Return True
    End Function

    'kontrola dlzky rokov
    Public Function kontrola_roka(ByVal rok As String, ByRef strError As String) As Boolean
        'ak nie je nic zadane tak netreba nic kontrolovat
        If rok.Length = 0 Then Return True
        'kontrola dlzky roka
        If Not rok.Length = 4 Then
            strError = "Nezadali ste rok v správnom tvare (2010) !!! "
            Return False
        End If

        'ak je vsetko v poriadku
        Return True
    End Function
    ' funkcia, ktora pred ukoncenim skontroluje vyplnenie vstupnych udajov
    Public Function kontrola_vstupnych_udajov_clena(ByVal priezvisko As String, ByVal rodne_cislo As String, ByVal clen_spz_od As String, ByVal clen_spz_do As String, ByVal kontrolne_brok As String, ByVal kontrolne_gula As String, ByVal mesto As String, ByVal okres As String, ByVal psc As String, ByRef zoznam_chyb As String) As Boolean

        zoznam_chyb = ""

        'kontrola dlzky priezviska
        If priezvisko.Length = 0 Then
            zoznam_chyb = "Priezvisko" + vbNewLine
        End If

        'kontrola dlzky rodneho cisla
        If rodne_cislo.Length <> 10 And rodne_cislo.Length <> 9 And rodne_cislo.Length <> 11 Then
            zoznam_chyb = zoznam_chyb + "Rodne cislo - zla dlzka" + vbNewLine

        End If
        hlavna_aplikacia.vytvor_all_clenovia()
        'skontroluje duplicitu rodneho cisla
        Dim con1 As New SqlCeConnection(pripojovaci_retazec)
        Dim com1 As New SqlCeCommand("SELECT count(rodne_cislo) FROM all_clenovia WHERE rodne_cislo = @rodne_cislo", con1)
        com1.Parameters.AddWithValue("rodne_cislo", rodne_cislo)
        Dim pocet_rc As Integer

        con1.Open()
        pocet_rc = com1.ExecuteScalar
        con1.Close()


        If pocet_rc <> 0 Then
            zoznam_chyb = zoznam_chyb + "Rodné číslo sa už v databáze nachádza!!!!" + vbNewLine
        End If
        'skontroluje ci rc je delitelne 11
        If rodne_cislo.Length = 10 Then

            If rodne_cislo Mod 11 <> 0 Then
                zoznam_chyb = zoznam_chyb + "Rodné číslo je nesprávne!!!!" + vbNewLine
            End If

        End If

        'kontrola dlzky roka clen_spz_od
        If clen_spz_od.Length <> 4 And clen_spz_od <> "" Then
            zoznam_chyb = zoznam_chyb + "Clen spz od " + vbNewLine

        End If

        'kontrola dlzky roka clen_spz_do
        If clen_spz_do.Length <> 4 And clen_spz_do <> "" Then
            zoznam_chyb = zoznam_chyb + "Clenske do " + vbNewLine

        End If

        'kontrola dlzky roka kontrolne brok
        If kontrolne_brok.Length <> 4 And kontrolne_brok <> "" Then
            zoznam_chyb = zoznam_chyb + "Kontrolne brok " + vbNewLine

        End If
        'kontrola dlzky roka kontrolne gula
        If kontrolne_gula.Length <> 4 And kontrolne_gula <> "" Then
            zoznam_chyb = zoznam_chyb + "Kontrolne gula " + vbNewLine

        End If

        ' kontrola kombinacie bydliska
        Dim pocet_zaznamov As String
        If okres = Nothing Or psc = Nothing Then

            If okres = Nothing Then
                zoznam_chyb = zoznam_chyb + "Nevybrali ste okres bydliska " + vbNewLine
            End If

            If psc = Nothing Then
                zoznam_chyb = zoznam_chyb + "Nevybrali ste psc bydliska " + vbNewLine
            End If
        Else

            Dim con As New SqlCeConnection(pripojovaci_retazec)
            Dim com As New SqlCeCommand("SELECT COUNT(*) AS Expr1 FROM ciselnik_obce WHERE     (obec = @obec) AND (okres = @okres) AND (psc = @psc)", con)
            With com.Parameters
                .AddWithValue("obec", mesto)
                .AddWithValue("okres", okres)
                .AddWithValue("psc", psc)
            End With

            con.Open()
            pocet_zaznamov = com.ExecuteScalar
            con.Close()

            'skontroluje ci sa nasla spravna kombinacia

            If pocet_zaznamov = 0 Then
                zoznam_chyb = zoznam_chyb + "Vybarali ste chybnu kombinaciu udajov bydliska (Mesto, Okres, Psc) " + vbNewLine
            End If

        End If


        'ak je vsetko v poriadku
        Return True
    End Function
    ' funkcia, ktora pred ukoncenim skontroluje vyplnenie vstupnych udajov pri editovani udajov
    Public Function kontrola_vstupnych_udajov_clena_edituj(ByVal priezvisko As String, ByVal rodne_cislo As String, ByVal clen_spz_od As String, ByVal clen_spz_do As String, ByVal kontrolne_brok As String, ByVal kontrolne_gula As String, ByVal mesto As String, ByVal okres As String, ByVal psc As String, ByRef zoznam_chyb As String) As Boolean

        zoznam_chyb = ""

        'kontrola dlzky priezviska
        If priezvisko.Length = 0 Then
            zoznam_chyb = "Priezvisko" + vbNewLine
        End If

        'kontrola dlzky rodneho cisla
        If rodne_cislo.Length <> 10 And rodne_cislo.Length <> 9 And rodne_cislo.Length <> 11 Then
            zoznam_chyb = zoznam_chyb + "Rodne cislo - zla dlzka" + vbNewLine

        End If
        hlavna_aplikacia.vytvor_all_clenovia()

        'skontroluje ci rc je delitelne 11
        If rodne_cislo.Length = 10 Then

            If rodne_cislo Mod 11 <> 0 Then
                zoznam_chyb = zoznam_chyb + "Rodné číslo je nesprávne!!!!" + vbNewLine
            End If

        End If

        'kontrola dlzky roka clen_spz_od
        If clen_spz_od.Length <> 4 And clen_spz_od <> "" Then
            zoznam_chyb = zoznam_chyb + "Clen spz od " + vbNewLine

        End If

        'kontrola dlzky roka clen_spz_do
        If clen_spz_do.Length <> 4 And clen_spz_do <> "" Then
            zoznam_chyb = zoznam_chyb + "Clenske do " + vbNewLine

        End If

        'kontrola dlzky roka kontrolne brok
        If kontrolne_brok.Length <> 4 And kontrolne_brok <> "" Then
            zoznam_chyb = zoznam_chyb + "Kontrolne brok " + vbNewLine

        End If
        'kontrola dlzky roka kontrolne gula
        If kontrolne_gula.Length <> 4 And kontrolne_gula <> "" Then
            zoznam_chyb = zoznam_chyb + "Kontrolne gula " + vbNewLine

        End If

        ' kontrola kombinacie bydliska
        Dim pocet_zaznamov As String
        If okres = Nothing Or psc = Nothing Then

            If okres = Nothing Then
                zoznam_chyb = zoznam_chyb + "Nevybrali ste okres bydliska " + vbNewLine
            End If

            If psc = Nothing Then
                zoznam_chyb = zoznam_chyb + "Nevybrali ste psc bydliska " + vbNewLine
            End If
        Else

            Dim con As New SqlCeConnection(pripojovaci_retazec)
            Dim com As New SqlCeCommand("SELECT COUNT(*) AS Expr1 FROM ciselnik_obce WHERE     (obec = @obec) AND (okres = @okres) AND (psc = @psc)", con)
            With com.Parameters
                .AddWithValue("obec", mesto)
                .AddWithValue("okres", okres)
                .AddWithValue("psc", psc)
            End With

            con.Open()
            pocet_zaznamov = com.ExecuteScalar
            con.Close()

            'skontroluje ci sa nasla spravna kombinacia

            If pocet_zaznamov = 0 Then
                zoznam_chyb = zoznam_chyb + "Vybarali ste chybnu kombinaciu udajov bydliska (Mesto, Okres, Psc) " + vbNewLine
            End If

        End If


        'ak je vsetko v poriadku
        Return True
    End Function
End Module
