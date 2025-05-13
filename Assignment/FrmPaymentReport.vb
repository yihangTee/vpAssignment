Public Class FrmPaymentReport

    Public Class SalesSummary
        Public Property PaymentMethod As String
        Public Property TotalSales As Decimal
    End Class

    ' Declare chartData as IEnumerable(Of SalesSummary)
    Private chartData As IEnumerable(Of SalesSummary)

    Private Sub FrmPaymentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate months
        For i As Integer = 1 To 12
            cmbMonth.Items.Add(New DateTime(2025, i, 1).ToString("MMMM"))
        Next
        cmbMonth.SelectedIndex = 0

        ' Populate payment methods
        cmbPaymentMethod.Items.AddRange({"All", "Cash", "QR"})
        cmbPaymentMethod.SelectedIndex = 0
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim db As New BL_farizDataContext()

        ' Get filter values
        Dim selectedMonth As Integer = cmbMonth.SelectedIndex + 1 ' Jan = 1
        Dim selectedMethod As String = cmbPaymentMethod.SelectedItem?.ToString()

        ' Filter payments
        Dim filteredPayments = db.Payments.AsQueryable()

        If selectedMonth > 0 Then
            filteredPayments = filteredPayments.Where(Function(p) p.DateTime.HasValue AndAlso p.DateTime.Value.Month = selectedMonth)
        End If

        If Not String.IsNullOrEmpty(selectedMethod) AndAlso selectedMethod <> "All" Then
            filteredPayments = filteredPayments.Where(Function(p) p.PaymentMethod = selectedMethod)
        End If

        ' Fetch and filter the data
        Dim rawData = filteredPayments.
            Select(Function(p) New With {
                p.OrderID,
                p.PaymentMethod,
                p.AmountPaid,
                p.DateTime
            }).ToList()

        ' Format for display
        Dim reportData = rawData.
            Select(Function(p) New With {
                .OrderID = p.OrderID,
                .PaymentMethod = p.PaymentMethod,
                .AmountPaid = p.AmountPaid,
                .DateTime = If(p.DateTime.HasValue, p.DateTime.Value.ToString("yyyy-MM-dd HH:mm"), "")
            }).ToList()

        ' Bind to DataGridView
        dgvReport.DataSource = reportData

        ' Calculate total
        Dim totalSales As Decimal = filteredPayments.Sum(Function(p) p.AmountPaid)
        lblTotalSales.Text = "Total Sales: RM " & totalSales.ToString("F2")

        ' Update chartData as IEnumerable(Of SalesSummary)
        chartData = filteredPayments.
            GroupBy(Function(p) p.PaymentMethod).
            Select(Function(g) New SalesSummary With {
                .PaymentMethod = g.Key,
                .TotalSales = g.Sum(Function(p) p.AmountPaid)
            }).ToList()

        ' Update chart
        UpdateChart(chartData)
    End Sub

    Private Sub UpdateChart(data As IEnumerable(Of SalesSummary))
        salesChart.Series.Clear()
        Dim series = New DataVisualization.Charting.Series("Sales")
        series.ChartType = DataVisualization.Charting.SeriesChartType.Pie

        Dim total As Decimal = data.Sum(Function(item) item.TotalSales)

        For Each item In data
            Dim pointIndex = series.Points.AddXY(item.PaymentMethod, item.TotalSales)
            Dim percent = (item.TotalSales / total) * 100D
            series.Points(pointIndex).Label = $"{item.PaymentMethod}: {percent:F1}%"
        Next

        salesChart.Series.Add(series)
        salesChart.Legends.Clear()
        salesChart.Legends.Add("Legend")
        salesChart.Legends("Legend").Docking = DataVisualization.Charting.Docking.Right
    End Sub


    Private Sub btnToggleChart_Click(sender As Object, e As EventArgs) Handles btnToggleChart.Click
        ' Toggle visibility of DataGridView and Chart
        If dgvReport.Visible Then
            ' Hide DataGridView, show chart, and update button text
            dgvReport.Visible = False
            salesChart.Visible = True
            btnToggleChart.Text = "Switch to Table View"

            ' Ensure chart is populated
            If chartData IsNot Nothing Then
                UpdateChart(chartData)
            End If

            salesChart.BringToFront() ' Bring chart to the front
        Else
            ' Hide chart, show DataGridView, and update button text
            dgvReport.Visible = True
            salesChart.Visible = False
            btnToggleChart.Text = "Switch to Chart View"

            dgvReport.BringToFront() ' Bring DataGridView to the front
        End If
    End Sub

End Class
