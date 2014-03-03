Public Class Cart

    Public inCheckOut() As CartItem
    Dim arraySize As Integer
    Dim total As Double
    Dim subTotal As Double
    Public minAgeReq As Double
    Public minAge As Double

    Public Sub cartIntialize()

        total = 0.0
        subTotal = 0.0
        arraySize = 0
        minAgeReq = 0
        SalesForm.STBlankLbl.Text = Format(total, "c")
        SalesForm.TBlankLbl.Text = Format(total, "c")
    End Sub

    Public Sub addItem(ByVal barcode As String)

        Dim tempCartItem As CartItem = SalesForm.mainRegister.findDBItem(barcode)

        If Not (IsNothing(tempCartItem)) Then
            Dim position As Integer = 0
            If (checkDup(barcode, position)) Then
                inCheckOut(position).Quantity += 1
                DisplayCart()
            Else
                If (tempCartItem.ageReq > minAgeReq) Then
                    setAgeReq(tempCartItem.ageReq)
                End If
                If minAge < minAgeReq Then
                    checkCustAge()
                End If
                If minAge >= minAgeReq Then
                    ReDim Preserve inCheckOut(arraySize)
                    inCheckOut(arraySize) = tempCartItem
                    DisplayCart()
                Else
                    MessageBox.Show("Customer is not old enough to purchase this item")
                End If
            End If
        End If

    End Sub

    Public Sub setAgeReq(ByVal sAgeReq As Integer)
        minAgeReq = sAgeReq
    End Sub
    Public Sub setAge(ByVal sAgeReq As Integer)
        minAge = sAgeReq
    End Sub
    Public Sub checkCustAge()
        AgeVerificationForm.Dispose()
        AgeVerificationForm.ShowDialog()

    End Sub

    Private Sub DisplayCart()
        Dim selectIndex As Integer = SalesForm.CartLstBox.SelectedIndex()
        SalesForm.CartLstBox.Items.Clear()
        SalesForm.PriceLstBox.Items.Clear()
        Dim index As Integer = 0
        For Each CartItem In inCheckOut
            Dim ItemDisplay As String = inCheckOut(index).ItemName
            'If inCheckOut(index).Quantity > 1 Then
            ItemDisplay += " x " & inCheckOut(index).Quantity
            'End If
            SalesForm.CartLstBox.Items.Add(ItemDisplay)
            SalesForm.PriceLstBox.Items.Add(Format(inCheckOut(index).price, "c"))
            index += 1
        Next
        If SalesForm.CartLstBox.Items.Count = 0 Then
            selectIndex = -1
        End If
        If selectIndex <> -1 Then
            SalesForm.CartLstBox.SelectedItem = SalesForm.CartLstBox.Items(selectIndex)
        End If
        calculateSubTotal()
        calculateTotal()
        arraySize = inCheckOut.Length()

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

    Public Sub incrItem(ByVal index As Integer)

        addItem(inCheckOut(index).barcode)

    End Sub

    Public Sub decItem(ByVal index As Integer)

        inCheckOut(index).Quantity -= 1
        If inCheckOut(index).Quantity <= 0 Then
            RemItem(index)
        End If
        DisplayCart()
    End Sub

    Public Sub RemItem(ByVal index As Integer)
        arraySize -= 1
        Dim tempCart(arraySize - 1) As CartItem
        Dim position As Integer = 0
        Dim position2 As Integer = 0

        For Each CartItem In inCheckOut
            If position2 <> index Then
                tempCart(position) = inCheckOut(position2)
                position += 1
                position2 += 1
            Else
                position2 += 1
            End If
        Next

        position = 0
        ReDim inCheckOut(arraySize - 1)
        For Each CartItem In tempCart
            inCheckOut(position) = tempCart(position)
            position += 1
        Next

        SalesForm.CartLstBox.ClearSelected()
        DisplayCart()
    End Sub

    Public Sub ClrItem()

        Dim index As Integer = 0
        For Each item In inCheckOut
            RemItem(index)
        Next
        minAgeReq = 0
        minAge = 0

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
            total += (inCheckOut(counter).price * inCheckOut(counter).Quantity)
            total += calculateTax(inCheckOut(counter).price, inCheckOut(counter).Quantity, inCheckOut(counter).taxType, inCheckOut(counter).tax)
            counter += 1
        Loop
        SalesForm.TBlankLbl.Text = Format(total, "c")
    End Sub

    Public Function calculateTax(ByVal sPrice As Double, ByVal sQuantity As Integer, ByVal sTaxType As String, ByVal sTaxRate As Double)

        Dim tax As Double

        If sTaxType = "Percent   " Then
            tax = PercentTax(sPrice, sQuantity, sTaxRate)
        End If

        Return tax
    End Function

    Public Function PercentTax(ByVal sPrice As Double, ByVal sQuantity As Integer, staxRate As Double)

        Return (sQuantity * (sPrice * staxRate))

    End Function
End Class
