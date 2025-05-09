Imports System.Data.Linq
Imports System.Runtime.Remoting.Lifetime
Imports System.Text.RegularExpressions

Public Class FrmAddStaff
    Private staffId As String = App.GetNextId()
    Private Sub FrmAddStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnReset.PerformClick()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
            txtConfirmPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
            txtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click, BrowseToolStripMenuItem.Click
        Dim dlgOpen As New OpenFileDialog
        dlgOpen.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png;*.jpeg"
        If dlgOpen.ShowDialog = DialogResult.OK Then
            picProfileImage.Image = Image.FromFile(dlgOpen.FileName)
            picProfileImage.Tag = dlgOpen.FileName ' Use Tag to check if image was uploaded
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click, ResetToolStripMenuItem.Click
        If App.intCount < App.Staffs.Length Then
            grpEntry1.Enabled = True
            grpEntry2.Enabled = True
        Else
            MessageBox.Show("The maximum number of staff records has been reached.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            grpEntry1.Enabled = False
            grpEntry2.Enabled = False
            btnSubmit.Enabled = False
            btnReset.Enabled = False
        End If
        txtFirstName.Clear()
        txtLastName.Clear()
        radMale.Checked = True
        mskContactNumber.Clear()
        txtEmailAddress.Clear()
        txtStreet.Clear()
        mskZipCode.Clear()
        txtCity.Clear()
        txtState.Clear()
        picProfileImage.Image = Nothing
        picProfileImage.Tag = Nothing
        cboDepartment.SelectedIndex = -1
        cboRole.SelectedIndex = -1
        cboRole.Items.Clear()
        cboRole.Enabled = False
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        chkShowPassword.Checked = False
        txtFirstName.Focus()
        err.Clear()
    End Sub

    Private Function IsDuplicateUsername(strUsername As String) As Boolean
        Dim db As New BL_farizDataContext()
        Dim duplicateUsername = (From s In db.Staffs
                                 Where s.Username = strUsername AndAlso s.StaffID <> staffId
                                 Select s).Any()
        If duplicateUsername Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtFirstName_Validating(sender As Object, e As EventArgs) Handles txtFirstName.Validating
        'set error for missing first name
        If String.IsNullOrEmpty(txtFirstName.Text) Then
            err.SetError(txtFirstName, "The staff's first name is required.")
        Else
            'set error for invalid first name
            If Not App.IsValidName(txtFirstName.Text) Then
                err.SetError(txtFirstName, "First name must only contain letters.")
            Else
                err.SetError(txtFirstName, "")
            End If
        End If

    End Sub

    Private Sub txtLastName_Validating(sender As Object, e As EventArgs) Handles txtLastName.Validating
        'set error for missing last name
        If String.IsNullOrEmpty(txtLastName.Text) Then
            err.SetError(txtLastName, "The staff's last name is required.")
        Else
            'set error for invalid last name
            If Not App.IsValidName(txtLastName.Text) Then
                err.SetError(txtLastName, "Last name must only contain letters.")
            Else
                err.SetError(txtLastName, "")
            End If

        End If
    End Sub

    Private Sub mskContactNumber_Validating(sender As Object, e As EventArgs) Handles mskContactNumber.Validating
        Dim rawInput As String = mskContactNumber.Text.Replace("-", "").Replace("_", "").Replace("(", "").Replace(")", "").Replace(" ", "").Trim()
        'set error for missing contact number
        If String.IsNullOrEmpty(rawInput) Then
            err.SetError(mskContactNumber, "The staff's contact number is required.")
        ElseIf rawInput.Length < 10 Or rawInput.Length > 14 Then
            err.SetError(mskContactNumber, "Contact number must contain between 10 to 14 digits.")
        Else
            err.SetError(mskContactNumber, "")
        End If
    End Sub

    Private Sub txtEmailAddress_Validating(sender As Object, e As EventArgs) Handles txtEmailAddress.Validating
        'set error for missing email
        If String.IsNullOrEmpty(txtEmailAddress.Text) Then
            err.SetError(txtEmailAddress, "The staff's email address is required.")
        Else
            'set error for invalid email address
            If Not App.IsValidEmail(txtEmailAddress.Text) Then
                err.SetError(txtEmailAddress, "Email address must contain at least includes a letter infront of '@', a '@', a letter between '@' and '.', and a letter behind '.'.")
            Else
                err.SetError(txtEmailAddress, "")
            End If
        End If
    End Sub

    Private Sub txtStreet_Validating(sender As Object, e As EventArgs) Handles txtStreet.Validating
        'set error for missing street
        If String.IsNullOrEmpty(txtStreet.Text) Then
            err.SetError(txtStreet, "The staff's street (home address) is required.")
        Else
            err.SetError(txtStreet, "")
        End If
    End Sub

    Private Sub mskZipCode_Validating(sender As Object, e As EventArgs) Handles mskZipCode.Validating
        'set error for missing zip code
        Dim rawInput As String = mskZipCode.Text.Replace("-", "").Replace("_", "").Replace(" ", "").Trim()
        If String.IsNullOrEmpty(rawInput) Then
            err.SetError(mskZipCode, "The staff's zip code (home address) is required.")
        ElseIf rawInput.Length < 4 Or rawInput.Length > 5 Then
            err.SetError(mskZipCode, "Zip code must contain between 4 to 5 digits.")
        Else
            err.SetError(mskZipCode, "")
        End If
    End Sub

    Private Sub txtCity_Validating(sender As Object, e As EventArgs) Handles txtCity.Validating
        'set error for missing city
        If String.IsNullOrEmpty(txtCity.Text) Then
            err.SetError(txtCity, "The staff's city (home address) is required.")
        Else
            err.SetError(txtCity, "")
        End If
    End Sub

    Private Sub txtState_Validating(sender As Object, e As EventArgs) Handles txtState.Validating
        'set error for missing state
        If String.IsNullOrEmpty(txtState.Text) Then
            err.SetError(txtState, "The staff's state (home address) is required.")
        Else
            err.SetError(txtState, "")
        End If
    End Sub

    Private Sub picProfileImage_Validating(sender As Object, e As EventArgs) Handles picProfileImage.Validating
        'set error for missing profile image
        If IsNothing(picProfileImage.Image) Or picProfileImage.Tag Is Nothing Then
            err.SetError(picProfileImage, "The staff's profile image is required.")
        Else
            err.SetError(picProfileImage, "")
        End If
    End Sub

    Private Sub cboDepartment_Validating(sender As Object, e As EventArgs) Handles cboDepartment.Validating
        'set error for missing department
        If cboDepartment.SelectedIndex = -1 Then
            err.SetError(cboDepartment, "The staff's department is required.")
        Else
            err.SetError(cboDepartment, "")
        End If
    End Sub

    Private Sub cboRole_Validating(sender As Object, e As EventArgs) Handles cboRole.Validating
        'set error for missing role
        If cboRole.SelectedIndex = -1 Then
            err.SetError(cboRole, "The staff's role is required.")
        Else
            err.SetError(cboRole, "")
        End If
    End Sub

    Private Sub txtUsername_Validating(sender As Object, e As EventArgs) Handles txtUsername.Validating
        'set error for missing username
        If String.IsNullOrEmpty(txtUsername.Text) Then
            err.SetError(txtUsername, "The staff's username is required.")
        ElseIf IsDuplicateUsername(txtUsername.Text) Then
            err.SetError(txtUsername, "The staff's username is already taken. Please choose another one")
        Else
            err.SetError(txtUsername, "")
        End If
    End Sub

    Private Sub txtPassword_Validating(sender As Object, e As EventArgs) Handles txtPassword.Validating
        'set error for missing password
        If String.IsNullOrEmpty(txtPassword.Text) Then
            err.SetError(txtPassword, "The staff's password is required.")
        Else
            'set error for invalid password
            If Not App.IsValidPassword(txtPassword.Text) Then
                err.SetError(txtPassword, "Password must contain a least a number, uppercase and lowercase letter, and special char.")
            Else
                err.SetError(txtPassword, "")
            End If
        End If
    End Sub

    Private Sub txtConfirmPassword_Validating(sender As Object, e As EventArgs) Handles txtConfirmPassword.Validating
        'set error for missing confirm password
        If String.IsNullOrEmpty(txtConfirmPassword.Text) Then
            err.SetError(txtConfirmPassword, "The staff's confirm password is required.")
        Else
            'set error for unmatching confirm password
            If Not App.IsValidConfirmPassword(txtPassword.Text, txtConfirmPassword.Text) Then
                err.SetError(txtConfirmPassword, "Password and confirm password does not matched.")
            Else
                err.SetError(txtConfirmPassword, "")
            End If
        End If
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click, SubmitToolStripMenuItem.Click
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

            'set error for missing street
            If String.IsNullOrEmpty(txtStreet.Text) Then
                err.SetError(txtStreet, "The staff's street (home address) is required.")
                Return
            Else
                err.SetError(txtStreet, "")
            End If

            'set error for missing zip code
            Dim rawInput2 As String = mskZipCode.Text.Replace("-", "").Replace("_", "").Replace(" ", "").Trim()
            If String.IsNullOrEmpty(rawInput2) Then
                err.SetError(mskZipCode, "The staff's zip code (home address) is required.")
                Return
            ElseIf rawInput2.Length < 4 Or rawInput2.Length > 5 Then
                err.SetError(mskZipCode, "Zip code must contain between 4 to 5 digits.")
            Else
                err.SetError(mskZipCode, "")
            End If

            'set error for missing city
            If String.IsNullOrEmpty(txtCity.Text) Then
                err.SetError(txtCity, "The staff's city (home address) is required.")
                Return
            Else
                err.SetError(txtCity, "")
            End If

            'set error for missing state
            If String.IsNullOrEmpty(txtState.Text) Then
                err.SetError(txtState, "The staff's state (home address) is required.")
                Return
            Else
                err.SetError(txtState, "")
            End If

            'set error for missing profile image
            If IsNothing(picProfileImage.Image) Or picProfileImage.Tag Is Nothing Then
                err.SetError(picProfileImage, "The staff's profile image is required.")
                Return
            Else
                err.SetError(picProfileImage, "")
            End If

            'set error for missing department
            If cboDepartment.SelectedIndex = -1 Then
                err.SetError(cboDepartment, "The staff's department is required.")
                Return
            Else
                err.SetError(cboDepartment, "")
            End If

            'set error for missing role
            If cboRole.SelectedIndex = -1 Then
                err.SetError(cboRole, "The staff's role is required.")
                Return
            Else
                err.SetError(cboRole, "")
            End If

            'set error for missing username
            If String.IsNullOrEmpty(txtUsername.Text) Then
                err.SetError(txtUsername, "The staff's username is required.")
                Return
            ElseIf IsDuplicateUsername(txtUsername.Text) Then
                err.SetError(txtUsername, "The staff's username is already taken. Please choose another one")
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

            'set error for missing confirm password
            If String.IsNullOrEmpty(txtConfirmPassword.Text) Then
                err.SetError(txtConfirmPassword, "The staff's confirm password is required.")
                Return
            Else
                'set error for unmatching confirm password
                If Not App.IsValidConfirmPassword(txtPassword.Text, txtConfirmPassword.Text) Then
                    err.SetError(txtConfirmPassword, "Password and confirm password does not matched.")
                    Return
                Else
                    err.SetError(txtConfirmPassword, "")
                End If
            End If
        End If


        '1. Read the inputs and assign to variable

        Dim staffFirstName As String = txtFirstName.Text.Trim
            Dim staffLastName As String = txtLastName.Text.Trim
            Dim staffGender As String = ""

            If radMale.Checked Then
                staffGender = "Male"
            ElseIf radFemale.Checked Then
                staffGender = "Female"
            End If

            Dim staffContactNumber As String = mskContactNumber.Text.Replace("-", "").Replace("_", "").Replace("(", "").Replace(")", "").Replace(" ", "").Trim()
            Dim staffEmailAddress As String = txtEmailAddress.Text.Trim
            Dim staffHomeAddress As String = txtStreet.Text.Trim & ", " & mskZipCode.Text.Trim _
            & " " & txtCity.Text.Trim & ", " & txtState.Text.Trim

            Dim staffProfileImage As Byte() = App.ImageToByteArray(picProfileImage.Image)
            Dim staffDepartment As String = cboDepartment.Text
            Dim staffRole As String = cboRole.Text
            Dim staffUsername As String = txtUsername.Text

        Dim strPassword As String = txtPassword.Text
        Dim staffDateOfRegistered As Date = Date.Now


            ' 2. Create a new Staff object and set its properties
            Dim newStaff As New Staff()
            newStaff.StaffID = staffId
            newStaff.FirstName = staffFirstName
            newStaff.LastName = staffLastName
            newStaff.Gender = staffGender
            newStaff.ContactNumber = staffContactNumber
            newStaff.EmailAddress = staffEmailAddress
            newStaff.HomeAddress = staffHomeAddress
            newStaff.ProfileImage = staffProfileImage
            newStaff.Department = staffDepartment
            newStaff.Role = staffRole
        newStaff.Username = staffUsername
        newStaff.Password = strPassword
        newStaff.CreatedDate = staffDateOfRegistered
            newStaff.Status = "Active"
            newStaff.CreatedBy = App.CurrentUserName
            ' Confirm before saving
            If MessageBox.Show("Are you sure you want to save this staff record?", "Confirm",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Return
            End If

        ' 3. Insert the Customer record using LINQ (or your DB context)
        Dim db As New BL_farizDataContext()

        db.Staffs.InsertOnSubmit(newStaff)
            db.SubmitChanges()
            ' 4. Show a message box to indicate insertion done
            MessageBox.Show("Staff [" & staffFirstName & " " & staffLastName & "] added into the database",
                    "Insert successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnReset.PerformClick()

            btnBack.PerformClick()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, ExitToolStripMenuItem.Click
        Me.Close()
        FrmUserProfile.Show()
    End Sub

    Private Sub FieldGuidelineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldGuidelineToolStripMenuItem.Click
        MessageBox.Show(
        "ADDING STAFF GUIDE:" & vbCrLf & vbCrLf &
        "1. Staff First Name: Enter alphabetic characters only" & vbCrLf &
        "2. Staff Last Name: Enter alphabetic characters only" & vbCrLf &
        "3. Staff Gender: Click either one to select gender" & vbCrLf &
        "4. Staff Contact Number: Enter digit numbers between 10 and 14" & vbCrLf &
        "5. Staff Email Address: Enter email address with at least a letter infront of '@', a '@', a letter between '@' and '.', and a letter behind '.'" & vbCrLf &
        "6. Staff Street (Home Address): Enter the staff's street (home address)" & vbCrLf &
        "7. Staff Zip Code (Home Address): Enter the staff's zip code (home address)" & vbCrLf &
        "8. Staff City (Home Address): Enter the staff's city (home address)" & vbCrLf &
        "9. Staff State/Province (Home Address): Enter the staff's state/province (home address)" & vbCrLf &
        "10. Staff Profile Image: Browse to upload the staff's profile image in your file" & vbCrLf &
        "11. Staff Department: Double click to select the staff's department" & vbCrLf &
        "12. Staff Role: Double click to select the staff's role (After select the staff's department)" & vbCrLf &
        "13. Staff Username: Enter the registered staff's username" & vbCrLf &
        "14. Staff Password: Enter password with at least a number, uppercase and lowercase letter, and special character" & vbCrLf &
        "15. Staff Confirm Password: Enter confirm password with the same as password above" & vbCrLf &
        "• Press Submit button to insert the new staff list record",
         "Add Staff Help",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartment.SelectedIndexChanged
        Dim intSelectedIndex As Integer = cboDepartment.SelectedIndex

        If intSelectedIndex < 0 Then Exit Sub 'Prevent accessing -1 index

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