Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class CirclePictureBox
    Inherits PictureBox
    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        Dim grapth As GraphicsPath = New GraphicsPath()
        grapth.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New Region(grapth)
        MyBase.OnPaint(pe)
    End Sub
End Class