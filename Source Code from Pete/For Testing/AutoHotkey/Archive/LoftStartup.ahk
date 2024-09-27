#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.

;          MsgBox "
;      (
;      Don't forget to turn on
;      the Uneekor first!
;      It is the switch by the
;      club storage labeled Uneekor.
;      We hope you have a great time
;      today at LOFT Golf Studios!
;      )", "Welcome in!", "iconi T20"

;Check if View is running and if not open the program
If WinExist("ahk_exe view.exe")
     WinActivate "ahk_exe view.exe"
else
{
   Run "C:\LOFT\Uneekor\Launcher\UneekorLauncher.exe /run VIEW"
   WinWaitActive("ahk_exe view.exe", , 30)
      MsgBox "
      (
      Select Loft Golf Studios
      or your MyUneekor profile
      once VIEW loads and then
      click START to continue.
      )", "Start VIEW", "iconi T20"
}


            ;Check if GSPro is running and if not open the program
            If WinExist("ahk_exe gspro.exe")
                  WinActivate "ahk_exe gspro.exe"
             else
             {
                Run "C:\LOFT\GSProV1\GSPLauncher.exe"

            sleep 5000

            WinWaitActive "ahk_exe gspro.exe"

            ControlSetChecked(0, "Button1", "ahk_exe gspro.exe")
            ControlChooseString("1280 x 800", "ComboBox1", "ahk_exe gspro.exe")
            ControlChooseString("Very High", "ComboBox2","ahk_exe gspro.exe")
            ControlChooseString("Display 2 (Left)", "ComboBox3", "ahk_exe gspro.exe")

            SetControlDelay -1
            ControlClick "Play!", "ahk_exe gspro.exe"
         }

Sleep 10000

      MsgBox "
      (
      REMINDER:
      - Do NOT close the Uneekor Connect window.
         Minimize the window or GSPro will not work.
      - Add a new session in VIEW to continue.
      - Maximize VIEW and select CLUB for club data.
      )", "LOFT Golf Studios - Reminders", "iconi T20"

;if WinExist("ahk_exe UneekorLauncher.exe")
;   WinClose
;else
;   WinClose("ahk_exe UneekorLauncher.exe")

ExitApp