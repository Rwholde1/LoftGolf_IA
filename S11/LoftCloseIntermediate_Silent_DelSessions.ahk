#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.
#Include C:\LOFT\AutoHotkey\UtilityFunctions.ahk

CoordMode ("Mouse", "Window")
; BlockInput true
If WinExist("ahk_exe GSPro.exe")
{
    WinClose "ahk_exe GSPro.exe"
}
If WinExist("ahk_class WindowsForms10.Window.8.app.0.13965fa_r7_ad1")
{
    WinClose "ahk_class WindowsForms10.Window.8.app.0.13965fa_r7_ad1"
}
If WinExist("ahk_exe VIEW.exe")
{
    WinActivate "ahk_exe VIEW.exe"
    DeleteSessions(0)
    Sleep 5000
    Run '"C:\Program Files\AutoHotkey\v2\AutoHotkey64.exe" "C:\LOFT\LoftUI\LG_Start_GUI.ahk"'
    BlockInput false
}
ExitApp
