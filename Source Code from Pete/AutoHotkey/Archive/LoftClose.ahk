#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.

;Close GSPro

Result := MsgBox("Are you done golfing for today?","Close GSPro & VIEW", "YesNo")
if Result = "Yes"
{
    ProcessClose("gspro.exe")
    ProcessClose("GSPconnect.exe")
	ProcessClose("view.exe")
    ProcessClose("UneekorLauncher.exe")
          MsgBox "
      (
      Thank you for coming to
      LOFT Golf Studios!
      )", "Goodbye...", "iconi T60"
}
else
    MsgBox "OK! Fairways and greens my friend!"

ExitApp