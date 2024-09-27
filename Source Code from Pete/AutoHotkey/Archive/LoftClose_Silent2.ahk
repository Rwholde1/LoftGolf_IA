#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.

;WinActivate "ahk_exe VIEW.exe"

Sleep 500
Loop 4
{
Loop 4
    {
    BlockInput true
        DllCall("SetCursorPos", "int", 1700, "int", 175)  ;Check box for Session #1 (screen)
            SetControlDelay 2
                Click
        DllCall("SetCursorPos", "int", 1900, "int", 1020)  ;Select Delete (screen)
            SetControlDelay 2
                Click
    BlockInput false
    }
Sleep 500
    Loop 4
    {
    BlockInput true
        DllCall("SetCursorPos", "int", 1700, "int", 232)  ;Check box for Session #2 (screen)
            SetControlDelay 2
                Click
        DllCall("SetCursorPos", "int", 1900, "int", 1020)  ;Select Delete (screen)
            SetControlDelay 2
                Click
    BlockInput false
    }
Sleep 500
    Loop 4
    {
    BlockInput true
        DllCall("SetCursorPos", "int", 1700, "int", 287)  ;Check box for Session #3 (screen)
            SetControlDelay 2
                Click
        DllCall("SetCursorPos", "int", 1900, "int", 1020)  ;Select Delete (screen)
            SetControlDelay 2
                Click
    BlockInput false
    }
Sleep 500
    Loop 4
    {
    BlockInput true
        DllCall("SetCursorPos", "int", 1700, "int", 342)  ;Check box for Session #4 (screen)
            SetControlDelay 2
                Click
        DllCall("SetCursorPos", "int", 1900, "int", 1020)  ;Select Delete (screen)
            SetControlDelay 2
                Click
    BlockInput false
    }
Sleep 500
    Loop 4
    {
    BlockInput true
        DllCall("SetCursorPos", "int", 1700, "int", 397)  ;Check box for Session #5 (screen)
            SetControlDelay 2
                Click
        DllCall("SetCursorPos", "int", 1900, "int", 1020)  ;Select Delete (screen)
            SetControlDelay 2
                Click
    BlockInput false
    }
Sleep 500
    Loop 4
    {
    BlockInput true
        DllCall("SetCursorPos", "int", 1700, "int", 452)  ;Check box for Session #6 (screen)
            SetControlDelay 2
                Click
        DllCall("SetCursorPos", "int", 1900, "int", 1020)  ;Select Delete (screen)
            SetControlDelay 2
                Click
    BlockInput false
    }
Sleep 500
    Loop 4
    {
    BlockInput true
        DllCall("SetCursorPos", "int", 1700, "int", 507)  ;Check box for Session #7 (screen)
            SetControlDelay 2
                Click
        DllCall("SetCursorPos", "int", 1900, "int", 1020)  ;Select Delete (screen)
            SetControlDelay 2
                Click
    BlockInput false
    }
Sleep 500
    Loop 4
    {
    BlockInput true
        DllCall("SetCursorPos", "int", 1700, "int", 562)  ;Check box for Session #8 (screen)
            SetControlDelay 2
                Click
        DllCall("SetCursorPos", "int", 1900, "int", 1020)  ;Select Delete (screen)
            SetControlDelay 2
                Click
    BlockInput false
    }
Sleep 500
    Loop 4
    {
    BlockInput true
        DllCall("SetCursorPos", "int", 1700, "int", 617)  ;Check box for Session #9 (screen)
            SetControlDelay 2
                Click
        DllCall("SetCursorPos", "int", 1900, "int", 1020)  ;Select Delete (screen)
            SetControlDelay 2
                Click
    BlockInput false
    }
}
Sleep 500
{
    ProcessClose("gspro.exe")
    ProcessClose("GSPconnect.exe")
	ProcessClose("view.exe")
    ProcessClose("UneekorLauncher.exe")
}

ExitApp