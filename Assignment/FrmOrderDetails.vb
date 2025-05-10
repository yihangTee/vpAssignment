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
    End Sub
End Class
