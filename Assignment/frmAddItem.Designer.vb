<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddItem
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddItem))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpItemDetail1 = New System.Windows.Forms.GroupBox()
        Me.picAddItemPicture = New Assignment.CirclePictureBox()
        Me.mskAddItemID = New System.Windows.Forms.MaskedTextBox()
        Me.txtAddItemName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSnapPicture = New System.Windows.Forms.Button()
        Me.btnUploadPicture = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpItemDetail2 = New System.Windows.Forms.GroupBox()
        Me.grpStockLevel = New System.Windows.Forms.GroupBox()
        Me.txtAddCustomStock = New System.Windows.Forms.TextBox()
        Me.radAddCustomStock = New System.Windows.Forms.RadioButton()
        Me.radAddLowStock = New System.Windows.Forms.RadioButton()
        Me.radAddMediumStock = New System.Windows.Forms.RadioButton()
        Me.radAddHighStock = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAddItemDescription = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAddItemPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboAddItemCategory = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnItemClear = New System.Windows.Forms.Button()
        Me.mnuAddItem = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SnapPictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FieldGuidelineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TakePictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItemDetail1.SuspendLayout()
        CType(Me.picAddItemPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItemDetail2.SuspendLayout()
        Me.grpStockLevel.SuspendLayout()
        Me.mnuAddItem.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.btnBack)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1182, 120)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(140, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 62)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "BL-Fariz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Restaurant"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Assignment.My.Resources.Resources.Back
        Me.PictureBox2.Location = New System.Drawing.Point(1128, 39)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
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
        Me.btnBack.Location = New System.Drawing.Point(1015, 40)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(113, 48)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.BFLogo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'grpItemDetail1
        '
        Me.grpItemDetail1.Controls.Add(Me.picAddItemPicture)
        Me.grpItemDetail1.Controls.Add(Me.mskAddItemID)
        Me.grpItemDetail1.Controls.Add(Me.txtAddItemName)
        Me.grpItemDetail1.Controls.Add(Me.Label4)
        Me.grpItemDetail1.Controls.Add(Me.Label3)
        Me.grpItemDetail1.Controls.Add(Me.btnSnapPicture)
        Me.grpItemDetail1.Controls.Add(Me.btnUploadPicture)
        Me.grpItemDetail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpItemDetail1.ForeColor = System.Drawing.Color.AliceBlue
        Me.grpItemDetail1.Location = New System.Drawing.Point(35, 224)
        Me.grpItemDetail1.Name = "grpItemDetail1"
        Me.grpItemDetail1.Size = New System.Drawing.Size(424, 481)
        Me.grpItemDetail1.TabIndex = 4
        Me.grpItemDetail1.TabStop = False
        Me.grpItemDetail1.Text = "Item Details 1"
        '
        'picAddItemPicture
        '
        Me.picAddItemPicture.BackColor = System.Drawing.Color.AliceBlue
        Me.picAddItemPicture.Location = New System.Drawing.Point(111, 75)
        Me.picAddItemPicture.Name = "picAddItemPicture"
        Me.picAddItemPicture.Size = New System.Drawing.Size(180, 180)
        Me.picAddItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAddItemPicture.TabIndex = 11
        Me.picAddItemPicture.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picAddItemPicture, "Upload or Snap an image for item")
        '
        'mskAddItemID
        '
        Me.mskAddItemID.Location = New System.Drawing.Point(170, 369)
        Me.mskAddItemID.Mask = "LL00000"
        Me.mskAddItemID.Name = "mskAddItemID"
        Me.mskAddItemID.Size = New System.Drawing.Size(109, 30)
        Me.mskAddItemID.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.mskAddItemID, "Enter a valid ID. (e.g. XX00000)")
        '
        'txtAddItemName
        '
        Me.txtAddItemName.Location = New System.Drawing.Point(170, 415)
        Me.txtAddItemName.MaxLength = 30
        Me.txtAddItemName.Name = "txtAddItemName"
        Me.txtAddItemName.Size = New System.Drawing.Size(222, 30)
        Me.txtAddItemName.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtAddItemName, "Enter Item's Name")
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(17, 418)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 40)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Item Name : "
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label3.Location = New System.Drawing.Point(53, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 40)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Item ID : "
        '
        'btnSnapPicture
        '
        Me.btnSnapPicture.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSnapPicture.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSnapPicture.Location = New System.Drawing.Point(226, 280)
        Me.btnSnapPicture.Name = "btnSnapPicture"
        Me.btnSnapPicture.Size = New System.Drawing.Size(116, 60)
        Me.btnSnapPicture.TabIndex = 2
        Me.btnSnapPicture.Text = "&Snap"
        Me.ToolTip1.SetToolTip(Me.btnSnapPicture, "Snap image by camera")
        Me.btnSnapPicture.UseVisualStyleBackColor = False
        '
        'btnUploadPicture
        '
        Me.btnUploadPicture.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnUploadPicture.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnUploadPicture.Location = New System.Drawing.Point(52, 280)
        Me.btnUploadPicture.Name = "btnUploadPicture"
        Me.btnUploadPicture.Size = New System.Drawing.Size(116, 60)
        Me.btnUploadPicture.TabIndex = 1
        Me.btnUploadPicture.Text = "&Upload"
        Me.ToolTip1.SetToolTip(Me.btnUploadPicture, "Upload image from local file")
        Me.btnUploadPicture.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label2.Location = New System.Drawing.Point(21, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(411, 40)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item Stock > Add New Item"
        '
        'grpItemDetail2
        '
        Me.grpItemDetail2.Controls.Add(Me.grpStockLevel)
        Me.grpItemDetail2.Controls.Add(Me.Label8)
        Me.grpItemDetail2.Controls.Add(Me.txtAddItemDescription)
        Me.grpItemDetail2.Controls.Add(Me.Label7)
        Me.grpItemDetail2.Controls.Add(Me.txtAddItemPrice)
        Me.grpItemDetail2.Controls.Add(Me.Label6)
        Me.grpItemDetail2.Controls.Add(Me.cboAddItemCategory)
        Me.grpItemDetail2.Controls.Add(Me.Label5)
        Me.grpItemDetail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpItemDetail2.ForeColor = System.Drawing.Color.AliceBlue
        Me.grpItemDetail2.Location = New System.Drawing.Point(495, 224)
        Me.grpItemDetail2.Name = "grpItemDetail2"
        Me.grpItemDetail2.Size = New System.Drawing.Size(498, 481)
        Me.grpItemDetail2.TabIndex = 5
        Me.grpItemDetail2.TabStop = False
        Me.grpItemDetail2.Text = "Item Details 2"
        '
        'grpStockLevel
        '
        Me.grpStockLevel.Controls.Add(Me.txtAddCustomStock)
        Me.grpStockLevel.Controls.Add(Me.radAddCustomStock)
        Me.grpStockLevel.Controls.Add(Me.radAddLowStock)
        Me.grpStockLevel.Controls.Add(Me.radAddMediumStock)
        Me.grpStockLevel.Controls.Add(Me.radAddHighStock)
        Me.grpStockLevel.Location = New System.Drawing.Point(204, 290)
        Me.grpStockLevel.Name = "grpStockLevel"
        Me.grpStockLevel.Size = New System.Drawing.Size(257, 185)
        Me.grpStockLevel.TabIndex = 8
        Me.grpStockLevel.TabStop = False
        '
        'txtAddCustomStock
        '
        Me.txtAddCustomStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtAddCustomStock.Location = New System.Drawing.Point(30, 151)
        Me.txtAddCustomStock.MaxLength = 10
        Me.txtAddCustomStock.Name = "txtAddCustomStock"
        Me.txtAddCustomStock.ReadOnly = True
        Me.txtAddCustomStock.Size = New System.Drawing.Size(154, 28)
        Me.txtAddCustomStock.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.txtAddCustomStock, "Available when ""Others"" is selected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enter number only")
        '
        'radAddCustomStock
        '
        Me.radAddCustomStock.AutoSize = True
        Me.radAddCustomStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.radAddCustomStock.Location = New System.Drawing.Point(6, 123)
        Me.radAddCustomStock.Name = "radAddCustomStock"
        Me.radAddCustomStock.Size = New System.Drawing.Size(111, 28)
        Me.radAddCustomStock.TabIndex = 11
        Me.radAddCustomStock.Text = "Others : "
        Me.radAddCustomStock.UseVisualStyleBackColor = True
        '
        'radAddLowStock
        '
        Me.radAddLowStock.AutoSize = True
        Me.radAddLowStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.radAddLowStock.Location = New System.Drawing.Point(6, 89)
        Me.radAddLowStock.Name = "radAddLowStock"
        Me.radAddLowStock.Size = New System.Drawing.Size(151, 28)
        Me.radAddLowStock.TabIndex = 10
        Me.radAddLowStock.Text = "10 unit (Low)"
        Me.radAddLowStock.UseVisualStyleBackColor = True
        '
        'radAddMediumStock
        '
        Me.radAddMediumStock.AutoSize = True
        Me.radAddMediumStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAddMediumStock.Location = New System.Drawing.Point(6, 54)
        Me.radAddMediumStock.Name = "radAddMediumStock"
        Me.radAddMediumStock.Size = New System.Drawing.Size(180, 26)
        Me.radAddMediumStock.TabIndex = 9
        Me.radAddMediumStock.Text = "30 unit (Medium)"
        Me.radAddMediumStock.UseVisualStyleBackColor = True
        '
        'radAddHighStock
        '
        Me.radAddHighStock.AutoSize = True
        Me.radAddHighStock.Checked = True
        Me.radAddHighStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAddHighStock.Location = New System.Drawing.Point(6, 19)
        Me.radAddHighStock.Name = "radAddHighStock"
        Me.radAddHighStock.Size = New System.Drawing.Size(153, 26)
        Me.radAddHighStock.TabIndex = 8
        Me.radAddHighStock.TabStop = True
        Me.radAddHighStock.Text = "50 unit (High)"
        Me.radAddHighStock.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label8.Location = New System.Drawing.Point(19, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 40)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Stock Level : "
        '
        'txtAddItemDescription
        '
        Me.txtAddItemDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtAddItemDescription.Location = New System.Drawing.Point(204, 161)
        Me.txtAddItemDescription.MaxLength = 5000
        Me.txtAddItemDescription.Multiline = True
        Me.txtAddItemDescription.Name = "txtAddItemDescription"
        Me.txtAddItemDescription.Size = New System.Drawing.Size(257, 123)
        Me.txtAddItemDescription.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtAddItemDescription, "Enter description of the item")
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label7.Location = New System.Drawing.Point(25, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 40)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Description : "
        '
        'txtAddItemPrice
        '
        Me.txtAddItemPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtAddItemPrice.Location = New System.Drawing.Point(204, 105)
        Me.txtAddItemPrice.MaxLength = 10
        Me.txtAddItemPrice.Name = "txtAddItemPrice"
        Me.txtAddItemPrice.Size = New System.Drawing.Size(154, 28)
        Me.txtAddItemPrice.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtAddItemPrice, "Enter only numbers")
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label6.Location = New System.Drawing.Point(42, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 40)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Unit Price : "
        '
        'cboAddItemCategory
        '
        Me.cboAddItemCategory.BackColor = System.Drawing.Color.Lavender
        Me.cboAddItemCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cboAddItemCategory.FormattingEnabled = True
        Me.cboAddItemCategory.Items.AddRange(New Object() {"Roti Canai (RC)", "Main Dish (MD)", "Side Dish (SD)", "Hot Drink (HD)", "Cold Drink (CD)"})
        Me.cboAddItemCategory.Location = New System.Drawing.Point(204, 47)
        Me.cboAddItemCategory.Name = "cboAddItemCategory"
        Me.cboAddItemCategory.Size = New System.Drawing.Size(245, 30)
        Me.cboAddItemCategory.TabIndex = 5
        Me.cboAddItemCategory.Text = "Select a Category"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label5.Location = New System.Drawing.Point(48, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 40)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Category : "
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddItem.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnAddItem.Location = New System.Drawing.Point(1024, 586)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(120, 46)
        Me.btnAddItem.TabIndex = 13
        Me.btnAddItem.Text = "&Add"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnItemClear
        '
        Me.btnItemClear.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnItemClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnItemClear.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnItemClear.Location = New System.Drawing.Point(1024, 653)
        Me.btnItemClear.Name = "btnItemClear"
        Me.btnItemClear.Size = New System.Drawing.Size(120, 46)
        Me.btnItemClear.TabIndex = 14
        Me.btnItemClear.Text = "&Clear"
        Me.btnItemClear.UseVisualStyleBackColor = False
        '
        'mnuAddItem
        '
        Me.mnuAddItem.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuAddItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuAddItem.Location = New System.Drawing.Point(0, 0)
        Me.mnuAddItem.Name = "mnuAddItem"
        Me.mnuAddItem.Size = New System.Drawing.Size(1182, 28)
        Me.mnuAddItem.TabIndex = 13
        Me.mnuAddItem.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ClearFormToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(255, 26)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'ClearFormToolStripMenuItem
        '
        Me.ClearFormToolStripMenuItem.Name = "ClearFormToolStripMenuItem"
        Me.ClearFormToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ClearFormToolStripMenuItem.Size = New System.Drawing.Size(255, 26)
        Me.ClearFormToolStripMenuItem.Text = "Clear Form"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(252, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(255, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SnapPictureToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'SnapPictureToolStripMenuItem
        '
        Me.SnapPictureToolStripMenuItem.Name = "SnapPictureToolStripMenuItem"
        Me.SnapPictureToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.SnapPictureToolStripMenuItem.Text = "Snap &Picture"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FieldGuidelineToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'FieldGuidelineToolStripMenuItem
        '
        Me.FieldGuidelineToolStripMenuItem.Name = "FieldGuidelineToolStripMenuItem"
        Me.FieldGuidelineToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.FieldGuidelineToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.FieldGuidelineToolStripMenuItem.Text = "Field Guideline"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TakePictureToolStripMenuItem, Me.UploadImageToolStripMenuItem, Me.ToolStripSeparator2, Me.ClearAllToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(174, 82)
        '
        'TakePictureToolStripMenuItem
        '
        Me.TakePictureToolStripMenuItem.Name = "TakePictureToolStripMenuItem"
        Me.TakePictureToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.TakePictureToolStripMenuItem.Text = "Take Photo"
        '
        'UploadImageToolStripMenuItem
        '
        Me.UploadImageToolStripMenuItem.Name = "UploadImageToolStripMenuItem"
        Me.UploadImageToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.UploadImageToolStripMenuItem.Text = "Upload Image"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(170, 6)
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Snow
        '
        'frmAddItem
        '
        Me.AcceptButton = Me.btnAddItem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.btnItemClear)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.grpItemDetail2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grpItemDetail1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mnuAddItem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1200, 800)
        Me.Name = "frmAddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ItemStock - Add Item"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItemDetail1.ResumeLayout(False)
        Me.grpItemDetail1.PerformLayout()
        CType(Me.picAddItemPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItemDetail2.ResumeLayout(False)
        Me.grpItemDetail2.PerformLayout()
        Me.grpStockLevel.ResumeLayout(False)
        Me.grpStockLevel.PerformLayout()
        Me.mnuAddItem.ResumeLayout(False)
        Me.mnuAddItem.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpItemDetail1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSnapPicture As Button
    Friend WithEvents btnUploadPicture As Button
    Friend WithEvents txtAddItemName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mskAddItemID As MaskedTextBox
    Friend WithEvents grpItemDetail2 As GroupBox
    Friend WithEvents cboAddItemCategory As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAddItemDescription As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAddItemPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents grpStockLevel As GroupBox
    Friend WithEvents radAddCustomStock As RadioButton
    Friend WithEvents radAddLowStock As RadioButton
    Friend WithEvents radAddMediumStock As RadioButton
    Friend WithEvents radAddHighStock As RadioButton
    Friend WithEvents txtAddCustomStock As TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnItemClear As Button
    Friend WithEvents picAddItemPicture As CirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mnuAddItem As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SnapPictureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TakePictureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UploadImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ClearAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents FieldGuidelineToolStripMenuItem As ToolStripMenuItem
End Class
