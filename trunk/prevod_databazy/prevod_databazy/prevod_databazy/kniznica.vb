Module kniznica
    Public Function pripojovaci_retazec_sdf() As String

        Dim pripojovaci_retazec_string As String = "Data Source=|DataDirectory|\databza_sdf.sdf"


        Return pripojovaci_retazec_string
    End Function
    Public Function pripojovaci_retazec_sdf2() As String

        Dim pripojovaci_retazec_string As String = "Data Source=|DataDirectory|\databza_sdf2.sdf"


        Return pripojovaci_retazec_string
    End Function

    Public Function pripojovaci_retazec_accdb() As String

        Dim pripojovaci_retazec_string As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\spz_evidencia_accb.accdb"


        Return pripojovaci_retazec_string
    End Function
End Module
