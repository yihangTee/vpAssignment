Public Class FrmPaymentReport

    Public Class SalesSummary
        Public Property PaymentMethod As String
        Public Property TotalSales As Decimal
    End Class
    Public Class TableSalesSummary
        Public Property TableNumber As String
        Public Property TotalSales As Decimal
    End Class


    ' Declare chartData as IEnumerable(Of SalesSummary)
    Private chartData As IEnumerable(Of SalesSummary)

    Private Sub FrmPaymentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set defaults:
        dtpFromDate.Value = New DateTime(Now.Year, 1, 1)
        dtpToDate.Value = DateTime.Today


        ' Populate payment methods
        cmbPaymentMethod.Items.AddRange({"All", "Cash", "QR"})
        cmbPaymentMethod.SelectedIndex = 0
        cmbReportType.Items.AddRange({"By Payment Method", "By Table Number"})
        cmbReportType.SelectedIndex = 0

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim db As New BL_farizDataContext()
        Dim fromDate As DateTime = dtpFromDate.Value.Date
        Dim toDate As DateTime = dtpToDate.Value.Date

        If fromDate > toDate Then
            MessageBox.Show("From date cannot be later than To date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedMethod As String = cmbPaymentMethod.SelectedItem?.ToString()

        ' Filter payments by date range
        Dim filteredPayments = db.Payments.AsQueryable()
        filteredPayments = filteredPayments.Where(Function(p) _
        p.DateTime.HasValue AndAlso
        p.DateTime.Value.Date >= fromDate AndAlso
        p.DateTime.Value.Date <= toDate)

        ' Filter by payment method if needed
        If Not String.IsNullOrEmpty(selectedMethod) AndAlso selectedMethod <> "All" Then
            filteredPayments = filteredPayments.Where(Function(p) p.PaymentMethod = selectedMethod)
        End If

        ' No data case
        If Not filteredPayments.Any() Then
            chartData = New List(Of SalesSummary)()
            dgvReport.DataSource = Nothing
            lblTotalSales.Text = "Total Sales: RM 0.00"
            UpdateChart(chartData)
            MessageBox.Show("No data found for the selected date range.", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Get selected report type
        Dim selectedReportType As String = cmbReportType.SelectedItem?.ToString()

        If selectedReportType = "By Payment Method" Then
            ' Format for DataGridView
            Dim rawData = filteredPayments.
            Select(Function(p) New With {
                p.OrderID,
                p.PaymentMethod,
                p.AmountPaid,
                p.DateTime
            }).ToList()

            Dim reportData = rawData.
            Select(Function(p) New With {
                .OrderID = p.OrderID,
                .PaymentMethod = p.PaymentMethod,
                .AmountPaid = If(Nullable.Equals(p.AmountPaid, Nothing), 0D, p.AmountPaid),
                .DateTime = If(p.DateTime.HasValue, p.DateTime.Value.ToString("yyyy-MM-dd HH:mm"), "")
            }).ToList()

            dgvReport.DataSource = reportData

            ' Chart for payment method
            chartData = filteredPayments.
            GroupBy(Function(p) p.PaymentMethod).
            Select(Function(g) New SalesSummary With {
                .PaymentMethod = g.Key,
                .TotalSales = g.Sum(Function(p) p.AmountPaid)
            }).ToList()

            UpdateChart(chartData)

        ElseIf selectedReportType = "By Table Number" Then
            ' Join payment with order
            Dim tableData = (From p In filteredPayments
                             Join o In db.Orders On p.OrderID Equals o.OrderID
                             Group By TableNo = o.TableNo Into Group
                             Select New TableSalesSummary With {
                             .TableNumber = TableNo,
                             .TotalSales = Group.Sum(Function(x) x.p.AmountPaid)
                         }).ToList()

            dgvReport.DataSource = tableData

            ' Chart for table numbers
            salesChart.Series.Clear()
            Dim series = New DataVisualization.Charting.Series("Sales")
            series.ChartType = DataVisualization.Charting.SeriesChartType.Pie

            Dim total As Decimal = tableData.Sum(Function(t) t.TotalSales)
            For Each item In tableData
                Dim idx = series.Points.AddXY("Table " & item.TableNumber, item.TotalSales)
                Dim percent = (item.TotalSales / total) * 100
                series.Points(idx).Label = $"Table {item.TableNumber}: {percent:F1}%"
            Next

            salesChart.Series.Add(series)
            salesChart.Legends.Clear()
            salesChart.Legends.Add("Legend")
            salesChart.Legends("Legend").Docking = DataVisualization.Charting.Docking.Right
        End If

        ' Update total label
        Dim totalSales As Decimal = filteredPayments.Sum(Function(p) p.AmountPaid)
        lblTotalSales.Text = "Total Sales: RM " & totalSales.ToString("F2")
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
