#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.

;Check if View is running and if not open the program
If WinExist("ahk_exe VIEW.exe")
     WinActivate "ahk_exe VIEW.exe"
else
{
   Run "C:\LOFT\Uneekor\Launcher\UneekorLauncher.exe /run VIEW"
   WinWaitActive("ahk_exe VIEW.exe", , 30)
   ;WinMaximize "ahk_exe VIEW.exe"
   ;WinMove -11, -11, 3862, 2110, "ahk_exe VIEW.exe"
   Sleep 8000
}

            ;Check if GSPro is running and if not open the program
If WinExist("ahk_exe gspro.exe")
      WinActivate "ahk_exe gspro.exe"
else
{
   Run "C:\LOFT\GSProV1\GSPLauncher.exe"
   WinWaitActive "ahk_exe gspro.exe"
   ControlSetChecked(0, "Button1", "ahk_exe gspro.exe")
   ControlChooseString("1280 x 800", "ComboBox1", "ahk_exe gspro.exe")
   ControlChooseString("Very High", "ComboBox2","ahk_exe gspro.exe")
   ControlChooseString("Display 2 (Left)", "ComboBox3", "ahk_exe gspro.exe")
   SetControlDelay -1
   ControlClick "Play!", "ahk_exe gspro.exe"
   ;Sleep 10000
   WinWaitActive "ahk_exe GSPconnect.exe"
   WinMinimize "ahk_exe GSPconnect.exe"
   WinActivate "ahk_exe VIEW.exe"
}

;Sleep 2000
   WinActivate "ahk_exe VIEW.exe"

      MsgBox "
      (
      MAXIMIZE: VIEW window (so START button is visible)

      SELECT: Loft Golf Studios or your MyUneekor profile

      CLICK: START to continue

      ADD: a new session in VIEW

      SELECT: CLUB for club data in VIEW

      DO NOT CLOSE: the "Uneekor Connect" window
         - or GSPro will not work.
      )", "LOFT Golf Studios - REMINDERS", "iconi T120"



ExitApp

