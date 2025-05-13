<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainPage))
        Me.btnStaffModule = New System.Windows.Forms.Button()
        Me.btnOrderPage = New System.Windows.Forms.Button()
        Me.btnItemModule = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnOrderPayment = New System.Windows.Forms.Button()
        Me.pbStaff = New System.Windows.Forms.PictureBox()
        Me.pbOrder = New System.Windows.Forms.PictureBox()
        Me.pbItem = New System.Windows.Forms.PictureBox()
        Me.pbPayment = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStaffModule
        '
        Me.btnStaffModule.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnStaffModule.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnStaffModule.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnStaffModule.Location = New System.Drawing.Point(100, 425)
        Me.btnStaffModule.Name = "btnStaffModule"
        Me.btnStaffModule.Size = New System.Drawing.Size(184, 78)
        Me.btnStaffModule.TabIndex = 0
        Me.btnStaffModule.Text = "Staff Module"
        Me.btnStaffModule.UseVisualStyleBackColor = False
        '
        'btnOrderPage
        '
        Me.btnOrderPage.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnOrderPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnOrderPage.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnOrderPage.Location = New System.Drawing.Point(301, 425)
        Me.btnOrderPage.Name = "btnOrderPage"
        Me.btnOrderPage.Size = New System.Drawing.Size(184, 78)
        Me.btnOrderPage.TabIndex = 1
        Me.btnOrderPage.Text = "Order Page"
        Me.btnOrderPage.UseVisualStyleBackColor = False
        '
        'btnItemModule
        '
        Me.btnItemModule.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnItemModule.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnItemModule.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnItemModule.Location = New System.Drawing.Point(504, 425)
        Me.btnItemModule.Name = "btnItemModule"
        Me.btnItemModule.Size = New System.Drawing.Size(184, 78)
        Me.btnItemModule.TabIndex = 2
        Me.btnItemModule.Text = "Item Module"
        Me.btnItemModule.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnLogOut.Location = New System.Drawing.Point(815, 61)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(103, 51)
        Me.btnLogOut.TabIndex = 4
        Me.btnLogOut.Text = "Log out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 40.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(171, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(638, 130)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Main Page"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.BFLogo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox2.Image = Global.Assignment.My.Resources.Resources.Logout
        Me.PictureBox2.Location = New System.Drawing.Point(924, 61)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btnOrderPayment
        '
        Me.btnOrderPayment.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnOrderPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnOrderPayment.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnOrderPayment.Location = New System.Drawing.Point(707, 425)
        Me.btnOrderPayment.Name = "btnOrderPayment"
        Me.btnOrderPayment.Size = New System.Drawing.Size(184, 78)
        Me.btnOrderPayment.TabIndex = 8
        Me.btnOrderPayment.Text = "Order/Payment Module"
        Me.btnOrderPayment.UseVisualStyleBackColor = False
        '
        'pbStaff
        '
        Me.pbStaff.BackColor = System.Drawing.Color.Lavender
        Me.pbStaff.Image = Global.Assignment.My.Resources.Resources.staffModule
        Me.pbStaff.Location = New System.Drawing.Point(104, 230)
        Me.pbStaff.Name = "pbStaff"
        Me.pbStaff.Size = New System.Drawing.Size(180, 180)
        Me.pbStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStaff.TabIndex = 9
        Me.pbStaff.TabStop = False
        '
        'pbOrder
        '
        Me.pbOrder.BackColor = System.Drawing.Color.Lavender
        Me.pbOrder.Image = Global.Assignment.My.Resources.Resources.orderModule
        Me.pbOrder.Location = New System.Drawing.Point(305, 230)
        Me.pbOrder.Name = "pbOrder"
        Me.pbOrder.Size = New System.Drawing.Size(180, 180)
        Me.pbOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbOrder.TabIndex = 10
        Me.pbOrder.TabStop = False
        '
        'pbItem
        '
        Me.pbItem.BackColor = System.Drawing.Color.Lavender
        Me.pbItem.Image = Global.Assignment.My.Resources.Resources.ItemModule
        Me.pbItem.Location = New System.Drawing.Point(507, 230)
        Me.pbItem.Name = "pbItem"
        Me.pbItem.Size = New System.Drawing.Size(180, 180)
        Me.pbItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbItem.TabIndex = 11
        Me.pbItem.TabStop = False
        '
        'pbPayment
        '
        Me.pbPayment.BackColor = System.Drawing.Color.Lavender
        Me.pbPayment.Image = Global.Assignment.My.Resources.Resources.paymentModule
        Me.pbPayment.Location = New System.Drawing.Point(707, 230)
        Me.pbPayment.Name = "pbPayment"
        Me.pbPayment.Size = New System.Drawing.Size(180, 180)
        Me.pbPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPayment.TabIndex = 12
        Me.pbPayment.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.btnLogOut)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 149)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(986, 33)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'FrmMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(986, 578)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbPayment)
        Me.Controls.Add(Me.pbItem)
        Me.Controls.Add(Me.pbOrder)
        Me.Controls.Add(Me.pbStaff)
        Me.Controls.Add(Me.btnOrderPayment)
        Me.Controls.Add(Me.btnItemModule)
        Me.Controls.Add(Me.btnOrderPage)
        Me.Controls.Add(Me.btnStaffModule)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMainPage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStaffModule As Button
    Friend WithEvents btnOrderPage As Button
    Friend WithEvents btnItemModule As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnOrderPayment As Button
    Friend WithEvents pbStaff As PictureBox
    Friend WithEvents pbOrder As PictureBox
    Friend WithEvents pbItem As PictureBox
    Friend WithEvents pbPayment As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
End Class
