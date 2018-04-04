'class which contains all needed properties, discribes  sales and validate it
Public Class Sale

    Private _sa_id As Integer
    Public Property Id() As Integer
        Get
            Return _sa_id
        End Get
        Set(ByVal value As Integer)
            _sa_id = value
        End Set
    End Property

    Private _sa_client As String
    Public Property Client() As String
        Get
            Return _sa_client
        End Get
        Set(ByVal value As String)
            If String.IsNullOrWhiteSpace(value) Then
                Throw New Exception("Client cannot be empty")
            End If
            _sa_client = value
        End Set
    End Property

    Private _sa_date As Date
    Public Property SaleDate() As Date
        Get
            Return _sa_date
        End Get
        Set(ByVal value As Date)
            _sa_date = value
        End Set
    End Property

    Private _sa_amount As Integer
    Public Property Amount() As Integer
        Get
            Return _sa_amount
        End Get
        Set(ByVal value As Integer)
            If value < 0 Then
                Throw New Exception("Amount cannot be less than zero")
            End If
            _sa_amount = value
        End Set
    End Property

    Private _sa_total As Integer
    Public Property Total() As Integer
        Get
            Return _sa_total
        End Get
        Set(ByVal value As Integer)
            If value < 0 Then
                Throw New Exception("Total cannot be less than zero")
            End If
            _sa_total = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Private _Consignment As Consignment
    Public Property Consignment() As Consignment
        Get
            Return _Consignment
        End Get
        Set(ByVal value As Consignment)
            _Consignment = value
        End Set
    End Property
    Private _consList As List(Of Consignment)
    Public Function getConsignmentsList() As List(Of Consignment)
        Return _consList
    End Function

    Public Sub New(Client As String, SaleDate As Date, Amount As Integer, Total As Integer)
        _sa_client = Client
        _sa_date = SaleDate
        _sa_amount = Amount
        _sa_total = Total
    End Sub

End Class
