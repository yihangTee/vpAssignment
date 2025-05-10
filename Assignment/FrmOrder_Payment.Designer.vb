<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrder_Payment
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
        Me.btnSalesReport = New System.Windows.Forms.Button()
        Me.btnOrderHistory = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSalesReport
        '
        Me.btnSalesReport.Location = New System.Drawing.Point(106, 150)
        Me.btnSalesReport.Name = "btnSalesReport"
        Me.btnSalesReport.Size = New System.Drawing.Size(132, 82)
        Me.btnSalesReport.TabIndex = 0
        Me.btnSalesReport.Text = "Generate Sales Report"
        Me.btnSalesReport.UseVisualStyleBackColor = True
        '
        'btnOrderHistory
        '
        Me.btnOrderHistory.Location = New System.Drawing.Point(295, 150)
        Me.btnOrderHistory.Name = "btnOrderHistory"
        Me.btnOrderHistory.Size = New System.Drawing.Size(132, 82)
        Me.btnOrderHistory.TabIndex = 1
        Me.btnOrderHistory.Text = "Order History"
        Me.btnOrderHistory.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(466, 150)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(132, 82)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FrmOrder_Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnOrderHistory)
        Me.Controls.Add(Me.btnSalesReport)
        Me.Name = "FrmOrder_Payment"
        Me.Text = "FrmOrder_Payment"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalesReport As Button
    Friend WithEvents btnOrderHistory As Button
    Friend WithEvents btnBack As Button
End Class
