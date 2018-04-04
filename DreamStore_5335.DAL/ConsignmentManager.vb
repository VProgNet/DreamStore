' class which manipulate whith consignments in database
Imports System.Data.SqlServerCe

Public Class ConsignmentManager
    Inherits DbManager

    Public Sub Create(ByVal c As Consignment)
        Dim connection As SqlCeConnection = MyBase.Connection

        Try

            Dim sql As String = $"INSERT INTO co_consignment (co_vendor_5335, co_exp_date_5335, 
							                                  co_price_5335, co_amount_5335,
							                                  co_remaining_5335) 
                                  VALUES ('{c.Vendor}', '{c.ExpDate:yyyy-MM-dd}', 
                                           {c.Price}, {c.Amount}, {c.Remaining})"
            Dim command As SqlCeCommand = New SqlCeCommand(sql, connection)

            connection.Open()
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If connection.State <> ConnectionState.Closed Then
                connection.Close()
            End If
        End Try
    End Sub

    Public Sub Update(ByVal c As Consignment)
        Dim connection As SqlCeConnection = MyBase.Connection

        Try

            Dim sql As String = $"UPDATE co_consignment SET co_vendor_5335 = '{c.Vendor}',
                                                            co_exp_date_5335 = '{c.ExpDate:yyyy-MM-dd}',
                                                            co_price_5335 =  {c.Price},
                                                            co_amount_5335 = {c.Amount},
                                                            co_remaining_5335 =  {c.Remaining}
                                                        WHERE co_id_5335 = {c.Id}"
            Dim command As SqlCeCommand = New SqlCeCommand(sql, connection)

            connection.Open()
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If connection.State <> ConnectionState.Closed Then
                connection.Close()
            End If
        End Try
    End Sub

    Public Sub Delete(ByVal id As Integer)
        Dim connection As SqlCeConnection = MyBase.Connection
        Try
            Dim sql As String = $"DELETE FROM co_consignment WHERE co_id_5335 = {id}"
            Dim command As SqlCeCommand = New SqlCeCommand(sql, connection)

            connection.Open()
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If connection.State <> ConnectionState.Closed Then
                connection.Close()
            End If
        End Try
    End Sub

    Public Function GetById(ByVal id As Integer) As Consignment
        Dim connection As SqlCeConnection = MyBase.Connection
        Try
            Dim sql As String = $"SELECT co_id_5335, co_vendor_5335, co_exp_date_5335, co_price_5335,
                                  co_amount_5335, co_remaining_5335
                                  FROM co_consignment 
                                  WHERE co_id_5335 = {id}"
            Dim command As SqlCeCommand = New SqlCeCommand(sql, connection)

            connection.Open()
            Dim reader As SqlCeDataReader = command.ExecuteReader
            If reader.Read Then
                Dim c As Consignment = New Consignment
                c.Id = Convert.ToInt32(reader.GetValue(0))
                c.Vendor = Convert.ToString(reader.GetValue(1))
                c.ExpDate = Convert.ToDateTime(reader.GetValue(2))
                c.Price = Convert.ToInt32(reader.GetValue(3))
                c.Amount = Convert.ToInt32(reader.GetValue(4))
                c.Remaining = Convert.ToInt32(reader.GetValue(5))
                Return c
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If connection.State <> ConnectionState.Closed Then
                connection.Close()
            End If
        End Try
        Return Nothing
    End Function

    Public Function GetAll() As List(Of Consignment)
        Dim connection As SqlCeConnection = MyBase.Connection
        Dim result As List(Of Consignment) = New List(Of Consignment)
        Try
            Dim sql As String = $"SELECT co_id_5335, co_vendor_5335, co_exp_date_5335, co_price_5335,
                                  co_amount_5335, co_remaining_5335
                                  FROM co_consignment"
            Dim command As SqlCeCommand = New SqlCeCommand(sql, connection)

            connection.Open()
            Dim reader As SqlCeDataReader = command.ExecuteReader
            While reader.Read
                Dim c As Consignment = New Consignment
                c.Id = Convert.ToInt32(reader.GetValue(0))
                c.Vendor = Convert.ToString(reader.GetValue(1))
                c.ExpDate = Convert.ToDateTime(reader.GetValue(2))
                c.Price = Convert.ToInt32(reader.GetValue(3))
                c.Amount = Convert.ToInt32(reader.GetValue(4))
                c.Remaining = Convert.ToInt32(reader.GetValue(5))
                result.Add(c)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If connection.State <> ConnectionState.Closed Then
                connection.Close()
            End If
        End Try
        Return result
    End Function

End Class
