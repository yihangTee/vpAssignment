<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalesReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSalesReport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbItemType = New System.Windows.Forms.ComboBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.chartSales = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbChartType = New System.Windows.Forms.ComboBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.docSalesReport = New System.Drawing.Printing.PrintDocument()
        Me.srpPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.chartSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(73, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select item type : "
        '
        'cmbItemType
        '
        Me.cmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemType.FormattingEnabled = True
        Me.cmbItemType.Location = New System.Drawing.Point(205, 26)
        Me.cmbItemType.Name = "cmbItemType"
        Me.cmbItemType.Size = New System.Drawing.Size(140, 28)
        Me.cmbItemType.TabIndex = 1
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(340, 485)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(156, 37)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate Report"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'chartSales
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartSales.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartSales.Legends.Add(Legend2)
        Me.chartSales.Location = New System.Drawing.Point(77, 74)
        Me.chartSales.Name = "chartSales"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartSales.Series.Add(Series2)
        Me.chartSales.Size = New System.Drawing.Size(645, 405)
        Me.chartSales.TabIndex = 3
        Me.chartSales.Text = "Chart1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(365, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 27)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select Chart Type : "
        '
        'cmbChartType
        '
        Me.cmbChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChartType.FormattingEnabled = True
        Me.cmbChartType.Items.AddRange(New Object() {"Bar", "Column ", "Line", "Pie"})
        Me.cmbChartType.Location = New System.Drawing.Point(513, 26)
        Me.cmbChartType.Name = "cmbChartType"
        Me.cmbChartType.Size = New System.Drawing.Size(140, 28)
        Me.cmbChartType.TabIndex = 5
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(615, 485)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 37)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'docSalesReport
        '
        '
        'srpPreview
        '
        Me.srpPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.srpPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.srpPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.srpPreview.Enabled = True
        Me.srpPreview.Icon = CType(resources.GetObject("srpPreview.Icon"), System.Drawing.Icon)
        Me.srpPreview.Name = "srpPreview"
        Me.srpPreview.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(502, 485)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(107, 37)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'FrmSalesReport
        '
        Me.AcceptButton = Me.btnGenerate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 551)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.cmbChartType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chartSales)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.cmbItemType)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmSalesReport"
        Me.Text = "FrmSalesReport"
        CType(Me.chartSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbItemType As ComboBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents chartSales As DataVisualization.Charting.Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbChartType As ComboBox
    Friend WithEvents btnBack As Button
    Friend WithEvents docSalesReport As Printing.PrintDocument
    Friend WithEvents srpPreview As PrintPreviewDialog
    Friend WithEvents btnPrint As Button
End Class
