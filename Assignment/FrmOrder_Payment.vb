Public Class FrmOrder_Payment
    Private Sub btnSalesReport_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click
        FrmSalesReport.ShowDialog()
    End Sub

    Private Sub btnOrderHistory_Click(sender As Object, e As EventArgs) Handles btnOrderHistory.Click
        FrmOrderHistory.ShowDialog()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        FrmMainPage.Show()
    End Sub

    Private Sub btnPaymentReport_Click(sender As Object, e As EventArgs) Handles btnPaymentReport.Click
        Me.Close()
        FrmPaymentReport.Show()
    End Sub
End Class