<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTable))
        Me.btnEditMode = New System.Windows.Forms.Button()
        Me.btnAddTable = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.pnlTables = New System.Windows.Forms.Panel()
        Me.cmsTable = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnOnEditModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FieldGuidelineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsTable.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEditMode
        '
        Me.btnEditMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditMode.Location = New System.Drawing.Point(14, 240)
        Me.btnEditMode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditMode.Name = "btnEditMode"
        Me.btnEditMode.Size = New System.Drawing.Size(212, 46)
        Me.btnEditMode.TabIndex = 0
        Me.btnEditMode.Text = "Edit Mode"
        Me.btnEditMode.UseVisualStyleBackColor = True
        '
        'btnAddTable
        '
        Me.btnAddTable.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAddTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTable.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnAddTable.Location = New System.Drawing.Point(232, 240)
        Me.btnAddTable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddTable.Name = "btnAddTable"
        Me.btnAddTable.Size = New System.Drawing.Size(152, 46)
        Me.btnAddTable.TabIndex = 1
        Me.btnAddTable.Text = "Add Table"
        Me.btnAddTable.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSave.Location = New System.Drawing.Point(390, 240)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(204, 46)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnReset.Location = New System.Drawing.Point(600, 239)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(197, 47)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset Layout"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'pnlTables
        '
        Me.pnlTables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTables.Location = New System.Drawing.Point(14, 303)
        Me.pnlTables.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlTables.Name = "pnlTables"
        Me.pnlTables.Size = New System.Drawing.Size(1299, 565)
        Me.pnlTables.TabIndex = 4
        '
        'cmsTable
        '
        Me.cmsTable.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.cmsTable.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.cmsTable.Name = "ContextMenuStrip1"
        Me.cmsTable.Size = New System.Drawing.Size(135, 36)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(134, 32)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.Label3)
        Me.grpInfo.Controls.Add(Me.lblTime)
        Me.grpInfo.Controls.Add(Me.lblName)
        Me.grpInfo.Controls.Add(Me.Label2)
        Me.grpInfo.Controls.Add(Me.Label1)
        Me.grpInfo.Controls.Add(Me.PictureBox1)
        Me.grpInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfo.ForeColor = System.Drawing.Color.AliceBlue
        Me.grpInfo.Location = New System.Drawing.Point(14, 46)
        Me.grpInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpInfo.Size = New System.Drawing.Size(1299, 186)
        Me.grpInfo.TabIndex = 5
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Information"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lavender
        Me.Label3.Location = New System.Drawing.Point(175, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(720, 141)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Order Page"
        '
        'lblTime
        '
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Location = New System.Drawing.Point(1091, 94)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(201, 40)
        Me.lblTime.TabIndex = 4
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Location = New System.Drawing.Point(1091, 38)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(201, 40)
        Me.lblName.TabIndex = 3
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label2.Location = New System.Drawing.Point(998, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Time :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label1.Location = New System.Drawing.Point(930, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Staff Name :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Lavender
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnBack.Location = New System.Drawing.Point(1123, 239)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(125, 47)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.Assignment.My.Resources.Resources.Back
        Me.PictureBox2.Location = New System.Drawing.Point(1254, 240)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1333, 33)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnOnEditModeToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'TurnOnEditModeToolStripMenuItem
        '
        Me.TurnOnEditModeToolStripMenuItem.Name = "TurnOnEditModeToolStripMenuItem"
        Me.TurnOnEditModeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.TurnOnEditModeToolStripMenuItem.Size = New System.Drawing.Size(322, 34)
        Me.TurnOnEditModeToolStripMenuItem.Text = "Turn on edit mode"
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
        'FrmTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1333, 891)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.pnlTables)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAddTable)
        Me.Controls.Add(Me.btnEditMode)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order"
        Me.cmsTable.ResumeLayout(False)
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEditMode As Button
    Friend WithEvents btnAddTable As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents pnlTables As Panel
    Friend WithEvents cmsTable As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TurnOnEditModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FieldGuidelineToolStripMenuItem As ToolStripMenuItem
End Class
