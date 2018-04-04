' class which manipulate whith sales in database

Imports System.Data.SqlServerCe
Public Class SaleManager
    Inherits DbManager

    Public Sub Create(ByVal s As Sale)
        Dim connection As SqlCeConnection = MyBase.Connection
        Try
            Dim sql As String = $"INSERT INTO sa_sale(sa_client_5335, sa_date_5335, sa_amount_5335, sa_total_5335)
                                  VALUES ('{s.Client}', '{s.SaleDate:yyyy-MM-dd}', '{s.Amount}', '{s.Total}')"
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
            Dim sql As String = $"DELETE FROM sa_sale WHERE sa_id_5335={id}"
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

    Public Function GetAll() As List(Of Sale)
        Dim connection As SqlCeConnection = MyBase.Connection
        Dim result As List(Of Sale) = New List(Of Sale)
        Try
            Dim sql As String = $"SELECT sa_id_5335, sa_client_5335, sa_date_5335, sa_amount_5335, sa_total_5335 
                                  FROM sa_sale"
            Dim command As SqlCeCommand = New SqlCeCommand(sql, connection)
            connection.Open()

            Dim reader As SqlCeDataReader = command.ExecuteReader
            While reader.Read
                Dim s As Sale = New Sale
                s.Id = Convert.ToInt32(reader.GetValue(0))
                s.Client = Convert.ToString(reader.GetValue(1))
                s.SaleDate = Convert.ToDateTime(reader.GetValue(2))
                s.Amount = Convert.ToInt32(reader.GetValue(3))
                s.Total = Convert.ToInt32(reader.GetValue(4))
                result.Add(s)
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
