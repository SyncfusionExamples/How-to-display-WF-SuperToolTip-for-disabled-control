Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Public Class Form1
    Inherits MetroForm


    Private superToolTip1 As SuperToolTip
    Public Sub New()
        InitializeComponent()
        superToolTip1 = New SuperToolTip()

    End Sub
    Private IsShown As Boolean = False
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        Dim ctrl As Control = Me.GetChildAtPoint(e.Location)
        If ctrl IsNot Nothing Then
            If ctrl Is Me.buttonAdv1 AndAlso (Not IsShown) Then
                'Initializes the ToolTipInfo
                Dim tooltip As New ToolTipInfo()
                tooltip.Body.Text = "SuperToolTip"
                'Sets the SuperToolTip
                Me.superToolTip1.SetToolTip(Me.buttonAdv1, tooltip)
                Dim pt1 As New System.Drawing.Point(ctrl.Location.X + 20, ctrl.Location.Y + 30)
                'Shows the SuperToolTip in the specified location
                Me.superToolTip1.Show(tooltip, Me.PointToScreen(pt1), 1000)
                IsShown = True
            End If
        Else
            Me.superToolTip1.Hide()
            IsShown = False
        End If
    End Sub
End Class
