Imports Dandelion
Public Class SalesForm

    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DandelionDB1DataSet11.Item' table. You can move, or remove it, as needed.
        Dim testItem As Item
        testItem = New Item
        testItem.setAll("343311", "Redds Strawberry", "Alcoholic", 2.99)

        'testing dynamically adding a button to a tab
        Dim redds As ItemButton
        redds = New ItemButton
        redds.Enabled = True




    End Sub
End Class
