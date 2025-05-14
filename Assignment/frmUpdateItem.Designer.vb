<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateItem
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateItem))
        Me.mnuUpdateItem = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FieldGuidelineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpItemDetail2 = New System.Windows.Forms.GroupBox()
        Me.grpStockLevel = New System.Windows.Forms.GroupBox()
        Me.txtUpdateCustomStock = New System.Windows.Forms.TextBox()
        Me.radUpdateCustomStock = New System.Windows.Forms.RadioButton()
        Me.radUpdateLowStock = New System.Windows.Forms.RadioButton()
        Me.radUpdateMediumStock = New System.Windows.Forms.RadioButton()
        Me.radUpdateHighStock = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUpdateItemDescription = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUpdateItemPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboUpdateItemCategory = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpItemDetail1 = New System.Windows.Forms.GroupBox()
        Me.btnDeletePicture = New System.Windows.Forms.Button()
        Me.picUpdateItemPicture = New Assignment.CirclePictureBox()
        Me.mskUpdateItemID = New System.Windows.Forms.MaskedTextBox()
        Me.txtUpdateItemName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSnapPicture = New System.Windows.Forms.Button()
        Me.btnUploadPicture = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnUpdateClear = New System.Windows.Forms.Button()
        Me.btnUpdateSearch = New System.Windows.Forms.Button()
        Me.btnCancelUpdateItemInfo = New System.Windows.Forms.Button()
        Me.btnUpdateItemInfo = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.mskSearchUpdateItemId = New System.Windows.Forms.MaskedTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TakePictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdateItem.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItemDetail2.SuspendLayout()
        Me.grpStockLevel.SuspendLayout()
        Me.grpItemDetail1.SuspendLayout()
        CType(Me.picUpdateItemPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuUpdateItem
        '
        Me.mnuUpdateItem.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuUpdateItem.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuUpdateItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuUpdateItem.Location = New System.Drawing.Point(0, 0)
        Me.mnuUpdateItem.Name = "mnuUpdateItem"
        Me.mnuUpdateItem.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mnuUpdateItem.Size = New System.Drawing.Size(1217, 33)
        Me.mnuUpdateItem.TabIndex = 0
        Me.mnuUpdateItem.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(263, 34)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(263, 34)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(260, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(263, 34)
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.btnBack)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 35)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1217, 150)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(160, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 84)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "BL-Fariz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Restaurant"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Assignment.My.Resources.Resources.Back
        Me.PictureBox2.Location = New System.Drawing.Point(1146, 52)
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
        Me.btnBack.Location = New System.Drawing.Point(1017, 54)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(127, 60)
        Me.btnBack.TabIndex = 19
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
        'grpItemDetail2
        '
        Me.grpItemDetail2.Controls.Add(Me.grpStockLevel)
        Me.grpItemDetail2.Controls.Add(Me.Label8)
        Me.grpItemDetail2.Controls.Add(Me.txtUpdateItemDescription)
        Me.grpItemDetail2.Controls.Add(Me.Label7)
        Me.grpItemDetail2.Controls.Add(Me.txtUpdateItemPrice)
        Me.grpItemDetail2.Controls.Add(Me.Label6)
        Me.grpItemDetail2.Controls.Add(Me.cboUpdateItemCategory)
        Me.grpItemDetail2.Controls.Add(Me.Label5)
        Me.grpItemDetail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpItemDetail2.ForeColor = System.Drawing.Color.AliceBlue
        Me.grpItemDetail2.Location = New System.Drawing.Point(619, 438)
        Me.grpItemDetail2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpItemDetail2.Name = "grpItemDetail2"
        Me.grpItemDetail2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpItemDetail2.Size = New System.Drawing.Size(560, 601)
        Me.grpItemDetail2.TabIndex = 3
        Me.grpItemDetail2.TabStop = False
        Me.grpItemDetail2.Text = "Item Details 2"
        '
        'grpStockLevel
        '
        Me.grpStockLevel.Controls.Add(Me.txtUpdateCustomStock)
        Me.grpStockLevel.Controls.Add(Me.radUpdateCustomStock)
        Me.grpStockLevel.Controls.Add(Me.radUpdateLowStock)
        Me.grpStockLevel.Controls.Add(Me.radUpdateMediumStock)
        Me.grpStockLevel.Controls.Add(Me.radUpdateHighStock)
        Me.grpStockLevel.Location = New System.Drawing.Point(224, 362)
        Me.grpStockLevel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpStockLevel.Name = "grpStockLevel"
        Me.grpStockLevel.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpStockLevel.Size = New System.Drawing.Size(289, 231)
        Me.grpStockLevel.TabIndex = 17
        Me.grpStockLevel.TabStop = False
        '
        'txtUpdateCustomStock
        '
        Me.txtUpdateCustomStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtUpdateCustomStock.Location = New System.Drawing.Point(34, 189)
        Me.txtUpdateCustomStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUpdateCustomStock.MaxLength = 10
        Me.txtUpdateCustomStock.Name = "txtUpdateCustomStock"
        Me.txtUpdateCustomStock.ReadOnly = True
        Me.txtUpdateCustomStock.Size = New System.Drawing.Size(173, 32)
        Me.txtUpdateCustomStock.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.txtUpdateCustomStock, "Available when ""Others"" is selected")
        '
        'radUpdateCustomStock
        '
        Me.radUpdateCustomStock.AutoSize = True
        Me.radUpdateCustomStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.radUpdateCustomStock.Location = New System.Drawing.Point(7, 154)
        Me.radUpdateCustomStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radUpdateCustomStock.Name = "radUpdateCustomStock"
        Me.radUpdateCustomStock.Size = New System.Drawing.Size(129, 30)
        Me.radUpdateCustomStock.TabIndex = 15
        Me.radUpdateCustomStock.Text = "Others : "
        Me.radUpdateCustomStock.UseVisualStyleBackColor = True
        '
        'radUpdateLowStock
        '
        Me.radUpdateLowStock.AutoSize = True
        Me.radUpdateLowStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.radUpdateLowStock.Location = New System.Drawing.Point(7, 111)
        Me.radUpdateLowStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radUpdateLowStock.Name = "radUpdateLowStock"
        Me.radUpdateLowStock.Size = New System.Drawing.Size(175, 30)
        Me.radUpdateLowStock.TabIndex = 14
        Me.radUpdateLowStock.Text = "10 unit (Low)"
        Me.radUpdateLowStock.UseVisualStyleBackColor = True
        '
        'radUpdateMediumStock
        '
        Me.radUpdateMediumStock.AutoSize = True
        Me.radUpdateMediumStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radUpdateMediumStock.Location = New System.Drawing.Point(7, 68)
        Me.radUpdateMediumStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radUpdateMediumStock.Name = "radUpdateMediumStock"
        Me.radUpdateMediumStock.Size = New System.Drawing.Size(216, 30)
        Me.radUpdateMediumStock.TabIndex = 13
        Me.radUpdateMediumStock.Text = "30 unit (Medium)"
        Me.radUpdateMediumStock.UseVisualStyleBackColor = True
        '
        'radUpdateHighStock
        '
        Me.radUpdateHighStock.AutoSize = True
        Me.radUpdateHighStock.Checked = True
        Me.radUpdateHighStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radUpdateHighStock.Location = New System.Drawing.Point(7, 24)
        Me.radUpdateHighStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radUpdateHighStock.Name = "radUpdateHighStock"
        Me.radUpdateHighStock.Size = New System.Drawing.Size(181, 30)
        Me.radUpdateHighStock.TabIndex = 12
        Me.radUpdateHighStock.TabStop = True
        Me.radUpdateHighStock.Text = "50 unit (High)"
        Me.radUpdateHighStock.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label8.Location = New System.Drawing.Point(40, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 50)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Stock Level : "
        '
        'txtUpdateItemDescription
        '
        Me.txtUpdateItemDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtUpdateItemDescription.Location = New System.Drawing.Point(225, 201)
        Me.txtUpdateItemDescription.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUpdateItemDescription.MaxLength = 30
        Me.txtUpdateItemDescription.Multiline = True
        Me.txtUpdateItemDescription.Name = "txtUpdateItemDescription"
        Me.txtUpdateItemDescription.Size = New System.Drawing.Size(289, 153)
        Me.txtUpdateItemDescription.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.txtUpdateItemDescription, "Enter description of the item")
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label7.Location = New System.Drawing.Point(47, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 50)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Description : "
        '
        'txtUpdateItemPrice
        '
        Me.txtUpdateItemPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtUpdateItemPrice.Location = New System.Drawing.Point(224, 131)
        Me.txtUpdateItemPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUpdateItemPrice.MaxLength = 10
        Me.txtUpdateItemPrice.Name = "txtUpdateItemPrice"
        Me.txtUpdateItemPrice.Size = New System.Drawing.Size(173, 32)
        Me.txtUpdateItemPrice.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txtUpdateItemPrice, "Enter only numbers")
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label6.Location = New System.Drawing.Point(66, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 50)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Unit Price : "
        '
        'cboUpdateItemCategory
        '
        Me.cboUpdateItemCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cboUpdateItemCategory.FormattingEnabled = True
        Me.cboUpdateItemCategory.Items.AddRange(New Object() {"Roti Canai (RC)", "Main Dish (MD)", "Side Dish (SD)", "Hot Drink (HD)", "Cold Drink (CD)"})
        Me.cboUpdateItemCategory.Location = New System.Drawing.Point(224, 59)
        Me.cboUpdateItemCategory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboUpdateItemCategory.Name = "cboUpdateItemCategory"
        Me.cboUpdateItemCategory.Size = New System.Drawing.Size(275, 34)
        Me.cboUpdateItemCategory.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.cboUpdateItemCategory, "Select a Category")
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label5.Location = New System.Drawing.Point(73, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 50)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Category : "
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label2.Location = New System.Drawing.Point(20, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(490, 50)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Item Stock > Update Item Infomation"
        '
        'grpItemDetail1
        '
        Me.grpItemDetail1.Controls.Add(Me.btnDeletePicture)
        Me.grpItemDetail1.Controls.Add(Me.picUpdateItemPicture)
        Me.grpItemDetail1.Controls.Add(Me.mskUpdateItemID)
        Me.grpItemDetail1.Controls.Add(Me.txtUpdateItemName)
        Me.grpItemDetail1.Controls.Add(Me.Label4)
        Me.grpItemDetail1.Controls.Add(Me.Label3)
        Me.grpItemDetail1.Controls.Add(Me.btnSnapPicture)
        Me.grpItemDetail1.Controls.Add(Me.btnUploadPicture)
        Me.grpItemDetail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpItemDetail1.ForeColor = System.Drawing.Color.AliceBlue
        Me.grpItemDetail1.Location = New System.Drawing.Point(39, 438)
        Me.grpItemDetail1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpItemDetail1.Name = "grpItemDetail1"
        Me.grpItemDetail1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpItemDetail1.Size = New System.Drawing.Size(540, 601)
        Me.grpItemDetail1.TabIndex = 2
        Me.grpItemDetail1.TabStop = False
        Me.grpItemDetail1.Text = "Item Details 1"
        '
        'btnDeletePicture
        '
        Me.btnDeletePicture.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnDeletePicture.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnDeletePicture.Location = New System.Drawing.Point(363, 350)
        Me.btnDeletePicture.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDeletePicture.Name = "btnDeletePicture"
        Me.btnDeletePicture.Size = New System.Drawing.Size(130, 75)
        Me.btnDeletePicture.TabIndex = 6
        Me.btnDeletePicture.Text = "&Delete"
        Me.btnDeletePicture.UseVisualStyleBackColor = False
        '
        'picUpdateItemPicture
        '
        Me.picUpdateItemPicture.BackColor = System.Drawing.Color.AliceBlue
        Me.picUpdateItemPicture.Location = New System.Drawing.Point(174, 75)
        Me.picUpdateItemPicture.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picUpdateItemPicture.Name = "picUpdateItemPicture"
        Me.picUpdateItemPicture.Size = New System.Drawing.Size(202, 225)
        Me.picUpdateItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUpdateItemPicture.TabIndex = 11
        Me.picUpdateItemPicture.TabStop = False
        '
        'mskUpdateItemID
        '
        Me.mskUpdateItemID.Location = New System.Drawing.Point(217, 461)
        Me.mskUpdateItemID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mskUpdateItemID.Mask = "LL00000"
        Me.mskUpdateItemID.Name = "mskUpdateItemID"
        Me.mskUpdateItemID.Size = New System.Drawing.Size(129, 35)
        Me.mskUpdateItemID.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.mskUpdateItemID, "Enter a valid ID. (e.g. XX00000)")
        '
        'txtUpdateItemName
        '
        Me.txtUpdateItemName.Location = New System.Drawing.Point(217, 519)
        Me.txtUpdateItemName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUpdateItemName.MaxLength = 30
        Me.txtUpdateItemName.Name = "txtUpdateItemName"
        Me.txtUpdateItemName.Size = New System.Drawing.Size(249, 35)
        Me.txtUpdateItemName.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtUpdateItemName, "Enter Item's Name")
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(55, 522)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 50)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Item Name : "
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label3.Location = New System.Drawing.Point(96, 464)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 50)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Item ID : "
        '
        'btnSnapPicture
        '
        Me.btnSnapPicture.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSnapPicture.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSnapPicture.Location = New System.Drawing.Point(205, 350)
        Me.btnSnapPicture.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSnapPicture.Name = "btnSnapPicture"
        Me.btnSnapPicture.Size = New System.Drawing.Size(130, 75)
        Me.btnSnapPicture.TabIndex = 5
        Me.btnSnapPicture.Text = "&Snap"
        Me.btnSnapPicture.UseVisualStyleBackColor = False
        '
        'btnUploadPicture
        '
        Me.btnUploadPicture.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnUploadPicture.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnUploadPicture.Location = New System.Drawing.Point(45, 350)
        Me.btnUploadPicture.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUploadPicture.Name = "btnUploadPicture"
        Me.btnUploadPicture.Size = New System.Drawing.Size(130, 75)
        Me.btnUploadPicture.TabIndex = 4
        Me.btnUploadPicture.Text = "&Upload"
        Me.btnUploadPicture.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label9.Location = New System.Drawing.Point(381, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(220, 29)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Enter an Item ID : "
        '
        'btnUpdateClear
        '
        Me.btnUpdateClear.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnUpdateClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateClear.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnUpdateClear.Location = New System.Drawing.Point(618, 355)
        Me.btnUpdateClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdateClear.Name = "btnUpdateClear"
        Me.btnUpdateClear.Size = New System.Drawing.Size(130, 50)
        Me.btnUpdateClear.TabIndex = 3
        Me.btnUpdateClear.Text = "&Clear"
        Me.btnUpdateClear.UseVisualStyleBackColor = False
        '
        'btnUpdateSearch
        '
        Me.btnUpdateSearch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnUpdateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSearch.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnUpdateSearch.Location = New System.Drawing.Point(449, 355)
        Me.btnUpdateSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdateSearch.Name = "btnUpdateSearch"
        Me.btnUpdateSearch.Size = New System.Drawing.Size(130, 50)
        Me.btnUpdateSearch.TabIndex = 2
        Me.btnUpdateSearch.Text = "&Search"
        Me.btnUpdateSearch.UseVisualStyleBackColor = False
        '
        'btnCancelUpdateItemInfo
        '
        Me.btnCancelUpdateItemInfo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCancelUpdateItemInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelUpdateItemInfo.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnCancelUpdateItemInfo.Location = New System.Drawing.Point(619, 1081)
        Me.btnCancelUpdateItemInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelUpdateItemInfo.Name = "btnCancelUpdateItemInfo"
        Me.btnCancelUpdateItemInfo.Size = New System.Drawing.Size(130, 62)
        Me.btnCancelUpdateItemInfo.TabIndex = 18
        Me.btnCancelUpdateItemInfo.Text = "C&ancel"
        Me.btnCancelUpdateItemInfo.UseVisualStyleBackColor = False
        '
        'btnUpdateItemInfo
        '
        Me.btnUpdateItemInfo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnUpdateItemInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateItemInfo.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnUpdateItemInfo.Location = New System.Drawing.Point(459, 1081)
        Me.btnUpdateItemInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdateItemInfo.Name = "btnUpdateItemInfo"
        Me.btnUpdateItemInfo.Size = New System.Drawing.Size(130, 62)
        Me.btnUpdateItemInfo.TabIndex = 17
        Me.btnUpdateItemInfo.Text = "U&pdate"
        Me.btnUpdateItemInfo.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Snow
        '
        'mskSearchUpdateItemId
        '
        Me.mskSearchUpdateItemId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskSearchUpdateItemId.Location = New System.Drawing.Point(665, 294)
        Me.mskSearchUpdateItemId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mskSearchUpdateItemId.Mask = "LL00000"
        Me.mskSearchUpdateItemId.Name = "mskSearchUpdateItemId"
        Me.mskSearchUpdateItemId.Size = New System.Drawing.Size(124, 35)
        Me.mskSearchUpdateItemId.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.mskSearchUpdateItemId, "Enter Item's ID")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TakePictureToolStripMenuItem, Me.UploadImageToolStripMenuItem, Me.RemoveImageToolStripMenuItem, Me.ToolStripSeparator2, Me.ClearAllToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(204, 138)
        '
        'TakePictureToolStripMenuItem
        '
        Me.TakePictureToolStripMenuItem.Name = "TakePictureToolStripMenuItem"
        Me.TakePictureToolStripMenuItem.Size = New System.Drawing.Size(203, 32)
        Me.TakePictureToolStripMenuItem.Text = "Take Photo"
        '
        'UploadImageToolStripMenuItem
        '
        Me.UploadImageToolStripMenuItem.Name = "UploadImageToolStripMenuItem"
        Me.UploadImageToolStripMenuItem.Size = New System.Drawing.Size(203, 32)
        Me.UploadImageToolStripMenuItem.Text = "Upload Image"
        '
        'RemoveImageToolStripMenuItem
        '
        Me.RemoveImageToolStripMenuItem.Name = "RemoveImageToolStripMenuItem"
        Me.RemoveImageToolStripMenuItem.Size = New System.Drawing.Size(203, 32)
        Me.RemoveImageToolStripMenuItem.Text = "Remove Image"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(200, 6)
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(203, 32)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'frmUpdateItem
        '
        Me.AcceptButton = Me.btnUpdateSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(1213, 1050)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.mskSearchUpdateItemId)
        Me.Controls.Add(Me.btnCancelUpdateItemInfo)
        Me.Controls.Add(Me.btnUpdateItemInfo)
        Me.Controls.Add(Me.btnUpdateClear)
        Me.Controls.Add(Me.btnUpdateSearch)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.grpItemDetail2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grpItemDetail1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mnuUpdateItem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuUpdateItem
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(1235, 1236)
        Me.Name = "frmUpdateItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ItemStock - Update Item"
        Me.mnuUpdateItem.ResumeLayout(False)
        Me.mnuUpdateItem.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItemDetail2.ResumeLayout(False)
        Me.grpItemDetail2.PerformLayout()
        Me.grpStockLevel.ResumeLayout(False)
        Me.grpStockLevel.PerformLayout()
        Me.grpItemDetail1.ResumeLayout(False)
        Me.grpItemDetail1.PerformLayout()
        CType(Me.picUpdateItemPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuUpdateItem As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpItemDetail2 As GroupBox
    Friend WithEvents grpStockLevel As GroupBox
    Friend WithEvents txtUpdateCustomStock As TextBox
    Friend WithEvents radUpdateCustomStock As RadioButton
    Friend WithEvents radUpdateLowStock As RadioButton
    Friend WithEvents radUpdateMediumStock As RadioButton
    Friend WithEvents radUpdateHighStock As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUpdateItemDescription As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUpdateItemPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboUpdateItemCategory As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents grpItemDetail1 As GroupBox
    Friend WithEvents btnDeletePicture As Button
    Friend WithEvents mskUpdateItemID As MaskedTextBox
    Friend WithEvents txtUpdateItemName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSnapPicture As Button
    Friend WithEvents btnUploadPicture As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnUpdateClear As Button
    Friend WithEvents btnUpdateSearch As Button
    Friend WithEvents btnCancelUpdateItemInfo As Button
    Friend WithEvents btnUpdateItemInfo As Button
    Friend WithEvents picUpdateItemPicture As CirclePictureBox
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FieldGuidelineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TakePictureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UploadImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ClearAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mskSearchUpdateItemId As MaskedTextBox
End Class
