<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentMain))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.radCash = New System.Windows.Forms.RadioButton()
        Me.radQR = New System.Windows.Forms.RadioButton()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.panelPaymentCash = New System.Windows.Forms.Panel()
        Me.PanelKeyboard = New System.Windows.Forms.Panel()
        Me.key1 = New System.Windows.Forms.Button()
        Me.key4 = New System.Windows.Forms.Button()
        Me.key7 = New System.Windows.Forms.Button()
        Me.key2 = New System.Windows.Forms.Button()
        Me.key5 = New System.Windows.Forms.Button()
        Me.key0 = New System.Windows.Forms.Button()
        Me.key8 = New System.Windows.Forms.Button()
        Me.key3 = New System.Windows.Forms.Button()
        Me.keyBackspace = New System.Windows.Forms.Button()
        Me.key6 = New System.Windows.Forms.Button()
        Me.keyDot = New System.Windows.Forms.Button()
        Me.key9 = New System.Windows.Forms.Button()
        Me.panelCashInput = New System.Windows.Forms.Panel()
        Me.btn10sen = New System.Windows.Forms.Button()
        Me.btn20sen = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.btn20 = New System.Windows.Forms.Button()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnChangeMode = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnSuccessPay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblPayCash = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.PanelPayment = New System.Windows.Forms.Panel()
        Me.GrpBxPaymentMethod = New System.Windows.Forms.GroupBox()
        Me.grpCart = New System.Windows.Forms.GroupBox()
        Me.btnSplit = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.grpOrderItem = New System.Windows.Forms.GroupBox()
        Me.lblTotalPay = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelSaparate = New System.Windows.Forms.Panel()
        Me.lbltotalPrice = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblSubtotalHeader = New System.Windows.Forms.Label()
        Me.lblQuantityHeader = New System.Windows.Forms.Label()
        Me.lblPriceHeader = New System.Windows.Forms.Label()
        Me.lblNameHeader = New System.Windows.Forms.Label()
        Me.lblNumberHeader = New System.Windows.Forms.Label()
        Me.lblTableNo = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FieldGuidelineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelPaymentCash.SuspendLayout()
        Me.PanelKeyboard.SuspendLayout()
        Me.panelCashInput.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelPayment.SuspendLayout()
        Me.GrpBxPaymentMethod.SuspendLayout()
        Me.grpCart.SuspendLayout()
        Me.grpOrderItem.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radCash
        '
        Me.radCash.AutoSize = True
        Me.radCash.Checked = True
        Me.radCash.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!)
        Me.radCash.Location = New System.Drawing.Point(44, 39)
        Me.radCash.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radCash.Name = "radCash"
        Me.radCash.Size = New System.Drawing.Size(84, 34)
        Me.radCash.TabIndex = 2
        Me.radCash.TabStop = True
        Me.radCash.Text = "Cash"
        Me.radCash.UseVisualStyleBackColor = True
        '
        'radQR
        '
        Me.radQR.AutoSize = True
        Me.radQR.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!)
        Me.radQR.Location = New System.Drawing.Point(176, 41)
        Me.radQR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radQR.Name = "radQR"
        Me.radQR.Size = New System.Drawing.Size(108, 34)
        Me.radQR.TabIndex = 8
        Me.radQR.Text = "QR Pay"
        Me.radQR.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Red
        Me.btnBack.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(346, 158)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(133, 132)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'panelPaymentCash
        '
        Me.panelPaymentCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelPaymentCash.Controls.Add(Me.PanelKeyboard)
        Me.panelPaymentCash.Controls.Add(Me.panelCashInput)
        Me.panelPaymentCash.Controls.Add(Me.Label2)
        Me.panelPaymentCash.Controls.Add(Me.btnChangeMode)
        Me.panelPaymentCash.Controls.Add(Me.btnCalculate)
        Me.panelPaymentCash.Controls.Add(Me.btnSuccessPay)
        Me.panelPaymentCash.Controls.Add(Me.btnClear)
        Me.panelPaymentCash.Controls.Add(Me.btnBack)
        Me.panelPaymentCash.Location = New System.Drawing.Point(765, 336)
        Me.panelPaymentCash.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelPaymentCash.Name = "panelPaymentCash"
        Me.panelPaymentCash.Size = New System.Drawing.Size(492, 572)
        Me.panelPaymentCash.TabIndex = 9
        '
        'PanelKeyboard
        '
        Me.PanelKeyboard.Controls.Add(Me.key1)
        Me.PanelKeyboard.Controls.Add(Me.key4)
        Me.PanelKeyboard.Controls.Add(Me.key7)
        Me.PanelKeyboard.Controls.Add(Me.key2)
        Me.PanelKeyboard.Controls.Add(Me.key5)
        Me.PanelKeyboard.Controls.Add(Me.key0)
        Me.PanelKeyboard.Controls.Add(Me.key8)
        Me.PanelKeyboard.Controls.Add(Me.key3)
        Me.PanelKeyboard.Controls.Add(Me.keyBackspace)
        Me.PanelKeyboard.Controls.Add(Me.key6)
        Me.PanelKeyboard.Controls.Add(Me.keyDot)
        Me.PanelKeyboard.Controls.Add(Me.key9)
        Me.PanelKeyboard.Location = New System.Drawing.Point(20, 22)
        Me.PanelKeyboard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelKeyboard.Name = "PanelKeyboard"
        Me.PanelKeyboard.Size = New System.Drawing.Size(316, 338)
        Me.PanelKeyboard.TabIndex = 5
        '
        'key1
        '
        Me.key1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.key1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key1.Location = New System.Drawing.Point(0, 2)
        Me.key1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key1.Name = "key1"
        Me.key1.Size = New System.Drawing.Size(96, 75)
        Me.key1.TabIndex = 4
        Me.key1.Text = "1"
        Me.key1.UseVisualStyleBackColor = True
        '
        'key4
        '
        Me.key4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key4.Location = New System.Drawing.Point(0, 82)
        Me.key4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key4.Name = "key4"
        Me.key4.Size = New System.Drawing.Size(96, 75)
        Me.key4.TabIndex = 5
        Me.key4.Text = "4"
        Me.key4.UseVisualStyleBackColor = True
        '
        'key7
        '
        Me.key7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key7.Location = New System.Drawing.Point(0, 162)
        Me.key7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key7.Name = "key7"
        Me.key7.Size = New System.Drawing.Size(96, 75)
        Me.key7.TabIndex = 6
        Me.key7.Text = "7"
        Me.key7.UseVisualStyleBackColor = True
        '
        'key2
        '
        Me.key2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key2.Location = New System.Drawing.Point(102, 2)
        Me.key2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key2.Name = "key2"
        Me.key2.Size = New System.Drawing.Size(96, 75)
        Me.key2.TabIndex = 7
        Me.key2.Text = "2"
        Me.key2.UseVisualStyleBackColor = True
        '
        'key5
        '
        Me.key5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key5.Location = New System.Drawing.Point(102, 82)
        Me.key5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key5.Name = "key5"
        Me.key5.Size = New System.Drawing.Size(96, 75)
        Me.key5.TabIndex = 8
        Me.key5.Text = "5"
        Me.key5.UseVisualStyleBackColor = True
        '
        'key0
        '
        Me.key0.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key0.Location = New System.Drawing.Point(205, 242)
        Me.key0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key0.Name = "key0"
        Me.key0.Size = New System.Drawing.Size(96, 75)
        Me.key0.TabIndex = 16
        Me.key0.Text = "0"
        Me.key0.UseVisualStyleBackColor = True
        '
        'key8
        '
        Me.key8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key8.Location = New System.Drawing.Point(102, 162)
        Me.key8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key8.Name = "key8"
        Me.key8.Size = New System.Drawing.Size(96, 75)
        Me.key8.TabIndex = 9
        Me.key8.Text = "8"
        Me.key8.UseVisualStyleBackColor = True
        '
        'key3
        '
        Me.key3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key3.Location = New System.Drawing.Point(205, 2)
        Me.key3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key3.Name = "key3"
        Me.key3.Size = New System.Drawing.Size(96, 75)
        Me.key3.TabIndex = 10
        Me.key3.Text = "3"
        Me.key3.UseVisualStyleBackColor = True
        '
        'keyBackspace
        '
        Me.keyBackspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.keyBackspace.Location = New System.Drawing.Point(102, 242)
        Me.keyBackspace.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.keyBackspace.Name = "keyBackspace"
        Me.keyBackspace.Size = New System.Drawing.Size(96, 75)
        Me.keyBackspace.TabIndex = 15
        Me.keyBackspace.Text = "<"
        Me.keyBackspace.UseVisualStyleBackColor = True
        '
        'key6
        '
        Me.key6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key6.Location = New System.Drawing.Point(205, 82)
        Me.key6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key6.Name = "key6"
        Me.key6.Size = New System.Drawing.Size(96, 75)
        Me.key6.TabIndex = 11
        Me.key6.Text = "6"
        Me.key6.UseVisualStyleBackColor = True
        '
        'keyDot
        '
        Me.keyDot.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.keyDot.Location = New System.Drawing.Point(0, 242)
        Me.keyDot.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.keyDot.Name = "keyDot"
        Me.keyDot.Size = New System.Drawing.Size(96, 75)
        Me.keyDot.TabIndex = 14
        Me.keyDot.Text = "."
        Me.keyDot.UseVisualStyleBackColor = True
        '
        'key9
        '
        Me.key9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key9.Location = New System.Drawing.Point(205, 162)
        Me.key9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key9.Name = "key9"
        Me.key9.Size = New System.Drawing.Size(96, 75)
        Me.key9.TabIndex = 12
        Me.key9.Text = "9"
        Me.key9.UseVisualStyleBackColor = True
        '
        'panelCashInput
        '
        Me.panelCashInput.Controls.Add(Me.btn10sen)
        Me.panelCashInput.Controls.Add(Me.btn20sen)
        Me.panelCashInput.Controls.Add(Me.btn1)
        Me.panelCashInput.Controls.Add(Me.btn5)
        Me.panelCashInput.Controls.Add(Me.btn10)
        Me.panelCashInput.Controls.Add(Me.btn20)
        Me.panelCashInput.Controls.Add(Me.btn50)
        Me.panelCashInput.Controls.Add(Me.btn100)
        Me.panelCashInput.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelCashInput.Location = New System.Drawing.Point(21, 22)
        Me.panelCashInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panelCashInput.Name = "panelCashInput"
        Me.panelCashInput.Size = New System.Drawing.Size(299, 315)
        Me.panelCashInput.TabIndex = 17
        Me.panelCashInput.Visible = False
        '
        'btn10sen
        '
        Me.btn10sen.Location = New System.Drawing.Point(148, 239)
        Me.btn10sen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn10sen.Name = "btn10sen"
        Me.btn10sen.Size = New System.Drawing.Size(142, 72)
        Me.btn10sen.TabIndex = 7
        Me.btn10sen.Text = "10 sen"
        Me.btn10sen.UseVisualStyleBackColor = True
        '
        'btn20sen
        '
        Me.btn20sen.Location = New System.Drawing.Point(148, 158)
        Me.btn20sen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn20sen.Name = "btn20sen"
        Me.btn20sen.Size = New System.Drawing.Size(142, 72)
        Me.btn20sen.TabIndex = 6
        Me.btn20sen.Text = "20 sen"
        Me.btn20sen.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(148, 78)
        Me.btn1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(142, 72)
        Me.btn1.TabIndex = 5
        Me.btn1.Text = "RM1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(148, 0)
        Me.btn5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(142, 72)
        Me.btn5.TabIndex = 4
        Me.btn5.Text = "RM5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn10
        '
        Me.btn10.Location = New System.Drawing.Point(-1, 238)
        Me.btn10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(142, 72)
        Me.btn10.TabIndex = 3
        Me.btn10.Text = "RM10"
        Me.btn10.UseVisualStyleBackColor = True
        '
        'btn20
        '
        Me.btn20.Location = New System.Drawing.Point(-1, 158)
        Me.btn20.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(142, 72)
        Me.btn20.TabIndex = 2
        Me.btn20.Text = "RM20"
        Me.btn20.UseVisualStyleBackColor = True
        '
        'btn50
        '
        Me.btn50.Location = New System.Drawing.Point(0, 78)
        Me.btn50.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(142, 72)
        Me.btn50.TabIndex = 1
        Me.btn50.Text = "RM50"
        Me.btn50.UseVisualStyleBackColor = True
        '
        'btn100
        '
        Me.btn100.Location = New System.Drawing.Point(0, 0)
        Me.btn100.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(142, 72)
        Me.btn100.TabIndex = 0
        Me.btn100.Text = "RM100"
        Me.btn100.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Palace Script MT", 60.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(21, 439)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(505, 119)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "BL-Fariz...."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnChangeMode
        '
        Me.btnChangeMode.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnChangeMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeMode.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnChangeMode.Location = New System.Drawing.Point(346, 9)
        Me.btnChangeMode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnChangeMode.Name = "btnChangeMode"
        Me.btnChangeMode.Size = New System.Drawing.Size(133, 62)
        Me.btnChangeMode.TabIndex = 19
        Me.btnChangeMode.Text = "Switch to Cash Input"
        Me.btnChangeMode.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(174, 361)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(146, 75)
        Me.btnCalculate.TabIndex = 18
        Me.btnCalculate.Text = "Enter"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnSuccessPay
        '
        Me.btnSuccessPay.BackColor = System.Drawing.Color.LightGreen
        Me.btnSuccessPay.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuccessPay.ForeColor = System.Drawing.Color.Black
        Me.btnSuccessPay.Location = New System.Drawing.Point(346, 295)
        Me.btnSuccessPay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSuccessPay.Name = "btnSuccessPay"
        Me.btnSuccessPay.Size = New System.Drawing.Size(133, 141)
        Me.btnSuccessPay.TabIndex = 10
        Me.btnSuccessPay.Text = "Success Pay"
        Me.btnSuccessPay.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(20, 361)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(147, 75)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.lblChange)
        Me.Panel1.Controls.Add(Me.lblPayCash)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Location = New System.Drawing.Point(765, 120)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(492, 218)
        Me.Panel1.TabIndex = 11
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(37, 58)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(80, 29)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Cash :"
        '
        'lblChange
        '
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(123, 116)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(338, 68)
        Me.lblChange.TabIndex = 3
        Me.lblChange.Text = "RM 0.00"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPayCash
        '
        Me.lblPayCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayCash.Location = New System.Drawing.Point(123, 39)
        Me.lblPayCash.Name = "lblPayCash"
        Me.lblPayCash.Size = New System.Drawing.Size(338, 68)
        Me.lblPayCash.TabIndex = 2
        Me.lblPayCash.Text = "RM 0.00"
        Me.lblPayCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(11, 135)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(109, 29)
        Me.Label34.TabIndex = 1
        Me.Label34.Text = "Change :"
        '
        'PanelPayment
        '
        Me.PanelPayment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelPayment.BackColor = System.Drawing.Color.Transparent
        Me.PanelPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPayment.Controls.Add(Me.GrpBxPaymentMethod)
        Me.PanelPayment.Controls.Add(Me.grpCart)
        Me.PanelPayment.Controls.Add(Me.Panel1)
        Me.PanelPayment.Controls.Add(Me.panelPaymentCash)
        Me.PanelPayment.Location = New System.Drawing.Point(42, 58)
        Me.PanelPayment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelPayment.Name = "PanelPayment"
        Me.PanelPayment.Size = New System.Drawing.Size(1278, 943)
        Me.PanelPayment.TabIndex = 4
        '
        'GrpBxPaymentMethod
        '
        Me.GrpBxPaymentMethod.Controls.Add(Me.radCash)
        Me.GrpBxPaymentMethod.Controls.Add(Me.radQR)
        Me.GrpBxPaymentMethod.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBxPaymentMethod.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GrpBxPaymentMethod.Location = New System.Drawing.Point(765, 18)
        Me.GrpBxPaymentMethod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GrpBxPaymentMethod.Name = "GrpBxPaymentMethod"
        Me.GrpBxPaymentMethod.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GrpBxPaymentMethod.Size = New System.Drawing.Size(493, 95)
        Me.GrpBxPaymentMethod.TabIndex = 20
        Me.GrpBxPaymentMethod.TabStop = False
        Me.GrpBxPaymentMethod.Text = "Payment Method"
        '
        'grpCart
        '
        Me.grpCart.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.grpCart.Controls.Add(Me.btnSplit)
        Me.grpCart.Controls.Add(Me.btnVoid)
        Me.grpCart.Controls.Add(Me.grpOrderItem)
        Me.grpCart.Controls.Add(Me.lblTableNo)
        Me.grpCart.Controls.Add(Me.label1)
        Me.grpCart.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpCart.Location = New System.Drawing.Point(26, 18)
        Me.grpCart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCart.Name = "grpCart"
        Me.grpCart.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCart.Size = New System.Drawing.Size(718, 891)
        Me.grpCart.TabIndex = 19
        Me.grpCart.TabStop = False
        Me.grpCart.Text = "Payment"
        '
        'btnSplit
        '
        Me.btnSplit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSplit.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSplit.Location = New System.Drawing.Point(512, 774)
        Me.btnSplit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSplit.Name = "btnSplit"
        Me.btnSplit.Size = New System.Drawing.Size(153, 48)
        Me.btnSplit.TabIndex = 6
        Me.btnSplit.Text = "Split"
        Me.btnSplit.UseVisualStyleBackColor = False
        '
        'btnVoid
        '
        Me.btnVoid.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnVoid.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnVoid.Location = New System.Drawing.Point(300, 774)
        Me.btnVoid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(146, 48)
        Me.btnVoid.TabIndex = 5
        Me.btnVoid.Text = "Void"
        Me.btnVoid.UseVisualStyleBackColor = False
        '
        'grpOrderItem
        '
        Me.grpOrderItem.Controls.Add(Me.lblTotalPay)
        Me.grpOrderItem.Controls.Add(Me.lblTax)
        Me.grpOrderItem.Controls.Add(Me.Label4)
        Me.grpOrderItem.Controls.Add(Me.Label3)
        Me.grpOrderItem.Controls.Add(Me.panelSaparate)
        Me.grpOrderItem.Controls.Add(Me.lbltotalPrice)
        Me.grpOrderItem.Controls.Add(Me.lbltotal)
        Me.grpOrderItem.Controls.Add(Me.lblSubtotalHeader)
        Me.grpOrderItem.Controls.Add(Me.lblQuantityHeader)
        Me.grpOrderItem.Controls.Add(Me.lblPriceHeader)
        Me.grpOrderItem.Controls.Add(Me.lblNameHeader)
        Me.grpOrderItem.Controls.Add(Me.lblNumberHeader)
        Me.grpOrderItem.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOrderItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpOrderItem.Location = New System.Drawing.Point(33, 76)
        Me.grpOrderItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpOrderItem.Name = "grpOrderItem"
        Me.grpOrderItem.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpOrderItem.Size = New System.Drawing.Size(662, 651)
        Me.grpOrderItem.TabIndex = 4
        Me.grpOrderItem.TabStop = False
        Me.grpOrderItem.Text = "Order Item"
        '
        'lblTotalPay
        '
        Me.lblTotalPay.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPay.Location = New System.Drawing.Point(498, 589)
        Me.lblTotalPay.Name = "lblTotalPay"
        Me.lblTotalPay.Size = New System.Drawing.Size(145, 52)
        Me.lblTotalPay.TabIndex = 7
        '
        'lblTax
        '
        Me.lblTax.Location = New System.Drawing.Point(514, 479)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(118, 38)
        Me.lblTax.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(372, 589)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 38)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total Pay :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(341, 475)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 30)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Service Tax (10%) :"
        '
        'panelSaparate
        '
        Me.panelSaparate.BackColor = System.Drawing.Color.White
        Me.panelSaparate.Location = New System.Drawing.Point(32, 418)
        Me.panelSaparate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panelSaparate.Name = "panelSaparate"
        Me.panelSaparate.Size = New System.Drawing.Size(612, 2)
        Me.panelSaparate.TabIndex = 7
        '
        'lbltotalPrice
        '
        Me.lbltotalPrice.Location = New System.Drawing.Point(514, 441)
        Me.lbltotalPrice.Name = "lbltotalPrice"
        Me.lbltotalPrice.Size = New System.Drawing.Size(118, 38)
        Me.lbltotalPrice.TabIndex = 6
        '
        'lbltotal
        '
        Me.lbltotal.Location = New System.Drawing.Point(406, 441)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(102, 29)
        Me.lbltotal.TabIndex = 5
        Me.lbltotal.Text = "Sub Total :"
        '
        'lblSubtotalHeader
        '
        Me.lblSubtotalHeader.AutoSize = True
        Me.lblSubtotalHeader.Location = New System.Drawing.Point(549, 46)
        Me.lblSubtotalHeader.Name = "lblSubtotalHeader"
        Me.lblSubtotalHeader.Size = New System.Drawing.Size(94, 30)
        Me.lblSubtotalHeader.TabIndex = 4
        Me.lblSubtotalHeader.Text = "Subtotal"
        '
        'lblQuantityHeader
        '
        Me.lblQuantityHeader.AutoSize = True
        Me.lblQuantityHeader.Location = New System.Drawing.Point(417, 46)
        Me.lblQuantityHeader.Name = "lblQuantityHeader"
        Me.lblQuantityHeader.Size = New System.Drawing.Size(96, 30)
        Me.lblQuantityHeader.TabIndex = 3
        Me.lblQuantityHeader.Text = "Quantity"
        '
        'lblPriceHeader
        '
        Me.lblPriceHeader.AutoSize = True
        Me.lblPriceHeader.Location = New System.Drawing.Point(294, 46)
        Me.lblPriceHeader.Name = "lblPriceHeader"
        Me.lblPriceHeader.Size = New System.Drawing.Size(59, 30)
        Me.lblPriceHeader.TabIndex = 2
        Me.lblPriceHeader.Text = "Price"
        '
        'lblNameHeader
        '
        Me.lblNameHeader.AutoSize = True
        Me.lblNameHeader.Location = New System.Drawing.Point(83, 46)
        Me.lblNameHeader.Name = "lblNameHeader"
        Me.lblNameHeader.Size = New System.Drawing.Size(70, 30)
        Me.lblNameHeader.TabIndex = 1
        Me.lblNameHeader.Text = "Name"
        '
        'lblNumberHeader
        '
        Me.lblNumberHeader.AutoSize = True
        Me.lblNumberHeader.Location = New System.Drawing.Point(27, 46)
        Me.lblNumberHeader.Name = "lblNumberHeader"
        Me.lblNumberHeader.Size = New System.Drawing.Size(47, 30)
        Me.lblNumberHeader.TabIndex = 0
        Me.lblNumberHeader.Text = "No."
        '
        'lblTableNo
        '
        Me.lblTableNo.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableNo.Location = New System.Drawing.Point(141, 40)
        Me.lblTableNo.Name = "lblTableNo"
        Me.lblTableNo.Size = New System.Drawing.Size(155, 38)
        Me.lblTableNo.TabIndex = 3
        Me.lblTableNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(39, 44)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(109, 30)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Table No :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1349, 36)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FieldGuidelineToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 32)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'FieldGuidelineToolStripMenuItem
        '
        Me.FieldGuidelineToolStripMenuItem.Name = "FieldGuidelineToolStripMenuItem"
        Me.FieldGuidelineToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.FieldGuidelineToolStripMenuItem.Size = New System.Drawing.Size(292, 34)
        Me.FieldGuidelineToolStripMenuItem.Text = "Field Guideline"
        '
        'PaymentMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1349, 1050)
        Me.Controls.Add(Me.PanelPayment)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PaymentMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PaymentMain"
        Me.panelPaymentCash.ResumeLayout(False)
        Me.PanelKeyboard.ResumeLayout(False)
        Me.panelCashInput.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelPayment.ResumeLayout(False)
        Me.GrpBxPaymentMethod.ResumeLayout(False)
        Me.GrpBxPaymentMethod.PerformLayout()
        Me.grpCart.ResumeLayout(False)
        Me.grpCart.PerformLayout()
        Me.grpOrderItem.ResumeLayout(False)
        Me.grpOrderItem.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picClose As PictureBox
    Friend WithEvents picMax As PictureBox
    Friend WithEvents picMin As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents radCash As RadioButton
    Friend WithEvents radQR As RadioButton
    Friend WithEvents btnBack As Button
    Friend WithEvents panelPaymentCash As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents key0 As Button
    Friend WithEvents keyBackspace As Button
    Friend WithEvents keyDot As Button
    Friend WithEvents key9 As Button
    Friend WithEvents key6 As Button
    Friend WithEvents key3 As Button
    Friend WithEvents key8 As Button
    Friend WithEvents key5 As Button
    Friend WithEvents key2 As Button
    Friend WithEvents key7 As Button
    Friend WithEvents key4 As Button
    Friend WithEvents key1 As Button
    Friend WithEvents btnSuccessPay As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents lblPayCash As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents PanelPayment As Panel
    Friend WithEvents grpCart As GroupBox
    Friend WithEvents lblTableNo As Label
    Friend WithEvents label1 As Label
    Friend WithEvents GrpBxPaymentMethod As GroupBox
    Friend WithEvents btnChangeMode As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents grpOrderItem As GroupBox
    Friend WithEvents lblSubtotalHeader As Label
    Friend WithEvents lblQuantityHeader As Label
    Friend WithEvents lblPriceHeader As Label
    Friend WithEvents lblNameHeader As Label
    Friend WithEvents lblNumberHeader As Label
    Friend WithEvents PanelKeyboard As Panel
    Friend WithEvents panelCashInput As Panel
    Friend WithEvents btn10 As Button
    Friend WithEvents btn20 As Button
    Friend WithEvents btn50 As Button
    Friend WithEvents btn100 As Button
    Friend WithEvents btn10sen As Button
    Friend WithEvents btn20sen As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents lbltotalPrice As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents panelSaparate As Panel
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalPay As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents btnVoid As Button
    Friend WithEvents btnSplit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FieldGuidelineToolStripMenuItem As ToolStripMenuItem
End Class
