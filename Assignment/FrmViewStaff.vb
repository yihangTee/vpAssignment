Imports System.Data.Linq

Public Class FrmViewStaff
    Private Sub FrmViewStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnReset.PerformClick()
    End Sub
    Private Sub BindData()
        Dim strName As String = txtName.Text.Trim
        Dim strGender As String = cboGender.Text
        Dim strDepartment As String = cboDepartment.Text
        Dim strRole As String = cboRole.Text
        Dim strStatus As String = cboStatus.Text
        ' The Data Context object acts like the data manager
        ' It translates the LINQ query into SQL
        Dim db As New BL_farizDataContext()

        'LINQ query that selects Customer records from the database
        'Also apply filters that specified via the Where clause
        Dim rs = From c In db.Staffs
                 Where (String.IsNullOrEmpty(strName) Or (c.FirstName & " " & c.LastName).Contains(strName)) And
               (strGender = "All" Or If(c.Gender, "") = strGender) And
               (strDepartment = "All" Or If(c.Department, "") = strDepartment) And
               (strRole = "All" Or If(c.Role, "") = strRole) And
               (strStatus = "All" Or If(c.Status, "") = strStatus)
                 Select New With {
             .StaffID = c.StaffID,
             .Name = c.FirstName & " " & c.LastName,
             .Gender = c.Gender,
             .ContactNo = c.ContactNumber,
             .Email = c.EmailAddress,
             .Department = c.Department,
             .Role = c.Role,
             .Status = c.Status,
             .Username = c.Username
                              }
        Dim results = rs.ToList()

        dgv.DataSource = results
        lblCount.Text = results.Count().ToString("0 record(s)")
    End Sub


    Private Sub cboDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartment.SelectedIndexChanged
        'Reset the list role
        cboRole.Items.Clear()
        cboRole.Items.Add("All")
        'default
        cboRole.Text = "All"

        If cboDepartment.Text = "Administrative staff" Then ' Administrative department
            cboRole.Items.Add("Manager")
            cboRole.Items.Add("Administrator")

        ElseIf cboDepartment.Text = "Back-Of-House staff" Then
            cboRole.Items.Add("Executive chef")
            cboRole.Items.Add("Cooks")
            cboRole.Items.Add("Kitchen helper")

        ElseIf cboDepartment.Text = "Front-Of-House staff" Then
            cboRole.Items.Add("Waiter")
            cboRole.Items.Add("Receptionist")

        End If
        cboRole.Enabled = True

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click, SearchToolStripMenuItem.Click
        BindData()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click, ResetToolStripMenuItem.Click
        txtName.Text = ""
        cboGender.Text = "All"
        cboDepartment.Text = "All"
        cboRole.Text = "All"
        cboRole.Enabled = False
        cboStatus.Text = "All"
        BindData()
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim intNo As Integer = e.RowIndex
        If intNo > -1 Then
            Dim strId As String = CStr(dgv.Rows(intNo).Cells(0).Value)
            Me.Close()
            FrmStaffDetails.strSelectedId = strId
            FrmStaffDetails.Show()
            BindData()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, ExitToolStripMenuItem.Click
        Me.Close()
        FrmUserProfile.Show()
    End Sub

    Private Sub FieldGuidelineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldGuidelineToolStripMenuItem.Click
        MessageBox.Show(
        "VIEWING TIPS:" & vbCrLf & vbCrLf &
        "• Choose ONE of the Aspect from the dropdown" & vbCrLf &
        "• Fill in the necessary information (e.g Name)" & vbCrLf &
        "   OR" & vbCrLf &
        "• Select from the radio button (e.g Male/Female)" & vbCrLf &
        "• Select from the dropdown (e.g Status/Department/Role)" & vbCrLf &
        "• Press Search button will show the staff list below" & vbCrLf &
        "• Double click to modify the selected record",
        "View Help",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class