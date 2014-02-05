Public Class Cart

    Dim inCheckOut As CartItem()

    Public Sub cartIntialize()

        ReDim inCheckOut(0)

    End Sub

    Public Sub addItem(ByVal barcode As String)



        Dim arraySize As Integer = inCheckOut.Length()
        ReDim Preserve inCheckOut(arraySize + 1)
        inCheckOut(arraySize) = SalesForm.mainRegister.findDBItem(barcode)

        SalesForm.CartLstBox.Items.Add(inCheckOut(arraySize).ItemName)
        SalesForm.PriceLstBox.Items.Add(Format(inCheckOut(arraySize).price, "c"))


    End Sub
End Class
