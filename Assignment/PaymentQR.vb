Imports AForge.Video
Imports AForge.Video.DirectShow
Public Class PaymentQR
    Private videoDevices As FilterInfoCollection
    Private videoSource As VideoCaptureDevice

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
        Me.Close()
    End Sub

    Private Sub PaymentQR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
        End If
    End Sub
End Class