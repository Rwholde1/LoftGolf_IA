#Requires AutoHotkey v2.0
#SingleInstance
#Warn

; Include utility functions
#Include C:\LOFT\AutoHotkey\UtilityFunctions.ahk

; Main process
BlockInputState(true)
RunProgram('"C:\Program Files\AutoHotkey\v2\AutoHotkey64_UIA.exe" "C:\LOFT\AutoHotkey\LoftStartupView_1.ahk"')
Sleep 60000  ; Sleep for 1 minute to ensure processes are up
BlockInputState(false)

ExitApp