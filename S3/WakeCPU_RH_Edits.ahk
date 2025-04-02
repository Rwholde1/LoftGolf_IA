#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.

keystrokeWake(){
	Send("{Shift down}")
	Sleep(50)
	Send("{Shift up}")
}

mouseWake(){
	MouseMove 10, 10, 100, 'R'
	MouseMove -10, -10, 100, 'R'
}

commandWake(){
	SendMessage 0x0112, 0xF170, -1,, "Program Manager"  ; 0x0112 is WM_SYSCOMMAND, 0xF170 is SC_MONITORPOWER.
}


keystrokeWake()
mouseWake()
commandWake()
Sleep(15000) ; Sleep for 15 seconds to give ample time for the PC to wake up. This could be adjusted down.


ExitApp