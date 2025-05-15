Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Windows.Forms.DataVisualization.Charting

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
        Try
            Using bmp As New Bitmap(chartSales.Width, chartSales.Height)
                chartSales.DrawToBitmap(bmp, New System.Drawing.Rectangle(0, 0, chartSales.Width, chartSales.Height))
                e.Graphics.DrawImage(bmp, 50, 50)
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to print chart: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub FieldGuidelineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldGuidelineToolStripMenuItem.Click
        MessageBox.Show(
        "SALES REPORT SAFEGUARDS:" & vbCrLf & vbCrLf &
        "1. Generate report by its category and the type of chart." & vbCrLf &
        "2. User can print out the report if they want",
        "Sales Report Help",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PrintAsPDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintAsPDFToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "PDF Files (*.pdf)|*.pdf"
        sfd.FileName = $"SalesItemReport_{DateTime.Now:yyyyMMdd}.pdf"

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Using fs As New FileStream(sfd.FileName, FileMode.Create)
                    Dim doc As New Document(PageSize.A4.Rotate())
                    Dim writer = PdfWriter.GetInstance(doc, fs)
                    doc.Open()

                    Dim titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)
                    Dim normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10)

                    doc.Add(New Paragraph("Sales Report Chart", titleFont))
                    doc.Add(New Paragraph("Generated on: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm"), normalFont))
                    doc.Add(New Paragraph(" "))

                    Using chartImage As New MemoryStream()
                        chartSales.SaveImage(chartImage, ChartImageFormat.Png)
                        Dim chartImg As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(chartImage.ToArray())
                        chartImg.ScaleToFit(750.0F, 500.0F)
                        chartImg.Alignment = Element.ALIGN_CENTER
                        doc.Add(chartImg)
                    End Using

                    doc.Close()
                End Using

                MessageBox.Show("Chart exported to PDF successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Failed to export chart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class