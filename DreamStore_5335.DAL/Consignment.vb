'class which contains all needed properties, discribes  consignment and validate it

Public Class Consignment

    Private _co_id As Integer
    Public Property Id() As Integer
        Get
            Return _co_id
        End Get
        Set(ByVal value As Integer)
            _co_id = value
        End Set
    End Property

    Private _co_vendor As String
    Public Property Vendor() As String
        Get
            Return _co_vendor
        End Get
        Set(ByVal value As String)
            If String.IsNullOrWhiteSpace(value) Then
                Throw New Exception("Vendor cannot be empty")
            End If
            _co_vendor = value
        End Set
    End Property

    Private _co_exp_date As Date
    Public Property ExpDate() As Date
        Get
            Return _co_exp_date
        End Get
        Set(ByVal value As Date)
            _co_exp_date = value
        End Set
    End Property

    Private _co_price As Integer
    Public Property Price() As Integer
        Get
            Return _co_price
        End Get
        Set(ByVal value As Integer)
            If value <= 0 Then
                Throw New Exception("Price can not be equal or less than zero")
            End If
            _co_price = value
        End Set
    End Property

    Private _co_amount As Integer
    Public Property Amount() As Integer
        Get
            Return _co_amount
        End Get
        Set(ByVal value As Integer)
            If value < 0 Then
                Throw New Exception("Amount can not be less than zero")
            End If
            _co_amount = value
        End Set
    End Property

    Private _co_remaining As Integer
    Public Property Remaining() As Integer
        Get
            Return _co_remaining
        End Get
        Set(ByVal value As Integer)
            If value < 0 Then
                Throw New Exception("Remaining can not be less than zero")
            End If
            _co_remaining = value
        End Set
    End Property

    Public Sub New()
        _co_vendor = "aaa"
    End Sub

    Public Sub New(ByVal Vendor As String)
        _co_vendor = Vendor
    End Sub

    Public Sub New(ByVal Vendor As String, ByVal ExpDate As Date, ByVal Price As Integer, ByVal Amount As Integer, ByVal Remaining As Integer)
        _co_vendor = Vendor
        _co_exp_date = ExpDate
        _co_price = Price
        _co_amount = Amount
        _co_remaining = Remaining
    End Sub

End Class
