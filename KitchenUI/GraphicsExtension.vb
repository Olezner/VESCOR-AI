Imports System.Drawing

Public Module GraphicsExtension
    <System.Runtime.CompilerServices.Extension()>
    Public Sub FillRoundedRectangle(g As Graphics, brush As Brush, rect As Rectangle, radius As Integer)
        Using path As New Drawing2D.GraphicsPath()
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
            path.CloseFigure()
            g.FillPath(brush, path)
        End Using
    End Sub
End Module
