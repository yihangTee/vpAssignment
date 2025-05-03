<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrackItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrackItem))
        Me.mnuTrackItem = New System.Windows.Forms.MenuStrip()
        Me.mnuTrackItemFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTrackItemHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.FieldGuidelineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnTrackClear = New System.Windows.Forms.Button()
        Me.btnTrackSearch = New System.Windows.Forms.Button()
        Me.cboTrackStockLvl = New System.Windows.Forms.ComboBox()
        Me.lblTrackStockLvl = New System.Windows.Forms.Label()
        Me.cboTrackCategory = New System.Windows.Forms.ComboBox()
        Me.lblTrackCategory = New System.Windows.Forms.Label()
        Me.txtTrackName = New System.Windows.Forms.TextBox()
        Me.mskTrackID = New System.Windows.Forms.MaskedTextBox()
        Me.lblTrackName = New System.Windows.Forms.Label()
        Me.lblTrackID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboTrackAspect = New System.Windows.Forms.ComboBox()
        Me.tipTrackItem = New System.Windows.Forms.ToolTip(Me.components)
        Me.errTrackItem = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.mnuTrackItem.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.errTrackItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuTrackItem
        '
        Me.mnuTrackItem.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuTrackItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTrackItemFile, Me.mnuTrackItemHelp})
        Me.mnuTrackItem.Location = New System.Drawing.Point(0, 0)
        Me.mnuTrackItem.Name = "mnuTrackItem"
        Me.mnuTrackItem.Size = New System.Drawing.Size(782, 28)
        Me.mnuTrackItem.TabIndex = 0
        Me.mnuTrackItem.Text = "MenuStrip1"
        '
        'mnuTrackItemFile
        '
        Me.mnuTrackItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.mnuTrackItemFile.Name = "mnuTrackItemFile"
        Me.mnuTrackItemFile.Size = New System.Drawing.Size(46, 24)
        Me.mnuTrackItemFile.Text = "&File"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(214, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'mnuTrackItemHelp
        '
        Me.mnuTrackItemHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FieldGuidelineToolStripMenuItem})
        Me.mnuTrackItemHelp.Name = "mnuTrackItemHelp"
        Me.mnuTrackItemHelp.Size = New System.Drawing.Size(55, 24)
        Me.mnuTrackItemHelp.Text = "&Help"
        '
        'FieldGuidelineToolStripMenuItem
        '
        Me.FieldGuidelineToolStripMenuItem.Name = "FieldGuidelineToolStripMenuItem"
        Me.FieldGuidelineToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.FieldGuidelineToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.FieldGuidelineToolStripMenuItem.Text = "Field Guideline"
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
        Me.GroupBox1.Size = New System.Drawing.Size(782, 120)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(136, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 62)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "BL-Fariz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Restaurant"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Assignment.My.Resources.Resources.Back
        Me.PictureBox2.Location = New System.Drawing.Point(723, 44)
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
        Me.btnBack.Location = New System.Drawing.Point(610, 45)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(113, 48)
        Me.btnBack.TabIndex = 3
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label2.Location = New System.Drawing.Point(123, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(537, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "You're now tracking the Item Stock List"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cboTrackAspect)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Location = New System.Drawing.Point(54, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(672, 342)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Track - By Aspect"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnTrackClear)
        Me.GroupBox3.Controls.Add(Me.btnTrackSearch)
        Me.GroupBox3.Controls.Add(Me.cboTrackStockLvl)
        Me.GroupBox3.Controls.Add(Me.lblTrackStockLvl)
        Me.GroupBox3.Controls.Add(Me.cboTrackCategory)
        Me.GroupBox3.Controls.Add(Me.lblTrackCategory)
        Me.GroupBox3.Controls.Add(Me.txtTrackName)
        Me.GroupBox3.Controls.Add(Me.mskTrackID)
        Me.GroupBox3.Controls.Add(Me.lblTrackName)
        Me.GroupBox3.Controls.Add(Me.lblTrackID)
        Me.GroupBox3.Location = New System.Drawing.Point(49, 118)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(567, 188)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'btnTrackClear
        '
        Me.btnTrackClear.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnTrackClear.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnTrackClear.Location = New System.Drawing.Point(304, 106)
        Me.btnTrackClear.Name = "btnTrackClear"
        Me.btnTrackClear.Size = New System.Drawing.Size(116, 50)
        Me.btnTrackClear.TabIndex = 22
        Me.btnTrackClear.Text = "&Clear"
        Me.btnTrackClear.UseVisualStyleBackColor = False
        '
        'btnTrackSearch
        '
        Me.btnTrackSearch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnTrackSearch.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnTrackSearch.Location = New System.Drawing.Point(154, 106)
        Me.btnTrackSearch.Name = "btnTrackSearch"
        Me.btnTrackSearch.Size = New System.Drawing.Size(116, 50)
        Me.btnTrackSearch.TabIndex = 11
        Me.btnTrackSearch.Text = "&Search"
        Me.btnTrackSearch.UseVisualStyleBackColor = False
        '
        'cboTrackStockLvl
        '
        Me.cboTrackStockLvl.BackColor = System.Drawing.Color.AliceBlue
        Me.cboTrackStockLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cboTrackStockLvl.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.cboTrackStockLvl.FormattingEnabled = True
        Me.cboTrackStockLvl.Items.AddRange(New Object() {"High", "Medium", "Low"})
        Me.cboTrackStockLvl.Location = New System.Drawing.Point(250, 41)
        Me.cboTrackStockLvl.Name = "cboTrackStockLvl"
        Me.cboTrackStockLvl.Size = New System.Drawing.Size(244, 30)
        Me.cboTrackStockLvl.TabIndex = 21
        Me.cboTrackStockLvl.Text = "Select a Stock Level"
        '
        'lblTrackStockLvl
        '
        Me.lblTrackStockLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrackStockLvl.ForeColor = System.Drawing.Color.AliceBlue
        Me.lblTrackStockLvl.Location = New System.Drawing.Point(90, 35)
        Me.lblTrackStockLvl.Name = "lblTrackStockLvl"
        Me.lblTrackStockLvl.Size = New System.Drawing.Size(150, 40)
        Me.lblTrackStockLvl.TabIndex = 17
        Me.lblTrackStockLvl.Text = "Stock Level : "
        Me.lblTrackStockLvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboTrackCategory
        '
        Me.cboTrackCategory.FormattingEnabled = True
        Me.cboTrackCategory.Items.AddRange(New Object() {"Roti Canai (RC)", "Main Dish (MD)", "Side Dish (SD)", "Hot Drink (HD)", "Cold Drink (CD)"})
        Me.cboTrackCategory.Location = New System.Drawing.Point(250, 40)
        Me.cboTrackCategory.Name = "cboTrackCategory"
        Me.cboTrackCategory.Size = New System.Drawing.Size(244, 33)
        Me.cboTrackCategory.TabIndex = 20
        Me.cboTrackCategory.Text = "Select a Category"
        Me.tipTrackItem.SetToolTip(Me.cboTrackCategory, "Select a Item Category")
        '
        'lblTrackCategory
        '
        Me.lblTrackCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrackCategory.ForeColor = System.Drawing.Color.AliceBlue
        Me.lblTrackCategory.Location = New System.Drawing.Point(90, 35)
        Me.lblTrackCategory.Name = "lblTrackCategory"
        Me.lblTrackCategory.Size = New System.Drawing.Size(150, 40)
        Me.lblTrackCategory.TabIndex = 16
        Me.lblTrackCategory.Text = "Category : "
        Me.lblTrackCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTrackName
        '
        Me.txtTrackName.Location = New System.Drawing.Point(250, 41)
        Me.txtTrackName.Name = "txtTrackName"
        Me.txtTrackName.Size = New System.Drawing.Size(180, 30)
        Me.txtTrackName.TabIndex = 19
        Me.tipTrackItem.SetToolTip(Me.txtTrackName, "Enter Item's Name")
        '
        'mskTrackID
        '
        Me.mskTrackID.Location = New System.Drawing.Point(250, 41)
        Me.mskTrackID.Mask = "LL00000"
        Me.mskTrackID.Name = "mskTrackID"
        Me.mskTrackID.Size = New System.Drawing.Size(114, 30)
        Me.mskTrackID.TabIndex = 18
        Me.tipTrackItem.SetToolTip(Me.mskTrackID, "Enter Item's ID")
        '
        'lblTrackName
        '
        Me.lblTrackName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrackName.ForeColor = System.Drawing.Color.AliceBlue
        Me.lblTrackName.Location = New System.Drawing.Point(90, 35)
        Me.lblTrackName.Name = "lblTrackName"
        Me.lblTrackName.Size = New System.Drawing.Size(150, 40)
        Me.lblTrackName.TabIndex = 15
        Me.lblTrackName.Text = "Name : "
        Me.lblTrackName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTrackID
        '
        Me.lblTrackID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrackID.ForeColor = System.Drawing.Color.AliceBlue
        Me.lblTrackID.Location = New System.Drawing.Point(90, 35)
        Me.lblTrackID.Name = "lblTrackID"
        Me.lblTrackID.Size = New System.Drawing.Size(150, 40)
        Me.lblTrackID.TabIndex = 14
        Me.lblTrackID.Text = "Item ID : "
        Me.lblTrackID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label5.Location = New System.Drawing.Point(44, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 40)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Aspect Chosen : "
        '
        'cboTrackAspect
        '
        Me.cboTrackAspect.BackColor = System.Drawing.Color.AliceBlue
        Me.cboTrackAspect.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.cboTrackAspect.FormattingEnabled = True
        Me.cboTrackAspect.Items.AddRange(New Object() {"Item ID", "Name", "Category", "Stock Level"})
        Me.cboTrackAspect.Location = New System.Drawing.Point(241, 54)
        Me.cboTrackAspect.Name = "cboTrackAspect"
        Me.cboTrackAspect.Size = New System.Drawing.Size(187, 33)
        Me.cboTrackAspect.TabIndex = 0
        Me.tipTrackItem.SetToolTip(Me.cboTrackAspect, "Select an Aspect to Track")
        '
        'tipTrackItem
        '
        Me.tipTrackItem.BackColor = System.Drawing.Color.Snow
        '
        'errTrackItem
        '
        Me.errTrackItem.ContainerControl = Me
        '
        'frmTrackItem
        '
        Me.AcceptButton = Me.btnTrackSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(782, 603)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mnuTrackItem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuTrackItem
        Me.MaximumSize = New System.Drawing.Size(800, 650)
        Me.Name = "frmTrackItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ItemStock - Track Item"
        Me.mnuTrackItem.ResumeLayout(False)
        Me.mnuTrackItem.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.errTrackItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuTrackItem As MenuStrip
    Friend WithEvents mnuTrackItemFile As ToolStripMenuItem
    Friend WithEvents mnuTrackItemHelp As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboTrackAspect As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents mskTrackID As MaskedTextBox
    Friend WithEvents lblTrackStockLvl As Label
    Friend WithEvents lblTrackID As Label
    Friend WithEvents lblTrackName As Label
    Friend WithEvents lblTrackCategory As Label
    Friend WithEvents tipTrackItem As ToolTip
    Friend WithEvents errTrackItem As ErrorProvider
    Friend WithEvents txtTrackName As TextBox
    Friend WithEvents cboTrackCategory As ComboBox
    Friend WithEvents cboTrackStockLvl As ComboBox
    Friend WithEvents btnTrackClear As Button
    Friend WithEvents btnTrackSearch As Button
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FieldGuidelineToolStripMenuItem As ToolStripMenuItem
End Class
