Public Class ItemButton
    Inherits Button

    Dim barcode As String = ""

    Public Sub setBarcode(ByVal input As String)
        barcode = input
    End Sub
    Public Function getBarcode()
        Return barcode
    End Function
End Class
