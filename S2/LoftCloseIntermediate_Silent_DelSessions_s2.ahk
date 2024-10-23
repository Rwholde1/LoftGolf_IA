#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors. Could potentially add error hnalding, but the code works well between sessions and easy to navigate for users

CoordMode "Mouse", "Window"
{
    BlockInput true
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
       {
       Loop 1 ;Click ADD
          {
            If WinExist("ahk_exe SubVIEW.exe")
                WinClose "ahk_exe SubVIEW.exe"
            if WinExist("ahk_exe VIEW.exe")
          {
             WinActivate "ahk_exe VIEW.exe"
                Sleep 100
                Click 140, 100  ;Move to and Click ADD (window)
                Sleep 100
                Click 1360, 910  ;Move to and Click ADD (window)

          }
             else
                break

          Sleep 500   ;Sleep for 1/2 second before checking again
          }
       }
    }

    Sleep 5000
    Run '"C:\Program Files\AutoHotkey\v2\AutoHotkey64.exe" "C:\LOFT\LoftUI\LG_Start_GUI.ahk"'
    BlockInput false
}
ExitApp