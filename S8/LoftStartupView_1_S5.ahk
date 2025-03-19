#Requires AutoHotkey v2.0
#SingleInstance
#Warn

; Include utility functions
#Include C:\LOFT\AutoHotkey\UtilityFunctions.ahk

; Main process
;BlockInput true


;============================================================================================
; STUFF TO CHANGE IF BUTTONS MOVE AROUND
; Default screen resolution is 1440 x 900
; If screen resolution is dif, change the values below
ScreenResX := 1440
ScreenResY := 900
xScaler := CalcResScaleX(ScreenResX)
yScaler := CalcResScaleY(ScreenResY)

RecentUserColor := 0x4D4D4D
RecentUserX := Round(224 * xScaler)
RecentUserY := Round(305 * yScaler)

StartColor := 0x414144
StartX := Round(981 * xScaler)
StartY := Round(857 * yScaler)

AddColor := 0xB52133
AddX := 980
AddY := 768

ClubColor := 0xA0A0A0
ClubX := 265
ClubY := 300

PhotoColor := 0xF4F4F4
PhotoX := 1307
PhotoY := 371

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
ClickFast(AddX, AddY, AddColor)
ClickFast(ClubX, ClubY, ClubColor)
ClickFast(PhotoX, PhotoY, PhotoColor)


BlockInput false

; Run '"C:\Program Files\AutoHotkey\v2\AutoHotkey64" "C:\LOFT\LoftUI\LG_Start_GUI.ahk"'

ExitApp