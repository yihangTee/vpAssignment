Public Class FrmUserProfile

    Private Sub FrmUserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblID.Text = App.CurrentUserID
        lblName.Text = App.CurrentUserName

        If App.CurrentUserDepartment = "Administrative staff" Then
            tpgStaff.Enabled = True
            tpgOrder.Enabled = True
            tpgItemStock.Enabled = True
            tpgBilling.Enabled = True
        ElseIf App.CurrentUserDepartment = "Front-Of-House staff" Then
            TabControl1.SelectedIndex = 1
            tpgStaff.Enabled = False
            tpgOrder.Enabled = True
            tpgItemStock.Enabled = True
            tpgBilling.Enabled = True
        ElseIf App.CurrentUserDepartment = "Back-Of-House staff" Then
            TabControl1.SelectedIndex = 1
            tpgStaff.Enabled = False
            tpgOrder.Enabled = True
            tpgItemStock.Enabled = True
            tpgBilling.Enabled = True
        End If
    End Sub

    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click, AddNewStaffToolStripMenuItem.Click
        Me.Hide()
        FrmAddStaff.Show()
    End Sub

    Private Sub btnViewStaff_Click(sender As Object, e As EventArgs) Handles btnViewStaff.Click, ViewStaffToolStripMenuItem.Click
        Me.Hide()
        FrmViewStaff.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        FrmMainPage.Show()
    End Sub

    Private Sub btnStaffReport_Click(sender As Object, e As EventArgs) Handles btnStaffReport.Click, GenerateStaffToolStripMenuItem.Click
        Me.Hide()
        FrmGenerateStaffReport.Show()
    End Sub

    Private Sub FieldGuidelineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldGuidelineToolStripMenuItem.Click
        Dim guideText As String =
            "=== User Guide ===" & vbCrLf &
            " 1. Staff Management" & vbCrLf &
            "🔹 Add Staff – Opens a form to add new staff." & vbCrLf &
            "🔹 View & Modification Staff – See full staff data and modify selected staff record" & vbCrLf &
            "🔹 Staff Report – Preview or export staff reports as PDF and Txt file." & vbCrLf & vbCrLf &
            " 2. Order Management" & vbCrLf &
            " 3. Billing & Payment" & vbCrLf &
            " 4. Item Stock Management" & vbCrLf &
            "🔹 Add Item – Opens a form to add new stock items." & vbCrLf &
            "🔹 View & Track Item – See full item data and history tracking." & vbCrLf &
            "🔹 Update Item – Modify existing item information by entering an ID." & vbCrLf &
            "🔹 Delete Item – Search and delete items after confirmation." & vbCrLf &
            "🔹 Item Report – Filter, preview, print or export stock reports as PDF." & vbCrLf & vbCrLf &
            "💡 Tip: Hover over controls for tooltips or error hints when input is invalid."

        MessageBox.Show(guideText, "Module User Guide", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Staff Management System" & vbCrLf &
                    "Version 1.0" & vbCrLf &
                    "Developed by: [Tan Kae Ong]" & vbCrLf &
                    "© 2025 All rights reserved.",
                    "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class