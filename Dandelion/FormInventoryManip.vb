Public Class FormInventoryManip
    Public nowCart As EditList = New EditList
    Dim ItemList As ItemButton()
    Dim ItemPnl As Panel = New Panel
    Dim catSelected As Integer = -1
    Dim choice As Integer = 0
    Dim placeHold As Integer = 0
    Private Sub FormInventoryManip_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Start()

    End Sub

    Public Sub Start()

        For Each element As Control In Me.Controls
            element.Visible = True
            element.Enabled = True
        Next
        For Each element As Control In BoxSectionOne.Controls
            element.Visible = True
            element.Enabled = True
        Next
        For Each element As Control In BoxSectionTwo.Controls
            element.Visible = True
            element.Enabled = True
        Next element
        For Each element As Control In CatBox.Controls
            element.Visible = True
            element.Enabled = True
        Next element
        For Each element As Control In BoxSelectItems.Controls
            element.Visible = True
            element.Enabled = True
        Next element
        For Each element As Control In CartCtrlBox.Controls
            element.Visible = True
            element.Enabled = True
        Next element
        ListEditQue.Items.Clear()
        For Each element As Control In BoxCartEdit.Controls
            element.Visible = True
            element.Enabled = True
        Next element

        For Each element As Control In BoxSectionThree.Controls
            element.Visible = True
            element.Enabled = True
        Next element
        For Each element As Control In BoxInputFields.Controls
            element.Visible = True
            element.Enabled = True
            element.Text = ""
            If element.Name = CmboCatFill.Name Then
                CmboCatFill.SelectedItem = CmboCatFill.Items.Item(0)
            End If
        Next element
        For Each element As Control In BoxFinish.Controls
            element.Visible = True
            element.Enabled = True
        Next element

        BoxSectionTwo.Visible = False
        BoxSectionThree.Visible = False

        BtnFinished.Text = "Complete"
        BtnExitFieldEdit.Text = "Cancel"

        placeHold = 0
        choice = 0
    End Sub

    Private Sub BtnRestock_Click(sender As Object, e As EventArgs) Handles BtnRestock.Click
        choice = 1
        BoxSectionOne.Visible = False
        BoxSectionTwo.Visible = True
        BoxSectionThree.Visible = False

        changeCat(1)
        CartCtrlBox.Enabled = False
        nowCart = New EditList

        BoxSelectItems.Text = "Select Items to Restock:"
        BoxSectionThree.Text = "Restock Item:"

        For Each element As Control In BoxSectionThree.Controls
            element.Visible = False
        Next
        BoxInputFields.Visible = True
        BoxFinish.Visible = True

        LblNowStock.Visible = True
        LblIncreaseStock.Visible = True
        RdBtnSet.Visible = True
        RdBtnIncrease.Visible = True
        RdBtnSet.Checked = False
        RdBtnIncrease.Checked = False

        For Each element As Control In BoxInputFields.Controls
            element.Visible = False
            element.Text = ""
        Next

        TxtNowStockFill.Visible = True
        TxtStockFill.Visible = True
        TxtNowStockFill.Enabled = False
        TxtStockFill.Enabled = False

        BtnFinished.Text = "Complete"
        BtnExitFieldEdit.Text = "Cancel"
        SearchTxtBox.Focus()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        BoxSectionOne.Visible = False
        BoxSectionTwo.Visible = False
        BoxSectionThree.Visible = True

        RdBtnSet.Visible = False
        RdBtnIncrease.Visible = False

        LblIncreaseStock.Visible = False
        TxtStockFill.Visible = False

        BoxSectionThree.Text = "Add Item:"

        choice = 2

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        choice = 3
        BoxSectionOne.Visible = False
        BoxSectionTwo.Visible = True
        BoxSectionThree.Visible = False

        changeCat(1)
        CartCtrlBox.Enabled = False
        nowCart = New EditList

        BoxSelectItems.Text = "Select Items to Edit:"
        BoxSectionThree.Text = "Edit Item:"

        BoxInputFields.Visible = True
        BoxFinish.Visible = True



        RdBtnSet.Visible = False
        RdBtnIncrease.Visible = False


        LblIncreaseStock.Visible = False
        TxtStockFill.Visible = False
        SearchTxtBox.Focus()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click

        choice = 4
        BoxSectionOne.Visible = False
        BoxSectionTwo.Visible = True
        BoxSectionThree.Visible = False

        changeCat(1)
        CartCtrlBox.Enabled = False
        nowCart = New EditList

        BoxSelectItems.Text = "Select Items to Remove:"
        BoxSectionThree.Text = "Remove Item:"



        LblBarcode.Visible = False
        LblName.Visible = False
        LblCategory.Visible = False
        LblAgeReq.Visible = False
        LblPrice.Visible = False
        LblMiniStock.Visible = False
        LblMaxStock.Visible = False
        LblNowStock.Visible = False
        LblIncreaseStock.Visible = False
        TxtStockFill.Visible = False
        BoxInputFields.Visible = False
        RdBtnSet.Visible = False
        RdBtnIncrease.Visible = False

        BtnFinished.Text = "Yes"
        BtnExitFieldEdit.Text = "No"

        For Each element As Control In BoxSectionThree.Controls
            element.Visible = False
        Next element

        BoxSectionTwo.Visible = True
        BoxFinish.Visible = True
        changeCat(1)
        choice = 4
        SearchTxtBox.Focus()
    End Sub

    ''/////////////////////////////////////////////////////////////////////////////////////////////////////////''

    Private Sub BtnCandy_Click(sender As Object, e As EventArgs) Handles BtnCandy.Click
        changeCat(1)
    End Sub

    Private Sub BtnSnack_Click(sender As Object, e As EventArgs) Handles BtnSnack.Click
        changeCat(2)
    End Sub

    Private Sub ColdBtn_Click_1(sender As Object, e As EventArgs) Handles ColdBtn.Click
        changeCat(3)
    End Sub

    Private Sub HotBtn_Click(sender As Object, e As EventArgs) Handles HotBtn.Click
        changeCat(4)
    End Sub

    Private Sub BeverageBtn_Click_1(sender As Object, e As EventArgs) Handles BeverageBtn.Click
        changeCat(5)
    End Sub

    Private Sub AlcoholBtn_Click_1(sender As Object, e As EventArgs) Handles AlcoholBtn.Click
        changeCat(6)
    End Sub

    Private Sub CigBtn_Click_1(sender As Object, e As EventArgs) Handles CigBtn.Click
        changeCat(7)
    End Sub

    Private Sub BtnSupply_Click(sender As Object, e As EventArgs) Handles BtnSupply.Click
        changeCat(8)
    End Sub

    Private Sub BtnOther_Click(sender As Object, e As EventArgs) Handles BtnOther.Click
        changeCat(9)
    End Sub

    Private Sub changeCat(ByVal choiceCat As Integer)

        SalesForm.mainRegister.getItemList(choiceCat, ItemList)
        addBtnToPnl()

    End Sub

    Public Sub addBtnToPnl()

        'To reset the buttons, the program disposes of the panel and recreates it
        ItemPnl.Dispose()
        ItemPnl = New Panel
        ItemPnl.AutoScroll = True
        ItemPnl.Dock = DockStyle.Fill
        BoxOuterBtnGrp.Controls.Add(ItemPnl)

        'sets variables to be used to place the buttons without overlap of the objects
        Dim boxSize As Double = ItemPnl.Size.Width()
        Dim rowCount As Integer = ItemList.Length
        Dim increCount As Integer = 0

        Dim startTop As Integer = 20
        Dim startLeft As Integer = 5
        Dim btnBoxSize As Integer = 75
        Dim row As Integer = 0
        Dim column As Integer = 0

        'The loop creates each new button
        Do While increCount < rowCount
            If ((startLeft + ((column + 1) * btnBoxSize)) > boxSize) Then
                row += 1
                column = 0
            End If
            ItemList(increCount).Left = startLeft + (column * btnBoxSize)
            ItemList(increCount).Top = startTop + (row * btnBoxSize)
            ItemList(increCount).Height = btnBoxSize
            ItemList(increCount).Width = btnBoxSize
            ItemList(increCount).Font = New Font(ItemList(increCount).Name, 10, FontStyle.Regular)
            ItemPnl.Controls.Add(ItemList(increCount))
            AddHandler ItemList(increCount).Click, AddressOf ItemList(increCount).addtoEditList
            increCount += 1
            column += 1
        Loop
    End Sub

    Private Sub SearchTextBox_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles SearchTxtBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim BCsearched As String = SearchTxtBox.Text
            'nowCart.addItem(BCsearched)
            SearchTxtBox.Text = ""
        End If
    End Sub

    Private Sub SearchTxtBox_LostFocus(sender As Object, e As EventArgs) Handles SearchTxtBox.LostFocus
        Dim SearchFocus As Boolean = True
        Dim i As Integer = 0
        While i < (ListEditQue.Items.Count)

            If ListEditQue.Focused Then
                SearchFocus = False
            End If

            i += 1
        End While

        If SearchFocus Then
            SearchTxtBox.Focus()
        End If

    End Sub

    Private Sub setListEditMode(sender As Object, e As EventArgs) Handles ListEditQue.GotFocus

        CatBox.Enabled = False
        BoxOuterBtnGrp.Enabled = False
        CartCtrlBox.Enabled = True
        BoxCartEdit.Enabled = True

    End Sub

    Private Sub BtnExitFieldEdit_Click(sender As Object, e As EventArgs) Handles BtnExitFieldEdit.Click
        Start()
    End Sub

    Private Sub RemBtn_Click(sender As Object, e As EventArgs) Handles RemBtn.Click

        Dim index As Integer = ListEditQue.SelectedIndex
        If index <> -1 Then
            nowCart.RemItem(index)
        End If
        If ListEditQue.Items.Count = 0 Then
            leaveCartEditMode()
        End If

    End Sub

    Private Sub ClrBtn_Click(sender As Object, e As EventArgs) Handles ClrBtn.Click

        nowCart.ClrItem()
        leaveCartEditMode()

    End Sub

    Public Sub leaveCartEditMode()

        CatBox.Enabled = True
        BoxOuterBtnGrp.Enabled = True
        BoxCartEdit.Enabled = True
        SearchTxtBox.Focus()
        CartCtrlBox.Enabled = False
        ListEditQue.ClearSelected()
        SearchTxtBox.Focus()

    End Sub

    Private Sub CnclBtn_Click(sender As Object, e As EventArgs) Handles CnclBtn.Click

        leaveCartEditMode()

    End Sub

    ''/////////////////////////////////////////////////////////////////////////////////////////////////////////''

    Private Sub BtnBegin_Click(sender As Object, e As EventArgs) Handles BtnBegin.Click

        If choice = 1 Then
            BoxSectionTwo.Visible = False
            BoxSectionThree.Visible = True
            RestockItemScreen()
        ElseIf choice = 3 Then
            BoxSectionTwo.Visible = False
            BoxSectionThree.Visible = True
            EditItemScreen()
        ElseIf choice = 4 Then
            BoxSectionTwo.Visible = False
            BoxSectionThree.Visible = True
            RemoveItemScreen()
        End If

    End Sub

    Private Sub BtnCnclCart_Click(sender As Object, e As EventArgs) Handles BtnCnclCart.Click
        Start()
    End Sub

    Private Sub BtnFinished_Click(sender As Object, e As EventArgs) Handles BtnFinished.Click

        If inputValidate() Then
            If choice = 1 Then
                RestockItemProcess()
            ElseIf choice = 2 Then
                AddItemProcess()
            ElseIf choice = 3 Then
                EditItemProcess()
            ElseIf choice = 4 Then
                RemoveItemProcess()
            End If
        End If
    End Sub

    Public Sub RestockItemScreen()

        If placeHold < nowCart.inCheckOut.Length() Then

            TxtNowStockFill.Enabled = False
            TxtStockFill.Enabled = False
            RdBtnSet.Checked = False
            RdBtnIncrease.Checked = False
            BoxSectionThree.Text = nowCart.inCheckOut(placeHold).ItemName
            TxtNowStockFill.Text = nowCart.inCheckOut(placeHold).StockQuant
            TxtStockFill.Text = 0
        Else
            MessageBox.Show("All Items selected were restocked", "Restock Complete")
            Start()
        End If
    End Sub

    Private Sub RdBtnSet_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtnSet.CheckedChanged

        If RdBtnSet.Checked = True Then
            TxtNowStockFill.Text = nowCart.inCheckOut(placeHold).StockQuant
            TxtNowStockFill.Enabled = True
            TxtStockFill.Enabled = False
            BtnFinished.Enabled = True
        End If
    End Sub

    Private Sub RdBtnIncrease_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtnIncrease.CheckedChanged
        If RdBtnIncrease.Checked = True Then
            TxtNowStockFill.Enabled = False
            TxtStockFill.Enabled = True
            BtnFinished.Enabled = True
        End If

    End Sub

    Public Sub RestockItemProcess()
        Dim stock As Integer = nowCart.inCheckOut(placeHold).StockQuant
        Dim barcode As String = nowCart.inCheckOut(placeHold).barcode
        Dim statement As String = ""
        If RdBtnSet.Checked = True Then
            stock = TxtNowStockFill.Text
            SalesForm.mainRegister.ReStock(barcode, stock)
        ElseIf RdBtnIncrease.Checked = True Then
            stock += TxtStockFill.Text
            SalesForm.mainRegister.ReStock(barcode, stock)
        End If
        placeHold += 1
        RestockItemScreen()
    End Sub

    Public Sub AddItemProcess()

        Dim barcode As String = TxtBarcodeFill.Text
        Dim ItemName As String = TxtNameFill.Text
        Dim CatSelected As String = CmboCatFill.Text
        'Candy 1
        'Snack 2
        'ColdFood 3
        'HotFood 4
        'Beverage 5
        'Alcohol 6
        'Cigarettes 7
        'Supplies 8
        'Other 9
        Dim Category As Integer = 1
        Select Case catSelected
            Case "Candy"
                Category = 1
            Case "Snack"
                Category = 2
            Case "ColdFood"
                Category = 3
            Case "HotFood"
                Category = 4
            Case "Beverage"
                Category = 5
            Case "Alcohol"
                Category = 6
            Case "Cigarettes"
                Category = 7
            Case "Supplies"
                Category = 8
            Case "Other"
                Category = 9
        End Select

        Dim ageReq As String = TxtAgeReqFill.Text
        Dim price As String = TxtPriceFill.Text

        Dim StockQuant As String = TxtNowStockFill.Text
        Dim LowQuant As String = TxtMiniStockFill.Text
        Dim HighQuant As String = TxtMaxStockFill.Text

        SalesForm.mainRegister.addItem(barcode, ItemName, ageReq, price, StockQuant, LowQuant, HighQuant, Category)

        MessageBox.Show("Your Item has been added", "Add Successful")
        Start()
    End Sub

    Public Sub EditItemScreen()
        If placeHold < nowCart.inCheckOut.Length() Then
            BoxSectionThree.Text = nowCart.inCheckOut(placeHold).ItemName
            TxtBarcodeFill.Enabled = False
            TxtBarcodeFill.Text = nowCart.inCheckOut(placeHold).barcode
            TxtNameFill.Text = nowCart.inCheckOut(placeHold).ItemName
            CmboCatFill.Text = nowCart.inCheckOut(placeHold).Category
            TxtAgeReqFill.Text = nowCart.inCheckOut(placeHold).ageReq
            TxtPriceFill.Text = nowCart.inCheckOut(placeHold).price
            TxtMiniStockFill.Text = nowCart.inCheckOut(placeHold).LowQuant
            TxtMaxStockFill.Text = nowCart.inCheckOut(placeHold).HighQuant
            LblNowStock.Visible = False
            TxtNowStockFill.Visible = False
        Else
            MessageBox.Show("All Items selected were Editted", "Edits Complete")
            Start()
        End If
    End Sub

    Public Sub EditItemProcess()

        Dim barcode As String = TxtBarcodeFill.Text
        Dim ItemName As String = TxtNameFill.Text
        Dim CatSelected As String = CmboCatFill.Text
        'ColdFood 1
        'CookedFood 2
        'Beverage 3
        'Alcohol 4
        'Cigarettes 5
        'NonCon 6
        'Other 7
        Dim Category As Integer = 1
        Select Case CatSelected
            Case "ColdFood"
                Category = 1
            Case "CookedFood"
                Category = 2
            Case "Beverage"
                Category = 3
            Case "Alcohol"
                Category = 4
            Case "Cigarettes"
                Category = 5
            Case "NonCon"
                Category = 6
            Case "Other"
                Category = 7
        End Select

        Dim ageReq As String = TxtAgeReqFill.Text
        Dim price As String = TxtPriceFill.Text
        Dim LowQuant As String = TxtMiniStockFill.Text
        Dim HighQuant As String = TxtMaxStockFill.Text

        SalesForm.mainRegister.EditItem(barcode, ItemName, ageReq, price, LowQuant, HighQuant, Category)
        placeHold += 1
        EditItemScreen()

    End Sub

    Public Sub RemoveItemScreen()
        If placeHold < nowCart.inCheckOut.Length() Then
            BoxSectionThree.Text = "Delete " & nowCart.inCheckOut(placeHold).ItemName & "?"
        Else
            MessageBox.Show("All Items selected were Removed", "Items Removed")
            Start()
        End If
    End Sub

    Public Sub RemoveItemProcess()
        Dim sbarcode As String = nowCart.inCheckOut(placeHold).barcode
        SalesForm.mainRegister.RemoveItem(sbarcode)
        placeHold += 1
        RemoveItemScreen()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Dispose()
    End Sub

    Private Function inputValidate()
        Dim valid As Boolean = False
        Dim errorList As String = "Please check field(s): "

        If choice = 1 Then
            'Restock

            If RdBtnSet.Checked = True And TxtNowStockFill.Text <> "" Then
                'Check that it's an integer
                If IsNumeric(TxtNowStockFill.Text) Then
                    TxtNowStockFill.Text = Replace(TxtNowStockFill.Text, ".", "")
                    valid = True
                End If
            ElseIf RdBtnIncrease.Checked = True And TxtStockFill.Text <> "" Then
                'Check that it's an integer
                If IsNumeric(TxtStockFill.Text) Then
                    TxtStockFill.Text = Replace(TxtStockFill.Text, ".", "")
                    valid = True
                End If
            Else
                valid = False
                MessageBox.Show("please select between Set and Increase stock, then enter the desired value", "error")
            End If
        ElseIf choice = 2 Then
            'Add

            If TxtBarcodeFill.Text <> "" And IsNumeric(TxtBarcodeFill.Text) Then
                TxtBarcodeFill.Text = Replace(TxtBarcodeFill.Text, ".", "")
                valid = True
            Else
                valid = False
                errorList += " 1 "
            End If

            If TxtNameFill.Text <> "" Then
                valid = True
            Else
                valid = False
                errorList += " 2 "
            End If

            If CmboCatFill.Text <> "" Or CmboCatFill.Text <> "------" Then
                valid = True
            Else
                valid = False
                errorList += " 3 "
            End If

            If TxtAgeReqFill.Text <> "" And IsNumeric(TxtAgeReqFill.Text) Then
                TxtAgeReqFill.Text = Replace(TxtAgeReqFill.Text, ".", "")
                valid = True
            Else
                valid = False
                errorList += " 4 "
            End If

            If TxtPriceFill.Text <> "" And IsNumeric(TxtAgeReqFill.Text) Then
                valid = True
            Else
                valid = False
                errorList += " 5 "
            End If

            If TxtMiniStockFill.Text <> "" And IsNumeric(TxtMiniStockFill.Text) Then
                TxtMiniStockFill.Text = Replace(TxtMiniStockFill.Text, ".", "")
                valid = True
            Else
                valid = False
                errorList += " 6 "
            End If

            If TxtMaxStockFill.Text <> "" And IsNumeric(TxtMaxStockFill.Text) Then
                TxtMaxStockFill.Text = Replace(TxtMaxStockFill.Text, ".", "")
                valid = True
            Else
                valid = False
                errorList += " 7 "
            End If

            If TxtNowStockFill.Text <> "" And IsNumeric(TxtNowStockFill.Text) Then
                TxtNowStockFill.Text = Replace(TxtNowStockFill.Text, ".", "")
                valid = True
            Else
                valid = False
                errorList += " 8 "
            End If

            If valid = False Then
                MessageBox.Show(errorList, "error")
            End If

        ElseIf choice = 3 Then
            'Edit

            If TxtNameFill.Text <> "" Then
                valid = True
            Else
                valid = False
                errorList += " 2 "
            End If

            If CmboCatFill.Text <> "" Or CmboCatFill.Text <> "------" Then
                valid = True
            Else
                valid = False
                errorList += " 3 "
            End If

            If TxtAgeReqFill.Text <> "" And IsNumeric(TxtAgeReqFill.Text) Then
                TxtAgeReqFill.Text = Replace(TxtAgeReqFill.Text, ".", "")
                valid = True
            Else
                valid = False
                errorList += " 4 "
            End If

            If TxtPriceFill.Text <> "" And IsNumeric(TxtAgeReqFill.Text) Then
                valid = True
            Else
                valid = False
                errorList += " 5 "
            End If

            If TxtMiniStockFill.Text <> "" And IsNumeric(TxtMiniStockFill.Text) Then
                TxtMiniStockFill.Text = Replace(TxtMiniStockFill.Text, ".", "")
                valid = True
            Else
                valid = False
                errorList += " 6 "
            End If

            If TxtMaxStockFill.Text <> "" And IsNumeric(TxtMaxStockFill.Text) Then
                TxtMaxStockFill.Text = Replace(TxtMaxStockFill.Text, ".", "")
                valid = True
            Else
                valid = False
                errorList += " 7 "
            End If

            If valid = False Then
                MessageBox.Show(errorList, "error")
            End If
        End If



        Return valid
    End Function

End Class




