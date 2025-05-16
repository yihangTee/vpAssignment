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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSplitPayment))
        Me.dgvItemsToSplit = New System.Windows.Forms.DataGridView()
        Me.lblTotalPay = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lbltotalPrice = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuidlinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvItemsToSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvItemsToSplit
        '
        Me.dgvItemsToSplit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemsToSplit.Location = New System.Drawing.Point(32, 41)
        Me.dgvItemsToSplit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvItemsToSplit.Name = "dgvItemsToSplit"
        Me.dgvItemsToSplit.RowHeadersWidth = 51
        Me.dgvItemsToSplit.RowTemplate.Height = 24
        Me.dgvItemsToSplit.Size = New System.Drawing.Size(839, 380)
        Me.dgvItemsToSplit.TabIndex = 0
        '
        'lblTotalPay
        '
        Me.lblTotalPay.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPay.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lblTotalPay.Location = New System.Drawing.Point(444, 558)
        Me.lblTotalPay.Name = "lblTotalPay"
        Me.lblTotalPay.Size = New System.Drawing.Size(414, 52)
        Me.lblTotalPay.TabIndex = 13
        '
        'lblTax
        '
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lblTax.Location = New System.Drawing.Point(486, 476)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(385, 38)
        Me.lblTax.TabIndex = 16
        '
        'lbltotalPrice
        '
        Me.lbltotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalPrice.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lbltotalPrice.Location = New System.Drawing.Point(500, 439)
        Me.lbltotalPrice.Name = "lbltotalPrice"
        Me.lbltotalPrice.Size = New System.Drawing.Size(371, 38)
        Me.lbltotalPrice.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button1.Location = New System.Drawing.Point(151, 439)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 68)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 33)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuidlinesToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'GuidlinesToolStripMenuItem
        '
        Me.GuidlinesToolStripMenuItem.Name = "GuidlinesToolStripMenuItem"
        Me.GuidlinesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GuidlinesToolStripMenuItem.Size = New System.Drawing.Size(249, 34)
        Me.GuidlinesToolStripMenuItem.Text = "Guidlines"
        '
        'FrmSplitPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 622)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTotalPay)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lbltotalPrice)
        Me.Controls.Add(Me.dgvItemsToSplit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmSplitPayment"
        Me.Text = "FrmSplitPayment"
        CType(Me.dgvItemsToSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvItemsToSplit As DataGridView
    Friend WithEvents lblTotalPay As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lbltotalPrice As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuidlinesToolStripMenuItem As ToolStripMenuItem
End Class
