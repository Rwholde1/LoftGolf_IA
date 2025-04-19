#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.

; Include utility functions file
#Include C:\LOFT\AutoHotkey\UtilityFunctions.ahk

ExitView()
ProcessClose("subview.exe")
ProcessClose("view.exe")
ProcessClose("UneekorLauncher.exe")
ProcessClose("AutoHotkey64_UIA.exe")
ProcessClose("AutoHotkey64.exe")
ProcessClose("AutoHotkey32.exe")

ExitApp