<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStaffDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStaffDetails))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.grpEntry2 = New System.Windows.Forms.GroupBox()
        Me.radInactive = New System.Windows.Forms.RadioButton()
        Me.radActive = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDateOfRegistered = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grpEntry1 = New System.Windows.Forms.GroupBox()
        Me.rtxtHomeAddress = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mskContactNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.picProfileImage = New System.Windows.Forms.PictureBox()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FieldGuidelineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpEntry2.SuspendLayout()
        Me.grpEntry1.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProfileImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(709, -30)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 29)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Log out"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'grpEntry2
        '
        Me.grpEntry2.Controls.Add(Me.radInactive)
        Me.grpEntry2.Controls.Add(Me.radActive)
        Me.grpEntry2.Controls.Add(Me.Label1)
        Me.grpEntry2.Controls.Add(Me.cboRole)
        Me.grpEntry2.Controls.Add(Me.cboDepartment)
        Me.grpEntry2.Controls.Add(Me.chkShowPassword)
        Me.grpEntry2.Controls.Add(Me.txtUsername)
        Me.grpEntry2.Controls.Add(Me.txtPassword)
        Me.grpEntry2.Controls.Add(Me.Label11)
        Me.grpEntry2.Controls.Add(Me.Label10)
        Me.grpEntry2.Controls.Add(Me.Label9)
        Me.grpEntry2.Controls.Add(Me.Label8)
        Me.grpEntry2.Controls.Add(Me.lblDateOfRegistered)
        Me.grpEntry2.Controls.Add(Me.lblId)
        Me.grpEntry2.Controls.Add(Me.Label14)
        Me.grpEntry2.Controls.Add(Me.Label12)
        Me.grpEntry2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEntry2.ForeColor = System.Drawing.Color.AliceBlue
        Me.grpEntry2.Location = New System.Drawing.Point(785, 282)
        Me.grpEntry2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEntry2.Name = "grpEntry2"
        Me.grpEntry2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEntry2.Size = New System.Drawing.Size(580, 491)
        Me.grpEntry2.TabIndex = 27
        Me.grpEntry2.TabStop = False
        Me.grpEntry2.Text = "Staff Info"
        '
        'radInactive
        '
        Me.radInactive.AutoSize = True
        Me.radInactive.Location = New System.Drawing.Point(431, 142)
        Me.radInactive.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radInactive.Name = "radInactive"
        Me.radInactive.Size = New System.Drawing.Size(127, 33)
        Me.radInactive.TabIndex = 73
        Me.radInactive.TabStop = True
        Me.radInactive.Text = "Inactive"
        Me.ToolTip1.SetToolTip(Me.radInactive, "Click either one to select gender.")
        Me.radInactive.UseVisualStyleBackColor = True
        '
        'radActive
        '
        Me.radActive.AutoSize = True
        Me.radActive.Checked = True
        Me.radActive.Location = New System.Drawing.Point(254, 142)
        Me.radActive.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radActive.Name = "radActive"
        Me.radActive.Size = New System.Drawing.Size(108, 33)
        Me.radActive.TabIndex = 72
        Me.radActive.TabStop = True
        Me.radActive.Text = "Active"
        Me.ToolTip1.SetToolTip(Me.radActive, "Click either one to select gender.")
        Me.radActive.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 29)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Gender"
        '
        'cboRole
        '
        Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRole.Enabled = False
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Items.AddRange(New Object() {"Administrative staff", "Back-Of-House staff", "Front-Of-House staff"})
        Me.cboRole.Location = New System.Drawing.Point(254, 248)
        Me.cboRole.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(293, 37)
        Me.cboRole.TabIndex = 67
        '
        'cboDepartment
        '
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Items.AddRange(New Object() {"Administrative staff", "Back-Of-House staff", "Front-Of-House staff"})
        Me.cboDepartment.Location = New System.Drawing.Point(254, 191)
        Me.cboDepartment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(293, 37)
        Me.cboDepartment.TabIndex = 66
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(254, 398)
        Me.chkShowPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(224, 33)
        Me.chkShowPassword.TabIndex = 65
        Me.chkShowPassword.Text = "Show password"
        Me.ToolTip1.SetToolTip(Me.chkShowPassword, "Check to show password charecter for password and confirm password field.")
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(254, 301)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsername.MaxLength = 25
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(293, 35)
        Me.txtUsername.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.txtUsername, "Enter the staff's username. ")
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(254, 352)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.MaxLength = 25
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(293, 35)
        Me.txtPassword.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.txtPassword, "Password must contain at least a number, uppercase and lowercase letter, and spec" &
        "ial character.")
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(110, 356)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 29)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "&Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(106, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 29)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "&Username"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(168, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 29)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Role"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(91, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 29)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Department"
        '
        'lblDateOfRegistered
        '
        Me.lblDateOfRegistered.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateOfRegistered.Location = New System.Drawing.Point(254, 89)
        Me.lblDateOfRegistered.Name = "lblDateOfRegistered"
        Me.lblDateOfRegistered.Size = New System.Drawing.Size(294, 34)
        Me.lblDateOfRegistered.TabIndex = 54
        '
        'lblId
        '
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblId.Location = New System.Drawing.Point(254, 38)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(294, 35)
        Me.lblId.TabIndex = 51
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(232, 29)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Date of Registered"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(132, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 29)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Staff Id "
        '
        'grpEntry1
        '
        Me.grpEntry1.Controls.Add(Me.rtxtHomeAddress)
        Me.grpEntry1.Controls.Add(Me.Label2)
        Me.grpEntry1.Controls.Add(Me.mskContactNumber)
        Me.grpEntry1.Controls.Add(Me.txtEmailAddress)
        Me.grpEntry1.Controls.Add(Me.radFemale)
        Me.grpEntry1.Controls.Add(Me.radMale)
        Me.grpEntry1.Controls.Add(Me.txtLastName)
        Me.grpEntry1.Controls.Add(Me.txtFirstName)
        Me.grpEntry1.Controls.Add(Me.Label5)
        Me.grpEntry1.Controls.Add(Me.Label4)
        Me.grpEntry1.Controls.Add(Me.Label17)
        Me.grpEntry1.Controls.Add(Me.Label18)
        Me.grpEntry1.Controls.Add(Me.Label19)
        Me.grpEntry1.Controls.Add(Me.Label6)
        Me.grpEntry1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEntry1.ForeColor = System.Drawing.Color.AliceBlue
        Me.grpEntry1.Location = New System.Drawing.Point(240, 282)
        Me.grpEntry1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEntry1.Name = "grpEntry1"
        Me.grpEntry1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEntry1.Size = New System.Drawing.Size(522, 491)
        Me.grpEntry1.TabIndex = 26
        Me.grpEntry1.TabStop = False
        Me.grpEntry1.Text = "Personal Info"
        '
        'rtxtHomeAddress
        '
        Me.rtxtHomeAddress.Location = New System.Drawing.Point(201, 321)
        Me.rtxtHomeAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rtxtHomeAddress.Name = "rtxtHomeAddress"
        Me.rtxtHomeAddress.Size = New System.Drawing.Size(293, 149)
        Me.rtxtHomeAddress.TabIndex = 72
        Me.rtxtHomeAddress.Text = ""
        Me.ToolTip1.SetToolTip(Me.rtxtHomeAddress, "Enter the staff's street, zip code, city and state or province" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (home address).")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 29)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "&Home Address"
        '
        'mskContactNumber
        '
        Me.mskContactNumber.Location = New System.Drawing.Point(201, 209)
        Me.mskContactNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mskContactNumber.Mask = "(00) - 000000000999"
        Me.mskContactNumber.Name = "mskContactNumber"
        Me.mskContactNumber.Size = New System.Drawing.Size(293, 35)
        Me.mskContactNumber.TabIndex = 67
        Me.ToolTip1.SetToolTip(Me.mskContactNumber, "Only digit numbers are allowed.")
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(201, 262)
        Me.txtEmailAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmailAddress.MaxLength = 254
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(293, 35)
        Me.txtEmailAddress.TabIndex = 69
        Me.ToolTip1.SetToolTip(Me.txtEmailAddress, "Email address must at least includes a letter infront of ""@"", a ""@"", a letter bet" &
        "ween ""@"" and ""."" , and a letter behind "".""")
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(378, 162)
        Me.radFemale.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(126, 33)
        Me.radFemale.TabIndex = 70
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.ToolTip1.SetToolTip(Me.radFemale, "Click either one to select gender.")
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Checked = True
        Me.radMale.Location = New System.Drawing.Point(201, 162)
        Me.radMale.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(95, 33)
        Me.radMale.TabIndex = 68
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.ToolTip1.SetToolTip(Me.radMale, "Click either one to select gender.")
        Me.radMale.UseVisualStyleBackColor = True
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(201, 112)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLastName.MaxLength = 30
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(293, 35)
        Me.txtLastName.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.txtLastName, "Only alphabetic characters are allowed.")
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(201, 68)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFirstName.MaxLength = 30
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(293, 35)
        Me.txtFirstName.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 29)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "&Email Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 29)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Contact &No"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(94, 162)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 29)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "Gender"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(58, 116)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(137, 29)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "&Last Name"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(57, 71)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(141, 29)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "&First Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 415)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 29)
        Me.Label6.TabIndex = 5
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnUpdate.Location = New System.Drawing.Point(1062, 560)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(140, 54)
        Me.btnUpdate.TabIndex = 67
        Me.btnUpdate.Text = "&Update"
        Me.ToolTip1.SetToolTip(Me.btnUpdate, "Save the changes to the database." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnDelete.Location = New System.Drawing.Point(1213, 560)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(140, 54)
        Me.btnDelete.TabIndex = 68
        Me.btnDelete.Text = "&Delete"
        Me.ToolTip1.SetToolTip(Me.btnDelete, "Soft delete (change active to Inactive) to the database." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'picProfileImage
        '
        Me.picProfileImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picProfileImage.Location = New System.Drawing.Point(26, 50)
        Me.picProfileImage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picProfileImage.Name = "picProfileImage"
        Me.picProfileImage.Size = New System.Drawing.Size(154, 160)
        Me.picProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfileImage.TabIndex = 60
        Me.picProfileImage.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picProfileImage, "Browse to upload the staff's profile image in your file.")
        '
        'dlgOpen
        '
        Me.dlgOpen.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnBack)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1403, 204)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.Back
        Me.PictureBox1.Location = New System.Drawing.Point(1297, 112)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.Location = New System.Drawing.Point(1168, 114)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(127, 60)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label3.Location = New System.Drawing.Point(158, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 84)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "BL-Fariz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Restaurant"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Assignment.My.Resources.Resources.BFLogo
        Me.PictureBox2.Location = New System.Drawing.Point(12, 66)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(124, 138)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 23)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1397, 33)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowseToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BrowseToolStripMenuItem
        '
        Me.BrowseToolStripMenuItem.Name = "BrowseToolStripMenuItem"
        Me.BrowseToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.BrowseToolStripMenuItem.Text = "Browse"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FieldGuidelineToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'FieldGuidelineToolStripMenuItem
        '
        Me.FieldGuidelineToolStripMenuItem.Name = "FieldGuidelineToolStripMenuItem"
        Me.FieldGuidelineToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.FieldGuidelineToolStripMenuItem.Text = "Field Guideline"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBrowse)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.picProfileImage)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Location = New System.Drawing.Point(14, 232)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1374, 629)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Staff - Modification"
        '
        'btnBrowse
        '
        Me.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnBrowse.Location = New System.Drawing.Point(52, 255)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(110, 39)
        Me.btnBrowse.TabIndex = 62
        Me.btnBrowse.TabStop = False
        Me.btnBrowse.Text = "&Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 29)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Profile Image"
        '
        'FrmStaffDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1401, 875)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.grpEntry2)
        Me.Controls.Add(Me.grpEntry1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmStaffDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff - Modification"
        Me.grpEntry2.ResumeLayout(False)
        Me.grpEntry2.PerformLayout()
        Me.grpEntry1.ResumeLayout(False)
        Me.grpEntry1.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProfileImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents grpEntry2 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents grpEntry1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDateOfRegistered As Label
    Friend WithEvents lblId As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents err As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents dlgOpen As OpenFileDialog
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents cboDepartment As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BrowseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FieldGuidelineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picProfileImage As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents rtxtHomeAddress As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mskContactNumber As MaskedTextBox
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents radInactive As RadioButton
    Friend WithEvents radActive As RadioButton
    Friend WithEvents Label1 As Label
End Class
