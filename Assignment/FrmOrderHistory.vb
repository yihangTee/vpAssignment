Public Class FrmOrderHistory
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim selectedDate As Date = dtpHistoryDate.Value.Date

        Using db As New BL_farizDataContext()
            Dim results = From o In db.Orders
                          Where o.OrderDateTime.Date = selectedDate
                          Join oi In db.Order_Items On o.OrderID Equals oi.OrderID
                          Join s In db.Staffs On o.StaffID Equals s.StaffID
                          Join i In db.Items On oi.Item_Id Equals i.Item_Id
                          Select New With {
                              .OrderID = o.OrderID,
                              .StaffID = s.StaffID,
                              .StaffName = s.FirstName & " " & s.LastName,
                              .TableNo = o.TableNo,
                              .OrderDateTime = o.OrderDateTime,
                              .TotalAmount = o.TotalAmount
                          }
            dgvOrderHistory.DataSource = results.ToList()
            lblRecordCount.Text = $"{results.Count} record (s)"
        End Using

        With dgvOrderHistory
            .DefaultCellStyle.ForeColor = Color.DarkSlateBlue
            .DefaultCellStyle.BackColor = Color.AliceBlue
            .DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender

            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

            .EnableHeadersVisualStyles = False
        End With
    End Sub

    Private Sub dtpHistoryDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpHistoryDate.ValueChanged
        btnSearch_Click(Nothing, Nothing)
    End Sub

    Private Sub dgvOrderHistory_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderHistory.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedOrderID As String = dgvOrderHistory.Rows(e.RowIndex).Cells("OrderID").Value.ToString()

            Dim frmOrderDetails As New FrmOrderDetails(selectedOrderID, dgvOrderHistory.Rows(e.RowIndex).Cells("TableNo").Value.ToString())
            frmOrderDetails.ShowDialog()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        FrmOrder_Payment.Show()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        dgvOrderHistory.DataSource = Nothing
    End Sub

    Private Sub FieldGuidelineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldGuidelineToolStripMenuItem.Click
        MessageBox.Show(
        "ORDER HISTORY SAFEGUARDS:" & vbCrLf & vbCrLf &
        "1. Generate order history by chosen date." & vbCrLf &
        "2. Double click to view details and reprint receipt",
        "Order History Help",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class