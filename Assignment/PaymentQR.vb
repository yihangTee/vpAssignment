Imports AForge.Video
Imports AForge.Video.DirectShow
Public Class PaymentQR
    Private videoDevices As FilterInfoCollection
    Private videoSource As VideoCaptureDevice
    Public Property SelectedTableNo As String
    Public Property ParentPaymentForm As Form
    Public pendingItemsList As List(Of OrderItemDetail)
    Private WithEvents receiptPrintDoc As New Printing.PrintDocument()

    Private Sub PaymentQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPendingItems()
    End Sub
    Private Sub LoadPendingItems()
        Dim db As New BL_farizDataContext()

        pendingItemsList = (From o In db.Orders
                            Join p In db.Payments On o.OrderID Equals p.OrderID
                            Join oi In db.Order_Items On o.OrderID Equals oi.OrderID
                            Join i In db.Items On oi.Item_Id Equals i.Item_Id
                            Where o.TableNo = SelectedTableNo AndAlso p.PaymentStatus = "Pending"
                            Select New OrderItemDetail With {
                            .OrderID = o.OrderID,
                            .ItemName = i.Item_Name,
                            .ItemPrice = i.Item_Price,
                            .Quantity = oi.Quantity,
                            .SubTotal = oi.SubTotal
                        }).ToList()
    End Sub
    Private Sub btnIScanYou_Click(sender As Object, e As EventArgs) Handles btnIScanYou.Click
        Try
            ' Show camera panel, hide QR image panel
            panelCamera.Visible = True
            picQR.Visible = False

            videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
            If videoDevices.Count > 0 Then
                videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)
                AddHandler videoSource.NewFrame, AddressOf videoSource_NewFrame
                videoSource.Start()
            Else
                MessageBox.Show("No camera found.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub videoSource_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        Dim bitmap As Bitmap = CType(eventArgs.Frame.Clone(), Bitmap)
        If picCamera.InvokeRequired Then
            picCamera.Invoke(Sub()
                                 picCamera.Image = bitmap
                                 picCamera.SizeMode = PictureBoxSizeMode.StretchImage
                             End Sub)
        Else
            picCamera.Image = bitmap
            picCamera.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btnYouScanMe_Click(sender As Object, e As EventArgs) Handles btnScanMe.Click
        ' Stop camera if it was running
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
        End If

        ' Show QR image panel, hide camera panel
        panelCamera.Visible = False
        picQR.Visible = True
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
        End If
        If ParentPaymentForm IsNot Nothing Then
            ParentPaymentForm.Show()
        End If

        Me.Close()
    End Sub

    Private Sub PaymentQR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim confirmResult = MessageBox.Show("Are you sure you want to complete the payment?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim db As New BL_farizDataContext()
        If confirmResult = DialogResult.Yes Then
            Try
                Dim matchingPayments = From o In db.Orders
                                       Join p In db.Payments On o.OrderID Equals p.OrderID
                                       Where o.TableNo = SelectedTableNo AndAlso p.PaymentStatus = "Pending"
                                       Select p

                If matchingPayments.Any() Then
                    For Each pay In matchingPayments
                        pay.PaymentMethod = "QR"
                        pay.PaymentStatus = "Success"
                        pay.DateTime = DateTime.Now
                    Next

                    db.SubmitChanges()
                    MessageBox.Show("Payment Success.", "Payment Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim tableRecord = db.TableNos.FirstOrDefault(Function(t) t.Name = SelectedTableNo)

                    If tableRecord IsNot Nothing Then
                        tableRecord.Color = Color.LightGreen.ToArgb()
                        db.SubmitChanges()
                    End If

                    For Each ctrl As Control In FrmTable.pnlTables.Controls
                        If TypeOf ctrl Is Button AndAlso ctrl.Text = SelectedTableNo Then
                            ctrl.BackColor = Color.LightGreen
                            Exit For
                        End If
                    Next
                    GenerateReceipt()
                    Me.Tag = "Paid" ' Set Tag to indicate success
                    Me.Close()
                Else
                    MessageBox.Show("No matching payment found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error while updating payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' User clicked No, do nothing
            MessageBox.Show("Payment cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub GenerateReceipt()
        If pendingItemsList Is Nothing OrElse pendingItemsList.Count = 0 Then
            MessageBox.Show("No items to print. Please load the pending order first.")
            Exit Sub
        End If

        Dim preview As New PrintPreviewDialog()
        preview.Document = receiptPrintDoc
        preview.Width = 800
        preview.Height = 600
        preview.ShowDialog()
    End Sub

    Private Sub receiptPrintDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles receiptPrintDoc.PrintPage
        Dim g As Graphics = e.Graphics
        Dim font As New Font("Segoe UI", 10)
        Dim boldFont As New Font("Segoe UI", 10, FontStyle.Bold)
        Dim titleFont As New Font("Segoe UI", 14, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.Black)
        Dim y As Integer = 40

        ' Header
        g.DrawString("BL Fariz Restaurant", titleFont, brush, 100, y)
        y += 40

        g.DrawString("Table No: " & SelectedTableNo, font, brush, 50, y)
        y += 30

        ' Table headers
        g.DrawString("No", boldFont, brush, 50, y)
        g.DrawString("Item Name", boldFont, brush, 100, y)
        g.DrawString("Qty", boldFont, brush, 300, y)
        g.DrawString("Price", boldFont, brush, 360, y)
        y += 20

        ' Print each item from pendingItemsList
        Dim index As Integer = 1
        Dim orderTotal As Decimal = 0

        For Each item In pendingItemsList
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
    End Sub

End Class