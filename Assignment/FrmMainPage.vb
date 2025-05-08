Public Class FrmMainPage
    Private Sub btnOrderPage_Click(sender As Object, e As EventArgs) Handles btnOrderPage.Click
        Me.Close()
        FrmTable.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
    End Sub

    Private Sub btnItemModule_Click(sender As Object, e As EventArgs) Handles btnItemModule.Click
        frmItemStock.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        FrmSalesReport.ShowDialog()
    End Sub

End Class