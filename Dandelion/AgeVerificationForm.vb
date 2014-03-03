Public Class AgeVerificationForm

    Dim regDate As Date

    Private Sub AgeVerificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        regDate = Date.Today()
        Label4.Text = SalesForm.currentCart.minAgeReq
        MaskedTextBox1.Focus()
        MaskedTextBox1.SelectionStart = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles InputConfirmBtn.Click
        CalculateAge()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles QuickConfirmBtn.Click
        SalesForm.currentCart.setAge(SalesForm.currentCart.minAgeReq)
        Me.Close()
    End Sub

    Public Sub CalculateAge()
        Dim Birthday As Date = MaskedTextBox1.Text
        Dim LegalBirthday As Date = New Date(regDate.Year - 21, regDate.Month, regDate.Day)

        If Birthday <= LegalBirthday Then
            SalesForm.currentCart.setAge(regDate.Year - Birthday.Year)
        End If
    End Sub
    Private Sub MaskedTextBox1_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MaskedTextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            CalculateAge()
            Me.Close()
        End If
    End Sub

End Class