Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Text
Imports Microsoft.Win32
Imports System.Transactions

Public Class FrmStaffDetails
    Public strSelectedId As String
    Dim reasons As New StringBuilder()
    Private Sub reserForm()
        lblId.Text = ""
        txtFirstName.Clear()
        txtLastName.Clear()
        radMale.Checked = True
        mskContactNumber.Clear()
        txtEmailAddress.Clear()
        rtxtHomeAddress.Clear()
        picProfileImage.Image = Nothing
        picProfileImage.Tag = Nothing
        cboDepartment.SelectedIndex = -1
        cboRole.SelectedIndex = -1
        cboRole.Enabled = False
        radActive.Checked = True
        txtUsername.Clear()
        txtPassword.Clear()
        err.Clear()
    End Sub

    Private Sub FrmStaffDetails_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        reserForm()
        Dim db As New BL_farizDataContext()
        Dim s As Staff = db.Staffs.FirstOrDefault(Function(o) o.StaffID = strSelectedId)
        ' Staff found --> Display details
        lblId.Text = s.StaffID
        txtFirstName.Text = s.FirstName
        txtLastName.Text = s.LastName
        Select Case s.Gender
            Case "Female" : radFemale.Checked = True
            Case "Male" : radMale.Checked = True
        End Select
        mskContactNumber.Text = s.ContactNumber
        txtEmailAddress.Text = s.EmailAddress
        rtxtHomeAddress.Text = s.HomeAddress

        Dim staffImg = s.ProfileImage

        If staffImg IsNot Nothing AndAlso staffImg.Length > 0 Then
            Try
                Dim imgBytes As Byte() = staffImg.ToArray()
                Using ms As New IO.MemoryStream(imgBytes)
                    picProfileImage.Image = Image.FromStream(ms)
                End Using
            Catch ex As Exception
                picProfileImage.Image = Nothing
            End Try
        Else
            picProfileImage.Image = Nothing
        End If

        cboDepartment.Text = s.Department
        cboRole.Text = s.Role
        lblDateOfRegistered.Text = s.CreatedDate.ToString
        radActive.Checked = (s.Status = "Active")
        radInactive.Checked = (s.Status = "Inactive")
        If radInactive.Checked Then
            btnDelete.Enabled = False
        End If
        txtUsername.Text = s.Username
        txtPassword.Text = s.Password
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click, UpdateToolStripMenuItem.Click
        'STOP if any input is invalid
        If Me.ValidateChildren() = False Then
            Return
        Else
            'set error for missing first name
            If String.IsNullOrEmpty(txtFirstName.Text) Then
                err.SetError(txtFirstName, "The staff's first name is required.")
                Return
            Else
                'set error for invalid first name
                If Not App.IsValidName(txtFirstName.Text) Then
                    err.SetError(txtFirstName, "First name must only contain letters.")
                    Return
                Else
                    err.SetError(txtFirstName, "")
                End If
            End If

            'set error for missing last name
            If String.IsNullOrEmpty(txtLastName.Text) Then
                err.SetError(txtLastName, "The staff's last name is required.")
                Return
            Else
                'set error for invalid last name
                If Not App.IsValidName(txtLastName.Text) Then
                    err.SetError(txtLastName, "Last name must only contain letters.")
                    Return
                Else
                    err.SetError(txtLastName, "")
                End If
            End If

            Dim rawInput1 As String = mskContactNumber.Text.Replace("-", "").Replace("_", "").Replace("(", "").Replace(")", "").Replace(" ", "").Trim()
            'set error for missing contact number
            If String.IsNullOrEmpty(rawInput1) Then
                err.SetError(mskContactNumber, "The staff's contact number is required.")
                Return
            ElseIf rawInput1.Length < 10 Or rawInput1.Length > 14 Then
                err.SetError(mskContactNumber, "Contact number must contain between 10 to 14 digits.")
                Return
            Else
                err.SetError(mskContactNumber, "")
            End If

            'set error for missing email
            If String.IsNullOrEmpty(txtEmailAddress.Text) Then
                err.SetError(txtEmailAddress, "The staff's email address is required.")
                Return
            Else
                'set error for invalid email address
                If Not App.IsValidEmail(txtEmailAddress.Text) Then
                    err.SetError(txtEmailAddress, "Email address must contain at least includes a letter infront of '@', a '@', a letter between '@' and '.', and a letter behind '.'.")
                    Return
                Else
                    err.SetError(txtEmailAddress, "")
                End If
            End If

            'set error for missing home address
            If String.IsNullOrEmpty(rtxtHomeAddress.Text) Then
                err.SetError(rtxtHomeAddress, "The staff's home address is required.")
                Return
            Else
                err.SetError(rtxtHomeAddress, "")
            End If

            'set error for missing username
            If String.IsNullOrEmpty(txtUsername.Text) Then
                err.SetError(txtUsername, "The staff's username is required.")
                Return
            Else
                err.SetError(txtUsername, "")
            End If

            'set error for missing password
            If String.IsNullOrEmpty(txtPassword.Text) Then
                err.SetError(txtPassword, "The staff's password is required.")
                Return
            Else
                'set error for invalid password
                If Not App.IsValidPassword(txtPassword.Text) Then
                    err.SetError(txtPassword, "Password must contain a least a number, uppercase and lowercase letter, and special char.")
                    Return
                Else
                    err.SetError(txtPassword, "")
                End If
            End If
        End If
        If MessageBox.Show("Are you sure you want to update this staff record?", "Confirm Updation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Dim db As New BL_farizDataContext()

        ' 1. Find staff
        Dim staffToUpdate = db.Staffs.FirstOrDefault(Function(o) o.StaffID = strSelectedId)

        ' 2. Update staff
        staffToUpdate.FirstName = txtFirstName.Text.Trim()
            staffToUpdate.LastName = txtLastName.Text.Trim()
            staffToUpdate.Gender = If(radMale.Checked, "Male", If(radFemale.Checked, "Female", ""))
            staffToUpdate.ContactNumber = mskContactNumber.Text.Replace("-", "").Replace("_", "").Replace("(", "").Replace(")", "").Replace(" ", "").Trim()
            staffToUpdate.EmailAddress = txtEmailAddress.Text.Trim()
            staffToUpdate.HomeAddress = rtxtHomeAddress.Text.Trim()
            staffToUpdate.ProfileImage = App.ImageToByteArray(picProfileImage.Image)
            staffToUpdate.Department = cboDepartment.Text
        staffToUpdate.Role = cboRole.Text
        staffToUpdate.Status = If(radActive.Checked, "Active", If(radInactive.Checked, "Inactive", ""))
        staffToUpdate.Username = txtUsername.Text
        ' Save hashedPassword to the database
        staffToUpdate.Password = txtPassword.Text
        db.SubmitChanges()
        MessageBox.Show("Staff updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnBack.PerformClick()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click, DeleteToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to soft delete from this staff record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Dim db As New BL_farizDataContext()
        Dim staffToDelete = db.Staffs.FirstOrDefault(Function(o) o.StaffID = strSelectedId)
        If staffToDelete Is Nothing Then
            MessageBox.Show("Staff record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        staffToDelete.Status = "Inactive"

        db.SubmitChanges()

        MessageBox.Show("Staff record has been marked for deletion on " & Date.Now.ToString("yyyy-MM-dd") & ". Admin will permanently remove it from the database after 3 months.",
            "Soft Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnBack.PerformClick()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, ExitToolStripMenuItem.Click
        Me.Close()
        FrmViewStaff.Show()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click, BrowseToolStripMenuItem.Click
        Dim dlgOpen As New OpenFileDialog
        dlgOpen.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png;*.jpeg"
        If dlgOpen.ShowDialog = DialogResult.OK Then
            picProfileImage.Image = Image.FromFile(dlgOpen.FileName)
            picProfileImage.Tag = dlgOpen.FileName ' Use Tag to check if image was uploaded
        End If
    End Sub

    Private Sub FieldGuidelineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldGuidelineToolStripMenuItem.Click
        MessageBox.Show(
        "MODIFICATION STAFF GUIDE:" & vbCrLf & vbCrLf &
        "1. Staff First Name: Enter alphabetic characters only" & vbCrLf &
        "2. Staff Last Name: Enter alphabetic characters only" & vbCrLf &
        "3. Staff Gender: Click either one to select gender" & vbCrLf &
        "4. Staff Contact Number: Enter digit numbers between 10 and 14" & vbCrLf &
        "5. Staff Email Address: Enter email address with at least a letter infront of '@', a '@', a letter between '@' and '.', and a letter behind '.'" & vbCrLf &
        "6. Staff Home Address: Enter the staff's home address" & vbCrLf &
        "7. Staff Profile Image: Browse to upload the staff's profile image in your file" & vbCrLf &
        "8. Staff Department: Double click to select the staff's department" & vbCrLf &
        "9. Staff Role: Double click to select the staff's role (After select the staff's department)" & vbCrLf &
        "10. Staff Username: Enter the registered staff's username" & vbCrLf &
        "11. Staff Password: Enter password with at least a number, uppercase and lowercase letter, and special character" & vbCrLf &
        "• Press Update button to update the selected staff record" & vbCrLf &
        "• Press Delete button to soft delete the selected staff record",
        "Modication (Update / Delete Staff) Help",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartment.SelectedIndexChanged
        Dim intSelectedIndex As Integer = cboDepartment.SelectedIndex

        'Reset the list role
        cboRole.Items.Clear()


        If cboDepartment.Items(intSelectedIndex).ToString = "Administrative staff" Then
            cboRole.Items.Add("Manager")
            cboRole.Items.Add("Administrator")

        ElseIf cboDepartment.Items(intSelectedIndex).ToString = "Back-Of-House staff" Then
            cboRole.Items.Add("Executive chef")
            cboRole.Items.Add("Cooks")
            cboRole.Items.Add("Kitchen helper")

        ElseIf cboDepartment.Items(intSelectedIndex).ToString = "Front-Of-House staff" Then
            cboRole.Items.Add("Waiter")
            cboRole.Items.Add("Receptionist")

        End If
        cboRole.Enabled = True
    End Sub
End Class