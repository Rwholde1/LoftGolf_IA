#Requires AutoHotkey v2.0
#SingleInstance
#Warn
^Esc::ExitApp

; Include utility functions file
#Include C:\LOFT\AutoHotkey\UtilityFunctions.ahk

;============================================================================================
; Default screen resolution is 1920 x 1080
; Constants for View UI pixel positions and colors (change/add/remove accordingly...)
RecentUserBtn :=    {x: 267,    y: 353,     color: 0x4D4D4D}
StartBtn :=         {x: 1500,   y: 1000,    color: 0xFFDA00}
AddSessionBtn :=    {x: 900,    y: 850,     color: 0xFFDA00}
ClubBtn :=          {x: 325,    y: 356,     color: 0x81818C}
PhotoBtn :=         {x: 1743,   y: 456,     color: 0x1E1E23}

;============================================================================================
; Actual process of opening Uneekor View, signing in, and getting settings ready

DetectandCloseUneekorView()
ActivateOrRun("ahk_exe VIEW.exe", "C:\LOFT\Uneekor\Launcher\UneekorLauncher.exe /run VIEW")
WaitAndActivateWindow("ahk_exe VIEW.exe", 30)

while (!WinExist("ahk_exe VIEW.exe"))
{
    WinActivate "ahk_exe VIEW.exe"
}

ClickFast(RecentUserBtn.x, RecentUserBtn.y, RecentUserBtn.color)
ClickFast(StartBtn.x, StartBtn.y, StartBtn.color)
DeleteSessions(1)
ClickFast(AddSessionBtn.x, AddSessionBtn.y, AddSessionBtn.color)
ClickFast(ClubBtn.x, ClubBtn.y, ClubBtn.color)
ClickFast(PhotoBtn.x, PhotoBtn.y, PhotoBtn.color)

; BlockInput false

; Run '"C:\Program Files\AutoHotkey\v2\AutoHotkey64" "C:\LOFT\LoftUI\LG_Start_GUI.ahk"'

ExitApp
