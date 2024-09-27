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
   Sleep 9000
}

;Check if GSPro is running and if not open the program
If WinExist("ahk_exe gspro.exe")
      WinActivate "ahk_exe gspro.exe"
else
{
   BlockInput true
   Run "C:\LOFT\GSProV1\GSPLauncher.exe"
   WinWaitActive "ahk_exe gspro.exe"
   SetControlDelay 0
   ;ControlSetChecked(0, "Button1", "ahk_exe gspro.exe")
   SetControlDelay 1
   ControlChooseString("1680 x 1050", "ComboBox1", "ahk_exe gspro.exe")
   SetControlDelay 1
   ControlChooseString("Very High", "ComboBox2","ahk_exe gspro.exe")
   SetControlDelay 1
   ControlChooseString("Display 1 (Left)", "ComboBox3", "ahk_exe gspro.exe")
   SetControlDelay 1
   ControlClick "Play!", "ahk_exe gspro.exe"
      Sleep 8000

      DllCall("SetCursorPos", "int", 2120, "int", 320)  ;Move to and Click top recent user (screen)
      Click
      DllCall("SetCursorPos", "int", 3050, "int", 1000)  ;Move to and Click start on View user (screen)
      Click
      ;MouseMove 2250, 1000  ;Move to and Click start on View user (window)
      ;Click
   Sleep 4000
   BlockInput false
   }

{
   BlockInput true
   WinActivate "ahk_exe VIEW.exe"
   Sleep 2000
   DllCall("SetCursorPos", "int", 3040, "int", 891)  ;Move to and Click ADD (screen)
   Click
   Sleep 4000
   DllCall("SetCursorPos", "int", 2000, "int", 334)  ;Move to and Click Club (screen)
   Click
   Sleep 2000
   DllCall("SetCursorPos", "int", 3442, "int", 420)  ;Move to and Click Photo (screen)
   Click
   BlockInput false
}

   if WinWaitActive("ahk_exe GSPconnect.exe",,2)
      WinMinimize
   else
      WinActivate "ahk_exe gspro.exe"
      MsgBox "
      (
      Be sure to log in and create a new session in
      Uneekor VIEW if it does not log in automatically.

      DO NOT CLOSE: the "Uneekor Connect" window
         - or GSPro will not work.
      )", "LOFT Golf Studios - REMINDERS", "iconi T120"


ExitApp

