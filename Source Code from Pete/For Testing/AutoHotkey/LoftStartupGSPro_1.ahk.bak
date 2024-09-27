#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.
;For resolutions 1280x800 Monitor 3 left, 1920x1080 Monitor 1/2 Right

CoordMode "Mouse", "Window"
SetTitleMatchMode 2
BlockInput true

{

;Check if GSPro is running and if not open the program
If WinExist("ahk_exe gspro.exe")
      WinActivate "ahk_exe gspro.exe"
   else
     {
     Run "C:\LOFT\GSProV1\GSPLauncher.exe"
     WinWait("ahk_Class #32770")
     Loop 3
        {
         if WinExist("ahk_Class #32770")
            {
            WinActivate
            SetControlDelay 0
            ControlSetChecked(0, "Button1", "ahk_Class #32770")
            SetControlDelay 0
            ControlChooseString("1280 x 800", "ComboBox1", "ahk_Class #32770")
            SetControlDelay 0
            ControlChooseString("Very High", "ComboBox2","ahk_Class #32770")
            SetControlDelay 0
            ControlChooseString("Display 1 (Left)", "ComboBox3", "ahk_Class #32770")
            SetControlDelay 0
            ControlClick("Play!", "ahk_Class #32770")
            }
            else
               break

             Sleep 500 ;Sleep for 1/2 second before checking again
         }
      }

Sleep 20000  ;Sleep for 20 seconds

if WinExist("ahk_class WindowsForms10.Window.8.app.0.13965fa_r7_ad1")
      WinMinimize "ahk_class WindowsForms10.Window.8.app.0.13965fa_r7_ad1"

;   MsgBox "
;      (
;      DO NOT CLOSE: the "Uneekor Connect" window
;         - or GSPro will not work.
;      )", "LOFT Golf Studios - REMINDERS", "iconi T120"
   }
BlockInput false

ExitApp

