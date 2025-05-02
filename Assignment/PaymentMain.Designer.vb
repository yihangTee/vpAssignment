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
        Me.panelCashInput = New System.Windows.Forms.Panel()
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
        Me.grpOrderItem = New System.Windows.Forms.GroupBox()
        Me.lblSubtotalHeader = New System.Windows.Forms.Label()
        Me.lblQuantityHeader = New System.Windows.Forms.Label()
        Me.lblPriceHeader = New System.Windows.Forms.Label()
        Me.lblNameHeader = New System.Windows.Forms.Label()
        Me.lblNumberHeader = New System.Windows.Forms.Label()
        Me.lblTableNo = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lbltotalPrice = New System.Windows.Forms.Label()
        Me.panelPaymentCash.SuspendLayout()
        Me.panelCashInput.SuspendLayout()
        Me.PanelKeyboard.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelPayment.SuspendLayout()
        Me.GrpBxPaymentMethod.SuspendLayout()
        Me.grpCart.SuspendLayout()
        Me.grpOrderItem.SuspendLayout()
        Me.SuspendLayout()
        '
        'radCash
        '
        Me.radCash.AutoSize = True
        Me.radCash.Checked = True
        Me.radCash.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!)
        Me.radCash.Location = New System.Drawing.Point(39, 31)
        Me.radCash.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radCash.Name = "radCash"
        Me.radCash.Size = New System.Drawing.Size(71, 29)
        Me.radCash.TabIndex = 2
        Me.radCash.TabStop = True
        Me.radCash.Text = "Cash"
        Me.radCash.UseVisualStyleBackColor = True
        '
        'radQR
        '
        Me.radQR.AutoSize = True
        Me.radQR.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!)
        Me.radQR.Location = New System.Drawing.Point(156, 33)
        Me.radQR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radQR.Name = "radQR"
        Me.radQR.Size = New System.Drawing.Size(91, 29)
        Me.radQR.TabIndex = 8
        Me.radQR.Text = "QR Pay"
        Me.radQR.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Red
        Me.btnBack.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(308, 126)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(118, 106)
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
        Me.panelPaymentCash.Location = New System.Drawing.Point(680, 269)
        Me.panelPaymentCash.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelPaymentCash.Name = "panelPaymentCash"
        Me.panelPaymentCash.Size = New System.Drawing.Size(438, 458)
        Me.panelPaymentCash.TabIndex = 9
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
        Me.panelCashInput.Location = New System.Drawing.Point(19, 18)
        Me.panelCashInput.Name = "panelCashInput"
        Me.panelCashInput.Size = New System.Drawing.Size(266, 252)
        Me.panelCashInput.TabIndex = 17
        Me.panelCashInput.Visible = False
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
        Me.PanelKeyboard.Location = New System.Drawing.Point(18, 18)
        Me.PanelKeyboard.Name = "PanelKeyboard"
        Me.PanelKeyboard.Size = New System.Drawing.Size(281, 270)
        Me.PanelKeyboard.TabIndex = 5
        '
        'key1
        '
        Me.key1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.key1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key1.Location = New System.Drawing.Point(0, 2)
        Me.key1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key1.Name = "key1"
        Me.key1.Size = New System.Drawing.Size(85, 60)
        Me.key1.TabIndex = 4
        Me.key1.Text = "1"
        Me.key1.UseVisualStyleBackColor = True
        '
        'key4
        '
        Me.key4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key4.Location = New System.Drawing.Point(0, 66)
        Me.key4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key4.Name = "key4"
        Me.key4.Size = New System.Drawing.Size(85, 60)
        Me.key4.TabIndex = 5
        Me.key4.Text = "4"
        Me.key4.UseVisualStyleBackColor = True
        '
        'key7
        '
        Me.key7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key7.Location = New System.Drawing.Point(0, 130)
        Me.key7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key7.Name = "key7"
        Me.key7.Size = New System.Drawing.Size(85, 60)
        Me.key7.TabIndex = 6
        Me.key7.Text = "7"
        Me.key7.UseVisualStyleBackColor = True
        '
        'key2
        '
        Me.key2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key2.Location = New System.Drawing.Point(91, 2)
        Me.key2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key2.Name = "key2"
        Me.key2.Size = New System.Drawing.Size(85, 60)
        Me.key2.TabIndex = 7
        Me.key2.Text = "2"
        Me.key2.UseVisualStyleBackColor = True
        '
        'key5
        '
        Me.key5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key5.Location = New System.Drawing.Point(91, 66)
        Me.key5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key5.Name = "key5"
        Me.key5.Size = New System.Drawing.Size(85, 60)
        Me.key5.TabIndex = 8
        Me.key5.Text = "5"
        Me.key5.UseVisualStyleBackColor = True
        '
        'key0
        '
        Me.key0.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key0.Location = New System.Drawing.Point(182, 194)
        Me.key0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key0.Name = "key0"
        Me.key0.Size = New System.Drawing.Size(85, 60)
        Me.key0.TabIndex = 16
        Me.key0.Text = "0"
        Me.key0.UseVisualStyleBackColor = True
        '
        'key8
        '
        Me.key8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key8.Location = New System.Drawing.Point(91, 130)
        Me.key8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key8.Name = "key8"
        Me.key8.Size = New System.Drawing.Size(85, 60)
        Me.key8.TabIndex = 9
        Me.key8.Text = "8"
        Me.key8.UseVisualStyleBackColor = True
        '
        'key3
        '
        Me.key3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key3.Location = New System.Drawing.Point(182, 2)
        Me.key3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key3.Name = "key3"
        Me.key3.Size = New System.Drawing.Size(85, 60)
        Me.key3.TabIndex = 10
        Me.key3.Text = "3"
        Me.key3.UseVisualStyleBackColor = True
        '
        'keyBackspace
        '
        Me.keyBackspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.keyBackspace.Location = New System.Drawing.Point(91, 194)
        Me.keyBackspace.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.keyBackspace.Name = "keyBackspace"
        Me.keyBackspace.Size = New System.Drawing.Size(85, 60)
        Me.keyBackspace.TabIndex = 15
        Me.keyBackspace.Text = "<"
        Me.keyBackspace.UseVisualStyleBackColor = True
        '
        'key6
        '
        Me.key6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key6.Location = New System.Drawing.Point(182, 66)
        Me.key6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key6.Name = "key6"
        Me.key6.Size = New System.Drawing.Size(85, 60)
        Me.key6.TabIndex = 11
        Me.key6.Text = "6"
        Me.key6.UseVisualStyleBackColor = True
        '
        'keyDot
        '
        Me.keyDot.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.keyDot.Location = New System.Drawing.Point(0, 194)
        Me.keyDot.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.keyDot.Name = "keyDot"
        Me.keyDot.Size = New System.Drawing.Size(85, 60)
        Me.keyDot.TabIndex = 14
        Me.keyDot.Text = "."
        Me.keyDot.UseVisualStyleBackColor = True
        '
        'key9
        '
        Me.key9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.key9.Location = New System.Drawing.Point(182, 130)
        Me.key9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key9.Name = "key9"
        Me.key9.Size = New System.Drawing.Size(85, 60)
        Me.key9.TabIndex = 12
        Me.key9.Text = "9"
        Me.key9.UseVisualStyleBackColor = True
        '
        'btn10sen
        '
        Me.btn10sen.Location = New System.Drawing.Point(132, 191)
        Me.btn10sen.Name = "btn10sen"
        Me.btn10sen.Size = New System.Drawing.Size(126, 58)
        Me.btn10sen.TabIndex = 7
        Me.btn10sen.Text = "10 sen"
        Me.btn10sen.UseVisualStyleBackColor = True
        '
        'btn20sen
        '
        Me.btn20sen.Location = New System.Drawing.Point(132, 126)
        Me.btn20sen.Name = "btn20sen"
        Me.btn20sen.Size = New System.Drawing.Size(126, 58)
        Me.btn20sen.TabIndex = 6
        Me.btn20sen.Text = "20 sen"
        Me.btn20sen.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(132, 62)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(126, 58)
        Me.btn1.TabIndex = 5
        Me.btn1.Text = "RM1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(132, 0)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(126, 58)
        Me.btn5.TabIndex = 4
        Me.btn5.Text = "RM5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn10
        '
        Me.btn10.Location = New System.Drawing.Point(-1, 190)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(126, 58)
        Me.btn10.TabIndex = 3
        Me.btn10.Text = "RM10"
        Me.btn10.UseVisualStyleBackColor = True
        '
        'btn20
        '
        Me.btn20.Location = New System.Drawing.Point(-1, 126)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(126, 58)
        Me.btn20.TabIndex = 2
        Me.btn20.Text = "RM20"
        Me.btn20.UseVisualStyleBackColor = True
        '
        'btn50
        '
        Me.btn50.Location = New System.Drawing.Point(0, 62)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(126, 58)
        Me.btn50.TabIndex = 1
        Me.btn50.Text = "RM50"
        Me.btn50.UseVisualStyleBackColor = True
        '
        'btn100
        '
        Me.btn100.Location = New System.Drawing.Point(0, 0)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(126, 58)
        Me.btn100.TabIndex = 0
        Me.btn100.Text = "RM100"
        Me.btn100.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Palace Script MT", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(407, 95)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "BL-Fariz"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnChangeMode
        '
        Me.btnChangeMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeMode.Location = New System.Drawing.Point(308, 7)
        Me.btnChangeMode.Name = "btnChangeMode"
        Me.btnChangeMode.Size = New System.Drawing.Size(118, 50)
        Me.btnChangeMode.TabIndex = 19
        Me.btnChangeMode.Text = "Switch to Cash Input"
        Me.btnChangeMode.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(155, 289)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(130, 60)
        Me.btnCalculate.TabIndex = 18
        Me.btnCalculate.Text = "Enter"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnSuccessPay
        '
        Me.btnSuccessPay.BackColor = System.Drawing.Color.LightGreen
        Me.btnSuccessPay.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuccessPay.ForeColor = System.Drawing.Color.Black
        Me.btnSuccessPay.Location = New System.Drawing.Point(308, 236)
        Me.btnSuccessPay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSuccessPay.Name = "btnSuccessPay"
        Me.btnSuccessPay.Size = New System.Drawing.Size(118, 113)
        Me.btnSuccessPay.TabIndex = 10
        Me.btnSuccessPay.Text = "Success Pay"
        Me.btnSuccessPay.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(18, 289)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(131, 60)
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
        Me.Panel1.Location = New System.Drawing.Point(680, 96)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 175)
        Me.Panel1.TabIndex = 11
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(33, 46)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(70, 25)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Cash :"
        '
        'lblChange
        '
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(109, 93)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(301, 55)
        Me.lblChange.TabIndex = 3
        Me.lblChange.Text = "RM "
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPayCash
        '
        Me.lblPayCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayCash.Location = New System.Drawing.Point(109, 31)
        Me.lblPayCash.Name = "lblPayCash"
        Me.lblPayCash.Size = New System.Drawing.Size(301, 55)
        Me.lblPayCash.TabIndex = 2
        Me.lblPayCash.Text = "RM "
        Me.lblPayCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(10, 108)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(93, 25)
        Me.Label34.TabIndex = 1
        Me.Label34.Text = "Change :"
        '
        'PanelPayment
        '
        Me.PanelPayment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelPayment.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPayment.Controls.Add(Me.GrpBxPaymentMethod)
        Me.PanelPayment.Controls.Add(Me.grpCart)
        Me.PanelPayment.Controls.Add(Me.Panel1)
        Me.PanelPayment.Controls.Add(Me.panelPaymentCash)
        Me.PanelPayment.Location = New System.Drawing.Point(37, 46)
        Me.PanelPayment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelPayment.Name = "PanelPayment"
        Me.PanelPayment.Size = New System.Drawing.Size(1136, 755)
        Me.PanelPayment.TabIndex = 4
        '
        'GrpBxPaymentMethod
        '
        Me.GrpBxPaymentMethod.Controls.Add(Me.radCash)
        Me.GrpBxPaymentMethod.Controls.Add(Me.radQR)
        Me.GrpBxPaymentMethod.Font = New System.Drawing.Font("Yu Gothic UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBxPaymentMethod.Location = New System.Drawing.Point(680, 14)
        Me.GrpBxPaymentMethod.Name = "GrpBxPaymentMethod"
        Me.GrpBxPaymentMethod.Size = New System.Drawing.Size(438, 76)
        Me.GrpBxPaymentMethod.TabIndex = 20
        Me.GrpBxPaymentMethod.TabStop = False
        Me.GrpBxPaymentMethod.Text = "Payment Method"
        '
        'grpCart
        '
        Me.grpCart.BackColor = System.Drawing.SystemColors.Control
        Me.grpCart.Controls.Add(Me.grpOrderItem)
        Me.grpCart.Controls.Add(Me.lblTableNo)
        Me.grpCart.Controls.Add(Me.label1)
        Me.grpCart.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCart.Location = New System.Drawing.Point(23, 14)
        Me.grpCart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCart.Name = "grpCart"
        Me.grpCart.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCart.Size = New System.Drawing.Size(638, 713)
        Me.grpCart.TabIndex = 19
        Me.grpCart.TabStop = False
        Me.grpCart.Text = "Payment"
        '
        'grpOrderItem
        '
        Me.grpOrderItem.Controls.Add(Me.lbltotalPrice)
        Me.grpOrderItem.Controls.Add(Me.lbltotal)
        Me.grpOrderItem.Controls.Add(Me.lblSubtotalHeader)
        Me.grpOrderItem.Controls.Add(Me.lblQuantityHeader)
        Me.grpOrderItem.Controls.Add(Me.lblPriceHeader)
        Me.grpOrderItem.Controls.Add(Me.lblNameHeader)
        Me.grpOrderItem.Controls.Add(Me.lblNumberHeader)
        Me.grpOrderItem.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOrderItem.Location = New System.Drawing.Point(29, 61)
        Me.grpOrderItem.Name = "grpOrderItem"
        Me.grpOrderItem.Size = New System.Drawing.Size(588, 521)
        Me.grpOrderItem.TabIndex = 4
        Me.grpOrderItem.TabStop = False
        Me.grpOrderItem.Text = "Order Item"
        '
        'lblSubtotalHeader
        '
        Me.lblSubtotalHeader.AutoSize = True
        Me.lblSubtotalHeader.Location = New System.Drawing.Point(488, 37)
        Me.lblSubtotalHeader.Name = "lblSubtotalHeader"
        Me.lblSubtotalHeader.Size = New System.Drawing.Size(74, 23)
        Me.lblSubtotalHeader.TabIndex = 4
        Me.lblSubtotalHeader.Text = "Subtotal"
        '
        'lblQuantityHeader
        '
        Me.lblQuantityHeader.AutoSize = True
        Me.lblQuantityHeader.Location = New System.Drawing.Point(371, 37)
        Me.lblQuantityHeader.Name = "lblQuantityHeader"
        Me.lblQuantityHeader.Size = New System.Drawing.Size(76, 23)
        Me.lblQuantityHeader.TabIndex = 3
        Me.lblQuantityHeader.Text = "Quantity"
        '
        'lblPriceHeader
        '
        Me.lblPriceHeader.AutoSize = True
        Me.lblPriceHeader.Location = New System.Drawing.Point(261, 37)
        Me.lblPriceHeader.Name = "lblPriceHeader"
        Me.lblPriceHeader.Size = New System.Drawing.Size(47, 23)
        Me.lblPriceHeader.TabIndex = 2
        Me.lblPriceHeader.Text = "Price"
        '
        'lblNameHeader
        '
        Me.lblNameHeader.AutoSize = True
        Me.lblNameHeader.Location = New System.Drawing.Point(96, 37)
        Me.lblNameHeader.Name = "lblNameHeader"
        Me.lblNameHeader.Size = New System.Drawing.Size(56, 23)
        Me.lblNameHeader.TabIndex = 1
        Me.lblNameHeader.Text = "Name"
        '
        'lblNumberHeader
        '
        Me.lblNumberHeader.AutoSize = True
        Me.lblNumberHeader.Location = New System.Drawing.Point(24, 37)
        Me.lblNumberHeader.Name = "lblNumberHeader"
        Me.lblNumberHeader.Size = New System.Drawing.Size(37, 23)
        Me.lblNumberHeader.TabIndex = 0
        Me.lblNumberHeader.Text = "No."
        '
        'lblTableNo
        '
        Me.lblTableNo.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableNo.Location = New System.Drawing.Point(125, 32)
        Me.lblTableNo.Name = "lblTableNo"
        Me.lblTableNo.Size = New System.Drawing.Size(138, 30)
        Me.lblTableNo.TabIndex = 3
        Me.lblTableNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(35, 35)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(86, 23)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Table No :"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(353, 321)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(54, 23)
        Me.lbltotal.TabIndex = 5
        Me.lbltotal.Text = "total :"
        '
        'lbltotalPrice
        '
        Me.lbltotalPrice.Location = New System.Drawing.Point(413, 321)
        Me.lbltotalPrice.Name = "lbltotalPrice"
        Me.lbltotalPrice.Size = New System.Drawing.Size(105, 39)
        Me.lbltotalPrice.TabIndex = 6
        '
        'PaymentMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1199, 843)
        Me.Controls.Add(Me.PanelPayment)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PaymentMain"
        Me.Text = "PaymentMain"
        Me.panelPaymentCash.ResumeLayout(False)
        Me.panelCashInput.ResumeLayout(False)
        Me.PanelKeyboard.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelPayment.ResumeLayout(False)
        Me.GrpBxPaymentMethod.ResumeLayout(False)
        Me.GrpBxPaymentMethod.PerformLayout()
        Me.grpCart.ResumeLayout(False)
        Me.grpCart.PerformLayout()
        Me.grpOrderItem.ResumeLayout(False)
        Me.grpOrderItem.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picClose As PictureBox
    Friend WithEvents picMax As PictureBox
    Friend WithEvents picMin As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents radCash As RadioButton
    Friend WithEvents radQR As RadioButton
    Friend WithEvents btnBack As Button
    Friend WithEvents panelPaymentCash As Panel
    Friend WithEvents btnCalculate As Button
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
End Class
