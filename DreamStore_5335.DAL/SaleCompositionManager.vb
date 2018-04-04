Public Class SaleCompositionManager
    Private _SaleCompositionList As List(Of SaleComposition)
    Public ReadOnly Property SaleCompositionList() As List(Of SaleComposition)
        Get
            Return _SaleCompositionList
        End Get
    End Property

    Property _consignmentList As ConsignmentList
    Property _consList As List(Of Consignment)

    Private _total As Integer
    Public Property Total() As Integer
        Get
            Return _total
        End Get
        Set(ByVal value As Integer)
            _total = value
        End Set
    End Property

    'procedure which determins which consignment from consignmentList is valid 
    'For the applied parametrs which are Not out of saleDate+overdueDays 
    'And hhave remaining amount of milk 
    Public Sub SetSaleParams(ByVal buyAmount As Integer, ByVal saleDate As Date, ByVal overdueDays As Integer, ByVal hide As Boolean)
        Dim consignmentSumm As Integer = 0 'for summurizing all remaining consignments
        _total = 0 'for order total
        _SaleCompositionList.Clear() 'for correct data representation 
        _consList = _consignmentList.GetAllConsignments 'gets all consignments from database2
        For Each c As Consignment In _consList ' loop which filling  saleComposition whith non calculated 
            'Data From saved Consignments
            Dim sc As SaleComposition = New SaleComposition
            sc.Id = c.Id
            sc.Price = c.Price
            sc.ExpDate = c.ExpDate
            sc.Amount = c.Amount
            sc.Remaining = c.Remaining


            'getting date 
            Dim d = DateAdd(DateInterval.Day, overdueDays * (-1), saleDate) 'calculating expiry interval 
            'For valid consignments
            If c.Remaining > 0 And (DateTime.Compare(d, sc.ExpDate) <= 0) Then
                sc.Show = True 'selection of what consignment to show(valid)
                consignmentSumm = consignmentSumm + sc.Remaining 'calculation all valid remaining 
                'consignments
                _SaleCompositionList.Add(sc) ' addind to saleCompositionList
            End If
        Next

        If consignmentSumm < buyAmount Then
            Throw New Exception("Not enought milk")
        End If


        For Each sc As SaleComposition In _SaleCompositionList
            Dim a As Integer = (sc.Remaining - buyAmount)
            ' if there was not enought milk in current consignment 
            'then in next iterations of the loop remaining amount of milk will be taken from next 
            'consignments
            If (a >= 0) Then
                'Partial sold
                'calc RemainingAfterSale
                sc.RemainingAfterSale = a
                buyAmount = 0
            Else
                'full sold
                buyAmount = buyAmount - sc.Remaining
            End If
            'calc ToTake
            sc.ToTake = sc.Remaining - sc.RemainingAfterSale
            If sc.ToTake <> 0 Then
                If sc.ToTake = sc.Remaining Then
                    sc.Explanation = "To sell completely"
                Else
                    sc.Explanation = "To sell partially"
                End If
            End If

            'calc LineTotal
            sc.LineTotal = sc.ToTake * sc.Price
            'calc Total
            Me._total = Me._total + sc.LineTotal
            If Not hide Then 'compulstion of which consignments to show
                If sc.ToTake <> 0 Then
                    sc.Show = True
                Else
                    sc.Show = False
                End If
            Else
                sc.Show = True
            End If

        Next

        hideAll()
    End Sub

    Public Sub hideAll()
        Dim tmpSaleCompositionList As List(Of SaleComposition) = New List(Of SaleComposition)
        'deleting not shown elements
        For Each sc As SaleComposition In _SaleCompositionList
            If (sc.Show) And (sc.Remaining <> 0) Then
                tmpSaleCompositionList.Add(sc)
            End If
        Next
        _SaleCompositionList = tmpSaleCompositionList
    End Sub

    Public Sub New()
        _consignmentList = New ConsignmentList
        _SaleCompositionList = New List(Of SaleComposition)
    End Sub

    Public Sub MakeSale(ByVal Client As String, ByVal SaleDate As Date, ByVal Amount As Integer, ByVal UpdateRemaining As Boolean)
        Try
            'Make total calculation for current sale
            Dim sale As Sale = New Sale(Client, SaleDate, Amount, _total)
            Dim sManager As SaleManager = New SaleManager
            sManager.Create(sale)
            If UpdateRemaining Then
                Dim cManager As ConsignmentManager = New ConsignmentManager
                For Each sc As SaleComposition In _SaleCompositionList
                    For Each c As Consignment In _consList
                        If (sc.Id = c.Id) Then
                            c.Remaining = sc.RemainingAfterSale
                            cManager.Update(c)
                        End If
                    Next
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
