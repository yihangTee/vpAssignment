Imports System.Data.Linq
Imports System.Data.SqlClient
Imports System.Text

Public Class FrmOrder
    Dim db As New BL_farizDataContext()
    Public Property SelectedTableNo As String

    Private Sub FrmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    Private Sub LoadCategories()
        Dim categories = (From i In db.Items
                          Select i.Item_Category
                          Distinct).ToList()

        cmbCategory.DataSource = categories
        cmbCategory.SelectedIndex = -1
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        If cmbCategory.SelectedIndex <> -1 Then
            LoadItemsByCategory(cmbCategory.SelectedItem.ToString())
        End If
    End Sub

    Private Sub LoadItemsByCategory(category As String)
        flpMenu.Controls.Clear()

        Dim items = From i In db.Items
                    Where i.Item_Category = category
                    Select i

        For Each item In items
            Dim itemPanel As New Panel
            With itemPanel
                .Width = 180
                .Height = 180
                .BorderStyle = BorderStyle.Fixed3D
                .Tag = item.Item_Id
            End With

            Dim picBox As New PictureBox
            With picBox
                .Width = 120
                .Height = 80
                .SizeMode = PictureBoxSizeMode.Zoom
                .Location = New Point(10, 5)
            End With

            Dim itemImg = item.Item_Picture

            If itemImg IsNot Nothing AndAlso itemImg.Length > 0 Then
                Try
                    Dim imgBytes As Byte() = itemImg.ToArray()
                    Using ms As New IO.MemoryStream(imgBytes)
                        picBox.Image = Image.FromStream(ms)
                    End Using
                Catch ex As Exception
                    picBox.Image = Nothing
                End Try
            Else
                picBox.Image = Nothing
            End If

            Dim lblName As New Label
            With lblName
                .Text = item.Item_Name
                .AutoSize = False
                .Width = 120
                .Height = 20
                .TextAlign = ContentAlignment.MiddleLeft
                .Location = New Point(10, picBox.Bottom + 5)
                .ForeColor = Color.White
                .Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
            End With

            Dim lblPrice As New Label
            With lblPrice
                .Text = "RM " & item.Item_Price.ToString("F2")
                .AutoSize = False
                .Width = 120
                .Height = 20
                .TextAlign = ContentAlignment.MiddleLeft
                .Location = New Point(10, lblName.Bottom)
                .ForeColor = Color.White
                .Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
            End With

            Dim btnAdd As New Button
            With btnAdd
                .Text = "Add"
                .Width = 60
                .Height = 30
                .Location = New Point(10, lblPrice.Bottom + 5)
                .BackColor = Color.LightSkyBlue
                .ForeColor = Color.DarkSlateBlue
                .Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
            End With

            AddHandler btnAdd.Click, Sub(s, e)
                                         AddToCart(item.Item_Id)
                                     End Sub

            itemPanel.Controls.Add(picBox)
            itemPanel.Controls.Add(lblName)
            itemPanel.Controls.Add(lblPrice)
            itemPanel.Controls.Add(btnAdd)

            flpMenu.Controls.Add(itemPanel)
        Next
    End Sub

    Private Function UpdateItemStockLevel(item As Item) As String
        Dim quantity = item.Item_Quantity
        Dim stocklvl As String

        If quantity >= 50 Then
            stocklvl = "High"
        ElseIf quantity > 10 AndAlso quantity <= 49 Then
            stocklvl = "Medium"
        Else
            stocklvl = "Low"
        End If

        Return stocklvl
    End Function

    Private Sub AddToCart(itemId As String)
        Dim item = db.Items.FirstOrDefault(Function(i) i.Item_Id = itemId)

        If item IsNot Nothing Then
            item.Item_StockLvl = UpdateItemStockLevel(item)
            db.SubmitChanges()

            If item.Item_Quantity <= 0 Then
                MessageBox.Show($"{item.Item_Name} is out of stock.", "Stock Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim existingPanel = GetCartPanel(itemId)

            If existingPanel IsNot Nothing Then
                Dim currentQty = GetCartItemQuantity(existingPanel)

                If (item.Item_StockLvl = "Low" And item.Item_Quantity - (currentQty + 1) > 0) Or
                    item.Item_Quantity - (currentQty + 1) < 10 Then
                    MessageBox.Show($"{item.Item_Name} stock is low ({item.Item_Quantity - (currentQty + 1)} left).",
                    "Low Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                If currentQty >= item.Item_Quantity Then
                    ShowStockWarning(item)
                    Return
                End If

                SetCartItemSummary(existingPanel, item, currentQty + 1)
            Else
                If item.Item_StockLvl = "Low" Then
                    MessageBox.Show($"{item.Item_Name} stock is low ({item.Item_Quantity - 1} left).",
                    "Low Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Dim newPanel = CreateCartPanel(item)
                flpCart.Controls.Add(newPanel)
            End If

            UpdateTotal()
        End If
    End Sub

    Private Function GetCartPanel(itemId As String) As Panel
        Return flpCart.Controls.OfType(Of Panel)().FirstOrDefault(Function(p) p.Tag.ToString() = itemId)
    End Function

    Private Sub UpdateItemQuantity(panel As Panel, item As Item, change As Integer)
        Dim currentQty = GetCartItemQuantity(panel)
        Dim newQty = currentQty + change

        If newQty < 1 Then Return

        SetCartItemSummary(panel, item, newQty)
        UpdateTotal()
    End Sub

    Private Function CreateCartPanel(item As Item) As Panel
        Dim panel As New Panel
        With panel
            .Width = 270
            .Height = 130
            .Tag = item.Item_Id
            .BorderStyle = BorderStyle.Fixed3D
            .BackColor = Color.White
        End With

        Dim lblSummary As New Label
        With lblSummary
            .Name = "lblSummary" & item.Item_Id
            .Text = $"{item.Item_Name} x 1 RM {item.Item_Price:F2}"
            .Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
            .ForeColor = Color.Black
            .Location = New Point(10, 10)
            .AutoSize = True
            .Tag = "1"
        End With

        Dim buttonY As Integer = lblSummary.Bottom + 10

        Dim btnIncrease As New Button
        With btnIncrease
            .Text = "+"
            .Size = New Size(30, 30)
            .Location = New Point(10, buttonY)
            .ForeColor = Color.Black
        End With
        AddHandler btnIncrease.Click, Sub(s, e) ModifyQuantity(item.Item_Id, 1)

        Dim btnDecrease As New Button
        With btnDecrease
            .Text = "-"
            .Size = New Size(30, 30)
            .Location = New Point(btnIncrease.Right + 5, buttonY)
            .ForeColor = Color.Black
        End With
        AddHandler btnDecrease.Click, Sub(s, e) ModifyQuantity(item.Item_Id, -1)

        Dim btnDelete As New Button
        With btnDelete
            .Text = "Delete"
            .Size = New Size(80, 30)
            .Location = New Point(btnDecrease.Right + 5, buttonY)
            .ForeColor = Color.Black
        End With
        AddHandler btnDelete.Click, Sub(s, e) DeleteItem(item.Item_Id)

        Dim txtNote As New TextBox
        With txtNote
            .Name = "txtNote_" & item.Item_Id
            .Text = ""
            .ForeColor = Color.Gray
            .Location = New Point(10, btnIncrease.Bottom + 10)
            .Width = 220
        End With

        panel.Controls.Add(lblSummary)
        panel.Controls.Add(btnIncrease)
        panel.Controls.Add(btnDecrease)
        panel.Controls.Add(btnDelete)
        panel.Controls.Add(txtNote)

        Return panel
    End Function

    Private Sub ModifyQuantity(itemId As String, change As Integer)
        Dim item = db.Items.FirstOrDefault(Function(i) i.Item_Id = itemId)

        If item IsNot Nothing Then
            Dim panel = GetCartPanel(itemId)
            If panel IsNot Nothing Then
                Dim currentQty = GetCartItemQuantity(panel)
                Dim newQty = currentQty + change

                If change > 0 AndAlso newQty > item.Item_Quantity Then
                    ShowStockWarning(item)
                    Return
                End If

                If newQty < 1 Then
                    flpCart.Controls.Remove(panel)
                Else
                    SetCartItemSummary(panel, item, newQty)
                End If

                UpdateTotal()
            End If
        End If
    End Sub

    Private Sub DeleteItem(itemId As String)
        Dim panel = GetCartPanel(itemId)
        If panel IsNot Nothing Then
            flpCart.Controls.Remove(panel)
            UpdateTotal()
        End If
    End Sub

    Private Sub UpdateTotal()
        Dim total As Decimal = 0

        For Each panel As Panel In flpCart.Controls
            For Each ctrl As Control In panel.Controls
                If TypeOf ctrl Is Label AndAlso ctrl.Name.StartsWith("lblSummary") Then
                    Dim parts = ctrl.Text.Split({"RM"}, StringSplitOptions.None)
                    If parts.Length = 2 Then
                        Dim priceText = parts(1).Trim()
                        Dim price As Decimal
                        If Decimal.TryParse(priceText, price) Then
                            total += price
                        End If
                    End If
                End If
            Next
        Next

        lblTotalAmount.Text = "RM " & total.ToString("F2")
    End Sub

    Private Function GenerateOrderID(ByVal db As BL_farizDataContext) As String
        Dim lastOrder = (From o In db.Orders
                         Order By o.OrderID Descending
                         Select o.OrderID).FirstOrDefault()

        If lastOrder IsNot Nothing AndAlso lastOrder.StartsWith("ORD") Then
            Dim num = Integer.Parse(lastOrder.Substring(3)) + 1
            Return "ORD" & num.ToString("D5")
        End If

        Return "ORD00001"
    End Function

    Private Function GeneratePaymentID(ByVal db As BL_farizDataContext) As String
        Dim lastpayment = (From p In db.Payments
                           Order By p.PaymentID Descending
                           Select p.PaymentID).FirstOrDefault()

        If lastpayment IsNot Nothing AndAlso lastpayment.StartsWith("PY") Then
            Dim num = Integer.Parse(lastpayment.Substring(3)) + 1
            Return "PY" & num.ToString("D5")
        End If

        Return "PY00001"
    End Function

    Private Sub btnSendOrder_Click(sender As Object, e As EventArgs) Handles btnSendOrder.Click
        If flpCart.Controls.Count = 0 Then
            MessageBox.Show("Cart is empty.")
            Return
        End If

        Dim orderID As String = GenerateOrderID(db)
        Dim username As String = FrmTable.lblName.Text.Trim()
        Dim staffId As String = GetStaffIdByName(username)
        Dim tableNo As String = lblTableNo.Text
        Dim totalAmount As Decimal = Decimal.Parse(lblTotalAmount.Text.Replace("RM", "").Trim())

        Dim newOrder As New [Order] With {
        .OrderID = orderID,
        .StaffID = staffId,
        .TableNo = tableNo,
        .TotalAmount = totalAmount,
        .OrderDateTime = DateTime.Now
        }

        db.Orders.InsertOnSubmit(newOrder)

        Dim paymentID As String = GeneratePaymentID(db)
        Dim newPayment As New Payment With {
        .PaymentID = paymentID,
        .OrderID = orderID,
        .PaymentMethod = "Not yet Pay",
        .AmountPaid = totalAmount * 1.1D,
        .DateTime = Nothing,
        .PaymentStatus = "Pending"
        }
        db.Payments.InsertOnSubmit(newPayment)

        Dim lastItemID = (From oi In db.Order_Items
                          Order By oi.OrderItemID Descending
                          Select oi.OrderItemID).FirstOrDefault()

        Dim lastItemNum As Integer = 0
        If lastItemID IsNot Nothing AndAlso lastItemID.StartsWith("OI") Then
            Integer.TryParse(lastItemID.Substring(2), lastItemNum)
        End If

        For Each panel As Panel In flpCart.Controls
            Dim itemId As String = panel.Tag.ToString()
            Dim lblSummary = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Name.StartsWith("lblSummary"))
            Dim itemInDb = db.Items.FirstOrDefault(Function(i) i.Item_Id = itemId)

            If lblSummary Is Nothing OrElse itemInDb Is Nothing Then Continue For

            Dim parts = lblSummary.Text.Split({" x ", " RM "}, StringSplitOptions.RemoveEmptyEntries)
            If parts.Length < 3 Then Continue For

            Dim itemName As String = parts(0).Trim()
            Dim quantity As Integer
            Dim subtotal As Decimal

            If Not Integer.TryParse(parts(1).Trim(), quantity) Then Continue For
            If Not Decimal.TryParse(parts(2).Trim(), subtotal) Then Continue For

            lastItemNum += 1
            Dim orderItemID As String = "OI" & lastItemNum.ToString("D5")

            Dim newItem As New Order_Item With {
            .OrderItemID = orderItemID,
            .OrderID = orderID,
            .Item_Id = itemId,
            .Quantity = quantity,
            .SubTotal = subtotal
        }

            db.Order_Items.InsertOnSubmit(newItem)

            itemInDb.Item_Quantity -= quantity
        Next

        Try
            db.SubmitChanges()
            MessageBox.Show("Order submitted successfully!")

            OrderListPreviewDialog.Document = PrintOrderList
            OrderListPreviewDialog.ShowDialog(Me)

            Dim tableRecord = db.TableNos.FirstOrDefault(Function(t) t.Name = tableNo)

            If tableRecord IsNot Nothing Then
                tableRecord.Color = Color.Orange.ToArgb()
                db.SubmitChanges()
            End If

            For Each ctrl As Control In FrmTable.pnlTables.Controls
                If TypeOf ctrl Is Button AndAlso ctrl.Text = tableNo Then
                    ctrl.BackColor = Color.Orange
                    Exit For
                End If
            Next

            flpCart.Controls.Clear()
            lblTotalAmount.Text = "RM 0.00"
        Catch ex As Exception
            MessageBox.Show("Failed to save order: " & ex.Message)
        End Try

    End Sub

    Private Function GetStaffIdByName(username As String) As String
        Dim staffId = (From s In db.Staffs
                       Where s.Username = username
                       Select Staff_Id = s.StaffID).FirstOrDefault()
        Return staffId
    End Function

    Private Function GetCartItemQuantity(panel As Panel) As Integer
        Dim lblSummary = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Name.StartsWith("lblSummary"))
        If lblSummary IsNot Nothing Then
            Dim parts = lblSummary.Text.Split({" x ", " RM "}, StringSplitOptions.RemoveEmptyEntries)
            Dim quantity As Integer
            If parts.Length >= 2 AndAlso Integer.TryParse(parts(1).Trim(), quantity) Then
                Return quantity
            End If
        End If
        Return 0
    End Function

    Private Sub ShowStockWarning(item As Item)
        MessageBox.Show($"Not enough stock for {item.Item_Name}. Only {item.Item_Quantity} left.",
                    "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub SetCartItemSummary(panel As Panel, item As Item, quantity As Integer)
        Dim lblSummary = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Name.StartsWith("lblSummary"))
        If lblSummary IsNot Nothing Then
            lblSummary.Text = $"{item.Item_Name} x {quantity} RM {quantity * item.Item_Price:F2}"
            lblSummary.Tag = quantity.ToString()
        End If
    End Sub

    Private Function GetCartItemDetails() As List(Of Tuple(Of String, String, Integer, Decimal))
        Dim itemList As New List(Of Tuple(Of String, String, Integer, Decimal))

        For Each panel As Panel In flpCart.Controls
            Dim itemId As String = panel.Tag.ToString()
            Dim lblSummary = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Name.StartsWith("lblSummary"))

            If lblSummary IsNot Nothing Then
                Dim parts = lblSummary.Text.Split({" x ", " RM "}, StringSplitOptions.RemoveEmptyEntries)

                If parts.Length >= 3 Then
                    Dim itemName As String = parts(0).Trim()
                    Dim quantity As Integer
                    Dim subtotal As Decimal

                    If Integer.TryParse(parts(1).Trim(), quantity) AndAlso Decimal.TryParse(parts(2).Trim(), subtotal) Then
                        itemList.Add(Tuple.Create(itemId, itemName, quantity, subtotal))
                    End If
                End If
            End If
        Next

        Return itemList
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()

    End Sub

    Private Sub btnGoToPayment_Click(sender As Object, e As EventArgs) Handles btnGoToPayment.Click
        Dim paymentPage As New PaymentMain()
        paymentPage.SelectedTableNo = lblTableNo.Text
        paymentPage.ShowDialog()
    End Sub

    Private Sub PrintOrderList_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintOrderList.PrintPage
        Dim fntHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fntSubHeader As New Font("Calibri", 12)
        Dim fntBody As New Font("Consolas", 10)
        Dim staffId As String = GetStaffIdByName(FrmTable.lblName.Text.Trim())

        Dim strHeader As String = "ORDER LIST"
        Dim strSubHeader As String = String.Format(
        "Table No: {0}" & vbNewLine &
        "Staff ID: {1}" & vbNewLine &
        "Order Time: {2:dd-MMMM-yyyy hh:mm:ss tt}",
        lblTableNo.Text, staffId, DateTime.Now
    )

        Dim body As New StringBuilder()
        body.AppendLine()
        body.AppendLine("No  Item Name                   Qty")
        body.AppendLine("--- -------------------------- ----")

        Dim count As Integer = 0

        For Each panel As Panel In flpCart.Controls
            Dim itemId As String = panel.Tag.ToString()
            Dim lblSummary = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Name.StartsWith("lblSummary"))
            Dim txtNote = panel.Controls.OfType(Of TextBox)().FirstOrDefault(Function(t) t.Name = "txtNote_" & itemId)

            If lblSummary Is Nothing Then Continue For

            Dim parts = lblSummary.Text.Split({" x ", " RM "}, StringSplitOptions.RemoveEmptyEntries)
            If parts.Length < 2 Then Continue For

            Dim itemName As String = parts(0).Trim()
            Dim quantity As Integer

            If Not Integer.TryParse(parts(1).Trim(), quantity) Then Continue For

            count += 1
            body.AppendFormat("{0,-3} {1,-26} {2,4}" & vbNewLine, count, itemName, quantity)

            If txtNote IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(txtNote.Text) Then
                body.AppendLine("     Note: " & txtNote.Text.Trim())
            End If
        Next

        body.AppendLine()
        body.AppendFormat("Total Items: {0}", count)

        Dim marginLeft As Integer = 100
        Dim marginTop As Integer = 100
        Dim lineHeight As Integer = CInt(fntBody.GetHeight(e.Graphics)) + 4

        e.Graphics.DrawString(strHeader, fntHeader, Brushes.Black, marginLeft, marginTop)
        e.Graphics.DrawString(strSubHeader, fntSubHeader, Brushes.Black, marginLeft, marginTop + 50)
        e.Graphics.DrawString(body.ToString(), fntBody, Brushes.Black, marginLeft, marginTop + 120)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        flpCart.Controls.Clear()
        UpdateTotal()
    End Sub

    Private Sub FieldGuidelineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldGuidelineToolStripMenuItem.Click
        MessageBox.Show(
        "ORDER SAFEGUARDS:" & vbCrLf & vbCrLf &
        "1. Search for the item by choosing its category." & vbCrLf &
        "2. Review item details before send order." & vbCrLf &
        "3. Confirm order with a order list." & vbCrLf &
        "4. Table will change color and show the waiting time after send order.",
        "Order Help",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class