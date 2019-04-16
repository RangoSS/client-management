Imports System.Data
Imports System.Data.SqlClient



Public Class category
    Dim sql As New connections  'creating instances
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub category_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cmd As New SqlCommand                              'every name space must be called as an object
        Dim conn As SqlConnection = New connections().Connect()

        Dim myJoin As String = "SELECT first_name,last_name,date_id,category_name FROM assert_details a 
                              JOIN staff s 
                               ON a.staff_id=s.staff_id
                               JOIN category c
                                ON a.category_id=c.category_id"
        With cmd
            .Connection = conn    'connection is the property of sqlCommand in order to use it we must create sqlcommand object
            .CommandType = CommandType.Text
            .CommandText = myJoin
        End With

        'now i want to read data from 
        Dim rd As SqlDataReader
        Dim table As DataTable = New DataTable()
        rd = cmd.ExecuteReader()
        If rd.HasRows Then
            table.Load(rd)
            DataGridView1.DataSource = table
        End If




    End Sub
End Class