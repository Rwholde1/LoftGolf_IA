#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.

WinClose "ahk_exe GSPconnect.exe"
Sleep 1000
Run "C:\LOFT\GSProV1\Core\GSPC\GSPconnect.exe"

Sleep 3000

If WinExist("ahk_exe GSPconnect.exe")
	WinActivate "ahk_exe gspro.exe"

Sleep 1000

   MsgBox "
      (
		Wait until the line turns green in the
		bottom right corner of the window and test.

		DO NOT CLOSE: the "Uneekor Connect" window
		or GSPro will not work.
      )", "GSPro Reconnect", "iconi T20"

ExitApp