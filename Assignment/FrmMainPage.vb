Public Class FrmMainPage
    Private Sub btnOrderPage_Click(sender As Object, e As EventArgs) Handles btnOrderPage.Click
        Me.Hide()
        FrmTable.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If MessageBox.Show("Are you sure you want to log out from this account?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Me.Close()
        FrmLogin.Show()
    End Sub

    Private Sub btnItemModule_Click(sender As Object, e As EventArgs) Handles btnItemModule.Click
        Me.Hide()
        frmItemStock.Show()
    End Sub

    Private Sub btnOrderPayment_Click(sender As Object, e As EventArgs) Handles btnOrderPayment.Click
        Me.Hide()
        FrmOrder_Payment.Show()
    End Sub

    Private Sub btnStaffModule_Click(sender As Object, e As EventArgs) Handles btnStaffModule.Click
        Me.Hide()
        FrmUserProfile.Show()
    End Sub
End Class