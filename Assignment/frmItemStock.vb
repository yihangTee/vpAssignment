Public Class frmItemStock
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click, AddToolStripMenuItem.Click
        frmAddItem.ShowDialog()
    End Sub

    Private Sub btnViewnTrack_Click(sender As Object, e As EventArgs) Handles btnViewnTrack.Click, ViewTrackItemToolStripMenuItem.Click
        frmViewnTrackItem.ShowDialog()
    End Sub

    Private Sub btnUpdateItemInfo_Click(sender As Object, e As EventArgs) Handles btnUpdateItemInfo.Click, UpdateItemToolStripMenuItem.Click
        frmUpdateItem.ShowDialog()
    End Sub

    Private Sub btnArchieveItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click, DeleteItemToolStripMenuItem.Click
        frmDeleteItem.ShowDialog()
    End Sub

    Private Sub btnGenerateItemReport_Click(sender As Object, e As EventArgs) Handles btnGenerateItemReport.Click, ReportToolStripMenuItem.Click
        frmItemReport.ShowDialog()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UserGuideToolstripMenuItem_Click(sender As Object, e As EventArgs) Handles UserGuideToolStripMenuItem.Click
        Dim guideText As String =
            "=== User Guide ===" & vbCrLf &
            "🔹 Add Item – Opens a form to add new stock items." & vbCrLf &
            "🔹 View & Track Item – See full item data and history tracking." & vbCrLf &
            "🔹 Update Item – Modify existing item information by entering an ID." & vbCrLf &
            "🔹 Delete Item – Search and delete items after confirmation." & vbCrLf &
            "🔹 Item Report – Filter, preview, print or export stock reports as PDF." & vbCrLf & vbCrLf &
            "💡 Tip: Hover over controls for tooltips or error hints when input is invalid."

        MessageBox.Show(guideText, "Module User Guide", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Item Stock Management System" & vbCrLf &
                    "Version 1.0" & vbCrLf &
                    "Developed by: [Soh Zi Ying]" & vbCrLf &
                    "© 2025 All rights reserved.",
                    "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
