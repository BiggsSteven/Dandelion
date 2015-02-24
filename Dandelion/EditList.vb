Public Class EditList
    Public inCheckOut() As CartItem
    Dim arraySize As Integer

    Public Sub initialize()
        arraySize = 0
    End Sub

    Public Sub addEditItem(ByVal barcode As String)
        Dim tempCartItem As CartItem = SalesForm.mainRegister.findDBItem(barcode)

        If Not (IsNothing(tempCartItem)) Then
            Dim position As Integer = 0
            If (checkDup(barcode, position)) Then

                DisplayCart()
            Else
                ReDim Preserve inCheckOut(arraySize)
                inCheckOut(arraySize) = tempCartItem
                DisplayCart()
            End If
        End If
    End Sub

    Public Function checkDup(ByVal sbarcode As String, ByVal sposition As Integer)
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

    Public Sub DisplayCart()
        Dim selectIndex As Integer = FormInventoryManip.ListEditQue.SelectedIndex()

        FormInventoryManip.ListEditQue.Items.Clear()

        Dim index As Integer = 0
        For Each CartItem In inCheckOut
            FormInventoryManip.ListEditQue.Items.Add(inCheckOut(index).ItemName)
            index += 1
        Next
        If FormInventoryManip.ListEditQue.Items.Count = 0 Then
            selectIndex = -1
        End If
        If selectIndex <> -1 Then
            FormInventoryManip.ListEditQue.SelectedItem = FormInventoryManip.ListEditQue.Items(selectIndex)
        End If
        arraySize = inCheckOut.Length()
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
        FormInventoryManip.ListEditQue.ClearSelected()
        DisplayCart()
    End Sub

    Public Sub ClrItem()

        Dim index As Integer = 0
        For Each item In inCheckOut
            RemItem(index)
        Next
    End Sub

End Class
