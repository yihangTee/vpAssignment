Public Class frmItemDetails
    Private trackedItem As Item

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Public Sub New(item As Item)
        InitializeComponent()
        trackedItem = item
    End Sub

    Private Sub frmItemDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If trackedItem IsNot Nothing Then
            lblShowItemID.Text = trackedItem.Item_Id
            lblShowItemName.Text = trackedItem.Item_Name
            lblShowItemCategory.Text = trackedItem.Item_Category
            lblShowItemDescription.Text = trackedItem.Item_Description
            lblShowItemStockLvl.Text = trackedItem.Item_StockLvl
            lblShowItemQuantity.Text = trackedItem.Item_Quantity.ToString()
            lblShowItemPrice.Text = "RM " & trackedItem.Item_Price.ToString("0.00")

            If trackedItem.Item_Picture IsNot Nothing Then
                Using ms As New IO.MemoryStream(trackedItem.Item_Picture.ToArray())
                    picShowItemPicture.Image = Image.FromStream(ms)
                End Using
            End If
        End If
    End Sub

End Class