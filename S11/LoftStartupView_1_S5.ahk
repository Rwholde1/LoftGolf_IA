#Requires AutoHotkey v2.0
#SingleInstance
#Warn

; Include utility functions
#Include C:\LOFT\AutoHotkey\UtilityFunctions.ahk

; Main process
;SendInput "^!z"
; BlockInput true

;============================================================================================
; STUFF TO CHANGE IF BUTTONS MOVE AROUND
; Default screen resolution is 1920 x 1080
; If Uneekor View monitor resolution is different, you need to find the appropriate coords manually

RecentUserColor := 0x262627
RecentUserX := 583
RecentUserY := 387

StartColor := 0x414144
StartX := 1219
StartY := 1028

AddColor := 0xB52133
AddX := 1265
AddY := 909

ClubColor := 0xA0A0A0
ClubX := 316
ClubY := 358

PhotoColor := 0xFFFFFF
PhotoX := 1761
PhotoY := 444

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
DeleteSessions()
ClickFast(AddX, AddY, AddColor)
ClickFast(ClubX, ClubY, ClubColor)
ClickFast(PhotoX, PhotoY, PhotoColor)

BlockInput false

; SendInput "^!z"

; Run '"C:\Program Files\AutoHotkey\v2\AutoHotkey64" "C:\LOFT\LoftUI\LG_Start_GUI.ahk"'

ExitApp