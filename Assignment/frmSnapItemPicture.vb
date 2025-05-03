Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class frmSnapItemPicture
    Dim vcdCamera As VideoCaptureDevice
    Dim bitMap As Bitmap
    Public Delegate Sub Del(ByVal image As Image)
    Private delegateImage As Del

    Public Sub New(ByVal del As Del)
        InitializeComponent()
        Me.delegateImage = del
    End Sub

    Private Sub frmSnapItemPicture_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnStartCamera.Text = "&Start Camera"
        btnStopCamera.Text = "S&top Camera"
        btnStopCamera.Enabled = False
        picSnapItemPicture.Image = Nothing
        picPreviewItemPicture.Image = Nothing
        picSnapItemPicture.Visible = False
        picPreviewItemPicture.Visible = False
        picCameraAccess.Visible = True
        lblConfirmPicture.Visible = False
    End Sub

    Private Sub btnStartCamera_Click(sender As Object, e As EventArgs) Handles btnStartCamera.Click, StartCaptureToolStripMenuItem.Click
        picCameraAccess.Visible = False
        Dim vcdfCamera As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        'Call the dialog to choose camera to start
        If btnStartCamera.Text = "&Start Camera" Then
            If vcdfCamera.ShowDialog() = Windows.Forms.DialogResult.OK Then
                vcdCamera = vcdfCamera.VideoDevice
                AddHandler vcdCamera.NewFrame, New NewFrameEventHandler(AddressOf Capturing)
                vcdCamera.Start()
            End If
            picSnapItemPicture.Visible = True
            btnStartCamera.Text = "&Snap Picture"
            btnStopCamera.Enabled = True
        ElseIf btnStartCamera.Text = "&Snap Picture" Then
            picPreviewItemPicture.Image = picSnapItemPicture.Image
            'Close the camera and show preview
            vcdCamera.Stop()
            picSnapItemPicture.Image = Nothing
            picSnapItemPicture.Visible = False
            picPreviewItemPicture.Visible = True
            'Change button to Yes or No
            btnStartCamera.Text = "&Yes"
            btnStopCamera.Text = "&No"
            lblConfirmPicture.Visible = True
        ElseIf btnStartCamera.Text = "&Yes" Then
            delegateImage(picPreviewItemPicture.Image)
            Me.Close()
        End If
    End Sub

    Private Sub btnStopCamera_Click(sender As Object, e As EventArgs) Handles btnStopCamera.Click, StopCaptureToolStripMenuItem.Click
        If btnStopCamera.Text = "S&top Camera" Then
            'Stop the camera
            vcdCamera.Stop()
            'Clear the picture box
            picSnapItemPicture.Image = Nothing
            picPreviewItemPicture.Image = Nothing
            picSnapItemPicture.Visible = True
            picPreviewItemPicture.Visible = False
            picCameraAccess.Visible = True

            'Reset the button
            btnStopCamera.Enabled = False
            btnStartCamera.Text = "&Start Camera"

        ElseIf btnStopCamera.Text = "&No" Then
            'Clear the picture box
            btnStartCamera.Text = "&Start Camera"
            btnStopCamera.Text = "S&top Camera"
            btnStopCamera.Enabled = False
            picSnapItemPicture.Image = Nothing
            picPreviewItemPicture.Image = Nothing
            picSnapItemPicture.Visible = True
            picPreviewItemPicture.Visible = False
            picCameraAccess.Visible = True
            lblConfirmPicture.Visible = False
        End If
    End Sub

    Private Sub Capturing(sender As Object, eventArgs As NewFrameEventArgs)
        bitMap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        picSnapItemPicture.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class