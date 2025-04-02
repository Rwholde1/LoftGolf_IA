#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.

Wsize := SysGet(16)
Hsize := SysGet(17)
DimensionsText := Wsize " / " Hsize

CoordMode "Mouse", "Window"
SetTitleMatchMode 2

BuildVideo(*)
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
	Wmp.Url := "C:\Users\Loft\Documents\Videos\Loft_Amenities_1.mp4" ; Change this link

	videoPlayer.Show()
	videoPlayer.Maximize()

	Sleep 27000 ;Milliseconds close to the video length (30000 - 60000)
	videoPlayer.Destroy()
}

BuildVideo
ExitApp