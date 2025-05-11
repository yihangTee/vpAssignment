<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrder))
        Me.grpCart = New System.Windows.Forms.GroupBox()
        Me.flpCart = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTableNo = New System.Windows.Forms.Label()
        Me.lblOrderItem = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.flpMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSendOrder = New System.Windows.Forms.Button()
        Me.btnGoToPayment = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PrintOrderList = New System.Drawing.Printing.PrintDocument()
        Me.OrderListPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.msOrderPage = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FieldGuidelineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpCart.SuspendLayout()
        Me.msOrderPage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCart
        '
        Me.grpCart.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.grpCart.Controls.Add(Me.flpCart)
        Me.grpCart.Controls.Add(Me.lblTotalAmount)
        Me.grpCart.Controls.Add(Me.Label2)
        Me.grpCart.Controls.Add(Me.lblTableNo)
        Me.grpCart.Controls.Add(Me.lblOrderItem)
        Me.grpCart.Controls.Add(Me.label1)
        Me.grpCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpCart.Location = New System.Drawing.Point(28, 39)
        Me.grpCart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCart.Name = "grpCart"
        Me.grpCart.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCart.Size = New System.Drawing.Size(519, 661)
        Me.grpCart.TabIndex = 1
        Me.grpCart.TabStop = False
        Me.grpCart.Text = "Cart"
        '
        'flpCart
        '
        Me.flpCart.AutoScroll = True
        Me.flpCart.Location = New System.Drawing.Point(25, 121)
        Me.flpCart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.flpCart.Name = "flpCart"
        Me.flpCart.Size = New System.Drawing.Size(470, 428)
        Me.flpCart.TabIndex = 7
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAmount.Location = New System.Drawing.Point(215, 562)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(182, 38)
        Me.lblTotalAmount.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(25, 562)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 38)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total Amount : "
        '
        'lblTableNo
        '
        Me.lblTableNo.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableNo.Location = New System.Drawing.Point(181, 39)
        Me.lblTableNo.Name = "lblTableNo"
        Me.lblTableNo.Size = New System.Drawing.Size(155, 38)
        Me.lblTableNo.TabIndex = 3
        Me.lblTableNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrderItem
        '
        Me.lblOrderItem.AutoSize = True
        Me.lblOrderItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderItem.Location = New System.Drawing.Point(20, 88)
        Me.lblOrderItem.Name = "lblOrderItem"
        Me.lblOrderItem.Size = New System.Drawing.Size(152, 29)
        Me.lblOrderItem.TabIndex = 2
        Me.lblOrderItem.Text = "Order Item :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(39, 44)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(136, 29)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Table No :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'flpMenu
        '
        Me.flpMenu.Location = New System.Drawing.Point(554, 93)
        Me.flpMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.flpMenu.Name = "flpMenu"
        Me.flpMenu.Size = New System.Drawing.Size(576, 548)
        Me.flpMenu.TabIndex = 2
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(707, 53)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(121, 28)
        Me.cmbCategory.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(554, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 42)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Category : "
        '
        'btnSendOrder
        '
        Me.btnSendOrder.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSendOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendOrder.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSendOrder.Location = New System.Drawing.Point(553, 654)
        Me.btnSendOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSendOrder.Name = "btnSendOrder"
        Me.btnSendOrder.Size = New System.Drawing.Size(175, 46)
        Me.btnSendOrder.TabIndex = 8
        Me.btnSendOrder.Text = "Send Order"
        Me.btnSendOrder.UseVisualStyleBackColor = False
        '
        'btnGoToPayment
        '
        Me.btnGoToPayment.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnGoToPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToPayment.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnGoToPayment.Location = New System.Drawing.Point(734, 654)
        Me.btnGoToPayment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGoToPayment.Name = "btnGoToPayment"
        Me.btnGoToPayment.Size = New System.Drawing.Size(139, 46)
        Me.btnGoToPayment.TabIndex = 9
        Me.btnGoToPayment.Text = "Payment"
        Me.btnGoToPayment.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnBack.Location = New System.Drawing.Point(984, 42)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 42)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PrintOrderList
        '
        '
        'OrderListPreviewDialog
        '
        Me.OrderListPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.OrderListPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.OrderListPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.OrderListPreviewDialog.Enabled = True
        Me.OrderListPreviewDialog.Icon = CType(resources.GetObject("OrderListPreviewDialog.Icon"), System.Drawing.Icon)
        Me.OrderListPreviewDialog.Name = "OrderListPreviewDialog"
        Me.OrderListPreviewDialog.Visible = False
        '
        'msOrderPage
        '
        Me.msOrderPage.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.msOrderPage.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.msOrderPage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.msOrderPage.Location = New System.Drawing.Point(0, 0)
        Me.msOrderPage.Name = "msOrderPage"
        Me.msOrderPage.Size = New System.Drawing.Size(1202, 33)
        Me.msOrderPage.TabIndex = 10
        Me.msOrderPage.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(215, 34)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(215, 34)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FieldGuidelineToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'FieldGuidelineToolStripMenuItem
        '
        Me.FieldGuidelineToolStripMenuItem.Name = "FieldGuidelineToolStripMenuItem"
        Me.FieldGuidelineToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.FieldGuidelineToolStripMenuItem.Size = New System.Drawing.Size(292, 34)
        Me.FieldGuidelineToolStripMenuItem.Text = "Field Guideline"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.Back
        Me.PictureBox1.Location = New System.Drawing.Point(1075, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'FrmOrder
        '
        Me.AcceptButton = Me.btnSendOrder
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1202, 727)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnGoToPayment)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSendOrder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.flpMenu)
        Me.Controls.Add(Me.grpCart)
        Me.Controls.Add(Me.msOrderPage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msOrderPage
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Page"
        Me.grpCart.ResumeLayout(False)
        Me.grpCart.PerformLayout()
        Me.msOrderPage.ResumeLayout(False)
        Me.msOrderPage.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpCart As GroupBox
    Friend WithEvents lblOrderItem As Label
    Friend WithEvents label1 As Label
    Friend WithEvents lblTableNo As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents flpMenu As FlowLayoutPanel
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSendOrder As Button
    Friend WithEvents flpCart As FlowLayoutPanel

    Friend WithEvents btnGoToPayment As Button

    Friend WithEvents btnBack As Button
    Friend WithEvents PrintOrderList As Printing.PrintDocument
    Friend WithEvents OrderListPreviewDialog As PrintPreviewDialog
    Friend WithEvents msOrderPage As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FieldGuidelineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
