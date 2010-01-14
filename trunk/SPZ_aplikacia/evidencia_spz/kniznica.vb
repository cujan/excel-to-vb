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
    Public Function kontrola_vstupnych_udajov_clena(ByVal priezvisko As String, ByVal rodne_cislo As String, ByVal clen_spz_od As String, ByVal clen_spz_do As String, ByVal kontrolne_brok As String, ByVal kontrolne_gula As String, ByRef zoznam_chyb As String) As Boolean
        zoznam_chyb = ""

        'kontrola dlzky priezviska
        If priezvisko.Length = 0 Then
            zoznam_chyb = "Priezvisko" + vbNewLine

        End If

        'kontrola dlzky rodneho cisla
        If rodne_cislo.Length <> 11 And rodne_cislo.Length <> 10 Then
            zoznam_chyb = zoznam_chyb + "Rodne cislo" + vbNewLine

        End If


        'kontrola dlzky roka clen_spz_od
        If Not clen_spz_od.Length = 4 Then
            zoznam_chyb = zoznam_chyb + "Clen spz od " + vbNewLine

        End If

        'kontrola dlzky roka clen_spz_do
        If Not clen_spz_do.Length = 4 Then
            zoznam_chyb = zoznam_chyb + "Clen spz do " + vbNewLine

        End If

        'kontrola dlzky roka kontrolne brok
        If Not kontrolne_brok.Length = 4 Then
            zoznam_chyb = zoznam_chyb + "Kontrolne brok " + vbNewLine

        End If
        'kontrola dlzky roka kontrolne gula
        If Not kontrolne_gula.Length = 4 Then
            zoznam_chyb = zoznam_chyb + "Kontrolne gula " + vbNewLine

        End If



        
        'ak je vsetko v poriadku
        Return True
    End Function
End Module
