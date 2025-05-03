Imports AForge.Video
Imports AForge.Video.DirectShow
Public Class PaymentQR
    Private videoDevices As FilterInfoCollection
    Private videoSource As VideoCaptureDevice
    Public Property SelectedTableNo As String
    Public Property ParentPaymentForm As Form



    Private Sub PaymentQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnIScanYou_Click(sender As Object, e As EventArgs) Handles btnIScanYou.Click
        Try
            ' Show camera panel, hide QR image panel
            panelCamera.Visible = True
            picQR.Visible = False

            videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
            If videoDevices.Count > 0 Then
                videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)
                AddHandler videoSource.NewFrame, AddressOf videoSource_NewFrame
                videoSource.Start()
            Else
                MessageBox.Show("No camera found.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub videoSource_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        Dim bitmap As Bitmap = CType(eventArgs.Frame.Clone(), Bitmap)
        If picCamera.InvokeRequired Then
            picCamera.Invoke(Sub()
                                 picCamera.Image = bitmap
                                 picCamera.SizeMode = PictureBoxSizeMode.StretchImage
                             End Sub)
        Else
            picCamera.Image = bitmap
            picCamera.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btnYouScanMe_Click(sender As Object, e As EventArgs) Handles btnScanMe.Click
        ' Stop camera if it was running
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
        End If

        ' Show QR image panel, hide camera panel
        panelCamera.Visible = False
        picQR.Visible = True
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
        End If
        If ParentPaymentForm IsNot Nothing Then
            ParentPaymentForm.Show()
        End If

        Me.Close()
    End Sub

    Private Sub PaymentQR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim confirmResult = MessageBox.Show("Are you sure you want to complete the payment?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim db As New BL_farizDataContext()

        Try
            Dim matchingPayments = From o In db.Orders
                                   Join p In db.Payments On o.OrderID Equals p.OrderID
                                   Where o.TableNo = SelectedTableNo AndAlso p.PaymentStatus = "Pending"
                                   Select p

            If matchingPayments.Any() Then
                For Each pay In matchingPayments
                    pay.PaymentMethod = "QR"
                    pay.PaymentStatus = "Success"
                    pay.DateTime = DateTime.Now
                Next

                db.SubmitChanges()
                MessageBox.Show("Payment Success.", "Payment Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim tableRecord = db.TableNos.FirstOrDefault(Function(t) t.Name = SelectedTableNo)

                If tableRecord IsNot Nothing Then
                    tableRecord.Color = Color.LightGreen.ToArgb()
                    db.SubmitChanges()
                End If

                For Each ctrl As Control In FrmTable.pnlTables.Controls
                    If TypeOf ctrl Is Button AndAlso ctrl.Text = SelectedTableNo Then
                        ctrl.BackColor = Color.LightGreen
                        Exit For
                    End If
                Next
                Me.Tag = "Paid" ' Set Tag to indicate success
                Me.Close()
            Else
                MessageBox.Show("No matching payment found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error while updating payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class