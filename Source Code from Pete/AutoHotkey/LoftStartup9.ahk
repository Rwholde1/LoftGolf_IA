#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.
{
	BlockInput true
	Run '"C:\Program Files\AutoHotkey\v2\AutoHotkey64_UIA.exe" "C:\LOFT\AutoHotkey\LoftStartupView_1.ahk"'
	Sleep 60000
	BlockInput false
}
ExitApp