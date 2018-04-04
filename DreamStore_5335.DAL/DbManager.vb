'class which provides connection to db using My.Settings.ConnectionString paramentr. 
'need for changing path to database without recompilation

Imports System.Data.SqlServerCe
Public Class DbManager
    Protected ReadOnly Property Connection() As SqlCeConnection
        Get
            Return New SqlCeConnection(My.Settings.ConnectionString)
        End Get
    End Property
End Class
