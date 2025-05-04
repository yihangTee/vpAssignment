Public Class FrmSalesReport
    Private formLoaded As Boolean = False

    Private Sub FrmSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
        cmbItemType.SelectedIndex = 0
        cmbChartType.SelectedIndex = 0
        formLoaded = True
    End Sub

    Private Sub LoadCategories()
        Dim db As New BL_farizDataContext()
        Dim categories = (From i In db.Items Select i.Item_Category).Distinct().ToList()
        cmbItemType.DataSource = categories
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim db As New BL_farizDataContext()
        Dim selectedCategory = cmbItemType.SelectedItem.ToString()
        Dim selectedChartType = cmbChartType.SelectedItem.ToString()

        Dim salesData = From oi In db.Order_Items
                        Join o In db.Orders On oi.OrderID Equals o.OrderID
                        Join it In db.Items On oi.Item_Id Equals it.Item_Id
                        Where it.Item_Category = selectedCategory
                        Group By it.Item_Name Into TotalQty = Sum(oi.Quantity)
                        Order By TotalQty Descending

        chartSales.Series.Clear()
        chartSales.Titles.Clear()
        chartSales.Titles.Add("Sales by Item - " & selectedCategory)

        Dim series As New DataVisualization.Charting.Series("Sales")

        Select Case selectedChartType
            Case "Bar"
                series.ChartType = DataVisualization.Charting.SeriesChartType.Bar
            Case "Column"
                series.ChartType = DataVisualization.Charting.SeriesChartType.Column
            Case "Line"
                series.ChartType = DataVisualization.Charting.SeriesChartType.Line
            Case "Pie"
                series.ChartType = DataVisualization.Charting.SeriesChartType.Pie
        End Select

        series.IsValueShownAsLabel = True

        For Each item In salesData
            series.Points.AddXY(item.Item_Name, item.TotalQty)
        Next

        chartSales.Series.Add(series)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub cmbItemType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemType.SelectedIndexChanged
        If formLoaded Then
            btnGenerate_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub cmbChartType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChartType.SelectedIndexChanged
        If formLoaded Then
            btnGenerate_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        srpPreview.Document = docSalesReport
        srpPreview.ShowDialog()
    End Sub

    Private Sub docSalesReport_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles docSalesReport.PrintPage
        Dim bmp As New Bitmap(chartSales.Width, chartSales.Height)
        chartSales.DrawToBitmap(bmp, New Rectangle(0, 0, chartSales.Width, chartSales.Height))

        e.Graphics.DrawImage(bmp, 50, 50)
    End Sub
End Class