Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class PaymentMain
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Dim cashAmount As String = ""
    Dim amount As Decimal = 0
    Private Sub NumberButton_Click(sender As Object, e As EventArgs) Handles key1.Click, key2.Click, key3.Click, key4.Click, key5.Click, key6.Click, key7.Click, key8.Click, key9.Click, key0.Click, keyDot.Click
        Dim btn = CType(sender, System.Windows.Forms.Button)
        Dim key As String = btn.Text

        If key = "." Then
            If cashAmount.Contains(".") Then Exit Sub
            If cashAmount = "" Then
                cashAmount = "0."
            Else
                cashAmount &= "."
            End If
        Else
            ' Limit to 2 digits after decimal
            If cashAmount.Contains(".") Then
                Dim decimalPart As String = cashAmount.Split("."c)(1)
                If decimalPart.Length >= 2 Then Exit Sub
            End If
            cashAmount &= key
        End If

        lblPayCash.Text = "RM " & cashAmount
    End Sub

    Private Sub BtnBackspace_Click(sender As Object, e As EventArgs) Handles keyBackspace.Click
        If cashAmount.Length > 0 Then
            cashAmount = cashAmount.Substring(0, cashAmount.Length - 1)
        End If
        lblPayCash.Text = "RM " & cashAmount
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles radCash.CheckedChanged, radQR.CheckedChanged
        panelPaymentCash.Visible = radCash.Checked
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cashAmount = ""
        amount = 0.00D
        lblPayCash.Text = "RM " & cashAmount
        lblChange.Text = "RM " & amount
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim total As Decimal = 10.2D

        If Decimal.TryParse(cashAmount, amount) Then
            Dim result As Decimal = amount - total
            lblChange.Text = "RM " & result.ToString("F2")
        Else
            MessageBox.Show("Invalid number")
        End If
    End Sub

    Private Sub btnSuccessPay_Click(sender As Object, e As EventArgs) Handles btnSuccessPay.Click
        Me.Close()
    End Sub

    Private Sub PaymentMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hihiihi
    End Sub
End Class