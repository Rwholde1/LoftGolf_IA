#Requires AutoHotkey v2.0
#SingleInstance

TimeString := FormatTime(, "Time")
;Msg := "
;	(
;		TIME CHECK...It is now {}
;
;		Are you scheduled for the following hour?
;	)"
;MsgBox Format(Msg, TimeString)

result := MsgBox("TIME CHECK...It is now " TimeString "!"
		. "   Are you scheduled for the following hour?", "TIME CHECK", "YesNo")
	if (result = "Yes")
		MsgBox "Great!  Enjoy the rest of your round!", "Continue"
	else if (result = "No")
	{
		MsgBox "
		(
		  This is your 5 MINUTE Warning...
		  Prepare to complete your round and gather your
		  belongings and clean up any trash so that the
		  bay is ready for the next group.

		  If you would like to continue, go online now and
		  book the next hour now (if the spot is available).

		  GSPro will close automatically at the end of your
		  scheduled session.
		)", "Countdown", "icon!"
			Sleep 10000
			if winexist("gspro.exe")
				ProcessClose("gspro.exe")
				ProcessClose("GSPconnect.exe")
				Sleep 10000
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
					 ControlChooseString("1680 x 1050", "ComboBox1", "ahk_Class #32770")
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
			else
				return
	}
	WinWaitActive("ahk_Class #32770")

ExitApp




