<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrderHistory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvOrderHistory = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpHistoryDate = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvOrderHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblRecordCount)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.dgvOrderHistory)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpHistoryDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(53, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(958, 573)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order History"
        '
        'lblRecordCount
        '
        Me.lblRecordCount.Location = New System.Drawing.Point(29, 527)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(234, 29)
        Me.lblRecordCount.TabIndex = 4
        Me.lblRecordCount.Text = "X record (s)"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSearch.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSearch.Location = New System.Drawing.Point(807, 36)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(118, 45)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'dgvOrderHistory
        '
        Me.dgvOrderHistory.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvOrderHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvOrderHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrderHistory.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOrderHistory.Location = New System.Drawing.Point(29, 89)
        Me.dgvOrderHistory.Name = "dgvOrderHistory"
        Me.dgvOrderHistory.RowHeadersWidth = 62
        Me.dgvOrderHistory.RowTemplate.Height = 28
        Me.dgvOrderHistory.Size = New System.Drawing.Size(896, 431)
        Me.dgvOrderHistory.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Date : "
        '
        'dtpHistoryDate
        '
        Me.dtpHistoryDate.Location = New System.Drawing.Point(218, 36)
        Me.dtpHistoryDate.Name = "dtpHistoryDate"
        Me.dtpHistoryDate.Size = New System.Drawing.Size(200, 35)
        Me.dtpHistoryDate.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.BFLogo
        Me.PictureBox1.Location = New System.Drawing.Point(53, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(227, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(583, 53)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "BL-Fariz Restaurant"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnBack.Location = New System.Drawing.Point(848, 71)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(99, 45)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.Assignment.My.Resources.Resources.Back
        Me.PictureBox2.Location = New System.Drawing.Point(953, 71)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(58, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'FrmOrderHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1057, 728)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmOrderHistory"
        Me.Text = "FrmOrderHistory"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvOrderHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvOrderHistory As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpHistoryDate As DateTimePicker
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
