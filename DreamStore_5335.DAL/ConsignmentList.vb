Imports DreamStore_5335.DAL

Public Class ConsignmentList
    'function to get all consignments from database by using consignmentManager
    Public Function GetAllConsignments() As List(Of Consignment)
        Dim manager As ConsignmentManager = New ConsignmentManager
        Return manager.GetAll
    End Function

    'Sorting 
    Public Function Sort(ByVal attrib As ConsignmentAttribute) As List(Of Consignment)
        Dim manager As ConsignmentManager = New ConsignmentManager
        Dim consignments As List(Of Consignment) = manager.GetAll

        Select Case attrib
            Case ConsignmentAttribute.Id
                Return (From a In consignments Order By a.Id Select a).ToList
            Case ConsignmentAttribute.Vendor
                Return (From a In consignments Order By a.Vendor Select a).ToList
            Case ConsignmentAttribute.ExpDate
                Return (From a In consignments Order By a.ExpDate Select a).ToList
            Case ConsignmentAttribute.Price
                Return (From a In consignments Order By a.Price Select a).ToList
            Case ConsignmentAttribute.Amount
                Return (From a In consignments Order By a.Amount Select a).ToList
            Case ConsignmentAttribute.Remaining
                Return (From a In consignments Order By a.Remaining Select a).ToList
        End Select

        Return Nothing

    End Function

    'Searching
    Public Function Search(ByVal value As Object, ByVal attribute As ConsignmentAttribute) As Consignment
        Select Case attribute
            Case ConsignmentAttribute.Id
                Dim result = From a In GetAllConsignments()
                             Where a.Id = value
                             Select a
                If result.Count > 0 Then
                    Return result.First
                Else
                    Return Nothing
                End If
            Case ConsignmentAttribute.Vendor
                Dim result = From a In GetAllConsignments()
                             Where a.Vendor = value
                             Select a
                If result.Count > 0 Then
                    Return result.First
                Else
                    Return Nothing
                End If
            Case ConsignmentAttribute.ExpDate
                Dim result = From a In GetAllConsignments()
                             Where a.ExpDate = value
                             Select a
                If result.Count > 0 Then
                    Return result.First
                End If
            Case ConsignmentAttribute.Price
                Dim result = From a In GetAllConsignments()
                             Where a.Price = value
                             Select a
                If result.Count > 0 Then
                    Return result.First
                End If
            Case ConsignmentAttribute.Amount
                Dim result = From a In GetAllConsignments()
                             Where a.Amount = value
                             Select a
                If result.Count > 0 Then
                    Return result.First
                End If
            Case ConsignmentAttribute.Remaining
                Dim result = From a In GetAllConsignments()
                             Where a.Remaining = value
                             Select a
                If result.Count > 0 Then
                    Return result.First
                End If
        End Select
        Return Nothing
    End Function


End Class
