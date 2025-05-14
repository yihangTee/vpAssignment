Imports System.Linq

Public Class frmAddItem
    Private categoryCode As String

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnSnapPicture_Click(sender As Object, e As EventArgs) Handles btnSnapPicture.Click, SnapPictureToolStripMenuItem.Click, TakePictureToolStripMenuItem.Click
        Dim frmSnapItemPicture As frmSnapItemPicture = New frmSnapItemPicture(AddressOf ShowImage)
        frmSnapItemPicture.ShowDialog()
    End Sub

    Private Sub ShowImage(ByVal image As Image)
        picAddItemPicture.Image = image
    End Sub

    Private Sub btnUploadPicture_Click(sender As Object, e As EventArgs) Handles btnUploadPicture.Click, UploadImageToolStripMenuItem.Click
        Using ofd As New OpenFileDialog
            ofd.Title = "Select An Image"
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

            If ofd.ShowDialog() = DialogResult.OK Then
                picAddItemPicture.Image = Image.FromFile(ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub radAddCustomStock_CheckedChanged(sender As Object, e As EventArgs) Handles radAddCustomStock.CheckedChanged
        If radAddCustomStock.Checked Then
            txtAddCustomStock.Enabled = True
            txtAddCustomStock.ReadOnly = False 'important
        Else
            txtAddCustomStock.Enabled = False
        End If
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click, SaveToolStripMenuItem.Click
        Try
            Dim stocklevel As String = ""
            Dim quantity As Integer = 0

            'Determine quantity and stock level
            If radAddHighStock.Checked Then
                quantity = 50
                stocklevel = "High"
            ElseIf radAddMediumStock.Checked Then
                quantity = 30
                stocklevel = "Medium"
            ElseIf radAddLowStock.Checked Then
                quantity = 10
                stocklevel = "Low"
            ElseIf radAddCustomStock.Checked Then
                If txtAddCustomStock.Text = "" Then
                    MessageBox.Show("Please enter a quantity for 'Others'.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtAddCustomStock.Focus()
                    Exit Sub
                End If

                'Use .trim() to remove any leading/trailing spaces
                If Not Integer.TryParse(txtAddCustomStock.Text.Trim(), quantity) Then
                    MessageBox.Show("Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtAddCustomStock.Focus()
                    Exit Sub
                End If

                If quantity < 0 Then
                    MessageBox.Show("Quantity cannot be negative.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtAddCustomStock.Focus()
                    Exit Sub
                End If

                If quantity > 50 Then
                    stocklevel = "High"
                ElseIf quantity >= 10 And quantity <= 49 Then
                    stocklevel = "Medium"
                Else
                    stocklevel = "Low"
                End If
            Else
                MessageBox.Show("Please select a Stock Level option.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'Validate other text inputs
            If mskAddItemID.Text = "" Or txtAddItemName.Text.Trim() = "" Or txtAddItemDescription.Text.Trim() = "" Or txtAddItemPrice.Text.Trim() = "" Then
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim price As Decimal
            If Not Decimal.TryParse(txtAddItemPrice.Text.Trim(), price) Then
                MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAddItemPrice.Focus()
                Exit Sub
            End If

            If price < 0 Then
                MessageBox.Show("Price cannot be negative.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAddItemPrice.Focus()
                Exit Sub
            End If

            If cboAddItemCategory.SelectedIndex = -1 Then
                MessageBox.Show("Please select a Category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'Get the image bytes
            Dim imgbytes() As Byte = Nothing
            If picAddItemPicture.Image IsNot Nothing Then
                Using ms As New IO.MemoryStream()
                    picAddItemPicture.Image.Save(ms, Imaging.ImageFormat.Jpeg)
                    imgbytes = ms.ToArray()
                End Using
            End If

            'Create new item object
            Dim newItem As New Item() With {
                .Item_Id = mskAddItemID.Text.ToUpper(),
                .Item_Name = txtAddItemName.Text,
                .Item_Description = txtAddItemDescription.Text,
                .Item_Category = cboAddItemCategory.Text,
                .Item_Price = price,
                .Item_StockLvl = stocklevel,
                .Item_Quantity = quantity,
                .Item_Picture = imgbytes
            }

            ' Check that Item ID matches selected category prefix
            Dim itemId As String = mskAddItemID.Text.Trim().ToUpper()
            Dim category As String = cboAddItemCategory.Text.Trim()
            Dim expectedPrefix As String = ""

            Select Case category
                Case "Roti Canai (RC)" : expectedPrefix = "RC"
                Case "Main Dish (MD)" : expectedPrefix = "MD"
                Case "Side Dish (SD)" : expectedPrefix = "SD"
                Case "Hot Drink (HD)" : expectedPrefix = "HD"
                Case "Cold Drink (CD)" : expectedPrefix = "CD"
                Case Else
                    MessageBox.Show("Please select a valid category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cboAddItemCategory.Focus()
                    Exit Sub
            End Select

            If String.IsNullOrWhiteSpace(itemId) OrElse Not itemId.StartsWith(expectedPrefix) Then
                MessageBox.Show($"Item ID must start with '{expectedPrefix}' based on the selected category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                mskAddItemID.Focus()
                Exit Sub
            End If

            Dim suffix As String = itemId.Substring(expectedPrefix.Length)
            If suffix.Length <> 5 OrElse Not IsNumeric(suffix) Then
                MessageBox.Show("Item ID format must be '" & expectedPrefix & "00000'.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                mskAddItemID.Focus()
                Exit Sub
            End If

            Dim isDuplicated As Boolean = idb.Items.Any(Function(i) i.Item_Id = newItem.Item_Id)
            If isDuplicated Then
                MessageBox.Show("Item ID already exists. Please use a different ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                mskAddItemID.Clear()
                mskAddItemID.Focus()
            Else
                'Insert into Database & show success msg
                idb.Items.InsertOnSubmit(newItem)
                idb.SubmitChanges()

                MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Clear form
                ClearForm()
                cboAddItemCategory.Text = "Select a Category"
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearForm()
        picAddItemPicture.Image = Nothing
        mskAddItemID.Clear()
        txtAddItemName.Clear()
        txtAddItemDescription.Clear()
        cboAddItemCategory.SelectedIndex = -1
        txtAddItemPrice.Clear()
        radAddHighStock.Checked = True
        radAddMediumStock.Checked = False
        radAddLowStock.Checked = False
        radAddCustomStock.Checked = False
        txtAddCustomStock.Clear()
        cboAddItemCategory.Text = "Select a Category"
    End Sub

    Private Sub btnItemClear_Click(sender As Object, e As EventArgs) Handles btnItemClear.Click, ClearFormToolStripMenuItem.Click, ClearAllToolStripMenuItem.Click
        ClearForm()
        cboAddItemCategory.Text = "Select a Category"
    End Sub

    Private Sub mskAddItemID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskAddItemID.Validating
        If String.IsNullOrWhiteSpace(mskAddItemID.Text) Then
            ErrorProvider1.SetError(mskAddItemID, "Enter a valid ID (e.g. XX00000)")
        Else
            ErrorProvider1.SetError(mskAddItemID, "")
        End If
    End Sub

    Private Sub txtAddItemPrice_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAddItemPrice.Validating
        Dim price As Decimal
        If Not Decimal.TryParse(txtAddItemPrice.Text, price) OrElse price < 0 Then
            ErrorProvider1.SetError(txtAddItemPrice, "Enter a valid price. (e.g. 99.99)")
        Else
            ErrorProvider1.SetError(txtAddItemPrice, "")
        End If
    End Sub

    Private Sub FieldGuidelineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldGuidelineToolStripMenuItem.Click
        MessageBox.Show(
        "ADDING ITEMS GUIDE:" & vbCrLf & vbCrLf &
        "1. Item ID: Must be unique (e.g. XX00001)" & vbCrLf &
        "2. Item Name: Enter a descriptive name" & vbCrLf &
        "3. Item Category: Select from the dropdown" & vbCrLf &
        "4. Price: Enter numeric values only" & vbCrLf &
        "5. Item Description: Provide a brief description" & vbCrLf &
        "6. Stock Levels: High (>50), Medium (10-50), Low (<10)" & vbCrLf &
        "7. Click the Upload/Snap button to insert item images (Optional)",
        "Add Item Help",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class