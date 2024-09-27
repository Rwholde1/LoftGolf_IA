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


AskUser := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center", "Do you want more time?  There is currently")
AskUser2 := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center", "time open after this session.  If you would")
AskUser3 := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center", "like to extend your round. Please go to")
AskUser4 := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center", "LoftGolfStudios.com and BOOK NOW within the")
AskUser5 := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center", "next 5 minutes to continue.  Thank you!")

ReminderBkg := ui.Add("Picture", "w400 h100 xm+300", "btnBackground.png")
Reminder := ui.Add("Text", "w400 h100 BackgroundTrans cWhite 0x201 xp yp", "CONTINUE")

Reminder.OnEvent("Click", DestroyUi)

ui.Show()

DestroyUi(*)
{
	ui.Destroy()
	ExitApp
}
