Public Class frmTrackItem
    Private Sub frmTrackItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideControls()
        ClearFields()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub cboTrackAspect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTrackAspect.SelectedIndexChanged
        'Reset all controls to not visible
        HideControls()

        If cboTrackAspect.SelectedItem Is Nothing Then
            Exit Sub
        End If

        If cboTrackAspect.SelectedItem.ToString() = "Item ID" Then
            lblTrackID.Visible = True
            mskTrackID.Visible = True
        ElseIf cboTrackAspect.SelectedItem.ToString() = "Name" Then
            lblTrackName.Visible = True
            txtTrackName.Visible = True
        ElseIf cboTrackAspect.SelectedItem.ToString() = "Category" Then
            lblTrackCategory.Visible = True
            cboTrackCategory.Visible = True
        ElseIf cboTrackAspect.SelectedItem.ToString() = "Stock Level" Then
            lblTrackStockLvl.Visible = True
            cboTrackStockLvl.Visible = True
        End If

        'Enable the search button when any of the fields are filled
        'Show the search and clear buttons
        btnTrackSearch.Visible = True
        btnTrackClear.Visible = True
    End Sub

    Private Sub btnTrackSearch_Click(sender As Object, e As EventArgs) Handles btnTrackSearch.Click, SearchToolStripMenuItem.Click
        Dim isValid As Boolean = True

        Select Case cboTrackAspect.SelectedItem?.ToString()
            Case "Item ID"
                If String.IsNullOrWhiteSpace(mskTrackID.Text) Then
                    MessageBox.Show("Please enter an Item ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    isValid = False
                End If

            Case "Name"
                If String.IsNullOrWhiteSpace(txtTrackName.Text) Then
                    MessageBox.Show("Please enter the item name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    isValid = False
                End If

            Case "Category"
                If cboTrackCategory.SelectedIndex = -1 Then
                    MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    isValid = False
                End If

            Case "Stock Level"
                If cboTrackStockLvl.SelectedIndex = -1 Then
                    MessageBox.Show("Please select a stock level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    isValid = False
                End If

            Case Else
                MessageBox.Show("Please select a tracking aspect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                isValid = False
        End Select

        If isValid Then
            ' If all is good, show the item details/item list details form
            Dim filteredItems As IEnumerable(Of Item) = Nothing

            Select Case cboTrackAspect.SelectedItem.ToString()
                Case "Item ID"
                    Dim item = idb.Items.FirstOrDefault(Function(i) i.Item_Id = mskTrackID.Text.Trim())
                    If item IsNot Nothing Then
                        Dim detailsForm As New frmItemDetails(item)
                        detailsForm.ShowDialog()
                    Else
                        MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Case "Name"
                    Dim item = idb.Items.FirstOrDefault(Function(i) i.Item_Name.ToLower() = txtTrackName.Text.Trim().ToLower())
                    If item IsNot Nothing Then
                        Dim detailsForm As New frmItemDetails(item)
                        detailsForm.ShowDialog()
                    Else
                        MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Case "Category"
                    filteredItems = idb.Items.Where(Function(i) i.Item_Category = cboTrackCategory.SelectedItem.ToString())
                    If filteredItems.Any() Then
                        Dim listForm As New frmItemListDetails(filteredItems.ToList())
                        listForm.ShowDialog()
                    Else
                        MessageBox.Show("No items found for this category.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Case "Stock Level"
                    filteredItems = idb.Items.Where(Function(i) i.Item_StockLvl = cboTrackStockLvl.SelectedItem.ToString())
                    If filteredItems.Any() Then
                        Dim listForm As New frmItemListDetails(filteredItems.ToList())
                        listForm.ShowDialog()
                    Else
                        MessageBox.Show("No items found for this stock level.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnTrackClear.Click, ClearToolStripMenuItem.Click
        ClearFields()
    End Sub

    Private Sub mskTrackID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mskTrackID.Validating
        If String.IsNullOrWhiteSpace(mskTrackID.Text) Then
            errTrackItem.SetError(mskTrackID, "Please Enter a Valid ID")
        Else
            errTrackItem.SetError(mskTrackID, "")
        End If
    End Sub

    Private Sub HideControls()
        ' Hide all controls
        lblTrackID.Visible = False
        mskTrackID.Visible = False
        lblTrackName.Visible = False
        txtTrackName.Visible = False
        lblTrackCategory.Visible = False
        cboTrackCategory.Visible = False
        lblTrackStockLvl.Visible = False
        cboTrackStockLvl.Visible = False
        btnTrackSearch.Visible = False
        btnTrackClear.Visible = False
    End Sub

    Private Sub ClearFields()
        mskTrackID.Clear()
        txtTrackName.Clear()
        cboTrackCategory.SelectedIndex = -1
        cboTrackStockLvl.SelectedIndex = -1
        cboTrackAspect.SelectedIndex = -1
    End Sub

    Private Sub FieldGuidelineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldGuidelineToolStripMenuItem.Click
        MessageBox.Show(
        "TRACKING TIPS:" & vbCrLf & vbCrLf &
        "• Choose ONE of the Aspect from the dropdown" & vbCrLf &
        "• Fill in the necessary information (e.g ID/Name)" & vbCrLf &
        "   OR" & vbCrLf &
        "• Select from the dropdown (e.g Category/Stock Level)" & vbCrLf &
        "• Press Search button will direct to either Item Details/Item List Details",
        "Track Help",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class