'class which consists of all properties from Consignment class and some new to create sale 
'composition table In dgv
Public Class SaleComposition
    Inherits Consignment
    Private _toTake As Integer
    Public Property ToTake() As Integer
        Get
            Return _toTake
        End Get
        Set(ByVal value As Integer)
            _toTake = value
        End Set
    End Property

    Private _explanation As String
    Public Property Explanation() As String
        Get
            Return _explanation
        End Get
        Set(ByVal value As String)
            _explanation = value
        End Set
    End Property

    Private _remainingAfterSale As Integer
    Public Property RemainingAfterSale() As Integer
        Get
            Return _remainingAfterSale
        End Get
        Set(ByVal value As Integer)
            _remainingAfterSale = value
        End Set
    End Property

    Private _lineTotal As Integer
    Public Property LineTotal() As Integer
        Get
            Return _lineTotal
        End Get
        Set(ByVal value As Integer)
            _lineTotal = value
        End Set
    End Property

    Private _show As Boolean
    Public Property Show() As Boolean
        Get
            Return _show
        End Get
        Set(ByVal value As Boolean)
            _show = value
        End Set
    End Property
End Class
