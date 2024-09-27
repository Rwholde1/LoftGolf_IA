﻿#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.


Wsize := SysGet(16)
Hsize := SysGet(17)
DimensionsText := Wsize " / " Hsize

ui := Gui()
ui.BackColor := "161616"
ui.Opt("+AlwaysOnTop -Caption +ToolWindow")
ui.SetFont("cBlack s36", "Corbel")


AskUser := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center", "Thank you for coming to Loft Golf Studios!")
AskUser2 := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center", "We look forward to seeing you again soon.")
;AskUser3 := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center", "")

;ReminderBkg := ui.Add("Picture", "w400 h100 xm+300", "btnBackground.png")
;Reminder := ui.Add("Text", "w400 h100 BackgroundTrans cWhite 0x201 xp yp", "CONTINUE")

;Reminder.OnEvent("Click", DestroyUi)

ui.Show()

Send "^!z"
Sleep 300000
Send "^!z"
Sleep 1000
SetTimer DestroyUi, -1

DestroyUi(*)
{
	ui.Destroy()
	ExitApp
}
