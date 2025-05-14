Public Class FrmOrderDetails
    Private orderID As String
    Private tableNo As String

    Public Sub New(orderID As String, tableNo As String)
        InitializeComponent()
        Me.orderID = orderID
        Me.tableNo = tableNo
    End Sub

    Private Sub FrmOrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using db As New BL_farizDataContext()
            Dim orderedItems = From oi In db.Order_Items
                               Join i In db.Items On oi.Item_Id Equals i.Item_Id
                               Where oi.OrderID = orderID
                               Select New With {
                                   .ItemName = i.Item_Name,
                                   .ItemPrice = i.Item_Price,
                                   .Quantity = oi.Quantity,
                                   .SubTotal = oi.SubTotal
                               }

            dgvOrderedItems.DataSource = orderedItems.ToList()

            Dim orderDetails = From o In db.Orders
                               Where o.OrderID = orderID
                               Select o.TotalAmount, o.TableNo, o.OrderDateTime, o.StaffID

            Dim order = orderDetails.FirstOrDefault()
            If order IsNot Nothing Then
                lblTotalAmount.Text = $"RM {order.TotalAmount:F2}"
                lblOrderDate.Text = $"{order.OrderDateTime.ToString("yyyy-MM-dd HH:mm")}"
                lblTableNo.Text = $"{order.TableNo}"
            End If
        End Using

        With dgvOrderedItems
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnReprintReceipt_Click(sender As Object, e As EventArgs) Handles btnReprintReceipt.Click
        receiptPreviewDialog.Document = reprintReceipt
        receiptPreviewDialog.ShowDialog(Me)
    End Sub

    Private Sub getOrderItemDetails()
        Using db As New BL_farizDataContext()
            Dim orderedItems = From oi In db.Order_Items
                               Join i In db.Items On oi.Item_Id Equals i.Item_Id
                               Where oi.OrderID = orderID
                               Select New With {
                                   .ItemName = i.Item_Name,
                                   .ItemPrice = i.Item_Price,
                                   .Quantity = oi.Quantity,
                                   .SubTotal = oi.SubTotal
                               }

            dgvOrderedItems.DataSource = orderedItems.ToList()

            Dim orderDetails = From o In db.Orders
                               Where o.OrderID = orderID
                               Select o.TotalAmount, o.TableNo, o.OrderDateTime, o.StaffID

            Dim order = orderDetails.FirstOrDefault()
        End Using
    End Sub

    Private Sub reprintReceipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles reprintReceipt.PrintPage
        Using db As New BL_farizDataContext()
            Dim orderedItems = (From oi In db.Order_Items
                                Join i In db.Items On oi.Item_Id Equals i.Item_Id
                                Where oi.OrderID = orderID
                                Select New With {
                                    .ItemName = i.Item_Name,
                                    .ItemPrice = i.Item_Price,
                                    .Quantity = oi.Quantity,
                                    .SubTotal = oi.SubTotal
                                }).ToList()

            Dim order = (From o In db.Orders
                         Where o.OrderID = orderID
                         Select o.TotalAmount, o.TableNo).FirstOrDefault()

            If order Is Nothing Then Exit Sub

            Dim g As Graphics = e.Graphics
            Dim font As New Font("Segoe UI", 10)
            Dim boldFont As New Font("Segoe UI", 10, FontStyle.Bold)
            Dim titleFont As New Font("Segoe UI", 14, FontStyle.Bold)
            Dim brush As New SolidBrush(Color.Black)
            Dim y As Integer = 40

            g.DrawString("BL Fariz Restaurant", titleFont, brush, 100, y)
            y += 40

            g.DrawString("Table No: " & order.TableNo, font, brush, 50, y)
            y += 30

            g.DrawString("No", boldFont, brush, 50, y)
            g.DrawString("Item Name", boldFont, brush, 100, y)
            g.DrawString("Qty", boldFont, brush, 300, y)
            g.DrawString("Price", boldFont, brush, 360, y)
            y += 20

            Dim index As Integer = 1
            Dim orderTotal As Decimal = 0

            For Each item In orderedItems
                g.DrawString(index.ToString(), font, brush, 50, y)
                g.DrawString(item.ItemName, font, brush, 100, y)
                g.DrawString(item.Quantity.ToString(), font, brush, 300, y)
                g.DrawString("RM " & item.SubTotal.ToString("F2"), font, brush, 360, y)

                orderTotal += item.SubTotal
                index += 1
                y += 20
            Next

            y += 10
            g.DrawString("Total Items: " & (index - 1).ToString(), font, brush, 50, y)

            y += 30
            Dim tax As Decimal = orderTotal * 0.1D
            Dim totalPay As Decimal = orderTotal + tax

            g.DrawString("Subtotal: RM " & orderTotal.ToString("F2"), boldFont, brush, 260, y)
            y += 20
            g.DrawString("Tax (10%): RM " & tax.ToString("F2"), boldFont, brush, 260, y)
            y += 20
            g.DrawString("Total: RM " & totalPay.ToString("F2"), titleFont, brush, 260, y)
            y += 40

            g.DrawString("Thank you for dining with us!", New Font("Segoe UI", 9, FontStyle.Italic), Brushes.Gray, 50, y)
        End Using
    End Sub
End Class
