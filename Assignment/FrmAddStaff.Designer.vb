<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddStaff))
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.mskContactNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.mskZipCode = New System.Windows.Forms.MaskedTextBox()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.picProfileImage = New System.Windows.Forms.PictureBox()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.grpEntry1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grpEntry2 = New System.Windows.Forms.GroupBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubmitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FieldGuidelineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.picProfileImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.grpEntry1.SuspendLayout()
        Me.grpEntry2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dlgOpen
        '
        Me.dlgOpen.FileName = "OpenFileDialog1"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(210, 39)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFirstName.MaxLength = 30
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(300, 35)
        Me.txtFirstName.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtFirstName, "Only alphabetic characters are allowed.")
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(210, 88)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLastName.MaxLength = 30
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(300, 35)
        Me.txtLastName.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtLastName, "Only alphabetic characters are allowed.")
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Checked = True
        Me.radMale.Location = New System.Drawing.Point(216, 134)
        Me.radMale.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(95, 33)
        Me.radMale.TabIndex = 9
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.ToolTip1.SetToolTip(Me.radMale, "Click either one to select gender.")
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(353, 134)
        Me.radFemale.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(126, 33)
        Me.radFemale.TabIndex = 44
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.ToolTip1.SetToolTip(Me.radFemale, "Click either one to select gender.")
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(212, 230)
        Me.txtEmailAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmailAddress.MaxLength = 254
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(299, 35)
        Me.txtEmailAddress.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txtEmailAddress, "Email address must at least includes a letter infront of ""@"", a ""@"", a letter bet" &
        "ween ""@"" and ""."" , and a letter behind "".""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'mskContactNumber
        '
        Me.mskContactNumber.Location = New System.Drawing.Point(212, 181)
        Me.mskContactNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mskContactNumber.Mask = "(00) - 000000000999"
        Me.mskContactNumber.Name = "mskContactNumber"
        Me.mskContactNumber.Size = New System.Drawing.Size(300, 35)
        Me.mskContactNumber.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.mskContactNumber, "Only digit numbers are allowed.")
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(214, 29)
        Me.txtStreet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStreet.MaxLength = 99
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(294, 35)
        Me.txtStreet.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.txtStreet, "Enter the staff's street (home address).")
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(214, 139)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCity.MaxLength = 99
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(293, 35)
        Me.txtCity.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.txtCity, "Enter the staff's city (home address).")
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(213, 195)
        Me.txtState.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtState.MaxLength = 99
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(294, 35)
        Me.txtState.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.txtState, "Enter the staff's state/ province (home address).")
        '
        'mskZipCode
        '
        Me.mskZipCode.Location = New System.Drawing.Point(214, 84)
        Me.mskZipCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mskZipCode.Mask = "00009"
        Me.mskZipCode.Name = "mskZipCode"
        Me.mskZipCode.Size = New System.Drawing.Size(293, 35)
        Me.mskZipCode.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.mskZipCode, "Enter the staff's zip code (home address). Only digit numbers are allowed.")
        Me.mskZipCode.ValidatingType = GetType(Integer)
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(234, 320)
        Me.chkShowPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(224, 33)
        Me.chkShowPassword.TabIndex = 25
        Me.chkShowPassword.Text = "Show password"
        Me.ToolTip1.SetToolTip(Me.chkShowPassword, "Check to show password charecter for password and confirm password field.")
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(234, 209)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.MaxLength = 25
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(293, 35)
        Me.txtPassword.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.txtPassword, "Password must contain at least a number, uppercase and lowercase letter, and spec" &
        "ial character.")
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(234, 155)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsername.MaxLength = 25
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(293, 35)
        Me.txtUsername.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.txtUsername, "Enter unique staff's username. ")
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(234, 264)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtConfirmPassword.MaxLength = 25
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(293, 35)
        Me.txtConfirmPassword.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.txtConfirmPassword, "Confirm password should be the same as password above.")
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'cboRole
        '
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Location = New System.Drawing.Point(234, 90)
        Me.cboRole.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(293, 37)
        Me.cboRole.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.cboRole, "Select the staff's role. (After select the staff's department)")
        '
        'cboDepartment
        '
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Items.AddRange(New Object() {"Administrative staff", "Back-Of-House staff", "Front-Of-House staff"})
        Me.cboDepartment.Location = New System.Drawing.Point(234, 30)
        Me.cboDepartment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(293, 37)
        Me.cboDepartment.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.cboDepartment, "Select the staff's department." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'picProfileImage
        '
        Me.picProfileImage.BackColor = System.Drawing.Color.Lavender
        Me.picProfileImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picProfileImage.Location = New System.Drawing.Point(1045, 48)
        Me.picProfileImage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picProfileImage.Name = "picProfileImage"
        Me.picProfileImage.Size = New System.Drawing.Size(154, 160)
        Me.picProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfileImage.TabIndex = 6
        Me.picProfileImage.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picProfileImage, "Browse to upload the staff's profile image in your file.")
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contact &Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "&Email Address"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnBrowse.Location = New System.Drawing.Point(886, 111)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(116, 41)
        Me.btnBrowse.TabIndex = 15
        Me.btnBrowse.TabStop = False
        Me.btnBrowse.Text = "&Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(868, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 29)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Profile &Image"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 415)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 29)
        Me.Label6.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mskZipCode)
        Me.GroupBox3.Controls.Add(Me.txtState)
        Me.GroupBox3.Controls.Add(Me.txtCity)
        Me.GroupBox3.Controls.Add(Me.txtStreet)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.ForeColor = System.Drawing.Color.AliceBlue
        Me.GroupBox3.Location = New System.Drawing.Point(19, 284)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(552, 250)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Home Address "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(134, 142)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 29)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "City"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 199)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(190, 29)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "State/ Province"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(83, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 29)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Zip code"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(111, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 29)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Street"
        '
        'grpEntry1
        '
        Me.grpEntry1.Controls.Add(Me.GroupBox3)
        Me.grpEntry1.Controls.Add(Me.mskContactNumber)
        Me.grpEntry1.Controls.Add(Me.txtEmailAddress)
        Me.grpEntry1.Controls.Add(Me.radFemale)
        Me.grpEntry1.Controls.Add(Me.radMale)
        Me.grpEntry1.Controls.Add(Me.Label6)
        Me.grpEntry1.Controls.Add(Me.txtLastName)
        Me.grpEntry1.Controls.Add(Me.txtFirstName)
        Me.grpEntry1.Controls.Add(Me.Label5)
        Me.grpEntry1.Controls.Add(Me.Label4)
        Me.grpEntry1.Controls.Add(Me.Label3)
        Me.grpEntry1.Controls.Add(Me.Label2)
        Me.grpEntry1.Controls.Add(Me.Label1)
        Me.grpEntry1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEntry1.ForeColor = System.Drawing.Color.AliceBlue
        Me.grpEntry1.Location = New System.Drawing.Point(56, 251)
        Me.grpEntry1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEntry1.Name = "grpEntry1"
        Me.grpEntry1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEntry1.Size = New System.Drawing.Size(612, 555)
        Me.grpEntry1.TabIndex = 0
        Me.grpEntry1.TabStop = False
        Me.grpEntry1.Text = "Personal Info"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(79, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 29)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Department"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(155, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 29)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Role"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(93, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 29)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "&Username"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(98, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 29)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "&Password"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 268)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(226, 29)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "&Confirm Password"
        '
        'grpEntry2
        '
        Me.grpEntry2.Controls.Add(Me.cboDepartment)
        Me.grpEntry2.Controls.Add(Me.cboRole)
        Me.grpEntry2.Controls.Add(Me.txtConfirmPassword)
        Me.grpEntry2.Controls.Add(Me.txtUsername)
        Me.grpEntry2.Controls.Add(Me.txtPassword)
        Me.grpEntry2.Controls.Add(Me.chkShowPassword)
        Me.grpEntry2.Controls.Add(Me.Label12)
        Me.grpEntry2.Controls.Add(Me.Label11)
        Me.grpEntry2.Controls.Add(Me.Label10)
        Me.grpEntry2.Controls.Add(Me.Label9)
        Me.grpEntry2.Controls.Add(Me.Label8)
        Me.grpEntry2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEntry2.ForeColor = System.Drawing.Color.AliceBlue
        Me.grpEntry2.Location = New System.Drawing.Point(657, 216)
        Me.grpEntry2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEntry2.Name = "grpEntry2"
        Me.grpEntry2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEntry2.Size = New System.Drawing.Size(566, 378)
        Me.grpEntry2.TabIndex = 1
        Me.grpEntry2.TabStop = False
        Me.grpEntry2.Text = "Staff Info"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSubmit.Location = New System.Drawing.Point(1109, 621)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(114, 46)
        Me.btnSubmit.TabIndex = 23
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnReset.Location = New System.Drawing.Point(974, 621)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(114, 46)
        Me.btnReset.TabIndex = 25
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnBack)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1305, 204)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.Back
        Me.PictureBox1.Location = New System.Drawing.Point(1242, 112)
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
        Me.btnBack.Location = New System.Drawing.Point(1113, 114)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(127, 60)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label17.Location = New System.Drawing.Point(158, 98)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(215, 84)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "BL-Fariz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Restaurant"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1299, 33)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowseToolStripMenuItem, Me.ResetToolStripMenuItem, Me.SubmitToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BrowseToolStripMenuItem
        '
        Me.BrowseToolStripMenuItem.Name = "BrowseToolStripMenuItem"
        Me.BrowseToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BrowseToolStripMenuItem.Size = New System.Drawing.Size(280, 34)
        Me.BrowseToolStripMenuItem.Text = "Browse"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(280, 34)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'SubmitToolStripMenuItem
        '
        Me.SubmitToolStripMenuItem.Name = "SubmitToolStripMenuItem"
        Me.SubmitToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SubmitToolStripMenuItem.Size = New System.Drawing.Size(280, 34)
        Me.SubmitToolStripMenuItem.Text = "Submit"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(280, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FieldGuidelineToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'FieldGuidelineToolStripMenuItem
        '
        Me.FieldGuidelineToolStripMenuItem.Name = "FieldGuidelineToolStripMenuItem"
        Me.FieldGuidelineToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.FieldGuidelineToolStripMenuItem.Size = New System.Drawing.Size(340, 34)
        Me.FieldGuidelineToolStripMenuItem.Text = "Field Guideline"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSubmit)
        Me.GroupBox2.Controls.Add(Me.grpEntry2)
        Me.GroupBox2.Controls.Add(Me.btnReset)
        Me.GroupBox2.Controls.Add(Me.picProfileImage)
        Me.GroupBox2.Controls.Add(Me.btnBrowse)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Location = New System.Drawing.Point(40, 212)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1240, 684)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Staff - Add"
        '
        'FrmAddStaff
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(1305, 919)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpEntry1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(1327, 975)
        Me.Name = "FrmAddStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff - Add"
        CType(Me.picProfileImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpEntry1.ResumeLayout(False)
        Me.grpEntry1.PerformLayout()
        Me.grpEntry2.ResumeLayout(False)
        Me.grpEntry2.PerformLayout()
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
    Friend WithEvents dlgOpen As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents err As ErrorProvider
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents grpEntry2 As GroupBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents grpEntry1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents mskZipCode As MaskedTextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents mskContactNumber As MaskedTextBox
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents picProfileImage As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BrowseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubmitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FieldGuidelineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboDepartment As ComboBox
    Friend WithEvents cboRole As ComboBox
End Class
