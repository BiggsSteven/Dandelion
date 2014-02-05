Imports System.Data.SqlClient
Imports System.Configuration

Public Class DatabaseClass
    Dim connectionStr As String
    Dim sqlCon As SqlConnection
    Dim dt As New DataTable
    Dim sqlDa As SqlDataAdapter
    Dim sqlCmd As SqlCommand
    Dim sqlText As String


    Public Sub Database()
        Dim server As String = ConfigurationSettings.AppSettings("Server")
        Dim database As String = ConfigurationSettings.AppSettings("Database")
        Dim User As String = ConfigurationSettings.AppSettings("User")
        Dim Password As String = ConfigurationSettings.AppSettings("Password")

        connectionStr = "Server =" & server & ";Database =" & database & ";User Id=" & User & ";Password=" & Password & ";"
        sqlCon = New SqlConnection(connectionStr)
        sqlCon.Open()
        'Dim sqlText As String = "SELECT Name FROM RobShop.dbo.Items WHERE Barcode = '55555'"
        'sqlDa = New SqlDataAdapter(sqlText, sqlCon)
        'sqlDa.Fill(dt)


    End Sub
    Public Sub getItemList(ByVal catSelected As Integer, ByRef ItemList() As ItemButton)
        Dim column As String = ""
        Select Case catSelected
            Case 1
                column = "ColdFood"
            Case 2
                column = "CookedFood"
            Case 3
                column = "Beverage"
            Case 4
                column = "Alcohol"
            Case 5
                column = "Cigarettes"
            Case 6
                column = "NonCon"
            Case 7
                column = "Other"
        End Select

        sqlText = "SELECT COUNT(*) From " & ConfigurationSettings.AppSettings("Item") & " WHERE Category = '" & column & "'"
        sqlCmd = New SqlCommand(sqlText, sqlCon)
        Dim rowCount As Integer = sqlCmd.ExecuteScalar()
        ReDim ItemList(rowCount - 1)


        sqlText = "SELECT Barcode, Name FROM " & ConfigurationSettings.AppSettings("Item") & " WHERE Category = '" & column & "'"
        sqlDa = New SqlDataAdapter(sqlText, sqlCon)
        dt.Clear()
        sqlDa.Fill(dt)

        Do While (rowCount > 0)
            ItemList(rowCount - 1) = New ItemButton
            ItemList(rowCount - 1).setBarcode(dt.Rows(rowCount - 1).Item(0))
            ItemList(rowCount - 1).Text = dt.Rows(rowCount - 1).Item(1)
            rowCount = rowCount - 1
        Loop

    End Sub

    Public Function findDBItem(ByVal barcode As String)

        sqlText = "SELECT Barcode, Name, Price, Tax FROM " & ConfigurationSettings.AppSettings("Item") & " WHERE Barcode = '" & barcode & "'"
        sqlDa = New SqlDataAdapter(sqlText, sqlCon)
        dt.Clear()
        sqlDa.Fill(dt)

        Dim name As String = dt.Rows(0).Item(1)
        Dim Price As Double = dt.Rows(0).Item(2)
        Dim tax As Double = dt.Rows(0).Item(3)

        Dim itemFound As CartItem = New CartItem()
        itemFound.setValues(barcode, name, Price, tax)

        Return itemFound
    End Function
End Class
