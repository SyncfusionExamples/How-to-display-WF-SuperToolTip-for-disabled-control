Imports Syncfusion.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        ' 
        ' buttonAdv1
        ' 
        Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016DarkGray
        Me.buttonAdv1.BeforeTouchSize = New System.Drawing.Size(84, 23)
        Me.buttonAdv1.Enabled = False
        Me.buttonAdv1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.buttonAdv1.Location = New System.Drawing.Point(286, 96)
        Me.buttonAdv1.Name = "buttonAdv1"
        Me.buttonAdv1.Size = New System.Drawing.Size(84, 23)
        Me.buttonAdv1.TabIndex = 0
        Me.buttonAdv1.Text = "ShowToolTip"
        Me.buttonAdv1.ThemeName = "Office2016DarkGray"
        Me.buttonAdv1.UseVisualStyle = True
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(69, 96)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(135, 32)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Hover mouse on button to show SuperToolTip"
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CaptionBarColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
        Me.CaptionButtonColor = System.Drawing.Color.White
        Me.CaptionForeColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.buttonAdv1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SuperToolTip"
        AddHandler MouseMove, AddressOf Form1_MouseMove
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private buttonAdv1 As ButtonAdv
    Private label1 As System.Windows.Forms.Label
End Class
