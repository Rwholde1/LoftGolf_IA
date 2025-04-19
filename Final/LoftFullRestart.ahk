#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.

RunWait '"C:\Program Files\AutoHotkey\v2\AutoHotkey64_UIA.exe" "C:\LOFT\AutoHotkey\LoftClose_Silent_DelSessions.ahk"'

Sleep 1500
{
	Run '"C:\Program Files\AutoHotkey\v2\AutoHotkey64_UIA.exe" "C:\LOFT\AutoHotkey\LoftStartupView_1_S5.ahk"'
	Sleep 1500
}

ExitApp