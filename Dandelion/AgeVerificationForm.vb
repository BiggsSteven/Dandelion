Public Class AgeVerificationForm

    Dim regDate As Date

    Private Sub AgeVerificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        regDate = Date.Now()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim days
        If (regDate.Month = 1 Or regDate.Month = 3 Or regDate.Month = 5 Or regDate.Month = 7 Or regDate.Month = 8 Or regDate.Month = 10 Or regDate.Month = 12) Then
            days = 31
        ElseIf (regDate.Month = 4 Or regDate.Month = 6 Or regDate.Month = 9 Or regDate.Month = 11) Then
            days = 30
        Else
            days = 28    'Make ammendment for leap year
        End If
    End Sub
    Private Sub SetAgeReqText(ByVal AgeReq As Integer)
        Label4.Text = AgeReq
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles InputConfirmBtn.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles QuickConfirmBtn.Click
        Me.Close()
    End Sub

    Private Sub MnthTxtBox_TextChanged(sender As Object, e As EventArgs) Handles MnthTxtBox.TextChanged
        If (MnthTxtBox.TextLength = 2) Then
            DayTextBox.Focus()
        End If
    End Sub

    Private Sub DayTextBox_TextChanged(sender As Object, e As EventArgs) Handles DayTextBox.TextChanged
        If (DayTextBox.TextLength = 2) Then
            YrTxtBox.Focus()
        End If
    End Sub

    Private Sub YrTxtBox_TextChanged(sender As Object, e As EventArgs) Handles YrTxtBox.TextChanged
        If (YrTxtBox.TextLength = 4) Then
            InputConfirmBtn.Focus()
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub
End Class