<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainX
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.timm = New System.Windows.Forms.Timer(Me.components)
		Me.Label1 = New System.Windows.Forms.Label()
		Me.LbAppTotal = New System.Windows.Forms.Label()
		Me.LbTotalLocked = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.LbLastLocked = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.LbTotalUnlocked = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.LbManualAuto = New System.Windows.Forms.Label()
		Me.notIcon = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.SuspendLayout()
		'
		'timm
		'
		Me.timm.Interval = 500
		'
		'Label1
		'
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Location = New System.Drawing.Point(20, 1)
		Me.Label1.Margin = New System.Windows.Forms.Padding(0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(81, 15)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "App Runtime"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'LbAppTotal
		'
		Me.LbAppTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LbAppTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbAppTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbAppTotal.ForeColor = System.Drawing.Color.Blue
		Me.LbAppTotal.Location = New System.Drawing.Point(100, 1)
		Me.LbAppTotal.Margin = New System.Windows.Forms.Padding(0)
		Me.LbAppTotal.Name = "LbAppTotal"
		Me.LbAppTotal.Size = New System.Drawing.Size(108, 15)
		Me.LbAppTotal.TabIndex = 1
		Me.LbAppTotal.Text = "00d 00h 00m 00s"
		Me.LbAppTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LbTotalLocked
		'
		Me.LbTotalLocked.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LbTotalLocked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbTotalLocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbTotalLocked.ForeColor = System.Drawing.Color.Crimson
		Me.LbTotalLocked.Location = New System.Drawing.Point(100, 43)
		Me.LbTotalLocked.Margin = New System.Windows.Forms.Padding(0)
		Me.LbTotalLocked.Name = "LbTotalLocked"
		Me.LbTotalLocked.Size = New System.Drawing.Size(108, 15)
		Me.LbTotalLocked.TabIndex = 3
		Me.LbTotalLocked.Text = "00d 00h 00m 00s"
		Me.LbTotalLocked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label4
		'
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label4.Location = New System.Drawing.Point(1, 43)
		Me.Label4.Margin = New System.Windows.Forms.Padding(0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(100, 15)
		Me.Label4.TabIndex = 2
		Me.Label4.Text = "Total Locked"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'LbLastLocked
		'
		Me.LbLastLocked.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LbLastLocked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbLastLocked.Cursor = System.Windows.Forms.Cursors.Hand
		Me.LbLastLocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbLastLocked.ForeColor = System.Drawing.Color.Red
		Me.LbLastLocked.Location = New System.Drawing.Point(100, 29)
		Me.LbLastLocked.Margin = New System.Windows.Forms.Padding(0)
		Me.LbLastLocked.Name = "LbLastLocked"
		Me.LbLastLocked.Size = New System.Drawing.Size(108, 15)
		Me.LbLastLocked.TabIndex = 5
		Me.LbLastLocked.Text = "00d 00h 00m 00s"
		Me.LbLastLocked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label6
		'
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label6.Location = New System.Drawing.Point(1, 29)
		Me.Label6.Margin = New System.Windows.Forms.Padding(0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(100, 15)
		Me.Label6.TabIndex = 4
		Me.Label6.Text = "Last Locked"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'LbTotalUnlocked
		'
		Me.LbTotalUnlocked.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LbTotalUnlocked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbTotalUnlocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbTotalUnlocked.ForeColor = System.Drawing.Color.Green
		Me.LbTotalUnlocked.Location = New System.Drawing.Point(100, 15)
		Me.LbTotalUnlocked.Margin = New System.Windows.Forms.Padding(0)
		Me.LbTotalUnlocked.Name = "LbTotalUnlocked"
		Me.LbTotalUnlocked.Size = New System.Drawing.Size(108, 15)
		Me.LbTotalUnlocked.TabIndex = 7
		Me.LbTotalUnlocked.Text = "00d 00h 00m 00s"
		Me.LbTotalUnlocked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label3.Location = New System.Drawing.Point(1, 15)
		Me.Label3.Margin = New System.Windows.Forms.Padding(0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(100, 15)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Unlocked"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'LbManualAuto
		'
		Me.LbManualAuto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbManualAuto.Cursor = System.Windows.Forms.Cursors.Hand
		Me.LbManualAuto.Enabled = False
		Me.LbManualAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbManualAuto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbManualAuto.ForeColor = System.Drawing.Color.Red
		Me.LbManualAuto.Location = New System.Drawing.Point(1, 1)
		Me.LbManualAuto.Margin = New System.Windows.Forms.Padding(0)
		Me.LbManualAuto.Name = "LbManualAuto"
		Me.LbManualAuto.Size = New System.Drawing.Size(20, 15)
		Me.LbManualAuto.TabIndex = 8
		Me.LbManualAuto.Text = "M"
		Me.LbManualAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'notIcon
		'
		Me.notIcon.Text = "Timeee show/hide"
		Me.notIcon.Visible = True
		'
		'MainX
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(209, 59)
		Me.Controls.Add(Me.LbManualAuto)
		Me.Controls.Add(Me.LbTotalUnlocked)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.LbLastLocked)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.LbTotalLocked)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.LbAppTotal)
		Me.Controls.Add(Me.Label1)
		Me.DoubleBuffered = True
		Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
		Me.ForeColor = System.Drawing.Color.Black
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(225, 98)
		Me.Name = "MainX"
		Me.Padding = New System.Windows.Forms.Padding(1)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "MainX"
		Me.TopMost = True
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents timm As System.Windows.Forms.Timer
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents LbAppTotal As System.Windows.Forms.Label
	Friend WithEvents LbTotalLocked As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents LbLastLocked As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents LbTotalUnlocked As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents LbManualAuto As System.Windows.Forms.Label
	Friend WithEvents notIcon As System.Windows.Forms.NotifyIcon
End Class
