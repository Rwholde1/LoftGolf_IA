#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.

{
BlockInput true
	;Check if GSPro is running and if not open the program
If WinExist("ahk_exe GSPro.exe")
      WinActivate "ahk_exe GSPro.exe"
else
     {
     Run "C:\GSProV1\GSPLauncher.exe"
		 Sleep 10000
          {
          if WinExist("ahk_exe GSPro.exe")
               WinActivate
               SetControlDelay 0
               ControlSetChecked(0, "Button1", "ahk_exe GSPro.exe")
               SetControlDelay 0
               ControlChooseString("1920 x 1080", "ComboBox1", "ahk_exe GSPro.exe")
               SetControlDelay 0
               ControlChooseString("GSPro Lite", "ComboBox2","ahk_exe GSPro.exe")
               SetControlDelay 0
               ControlChooseString("Display 2 (Left)", "ComboBox3", "ahk_exe GSPro.exe")
               SetControlDelay 0
               ControlClick("Play!", "ahk_exe GSPro.exe")
          }
	  }
	Sleep 60000
BlockInput false
}
ExitApp
