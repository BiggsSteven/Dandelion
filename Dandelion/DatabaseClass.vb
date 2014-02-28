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

        'ColdFood 1
        'CookedFood 2
        'Beverage 3
        'Alcohol 4
        'Cigarettes 5
        'NonCon 6
        'Other 7

        Select Case catSelected
            Case 1
                column = "1"
            Case 2
                column = "2"
            Case 3
                column = "3"
            Case 4
                column = "4"
            Case 5
                column = "5"
            Case 6
                column = "6"
            Case 7
                column = "7"
        End Select

        sqlText = "SELECT COUNT(*) From " & ConfigurationSettings.AppSettings("Item") & " WHERE Category = '" & column & "'"
        sqlCmd = New SqlCommand(sqlText, sqlCon)
        Dim rowCount As Integer = sqlCmd.ExecuteScalar()
        ReDim ItemList(rowCount - 1)


        sqlText = "SELECT Barcode, ItemName FROM " & ConfigurationSettings.AppSettings("Item") & " WHERE Category = '" & column & "'"
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

        sqlText = "SELECT I.Barcode, I.ItemName, I.Price, T.TaxType, T.TaxRate FROM " & ConfigurationSettings.AppSettings("Item") & " as I JOIN " & ConfigurationSettings.AppSettings("Tax") & " as T ON I.Category = T.CategoryNum WHERE I.Barcode = '" & barcode & "'"
        sqlDa = New SqlDataAdapter(sqlText, sqlCon)
        dt.Clear()
        sqlDa.Fill(dt)

        Dim name As String = ""
        Dim Price As Double
        Dim taxType As String = ""
        Dim taxRate As Double
        Dim itemFound As CartItem = New CartItem()

        If Not (dt.Rows.Count = 0) Then
            name = dt.Rows(0).Item(1)
            Price = dt.Rows(0).Item(2)
            taxType = dt.Rows(0).Item(3)
            taxRate = dt.Rows(0).Item(4)
            itemFound.setValues(barcode, name, Price, taxType, taxRate)
            Return itemFound
        End If


    End Function
End Class
