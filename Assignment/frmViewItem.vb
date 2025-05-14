Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmViewItem
    Private printPageIndex As Integer = 0
    Private dt As New DataTable()

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmViewItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItemsToGrid()
    End Sub

    Private Sub LoadItemsToGrid()
        ' Load from database
        Dim items = From i In idb.Items
                    Order By i.Item_Category, i.Item_Name
                    Select i.Item_Id, i.Item_Name, i.Item_Category, i.Item_Description, i.Item_Quantity, i.Item_StockLvl, i.Item_Price
        dt = New DataTable()

        ' Add row numbers
        dt.Columns.Add("No", GetType(Integer))
        dt.Columns.Add("Item ID", GetType(String))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Category", GetType(String))
        dt.Columns.Add("Description", GetType(String))
        dt.Columns.Add("Quantity", GetType(Integer))
        dt.Columns.Add("Stock Level", GetType(String))
        dt.Columns.Add("Price", GetType(Decimal))

        Dim count As Integer = 1
        For Each item In items
            dt.Rows.Add(count, item.Item_Id, item.Item_Name, item.Item_Category, item.Item_Description, item.Item_Quantity, item.Item_StockLvl, item.Item_Price)
            count += 1
        Next

        dgvViewItems.DataSource = dt

        ' Formatting
        dgvViewItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvViewItems.ReadOnly = True
        dgvViewItems.AllowUserToAddRows = False
        dgvViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' Show total record count
        lblTotalRecords.Text = dgvViewItems.Rows.Count & " record(s)"

        With dgvViewItems
            .DefaultCellStyle.ForeColor = Color.DarkSlateBlue
            .DefaultCellStyle.BackColor = Color.AliceBlue
            .DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender

            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

            .EnableHeadersVisualStyles = False
        End With
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        printPageIndex = 0
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontHeader = New Font("Calibri", 30, FontStyle.Bold)
        Dim font = New Font("Calibri", 15)
        Dim yPos As Integer = 100
        Dim leftMargin = 50
        ' Define the indexes to skip
        Dim skipColumns As Integer() = {0, 4} ' Skip "No" and "Description"

        ' Title and logo
        With e.Graphics
            .DrawImage(My.Resources.BFLogo, leftMargin, 20, 100, 100)
            .DrawString("Item Stock List", fontHeader, Brushes.Black, 210, 40)
            .DrawString("Generated on: " & DateTime.Now.ToString(), font, Brushes.Black, 210, 90)
        End With
        yPos += 33

        ' Adjust for 8 columns
        Dim colWidths = {100, 200, 150, 110, 110, 80} ' Total width should fit page
        Dim colCount = colWidths.Length

        ' Print headers
        Dim x = leftMargin
        Dim visibleColIndex As Integer = 0
        For i = 0 To dt.Columns.Count - 1
            If Not skipColumns.Contains(i) Then
                e.Graphics.DrawString(dt.Columns(i).ColumnName, font, Brushes.Black, x, yPos)
                x += colWidths(visibleColIndex)
                visibleColIndex += 1
            End If
        Next
        ' Header line
        e.Graphics.DrawLine(New Pen(Brushes.Black), 50, 160, 780, 160)

        yPos += 30

        ' Print Data Rows
        While printPageIndex < dt.Rows.Count
            x = leftMargin
            visibleColIndex = 0
            Dim row = dt.Rows(printPageIndex)

            For i = 0 To dt.Columns.Count - 1
                If Not skipColumns.Contains(i) Then
                    Dim cellValue = If(row(i) IsNot Nothing, row(i).ToString(), "")
                    e.Graphics.DrawString(cellValue, font, Brushes.Black, x, yPos)
                    x += colWidths(visibleColIndex)
                    visibleColIndex += 1
                End If
            Next

            yPos += 30
            printPageIndex += 1

            If yPos > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                Return
            End If
        End While

            ' End of pages
            e.HasMorePages = False
        printPageIndex = 0 ' Reset for next print
    End Sub

End Class