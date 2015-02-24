Public Class CheckOutForm

    Private total As Double = SalesForm.TBlankLbl.Text

    Private Sub CheckOutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalFillLbl.Text = FormatCurrency(total)
        MskTendered.Text = FormatCurrency(0)
    End Sub

    Private Sub CashSaleBtn_Click(sender As Object, e As EventArgs) Handles CashSaleBtn.Click
        PaymentChosen()
        CashSaleBtn.Font = New Font(CashSaleBtn.Font, FontStyle.Bold)
        CreditSaleBtn.Font = New Font(CreditSaleBtn.Font, FontStyle.Regular)
        CheckSaleBtn.Font = New Font(CheckSaleBtn.Font, FontStyle.Regular)
    End Sub

    Private Sub CreditSaleBtn_Click(sender As Object, e As EventArgs) Handles CreditSaleBtn.Click
        PaymentChosen()
        CashSaleBtn.Font = New Font(CashSaleBtn.Font, FontStyle.Regular)
        CreditSaleBtn.Font = New Font(CreditSaleBtn.Font, FontStyle.Bold)
        CheckSaleBtn.Font = New Font(CheckSaleBtn.Font, FontStyle.Regular)
    End Sub

    Private Sub CheckSaleBtn_Click(sender As Object, e As EventArgs) Handles CheckSaleBtn.Click
        PaymentChosen()
        CashSaleBtn.Font = New Font(CashSaleBtn.Font, FontStyle.Regular)
        CreditSaleBtn.Font = New Font(CreditSaleBtn.Font, FontStyle.Regular)
        CheckSaleBtn.Font = New Font(CheckSaleBtn.Font, FontStyle.Bold)
    End Sub

    Sub PaymentChosen()
        Me.KeyPreview = True
        MskTendered.Text = FormatCurrency(0)
        NumPadPnl.Enabled = True
        CnclBtn.Focus()
    End Sub

    Private Sub CheckOutForm_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyUp

        Dim tempVal As Double = MskTendered.Text
        Dim numHold As Integer

        If e.KeyCode = Keys.D0 Or e.KeyCode = Keys.NumPad0 Then
            numHold = 0
            tempVal = (tempVal * 10) + (numHold * 0.01)
        ElseIf e.KeyCode = Keys.D1 Or e.KeyCode = Keys.NumPad1 Then
            numHold = 1
            tempVal = (tempVal * 10) + (numHold * 0.01)
        ElseIf e.KeyCode = Keys.D2 Or e.KeyCode = Keys.NumPad2 Then
            numHold = 2
            tempVal = (tempVal * 10) + (numHold * 0.01)
        ElseIf e.KeyCode = Keys.D3 Or e.KeyCode = Keys.NumPad3 Then
            numHold = 3
            tempVal = (tempVal * 10) + (numHold * 0.01)
        ElseIf e.KeyCode = Keys.D4 Or e.KeyCode = Keys.NumPad4 Then
            numHold = 4
            tempVal = (tempVal * 10) + (numHold * 0.01)
        ElseIf e.KeyCode = Keys.D5 Or e.KeyCode = Keys.NumPad5 Then
            numHold = 5
            tempVal = (tempVal * 10) + (numHold * 0.01)
        ElseIf e.KeyCode = Keys.D6 Or e.KeyCode = Keys.NumPad6 Then
            numHold = 6
            tempVal = (tempVal * 10) + (numHold * 0.01)
        ElseIf e.KeyCode = Keys.D7 Or e.KeyCode = Keys.NumPad7 Then
            numHold = 7
            tempVal = (tempVal * 10) + (numHold * 0.01)
        ElseIf e.KeyCode = Keys.D8 Or e.KeyCode = Keys.NumPad8 Then
            numHold = 8
            tempVal = (tempVal * 10) + (numHold * 0.01)
        ElseIf e.KeyCode = Keys.D9 Or e.KeyCode = Keys.NumPad9 Then
            numHold = 9
            tempVal = (tempVal * 10) + (numHold * 0.01)
        ElseIf e.KeyCode = Keys.C Then
            tempVal = 0.0
        ElseIf e.KeyCode = Keys.Enter Then
        End If

        If e.KeyCode = Keys.Back Then
            tempVal *= 10
            tempVal = Math.Floor(tempVal)
            tempVal *= 0.01
        End If
        MskTendered.Text = FormatCurrency(tempVal)
        e.Handled = True

    End Sub

    Private Sub MskTendered_textedChanged(sender As Object, e As EventArgs) Handles MskTendered.TextChanged

        Dim total As Double = TotalFillLbl.Text
        Dim tender As Double = MskTendered.Text
        Dim change As Double = tender - total

        If (change >= 0) Then
            ChangeFillLbl.Text = FormatCurrency(change)
            CompleteBtn.Enabled = True
            CompleteBtn.Focus()
        Else
            ChangeFillLbl.Text = FormatCurrency(0)
            CompleteBtn.Enabled = False
            CnclBtn.Focus()
        End If

    End Sub

    Private Sub Num0Btn_Click(sender As Object, e As EventArgs) Handles Num0Btn.Click
        ClickedNumber(0)
    End Sub

    Private Sub Num1Btn_Click(sender As Object, e As EventArgs) Handles Num1Btn.Click
        ClickedNumber(1)
    End Sub

    Private Sub Num2Btn_Click(sender As Object, e As EventArgs) Handles Num2Btn.Click
        ClickedNumber(2)
    End Sub

    Private Sub Num3Btn_Click(sender As Object, e As EventArgs) Handles Num3Btn.Click
        ClickedNumber(3)
    End Sub

    Private Sub Num4Btn_Click(sender As Object, e As EventArgs) Handles Num4Btn.Click
        ClickedNumber(4)
    End Sub

    Private Sub Num5Btn_Click(sender As Object, e As EventArgs) Handles Num5Btn.Click
        ClickedNumber(5)
    End Sub

    Private Sub Num6Btn_Click(sender As Object, e As EventArgs) Handles Num6Btn.Click
        ClickedNumber(6)
    End Sub

    Private Sub Num7Btn_Click(sender As Object, e As EventArgs) Handles Num7Btn.Click
        ClickedNumber(7)
    End Sub

    Private Sub Num8Btn_Click(sender As Object, e As EventArgs) Handles Num8Btn.Click
        ClickedNumber(8)
    End Sub

    Private Sub Num9Btn_Click(sender As Object, e As EventArgs) Handles Num9Btn.Click
        ClickedNumber(9)
    End Sub

    Private Sub BSBtn_Click(sender As Object, e As EventArgs) Handles BSBtn.Click
        Dim tempVal As Double = MskTendered.Text
        Dim numHold As Integer
        tempVal *= 10
        tempVal = Math.Floor(tempVal)
        tempVal *= 0.01
        MskTendered.Text = FormatCurrency(tempVal)
    End Sub

    Private Sub ClrBtn_Click(sender As Object, e As EventArgs) Handles ClrBtn.Click
        MskTendered.Text = FormatCurrency(0)
    End Sub

    Private Sub ECBtn_Click(sender As Object, e As EventArgs) Handles ECBtn.Click
        Dim total As Double = TotalFillLbl.Text
        MskTendered.Text = total
    End Sub

    Private Sub CnclBtn_Click(sender As Object, e As EventArgs) Handles CnclBtn.Click
        Me.Close()
    End Sub

    Private Sub CompleteBtn_Click(sender As Object, e As EventArgs) Handles CompleteBtn.Click
        SalesForm.currentCart.DestockCart()
        SalesForm.currentCart.ClrItem()
        Me.Close()
    End Sub

    Public Sub ClickedNumber(ByVal numHold As Integer)
        Dim tempVal As Double = MskTendered.Text
        tempVal = (tempVal * 10) + (numHold * 0.01)
        MskTendered.Text = FormatCurrency(tempVal)
    End Sub
End Class