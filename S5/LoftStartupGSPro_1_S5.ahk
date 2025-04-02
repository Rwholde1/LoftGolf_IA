#Requires AutoHotkey v2.0
#SingleInstance
#Warn

; Include utility functions
#Include C:\LOFT\AutoHotkey\UtilityFunctions.ahk

; Main process
BlockInputState(true)

ActivateOrRun("ahk_exe gspro.exe", "C:\LOFT\GSProV1\GSPLauncher.exe")
WinWait("ahk_Class #32770")
ControlSetup("ahk_Class #32770", {MaxSteps: 3, Resolution: "1280 x 800", Quality: "Very High", Display: "Display 1 (Left)"})
Sleep 20000  ; Sleep for 20 seconds

if WinExist("ahk_class WindowsForms10.Window.8.app.0.13965fa_r7_ad1")
    WinMinimize "ahk_class WindowsForms10.Window.8.app.0.13965fa_r7_ad1"

BlockInputState(false)
ExitApp