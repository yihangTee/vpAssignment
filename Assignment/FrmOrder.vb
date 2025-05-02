Imports System.Data.Linq
Imports System.Data.SqlClient

Public Class FrmOrder
    Private Sub grpCart_Enter(sender As Object, e As EventArgs) Handles grpCart.Enter

    End Sub

    Private Sub FrmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDataGridView()
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

            'AddHandler btnAdd.Click, Sub(s, e)
            '                             AddToOrder(item.Item_Id)
            '                         End Sub

            itemPanel.Controls.Add(lblName)
            itemPanel.Controls.Add(lblPrice)
            itemPanel.Controls.Add(btnAdd)

            flpMenu.Controls.Add(itemPanel)
        Next
    End Sub

    Private Sub InitializeDataGridView()
        If dgvOrder.Columns.Count = 0 Then
            dgvOrder.Columns.Add("Item_Id", "Item ID")
            dgvOrder.Columns.Add("Item_Name", "Item Name")
            dgvOrder.Columns.Add("Quantity", "Quantity")
            dgvOrder.Columns.Add("Item_Price", "Price")
            dgvOrder.Columns.Add("SubTotal", "SubTotal")

            dgvOrder.Columns("Item_Price").ValueType = GetType(Decimal)
            dgvOrder.Columns("SubTotal").ValueType = GetType(Decimal)
        End If
    End Sub


    Private Sub UpdateTotal()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In dgvOrder.Rows
            total += Convert.ToDecimal(row.Cells("SubTotal").Value)
        Next

        lblTotalAmount.Text = "Total: RM " & total.ToString("F2")
    End Sub

End Class