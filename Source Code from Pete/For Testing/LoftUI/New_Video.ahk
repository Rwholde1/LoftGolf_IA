#Requires AutoHotkey v2.0
#SingleInstance force

Wsize := SysGet(16)
Hsize := SysGet(17)
DimensionsText := Wsize " / " Hsize

{
	videoPlayer := Gui()
	videoPlayer.BackColor := "161616"
	videoPlayer.Opt("+AlwaysOnTop -Caption +ToolWindow")
	videoPlayer.SetFont("cBlack s36 bold", "Raleway")

	VideoWidth := Wsize * 1.2
	VideoHeight := VideoWidth * 0.56

	videoPlayer.MarginX := (Wsize / 2) - (VideoWidth / 2)

	;ReturnToMain := videoPlayer.Add("Text", "w600 h100 BackgroundFFFFFF 0x201", "Go Back")
	;ReturnToMain.OnEvent("Click", ReturnFromVideo)

	ogcActiveXWmp := videoPlayer.Add("ActiveX", "w" VideoWidth " h" VideoHeight " vWmp", "WMPLayer.OCX")
	Wmp := ogcActiveXWmp.Value
	Wmp.Url := "C:\LOFT\Video\Loft Orientation3.mp4"

	videoPlayer.Show()
	videoPlayer.Maximize()

	BlockInput true
	Sleep 308000
	BlockInput false
	videoPlayer.Destroy()
}