Public Class AgeVerificationForm

    Dim regDate As Date

    Private Sub AgeVerificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        regDate = Date.Now()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
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
End Class