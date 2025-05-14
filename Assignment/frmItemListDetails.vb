Public Class frmItemListDetails
    Private items As List(Of Item)

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Public Sub New(itemList As List(Of Item))
        InitializeComponent()
        items = itemList
    End Sub

    Private Sub frmItemListDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure DataGridView
        With dgvItemList
            .Columns.Clear()
            .Rows.Clear()
            .AllowUserToAddRows = False
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            .DefaultCellStyle.ForeColor = Color.DarkSlateBlue
            .DefaultCellStyle.BackColor = Color.AliceBlue
            .DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .EnableHeadersVisualStyles = False

            .Columns.Add("colNo", "No.")
            .Columns.Add("colID", "Item ID")
            .Columns.Add("colName", "Item Name")
            .Columns.Add("colCategory", "Category")
            .Columns.Add("colDesc", "Description")
            .Columns.Add("colStockLvl", "Stock Level")
            .Columns.Add("colQty", "Quantity")
            .Columns.Add("colPrice", "Price")
        End With

        ' Populate DataGridView
        Dim no As Integer = 1
        For Each item In items
            dgvItemList.Rows.Add(no, item.Item_Id, item.Item_Name, item.Item_Category, item.Item_Description,
                                 item.Item_StockLvl, item.Item_Quantity, item.Item_Price.ToString("C"))
            no += 1
        Next

    End Sub

End Class