Public Class PaymentMain
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Dim cashAmount As String = ""
    Dim amount As Decimal = 0D
    Dim orderTotal As Decimal = 0D
    Public Property SelectedTableNo As String


    Private Sub NumberButton_Click(sender As Object, e As EventArgs) Handles key1.Click, key2.Click, key3.Click, key4.Click, key5.Click, key6.Click, key7.Click, key8.Click, key9.Click, key0.Click, keyDot.Click
        Dim btn = CType(sender, System.Windows.Forms.Button)
        Dim key As String = btn.Text

        If key = "." Then
            If cashAmount.Contains(".") Then Exit Sub
            If cashAmount = "" Then
                cashAmount = "0."
            Else
                cashAmount &= "."
            End If
        Else
            ' Check if already has 2 digits after decimal
            If cashAmount.Contains(".") Then
                Dim decimalPart As String = cashAmount.Split("."c)(1)
                If decimalPart.Length >= 2 Then Exit Sub
            End If

            ' Preview the new value
            Dim newAmount As String = cashAmount & key

            ' Try to parse and check the numeric value
            Dim numericValue As Decimal
            If Decimal.TryParse(newAmount, numericValue) Then
                If numericValue > 10000D Then Exit Sub
            End If

            cashAmount = newAmount
        End If

        lblPayCash.Text = "RM " & cashAmount
    End Sub

    Private Sub BtnBackspace_Click(sender As Object, e As EventArgs) Handles keyBackspace.Click
        If cashAmount.Length > 0 Then
            cashAmount = cashAmount.Substring(0, cashAmount.Length - 1)
        End If
        lblPayCash.Text = "RM " & cashAmount
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles radCash.CheckedChanged, radQR.CheckedChanged
        If radQR.Checked Then
            radQR.Checked = False ' Prevent loop

            Dim qrForm As New PaymentQR()
            qrForm.SelectedTableNo = SelectedTableNo
            qrForm.ParentPaymentForm = Me

            Me.Hide()
            qrForm.ShowDialog()

            ' Only close PaymentMain if QR payment was completed
            If qrForm.Tag IsNot Nothing AndAlso qrForm.Tag.ToString() = "Paid" Then
                Me.Close()
            Else
                Me.Show() ' Restore if not paid (e.g. Back pressed)
                radCash.Checked = True

            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cashAmount = "0.00"
        amount = 0.00D
        lblPayCash.Text = "RM " & cashAmount
        lblChange.Text = "RM " & amount
    End Sub

    Private Sub btnSuccessPay_Click(sender As Object, e As EventArgs) Handles btnSuccessPay.Click
        Dim confirmResult = MessageBox.Show("Are you sure you want to complete the payment?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim db As New BL_farizDataContext()
        Dim tableNo As String = lblTableNo.Text

        Try
            Dim matchingPayments = From o In db.Orders
                                   Join p In db.Payments On o.OrderID Equals p.OrderID
                                   Where o.TableNo = SelectedTableNo AndAlso p.PaymentStatus = "Pending"
                                   Select p

            If matchingPayments.Any() Then
                For Each pay In matchingPayments
                    pay.PaymentMethod = "Cash"
                    pay.PaymentStatus = "Success"
                    pay.DateTime = DateTime.Now
                Next

                db.SubmitChanges()
                MessageBox.Show("Payment Success.", "Payment Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim tableRecord = db.TableNos.FirstOrDefault(Function(t) t.Name = tableNo)

                If tableRecord IsNot Nothing Then
                    tableRecord.Color = Color.LightGreen.ToArgb()
                    db.SubmitChanges()
                End If

                For Each ctrl As Control In FrmTable.pnlTables.Controls
                    If TypeOf ctrl Is Button AndAlso ctrl.Text = tableNo Then
                        ctrl.BackColor = Color.LightGreen
                        Exit For
                    End If
                Next
                Me.Close()
            Else
                MessageBox.Show("No matching payment found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error while updating payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PaymentMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowLatestOrderItemDetails()
        lblTableNo.Text = SelectedTableNo
    End Sub
    Private Sub ShowLatestOrderItemDetails()

        Dim db As New BL_farizDataContext()

        Dim pendingItems = From o In db.Orders
                           Join p In db.Payments On o.OrderID Equals p.OrderID
                           Join oi In db.Order_Items On o.OrderID Equals oi.OrderID
                           Join i In db.Items On oi.Item_Id Equals i.Item_Id
                           Where o.TableNo = SelectedTableNo AndAlso p.PaymentStatus = "Pending"
                           Select New With {
                           .OrderID = o.OrderID,
                           .ItemName = i.Item_Name,
                           .ItemPrice = i.Item_Price,
                           .Quantity = oi.Quantity,
                           .SubTotal = oi.SubTotal
                       }

        If pendingItems.Any() Then
            ' Create header labels for the table
            Dim topOffset As Integer = 60
            Dim rowHeight As Integer = 25
            Dim fontSetting As New Font("Yu Gothic UI", 10.2F)


            ' Add the actual item details
            Dim rowNumber As Integer = 1
            orderTotal = 0D

            For Each item In pendingItems
                Dim lblNumber As New Label With {
                    .Text = rowNumber.ToString(),
                    .Location = New Point(24, topOffset),
                    .AutoSize = True,
                    .Font = fontSetting
                }

                Dim lblName As New Label With {
                    .Text = item.ItemName,
                    .Location = New Point(55, topOffset),
                    .AutoSize = True,
                    .Font = fontSetting
                }

                Dim lblPrice As New Label With {
                    .Text = "RM " & item.ItemPrice.ToString("F2"),
                    .Location = New Point(190, topOffset),
                    .AutoSize = True,
                    .Font = fontSetting
                }

                Dim lblQty As New Label With {
                    .Text = item.Quantity.ToString(),
                    .Location = New Point(300, topOffset),
                    .AutoSize = True,
                    .Font = fontSetting
                }

                Dim lblSubtotal As New Label With {
                    .Text = "RM" & item.SubTotal.ToString("F2"),
                    .Location = New Point(370, topOffset),
                    .AutoSize = True,
                    .Font = fontSetting
                }

                ' Add all labels to the GroupBox
                grpOrderItem.Controls.AddRange({lblNumber, lblName, lblPrice, lblQty, lblSubtotal})

                ' Move to next row
                topOffset += rowHeight
                rowNumber += 1
                orderTotal += item.SubTotal
            Next
        Else
            MessageBox.Show("No order items found for" & SelectedTableNo)
            Me.Close()
        End If
        lbltotalPrice.Text = "RM " & orderTotal.ToString("F2")

        Dim tax As Decimal = 0.1D
        Dim taxValue As Decimal = orderTotal * tax
        Dim totalPay As Decimal = orderTotal + taxValue
        lblTax.Text = "RM " & taxValue.ToString("F2")
        lblTotalPay.Text = "RM " & totalPay.ToString("F2")
    End Sub

    Private Sub CashButton_Click(sender As Object, e As EventArgs) Handles btn100.Click, btn50.Click, btn20.Click, btn10.Click, btn5.Click, btn1.Click, btn20sen.Click, btn10sen.Click
        Dim btn = CType(sender, System.Windows.Forms.Button)
        Dim value As Decimal = 0D

        ' Parse button text
        Select Case btn.Text
            Case "RM100" : value = 100D
            Case "RM50" : value = 50D
            Case "RM20" : value = 20D
            Case "RM10" : value = 10D
            Case "RM5" : value = 5D
            Case "RM1" : value = 1D
            Case "20 sen" : value = 0.2D
            Case "10 sen" : value = 0.1D
        End Select

        ' ADD value instead of overwrite
        Dim currentAmount As Decimal = 0D
        Decimal.TryParse(cashAmount, currentAmount)

        currentAmount += value
        If currentAmount > 10000D Then currentAmount = 10000D

        cashAmount = currentAmount.ToString("F2")
        lblPayCash.Text = "RM " & cashAmount

    End Sub

    Private isChangeMode As Boolean = False

    Private Sub btnChangeMode_Click(sender As Object, e As EventArgs) Handles btnChangeMode.Click
        isChangeMode = Not isChangeMode

        PanelKeyboard.Visible = Not isChangeMode
        panelCashInput.Visible = isChangeMode

        btnChangeMode.Text = If(isChangeMode, "Switch to Keypad", "Switch to Cash Input")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If Decimal.TryParse(cashAmount, amount) Then
            Dim result As Decimal = amount - orderTotal
            If result < 0 Then
                MessageBox.Show("Insufficient funds. Please enter a valid amount.")
            Else
                lblChange.Text = "RM " & result.ToString("F2")
            End If
        Else
            MessageBox.Show("Invalid number")
        End If
    End Sub
End Class

