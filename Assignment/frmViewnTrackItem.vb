Public Class frmViewnTrackItem
    Private Sub btnViewItem_Click(sender As Object, e As EventArgs) Handles btnViewItem.Click, ViewToolStripMenuItem.Click
        frmViewItem.ShowDialog()
    End Sub

    Private Sub btnTrackItem_Click(sender As Object, e As EventArgs) Handles btnTrackItem.Click, TrackItemToolStripMenuItem.Click
        frmTrackItem.ShowDialog()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FieldGuidelineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldGuidelineToolStripMenuItem.Click
        MessageBox.Show(
        "VIEW / TRACK ITEMS:" & vbCrLf & vbCrLf &
        "1. View full Item Lists" & vbCrLf &
        "2. Track items through 4 types of aspect",
        "View/Track Help",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class