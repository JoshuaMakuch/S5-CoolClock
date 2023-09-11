<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CoolClockForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ClockLabel = New System.Windows.Forms.Label()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Datelabel = New System.Windows.Forms.Label()
        Me.LightspeedLabel = New System.Windows.Forms.Label()
        Me.ReachedLabel = New System.Windows.Forms.Label()
        Me.ClockSpeedLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ClockLabel
        '
        Me.ClockLabel.AutoSize = True
        Me.ClockLabel.Font = New System.Drawing.Font("3ds", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ClockLabel.Location = New System.Drawing.Point(12, 9)
        Me.ClockLabel.Name = "ClockLabel"
        Me.ClockLabel.Size = New System.Drawing.Size(139, 34)
        Me.ClockLabel.TabIndex = 0
        Me.ClockLabel.Text = "00:00:00"
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(359, 178)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(124, 65)
        Me.QuitButton.TabIndex = 1
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'ClockTimer
        '
        Me.ClockTimer.Enabled = True
        Me.ClockTimer.Interval = 1
        '
        'Datelabel
        '
        Me.Datelabel.AutoSize = True
        Me.Datelabel.Font = New System.Drawing.Font("3ds", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Datelabel.Location = New System.Drawing.Point(12, 43)
        Me.Datelabel.Name = "Datelabel"
        Me.Datelabel.Size = New System.Drawing.Size(60, 27)
        Me.Datelabel.TabIndex = 2
        Me.Datelabel.Text = "Date"
        '
        'LightspeedLabel
        '
        Me.LightspeedLabel.AutoSize = True
        Me.LightspeedLabel.Location = New System.Drawing.Point(12, 70)
        Me.LightspeedLabel.Name = "LightspeedLabel"
        Me.LightspeedLabel.Size = New System.Drawing.Size(92, 20)
        Me.LightspeedLabel.TabIndex = 3
        Me.LightspeedLabel.Text = "LIGHTSPEED"
        '
        'ReachedLabel
        '
        Me.ReachedLabel.AutoSize = True
        Me.ReachedLabel.Location = New System.Drawing.Point(12, 110)
        Me.ReachedLabel.Name = "ReachedLabel"
        Me.ReachedLabel.Size = New System.Drawing.Size(174, 20)
        Me.ReachedLabel.TabIndex = 4
        Me.ReachedLabel.Text = "Where have we reached?"
        '
        'ClockSpeedLabel
        '
        Me.ClockSpeedLabel.AutoSize = True
        Me.ClockSpeedLabel.Location = New System.Drawing.Point(12, 90)
        Me.ClockSpeedLabel.Name = "ClockSpeedLabel"
        Me.ClockSpeedLabel.Size = New System.Drawing.Size(167, 20)
        Me.ClockSpeedLabel.TabIndex = 5
        Me.ClockSpeedLabel.Text = "Cycles of a 5GHz Clock: "
        '
        'CoolClockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 255)
        Me.Controls.Add(Me.ClockSpeedLabel)
        Me.Controls.Add(Me.ReachedLabel)
        Me.Controls.Add(Me.LightspeedLabel)
        Me.Controls.Add(Me.Datelabel)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.ClockLabel)
        Me.Name = "CoolClockForm"
        Me.Text = "CoolClockForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClockLabel As Label
    Friend WithEvents QuitButton As Button
    Friend WithEvents ClockTimer As Timer
    Friend WithEvents Datelabel As Label
    Friend WithEvents LightspeedLabel As Label
    Friend WithEvents ReachedLabel As Label
    Friend WithEvents ClockSpeedLabel As Label
End Class
