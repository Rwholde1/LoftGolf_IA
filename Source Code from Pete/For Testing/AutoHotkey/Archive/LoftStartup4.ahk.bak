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
   Run "C:\LOFT\GSProV1\GSPLauncher.exe"
   WinWaitActive "ahk_exe gspro.exe"
   ControlSetChecked(0, "Button1", "ahk_exe gspro.exe")
   ControlChooseString("1280 x 800", "ComboBox1", "ahk_exe gspro.exe")
   ControlChooseString("Very High", "ComboBox2","ahk_exe gspro.exe")
   ControlChooseString("Display 1 (Left)", "ComboBox3", "ahk_exe gspro.exe")
   ;SetControlDelay -1
   ControlClick "Play!", "ahk_exe gspro.exe"
      Sleep 8000
      ;DllCall("SetThreadDpiAwarenessContext", "ptr", -3, "ptr")
      MouseMove 2200, 420  ;Move to and Click top recent user (screen)
      Click
      ;MouseMove 900, 657  ;Move to and Click top recent user (window)
      ;Click
      MouseMove 4000, 1800  ;Move to and Click start on View user (screen)
      Click
      ;MouseMove 2733, 2052  ;Move to and Click start on View user (window)
      ;Click
   Sleep 4000
   }

{
   DllCall("SetThreadDpiAwarenessContext", "ptr", -3, "ptr")
   WinActivate "ahk_exe VIEW.exe"
   Sleep 2000
   MouseMove 4000, 1550  ;Move to and Click ADD (screen)
   Click
   ;MouseMove 2718, 1831  ;Move to and Click ADD (window)
   ;Click
   Sleep 2000
   MouseMove 1900, 450  ;Move to and Click Club (screen)
   Click
   ;MouseMove 642, 713  ;Move to and Click Club (window)
   ;Click
   ;MouseMove 3636, 316  ;Move to and Click Photo (screen)
   ;Click
   ;MouseMove 3537, 887  ;Move to and Click Photo (window)
   ;Click
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

