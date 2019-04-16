Imports System.Data
Imports System.Data.SqlClient


Public Class connections
    Dim conn As SqlConnection = New SqlConnection()
    Public Function Connect() As SqlConnection
        Try
            conn.ConnectionString = "server=localhost\sqlexpress;uid=sa;pwd=Rango123;database=assert_management"
            conn.Open()
            Return conn
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return New SqlConnection

    End Function
End Class
