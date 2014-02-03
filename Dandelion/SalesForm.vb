﻿Imports Dandelion
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Data.SqlClient

Public Class SalesForm
    Dim mainRegister As DatabaseClass = New DatabaseClass
    Dim catSelected As Integer = -1


    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainRegister.Database()
        changeCat(1) 'Start with first category open by default




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
    Private Sub changeCat(ByVal choiceCat As Integer)

        If (Not (choiceCat = catSelected)) Then

            catSelected = choiceCat


            Dim ItemList As ItemButton()
            mainRegister.getItemList(choiceCat, ItemList)

            ItemPnl.Dispose()
            ItemPnl = New Panel
            ItemPnl.AutoScroll = True
            ItemPnl.Left = CatBox.Right
            ItemPnl.Width = CartGrpBox.Left - CatBox.Right
            ItemPnl.Height = CtrlBox.Top
            Me.Controls.Add(ItemPnl)


            Dim boxSize As Double = ItemPnl.Size.Width()
            Dim rowCount As Integer = ItemList.Length
            Dim increCount As Integer = 0

            Dim startTop As Integer = 20
            Dim startLeft As Integer = 5
            Dim btnBoxSize As Integer = 75
            Dim row As Integer = 0
            Dim column As Integer = 0

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
                AddHandler ItemList(increCount).Click, AddressOf Me.addToCart
                increCount += 1
                column += 1

            Loop
        End If
    End Sub

    Public Sub addToCart(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

End Class
