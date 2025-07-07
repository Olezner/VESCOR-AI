Imports System.Drawing
Imports System.Windows.Forms

Public Class CustomButton
    Inherits Button

    ' Property for Border Radius
    Private _borderRadius As Integer = 10
    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(value As Integer)
            _borderRadius = value
            Me.Invalidate() ' Redraw the button when the property changes
        End Set
    End Property

    ' Override the OnPaint method to draw rounded corners
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Create a graphics object
        Dim g As Graphics = e.Graphics
        Dim buttonRectangle As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

        ' Set background color to green
        Using brush As New SolidBrush(Color.Green)
            g.FillRoundedRectangle(brush, buttonRectangle, _borderRadius)
        End Using

        ' Draw the text on top of the button
        Using textBrush As New SolidBrush(Me.ForeColor)
            g.DrawString(Me.Text, Me.Font, textBrush, New PointF((Me.Width - g.MeasureString(Me.Text, Me.Font).Width) / 2, (Me.Height - g.MeasureString(Me.Text, Me.Font).Height) / 2))
        End Using
    End Sub
End Class
