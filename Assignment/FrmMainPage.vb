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

    Private Sub FrmMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim staffDepartment = GetStaffDepartmentByUsername(FrmTable.lblName.Text)

        If staffDepartment = "Administrative staff" Then
            btnStaffModule.Visible = True
            btnOrderPayment.Visible = True
            pbStaff.Visible = True
            pbPayment.Visible = True
        Else
            btnStaffModule.Visible = False
            btnOrderPayment.Visible = False
            pbStaff.Visible = False
            pbPayment.Visible = False
        End If
    End Sub

    Public Function GetStaffDepartmentByUsername(username As String) As String
        Using db As New BL_farizDataContext()
            Dim staffDepartment = (From s In db.Staffs
                                   Where s.Username = username AndAlso s.Status = "Active"
                                   Select s.Department).FirstOrDefault()

            Return staffDepartment
        End Using
    End Function

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        btnLogOut_Click(Nothing, Nothing)
    End Sub

    Private Sub FieldGuidelineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldGuidelineToolStripMenuItem.Click
        MessageBox.Show(
        "MAIN PAGE SAFEGUARDS:" & vbCrLf & vbCrLf &
        "1. Staff Module : add staff, view & modify staff info, staff report" & vbCrLf &
        "2. Order Management Module : add order, view & modify order details, do payment" & vbCrLf &
        "3. Item Stock Management Module : add item, view & modify item info, item report" & vbCrLf &
        "4. Payment & Billing Module : order history, sales report, payment report",
        "Main Page Help",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class