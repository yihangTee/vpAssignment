<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrder
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
        Me.grpCart = New System.Windows.Forms.GroupBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvOrder = New System.Windows.Forms.DataGridView()
        Me.lblTableNo = New System.Windows.Forms.Label()
        Me.lblOrderItem = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.flpMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpCart.SuspendLayout()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCart
        '
        Me.grpCart.BackColor = System.Drawing.SystemColors.Control
        Me.grpCart.Controls.Add(Me.lblTotalAmount)
        Me.grpCart.Controls.Add(Me.Label2)
        Me.grpCart.Controls.Add(Me.dgvOrder)
        Me.grpCart.Controls.Add(Me.lblTableNo)
        Me.grpCart.Controls.Add(Me.lblOrderItem)
        Me.grpCart.Controls.Add(Me.label1)
        Me.grpCart.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCart.Location = New System.Drawing.Point(28, 14)
        Me.grpCart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCart.Name = "grpCart"
        Me.grpCart.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCart.Size = New System.Drawing.Size(519, 645)
        Me.grpCart.TabIndex = 1
        Me.grpCart.TabStop = False
        Me.grpCart.Text = "Cart"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAmount.Location = New System.Drawing.Point(195, 562)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(182, 37)
        Me.lblTotalAmount.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(25, 562)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 37)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total Amount : "
        '
        'dgvOrder
        '
        Me.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrder.Location = New System.Drawing.Point(25, 126)
        Me.dgvOrder.Name = "dgvOrder"
        Me.dgvOrder.RowHeadersWidth = 62
        Me.dgvOrder.RowTemplate.Height = 28
        Me.dgvOrder.Size = New System.Drawing.Size(463, 400)
        Me.dgvOrder.TabIndex = 4
        '
        'lblTableNo
        '
        Me.lblTableNo.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableNo.Location = New System.Drawing.Point(141, 40)
        Me.lblTableNo.Name = "lblTableNo"
        Me.lblTableNo.Size = New System.Drawing.Size(155, 38)
        Me.lblTableNo.TabIndex = 3
        Me.lblTableNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrderItem
        '
        Me.lblOrderItem.AutoSize = True
        Me.lblOrderItem.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderItem.Location = New System.Drawing.Point(20, 88)
        Me.lblOrderItem.Name = "lblOrderItem"
        Me.lblOrderItem.Size = New System.Drawing.Size(125, 30)
        Me.lblOrderItem.TabIndex = 2
        Me.lblOrderItem.Text = "Order Item :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(39, 44)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(106, 30)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Table No :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'flpMenu
        '
        Me.flpMenu.Location = New System.Drawing.Point(553, 54)
        Me.flpMenu.Name = "flpMenu"
        Me.flpMenu.Size = New System.Drawing.Size(576, 509)
        Me.flpMenu.TabIndex = 2
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(654, 6)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(121, 28)
        Me.cmbCategory.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(553, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Category : "
        '
        'FrmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 699)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.flpMenu)
        Me.Controls.Add(Me.grpCart)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmOrder"
        Me.Text = "Order Page"
        Me.grpCart.ResumeLayout(False)
        Me.grpCart.PerformLayout()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCart As GroupBox
    Friend WithEvents lblOrderItem As Label
    Friend WithEvents label1 As Label
    Friend WithEvents lblTableNo As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvOrder As DataGridView
    Friend WithEvents flpMenu As FlowLayoutPanel
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label3 As Label
End Class
