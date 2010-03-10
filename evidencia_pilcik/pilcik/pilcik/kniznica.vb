Module kniznica
    Public Function pripojovaci_retazec() As String

        Dim pripojovaci_retazec_string As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\pilcik_db.accdb"


        Return pripojovaci_retazec_string
    End Function

End Module
