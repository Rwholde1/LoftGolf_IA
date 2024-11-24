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

; Define a function to maximize a window by its title
MaximizeWindow(WindowTitle) {
    ; Check if the window exists
    if WinExist(WindowTitle) {
        ; Maximize the window
        WinMaximize, %WindowTitle%
    } else {
        MsgBox, Window not found: %WindowTitle%
    }
}

; Activating Microsoft PowerToys text extractor (can be used to check if cursor is on correct button by reading the text and comparing to expected (can be useful as we make Windows Forms application)
ActivatePowerToysOCR() {
    ; Clear clipboard before starting
    Clipboard := ""
    Sleep, 100

    ; Activate PowerToys Text Extractor (default shortcut: Win + Shift + T)
    Send, #+T
    Sleep, 300 ; Wait for PowerToys to activate

    ; Wait for clipboard text to populate
    ClipWait, 2
    if (ErrorLevel) {
        MsgBox, 48, Error, Text Extractor failed to copy text to clipboard.
        return ""
    }

    ; Return the text from clipboard
    return Clipboard
}

; Send keystrokes to specificed window even if not active (can be useful if needing to run in the background)

SendKeySequenceToWindow(winTitle, keySequence) {
    if WinExist(winTitle) {
        ControlSend,, %keySequence%, %winTitle%
    } else {
        MsgBox, Window not found: %winTitle%
    }
}

; Microsoft Powertoys FancyZones eature (arranges windows into predefined layouts, can possibly be used for displaying UI)
ActivatePowerToysFancyZones() {
    ; Activate FancyZones editor (default shortcut: Win + `)
    Send, #`
    Sleep, 500 ; Wait for FancyZones editor to open

    ; Check if FancyZones editor is open
    if WinExist("FancyZones Editor") {
        MsgBox, FancyZones Editor activated. Configure your layouts.
    } else {
        MsgBox, 48, Error, FancyZones Editor failed to open.
    }
}




