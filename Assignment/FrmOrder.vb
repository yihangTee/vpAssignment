Imports System.Data.Linq
Imports System.Data.SqlClient

Public Class FrmOrder
    Private Sub FrmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    Private Sub LoadCategories()
        Dim db As New BL_farizDataContext()

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
        Dim db As New BL_farizDataContext()
        flpMenu.Controls.Clear()

        Dim items = From i In db.Items
                    Where i.Item_Category = category
                    Select i

        For Each item In items
            Dim itemPanel As New Panel With {
            .Width = 120,
            .Height = 120,
            .BorderStyle = BorderStyle.Fixed3D,
            .Tag = item.Item_Id
        }

            Dim lblName As New Label With {
            .Text = item.Item_Name,
            .AutoSize = True,
            .Location = New Point(10, 10)
        }

            Dim lblPrice As New Label With {
            .Text = "RM " & item.Item_Price.ToString("F2"),
            .AutoSize = True,
            .Location = New Point(10, lblName.Bottom + 5)
        }

            Dim btnAdd As New Button With {
            .Text = "Add",
            .Width = 60,
            .Location = New Point(10, lblPrice.Bottom + 10)
        }

            AddHandler btnAdd.Click, Sub(s, e)
                                         AddToCart(item.Item_Id)
                                     End Sub

            itemPanel.Controls.Add(lblName)
            itemPanel.Controls.Add(lblPrice)
            itemPanel.Controls.Add(btnAdd)

            flpMenu.Controls.Add(itemPanel)
        Next
    End Sub

    Private Sub AddToCart(itemId As String)
        Dim db As New BL_farizDataContext()
        Dim item = db.Items.FirstOrDefault(Function(i) i.Item_Id = itemId)

        If item IsNot Nothing Then
            If item.Item_Quantity <= 0 Then
                MessageBox.Show($"{item.Item_Name} is out of stock.", "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim existingPanel = GetCartPanel(itemId)

            If existingPanel IsNot Nothing Then
                Dim currentQty = GetCartItemQuantity(existingPanel)

                If currentQty >= item.Item_Quantity Then
                    ShowStockWarning(item)
                    Return
                End If

                SetCartItemSummary(existingPanel, item, currentQty + 1)
            Else
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
        Dim panel As New Panel With {
        .Width = 250,
        .Height = 130,
        .Tag = item.Item_Id,
        .BorderStyle = BorderStyle.Fixed3D,
        .BackColor = Color.White
    }

        Dim lblSummary As New Label With {
        .Name = "lblSummary" & item.Item_Id,
        .Text = $"{item.Item_Name} x 1 RM {item.Item_Price:F2}",
        .Font = New Font("Segoe UI", 10, FontStyle.Bold),
        .Location = New Point(10, 10),
        .AutoSize = True,
        .Tag = "1"
    }

        Dim buttonY As Integer = lblSummary.Bottom + 10

        Dim btnIncrease As New Button With {
        .Text = "+",
        .Size = New Size(30, 30),
        .Location = New Point(10, buttonY)
    }
        AddHandler btnIncrease.Click, Sub(s, e) ModifyQuantity(item.Item_Id, 1)

        Dim btnDecrease As New Button With {
        .Text = "-",
        .Size = New Size(30, 30),
        .Location = New Point(btnIncrease.Right + 5, buttonY)
    }
        AddHandler btnDecrease.Click, Sub(s, e) ModifyQuantity(item.Item_Id, -1)

        Dim btnDelete As New Button With {
        .Text = "Delete",
        .Size = New Size(80, 30),
        .Location = New Point(btnDecrease.Right + 5, buttonY)
    }
        AddHandler btnDelete.Click, Sub(s, e) DeleteItem(item.Item_Id)

        Dim txtNote As New TextBox With {
        .Name = "txtNote_" & item.Item_Id,
        .Text = "",
        .ForeColor = Color.Gray,
        .Location = New Point(10, btnIncrease.Bottom + 10),
        .Width = 220
    }

        panel.Controls.Add(lblSummary)
        panel.Controls.Add(btnIncrease)
        panel.Controls.Add(btnDecrease)
        panel.Controls.Add(btnDelete)
        panel.Controls.Add(txtNote)

        Return panel
    End Function

    Private Sub ModifyQuantity(itemId As String, change As Integer)
        Dim db As New BL_farizDataContext()
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

    Private Sub btnSendOrder_Click(sender As Object, e As EventArgs) Handles btnSendOrder.Click
        If flpCart.Controls.Count = 0 Then
            MessageBox.Show("Cart is empty.")
            Return
        End If

        Dim db As New BL_farizDataContext()

        Dim orderID As String = GenerateOrderID(db)
        Dim staffID As String = "ST0001"
        Dim tableNo As String = lblTableNo.Text
        Dim totalAmount As Decimal = Decimal.Parse(lblTotalAmount.Text.Replace("RM", "").Trim())

        Dim newOrder As New [Order] With {
        .OrderID = orderID,
        .StaffID = staffID,
        .TableNo = tableNo,
        .TotalAmount = totalAmount,
        .OrderDateTime = DateTime.Now
    }

        db.Orders.InsertOnSubmit(newOrder)

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

            If lblSummary IsNot Nothing Then
                Dim parts = lblSummary.Text.Split({" x ", " RM "}, StringSplitOptions.RemoveEmptyEntries)

                If parts.Length >= 3 Then
                    Dim quantity As Integer
                    Dim subtotal As Decimal

                    If Integer.TryParse(parts(1).Trim(), quantity) AndAlso Decimal.TryParse(parts(2).Trim(), subtotal) Then
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
                    End If
                End If
            End If
        Next

        Try
            db.SubmitChanges()
            MessageBox.Show("Order submitted successfully!")

            flpCart.Controls.Clear()
            lblTotalAmount.Text = "RM 0.00"

        Catch ex As Exception
            MessageBox.Show("Failed to save order: " & ex.Message)
        End Try
    End Sub

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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()

    End Sub

    Private Sub flpCart_Paint(sender As Object, e As PaintEventArgs) Handles flpCart.Paint

    End Sub

    Private Sub btnGoToPayment_Click(sender As Object, e As EventArgs) Handles btnGoToPayment.Click
        PaymentMain.Show()
    End Sub
End Class