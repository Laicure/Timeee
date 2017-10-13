<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LastLockeds
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
		Me.txLastLockLogz = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'txLastLockLogz
		'
		Me.txLastLockLogz.Dock = System.Windows.Forms.DockStyle.Fill
		Me.txLastLockLogz.Location = New System.Drawing.Point(1, 1)
		Me.txLastLockLogz.MaxLength = 2147483647
		Me.txLastLockLogz.Multiline = True
		Me.txLastLockLogz.Name = "txLastLockLogz"
		Me.txLastLockLogz.ReadOnly = True
		Me.txLastLockLogz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txLastLockLogz.Size = New System.Drawing.Size(182, 259)
		Me.txLastLockLogz.TabIndex = 0
		Me.txLastLockLogz.WordWrap = False
		'
		'LastLockeds
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(184, 261)
		Me.Controls.Add(Me.txLastLockLogz)
		Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
		Me.ForeColor = System.Drawing.Color.Black
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "LastLockeds"
		Me.Padding = New System.Windows.Forms.Padding(1)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Last Locked Logs"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txLastLockLogz As System.Windows.Forms.TextBox
End Class
