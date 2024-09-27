;FileSelectFile, file, 2, %A_ScriptDir%, Select a media file:
file = C:\LOFT\Video\Loft Getting Started_V2.mp4
if Errorlevel
   ExitApp

Gui +LastFound
Gui Add, ActiveX, w1280 h800 vWmp, WMPLayer.OCX
Wmp.Url := file
Gui Show, , Welcome to LOFT Golf Studios - Getting Started
return

GuiClose:
ExitApp