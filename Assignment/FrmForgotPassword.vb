Public Class FrmForgotPassword
    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        Dim username As String = txtUsername.Text
        Dim email As String = txtEmailAddress.Text
        Dim newPassword As String = txtNewPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text

        'set error for missing password
        If String.IsNullOrEmpty(newPassword) Then
            err.SetError(txtNewPassword, "The staff's password is required.")
            Return
        Else
            'set error for invalid password
            If Not App.IsValidPassword(newPassword) Then
                err.SetError(txtNewPassword, "Password must contain a least a number, uppercase and lowercase letter, and special char.")
                Return
            Else
                err.SetError(txtNewPassword, "")
            End If
        End If

        'set error for missing confirm password
        If String.IsNullOrEmpty(txtConfirmPassword.Text) Then
            err.SetError(txtConfirmPassword, "The staff's confirm password is required.")
            Return
        Else
            'set error for unmatching confirm password
            If Not App.IsValidConfirmPassword(newPassword, confirmPassword) Then
                err.SetError(txtConfirmPassword, "Password and confirm password does not matched.")
                Return
            Else
                err.SetError(txtConfirmPassword, "")
            End If
        End If

        Dim db As New BL_farizDataContext()
        Dim user = (From u In db.Staffs
                    Where u.Username = username AndAlso u.EmailAddress = email
                    Select u).FirstOrDefault()

        If user Is Nothing Then
            MessageBox.Show("Username or email does not match any record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        user.Password = newPassword
        db.SubmitChanges()

        MessageBox.Show("Password reset successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        FrmLogin.Show()
    End Sub

    Private Sub txtNewPassword_Validating(sender As Object, e As EventArgs) Handles txtNewPassword.Validating
        'set error for missing password
        If String.IsNullOrEmpty(txtNewPassword.Text) Then
            err.SetError(txtNewPassword, "The staff's password is required.")
        Else
            'set error for invalid password
            If Not App.IsValidPassword(txtNewPassword.Text) Then
                err.SetError(txtNewPassword, "Password must contain a least a number, uppercase and lowercase letter, and special char.")
            Else
                err.SetError(txtNewPassword, "")
            End If
        End If
    End Sub

    Private Sub txtConfirmPassword_Validating(sender As Object, e As EventArgs) Handles txtConfirmPassword.Validating
        'set error for missing confirm password
        If String.IsNullOrEmpty(txtConfirmPassword.Text) Then
            err.SetError(txtConfirmPassword, "The staff's confirm password is required.")
        Else
            'set error for unmatching confirm password
            If Not App.IsValidConfirmPassword(txtNewPassword.Text, txtConfirmPassword.Text) Then
                err.SetError(txtConfirmPassword, "Password and confirm password does not matched.")
            Else
                err.SetError(txtConfirmPassword, "")
            End If
        End If
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = True Then
            txtNewPassword.UseSystemPasswordChar = False
            txtConfirmPassword.UseSystemPasswordChar = False
        Else
            txtNewPassword.UseSystemPasswordChar = True
            txtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class