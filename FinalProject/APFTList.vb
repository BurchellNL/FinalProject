Public Class APFTList
    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
    End Sub

    Private Sub APFTList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'APFTDataBaseDataSet.APFT' table. You can move, or remove it, as needed.
        Me.APFTTableAdapter.Fill(Me.APFTDataBaseDataSet.APFT)

    End Sub
End Class