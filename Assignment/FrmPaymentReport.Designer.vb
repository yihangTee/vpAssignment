<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaymentReport
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
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.cmbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.btnToggleChart = New System.Windows.Forms.Button()
        Me.salesChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.salesChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(43, 40)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(121, 24)
        Me.cmbMonth.TabIndex = 0
        '
        'cmbPaymentMethod
        '
        Me.cmbPaymentMethod.FormattingEnabled = True
        Me.cmbPaymentMethod.Location = New System.Drawing.Point(217, 40)
        Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
        Me.cmbPaymentMethod.Size = New System.Drawing.Size(121, 24)
        Me.cmbPaymentMethod.TabIndex = 1
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(394, 40)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(120, 31)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate report"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'dgvReport
        '
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(43, 86)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.RowHeadersWidth = 51
        Me.dgvReport.RowTemplate.Height = 24
        Me.dgvReport.Size = New System.Drawing.Size(708, 333)
        Me.dgvReport.TabIndex = 3
        '
        'btnToggleChart
        '
        Me.btnToggleChart.Location = New System.Drawing.Point(631, 36)
        Me.btnToggleChart.Name = "btnToggleChart"
        Me.btnToggleChart.Size = New System.Drawing.Size(120, 31)
        Me.btnToggleChart.TabIndex = 4
        Me.btnToggleChart.Text = "Chart"
        Me.btnToggleChart.UseVisualStyleBackColor = True
        '
        'salesChart
        '
        ChartArea2.Name = "ChartArea1"
        Me.salesChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.salesChart.Legends.Add(Legend2)
        Me.salesChart.Location = New System.Drawing.Point(43, 86)
        Me.salesChart.Name = "salesChart"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.salesChart.Series.Add(Series2)
        Me.salesChart.Size = New System.Drawing.Size(708, 333)
        Me.salesChart.TabIndex = 5
        Me.salesChart.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(481, 442)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 22)
        Me.Label1.TabIndex = 6
        '
        'lblTotalSales
        '
        Me.lblTotalSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.Location = New System.Drawing.Point(440, 441)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(311, 32)
        Me.lblTotalSales.TabIndex = 7
        '
        'FrmPaymentReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 497)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.salesChart)
        Me.Controls.Add(Me.btnToggleChart)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.cmbPaymentMethod)
        Me.Controls.Add(Me.cmbMonth)
        Me.Name = "FrmPaymentReport"
        Me.Text = "FrmPaymentReport"
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.salesChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents btnToggleChart As Button
    Friend WithEvents salesChart As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalSales As Label
End Class
