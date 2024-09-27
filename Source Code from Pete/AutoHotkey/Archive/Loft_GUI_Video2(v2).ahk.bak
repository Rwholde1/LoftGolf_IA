#Requires AutoHotkey v2.0
#SingleInstance

Video2 := Gui()
ogcActiveXWmp := Video2.Add("ActiveX", "w1280 h800 vWmp", "WMPLayer.OCX")
Wmp := ogcActiveXWmp.Value
Wmp.Url := "C:\LOFT\Video\Loft Simulator Gameplay.mp4"
Video2.Title := "LOFT Golf Studios - Gameplay"
Video2.Show()
return

GuiClose:
ExitApp