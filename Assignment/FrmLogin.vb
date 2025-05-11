Imports System.Data.Linq
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class FrmLogin
    'Private sampleUsername As String = "FarizQQ"
    ' Private salmplePassword As String = "Fariz*12"
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mskUsername.Focus()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = True Then
            mskPassword.UseSystemPasswordChar = False
        Else
            mskPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = mskUsername.Text.Trim
        Dim password As String = mskPassword.Text.Trim
        Dim blnCkhUsernameAndPasssword As Boolean = CheckUsernameAndPassword(username, password)

        If blnCkhUsernameAndPasssword Then
            retrieveInfo(username)
            MessageBox.Show("Welcome [" & App.CurrentUserName & "]", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            err.SetError(mskUsername, "")
            err.SetError(mskPassword, "")
            Me.Hide()
            'FrmUserProfile.Show()
            FrmMainPage.Show()

        Else
            ' Clear existing errors first
            err.SetError(mskUsername, "")
            err.SetError(mskPassword, "")

            ' Set error for missing username
            If String.IsNullOrEmpty(username) Then
                err.SetError(mskUsername, "Username is required.")
                mskUsername.Focus()
            End If

            ' Set error for missing password
            If String.IsNullOrEmpty(password) Then
                err.SetError(mskPassword, "Password is required.")
                If Not String.IsNullOrEmpty(username) Then
                    mskPassword.Focus() ' Only focus password if username is filled
                End If
            End If

            ' Set generic error if username and password are filled but incorrect
            If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) Then
                err.SetError(mskUsername, "Username or password is incorrect.")
                err.SetError(mskPassword, "Username or password is incorrect.")
            End If
        End If

        FrmTable.lblName.Text = username
    End Sub

    Private Function CheckUsernameAndPassword(strUsername As String, strPassword As String) As Boolean
        Dim result As Boolean = False
        ' The Data Context object acts like the data manager
        ' It translates the LINQ query into SQL
        Dim db As New BL_farizDataContext()
        'Query the database using LINQ
        Dim user = (From u In db.Staffs
                    Where u.Username = strUsername AndAlso u.Password = strPassword
                    Select u).FirstOrDefault()

        If user IsNot Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        mskUsername.Text = ""
        mskPassword.Text = ""
        mskUsername.Focus()
        err.Clear()
    End Sub

    Private Sub retrieveInfo(ByVal strUsername As String)
        Dim db As New BL_farizDataContext()
        Dim retrieveStaffName As String = (From u In db.Staffs
                                           Where u.Username = strUsername
                                           Select u.FirstName & " " & u.LastName).FirstOrDefault()
        Dim retrieveStaffDepartment As String = (From u In db.Staffs
                                                 Where u.Username = strUsername
                                                 Select u.Department).FirstOrDefault()
        Dim retrieveStaffId As String = (From u In db.Staffs
                                         Where u.Username = strUsername
                                         Select u.StaffID).FirstOrDefault
        App.CurrentUserName = retrieveStaffName
        App.CurrentUserDepartment = retrieveStaffDepartment
        App.CurrentUserID = retrieveStaffId

    End Sub

    Private Sub lnkForgetPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgetPassword.LinkClicked
        Me.Hide()
        FrmForgotPassword.Show()
    End Sub
End Class