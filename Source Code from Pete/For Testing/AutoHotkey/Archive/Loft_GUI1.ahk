;FileSelectFile, file, 2, %A_ScriptDir%, Select a media file:
file = C:\LOFT\Video\Loft Getting Started.mp4
if Errorlevel
   ExitApp

Gui +LastFound
Gui Add, ActiveX, w1280 h800 vWmp, WMPLayer.OCX
Wmp.Url := file
Gui Show, , Wmp in GUI
return

GuiClose:
ExitApp