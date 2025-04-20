#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.
;For resolutions 1280x800 Monitor 3 left, 1920x1080 Monitor 1/2 Right

Wsize := SysGet(16)
Hsize := SysGet(17)
DimensionsText := Wsize " / " Hsize

CoordMode "Mouse", "Window"
SetTitleMatchMode 2

{

;Check if GSPro is running and if not open the program
If WinExist("ahk_exe gspro.exe")
      WinActivate "ahk_exe gspro.exe"
   else
     {
     Run "C:\LOFT\GSProV1\GSPLauncher.exe"
     WinWait("GSPro Configuration")
     Loop 3
        {
         if WinExist("GSPro Configuration")
            {
            WinActivate("GSPro Configuration")
            SetControlDelay 0
            ControlSetChecked(0, "Button1", "GSPro Configuration")
            SetControlDelay 0
            ControlChooseString("1280 x 800", "ComboBox1", "GSPro Configuration")
            SetControlDelay 0
            ControlChooseString("Very High", "ComboBox2","GSPro Configuration")
            SetControlDelay 0
            ControlChooseString("Display 1 (Left)", "ComboBox3", "GSPro Configuration")
            SetControlDelay 0
            ControlClick("Play!", "GSPro Configuration")
            }
            else
               break

             Sleep 500 ;Sleep for 1/2 second before checking again
         }
      }

; RunWait 'C:\LOFT\AutoHotkey\LoftLoadVideo.exe' ; Runs the video player (full path)
Sleep 41000

if WinExist("Uneekor Connect")
      WinMinimize "Uneekor Connect"

;   MsgBox "
;      (
;      DO NOT CLOSE: the "Uneekor Connect" window
;         - or GSPro will not work.
;      )", "LOFT Golf Studios - REMINDERS", "iconi T120"
   }

ExitApp

