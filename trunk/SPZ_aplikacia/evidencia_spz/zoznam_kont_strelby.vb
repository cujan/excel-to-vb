Partial Class zoznam_kont_strelby
    Partial Class zoznam_kont_strelbyDataTable

        Private Sub zoznam_kont_strelbyDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.zdruzenie_nazovColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
