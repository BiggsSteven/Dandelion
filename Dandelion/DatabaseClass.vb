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


    End Sub

    Public Sub getItemList(ByVal catSelected As Integer, ByRef ItemList() As ItemButton)
        Dim column As String = ""

        'Candy 1
        'Snack 2
        'ColdFood 3
        'HotFood 4
        'Beverage 5
        'Alcohol 6
        'Cigarettes 7
        'Supplies 8
        'Other 9


        column = catSelected

        sqlText = "SELECT COUNT(*) From " & ConfigurationSettings.AppSettings("Item") & " WHERE Category = '" & column & "'"
        sqlCmd = New SqlCommand(sqlText, sqlCon)
        Dim rowCount As Integer = sqlCmd.ExecuteScalar()
        ReDim ItemList(rowCount - 1)


        sqlText = "SELECT Barcode, ItemName FROM " & ConfigurationSettings.AppSettings("Item") & " WHERE Category = '" & column & "'"
        sqlDa = New SqlDataAdapter(sqlText, sqlCon)
        dt.Clear()
        dt = New DataTable
        sqlDa.Fill(dt)

        Do While (rowCount > 0)
            ItemList(rowCount - 1) = New ItemButton
            ItemList(rowCount - 1).setBarcode(dt.Rows(rowCount - 1).Item(0))
            ItemList(rowCount - 1).Text = dt.Rows(rowCount - 1).Item(1)
            rowCount = rowCount - 1
        Loop

    End Sub

    Public Function findDBItem(ByVal barcode As String)

        sqlText = "SELECT I.Barcode, I.ItemName, I.Price, T.TaxType, T.TaxRate, I.AgeReq, I.Quant, I.BottomQ, I.TopQ, I.Category FROM " & ConfigurationSettings.AppSettings("Item") & " as I JOIN " & ConfigurationSettings.AppSettings("Tax") & " as T ON I.Category = T.CategoryNum WHERE I.Barcode = '" & barcode & "'"
        sqlDa = New SqlDataAdapter(sqlText, sqlCon)
        dt.Clear()
        dt = New DataTable
        sqlDa.Fill(dt)

        Dim name As String = ""
        Dim Price As Double
        Dim taxType As String = ""
        Dim taxRate As Double
        Dim itemFound As CartItem = New CartItem()
        Dim ageReq As Integer = 0
        Dim quantity As Integer = 0
        Dim BottomQ As Integer = 0
        Dim TopQ As Integer = 0
        Dim Category As String = ""

        If Not (dt.Rows.Count = 0) Then
            name = dt.Rows(0).Item(1)
            Price = dt.Rows(0).Item(2)
            taxType = dt.Rows(0).Item(3)
            taxRate = dt.Rows(0).Item(4)
            ageReq = dt.Rows(0).Item(5)
            quantity = dt.Rows(0).Item(6)
            BottomQ = dt.Rows(0).Item(7)
            TopQ = dt.Rows(0).Item(8)
            Category = dt.Rows(0).Item(9)

            itemFound.setValues(barcode, name, Price, taxType, taxRate, ageReq, quantity, BottomQ, TopQ, Category)
            Return itemFound
        End If


    End Function

    Public Sub DeStock(ByVal barcode As String, ByVal quantity As Integer)
        sqlText = "SELECT Barcode, Quant FROM " & ConfigurationSettings.AppSettings("Item") & " WHERE Barcode = '" & barcode & "'"
        sqlDa = New SqlDataAdapter(sqlText, sqlCon)
        dt.Clear()
        dt = New DataTable
        sqlDa.Fill(dt)

        Dim preQuan As Integer
        Dim postQuan As Integer

        If Not (dt.Rows.Count = 0) Then
            preQuan = dt.Rows(0).Item(1)
            postQuan = preQuan - quantity
            sqlText = "UPDATE " & ConfigurationSettings.AppSettings("Item") & " SET Quant = " & postQuan & " WHERE Barcode = '" & barcode & "'"
            sqlCmd = New SqlCommand(sqlText, sqlCon)
            sqlCmd.ExecuteNonQuery()
        End If
    End Sub

    Public Sub ReStock(ByVal barcode As String, ByVal quantity As Integer)
        sqlText = "UPDATE " & ConfigurationSettings.AppSettings("Item") & " SET Quant = " & quantity & " WHERE Barcode = '" & barcode & "'"
        sqlCmd = New SqlCommand(sqlText, sqlCon)
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub addItem(ByVal barcode As String, ByVal name As String, ByVal ageReq As String, ByVal price As String, _
                       ByVal stockQuant As String, ByVal minQuant As String, ByVal maxQuant As String, ByVal category As Integer)

        sqlText = "INSERT INTO " & ConfigurationSettings.AppSettings("Item") & " (Barcode, ItemName, Category, Price, AgeReq, Quant, BottomQ, TopQ) VALUES " _
             & "( '" & barcode & "' , '" & name & "' , '" & category & "' , '" & price & "' , '" & ageReq & "' , '" & stockQuant & "','" _
             & minQuant & "' , '" & maxQuant & "')"
        sqlCmd = New SqlCommand(sqlText, sqlCon)
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub EditItem(ByVal barcode As String, ByVal name As String, ByVal ageReq As String, ByVal price As String, _
                       ByVal minQuant As String, ByVal maxQuant As String, ByVal category As Integer)
        sqlText = "UPDATE " & ConfigurationSettings.AppSettings("Item") & " SET ItemName = '" & name & "', Category = '" & category _
            & "', Price = '" & price & "', AgeReq = '" & ageReq & "', BottomQ = '" & minQuant & "', TopQ = '" & maxQuant _
            & "' Where barcode ='" & barcode & "'"
        sqlCmd = New SqlCommand(sqlText, sqlCon)
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub RemoveItem(ByVal barcode As String)
        sqlText = "DELETE FROM " & ConfigurationSettings.AppSettings("Item") & " WHERE barcode = '" & barcode & "'"
        sqlCmd = New SqlCommand(sqlText, sqlCon)
        sqlCmd.ExecuteNonQuery()
    End Sub
End Class
