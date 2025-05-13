Public Class FrmMainPage
    Private Sub btnOrderPage_Click(sender As Object, e As EventArgs) Handles btnOrderPage.Click
        Me.Close()
        FrmTable.Show()

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        FrmPaymentReport.Show()
    End Sub
End Class