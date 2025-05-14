Imports System.Linq

Public Class frmDeleteItem
    Private currentItem As Item

    Private Sub frmDeleteItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearFields()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnDeleteSearch_Click(sender As Object, e As EventArgs) Handles btnDeleteSearch.Click, SearchToolStripMenuItem.Click
        Dim itemId As String = mskSearchDeleteItemId.Text.Trim()

        If itemId = "" Then
            MessageBox.Show("Please enter an Item ID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mskSearchDeleteItemId.Focus()
            Exit Sub
        End If

        currentItem = idb.Items.FirstOrDefault(Function(i) i.Item_Id = itemId)

        If currentItem Is Nothing Then
            MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearFields()
            Exit Sub
        End If

        ' Load brief info
        lblShowDeleteItemID.Text = currentItem.Item_Id
        lblShowDeleteItemName.Text = currentItem.Item_Name
        picDeleteItemPicture.Image = If(currentItem.Item_Picture IsNot Nothing, ByteArrayToImage(currentItem.Item_Picture.ToArray()), Nothing)
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click, DelToolStripMenuItem1.Click
        If currentItem Is Nothing Then
            MessageBox.Show("Please search and select an item first.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim result = MessageBox.Show("Are you sure you want to delete this item? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            idb.Items.DeleteOnSubmit(currentItem)
            idb.SubmitChanges()
            MessageBox.Show("Item deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
        End If
    End Sub

    Private Sub btnReviewItemDetails_Click(sender As Object, e As EventArgs) Handles btnReviewItemDetails.Click
        If currentItem Is Nothing Then
            MessageBox.Show("Please search and select an item first.", "View Details", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Assuming frmItemDetails reads the item from a shared context or you pass data accordingly
        Dim detailsForm As New frmItemDetails(currentItem)
        detailsForm.ShowDialog()
    End Sub

    Private Function ByteArrayToImage(byteArray As Byte()) As Image
        If byteArray Is Nothing OrElse byteArray.Length = 0 Then Return Nothing
        Using ms As New IO.MemoryStream(byteArray)
            Return Image.FromStream(ms)
        End Using
    End Function

    Private Sub ClearFields()
        mskSearchDeleteItemId.Clear()
        mskSearchDeleteItemId.Focus()
        lblShowDeleteItemID.Text = ""
        lblShowDeleteItemName.Text = ""
        picDeleteItemPicture.Image = Nothing
        currentItem = Nothing
    End Sub

    Private Sub btnDeleteClear_Click(sender As Object, e As EventArgs) Handles btnDeleteClear.Click, ClearToolStripMenuItem.Click
        ClearFields()
    End Sub

    Private Sub mskSearchDeleteItemID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskSearchDeleteItemId.Validating
        If String.IsNullOrWhiteSpace(mskSearchDeleteItemId.Text) Then
            ErrorProvider1.SetError(mskSearchDeleteItemId, "Please Enter a Valid ID")
        Else
            ErrorProvider1.SetError(mskSearchDeleteItemId, "")
        End If
    End Sub

    Private Sub FieldGuidelineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldGuidelineToolStripMenuItem.Click
        MessageBox.Show(
        "DELETION SAFEGUARDS:" & vbCrLf & vbCrLf &
        "1. Search for the item using its ID." & vbCrLf &
        "2. Review item details before deletion." & vbCrLf &
        "3. Confirm deletion with a warning message." & vbCrLf &
        "4. Delete action are unrevertable.",
        "Delete Help",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class