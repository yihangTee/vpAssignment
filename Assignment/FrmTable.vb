Imports System.Data.Linq
Imports System.Data.SqlClient

Public Class FrmTable
    Dim dragging As Boolean = False
    Dim offset As Point
    Dim selectedButton As Button
    Dim EditMode As Boolean = False
    'Dim db As New BL_farizDataContext()

    Private Sub FrmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAddTable.Visible = False
        btnSave.Visible = False
        btnReset.Visible = False
        UpdateEditModeButton()
        LoadTableButtonsFromDB()
        Timer1.Start()
    End Sub

    Private Function NormalizeName(name As String) As String
        Return New String(name.Where(Function(c) Char.IsLetterOrDigit(c)).ToArray()).ToLower()
    End Function

    Private Sub btnAddTable_Click(sender As Object, e As EventArgs) Handles btnAddTable.Click
        Dim tableName As String = InputBox("Enter a name for the new table:", "New Table")

        If String.IsNullOrWhiteSpace(tableName) Then
            MessageBox.Show("Table name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        tableName = tableName.Replace(",", "")

        Dim normalizedInput As String = NormalizeName(tableName)

        While pnlTables.Controls.OfType(Of Button)().Any(Function(b) NormalizeName(b.Text) = normalizedInput)
            tableName = InputBox("The table name already exists. Please enter a different name:",
                                 "New Table", tableName)
            If String.IsNullOrWhiteSpace(tableName) Then
                MessageBox.Show("Table name cannot be empty.", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                Return
            End If
            tableName = tableName.Replace(",", "")
        End While

        Dim btn As New Button With {
        .Name = tableName,
        .Text = tableName,
        .Size = New Size(60, 60),
        .BackColor = Color.LightGreen,
        .Location = New Point(10, 10),
        .ContextMenuStrip = If(EditMode, cmsTable, Nothing)
    }

        AddHandler btn.MouseDown, AddressOf Table_MouseDown
        AddHandler btn.MouseMove, AddressOf Table_MouseMove
        AddHandler btn.MouseUp, AddressOf Table_MouseUp
        AddHandler btn.Click, AddressOf TableButton_Click

        pnlTables.Controls.Add(btn)
    End Sub

    Private Sub Table_MouseMove(sender As Object, e As MouseEventArgs)
        If dragging AndAlso EditMode AndAlso selectedButton IsNot Nothing Then
            Dim newLeft As Integer = selectedButton.Left + e.X - offset.X
            Dim newTop As Integer = selectedButton.Top + e.Y - offset.Y

            If newLeft >= 0 AndAlso newLeft + selectedButton.Width <= pnlTables.Width Then
                selectedButton.Left = newLeft
            End If

            If newTop >= 0 AndAlso newTop + selectedButton.Height <= pnlTables.Height Then
                selectedButton.Top = newTop
            End If
        End If

    End Sub

    Private Sub Table_MouseUp(sender As Object, e As MouseEventArgs)
        dragging = False
        selectedButton = Nothing
    End Sub

    Private Sub Table_MouseDown(sender As Object, e As MouseEventArgs)
        If EditMode AndAlso e.Button = MouseButtons.Left Then
            dragging = True
            selectedButton = CType(sender, Button)
            offset = e.Location
        End If

    End Sub

    Private Sub btnEditMode_Click(sender As Object, e As EventArgs) Handles btnEditMode.Click
        EditMode = Not EditMode
        UpdateEditModeButton()
    End Sub

    Private Sub UpdateEditModeButton()
        If EditMode Then
            btnEditMode.Text = "Edit Mode: On"
            btnEditMode.BackColor = Color.Green
            btnEditMode.ForeColor = Color.White
            btnAddTable.Visible = True
            btnSave.Visible = True
            btnReset.Visible = True
        Else
            btnEditMode.Text = "Edit Mode: Off"
            btnEditMode.BackColor = Color.Red
            btnEditMode.ForeColor = Color.Black
            btnAddTable.Visible = False
            btnSave.Visible = False
            btnReset.Visible = False
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using db As New BL_farizDataContext()
            For Each ctrl As Control In pnlTables.Controls
                If TypeOf ctrl Is Button Then
                    Dim btn As Button = CType(ctrl, Button)
                    Dim existingTable = db.TableNos.FirstOrDefault(Function(t) t.Name = btn.Text)

                    If existingTable IsNot Nothing Then
                        existingTable.X = btn.Left
                        existingTable.Y = btn.Top
                        existingTable.Color = btn.BackColor.ToArgb()
                    Else
                        Dim newTable As New TableNo With {
                    .Name = btn.Text,
                    .X = btn.Left,
                    .Y = btn.Top,
                    .Color = btn.BackColor.ToArgb()
                }
                        db.TableNos.InsertOnSubmit(newTable)
                    End If
                End If
            Next

            db.SubmitChanges()
        End Using
        MessageBox.Show("Layout saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmsTable_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsTable.Opening
        If Not EditMode Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim db As New BL_farizDataContext()
        Dim result = MessageBox.Show("Are you sure you want to reset the layout to default?", "Reset Layout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then

            Dim hasPendingPayments = (
                From o In db.Orders
                Join p In db.Payments On o.OrderID Equals p.OrderID
                Where p.PaymentStatus = "Pending"
            ).Any()

            If hasPendingPayments Then
                MessageBox.Show("Cannot reset layout. One or more tables have pending payments.",
                            "Reset Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            db.TableNos.DeleteAllOnSubmit(db.TableNos)
            db.SubmitChanges()

            pnlTables.Controls.Clear()

            LoadTableButtonsFromDB()

            MessageBox.Show("Layout has been reset to default.", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TableButton_Click(sender As Object, e As EventArgs)
        Dim tableBtn As Button = CType(sender, Button)

        Dim tableName As String = tableBtn.Text

        If EditMode = False Then
            Dim cartPage As New FrmOrder()
            cartPage.lblTableNo.Text = tableName
            cartPage.lblTableNo.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            cartPage.Show()
        End If
    End Sub

    Private Sub LoadTableButtonsFromDB()
        Using db As New BL_farizDataContext()
            Dim tableList = db.TableNos.ToList()

            For Each t In tableList
                Dim btn As New Button With {
            .Text = t.Name,
            .Location = New Point(CInt(t.X), CInt(t.Y)),
            .Size = New Size(60, 60),
            .BackColor = Color.FromArgb(CInt(t.Color)),
            .ContextMenuStrip = cmsTable
        }

                AddHandler btn.MouseDown, AddressOf Table_MouseDown
                AddHandler btn.MouseMove, AddressOf Table_MouseMove
                AddHandler btn.MouseUp, AddressOf Table_MouseUp
                AddHandler btn.Click, AddressOf TableButton_Click

                pnlTables.Controls.Add(btn)
            Next
        End Using
    End Sub

    Private Sub DeleteToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim btn As Button = TryCast(cmsTable.SourceControl, Button)
        Dim db As New BL_farizDataContext()
        If btn IsNot Nothing Then
            Dim tableName As String = btn.Text

            Dim hasPendingPayment = (
                From o In db.Orders
                Join p In db.Payments On o.OrderID Equals p.OrderID
                Where o.TableNo = tableName AndAlso p.PaymentStatus = "Pending"
            ).Any()

            If hasPendingPayment Then
                MessageBox.Show("Cannot delete this table. There is a pending payment associated with it.",
                                "Deletion Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result = MessageBox.Show("Delete " & btn.Text & "?", "Confirm Delete", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                pnlTables.Controls.Remove(btn)
                btn.Dispose()

                Dim tableToDelete = db.TableNos.FirstOrDefault(Function(t) t.Name = tableName)
                If tableToDelete IsNot Nothing Then
                    db.TableNos.DeleteOnSubmit(tableToDelete)
                    db.SubmitChanges()
                End If

                MessageBox.Show("Table deleted successfully.", "Deleted", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("dd/MM hh:mm:ss tt")

        For Each btn As Button In pnlTables.Controls.OfType(Of Button)()
            Dim tableNo As String = btn.Text.Split(New String() {vbCrLf}, StringSplitOptions.None)(0).Trim()
            UpdateTableButtonWithWaitingTime(tableNo)
        Next
    End Sub

    Public Sub UpdateTableButtonWithWaitingTime(tableNo As String)
        Dim db As New BL_farizDataContext()
        Dim btn As Button = pnlTables.Controls.OfType(Of Button)().
                        FirstOrDefault(Function(b) b.Text.StartsWith(tableNo))

        If btn Is Nothing Then Exit Sub

        Dim latestOrder = (From o In db.Orders
                           Where o.TableNo = tableNo
                           Order By o.OrderDateTime Descending
                           Select o).FirstOrDefault()

        If latestOrder IsNot Nothing Then
            Dim isPending = (From p In db.Payments
                             Where p.OrderID = latestOrder.OrderID AndAlso p.PaymentStatus = "Pending"
                             Select p).Any()

            If isPending Then
                Dim waitingTime = DateTime.Now - latestOrder.OrderDateTime
                Dim timeDisplay As String

                If waitingTime.TotalHours < 1 Then
                    timeDisplay = $"{waitingTime.Minutes:D2}:{waitingTime.Seconds:D2}"
                Else
                    timeDisplay = $"{CInt(waitingTime.TotalHours):D2}:{waitingTime.Minutes:D2}:{waitingTime.Seconds:D2}"
                End If

                btn.Text = tableNo

                Dim waitingTimeLabel As Label = btn.Controls.OfType(Of Label)().FirstOrDefault()
                If waitingTimeLabel Is Nothing Then
                    waitingTimeLabel = New Label With {
                    .Text = timeDisplay,
                    .Font = New Font("Arial", 8, FontStyle.Bold),
                    .ForeColor = Color.White,
                    .BackColor = Color.Red,
                    .Padding = New Padding(2),
                    .AutoSize = True
                }
                    btn.Controls.Add(waitingTimeLabel)
                Else
                    waitingTimeLabel.Text = timeDisplay
                End If

                btn.BackColor = Color.Orange
            Else
                btn.Text = tableNo
                btn.BackColor = Color.LightGreen

                Dim waitingTimeLabel As Label = btn.Controls.OfType(Of Label)().FirstOrDefault()
                If waitingTimeLabel IsNot Nothing Then
                    btn.Controls.Remove(waitingTimeLabel)
                End If
            End If
        Else
            btn.Text = tableNo
            btn.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Timer1.Stop()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        FrmMainPage.Show()
    End Sub
End Class
