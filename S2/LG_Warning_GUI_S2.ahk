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


AskUser := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center", "There are 5 minutes left in this session.")
AskUser2 := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center", "Begin wrapping up your round to allow the")
AskUser3 := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center", "next group to start on time.  Thank you.")

ReminderBkg := ui.Add("Picture", "w400 h100 xm+300", "btnBackground.png")
Reminder := ui.Add("Text", "w400 h100 BackgroundTrans cWhite 0x201 xp yp", "OK")

Reminder.OnEvent("Click", DestroyUi)

ui.Show()

SetTimer DestroyUI, 240000

DestroyUi(*)
{
	ui.Destroy()
	ExitApp
}
