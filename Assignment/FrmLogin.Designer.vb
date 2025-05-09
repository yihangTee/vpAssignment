<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mskUsername = New System.Windows.Forms.MaskedTextBox()
        Me.mskPassword = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lnkForgetPassword = New System.Windows.Forms.LinkLabel()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label1.Location = New System.Drawing.Point(239, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'mskUsername
        '
        Me.mskUsername.CausesValidation = False
        Me.mskUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskUsername.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mskUsername.Location = New System.Drawing.Point(245, 47)
        Me.mskUsername.Name = "mskUsername"
        Me.mskUsername.Size = New System.Drawing.Size(219, 24)
        Me.mskUsername.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.mskUsername, "Please enter your registered username.")
        '
        'mskPassword
        '
        Me.mskPassword.CausesValidation = False
        Me.mskPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskPassword.Location = New System.Drawing.Point(245, 120)
        Me.mskPassword.Name = "mskPassword"
        Me.mskPassword.Size = New System.Drawing.Size(219, 24)
        Me.mskPassword.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.mskPassword, "Please enter your registered password.")
        Me.mskPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label2.Location = New System.Drawing.Point(239, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword.ForeColor = System.Drawing.Color.AliceBlue
        Me.chkShowPassword.Location = New System.Drawing.Point(245, 150)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(137, 22)
        Me.chkShowPassword.TabIndex = 5
        Me.chkShowPassword.Text = "Show password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnLogin.CausesValidation = False
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnLogin.Location = New System.Drawing.Point(246, 212)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(108, 42)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "&Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnReset.Location = New System.Drawing.Point(360, 212)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(108, 42)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.login_profile_icon
        Me.PictureBox1.Location = New System.Drawing.Point(10, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 242)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lnkForgetPassword
        '
        Me.lnkForgetPassword.AutoSize = True
        Me.lnkForgetPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkForgetPassword.LinkColor = System.Drawing.Color.DeepSkyBlue
        Me.lnkForgetPassword.Location = New System.Drawing.Point(244, 175)
        Me.lnkForgetPassword.Name = "lnkForgetPassword"
        Me.lnkForgetPassword.Size = New System.Drawing.Size(147, 18)
        Me.lnkForgetPassword.TabIndex = 8
        Me.lnkForgetPassword.TabStop = True
        Me.lnkForgetPassword.Text = "Forgot Password?"
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(482, 266)
        Me.Controls.Add(Me.lnkForgetPassword)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.chkShowPassword)
        Me.Controls.Add(Me.mskPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mskUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmLogin"
        Me.Text = "Login"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mskUsername As MaskedTextBox
    Friend WithEvents mskPassword As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents err As ErrorProvider
    Friend WithEvents btnReset As Button
    Friend WithEvents lnkForgetPassword As LinkLabel
End Class
