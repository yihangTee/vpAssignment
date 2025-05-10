<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrderDetails
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTableNo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.dgvOrderedItems = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOrderDate = New System.Windows.Forms.Label()
        CType(Me.dgvOrderedItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(61, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Table No : "
        '
        'lblTableNo
        '
        Me.lblTableNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTableNo.Location = New System.Drawing.Point(172, 66)
        Me.lblTableNo.Name = "lblTableNo"
        Me.lblTableNo.Size = New System.Drawing.Size(127, 29)
        Me.lblTableNo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(61, 560)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 48)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total Amount : "
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAmount.Location = New System.Drawing.Point(226, 560)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(127, 29)
        Me.lblTotalAmount.TabIndex = 3
        '
        'dgvOrderedItems
        '
        Me.dgvOrderedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderedItems.Location = New System.Drawing.Point(65, 118)
        Me.dgvOrderedItems.Name = "dgvOrderedItems"
        Me.dgvOrderedItems.RowHeadersWidth = 62
        Me.dgvOrderedItems.RowTemplate.Height = 28
        Me.dgvOrderedItems.Size = New System.Drawing.Size(618, 391)
        Me.dgvOrderedItems.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(422, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 28)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Order Date : "
        '
        'lblOrderDate
        '
        Me.lblOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrderDate.Location = New System.Drawing.Point(555, 66)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(127, 29)
        Me.lblOrderDate.TabIndex = 6
        '
        'FrmOrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 705)
        Me.Controls.Add(Me.lblOrderDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvOrderedItems)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTableNo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmOrderDetails"
        Me.Text = "FrmOrderDetails"
        CType(Me.dgvOrderedItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTableNo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents dgvOrderedItems As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents lblOrderDate As Label
End Class
