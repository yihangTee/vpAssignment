Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Drawing

Public Class FrmGenerateStaffReport
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click, GenerateReportToolStripMenuItem.Click
        If radPDF.Checked Then
            GeneratePdfReport()
        ElseIf radText.Checked Then
            If chkProfileImage.Checked Then
                MessageBox.Show("Plain text do not support images. Use PDF instead.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                chkProfileImage.Checked = False
                Return
            End If
            GenerateTextReport()
        Else
            MessageBox.Show("Please choose one of the file format (PDF/Txt) before generating report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        btnBack.PerformClick()
    End Sub


    Private Sub GeneratePdfReport()
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "PDF Files (*.pdf)|*.pdf"
        sfd.FileName = "StaffReport" & Date.Now.ToString("yyyy-MM-dd") & ".pdf"

        If sfd.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = sfd.FileName

            Dim db As New BL_farizDataContext()

            Dim staffList As IEnumerable(Of Staff)
            If chkInactiveStaff.Checked Then
                staffList = From s In db.Staffs Select s
            Else
                staffList = From s In db.Staffs Where s.Status = "Active" Select s
            End If

            Dim doc As New Document(PageSize.A4.Rotate())
            PdfWriter.GetInstance(doc, New FileStream(filePath, FileMode.Create))
            doc.Open()

            ' --- Add Logo ---
            Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(My.Resources.BFLogo, Imaging.ImageFormat.Png)
            logo.ScaleAbsolute(60, 60)
            doc.Add(logo)

            '--- Add Title ---
            Dim titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)
            doc.Add(New Paragraph("Staff Report", titleFont))
            doc.Add(New Paragraph("Generated on: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm")))
            doc.Add(New Paragraph(" "))

            ' --- Setup Table ---
            Dim includeImage As Boolean = chkProfileImage.Checked
            Dim columnCount As Integer = If(includeImage, 9, 8)
            Dim table As New PdfPTable(columnCount) ' Number of columns
            table.WidthPercentage = 100

            If includeImage Then
                table.SetWidths(New Single() {1.0F, 1.5F, 2.0F, 1.0F, 2.0F, 2.5F, 2.0F, 1.5F, 1.0F})
            Else
                table.SetWidths(New Single() {1.0F, 2.0F, 1.0F, 2.0F, 2.5F, 2.0F, 1.5F, 1.0F})
            End If

            ' --- Header Row ---
            If includeImage Then
                table.AddCell(New Phrase("Image", FontFactory.GetFont(FontFactory.HELVETICA_BOLD)))
            End If
            Dim headers As String() = {"ID", "Name", "Gender", "Contact", "Email", "Department", "Role", "Status"}
            For Each header In headers
                table.AddCell(New Phrase(header, FontFactory.GetFont(FontFactory.HELVETICA_BOLD)))
            Next

            ' --- Data Rows ---
            For Each staff In staffList
                If includeImage Then
                    If staff.ProfileImage IsNot Nothing Then
                        Try
                            ' Resize image before loading into memory
                            Dim img As iTextSharp.text.Image = ResizeImage(staff.ProfileImage.ToArray(), 60, 60)
                            Dim imgCell As New PdfPCell(img, True)
                            imgCell.HorizontalAlignment = Element.ALIGN_CENTER
                            imgCell.VerticalAlignment = Element.ALIGN_MIDDLE
                            imgCell.FixedHeight = 60.0F ' Keep cell height consistent
                            table.AddCell(imgCell)
                        Catch ex As Exception
                            table.AddCell("Invalid Image")
                        End Try
                    Else
                        Dim noImgCell As New PdfPCell(New Phrase("No Image"))
                        noImgCell.HorizontalAlignment = Element.ALIGN_CENTER
                        noImgCell.VerticalAlignment = Element.ALIGN_MIDDLE
                        noImgCell.FixedHeight = 60.0F
                        table.AddCell(noImgCell)
                    End If
                End If

                ' Add Staff Data Cells
                table.AddCell(staff.StaffID.ToString())
                table.AddCell(staff.FirstName & " " & staff.LastName)
                table.AddCell(staff.Gender)
                table.AddCell(staff.ContactNumber)
                table.AddCell(staff.EmailAddress)
                table.AddCell(staff.Department)
                table.AddCell(staff.Role)
                table.AddCell(staff.Status)
            Next

            doc.Add(table)
            doc.Close()

            If File.Exists(filePath) Then
                MessageBox.Show("PDF successfully saved to: " & filePath)
                Try
                    Process.Start("explorer.exe", filePath)
                Catch ex As Exception
                    MessageBox.Show("Could not open the PDF automatically. Please open it manually.")
                End Try
            Else
                MessageBox.Show("PDF failed to save.")
            End If
        End If
    End Sub

    ' --- Resize Image Helper Function ---
    Private Function ResizeImage(ByVal imageBytes As Byte(), ByVal newWidth As Integer, ByVal newHeight As Integer) As iTextSharp.text.Image
        ' Create a MemoryStream from the byte array
        Using ms As New MemoryStream(imageBytes)
            ' Load the image from the MemoryStream using System.Drawing.Image
            Dim img As System.Drawing.Image = System.Drawing.Image.FromStream(ms)

            ' Resize the image using System.Drawing.Bitmap
            Dim resizedImg As New System.Drawing.Bitmap(img, New Size(newWidth, newHeight))

            ' Create a MemoryStream for the resized image
            Using resizedMs As New MemoryStream()
                resizedImg.Save(resizedMs, Imaging.ImageFormat.Png) ' Save resized image to the memory stream
                resizedMs.Seek(0, SeekOrigin.Begin) ' Reset the memory stream position

                ' Convert the resized image to an iTextSharp.text.Image object
                Return iTextSharp.text.Image.GetInstance(resizedMs.ToArray())
            End Using
        End Using
    End Function


    Private Sub GenerateTextReport()
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Text Files (*.txt)|*.txt"
        sfd.FileName = "StaffReport" & Date.Now.ToString("yyyy-MM-dd") & ".txt"

        If sfd.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = sfd.FileName

            Dim db As New BL_farizDataContext()
            Dim staffList As IEnumerable(Of Staff)
            If chkInactiveStaff.Checked Then
                staffList = From s In db.Staffs Select s
            Else
                staffList = From s In db.Staffs Where s.Status = "Active" Select s
            End If

            Using writer As New StreamWriter(filePath)
                writer.WriteLine("STAFF REPORT")
                writer.WriteLine("Generated on: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm"))
                writer.WriteLine(New String("="c, 50))

                For Each staff In staffList
                    writer.WriteLine(String.Format("{0,-12}: {1}", "Staff ID", staff.StaffID))
                    writer.WriteLine(String.Format("{0,-12}: {1}", "Name", staff.FirstName & " " & staff.LastName))
                    writer.WriteLine(String.Format("{0,-12}: {1}", "Gender", staff.Gender))
                    writer.WriteLine(String.Format("{0,-12}: {1}", "Contact", staff.ContactNumber))
                    writer.WriteLine(String.Format("{0,-12}: {1}", "Email", staff.EmailAddress))
                    writer.WriteLine(String.Format("{0,-12}: {1}", "Department", staff.Department))
                    writer.WriteLine(String.Format("{0,-12}: {1}", "Role", staff.Role))
                    writer.WriteLine(String.Format("{0,-12}: {1}", "Status", staff.Status))
                    writer.WriteLine(New String("-"c, 50))
                Next

                writer.WriteLine("END OF REPORT")
            End Using

            If File.Exists(filePath) Then
                MessageBox.Show("Text file saved: " & filePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Process.Start("notepad.exe", filePath)


            Else
                MessageBox.Show("Failed to save text file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, ExitToolStripMenuItem.Click
        Me.Close()
        FrmUserProfile.Show()
    End Sub

    Private Sub FieldGuidelineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldGuidelineToolStripMenuItem.Click
        MessageBox.Show(
        "GENERATING REPORT TIPS:" & vbCrLf & vbCrLf &
        "• Choose the desired file format" & vbCrLf &
        "• Select from the radio button (e.g PDF/Txt)" & vbCrLf &
         "• Include the desired staff info" & vbCrLf &
        "• Select from the checkbox (e.g Profile Image - only available for PDF file/ Inactive staff)" & vbCrLf &
        "• to create a staff report and automatically open the exported PDF/Txt in File Explorer.",
        "Generate Report Help",
        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class