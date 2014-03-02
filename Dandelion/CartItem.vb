Public Class CartItem
    Public barcode As String
    Public ItemName As String
    Public Quantity As Integer
    Public ageReq As Integer
    Public price As Double
    Public tax As Double
    Public taxType As String

    Public Sub setValues(ByVal sBarcode As String, ByVal sItemName As String, ByVal sPrice As Double, ByVal sTaxType As String, ByVal sTaxRate As Double, ByVal sAgeReq As Integer)
        barcode = sBarcode
        ItemName = sItemName
        price = sPrice
        tax = sTaxRate
        taxType = sTaxType
        Quantity = 1
        ageReq = sAgeReq
    End Sub


End Class
