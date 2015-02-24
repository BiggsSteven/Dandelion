Public Class CartItem
    Public barcode As String
    Public ItemName As String
    Public Category As String
    Public Quantity As Integer
    Public ageReq As Integer
    Public price As Double
    Public tax As Double
    Public taxType As String
    Public StockQuant As String
    Public LowQuant As Integer
    Public HighQuant As Integer

    Public Sub setValues(ByVal sBarcode As String, ByVal sItemName As String, ByVal sPrice As Double, ByVal sTaxType As String, _
                         ByVal sTaxRate As Double, ByVal sAgeReq As Integer, ByVal sQuan As Integer, ByVal sLowQ As Integer, ByVal sHighQ As Integer, ByVal sCategory As String)
        barcode = sBarcode
        ItemName = sItemName
        price = sPrice
        tax = sTaxRate
        taxType = sTaxType
        Quantity = 1
        ageReq = sAgeReq
        StockQuant = sQuan
        LowQuant = sLowQ
        HighQuant = sHighQ
        Category = sCategory

    End Sub

End Class
