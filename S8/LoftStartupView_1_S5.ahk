#Requires AutoHotkey v2.0
#SingleInstance
#Warn

; Include utility functions
#Include C:\LOFT\AutoHotkey\UtilityFunctions.ahk

; Main process
BlockInput true


;============================================================================================
; STUFF TO CHANGE IF BUTTONS MOVE AROUND
; Default screen resolution is 1440 x 900
; If screen resolution is dif, change the values below
ScreenResX := 1440
ScreenResY := 900

RecentUserColor := 0x4D4D4D
RecentUserColor2 := 0x11DFF8
RecentUserX := 224
RecentUserY := 305

StartColor := 0x414144
StartX := 981
StartY := 857

;============================================================================================
RecentUserClicked := false
StartClicked := false

;============================================================================================

ActivateOrRun("ahk_exe VIEW.exe", "C:\LOFT\Uneekor\Launcher\UneekorLauncher.exe /run VIEW")
WinWaitActive("ahk_exe VIEW.exe", , 30)

while (!WinExist("ahk_exe VIEW.exe"))                                                                            ; Signing into VIEW
{
    WinActivate "ahk_exe VIEW.exe"
}

ClickFast(RecentUserX, RecentUserY, RecentUserColor)
ClickFast(StartX, StartY, StartColor)

Loop 20  ; Click ADD
{
    if WinExist("ahk_exe VIEW.exe") {
        WinActivate "ahk_exe VIEW.exe"
        ClickIfCorrectColor(1360, 910, COLOR)  ; Click ADD button
    }
    Sleep 500  ; Sleep for 1/2 second before checking again
}

Sleep 1000  ; Sleep for 1 second

Loop 20  ; Click Club
{
    if WinExist("ahk_exe VIEW.exe") {
        WinActivate "ahk_exe VIEW.exe"
        ClickIfCorrectColor(317, 380, COLOR)  ; Click Club button
    }
    Sleep 500  ; Sleep for 1/2 second before checking again
}

Sleep 500  ; Sleep for 1/2 second

Loop 20  ; Click Photo
{
    if WinExist("ahk_exe VIEW.exe") {
        WinActivate "ahk_exe VIEW.exe"
        ClickIfCorrectColor(1770, 445, COLOR)  ; Click Photo button
    }
    Sleep 500  ; Sleep for 1/2 second before checking again
}

BlockInput false

; Run '"C:\Program Files\AutoHotkey\v2\AutoHotkey64" "C:\LOFT\LoftUI\LG_Start_GUI.ahk"'

ExitApp