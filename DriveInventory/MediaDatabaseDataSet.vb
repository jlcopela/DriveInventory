

Partial Public Class MediaDatabaseDataSet
    Partial Public Class MediaDataTable
        Private Sub MediaDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.MediaImageColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
