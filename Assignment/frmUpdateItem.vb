Imports System.Data.Linq

Public Class frmUpdateItem
    ' Store the original item for reset
    Private originalItem As Item
    Private originalImage As Image

    Private Sub frmUpdateItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnSnapPicture_Click(sender As Object, e As EventArgs) Handles btnSnapPicture.Click, TakePictureToolStripMenuItem.Click
        Dim frmSnapItemPicture As frmSnapItemPicture = New frmSnapItemPicture(AddressOf ShowImage)
        frmSnapItemPicture.ShowDialog()
    End Sub

    Private Sub ShowImage(ByVal image As Image)
        picUpdateItemPicture.Image = image
    End Sub

    Private Sub btnUploadPicture_Click(sender As Object, e As EventArgs) Handles btnUploadPicture.Click, UploadImageToolStripMenuItem.Click
        Using ofd As New OpenFileDialog
            ofd.Title = "Select An Image"
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

            If ofd.ShowDialog() = DialogResult.OK Then
                'picUpdateItemPicture.Image = Image.FromFile(ofd.FileName)
                picUpdateItemPicture.Image = New Bitmap(ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub btnDeletePicture_Click(sender As Object, e As EventArgs) Handles btnDeletePicture.Click, RemoveImageToolStripMenuItem.Click
        picUpdateItemPicture.Image = Nothing
        If originalItem IsNot Nothing Then
            originalItem.Item_Picture = Nothing
        End If
    End Sub

    Private Sub btnUpdateSearch_Click(sender As Object, e As EventArgs) Handles btnUpdateSearch.Click, SearchToolStripMenuItem.Click
        If mskSearchUpdateItemId.Text.Trim() = "" Then
            MessageBox.Show("Please enter an Item ID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mskSearchUpdateItemId.Focus()
            Exit Sub
        End If

        Dim item = idb.Items.FirstOrDefault(Function(i) i.Item_Id = mskSearchUpdateItemId.Text.Trim())

        If item Is Nothing Then
            MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mskSearchUpdateItemId.Focus()
            Exit Sub
        End If

        ' Load item info
        mskUpdateItemID.Text = item.Item_Id
        txtUpdateItemName.Text = item.Item_Name
        txtUpdateItemDescription.Text = item.Item_Description
        cboUpdateItemCategory.Text = item.Item_Category
        txtUpdateItemPrice.Text = item.Item_Price.ToString()
        Select Case item.Item_Quantity
            Case 50
                radUpdateHighStock.Checked = True
                txtUpdateCustomStock.Text = ""
            Case 30
                radUpdateMediumStock.Checked = True
                txtUpdateCustomStock.Text = ""
            Case 10
                radUpdateLowStock.Checked = True
                txtUpdateCustomStock.Text = ""
            Case Else
                radUpdateCustomStock.Checked = True
                txtUpdateCustomStock.Text = item.Item_Quantity.ToString()
        End Select

        picUpdateItemPicture.Image = If(item.Item_Picture IsNot Nothing, ByteArrayToImage(item.Item_Picture.ToArray()), Nothing)

        originalItem = item

        originalImage = picUpdateItemPicture.Image

        ToggleControls(True)
    End Sub

    Private Function ByteArrayToImage(byteArray As Byte()) As Image
        If byteArray Is Nothing OrElse byteArray.Length = 0 Then Return Nothing
        Using ms As New IO.MemoryStream(byteArray)
            Return Image.FromStream(ms)
        End Using
    End Function

    Private Sub btnUpdateClear_Click(sender As Object, e As EventArgs) Handles btnUpdateClear.Click, ClearToolStripMenuItem.Click, ClearAllToolStripMenuItem.Click
        ResetForm()
    End Sub

    Private Sub btnUpdateItemInfo_Click(sender As Object, e As EventArgs) Handles btnUpdateItemInfo.Click
        If originalItem Is Nothing Then Exit Sub

        Try
            ' Validate fields
            Dim price As Decimal
            Dim stocklvl As String
            Dim quantity As Integer

            If radUpdateHighStock.Checked Then
                quantity = 50
                stocklvl = "High"
            ElseIf radUpdateMediumStock.Checked Then
                quantity = 30
                stocklvl = "Medium"
            ElseIf radUpdateLowStock.Checked Then
                quantity = 10
                stocklvl = "Low"
            ElseIf radUpdateCustomStock.Checked Then
                If txtUpdateCustomStock.Text = "" Then
                    MessageBox.Show("Please enter a quantity for 'Others'.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtUpdateCustomStock.Focus()
                    Exit Sub
                End If

                If Not Integer.TryParse(txtUpdateCustomStock.Text.Trim(), quantity) OrElse quantity < 0 Then
                    MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtUpdateCustomStock.Focus()
                    Exit Sub
                End If

                If quantity > 50 Then
                    stocklvl = "High"
                ElseIf quantity >= 10 And quantity <= 49 Then
                    stocklvl = "Medium"
                Else
                    stocklvl = "Low"
                End If
            End If

            If Not Decimal.TryParse(txtUpdateItemPrice.Text.Trim(), price) OrElse price < 0 Then
                MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUpdateItemPrice.Focus()
                Exit Sub
            End If

            ' Update fields
            originalItem.Item_Id = mskUpdateItemID.Text.Trim()
            originalItem.Item_Name = txtUpdateItemName.Text.Trim()
            originalItem.Item_Description = txtUpdateItemDescription.Text.Trim()
            originalItem.Item_Category = cboUpdateItemCategory.Text.Trim()
            originalItem.Item_Price = price
            originalItem.Item_Quantity = quantity
            originalItem.Item_StockLvl = stocklvl

            If picUpdateItemPicture.Image IsNot Nothing Then
                Using ms As New IO.MemoryStream()
                    Dim cloneImage As New Bitmap(picUpdateItemPicture.Image)
                    cloneImage.Save(ms, Imaging.ImageFormat.Jpeg)
                    originalItem.Item_Picture = ms.ToArray()
                End Using
            Else
                originalItem.Item_Picture = Nothing
            End If

            ' Check that Item ID matches selected category prefix
            Dim itemId As String = mskUpdateItemID.Text.Trim().ToUpper()
            Dim category As String = cboUpdateItemCategory.Text.Trim()
            Dim expectedPrefix As String = ""

            Select Case category
                Case "Roti Canai (RC)" : expectedPrefix = "RC"
                Case "Main Dish (MD)" : expectedPrefix = "MD"
                Case "Side Dish (SD)" : expectedPrefix = "SD"
                Case "Hot Drink (HD)" : expectedPrefix = "HD"
                Case "Cold Drink (CD)" : expectedPrefix = "CD"
                Case Else
                    MessageBox.Show("Please select a valid category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cboUpdateItemCategory.Focus()
                    Exit Sub
            End Select

            If String.IsNullOrWhiteSpace(itemId) OrElse Not itemId.StartsWith(expectedPrefix) Then
                MessageBox.Show($"Item ID must start with '{expectedPrefix}' based on the selected category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                mskUpdateItemID.Focus()
                Exit Sub
            End If

            Dim suffix As String = itemId.Substring(expectedPrefix.Length)
            If suffix.Length <> 5 OrElse Not IsNumeric(suffix) Then
                MessageBox.Show("Item ID format must be '" & expectedPrefix & "00000'.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                mskUpdateItemID.Focus()
                Exit Sub
            End If

            idb.SubmitChanges()
            MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelUpdateItemInfo_Click(sender As Object, e As EventArgs) Handles btnCancelUpdateItemInfo.Click
        If originalItem Is Nothing Then Exit Sub

        mskUpdateItemID.Text = originalItem.Item_Id
        txtUpdateItemName.Text = originalItem.Item_Name
        txtUpdateItemDescription.Text = originalItem.Item_Description
        cboUpdateItemCategory.Text = originalItem.Item_Category
        txtUpdateItemPrice.Text = originalItem.Item_Price.ToString()
        Select Case originalItem.Item_Quantity
            Case 50
                radUpdateHighStock.Checked = True
                txtUpdateCustomStock.Text = ""
            Case 30
                radUpdateMediumStock.Checked = True
                txtUpdateCustomStock.Text = ""
            Case 10
                radUpdateLowStock.Checked = True
                txtUpdateCustomStock.Text = ""
            Case Else
                radUpdateCustomStock.Checked = True
                txtUpdateCustomStock.Text = originalItem.Item_Quantity.ToString()
        End Select
        picUpdateItemPicture.Image = originalImage
    End Sub

    Private Sub mskSearchUpdateItemID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskSearchUpdateItemId.Validating
        If String.IsNullOrWhiteSpace(mskSearchUpdateItemId.Text) Then
            ErrorProvider1.SetError(mskSearchUpdateItemId, "Please Enter a Valid ID")
        Else
            ErrorProvider1.SetError(mskSearchUpdateItemId, "")
        End If
    End Sub

    Private Sub mskUpdateItemID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskUpdateItemID.Validating
        If String.IsNullOrWhiteSpace(mskUpdateItemID.Text) Then
            ErrorProvider1.SetError(mskUpdateItemID, "Please Enter a Valid ID")
        Else
            ErrorProvider1.SetError(mskUpdateItemID, "")
        End If
    End Sub

    Private Sub txtUpdateItemPrice_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUpdateItemPrice.Validating
        Dim price As Decimal
        If Not Decimal.TryParse(txtUpdateItemPrice.Text, price) OrElse price < 0 Then
            ErrorProvider1.SetError(txtUpdateItemPrice, "Enter a valid price. (e.g. 99.99)")
        Else
            ErrorProvider1.SetError(txtUpdateItemPrice, "")
        End If
    End Sub

    Private Sub ToggleControls(state As Boolean)
        mskUpdateItemID.ReadOnly = Not state
        txtUpdateItemName.ReadOnly = Not state
        txtUpdateItemDescription.ReadOnly = Not state
        cboUpdateItemCategory.Enabled = state
        txtUpdateItemPrice.ReadOnly = Not state
        txtUpdateCustomStock.ReadOnly = Not state
        btnUpdateItemInfo.Enabled = state
        btnCancelUpdateItemInfo.Enabled = state
        btnUploadPicture.Enabled = state
        btnSnapPicture.Enabled = state
        btnDeletePicture.Enabled = state
        radUpdateCustomStock.Enabled = state
        radUpdateHighStock.Enabled = state
        radUpdateMediumStock.Enabled = state
        radUpdateLowStock.Enabled = state
    End Sub

    Private Sub ResetForm()
        mskSearchUpdateItemId.Clear()
        mskSearchUpdateItemId.Focus()
        picUpdateItemPicture.Image = Nothing
        mskUpdateItemID.Clear()
        txtUpdateItemName.Clear()
        txtUpdateItemDescription.Clear()
        cboUpdateItemCategory.SelectedIndex = -1
        txtUpdateItemPrice.Clear()
        radUpdateCustomStock.Checked = False
        radUpdateHighStock.Checked = False
        radUpdateLowStock.Checked = False
        radUpdateMediumStock.Checked = False
        txtUpdateCustomStock.Clear()
        ToggleControls(False)
        originalItem = Nothing
    End Sub

    Private Sub FieldGuidelineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldGuidelineToolStripMenuItem.Click
        MessageBox.Show(
        "UPDATING ITEMS:" & vbCrLf & vbCrLf &
        "1. Item ID is modified togather with Category (e.g. Main Dish -> MD00001)" & vbCrLf &
        "2. Name, Price, Description, and Stock Level are required" & vbCrLf &
        "3. Image can re-upload/ re-snap/ remove" & vbCrLf &
        "4. Changes save after the Update button press" & vbCrLf &
        "5. Press Cancel button to recall edits",
        "Update Help",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub radUpdateHighStock_CheckedChanged(sender As Object, e As EventArgs) Handles radUpdateHighStock.CheckedChanged, radUpdateLowStock.CheckedChanged, radUpdateMediumStock.CheckedChanged, radUpdateCustomStock.CheckedChanged
        If radUpdateCustomStock.Checked Then
            txtUpdateCustomStock.Enabled = True
            txtUpdateCustomStock.Focus()
        Else
            txtUpdateCustomStock.Enabled = False
            txtUpdateCustomStock.Clear()
        End If
    End Sub
End Class