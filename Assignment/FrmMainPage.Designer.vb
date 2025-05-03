<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainPage
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
        Me.btnStaffModule = New System.Windows.Forms.Button()
        Me.btnOrderPage = New System.Windows.Forms.Button()
        Me.btnItemModule = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStaffModule
        '
        Me.btnStaffModule.Location = New System.Drawing.Point(83, 160)
        Me.btnStaffModule.Name = "btnStaffModule"
        Me.btnStaffModule.Size = New System.Drawing.Size(128, 86)
        Me.btnStaffModule.TabIndex = 0
        Me.btnStaffModule.Text = "Staff Module"
        Me.btnStaffModule.UseVisualStyleBackColor = True
        '
        'btnOrderPage
        '
        Me.btnOrderPage.Location = New System.Drawing.Point(237, 160)
        Me.btnOrderPage.Name = "btnOrderPage"
        Me.btnOrderPage.Size = New System.Drawing.Size(128, 86)
        Me.btnOrderPage.TabIndex = 1
        Me.btnOrderPage.Text = "Order Page"
        Me.btnOrderPage.UseVisualStyleBackColor = True
        '
        'btnItemModule
        '
        Me.btnItemModule.Location = New System.Drawing.Point(380, 160)
        Me.btnItemModule.Name = "btnItemModule"
        Me.btnItemModule.Size = New System.Drawing.Size(128, 86)
        Me.btnItemModule.TabIndex = 2
        Me.btnItemModule.Text = "Item Module"
        Me.btnItemModule.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(532, 160)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(128, 86)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(307, 282)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(128, 86)
        Me.btnLogOut.TabIndex = 4
        Me.btnLogOut.Text = "Log out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'FrmMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnItemModule)
        Me.Controls.Add(Me.btnOrderPage)
        Me.Controls.Add(Me.btnStaffModule)
        Me.Name = "FrmMainPage"
        Me.Text = "FrmMainPage"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStaffModule As Button
    Friend WithEvents btnOrderPage As Button
    Friend WithEvents btnItemModule As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnLogOut As Button
End Class
