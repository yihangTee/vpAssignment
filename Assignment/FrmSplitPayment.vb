Public Class FrmSplitPayment

    Private originalItems As List(Of OrderItemDetail)
    Private splitItems As List(Of OrderItemDetail)
    Private Sub FrmSplitPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvItemsToSplit.AutoGenerateColumns = False
        dgvItemsToSplit.Columns.Clear()
        dgvItemsToSplit.MultiSelect = True
        dgvItemsToSplit.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        ' Add columns manually
        dgvItemsToSplit.Columns.Add(New DataGridViewTextBoxColumn With {
        .DataPropertyName = "ItemName",
        .HeaderText = "Item Name",
        .ReadOnly = True
    })

        dgvItemsToSplit.Columns.Add(New DataGridViewTextBoxColumn With {
        .DataPropertyName = "ItemPrice",
        .HeaderText = "Price (RM)",
        .ReadOnly = True
    })

        dgvItemsToSplit.Columns.Add(New DataGridViewTextBoxColumn With {
        .DataPropertyName = "Quantity",
        .HeaderText = "Qty",
        .ReadOnly = True
    })

        dgvItemsToSplit.Columns.Add(New DataGridViewTextBoxColumn With {
        .DataPropertyName = "SubTotal",
        .HeaderText = "Subtotal (RM)",
        .ReadOnly = True
    })

        dgvItemsToSplit.DataSource = splitItems
        RecalculateTotals()
    End Sub

    ' Add this constructor
    Public Sub New(items As List(Of OrderItemDetail))
        InitializeComponent()
        originalItems = items.Select(Function(x) New OrderItemDetail With {
            .OrderID = x.OrderID,
            .ItemName = x.ItemName,
            .ItemPrice = x.ItemPrice,
            .Quantity = x.Quantity,
            .SubTotal = x.SubTotal
        }).ToList()
        splitItems = items.Select(Function(x) New OrderItemDetail With {
    .OrderID = x.OrderID,
    .ItemName = x.ItemName,
    .ItemPrice = x.ItemPrice,
    .Quantity = x.Quantity,  ' Use real quantity here
    .SubTotal = x.Quantity * x.ItemPrice
}).ToList()

    End Sub
    Private Sub dgvItemsToSplit_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemsToSplit.CellEndEdit
        ' Update splitItems from the DataGridView
        For i As Integer = 0 To dgvItemsToSplit.Rows.Count - 1
            Dim row = dgvItemsToSplit.Rows(i)
            If Not row.IsNewRow Then
                Dim qty As Integer
                If Integer.TryParse(row.Cells("Quantity").Value?.ToString(), qty) Then
                    splitItems(i).Quantity = qty
                    splitItems(i).SubTotal = qty * splitItems(i).ItemPrice
                    row.Cells("SubTotal").Value = splitItems(i).SubTotal.ToString("F2")
                End If
            End If
        Next
        RecalculateTotals()
    End Sub
    Private Sub dgvItemsToSplit_SelectionChanged(sender As Object, e As EventArgs) Handles dgvItemsToSplit.SelectionChanged
        RecalculateTotals()
    End Sub



    Private Sub RecalculateTotals()
        Dim subtotalSplit As Decimal = 0D

        For Each row As DataGridViewRow In dgvItemsToSplit.SelectedRows
            If Not row.IsNewRow AndAlso row.DataBoundItem IsNot Nothing Then
                Dim item As OrderItemDetail = CType(row.DataBoundItem, OrderItemDetail)
                subtotalSplit += item.SubTotal
            End If
        Next

        Dim taxSplit = subtotalSplit * 0.1D
        Dim totalSplit = subtotalSplit + taxSplit

        lbltotalPrice.Text = "Subtotal: RM " & subtotalSplit.ToString("F2")
        lblTax.Text = "Service Tax: RM " & taxSplit.ToString("F2")
        lblTotalPay.Text = "Total Pay: RM " & totalSplit.ToString("F2")
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub GuidlinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuidlinesToolStripMenuItem.Click
        MessageBox.Show(
        "SPLIT PAYMENT SAFEGUARDS:" & vbCrLf & vbCrLf &
        "1. Check the item you purchase" & vbCrLf &
        "2. Select the item wants to pay" & vbCrLf &
        "3. Can use the calculator to calculate the change" & vbCrLf,
        "Payment Help",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class