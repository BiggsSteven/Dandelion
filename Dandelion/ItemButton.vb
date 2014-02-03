Public Class ItemButton
    Inherits Button

    Dim barcode As String = ""

    Public Sub setBarcode(ByVal input As String)
        barcode = input
    End Sub
    Public Function getBarcode()
        Return barcode
    End Function

    Public Sub addToCart(ByVal sender As System.Object, ByVal e As System.EventArgs)

        SalesForm.CartLstBox.Items.Add(Me.Text)
    End Sub
End Class
