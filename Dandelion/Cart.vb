Public Class Cart

    Dim inCheckOut As CartItem()
    Dim arraySize As Integer
    Dim total As Double
    Dim subTotal As Double

    Public Sub cartIntialize()

        total = 0.0
        subTotal = 0.0
        arraySize = 0
        SalesForm.STBlankLbl.Text = Format(total, "c")
        SalesForm.TBlankLbl.Text = Format(total, "c")


    End Sub

    Public Sub addItem(ByVal barcode As String)


        ReDim Preserve inCheckOut(arraySize)

        inCheckOut(arraySize) = SalesForm.mainRegister.findDBItem(barcode)

        SalesForm.CartLstBox.Items.Add(inCheckOut(arraySize).ItemName)
        SalesForm.PriceLstBox.Items.Add(Format(inCheckOut(arraySize).price, "c"))
        calculateSubTotal()
        calculateTotal()
        arraySize = inCheckOut.Length()

    End Sub

    Public Sub calculateSubTotal()

        subTotal = 0
        Dim counter As Integer = 0
        Do While (counter < inCheckOut.Length())
            subTotal += inCheckOut(counter).price
            counter += 1
        Loop

        SalesForm.STBlankLbl.Text = Format(subTotal, "c")
    End Sub
    Public Sub calculateTotal()

        total = 0
        Dim counter As Integer = 0
        Do While (counter < inCheckOut.Length())
            total += (inCheckOut(counter).price * (1 + inCheckOut(counter).tax))
            counter += 1
        Loop
        SalesForm.TBlankLbl.Text = Format(total, "c")
    End Sub

End Class
