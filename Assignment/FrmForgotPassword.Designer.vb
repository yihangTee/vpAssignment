<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmForgotPassword))
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpVerification = New System.Windows.Forms.GroupBox()
        Me.grpResetPassword = New System.Windows.Forms.GroupBox()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnResetPassword = New System.Windows.Forms.Button()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpVerification.SuspendLayout()
        Me.grpResetPassword.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(212, 78)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.txtConfirmPassword.MaxLength = 25
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(225, 35)
        Me.txtConfirmPassword.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.txtConfirmPassword, "Confirm password should be the same as password above.")
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(212, 31)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUsername.MaxLength = 25
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(225, 35)
        Me.txtUsername.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.txtUsername, "Enter your username for verification.")
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(212, 31)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNewPassword.MaxLength = 25
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(225, 35)
        Me.txtNewPassword.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.txtNewPassword, "Password must contain at least a number, uppercase and lowercase letter, and spec" &
        "ial character.")
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 81)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(226, 29)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "&Confirm Password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(48, 34)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(188, 29)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "&New Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(92, 34)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 29)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "&Username"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(212, 79)
        Me.txtEmailAddress.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmailAddress.MaxLength = 254
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(225, 35)
        Me.txtEmailAddress.TabIndex = 70
        Me.ToolTip1.SetToolTip(Me.txtEmailAddress, "Enter your email address for verification")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 79)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 29)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "&Email Address"
        '
        'grpVerification
        '
        Me.grpVerification.Controls.Add(Me.txtEmailAddress)
        Me.grpVerification.Controls.Add(Me.Label5)
        Me.grpVerification.Controls.Add(Me.Label10)
        Me.grpVerification.Controls.Add(Me.txtUsername)
        Me.grpVerification.ForeColor = System.Drawing.Color.AliceBlue
        Me.grpVerification.Location = New System.Drawing.Point(35, 52)
        Me.grpVerification.Name = "grpVerification"
        Me.grpVerification.Size = New System.Drawing.Size(470, 142)
        Me.grpVerification.TabIndex = 72
        Me.grpVerification.TabStop = False
        Me.grpVerification.Text = "Verification "
        '
        'grpResetPassword
        '
        Me.grpResetPassword.Controls.Add(Me.chkShowPassword)
        Me.grpResetPassword.Controls.Add(Me.txtConfirmPassword)
        Me.grpResetPassword.Controls.Add(Me.Label12)
        Me.grpResetPassword.Controls.Add(Me.txtNewPassword)
        Me.grpResetPassword.Controls.Add(Me.Label11)
        Me.grpResetPassword.ForeColor = System.Drawing.Color.AliceBlue
        Me.grpResetPassword.Location = New System.Drawing.Point(23, 188)
        Me.grpResetPassword.Name = "grpResetPassword"
        Me.grpResetPassword.Size = New System.Drawing.Size(470, 148)
        Me.grpResetPassword.TabIndex = 73
        Me.grpResetPassword.TabStop = False
        Me.grpResetPassword.Text = "Reset Password "
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword.ForeColor = System.Drawing.Color.AliceBlue
        Me.chkShowPassword.Location = New System.Drawing.Point(212, 116)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(189, 29)
        Me.chkShowPassword.TabIndex = 28
        Me.chkShowPassword.Text = "Show password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnResetPassword)
        Me.GroupBox3.Controls.Add(Me.grpResetPassword)
        Me.GroupBox3.ForeColor = System.Drawing.Color.AliceBlue
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(511, 408)
        Me.GroupBox3.TabIndex = 73
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Login - Forgot Password"
        '
        'btnResetPassword
        '
        Me.btnResetPassword.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnResetPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetPassword.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnResetPassword.Location = New System.Drawing.Point(166, 344)
        Me.btnResetPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(180, 53)
        Me.btnResetPassword.TabIndex = 28
        Me.btnResetPassword.Text = "&Reset Password"
        Me.btnResetPassword.UseVisualStyleBackColor = False
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'FrmForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(537, 432)
        Me.Controls.Add(Me.grpVerification)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.AliceBlue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FrmForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login - Forgot Password"
        Me.grpVerification.ResumeLayout(False)
        Me.grpVerification.PerformLayout()
        Me.grpResetPassword.ResumeLayout(False)
        Me.grpResetPassword.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents grpVerification As GroupBox
    Friend WithEvents grpResetPassword As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnResetPassword As Button
    Friend WithEvents err As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents chkShowPassword As CheckBox
End Class
