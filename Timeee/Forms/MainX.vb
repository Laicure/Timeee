Public Class MainX
	Dim Locked As Boolean = False

	Dim StartTime As DateTime = Now

	Dim TimeLocked As DateTime = Now
	Dim TotalLastLocked As TimeSpan = Nothing
	Dim LastLockedz As New HashSet(Of String)

	Dim TotalUnlocked As TimeSpan = Nothing

	Dim notif As Boolean = False

	Dim urlxx As String = "C:\Users\" & Environment.UserName & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\Timeee.url"

	Private Sub MainX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		StartTime = Now
		TimeLocked = Now
		Me.Text = "Timeee v" & My.Application.Info.Version.ToString

		'start at bottom-right
		Me.Top = My.Computer.Screen.WorkingArea.Height - Me.Height
		Me.Left = My.Computer.Screen.WorkingArea.Width - Me.Width

		'Handler for PC Locking
		AddHandler Microsoft.Win32.SystemEvents.SessionSwitch, AddressOf CheckLock

		timm.Enabled = True

		'update auto-start url
		If My.Computer.FileSystem.FileExists(urlxx) Then
			My.Computer.FileSystem.WriteAllText(urlxx, "[InternetShortcut]" & vbCrLf & "URL=file:///" & Replace(System.Reflection.Assembly.GetExecutingAssembly().Location, "\", "/"), False)
			LbManualAuto.Text = "A"
			LbManualAuto.ForeColor = Color.Green
		End If
		LbManualAuto.Enabled = True

		notIcon.Icon = My.Resources.timer
		Me.Icon = My.Resources.timer
	End Sub

	Private Sub MainX_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		'If MessageBox.Show("Are you sure to close Timeee?", "Confirm Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
		'	e.Cancel = True
		'	Exit Sub
		'End If

		Me.Hide()
	End Sub

	Private Sub CheckLock(ByVal sender As Object, ByVal e As Microsoft.Win32.SessionSwitchEventArgs)
		If e.Reason = Microsoft.Win32.SessionSwitchReason.SessionLock Then
			Locked = True
			TimeLocked = Now
			If LastLockeds.Visible Then LastLockeds.Close()
		Else
			Locked = False
			Dim timLocked As TimeSpan = DateTime.Now.Subtract(TimeLocked)
			TotalLastLocked = TotalLastLocked.Add(timLocked)
			LbLastLocked.Text = timLocked.Days.ToString("d2") & "d " & timLocked.Hours.ToString("d2") & "h " & timLocked.Minutes.ToString("d2") & "m " & timLocked.Seconds.ToString("d2") & "s"
			LastLockedz.Add("[" & DateTime.Now.ToString("hh:mm:ss tt", Globalization.CultureInfo.InvariantCulture) & "]" & vbCrLf & LbLastLocked.Text)
			LbTotalLocked.Text = TotalLastLocked.Days.ToString("d2") & "d " & TotalLastLocked.Hours.ToString("d2") & "h " & TotalLastLocked.Minutes.ToString("d2") & "m " & TotalLastLocked.Seconds.ToString("d2") & "s"

			If notif Then notIcon.ShowBalloonTip(7777, "Away", LbLastLocked.Text, ToolTipIcon.Info)
		End If
	End Sub

	Private Sub timm_Tick(sender As Object, e As EventArgs) Handles timm.Tick
		Dim AppTotal As TimeSpan = DateTime.Now.Subtract(StartTime)
		LbAppTotal.Text = AppTotal.Days.ToString("d2") & "d " & AppTotal.Hours.ToString("d2") & "h " & AppTotal.Minutes.ToString("d2") & "m " & AppTotal.Seconds.ToString("d2") & "s"

		If Not Locked Then
			TotalUnlocked = AppTotal.Subtract(TotalLastLocked)
			LbTotalUnlocked.Text = TotalUnlocked.Days.ToString("d2") & "d " & TotalUnlocked.Hours.ToString("d2") & "h " & TotalUnlocked.Minutes.ToString("d2") & "m " & TotalUnlocked.Seconds.ToString("d2") & "s"
		End If
	End Sub

	Private Sub LbManualAuto_Click(sender As Object, e As EventArgs) Handles LbManualAuto.Click
		If LbManualAuto.Text = "M" Then
			If MessageBox.Show("Are you sure to set the app to auto-start with your PC?", "Auto?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
				LbManualAuto.Text = "A"
				LbManualAuto.ForeColor = Color.Green

				'update auto-start url
				If Not My.Computer.FileSystem.FileExists(urlxx) Then
					My.Computer.FileSystem.WriteAllText(urlxx, "[InternetShortcut]" & vbCrLf & "URL=file:///" & Replace(System.Reflection.Assembly.GetExecutingAssembly().Location, "\", "/"), False)
				End If
			End If
		Else
			LbManualAuto.Text = "M"
			LbManualAuto.ForeColor = Color.Red
			If My.Computer.FileSystem.FileExists(urlxx) Then
				My.Computer.FileSystem.DeleteFile(urlxx, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
			End If
		End If
	End Sub

	Private Sub notIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles notIcon.MouseDoubleClick
		If Me.Visible Then
			Me.Hide()
		Else
			Me.Show()
			Me.Activate()
		End If
	End Sub

	Private Sub lbHistory_Click(sender As Object, e As EventArgs) Handles lbHistory.Click
		If LastLockedz.Count = 0 Then Exit Sub
		If Not LastLockeds.Visible Then LastLockeds.Show(Me)
		LastLockeds.txLastLockLogz.Text = String.Join(vbCrLf & vbCrLf, LastLockedz)
		LastLockeds.Activate()
	End Sub

	Private Sub lbNotify_Click(sender As Object, e As EventArgs) Handles lbNotify.Click
		If lbNotify.Text = "S" Then
			lbNotify.Text = "N"
			lbNotify.ForeColor = Color.Green
			notif = True
		Else
			lbNotify.Text = "S"
			lbNotify.ForeColor = Color.Red
			notif = False
		End If
	End Sub
End Class