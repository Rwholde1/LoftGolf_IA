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

; Example usage: Maximize Notepad
^m:: ; Ctrl + M hotkey to trigger the function
MaximizeWindow("Untitled - Notepad")
return
