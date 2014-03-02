Imports Dandelion
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Data.SqlClient

Public Class SalesForm
    Public mainRegister As DatabaseClass = New DatabaseClass
    Public currentCart As Cart = New Cart
    Dim ItemList As ItemButton()
    Dim catSelected As Integer = -1

    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainRegister.Database()
        currentCart.cartIntialize()
        changeCat(1) 'Start with first category open by default
        SearchTxtBox.Focus()
        CartCtrlBox.Enabled = False
    End Sub

    Private Sub ColdBtn_Click(sender As Object, e As EventArgs) Handles ColdBtn.Click
        changeCat(1)
    End Sub

    Private Sub CookedBtn_Click(sender As Object, e As EventArgs) Handles CookedBtn.Click
        changeCat(2)
    End Sub

    Private Sub BeverageBtn_Click(sender As Object, e As EventArgs) Handles BeverageBtn.Click
        changeCat(3)
    End Sub

    Private Sub AlcoholBtn_Click(sender As Object, e As EventArgs) Handles AlcoholBtn.Click
        changeCat(4)
    End Sub

    Private Sub CigBtn_Click(sender As Object, e As EventArgs) Handles CigBtn.Click
        changeCat(5)
    End Sub

    Private Sub NonConsumBtn_Click(sender As Object, e As EventArgs) Handles NonConsumBtn.Click
        changeCat(6)
    End Sub

    Private Sub Other_Click(sender As Object, e As EventArgs) Handles Other.Click
        changeCat(7)
    End Sub

    Private Sub SearchTextBox_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles SearchTxtBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim BCsearched As String = SearchTxtBox.Text
            currentCart.addItem(BCsearched)
            SearchTxtBox.Text = ""
        End If
    End Sub

    Private Sub changeCat(ByVal choiceCat As Integer)

        mainRegister.getItemList(choiceCat, ItemList)

        addBtnToPnl()

    End Sub

    Public Sub addBtnToPnl()

        'To reset the buttons, the program disposes of the panel and recreates it
        ItemPnl.Dispose()
        ItemPnl = New Panel
        ItemPnl.AutoScroll = True
        ItemPnl.Left = CatBox.Right
        ItemPnl.Width = CartGrpBox.Left - CatBox.Right
        ItemPnl.Height = CtrlBox.Top
        Me.Controls.Add(ItemPnl)

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
            ItemPnl.Controls.Add(ItemList(increCount))
            AddHandler ItemList(increCount).Click, AddressOf ItemList(increCount).addToCart
            increCount += 1
            column += 1
        Loop
    End Sub

    Private Sub SearchTxtBox_LostFocus(sender As Object, e As EventArgs) Handles SearchTxtBox.LostFocus
        Dim SearchFocus As Boolean = True
        Dim i As Integer = 0
        While i < (CartLstBox.Items.Count)

            If CartLstBox.Focused Then
                SearchFocus = False
            End If

            i += 1
        End While

        If SearchFocus Then
            SearchTxtBox.Focus()
        End If

    End Sub

    Private Sub IncrBtn_Click(sender As Object, e As EventArgs) Handles IncrBtn.Click

        Dim index As Integer = CartLstBox.SelectedIndex
        If index <> -1 Then
            currentCart.incrItem(index)
        End If
        If CartLstBox.Items.Count = 0 Then
            leaveCartEditMode()
        End If
    End Sub

    Private Sub DecBtn_Click(sender As Object, e As EventArgs) Handles DecBtn.Click

        Dim index As Integer = CartLstBox.SelectedIndex
        If index <> -1 Then
            currentCart.decItem(index)
        End If
        If CartLstBox.Items.Count = 0 Then
            leaveCartEditMode()
        End If
    End Sub

    Private Sub RemBtn_Click(sender As Object, e As EventArgs) Handles RemBtn.Click

        Dim index As Integer = CartLstBox.SelectedIndex
        If index <> -1 Then
            currentCart.RemItem(index)
        End If
        If CartLstBox.Items.Count = 0 Then
            leaveCartEditMode()
        End If

    End Sub

    Private Sub ClrBtn_Click(sender As Object, e As EventArgs) Handles ClrBtn.Click

        currentCart.ClrItem()
        leaveCartEditMode()

    End Sub

    Private Sub CnclBtn_Click(sender As Object, e As EventArgs) Handles CnclBtn.Click
        leaveCartEditMode()
    End Sub

    Private Sub setCartEditMode(sender As Object, e As EventArgs) Handles CartLstBox.GotFocus

        Dim cControl As Control
        For Each cControl In Me.Controls
            If cControl.Left < CartGrpBox.Left Then
                cControl.Enabled = False
                CartCtrlBox.Enabled = True
                CnclBtn.Visible = True
            End If
        Next
    End Sub

    Public Sub leaveCartEditMode()

        Dim cControl As Control
        For Each cControl In Me.Controls
            cControl.Enabled = True
        Next
        CartCtrlBox.Enabled = False
        CartLstBox.ClearSelected()
        CnclBtn.Visible = False
        SearchTxtBox.Focus()


    End Sub

End Class
