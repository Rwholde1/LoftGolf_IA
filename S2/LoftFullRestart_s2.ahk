#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.

CoordMode "Mouse", "Window" ;May not need hard coded coordinates for all of the if clicks, could look into this but not a priority right now (functions well)

{
    If WinExist("ahk_exe GSPro.exe")
        WinClose "ahk_exe GSPro.exe"
    If WinExist("ahk_class WindowsForms10.Window.8.app.0.13965fa_r7_ad1")
        WinClose "ahk_class WindowsForms10.Window.8.app.0.13965fa_r7_ad1"
    {
        If WinExist("ahk_exe VIEW.exe")
            WinActivate "ahk_exe VIEW.exe"
            Click 23, 207  ;Move to and Click Session 1 (window) 
            Sleep 50
            Click 23, 262  ;Move to and Click Session 2 (window)
            Sleep 50
            Click 23, 318  ;Move to and Click Session 3 (window)
            Sleep 50
            Click 23, 370  ;Move to and Click Session 4 (window)
            Sleep 50
            Click 23, 426  ;Move to and Click Session 5 (window)
            Sleep 50
            Click 23, 481  ;Move to and Click Session 6 (window)
            Sleep 50
            Click 23, 541  ;Move to and Click Session 7 (window)
            Sleep 50
            Click 23, 595  ;Move to and Click Session 8 (window)
            Sleep 50
            Click 23, 650  ;Move to and Click Session 9 (window)
            Sleep 50
            Click 23, 705  ;Move to and Click Session 10 (window)
            Sleep 50
            Click 23, 763  ;Move to and Click Session 11 (window)
            Sleep 50
            Click 23, 815  ;Move to and Click Session 12 (window)
            Sleep 50
            Click 23, 875  ;Move to and Click Session 13 (window)
            Sleep 50
            Click 23, 930  ;Move to and Click Session 14 (window)
            Sleep 500
            Click 205, 1050  ;Move to and Click Session Delete (window)
            Sleep 1000       
    }
	ProcessClose("subview.exe")
    ProcessClose("view.exe")
    ProcessClose("UneekorLauncher.exe")
    ProcessClose("AutoHotkey64_UIA.exe")
    ProcessClose("AutoHotkey64.exe")
    ProcessClose("AutoHotkey32.exe")
}
Sleep 2000
{
	BlockInput true
	Run '"C:\Program Files\AutoHotkey\v2\AutoHotkey64_UIA.exe" "C:\LOFT\AutoHotkey\LoftStartupView_1.ahk"'
	Sleep 60000
	BlockInput false
}

ExitApp