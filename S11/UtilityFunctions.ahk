; Contains useful functions for AutoHotKey scripts

DebugColor := false

; ===================================================================================================================

CoordMode("Mouse", "Window")
CoordMode("Pixel", "Window")

; ===================================================================================================================
; Checks to see if the color of the pixel at (x, y) matches the expected color
ColorMatch(x, y, expectedColor)
{
    color := PixelGetColor(x, y)
    return (color == expectedColor)
}

ClickFast(x, y, expectedColor)
{
    ButtonClicked := false
    if (DebugColor)
    {
        Sleep 20000
        color := PixelGetColor(x, y)
        MsgBox("Pixel at (" x "," y ") = " Format("0x{:06X}", color) "`nExpected: " Format("0x{:06X}", expectedColor))
    }
    while (!ButtonClicked)
        {
        if(ColorMatch(x, y, expectedColor))
        {
            CoordMode("Mouse", "Window")
            Sleep 200
            Click(x, y)
            Sleep 200
            ButtonClicked := true
        }
    }
}

DeleteSessions(rem)
{
    ;Sleep 10000
    while(!(PixelGetColor(1200, 20) == 0x141416 or PixelGetColor(1200, 20) == 0x1E1E22))
    {
        Sleep 250
    }
    Sleep 5000
    if (PixelGetColor(22, 260) != 0x1E1E22)     ; see if active sessions exist
    {
        Click(34, 1052)
        Sleep 200
        Click(24, 233)
        Sleep 200
        Click(200, 1000)
        Sleep 200
        CLick(1025, 578)
        Sleep 200
        Click(34, 1052)
        Sleep 200
        if (rem == 1)
        {
            ClickFast(38, 165, 0x2D2D34)     ; click add session button
        }
    }
}

; Function to check and activate a window or run a program
ActivateOrRun(winTitle, exePath) {
    If WinExist(winTitle)
        WinActivate winTitle
    else
        Run exePath
}

; Function to wait for a window to exist and activate it
WaitAndActivateWindow(winTitle, timeout := 30) {
    StartTime := A_TickCount
    Loop {
        if WinExist(winTitle) {
            WinActivate winTitle
            return true
        }
        if (A_TickCount - StartTime > timeout * 1000) {
            return false  ; Timeout after the specified seconds
        }
        Sleep 500  ; Check every 0.5 seconds
    }
    return false
}

; Function to click a specific control in a window by class and coordinates
ClickControl(className, x, y) {
    if WinExist(className) {
        WinActivate className
        Click(x, y)
    }
}

; Function to set a control's value or select an option from a dropdown
ControlSetOption(className, controlType, controlName, optionValue) {
    SetControlDelay 0
    if WinExist(className) {
        WinActivate className
        if (controlType == "ComboBox") {
            ControlChooseString(optionValue, controlName, className)
        } else if (controlType == "Button") {
            ControlSetChecked(0, controlName, className)
        }
    }
}

; Function to wait for a program to start and interact with it
WaitForAndSetupProgram(exePath, winTitle, controls := []) {
    Run exePath
    WinWait(winTitle)
    ; Optionally interact with controls here
    for index, controlData in controls {
        ControlSetOption(controlData.className, controlData.controlType, controlData.controlName, controlData.optionValue)
    }
}
