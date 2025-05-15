
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO


Public Class FrmPaymentReport

    Public Class SalesSummary
        Public Property PaymentMethod As String
        Public Property TotalSales As Decimal
    End Class
    Public Class TableSalesSummary
        Public Property TableNumber As String
        Public Property TotalSales As Decimal
    End Class
    Private printDoc As New Printing.PrintDocument()
    Private dgvBitmap As Bitmap
    Private chartBitmap As Bitmap




    ' Declare chartData as IEnumerable(Of SalesSummary)
    Private chartData As IEnumerable(Of SalesSummary)

    Private Sub FrmPaymentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set defaults:
        dtpFromDate.Value = New DateTime(Now.Year, 1, 1)
        dtpToDate.Value = DateTime.Today

        ' Populate payment methods
        cmbPaymentMethod.Items.Clear()
        cmbPaymentMethod.Items.AddRange({"All", "Cash", "QR"})
        cmbPaymentMethod.SelectedIndex = 0

        cmbReportType.Items.Clear()
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

        ' Filter payments by date range AND successful status only
        Dim filteredPayments = db.Payments.AsQueryable()
        filteredPayments = filteredPayments.Where(Function(p) _
    p.DateTime.HasValue AndAlso
    p.DateTime.Value.Date >= fromDate AndAlso
    p.DateTime.Value.Date <= toDate AndAlso
    p.PaymentStatus = "Success")


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
            salesChart.Legends.Add("Legend") ' Custom name
            series.Legend = "Legend"         ' Tell series to use this legend
            salesChart.Legends("Legend").Docking = DataVisualization.Charting.Docking.Right
        End If

        ' Update total label
        Dim totalSales As Decimal = filteredPayments.Sum(Function(p) p.AmountPaid)
        lblTotalSales.Text = "Total Sales: RM " & totalSales.ToString("F2")
        With dgvReport
            .DefaultCellStyle.ForeColor = Color.DarkSlateBlue
            .DefaultCellStyle.BackColor = Color.AliceBlue
            .DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10, FontStyle.Regular)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender

            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
            .ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10, FontStyle.Bold)

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .EnableHeadersVisualStyles = False
            .RowTemplate.Height = 28
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .GridColor = Color.LightGray
        End With
    End Sub

    Private Sub UpdateChart(data As IEnumerable(Of SalesSummary))
        salesChart.Series.Clear()
        Dim series = New DataVisualization.Charting.Series("Sales")
        series.Legend = "Legend"
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub FieldGuidelineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldGuidelineToolStripMenuItem.Click
        MessageBox.Show(
        "PAYMENT REPORT SAFEGUARDS:" & vbCrLf & vbCrLf &
        "1. Generate Payment report by chosen start date to end date." & vbCrLf &
        "2. Click < Generate > Button to generate report and < Chart > switch to chart",
        "Payment Report Help",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        ' Capture DataGridView
        dgvBitmap = New Bitmap(dgvReport.Width, dgvReport.Height)
        dgvReport.DrawToBitmap(dgvBitmap, New System.Drawing.Rectangle(0, 0, dgvReport.Width, dgvReport.Height))

        ' Only capture chart if it has data
        If salesChart.Series.Count > 0 Then
            chartBitmap = New Bitmap(salesChart.Width, salesChart.Height)
            salesChart.DrawToBitmap(chartBitmap, New System.Drawing.Rectangle(0, 0, salesChart.Width, salesChart.Height))
        Else
            chartBitmap = Nothing
        End If

        ' Set up PrintDocument
        AddHandler printDoc.PrintPage, AddressOf PrintDoc_PrintPage

        ' Show Print Preview
        Dim printPreview As New PrintPreviewDialog()
        printPreview.Document = printDoc
        printPreview.Width = 800
        printPreview.Height = 600
        printPreview.ShowDialog()

        ' Clean up
        RemoveHandler printDoc.PrintPage, AddressOf PrintDoc_PrintPage
    End Sub


    Private Sub PrintDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim marginLeft As Integer = e.MarginBounds.Left
        Dim marginTop As Integer = e.MarginBounds.Top
        Dim availableWidth As Integer = e.MarginBounds.Width

        Dim headerFont As New System.Drawing.Font("Arial", 16, FontStyle.Bold)
        Dim headerText As String = "Payment Report"
        Dim headerRect As New System.Drawing.RectangleF(e.MarginBounds.Left, e.MarginBounds.Top - 40, e.MarginBounds.Width, 30)

        e.Graphics.DrawString(headerText, headerFont, Brushes.Black, headerRect, New StringFormat With {.Alignment = StringAlignment.Center})

        Dim yOffset As Integer = e.MarginBounds.Top + 10

        Dim dgvScale As Single = CSng(Math.Min(1.0F, availableWidth / dgvBitmap.Width))
        Dim dgvHeight As Integer = CInt(dgvBitmap.Height * dgvScale)

        ' Draw DataGridView
        e.Graphics.DrawImage(dgvBitmap, New System.Drawing.Rectangle(marginLeft, marginTop, CInt(dgvBitmap.Width * dgvScale), dgvHeight))

        ' Draw Chart only if it exists
        If chartBitmap IsNot Nothing Then
            Dim chartScale As Single = CSng(Math.Min(1.0F, availableWidth / chartBitmap.Width))
            Dim chartHeight As Integer = CInt(chartBitmap.Height * chartScale)
            Dim chartTop As Integer = marginTop + dgvHeight + 20
            e.Graphics.DrawImage(chartBitmap, New System.Drawing.Rectangle(marginLeft, chartTop, CInt(chartBitmap.Width * chartScale), chartHeight))
        End If

        ' Only one page needed
        e.HasMorePages = False
    End Sub



    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim saveFileDialog As New SaveFileDialog With {
    .Filter = "PDF Files (*.pdf)|*.pdf",
    .Title = "Save Report as PDF",
    .FileName = "SalesReport_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"
}


        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Step 1: Create a PDF document
                Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
                PdfWriter.GetInstance(doc, New FileStream(saveFileDialog.FileName, FileMode.Create))
                doc.Open()

                ' Step 2: Add a title
                Dim titleFont As iTextSharp.text.Font = FontFactory.GetFont("Helvetica", BaseFont.CP1252, BaseFont.NOT_EMBEDDED, 16.0F, iTextSharp.text.Font.BOLD)
                Dim titleParagraph As New Paragraph("Sales Report", titleFont) With {
                            .Alignment = Element.ALIGN_CENTER
                }
                doc.Add(titleParagraph)


                ' Step 3: Create the PdfPTable with correct number of columns
                Dim pdfTable As New PdfPTable(dgvReport.ColumnCount)
                pdfTable.WidthPercentage = 100
                pdfTable.HeaderRows = 1 ' So headers repeat if table spans pages

                ' Optional: Set column widths (proportional)
                ' pdfTable.SetWidths(New Single() {1, 2, 2, 2}) ' Example

                ' Step 4: Add column headers
                For Each col As DataGridViewColumn In dgvReport.Columns
                    Dim cell As New PdfPCell(New Phrase(col.HeaderText)) With {
                        .BackgroundColor = BaseColor.LIGHT_GRAY
                    }
                    pdfTable.AddCell(cell)
                Next

                ' Step 5: Add data rows
                For Each row As DataGridViewRow In dgvReport.Rows
                    If Not row.IsNewRow Then
                        For Each cell As DataGridViewCell In row.Cells
                            pdfTable.AddCell(If(cell.Value?.ToString(), ""))
                        Next
                    End If
                Next

                ' Step 6: Add the table to the document
                doc.Add(pdfTable)

                ' Optional: Add a chart image
                If salesChart.Series.Count > 0 Then
                    Dim chartImage As New Bitmap(salesChart.Width, salesChart.Height)
                    salesChart.DrawToBitmap(chartImage, New System.Drawing.Rectangle(0, 0, salesChart.Width, salesChart.Height))

                    Dim chartStream As New MemoryStream()
                    chartImage.Save(chartStream, Imaging.ImageFormat.Png)
                    Dim pdfChart As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(chartStream.ToArray())
                    pdfChart.ScaleToFit(500.0F, 300.0F)
                    pdfChart.Alignment = Element.ALIGN_CENTER
                    doc.Add(New Paragraph(" ")) ' Spacer
                    doc.Add(pdfChart)
                End If

                ' Step 7: Close the document
                doc.Close()

                MessageBox.Show("Report saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error exporting report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
