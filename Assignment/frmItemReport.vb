Imports System.Linq
Imports System.Drawing.Printing
Imports System.Drawing
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class frmItemReport
    Private printPageIndex As Integer
    Private printRowIndex As Integer = 0 ' Reset this when starting a new print job
    Dim dt As DataTable

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmItemReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear the form for every time it loads
        ResetControl()
    End Sub

    Private Sub cboItemReportCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItemReportCategory.SelectedIndexChanged
        If cboItemReportCategory.SelectedIndex <> -1 Then
            ' Clear stock level to avoid double-filtering
            cboItemReportStockLvl.SelectedIndex = -1
            FilterByCategory()
        End If
    End Sub

    Private Sub cboItemReportStockLvl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItemReportStockLvl.SelectedIndexChanged
        If cboItemReportStockLvl.SelectedIndex <> -1 Then
            ' Clear category to avoid double-filtering
            cboItemReportCategory.SelectedIndex = -1
            FilterByStockLevel()
        End If
    End Sub

    Private Sub FilterByCategory()
        Dim category = cboItemReportCategory.SelectedItem.ToString()
        Dim result = idb.Items.Where(Function(i) i.Item_Category = category).ToList()
        DisplayResults(result)
    End Sub

    Private Sub FilterByStockLevel()
        Dim stockLvl = cboItemReportStockLvl.SelectedItem.ToString()
        Dim result = idb.Items.Where(Function(i) i.Item_StockLvl = stockLvl).ToList()
        DisplayResults(result)
    End Sub

    Private Sub DisplayResults(result As List(Of Item))
        dt = ConvertToDataTable(result)
        With dgvItemReport
            .DataSource = dt
            .AllowUserToAddRows = False
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            .DefaultCellStyle.ForeColor = Color.DarkSlateBlue
            .DefaultCellStyle.BackColor = Color.AliceBlue
            .DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10, FontStyle.Regular)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
            .ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10, FontStyle.Bold)
            .EnableHeadersVisualStyles = False
        End With
        lblReportTotalRecord.Text = $"{dt.Rows.Count} record(s)"
    End Sub

    Private Sub btnReportClear_Click(sender As Object, e As EventArgs) Handles btnReportClear.Click, ClearToolStripMenuItem.Click
        ResetControl()
    End Sub

    Private Function ConvertToDataTable(items As List(Of Item)) As DataTable
        Dim table As New DataTable()
        table.Columns.Add("Item ID")
        table.Columns.Add("Name")
        table.Columns.Add("Category")
        table.Columns.Add("Stock Level")
        table.Columns.Add("Quantity")
        table.Columns.Add("Price")

        For Each item In items
            table.Rows.Add(item.Item_Id, item.Item_Name, item.Item_Category, item.Item_StockLvl, item.Item_Quantity, item.Item_Price)
        Next

        Return table
    End Function

    Private Sub btnPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintReport.Click, PrintToolStripMenuItem.Click
        If dgvItemReport.Rows.Count = 0 OrElse dgvItemReport.Rows(0).IsNewRow Then
            MessageBox.Show("No data to print.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        printPageIndex = 0
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontHeader = New System.Drawing.Font("Calibri", 30, FontStyle.Bold)
        Dim font = New System.Drawing.Font("Calibri", 15)
        Dim yPos As Integer = 100
        Dim leftMargin = 50

        ' Title
        With e.Graphics
            .DrawImage(My.Resources.BFLogo, leftMargin, 20, 100, 100) ' Adjust logo size
            .DrawString("Item Report", fontHeader, Brushes.Black, 210, 40)
            .DrawString("Generated on: " & DateTime.Now.ToString(), font, Brushes.Black, 210, 90)
        End With
        yPos += 30

        ' Headers - Use actual DataGridView column count
        Dim colCount = dgvItemReport.Columns.Count
        Dim colWidths = {100, 200, 150, 120, 100, 80} ' Adjust to match your DGV

        ' Print headers
        Dim x = leftMargin
        For i = 0 To colCount - 1
            e.Graphics.DrawString(dgvItemReport.Columns(i).HeaderText, font, Brushes.Black, x, yPos)
            x += colWidths(i)
            e.Graphics.DrawLine(New Pen(Brushes.Black), 50, 160, 800, 160) ' Header line
        Next

        yPos += 30

        ' Print DataGridView rows
        While printPageIndex < dt.Rows.Count
            x = leftMargin
            Dim row = dt.Rows(printPageIndex)

            For i = 0 To colCount - 1
                Dim cellValue = If(row(i) IsNot Nothing, row(i).ToString(), "")
                e.Graphics.DrawString(cellValue, font, Brushes.Black, x, yPos)
                x += colWidths(i)
            Next

            yPos += 30
            printPageIndex += 1

            If yPos > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                Return
            End If
        End While
    End Sub

    Private Sub btnExportReportPDF_Click(sender As Object, e As EventArgs) Handles btnExportReportPDF.Click, ExportPDFToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "PDF Files (*.pdf)|*.pdf"
        sfd.FileName = $"ItemReport_{DateTime.Now:yyyyMMdd}.pdf"

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Using fs As New FileStream(sfd.FileName, FileMode.Create)
                    Dim doc As New Document(PageSize.A4.Rotate()) ' Landscape, without this line will be default to portrait
                    Dim writer = PdfWriter.GetInstance(doc, fs)
                    doc.Open()

                    ' Header with logo and text 
                    ' Convert logo to iTextSharp image
                    Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(My.Resources.BFLogo, Imaging.ImageFormat.Png)
                    logo.ScaleAbsolute(60, 60)

                    Dim headerTable As New PdfPTable(2)
                    headerTable.WidthPercentage = 100
                    headerTable.SetWidths(New Single() {1.0F, 4.0F}) ' Logo vs text

                    ' Logo cell
                    Dim logoCell As New PdfPCell(logo)
                    logoCell.Border = iTextSharp.text.Rectangle.NO_BORDER
                    logoCell.Rowspan = 3
                    headerTable.AddCell(logoCell)

                    ' Text cell
                    Dim titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)
                    Dim normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10)

                    Dim textCell As New PdfPCell()
                    textCell.Border = iTextSharp.text.Rectangle.NO_BORDER
                    textCell.AddElement(New Paragraph("Item Stock Report", titleFont))
                    textCell.AddElement(New Paragraph("Generated on: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm"), normalFont))

                    Dim filters As String = ""
                    If Not String.IsNullOrWhiteSpace(cboItemReportCategory.Text) Then
                        filters = cboItemReportCategory.Text
                    End If
                    If Not String.IsNullOrWhiteSpace(cboItemReportStockLvl.Text) Then
                        If filters <> "" Then
                            filters &= ", "
                        End If
                        filters &= cboItemReportStockLvl.Text
                    End If
                    If filters <> "" Then
                        textCell.AddElement(New Paragraph($"Filters: {filters}", normalFont))
                    End If

                    headerTable.AddCell(textCell)
                    doc.Add(headerTable)
                    doc.Add(New Paragraph(" ")) ' Spacer
                    ' End Header 

                    ' Table with DataGridView data
                    Dim pdfTable As New PdfPTable(dgvItemReport.Columns.Count)
                    pdfTable.WidthPercentage = 100

                    ' Add column headers
                    For Each col As DataGridViewColumn In dgvItemReport.Columns
                        pdfTable.AddCell(New Phrase(col.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD)))
                    Next

                    ' Add rows
                    For Each row As DataGridViewRow In dgvItemReport.Rows
                        If Not row.IsNewRow Then
                            For Each cell As DataGridViewCell In row.Cells
                                Dim cellValue As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                                pdfTable.AddCell(New Phrase(cellValue))
                            Next
                        End If
                    Next

                    doc.Add(pdfTable)
                    doc.Add(New Paragraph($"Total Records: {lblReportTotalRecord.Text}", normalFont))
                    doc.Close()
                End Using

                MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Failed to export PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ResetControl()
        cboItemReportCategory.SelectedIndex = -1
        cboItemReportStockLvl.SelectedIndex = -1
        dgvItemReport.DataSource = Nothing
        lblReportTotalRecord.Text = "X record(s)"
    End Sub

    Private Sub FieldGuidelineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldGuidelineToolStripMenuItem.Click
        MessageBox.Show(
        "REPORT GENERATION TIPS:" & vbCrLf & vbCrLf &
        "1. Select a category or stock level to filter items." & vbCrLf &
        "2. The filtered items' records will be auto-generated." & vbCrLf &
        "3. Click 'Print' to preview the report." & vbCrLf &
        "4. Click 'Export' to save the report in PDF format." & vbCrLf &
        "5. Use the 'Clear' button to reset the filters.",
        "Export Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class