Imports System.Data.SqlClient

Public Class DBClasses
    Private DatabaseConnectionStr = "Data Source=BIGGS-PC\SQLEXPRESS;Initial Catalog=DandelionDB1;Integrated Security=True"
    Private con As SqlConnection = New SqlConnection(DatabaseConnectionStr)
    Private ds As New DataSet


End Class
