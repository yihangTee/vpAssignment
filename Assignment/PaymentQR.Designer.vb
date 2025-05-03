<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentQR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentQR))
        Me.lblQr = New System.Windows.Forms.Label()
        Me.btnIScanYou = New System.Windows.Forms.Button()
        Me.btnScanMe = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picQR = New System.Windows.Forms.PictureBox()
        Me.panelCamera = New System.Windows.Forms.Panel()
        Me.picCamera = New System.Windows.Forms.PictureBox()
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCamera.SuspendLayout()
        CType(Me.picCamera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblQr
        '
        Me.lblQr.AutoSize = True
        Me.lblQr.Font = New System.Drawing.Font("Yu Gothic UI", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQr.Location = New System.Drawing.Point(489, 21)
        Me.lblQr.Name = "lblQr"
        Me.lblQr.Size = New System.Drawing.Size(259, 59)
        Me.lblQr.TabIndex = 30
        Me.lblQr.Text = "QR Payment"
        '
        'btnIScanYou
        '
        Me.btnIScanYou.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIScanYou.Location = New System.Drawing.Point(47, 263)
        Me.btnIScanYou.Name = "btnIScanYou"
        Me.btnIScanYou.Size = New System.Drawing.Size(183, 65)
        Me.btnIScanYou.TabIndex = 29
        Me.btnIScanYou.Text = "I Scan You ?"
        Me.btnIScanYou.UseVisualStyleBackColor = True
        '
        'btnScanMe
        '
        Me.btnScanMe.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScanMe.Location = New System.Drawing.Point(47, 143)
        Me.btnScanMe.Name = "btnScanMe"
        Me.btnScanMe.Size = New System.Drawing.Size(183, 65)
        Me.btnScanMe.TabIndex = 28
        Me.btnScanMe.Text = "You Scan Me ?"
        Me.btnScanMe.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGreen
        Me.Button2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(835, 399)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 113)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Success Pay"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Red
        Me.btnBack.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(835, 285)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(118, 106)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Palace Script MT", 60.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(449, 95)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "BL-Fariz...."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picQR
        '
        Me.picQR.Image = CType(resources.GetObject("picQR.Image"), System.Drawing.Image)
        Me.picQR.Location = New System.Drawing.Point(262, 107)
        Me.picQR.Name = "picQR"
        Me.picQR.Size = New System.Drawing.Size(473, 405)
        Me.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQR.TabIndex = 31
        Me.picQR.TabStop = False
        '
        'panelCamera
        '
        Me.panelCamera.Controls.Add(Me.picCamera)
        Me.panelCamera.Location = New System.Drawing.Point(262, 108)
        Me.panelCamera.Name = "panelCamera"
        Me.panelCamera.Size = New System.Drawing.Size(473, 404)
        Me.panelCamera.TabIndex = 32
        '
        'picCamera
        '
        Me.picCamera.Location = New System.Drawing.Point(0, 0)
        Me.picCamera.Name = "picCamera"
        Me.picCamera.Size = New System.Drawing.Size(470, 401)
        Me.picCamera.TabIndex = 0
        Me.picCamera.TabStop = False
        '
        'PaymentQR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 540)
        Me.Controls.Add(Me.panelCamera)
        Me.Controls.Add(Me.lblQr)
        Me.Controls.Add(Me.btnIScanYou)
        Me.Controls.Add(Me.btnScanMe)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picQR)
        Me.Name = "PaymentQR"
        Me.Text = "PaymentQR"
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCamera.ResumeLayout(False)
        CType(Me.picCamera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQr As Label
    Friend WithEvents btnIScanYou As Button
    Friend WithEvents btnScanMe As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents picQR As PictureBox
    Friend WithEvents panelCamera As Panel
    Friend WithEvents picCamera As PictureBox
End Class
