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
                    Where i.Item_Category = category And i.Item_Quantity > 0
                    Select i

        For Each item In items
            Dim itemPanel As New Panel With {
            .Width = 120,
            .Height = 120,
            .BorderStyle = BorderStyle.FixedSingle,
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
            Dim existingPanel = GetCartPanel(itemId)

            If existingPanel IsNot Nothing Then
                UpdateItemQuantity(existingPanel, item, 1)
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
        Dim lblSummary = panel.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Name.StartsWith("lblSummary"))
        If lblSummary IsNot Nothing Then
            Dim parts = lblSummary.Text.Split(CChar("x"))
            If parts.Length > 1 Then
                Dim itemName = parts(0).Trim()

                Dim quantityAndPrice = parts(1).Trim().Split(CChar("R"))
                If quantityAndPrice.Length > 1 Then
                    Dim currentQty As Integer
                    If Integer.TryParse(quantityAndPrice(0).Trim(), currentQty) Then
                        Dim newQty = currentQty + change

                        If newQty < 1 Then Return

                        lblSummary.Text = $"{itemName} x {newQty} RM {newQty * item.Item_Price:F2}"
                        lblSummary.Tag = newQty.ToString()
                        UpdateTotal()
                    End If
                End If
            End If
        End If
    End Sub

    Private Function CreateCartPanel(item As Item) As Panel
        Dim panel As New Panel With {
        .Width = 250,
        .Height = 130,
        .Tag = item.Item_Id,
        .BorderStyle = BorderStyle.FixedSingle,
        .BackColor = Color.White
    }

        Dim lblSummary As New Label With {
        .Name = "lblSummary_" & item.Item_Id,
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
                UpdateItemQuantity(panel, item, change)
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
End Class