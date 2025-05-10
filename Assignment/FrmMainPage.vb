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
        Me.Close()
    End Sub

    Private Sub btnOrderPayment_Click(sender As Object, e As EventArgs) Handles btnOrderPayment.Click
        FrmOrder_Payment.Show()
        Me.Close()
    End Sub
End Class