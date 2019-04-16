Imports System.Data
Imports System.Data.SqlClient

Public Class inserting
    Dim sql As New connections  'creating instances
    Private Sub inserting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conn As SqlConnection = New connections().Connect()

        Dim strSelect = "SELECT category_id,category_name FROM category"
        Dim cmd As New SqlCommand

        With cmd
            .Connection = conn
            .CommandType = CommandType.Text
            .CommandText = strSelect
        End With

        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader()
        If rd HasRows Then

    End Sub
End Class