<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUserProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserProfile))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStaffReport = New System.Windows.Forms.Button()
        Me.btnViewStaff = New System.Windows.Forms.Button()
        Me.btnAddStaff = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillingPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FieldGuidelineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgStaff = New System.Windows.Forms.TabPage()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tpgOrder = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tpgBilling = New System.Windows.Forms.TabPage()
        Me.tpgItemStock = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpgStaff.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgOrder.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lavender
        Me.Label3.Location = New System.Drawing.Point(304, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Staff Name :"
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Lavender
        Me.lblID.Location = New System.Drawing.Point(141, 49)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(156, 31)
        Me.lblID.TabIndex = 6
        Me.lblID.Text = "XXX"
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Lavender
        Me.lblName.Location = New System.Drawing.Point(459, 49)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(289, 31)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "XXX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lavender
        Me.Label1.Location = New System.Drawing.Point(25, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 29)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Staff ID :"
        '
        'btnStaffReport
        '
        Me.btnStaffReport.BackColor = System.Drawing.Color.Navy
        Me.btnStaffReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffReport.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnStaffReport.Location = New System.Drawing.Point(549, 270)
        Me.btnStaffReport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStaffReport.Name = "btnStaffReport"
        Me.btnStaffReport.Size = New System.Drawing.Size(183, 70)
        Me.btnStaffReport.TabIndex = 23
        Me.btnStaffReport.Text = "&Generate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Staff Report" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnStaffReport.UseVisualStyleBackColor = False
        '
        'btnViewStaff
        '
        Me.btnViewStaff.BackColor = System.Drawing.Color.Navy
        Me.btnViewStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewStaff.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnViewStaff.Location = New System.Drawing.Point(296, 269)
        Me.btnViewStaff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnViewStaff.Name = "btnViewStaff"
        Me.btnViewStaff.Size = New System.Drawing.Size(177, 75)
        Me.btnViewStaff.TabIndex = 22
        Me.btnViewStaff.Text = "&View / Modication Staff"
        Me.btnViewStaff.UseVisualStyleBackColor = False
        '
        'btnAddStaff
        '
        Me.btnAddStaff.BackColor = System.Drawing.Color.Navy
        Me.btnAddStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStaff.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnAddStaff.Location = New System.Drawing.Point(48, 269)
        Me.btnAddStaff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddStaff.Name = "btnAddStaff"
        Me.btnAddStaff.Size = New System.Drawing.Size(170, 75)
        Me.btnAddStaff.TabIndex = 21
        Me.btnAddStaff.Text = "&Add Staff"
        Me.btnAddStaff.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.GhostWhite
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnLogout.Location = New System.Drawing.Point(601, 124)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(118, 51)
        Me.btnLogout.TabIndex = 20
        Me.btnLogout.Text = "&Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnLogout)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(795, 204)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.Logout
        Me.PictureBox1.Location = New System.Drawing.Point(726, 124)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label2.Location = New System.Drawing.Point(158, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 84)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "BL-Fariz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Restaurant"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Assignment.My.Resources.Resources.BFLogo
        Me.PictureBox3.Location = New System.Drawing.Point(12, 66)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(124, 138)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 23)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(789, 33)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffToolStripMenuItem, Me.OrderToolStripMenuItem, Me.BillingPaymentToolStripMenuItem, Me.ItemStockToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewStaffToolStripMenuItem, Me.ViewStaffToolStripMenuItem, Me.GenerateStaffToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(239, 34)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'AddNewStaffToolStripMenuItem
        '
        Me.AddNewStaffToolStripMenuItem.Name = "AddNewStaffToolStripMenuItem"
        Me.AddNewStaffToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddNewStaffToolStripMenuItem.Size = New System.Drawing.Size(409, 34)
        Me.AddNewStaffToolStripMenuItem.Text = "Add New Staff"
        '
        'ViewStaffToolStripMenuItem
        '
        Me.ViewStaffToolStripMenuItem.Name = "ViewStaffToolStripMenuItem"
        Me.ViewStaffToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ViewStaffToolStripMenuItem.Size = New System.Drawing.Size(409, 34)
        Me.ViewStaffToolStripMenuItem.Text = "View / Modication Staff"
        '
        'GenerateStaffToolStripMenuItem
        '
        Me.GenerateStaffToolStripMenuItem.Name = "GenerateStaffToolStripMenuItem"
        Me.GenerateStaffToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GenerateStaffToolStripMenuItem.Size = New System.Drawing.Size(409, 34)
        Me.GenerateStaffToolStripMenuItem.Text = "Generate Staff"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(409, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(239, 34)
        Me.OrderToolStripMenuItem.Text = "Order"
        '
        'BillingPaymentToolStripMenuItem
        '
        Me.BillingPaymentToolStripMenuItem.Name = "BillingPaymentToolStripMenuItem"
        Me.BillingPaymentToolStripMenuItem.Size = New System.Drawing.Size(239, 34)
        Me.BillingPaymentToolStripMenuItem.Text = "Billing & Payment"
        '
        'ItemStockToolStripMenuItem
        '
        Me.ItemStockToolStripMenuItem.Name = "ItemStockToolStripMenuItem"
        Me.ItemStockToolStripMenuItem.Size = New System.Drawing.Size(239, 34)
        Me.ItemStockToolStripMenuItem.Text = "Item Stock"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(239, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FieldGuidelineToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'FieldGuidelineToolStripMenuItem
        '
        Me.FieldGuidelineToolStripMenuItem.Name = "FieldGuidelineToolStripMenuItem"
        Me.FieldGuidelineToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.FieldGuidelineToolStripMenuItem.Size = New System.Drawing.Size(292, 34)
        Me.FieldGuidelineToolStripMenuItem.Text = "Field Guideline"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgStaff)
        Me.TabControl1.Controls.Add(Me.tpgOrder)
        Me.TabControl1.Controls.Add(Me.tpgBilling)
        Me.TabControl1.Controls.Add(Me.tpgItemStock)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(14, 342)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(770, 504)
        Me.TabControl1.TabIndex = 25
        '
        'tpgStaff
        '
        Me.tpgStaff.BackColor = System.Drawing.Color.GhostWhite
        Me.tpgStaff.Controls.Add(Me.PictureBox5)
        Me.tpgStaff.Controls.Add(Me.PictureBox4)
        Me.tpgStaff.Controls.Add(Me.PictureBox2)
        Me.tpgStaff.Controls.Add(Me.btnStaffReport)
        Me.tpgStaff.Controls.Add(Me.btnViewStaff)
        Me.tpgStaff.Controls.Add(Me.btnAddStaff)
        Me.tpgStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpgStaff.Location = New System.Drawing.Point(4, 38)
        Me.tpgStaff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpgStaff.Name = "tpgStaff"
        Me.tpgStaff.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpgStaff.Size = New System.Drawing.Size(762, 462)
        Me.tpgStaff.TabIndex = 0
        Me.tpgStaff.Text = "Staff"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Lavender
        Me.PictureBox5.Image = Global.Assignment.My.Resources.Resources.Report
        Me.PictureBox5.Location = New System.Drawing.Point(549, 91)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(183, 170)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 26
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Lavender
        Me.PictureBox4.Image = Global.Assignment.My.Resources.Resources.SearchUser
        Me.PictureBox4.Location = New System.Drawing.Point(296, 91)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(177, 170)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Lavender
        Me.PictureBox2.Image = Global.Assignment.My.Resources.Resources.AddUser
        Me.PictureBox2.Location = New System.Drawing.Point(42, 91)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(177, 170)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'tpgOrder
        '
        Me.tpgOrder.Controls.Add(Me.Button1)
        Me.tpgOrder.Location = New System.Drawing.Point(4, 38)
        Me.tpgOrder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpgOrder.Name = "tpgOrder"
        Me.tpgOrder.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpgOrder.Size = New System.Drawing.Size(762, 462)
        Me.tpgOrder.TabIndex = 1
        Me.tpgOrder.Text = "Order"
        Me.tpgOrder.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Navy
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button1.Location = New System.Drawing.Point(296, 190)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 75)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "&Add "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tpgBilling
        '
        Me.tpgBilling.Location = New System.Drawing.Point(4, 38)
        Me.tpgBilling.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpgBilling.Name = "tpgBilling"
        Me.tpgBilling.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpgBilling.Size = New System.Drawing.Size(762, 462)
        Me.tpgBilling.TabIndex = 2
        Me.tpgBilling.Text = "Billing & Payment"
        Me.tpgBilling.UseVisualStyleBackColor = True
        '
        'tpgItemStock
        '
        Me.tpgItemStock.Location = New System.Drawing.Point(4, 38)
        Me.tpgItemStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpgItemStock.Name = "tpgItemStock"
        Me.tpgItemStock.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpgItemStock.Size = New System.Drawing.Size(762, 462)
        Me.tpgItemStock.TabIndex = 3
        Me.tpgItemStock.Text = "Item Stock"
        Me.tpgItemStock.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblID)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Lavender
        Me.GroupBox2.Location = New System.Drawing.Point(12, 231)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(771, 104)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current user "
        '
        'FrmUserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(795, 861)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmUserProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpgStaff.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgOrder.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnViewStaff As Button
    Friend WithEvents btnAddStaff As Button
    Friend WithEvents btnStaffReport As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgStaff As TabPage
    Friend WithEvents tpgOrder As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tpgBilling As TabPage
    Friend WithEvents tpgItemStock As TabPage
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents StaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BillingPaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FieldGuidelineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
