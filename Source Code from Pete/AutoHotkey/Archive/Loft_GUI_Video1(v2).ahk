#Requires AutoHotkey v2.0
#SingleInstance

myGui := Gui()
ogcActiveXWmp := myGui.Add("ActiveX", "w1280 h800 vWmp", "WMPLayer.OCX")
Wmp := ogcActiveXWmp.Value
Wmp.Url := "C:\LOFT\Video\Loft Getting Started_V2.mp4"
myGui.Title := "LOFT Golf Studios - Getting Started"
myGui.Show()
return

GuiClose:
ExitApp