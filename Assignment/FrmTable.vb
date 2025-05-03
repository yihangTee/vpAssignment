Imports System.Data.Linq
Imports System.Data.SqlClient

Public Class FrmTable
    Dim dragging As Boolean = False
    Dim offset As Point
    Dim selectedButton As Button
    Dim EditMode As Boolean = False

    Private Sub FrmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAddTable.Visible = False
        btnSave.Visible = False
        btnReset.Visible = False
        UpdateEditModeButton()
        LoadTableButtonsFromDB()
        lblName.Text = " Ho Tze Chian"
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
        .Size = New Size(50, 50),
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
        Dim result = MessageBox.Show("Are you sure you want to reset the layout to default?", "Reset Layout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then

            Using db As New BL_FarizDataContext()
                db.TableNos.DeleteAllOnSubmit(db.TableNos)
                db.SubmitChanges()
            End Using


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
            cartPage.Show()
        End If
    End Sub

    Private Sub LoadTableButtonsFromDB()
        Using db As New BL_FarizDataContext()
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
        If btn IsNot Nothing Then
            Dim result = MessageBox.Show("Delete " & btn.Text & "?", "Confirm Delete", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                pnlTables.Controls.Remove(btn)
                btn.Dispose()

                Dim tableName As String = btn.Text

                Using db As New BL_FarizDataContext()
                    Dim tableToDelete = db.TableNos.FirstOrDefault(Function(t) t.Name = tableName)

                    If tableToDelete IsNot Nothing Then
                        db.TableNos.DeleteOnSubmit(tableToDelete)
                        db.SubmitChanges()
                    End If
                End Using


                MessageBox.Show("Table deleted successfully.", "Deleted", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("dd/MM hh:mm:ss tt")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Timer1.Stop()
        Me.Close()
    End Sub

    Private Sub pnlTables_Paint(sender As Object, e As PaintEventArgs) Handles pnlTables.Paint

    End Sub

    Private Sub grpInfo_Enter(sender As Object, e As EventArgs) Handles grpInfo.Enter

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        FrmMainPage.Show()

    End Sub
End Class
