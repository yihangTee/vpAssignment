<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeleteItem))
        Me.mnuDeleteItem = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FieldGuidelineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblConfirmPicture = New System.Windows.Forms.Label()
        Me.btnReviewItemDetails = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.lblShowDeleteItemName = New System.Windows.Forms.Label()
        Me.lblShowDeleteItemID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picDeleteItemPicture = New Assignment.CirclePictureBox()
        Me.btnDeleteClear = New System.Windows.Forms.Button()
        Me.btnDeleteSearch = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mskSearchDeleteItemId = New System.Windows.Forms.MaskedTextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuDeleteItem.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.picDeleteItemPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuDeleteItem
        '
        Me.mnuDeleteItem.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuDeleteItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuDeleteItem.Location = New System.Drawing.Point(0, 0)
        Me.mnuDeleteItem.Name = "mnuDeleteItem"
        Me.mnuDeleteItem.Size = New System.Drawing.Size(782, 30)
        Me.mnuDeleteItem.TabIndex = 0
        Me.mnuDeleteItem.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ClearToolStripMenuItem, Me.DelToolStripMenuItem1, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 26)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.ClearToolStripMenuItem.Text = "CLear"
        '
        'DelToolStripMenuItem1
        '
        Me.DelToolStripMenuItem1.Name = "DelToolStripMenuItem1"
        Me.DelToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DelToolStripMenuItem1.Size = New System.Drawing.Size(220, 26)
        Me.DelToolStripMenuItem1.Text = "&Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(217, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FieldGuidelineToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 26)
        Me.HelpToolStripMenuItem.Text = "&Help"
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
        Me.GroupBox1.TabIndex = 8
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.btnDeleteClear)
        Me.GroupBox2.Controls.Add(Me.btnDeleteSearch)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.mskSearchDeleteItemId)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Location = New System.Drawing.Point(12, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(758, 422)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item - Delete Item"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblConfirmPicture)
        Me.GroupBox3.Controls.Add(Me.btnReviewItemDetails)
        Me.GroupBox3.Controls.Add(Me.btnDeleteItem)
        Me.GroupBox3.Controls.Add(Me.lblShowDeleteItemName)
        Me.GroupBox3.Controls.Add(Me.lblShowDeleteItemID)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.picDeleteItemPicture)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.AliceBlue
        Me.GroupBox3.Location = New System.Drawing.Point(38, 151)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(682, 251)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Brief Item's Info"
        '
        'lblConfirmPicture
        '
        Me.lblConfirmPicture.AutoSize = True
        Me.lblConfirmPicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lblConfirmPicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPicture.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblConfirmPicture.Location = New System.Drawing.Point(235, 218)
        Me.lblConfirmPicture.Name = "lblConfirmPicture"
        Me.lblConfirmPicture.Size = New System.Drawing.Size(379, 18)
        Me.lblConfirmPicture.TabIndex = 10
        Me.lblConfirmPicture.Text = "Gentle Remind : Item deleted cannot be retrieved."
        '
        'btnReviewItemDetails
        '
        Me.btnReviewItemDetails.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnReviewItemDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReviewItemDetails.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnReviewItemDetails.Location = New System.Drawing.Point(444, 151)
        Me.btnReviewItemDetails.Name = "btnReviewItemDetails"
        Me.btnReviewItemDetails.Size = New System.Drawing.Size(116, 55)
        Me.btnReviewItemDetails.TabIndex = 30
        Me.btnReviewItemDetails.Text = "&View Details"
        Me.btnReviewItemDetails.UseVisualStyleBackColor = False
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnDeleteItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteItem.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnDeleteItem.Location = New System.Drawing.Point(294, 159)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(116, 40)
        Me.btnDeleteItem.TabIndex = 29
        Me.btnDeleteItem.Text = "&Delete"
        Me.btnDeleteItem.UseVisualStyleBackColor = False
        '
        'lblShowDeleteItemName
        '
        Me.lblShowDeleteItemName.BackColor = System.Drawing.Color.GhostWhite
        Me.lblShowDeleteItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowDeleteItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowDeleteItemName.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblShowDeleteItemName.Location = New System.Drawing.Point(400, 80)
        Me.lblShowDeleteItemName.Name = "lblShowDeleteItemName"
        Me.lblShowDeleteItemName.Size = New System.Drawing.Size(182, 57)
        Me.lblShowDeleteItemName.TabIndex = 21
        '
        'lblShowDeleteItemID
        '
        Me.lblShowDeleteItemID.BackColor = System.Drawing.Color.GhostWhite
        Me.lblShowDeleteItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowDeleteItemID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblShowDeleteItemID.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblShowDeleteItemID.Location = New System.Drawing.Point(400, 40)
        Me.lblShowDeleteItemID.Name = "lblShowDeleteItemID"
        Me.lblShowDeleteItemID.Size = New System.Drawing.Size(182, 30)
        Me.lblShowDeleteItemID.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(253, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 40)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Item Name : "
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label3.Location = New System.Drawing.Point(289, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 40)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Item ID : "
        '
        'picDeleteItemPicture
        '
        Me.picDeleteItemPicture.BackColor = System.Drawing.Color.AliceBlue
        Me.picDeleteItemPicture.Location = New System.Drawing.Point(31, 40)
        Me.picDeleteItemPicture.Name = "picDeleteItemPicture"
        Me.picDeleteItemPicture.Size = New System.Drawing.Size(180, 180)
        Me.picDeleteItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDeleteItemPicture.TabIndex = 12
        Me.picDeleteItemPicture.TabStop = False
        '
        'btnDeleteClear
        '
        Me.btnDeleteClear.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnDeleteClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteClear.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnDeleteClear.Location = New System.Drawing.Point(400, 96)
        Me.btnDeleteClear.Name = "btnDeleteClear"
        Me.btnDeleteClear.Size = New System.Drawing.Size(116, 40)
        Me.btnDeleteClear.TabIndex = 28
        Me.btnDeleteClear.Text = "&Clear"
        Me.btnDeleteClear.UseVisualStyleBackColor = False
        '
        'btnDeleteSearch
        '
        Me.btnDeleteSearch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnDeleteSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSearch.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnDeleteSearch.Location = New System.Drawing.Point(250, 96)
        Me.btnDeleteSearch.Name = "btnDeleteSearch"
        Me.btnDeleteSearch.Size = New System.Drawing.Size(116, 40)
        Me.btnDeleteSearch.TabIndex = 27
        Me.btnDeleteSearch.Text = "&Search"
        Me.btnDeleteSearch.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label9.Location = New System.Drawing.Point(206, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(186, 25)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Enter an Item ID : "
        '
        'mskSearchDeleteItemId
        '
        Me.mskSearchDeleteItemId.Location = New System.Drawing.Point(432, 47)
        Me.mskSearchDeleteItemId.Mask = "LL00000"
        Me.mskSearchDeleteItemId.Name = "mskSearchDeleteItemId"
        Me.mskSearchDeleteItemId.Size = New System.Drawing.Size(109, 30)
        Me.mskSearchDeleteItemId.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.mskSearchDeleteItemId, "Enter Item's ID")
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Snow
        '
        'frmDeleteItem
        '
        Me.AcceptButton = Me.btnDeleteSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(782, 603)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mnuDeleteItem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuDeleteItem
        Me.MaximumSize = New System.Drawing.Size(800, 650)
        Me.Name = "frmDeleteItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ItemStock - Delete Item"
        Me.mnuDeleteItem.ResumeLayout(False)
        Me.mnuDeleteItem.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.picDeleteItemPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuDeleteItem As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnDeleteClear As Button
    Friend WithEvents btnDeleteSearch As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents mskSearchDeleteItemId As MaskedTextBox
    Friend WithEvents picDeleteItemPicture As CirclePictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblShowDeleteItemName As Label
    Friend WithEvents lblShowDeleteItemID As Label
    Friend WithEvents btnReviewItemDetails As Button
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents lblConfirmPicture As Label
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DelToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FieldGuidelineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
End Class
