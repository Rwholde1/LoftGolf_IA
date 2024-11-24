; Contains useful functions for AutoHotKey scripts

; Function to check if a pixel color is within bounds of a specified color
CheckPixelColor(x, y, expectedColor) {
    ; Get the color of the pixel at (x, y)
    PixelGetColor, color, x, y

    ; Extract B, G, R values from the colors
    b1 := (color >> 16) & 0xFF
    g1 := (color >> 8) & 0xFF
    r1 := color & 0xFF

    b2 := (expectedColor >> 16) & 0xFF
    g2 := (expectedColor >> 8) & 0xFF
    r2 := expectedColor & 0xFF

    ; Check if each color component is within +-7 of the expected color
    if (Abs(b1 - b2) <= 7 && Abs(g1 - g2) <= 7 && Abs(r1 - r2) <= 7) {
        return true
    }
    return false
}

; Function to check and activate a window or run a program
ActivateOrRun(winTitle, exePath) {
    If WinExist(winTitle)
        WinActivate winTitle
    else
        Run exePath
}

; Function to block or unblock input
BlockInputState(state) {
    BlockInput state
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
        Click x, y
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