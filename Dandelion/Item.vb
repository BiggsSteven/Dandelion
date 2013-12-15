Public Class Item

    Private barcode As String
    Private name As String
    Private cat As String
    Private price As Double
    Public Sub setBarcode(ByVal tempBarcode As String)
        barcode = tempBarcode
    End Sub
    Public Sub setName(ByVal tempName As String)
        name = tempName
    End Sub
    Public Sub setCat(ByVal tempCat As String)
        cat = tempCat
    End Sub
    Public Sub setPrice(ByVal tempPrice As Double)
        price = tempPrice
    End Sub
    Public Sub setAll(ByVal tempBarcode As String, ByVal tempName As String, ByVal tempCat As String, ByVal tempPrice As Double)
        setBarcode(tempBarcode)
        setName(tempName)
        setCat(tempCat)
        setPrice(tempPrice)
    End Sub
    Public Function getBarcode() As String

        Return barcode
    End Function
    Public Function getName() As String

        Return name
    End Function
    Public Function getCat() As String

        Return cat
    End Function
    Public Function getPrice() As Double

        Return price
    End Function


End Class
