<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemStock))
        Me.mnuItemStock = New System.Windows.Forms.MenuStrip()
        Me.FIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTrackItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserGuideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblSName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnViewnTrack = New System.Windows.Forms.Button()
        Me.btnUpdateItemInfo = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.btnGenerateItemReport = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.mnuItemStock.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuItemStock
        '
        Me.mnuItemStock.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuItemStock.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuItemStock.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIleToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuItemStock.Location = New System.Drawing.Point(0, 0)
        Me.mnuItemStock.Name = "mnuItemStock"
        Me.mnuItemStock.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mnuItemStock.Size = New System.Drawing.Size(1330, 33)
        Me.mnuItemStock.TabIndex = 0
        Me.mnuItemStock.Text = "mnuItemStock"
        '
        'FIleToolStripMenuItem
        '
        Me.FIleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.ViewTrackItemToolStripMenuItem, Me.ReportToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FIleToolStripMenuItem.Name = "FIleToolStripMenuItem"
        Me.FIleToolStripMenuItem.Size = New System.Drawing.Size(55, 29)
        Me.FIleToolStripMenuItem.Text = "&FIle"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.AddToolStripMenuItem.Text = "&Add New Item"
        '
        'ViewTrackItemToolStripMenuItem
        '
        Me.ViewTrackItemToolStripMenuItem.Name = "ViewTrackItemToolStripMenuItem"
        Me.ViewTrackItemToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.ViewTrackItemToolStripMenuItem.Text = "&View/Track Item"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.ReportToolStripMenuItem.Text = "&Report"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(235, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateItemToolStripMenuItem, Me.DeleteItemToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UpdateItemToolStripMenuItem
        '
        Me.UpdateItemToolStripMenuItem.Name = "UpdateItemToolStripMenuItem"
        Me.UpdateItemToolStripMenuItem.Size = New System.Drawing.Size(213, 34)
        Me.UpdateItemToolStripMenuItem.Text = "U&pdate Item"
        '
        'DeleteItemToolStripMenuItem
        '
        Me.DeleteItemToolStripMenuItem.Name = "DeleteItemToolStripMenuItem"
        Me.DeleteItemToolStripMenuItem.Size = New System.Drawing.Size(213, 34)
        Me.DeleteItemToolStripMenuItem.Text = "De&lete Item"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.UserGuideToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(231, 34)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'UserGuideToolStripMenuItem
        '
        Me.UserGuideToolStripMenuItem.Name = "UserGuideToolStripMenuItem"
        Me.UserGuideToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.UserGuideToolStripMenuItem.Size = New System.Drawing.Size(231, 34)
        Me.UserGuideToolStripMenuItem.Text = "U&ser Guide"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.btnBack)
        Me.GroupBox1.Controls.Add(Me.lblSName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 35)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1330, 150)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Assignment.My.Resources.Resources.Back
        Me.PictureBox2.Location = New System.Drawing.Point(1256, 49)
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
        Me.btnBack.Location = New System.Drawing.Point(1128, 50)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(127, 60)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblSName
        '
        Me.lblSName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSName.Location = New System.Drawing.Point(396, 52)
        Me.lblSName.Name = "lblSName"
        Me.lblSName.Size = New System.Drawing.Size(328, 50)
        Me.lblSName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Staff Name : "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.BFLogo
        Me.PictureBox1.Location = New System.Drawing.Point(14, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label2.Location = New System.Drawing.Point(549, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(395, 41)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "You're now entering : "
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label3.Location = New System.Drawing.Point(590, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(587, 92)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Item Stock Management"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.GhostWhite
        Me.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddItem.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnAddItem.Location = New System.Drawing.Point(118, 758)
        Me.btnAddItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(164, 74)
        Me.btnAddItem.TabIndex = 5
        Me.btnAddItem.Text = "&Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnViewnTrack
        '
        Me.btnViewnTrack.BackColor = System.Drawing.Color.GhostWhite
        Me.btnViewnTrack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewnTrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewnTrack.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnViewnTrack.Location = New System.Drawing.Point(356, 758)
        Me.btnViewnTrack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnViewnTrack.Name = "btnViewnTrack"
        Me.btnViewnTrack.Size = New System.Drawing.Size(164, 74)
        Me.btnViewnTrack.TabIndex = 13
        Me.btnViewnTrack.Text = "View / &Track Item"
        Me.btnViewnTrack.UseVisualStyleBackColor = False
        '
        'btnUpdateItemInfo
        '
        Me.btnUpdateItemInfo.BackColor = System.Drawing.Color.GhostWhite
        Me.btnUpdateItemInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateItemInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateItemInfo.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnUpdateItemInfo.Location = New System.Drawing.Point(583, 758)
        Me.btnUpdateItemInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdateItemInfo.Name = "btnUpdateItemInfo"
        Me.btnUpdateItemInfo.Size = New System.Drawing.Size(164, 74)
        Me.btnUpdateItemInfo.TabIndex = 14
        Me.btnUpdateItemInfo.Text = "&Update Item Information"
        Me.btnUpdateItemInfo.UseVisualStyleBackColor = False
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.BackColor = System.Drawing.Color.GhostWhite
        Me.btnDeleteItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteItem.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDeleteItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteItem.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnDeleteItem.Location = New System.Drawing.Point(817, 758)
        Me.btnDeleteItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(164, 74)
        Me.btnDeleteItem.TabIndex = 15
        Me.btnDeleteItem.Text = "&Delete Item"
        Me.btnDeleteItem.UseVisualStyleBackColor = False
        '
        'btnGenerateItemReport
        '
        Me.btnGenerateItemReport.BackColor = System.Drawing.Color.GhostWhite
        Me.btnGenerateItemReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerateItemReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateItemReport.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnGenerateItemReport.Location = New System.Drawing.Point(1052, 758)
        Me.btnGenerateItemReport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGenerateItemReport.Name = "btnGenerateItemReport"
        Me.btnGenerateItemReport.Size = New System.Drawing.Size(164, 74)
        Me.btnGenerateItemReport.TabIndex = 16
        Me.btnGenerateItemReport.Text = "&Generate Item Report"
        Me.btnGenerateItemReport.UseVisualStyleBackColor = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Lavender
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox8.Image = Global.Assignment.My.Resources.Resources.Report
        Me.PictureBox8.Location = New System.Drawing.Point(1034, 536)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(200, 203)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 12
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Lavender
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox7.Image = Global.Assignment.My.Resources.Resources.Delete
        Me.PictureBox7.Location = New System.Drawing.Point(800, 536)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(200, 203)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 11
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Lavender
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox6.Image = Global.Assignment.My.Resources.Resources.Update
        Me.PictureBox6.Location = New System.Drawing.Point(565, 536)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(200, 203)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 10
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Lavender
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Image = Global.Assignment.My.Resources.Resources.TrackStock
        Me.PictureBox5.Location = New System.Drawing.Point(338, 536)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(200, 203)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Lavender
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Image = Global.Assignment.My.Resources.Resources.AddItem
        Me.PictureBox4.Location = New System.Drawing.Point(101, 536)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(200, 203)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Lavender
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = Global.Assignment.My.Resources.Resources.ItemStock
        Me.PictureBox3.Location = New System.Drawing.Point(323, 281)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(200, 203)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'frmItemStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(1325, 956)
        Me.Controls.Add(Me.btnGenerateItemReport)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.btnUpdateItemInfo)
        Me.Controls.Add(Me.btnViewnTrack)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mnuItemStock)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuItemStock
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(1347, 986)
        Me.Name = "frmItemStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Stock Management"
        Me.mnuItemStock.ResumeLayout(False)
        Me.mnuItemStock.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuItemStock As MenuStrip
    Friend WithEvents FIleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblSName As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnViewnTrack As Button
    Friend WithEvents btnUpdateItemInfo As Button
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents btnGenerateItemReport As Button
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewTrackItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserGuideToolStripMenuItem As ToolStripMenuItem
End Class
