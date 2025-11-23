Imports System.Collections.Generic

Public NotInheritable Class CategoriesList
    Private Sub New()
    End Sub

    Public Shared Function GetDefaultNames() As IEnumerable(Of String)
        Return New List(Of String) From {
            "Food",
            "Transport",
            "Utilities",
            "Entertainment",
            "Clothes",
            "Other"
        }
    End Function
End Class
