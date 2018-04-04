Imports DreamStore_5335.DAL
Public Class SaleList
    Public Function GetAllSales() As List(Of Sale)
        Dim manager As SaleManager = New SaleManager 'getting list of all sales for sale list form 
        Return manager.GetAll
    End Function

End Class
