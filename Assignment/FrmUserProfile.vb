Public Class FrmUserProfile

    Private Sub FrmUserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblID.Text = App.CurrentUserID
        lblName.Text = App.CurrentUserName
    End Sub

    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click, AddToolStripMenuItem.Click
        Me.Hide()
        FrmAddStaff.Show()
    End Sub

    Private Sub btnViewStaff_Click(sender As Object, e As EventArgs) Handles btnViewStaff.Click, ViewModifyStaffToolStripMenuItem.Click
        Me.Hide()
        FrmViewStaff.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FrmMainPage.Show()
    End Sub

    Private Sub btnStaffReport_Click(sender As Object, e As EventArgs) Handles btnStaffReport.Click, GenerateStaffReportToolStripMenuItem.Click
        Me.Hide()
        FrmGenerateStaffReport.Show()
    End Sub

    Private Sub FieldGuidelineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldGuidelineToolStripMenuItem.Click
        Dim guideText As String =
            "=== User Guide ===" & vbCrLf &
            " Staff Management" & vbCrLf &
            "🔹 Add Staff – Opens a form to add new staff." & vbCrLf &
            "🔹 View & Modification Staff – See full staff data and modify selected staff record" & vbCrLf &
            "🔹 Staff Report – Preview or export staff reports as PDF and Txt file." & vbCrLf & vbCrLf &
            "💡 Tip: Hover over controls for tooltips or error hints when input is invalid."

        MessageBox.Show(guideText, "Module User Guide", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Staff Management System" & vbCrLf &
                    "Version 1.0" & vbCrLf &
                    "Developed by: [Tan Kae Ong]" & vbCrLf &
                    "© 2025 All rights reserved.",
                    "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class