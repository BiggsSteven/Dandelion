Public Class CartItem
    Public barcode As String
    Public ItemName As String
    Public Quantitiy As Integer

    Public price As Double
    Public tax As Double

    Public Sub setValues(ByVal sBarcode As String, ByVal sItemName As String, ByVal sPrice As Double, ByVal sTax As Double)
        barcode = sBarcode
        ItemName = sItemName
        price = sPrice
        tax = sTax
    End Sub


End Class
