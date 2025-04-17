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

RecentUserColor := 0x4D4D4D
RecentUserX := 267
RecentUserY := 353

StartColor := 0xFFDA00
StartX := 1500
StartY := 1000

AddColor := 0xFFDA00
AddX := 900
AddY := 850

ClubColor := 0x81818C
ClubX := 325
ClubY := 356

PhotoColor := 0x1E1E23
PhotoX := 1743
PhotoY := 456

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
DeleteSessions(1)
ClickFast(AddX, AddY, AddColor)
ClickFast(ClubX, ClubY, ClubColor)
ClickFast(PhotoX, PhotoY, PhotoColor)

BlockInput false

; SendInput "^!z"

; Run '"C:\Program Files\AutoHotkey\v2\AutoHotkey64" "C:\LOFT\LoftUI\LG_Start_GUI.ahk"'

ExitApp
