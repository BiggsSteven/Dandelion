﻿Public Class ItemButton
    Inherits Button

    Dim barcode As String = ""

    Public Sub setBarcode(ByVal input As String)
        barcode = input
    End Sub
    Public Function getBarcode()
        Return barcode
    End Function

    Public Sub addToCart(ByVal sender As System.Object, ByVal e As System.EventArgs)

        SalesForm.currentCart.addItem(barcode)

    End Sub

    Public Sub addtoEditList(ByVal sender As System.Object, ByVal e As System.EventArgs)

        FormInventoryManip.nowCart.addEditItem(barcode)
        FormInventoryManip.BtnBegin.Enabled = True

    End Sub

End Class
