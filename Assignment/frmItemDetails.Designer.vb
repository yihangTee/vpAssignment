<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemDetails))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblShowItemID = New System.Windows.Forms.Label()
        Me.lblShowItemName = New System.Windows.Forms.Label()
        Me.lblShowItemCategory = New System.Windows.Forms.Label()
        Me.lblShowItemPrice = New System.Windows.Forms.Label()
        Me.lblShowItemDescription = New System.Windows.Forms.Label()
        Me.lblShowItemStockLvl = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblShowItemQuantity = New System.Windows.Forms.Label()
        Me.picShowItemPicture = New Assignment.CirclePictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShowItemPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.btnBack)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(678, 150)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(153, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 84)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "BL-Fariz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Restaurant"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Assignment.My.Resources.Resources.Back
        Me.PictureBox2.Location = New System.Drawing.Point(608, 48)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.Location = New System.Drawing.Point(480, 48)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(127, 60)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.BFLogo
        Me.PictureBox1.Location = New System.Drawing.Point(14, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label2.Location = New System.Drawing.Point(109, 434)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 50)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Item ID : "
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label3.Location = New System.Drawing.Point(70, 498)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 50)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Item Name : "
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(86, 560)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 50)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Category : "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label5.Location = New System.Drawing.Point(80, 974)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 50)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Unit Price : "
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label6.Location = New System.Drawing.Point(63, 622)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 50)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Description : "
        '
        'lblShowItemID
        '
        Me.lblShowItemID.BackColor = System.Drawing.Color.GhostWhite
        Me.lblShowItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowItemID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowItemID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblShowItemID.Location = New System.Drawing.Point(263, 434)
        Me.lblShowItemID.Name = "lblShowItemID"
        Me.lblShowItemID.Size = New System.Drawing.Size(336, 50)
        Me.lblShowItemID.TabIndex = 19
        '
        'lblShowItemName
        '
        Me.lblShowItemName.BackColor = System.Drawing.Color.GhostWhite
        Me.lblShowItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowItemName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblShowItemName.Location = New System.Drawing.Point(263, 498)
        Me.lblShowItemName.Name = "lblShowItemName"
        Me.lblShowItemName.Size = New System.Drawing.Size(336, 50)
        Me.lblShowItemName.TabIndex = 20
        '
        'lblShowItemCategory
        '
        Me.lblShowItemCategory.BackColor = System.Drawing.Color.GhostWhite
        Me.lblShowItemCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowItemCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowItemCategory.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblShowItemCategory.Location = New System.Drawing.Point(263, 560)
        Me.lblShowItemCategory.Name = "lblShowItemCategory"
        Me.lblShowItemCategory.Size = New System.Drawing.Size(336, 50)
        Me.lblShowItemCategory.TabIndex = 21
        '
        'lblShowItemPrice
        '
        Me.lblShowItemPrice.BackColor = System.Drawing.Color.GhostWhite
        Me.lblShowItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowItemPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowItemPrice.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblShowItemPrice.Location = New System.Drawing.Point(263, 974)
        Me.lblShowItemPrice.Name = "lblShowItemPrice"
        Me.lblShowItemPrice.Size = New System.Drawing.Size(336, 50)
        Me.lblShowItemPrice.TabIndex = 22
        '
        'lblShowItemDescription
        '
        Me.lblShowItemDescription.BackColor = System.Drawing.Color.GhostWhite
        Me.lblShowItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowItemDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowItemDescription.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblShowItemDescription.Location = New System.Drawing.Point(263, 622)
        Me.lblShowItemDescription.Name = "lblShowItemDescription"
        Me.lblShowItemDescription.Size = New System.Drawing.Size(336, 212)
        Me.lblShowItemDescription.TabIndex = 23
        '
        'lblShowItemStockLvl
        '
        Me.lblShowItemStockLvl.BackColor = System.Drawing.Color.GhostWhite
        Me.lblShowItemStockLvl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowItemStockLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowItemStockLvl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblShowItemStockLvl.Location = New System.Drawing.Point(263, 849)
        Me.lblShowItemStockLvl.Name = "lblShowItemStockLvl"
        Me.lblShowItemStockLvl.Size = New System.Drawing.Size(336, 50)
        Me.lblShowItemStockLvl.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label7.Location = New System.Drawing.Point(63, 849)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 50)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Stock Level : "
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label8.Location = New System.Drawing.Point(96, 911)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 50)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Quantity : "
        '
        'lblShowItemQuantity
        '
        Me.lblShowItemQuantity.BackColor = System.Drawing.Color.GhostWhite
        Me.lblShowItemQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowItemQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowItemQuantity.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblShowItemQuantity.Location = New System.Drawing.Point(263, 911)
        Me.lblShowItemQuantity.Name = "lblShowItemQuantity"
        Me.lblShowItemQuantity.Size = New System.Drawing.Size(336, 50)
        Me.lblShowItemQuantity.TabIndex = 26
        '
        'picShowItemPicture
        '
        Me.picShowItemPicture.BackColor = System.Drawing.Color.AliceBlue
        Me.picShowItemPicture.Location = New System.Drawing.Point(244, 176)
        Me.picShowItemPicture.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picShowItemPicture.Name = "picShowItemPicture"
        Me.picShowItemPicture.Size = New System.Drawing.Size(208, 231)
        Me.picShowItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShowItemPicture.TabIndex = 18
        Me.picShowItemPicture.TabStop = False
        '
        'frmItemDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(673, 1050)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblShowItemQuantity)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblShowItemStockLvl)
        Me.Controls.Add(Me.lblShowItemDescription)
        Me.Controls.Add(Me.lblShowItemPrice)
        Me.Controls.Add(Me.lblShowItemCategory)
        Me.Controls.Add(Me.lblShowItemName)
        Me.Controls.Add(Me.lblShowItemID)
        Me.Controls.Add(Me.picShowItemPicture)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(695, 1174)
        Me.Name = "frmItemDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ItemStock - Item Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShowItemPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents picShowItemPicture As CirclePictureBox
    Friend WithEvents lblShowItemID As Label
    Friend WithEvents lblShowItemName As Label
    Friend WithEvents lblShowItemCategory As Label
    Friend WithEvents lblShowItemPrice As Label
    Friend WithEvents lblShowItemDescription As Label
    Friend WithEvents lblShowItemStockLvl As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblShowItemQuantity As Label
End Class
