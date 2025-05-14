<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSplitPayment
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
        Me.dgvItemsToSplit = New System.Windows.Forms.DataGridView()
        Me.lblTotalPay = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lbltotalPrice = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvItemsToSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvItemsToSplit
        '
        Me.dgvItemsToSplit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemsToSplit.Location = New System.Drawing.Point(31, 23)
        Me.dgvItemsToSplit.Name = "dgvItemsToSplit"
        Me.dgvItemsToSplit.RowHeadersWidth = 51
        Me.dgvItemsToSplit.RowTemplate.Height = 24
        Me.dgvItemsToSplit.Size = New System.Drawing.Size(746, 304)
        Me.dgvItemsToSplit.TabIndex = 0
        '
        'lblTotalPay
        '
        Me.lblTotalPay.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPay.Location = New System.Drawing.Point(406, 458)
        Me.lblTotalPay.Name = "lblTotalPay"
        Me.lblTotalPay.Size = New System.Drawing.Size(368, 42)
        Me.lblTotalPay.TabIndex = 13
        '
        'lblTax
        '
        Me.lblTax.Location = New System.Drawing.Point(422, 370)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(342, 30)
        Me.lblTax.TabIndex = 16
        '
        'lbltotalPrice
        '
        Me.lbltotalPrice.Location = New System.Drawing.Point(434, 340)
        Me.lbltotalPrice.Name = "lbltotalPrice"
        Me.lbltotalPrice.Size = New System.Drawing.Size(330, 30)
        Me.lbltotalPrice.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(105, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 54)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmSplitPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 498)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTotalPay)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lbltotalPrice)
        Me.Controls.Add(Me.dgvItemsToSplit)
        Me.Name = "FrmSplitPayment"
        Me.Text = "FrmSplitPayment"
        CType(Me.dgvItemsToSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvItemsToSplit As DataGridView
    Friend WithEvents lblTotalPay As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lbltotalPrice As Label
    Friend WithEvents Button1 As Button
End Class
