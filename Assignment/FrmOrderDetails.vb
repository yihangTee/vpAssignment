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
            Dim font As New Font("Consolas", 10)
            Dim boldFont As New Font("Consolas", 10, FontStyle.Bold)
            Dim titleFont As New Font("Consolas", 12, FontStyle.Bold)
            Dim italicFont As New Font("Consolas", 9, FontStyle.Italic)
            Dim brush As New SolidBrush(Color.Black)
            Dim grayBrush As New SolidBrush(Color.Gray)
            Dim y As Integer = 20
            Dim lineWidth As Integer = 280
            Dim leftX As Integer = 20

            Dim rightAlign = Function(text As String, totalWidth As Integer) As Integer
                                 Dim size = g.MeasureString(text, font)
                                 Return leftX + totalWidth - CInt(size.Width)
                             End Function

            g.DrawString("BL Fariz Restaurant", titleFont, brush, leftX + 30, y)
            y += 20
            g.DrawString("Tel: 011-1220 6233", font, brush, leftX + 50, y)
            y += 20
            g.DrawString("Table No: " & order.TableNo, font, brush, leftX + 30, y)
            y += 20

            g.DrawString(StrDup(36, "-"c), font, grayBrush, leftX, y)
            y += 20

            g.DrawString(Now.ToString("dd/MM/yyyy    hh:mm tt"), font, brush, leftX, y)
            y += 20

            g.DrawString(StrDup(36, "-"c), font, grayBrush, leftX, y)
            y += 20

            Dim orderTotal As Decimal = 0
            For Each item In orderedItems
                Dim itemLine As String = $"{item.Quantity}  {item.ItemName}"
                g.DrawString(itemLine, font, brush, leftX, y)
                g.DrawString("RM " & item.SubTotal.ToString("F2"), font, brush, rightAlign("RM " & item.SubTotal.ToString("F2"), lineWidth), y)
                orderTotal += item.SubTotal
                y += 20
            Next

            g.DrawString(StrDup(36, "-"c), font, grayBrush, leftX, y)
            y += 20

            Dim tax As Decimal = orderTotal * 0.1D
            Dim totalPay As Decimal = orderTotal + tax

            g.DrawString("SUB-TOTAL", boldFont, brush, leftX, y)
            g.DrawString("RM " & orderTotal.ToString("F2"), boldFont, brush, rightAlign("RM " & orderTotal.ToString("F2"), lineWidth), y)
            y += 20

            g.DrawString("TAX (10%)", boldFont, brush, leftX, y)
            g.DrawString("RM " & tax.ToString("F2"), boldFont, brush, rightAlign("RM " & tax.ToString("F2"), lineWidth), y)
            y += 20

            g.DrawString("TOTAL DUE", titleFont, brush, leftX, y)
            g.DrawString("RM " & totalPay.ToString("F2"), titleFont, brush, rightAlign("RM " & totalPay.ToString("F2"), lineWidth), y)
            y += 30

            g.DrawString("Thank you for dining!", italicFont, brush, leftX + 40, y)
            y += 20
            g.DrawString("Please come again.", italicFont, brush, leftX + 50, y)
        End Using
    End Sub

End Class
