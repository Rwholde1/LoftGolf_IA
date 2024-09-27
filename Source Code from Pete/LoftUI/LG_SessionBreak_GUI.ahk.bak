#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.


Wsize := SysGet(16)
Hsize := SysGet(17)
DimensionsText := Wsize " / " Hsize

ui := Gui()
ui.BackColor := "161616"
ui.Opt("+AlwaysOnTop -Caption +ToolWindow")
ui.SetFont("cBlack s36", "Corbel")


AskUser := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center", "This session's time has expired.  Select")
AskUser2 := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center", "CONTINUE if you have the next hour reserved")
AskUser3 := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center", "or select RESET THE SIM for the next group.")

ReminderBkg := ui.Add("Picture", "w400 h100 xm+300", "btnBackground.png")
Reminder := ui.Add("Text", "w400 h100 BackgroundTrans cWhite 0x201 xp yp", "CONTINUE")

Reminder.OnEvent("Click", DestroyUiContinue)

ResetBkg := ui.Add("Picture", "w400 h100 xm+300", "btnBackground.png")
Reset := ui.Add("Text", "w400 h100 BackgroundTrans cWhite 0x201 xp yp", "RESET THE SIM")

Reset.OnEvent("Click", DestroyUiReset)

ui.Show()

SetTimer DestroyUIReset, 60000

DestroyUiContinue(*)
{
	ui.Destroy()
	ExitApp
}

DestroyUiReset(*)
{
	ui.Destroy()
	{
		BlockInput true
		;Run [Delete intermediate session silent]
		Run '"C:\Program Files\AutoHotkey\v2\AutoHotkey64.exe" "C:\LOFT\AutoHotkey\LoftCloseIntermediate_Silent_DelSessions.ahk"'
		Sleep 20000
		BlockInput false
	}
	ExitApp
}