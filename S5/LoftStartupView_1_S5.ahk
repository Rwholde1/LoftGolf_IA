#Requires AutoHotkey v2.0
#SingleInstance
#Warn

; Include utility functions
#Include C:\LOFT\AutoHotkey\UtilityFunctions.ahk

; Main process
BlockInputState(true)

ActivateOrRun("ahk_exe VIEW.exe", "C:\LOFT\Uneekor\Launcher\UneekorLauncher.exe /run VIEW")
WinWaitActive("ahk_exe VIEW.exe", , 30)
Sleep 25000  ; Sleep for 25 seconds

Loop, 2  ; Sign into VIEW
{
    if WinExist("ahk_exe VIEW.exe") {
        WinActivate "ahk_exe VIEW.exe"
        ClickIfCorrectColor(455, 340, 0x4d4d4d)            ; Click the top recent user
        Sleep 200
        ClickIfCorrectColor(1375, 1025, 0xFF344D)          ; Click the start button
    }
    Sleep 500  ; Sleep for 1/2 second before checking again
}

Sleep 6000  ; Sleep for 6 seconds

Loop, 2  ; Click ADD
{
    if WinExist("ahk_exe VIEW.exe") {
        WinActivate "ahk_exe VIEW.exe"
        ClickIfCorrectColor(1360, 910, COLOR)  ; Click ADD button
    }
    Sleep 500  ; Sleep for 1/2 second before checking again
}

Sleep 1000  ; Sleep for 1 second

Loop, 2  ; Click Club
{
    if WinExist("ahk_exe VIEW.exe") {
        WinActivate "ahk_exe VIEW.exe"
        ClickIfCorrectColor(317, 380, COLOR)  ; Click Club button
    }
    Sleep 500  ; Sleep for 1/2 second before checking again
}

Sleep 500  ; Sleep for 1/2 second

Loop, 2  ; Click Photo
{
    if WinExist("ahk_exe VIEW.exe") {
        WinActivate "ahk_exe VIEW.exe"
        ClickIfCorrectColor(1770, 445, COLOR)  ; Click Photo button
    }
    Sleep 500  ; Sleep for 1/2 second before checking again
}

BlockInputState(false)

Run '"C:\Program Files\AutoHotkey\v2\AutoHotkey64" "C:\LOFT\LoftUI\LG_Start_GUI.ahk"'

ExitApp