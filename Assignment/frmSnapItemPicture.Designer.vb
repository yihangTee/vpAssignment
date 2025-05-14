<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSnapItemPicture
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSnapItemPicture))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnStopCamera = New System.Windows.Forms.Button()
        Me.btnStartCamera = New System.Windows.Forms.Button()
        Me.lblConfirmPicture = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartCaptureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopCaptureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picCameraAccess = New Assignment.CirclePictureBox()
        Me.picPreviewItemPicture = New Assignment.CirclePictureBox()
        Me.picSnapItemPicture = New Assignment.CirclePictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.picCameraAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPreviewItemPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnapItemPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.btnBack)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 120)
        Me.GroupBox1.TabIndex = 5
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
        Me.PictureBox2.Location = New System.Drawing.Point(494, 40)
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
        Me.btnBack.Location = New System.Drawing.Point(381, 42)
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
        'btnStopCamera
        '
        Me.btnStopCamera.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnStopCamera.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopCamera.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnStopCamera.Location = New System.Drawing.Point(305, 452)
        Me.btnStopCamera.Name = "btnStopCamera"
        Me.btnStopCamera.Size = New System.Drawing.Size(157, 60)
        Me.btnStopCamera.TabIndex = 8
        Me.btnStopCamera.Text = "S&top Camera"
        Me.btnStopCamera.UseVisualStyleBackColor = False
        '
        'btnStartCamera
        '
        Me.btnStartCamera.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnStartCamera.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartCamera.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnStartCamera.Location = New System.Drawing.Point(90, 452)
        Me.btnStartCamera.Name = "btnStartCamera"
        Me.btnStartCamera.Size = New System.Drawing.Size(157, 60)
        Me.btnStartCamera.TabIndex = 7
        Me.btnStartCamera.Text = "&Start Camera"
        Me.btnStartCamera.UseVisualStyleBackColor = False
        '
        'lblConfirmPicture
        '
        Me.lblConfirmPicture.AutoSize = True
        Me.lblConfirmPicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblConfirmPicture.ForeColor = System.Drawing.Color.Red
        Me.lblConfirmPicture.Location = New System.Drawing.Point(139, 401)
        Me.lblConfirmPicture.Name = "lblConfirmPicture"
        Me.lblConfirmPicture.Size = New System.Drawing.Size(275, 20)
        Me.lblConfirmPicture.TabIndex = 9
        Me.lblConfirmPicture.Text = "Are you confirm to use this picture?"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartCaptureToolStripMenuItem, Me.StopCaptureToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(166, 82)
        '
        'StartCaptureToolStripMenuItem
        '
        Me.StartCaptureToolStripMenuItem.Name = "StartCaptureToolStripMenuItem"
        Me.StartCaptureToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.StartCaptureToolStripMenuItem.Text = "Start Capture"
        '
        'StopCaptureToolStripMenuItem
        '
        Me.StopCaptureToolStripMenuItem.Name = "StopCaptureToolStripMenuItem"
        Me.StopCaptureToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.StopCaptureToolStripMenuItem.Text = "Stop Capture"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(162, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'picCameraAccess
        '
        Me.picCameraAccess.BackColor = System.Drawing.Color.AliceBlue
        Me.picCameraAccess.Image = Global.Assignment.My.Resources.Resources.Snap
        Me.picCameraAccess.Location = New System.Drawing.Point(187, 184)
        Me.picCameraAccess.Name = "picCameraAccess"
        Me.picCameraAccess.Size = New System.Drawing.Size(180, 180)
        Me.picCameraAccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCameraAccess.TabIndex = 6
        Me.picCameraAccess.TabStop = False
        '
        'picPreviewItemPicture
        '
        Me.picPreviewItemPicture.BackColor = System.Drawing.Color.AliceBlue
        Me.picPreviewItemPicture.Location = New System.Drawing.Point(187, 184)
        Me.picPreviewItemPicture.Name = "picPreviewItemPicture"
        Me.picPreviewItemPicture.Size = New System.Drawing.Size(180, 180)
        Me.picPreviewItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPreviewItemPicture.TabIndex = 10
        Me.picPreviewItemPicture.TabStop = False
        '
        'picSnapItemPicture
        '
        Me.picSnapItemPicture.BackColor = System.Drawing.Color.AliceBlue
        Me.picSnapItemPicture.Location = New System.Drawing.Point(187, 184)
        Me.picSnapItemPicture.Name = "picSnapItemPicture"
        Me.picSnapItemPicture.Size = New System.Drawing.Size(180, 180)
        Me.picSnapItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSnapItemPicture.TabIndex = 11
        Me.picSnapItemPicture.TabStop = False
        '
        'frmSnapItemPicture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(562, 553)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.lblConfirmPicture)
        Me.Controls.Add(Me.btnStopCamera)
        Me.Controls.Add(Me.btnStartCamera)
        Me.Controls.Add(Me.picCameraAccess)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picPreviewItemPicture)
        Me.Controls.Add(Me.picSnapItemPicture)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(580, 600)
        Me.Name = "frmSnapItemPicture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ItemStock - Snap Picture"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.picCameraAccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPreviewItemPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnapItemPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picCameraAccess As CirclePictureBox
    Friend WithEvents btnStopCamera As Button
    Friend WithEvents btnStartCamera As Button
    Friend WithEvents lblConfirmPicture As Label
    Friend WithEvents picPreviewItemPicture As CirclePictureBox
    Friend WithEvents picSnapItemPicture As CirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents StartCaptureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopCaptureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
