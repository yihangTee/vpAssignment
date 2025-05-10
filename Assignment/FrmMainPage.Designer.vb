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
        Me.btnStaffModule = New System.Windows.Forms.Button()
        Me.btnOrderPage = New System.Windows.Forms.Button()
        Me.btnItemModule = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnOrderPayment = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStaffModule
        '
        Me.btnStaffModule.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnStaffModule.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffModule.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnStaffModule.Location = New System.Drawing.Point(100, 301)
        Me.btnStaffModule.Name = "btnStaffModule"
        Me.btnStaffModule.Size = New System.Drawing.Size(172, 100)
        Me.btnStaffModule.TabIndex = 0
        Me.btnStaffModule.Text = "Staff Module"
        Me.btnStaffModule.UseVisualStyleBackColor = False
        '
        'btnOrderPage
        '
        Me.btnOrderPage.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnOrderPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderPage.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnOrderPage.Location = New System.Drawing.Point(278, 301)
        Me.btnOrderPage.Name = "btnOrderPage"
        Me.btnOrderPage.Size = New System.Drawing.Size(165, 100)
        Me.btnOrderPage.TabIndex = 1
        Me.btnOrderPage.Text = "Order Page"
        Me.btnOrderPage.UseVisualStyleBackColor = False
        '
        'btnItemModule
        '
        Me.btnItemModule.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnItemModule.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemModule.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnItemModule.Location = New System.Drawing.Point(449, 301)
        Me.btnItemModule.Name = "btnItemModule"
        Me.btnItemModule.Size = New System.Drawing.Size(180, 100)
        Me.btnItemModule.TabIndex = 2
        Me.btnItemModule.Text = "Item Module"
        Me.btnItemModule.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnLogOut.Location = New System.Drawing.Point(823, 12)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(94, 32)
        Me.btnLogOut.TabIndex = 4
        Me.btnLogOut.Text = "Log out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(179, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(638, 130)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Main Page"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.BFLogo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.Assignment.My.Resources.Resources.Logout
        Me.PictureBox2.Location = New System.Drawing.Point(923, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btnOrderPayment
        '
        Me.btnOrderPayment.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnOrderPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderPayment.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnOrderPayment.Location = New System.Drawing.Point(637, 301)
        Me.btnOrderPayment.Name = "btnOrderPayment"
        Me.btnOrderPayment.Size = New System.Drawing.Size(220, 100)
        Me.btnOrderPayment.TabIndex = 8
        Me.btnOrderPayment.Text = "Order/Payment Module"
        Me.btnOrderPayment.UseVisualStyleBackColor = False
        '
        'FrmMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(986, 578)
        Me.Controls.Add(Me.btnOrderPayment)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnItemModule)
        Me.Controls.Add(Me.btnOrderPage)
        Me.Controls.Add(Me.btnStaffModule)
        Me.Name = "FrmMainPage"
        Me.Text = "FrmMainPage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStaffModule As Button
    Friend WithEvents btnOrderPage As Button
    Friend WithEvents btnItemModule As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnOrderPayment As Button
End Class
