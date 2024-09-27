#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.

{
	BlockInput true
	Run '"C:\Program Files\AutoHotkey\v2\AutoHotkey64_UIA.exe" "C:\LOFT\AutoHotkey\LoftCloseIntermediate_Silent_DelSessions.ahk"'
	Sleep 1000
	Run '"C:\Program Files\AutoHotkey\v2\AutoHotkey64_UIA.exe" "C:\LOFT\AutoHotkey\AHK GUI\LG_Start_GUI.ahk"'
	Sleep 5000
	BlockInput false
	ExitApp
}