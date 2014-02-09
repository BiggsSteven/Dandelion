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

        Dim tempCartItem As CartItem = SalesForm.mainRegister.findDBItem(barcode)
        If Not (IsNothing(tempCartItem)) Then
            Dim position As Integer = 0
            If (checkDup(barcode, position)) Then
                inCheckOut(position).Quantity += 1
                SalesForm.CartLstBox.Items.Item(position) = inCheckOut(position).ItemName & " x " & inCheckOut(position).Quantity
            Else
                ReDim Preserve inCheckOut(arraySize)
                inCheckOut(arraySize) = tempCartItem
                SalesForm.CartLstBox.Items.Add(inCheckOut(arraySize).ItemName)
                SalesForm.PriceLstBox.Items.Add(Format(inCheckOut(arraySize).price, "c"))
            End If

            calculateSubTotal()
            calculateTotal()
            arraySize = inCheckOut.Length()
        End If
    End Sub

    Public Function checkDup(ByVal sbarcode As String, ByRef sPosition As Integer)
        Dim counter As Integer = 0
        Do While (counter < arraySize)
            If (sbarcode = inCheckOut(counter).barcode) Then
                sPosition = counter
                Return True
            End If
            counter += 1
        Loop
        Return False
    End Function

    Public Sub increItem(counter)

    End Sub

    Public Sub calculateSubTotal()

        subTotal = 0
        Dim counter As Integer = 0
        Do While (counter < inCheckOut.Length())
            subTotal += (inCheckOut(counter).price * inCheckOut(counter).Quantity)
            counter += 1
        Loop

        SalesForm.STBlankLbl.Text = Format(subTotal, "c")
    End Sub
    Public Sub calculateTotal()

        total = 0
        Dim counter As Integer = 0
        Do While (counter < inCheckOut.Length())
            total += ((inCheckOut(counter).price * inCheckOut(counter).Quantity) * (1 + inCheckOut(counter).tax))
            counter += 1
        Loop
        SalesForm.TBlankLbl.Text = Format(total, "c")
    End Sub

End Class
