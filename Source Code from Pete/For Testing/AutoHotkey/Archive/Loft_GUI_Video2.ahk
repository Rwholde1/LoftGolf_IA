;FileSelectFile, file, 2, %A_ScriptDir%, Select a media file:
file = C:\LOFT\Video\Loft Simulator Gameplay.mp4
if Errorlevel
   ExitApp

Gui +LastFound
Gui Add, ActiveX, w1280 h800 vWmp, WMPLayer.OCX
Wmp.Url := file
Gui Show, , Welcome to LOFT Golf Studios - Gameplay
return

GuiClose:
ExitApp