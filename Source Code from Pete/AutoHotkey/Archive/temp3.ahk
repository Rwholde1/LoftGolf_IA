#SingleInstance
;^s::
;{
;	MouseGetPos(&xpos, &ypos)
;	MsgBox("The cursor is at X" xpos " Y" ypos ".")
;}
;
;WinActivate "ahk_exe VIEW.exe"
;MsgBox "The active window's class is " WinGetClass("A")

Esc::
{
	CoordMode
	MouseGetPos(&xpos, &ypos)
	MsgBox("The cursor is at X" xpos " Y" ypos ".")
}
