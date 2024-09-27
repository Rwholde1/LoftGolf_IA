#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.

{
BlockInput true

;Check if View is running and if not open the program
If WinExist("ahk_exe VIEW.exe")
     WinActivate "ahk_exe VIEW.exe"
else
{
   Run "C:\LOFT\Uneekor\Launcher\UneekorLauncher.exe /run VIEW"
   WinWaitActive("ahk_exe VIEW.exe", , 30)
   Sleep 11000
}

;Check if GSPro is running and if not open the program
If WinExist("ahk_exe gspro.exe")
      WinActivate "ahk_exe gspro.exe"
else
     {
     Run "C:\LOFT\GSProV1\GSPLauncher.exe"
     WinWait("ahk_exe gspro.exe")
     Loop 3
          {
          if WinExist("ahk_exe gspro.exe")
               WinActivate
               SetControlDelay 0
               ControlSetChecked(0, "Button1", "ahk_exe gspro.exe")
               SetControlDelay 0
               ControlChooseString("1680 x 1050", "ComboBox1", "ahk_exe gspro.exe")
               SetControlDelay 0
               ControlChooseString("Very High", "ComboBox2","ahk_exe gspro.exe")
               SetControlDelay 0
               ControlChooseString("Display 1 (Left)", "ComboBox3", "ahk_exe gspro.exe")
               SetControlDelay 0
               ControlClick("Play!", "ahk_exe gspro.exe")
          break
          }
          Sleep 500 ;Sleep for 1/2 second before checking again
     }

Sleep 5000  ;Sleep for 5 seconds

{
   Loop 4  ;Sign into VIEW
      {
      if WinExist("ahk_exe VIEW.exe")
         BlockInput true
            DllCall("SetCursorPos", "int", 2120, "int", 320)  ;Move to and Click top recent user (screen)
               Click
            DllCall("SetCursorPos", "int", 3050, "int", 1000)  ;Move to and Click start on View user (screen)
               Click
         BlockInput false
      break
      }
      Sleep 500   ;Sleep for 1/2 second before checking again
}

Sleep 10000  ;Sleep for 10 seconds

{
   Loop 4  ;Click ADD
      {
      if WinExist("ahk_exe VIEW.exe")
         WinActivate "ahk_exe VIEW.exe"
         BlockInput true
            DllCall("SetCursorPos", "int", 3040, "int", 891)  ;Move to and Click ADD (screen)
               Click
         BlockInput false
      break
      }
      WinActivate "ahk_exe gspro.exe"
      Sleep 1000   ;Sleep for 1 second before checking again
}

Sleep 4000  ;Sleep for 4 seconds

{
   Loop 4  ;Click Club
      {
      if WinExist("ahk_exe VIEW.exe")
         WinActivate "ahk_exe VIEW.exe"
         BlockInput true
            DllCall("SetCursorPos", "int", 1998, "int", 330)  ;Move to and Click Club (screen)
               Click
         BlockInput false
      break
      }
      WinActivate "ahk_exe gspro.exe"
      Sleep 1000   ;Sleep for 1 second before checking again
}

Sleep 2000  ;Sleep for 2 seconds

{
   Loop 4  ;Click Photo
      {
      if WinExist("ahk_exe VIEW.exe")
         WinActivate "ahk_exe VIEW.exe"
         BlockInput true
            DllCall("SetCursorPos", "int", 3442, "int", 415)  ;Move to and Click Photo (screen)
               Click
         BlockInput false
      break
      }
      WinActivate "ahk_exe gspro.exe"
      Sleep 500   ;Sleep for 1/2 second before checking again
}

Sleep 1000  ;Sleep for 1 second

   MsgBox "
      (
      Be sure to log in and create a new session in
      Uneekor VIEW if it does not log in automatically.

      DO NOT CLOSE: the "Uneekor Connect" window
         - or GSPro will not work.
      )", "LOFT Golf Studios - REMINDERS", "iconi T120"

BlockInput false
}
ExitApp

