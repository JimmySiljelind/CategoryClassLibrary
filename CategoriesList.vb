Public NotInheritable Class CategoriesList
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
