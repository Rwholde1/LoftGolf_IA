﻿gameSelect := Gui()

Wsize := SysGet(16)
Hsize := SysGet(17)
DimensionsText := Wsize " / " Hsize

BuildGameSelect

BuildGameSelect(*)
{
	gameSelect.BackColor := "161616"
	gameSelect.Opt("+AlwaysOnTop -Caption +ToolWindow")
	gameSelect.SetFont("cBlack s36", "Yu Gothic")
	Wsize := SysGet(16)
	Hsize := SysGet(17)

	LogoWidth := Wsize / 8
	gameSelect.MarginX := (Wsize / 2) - (LogoWidth / 2)
	gameSelect.MarginY := Hsize / 15
	gameSelect.AddPicture("w" LogoWidth " h-1", "loftgolflogo-white2.png")

	OptionsMargin := (LogoWidth / 2) - 450
	MainMargin := (LogoWidth / 2) - 300
	MyMargin := Abs(OptionsMargin)
	ReturnMargin := Abs(MainMargin)


	if (OptionsMargin < 0) {
		GolfBkg := gameSelect.Add("Picture", "w400 h100 xm-" MyMargin, "btnBackground.png")
		Golf := gameSelect.Add("Text", "w400 h100 BackgroundTrans cWhite 0x201 xp yp", "GOLF")

		KaraokeBkg := gameSelect.Add("Picture", "w400 h100 xp+500", "soon.png")
		Karaoke := gameSelect.Add("Text", "w400 h100 BackgroundTrans cGray 0x201 xp yp", "KARAOKE")
		gameSelect.SetFont("cBlack s16", "Yu Gothic")
		KaraokeComingSoon := gameSelect.Add("Text", "w400 h100 BackgroundTrans cGray 0x201 xp yp+35", "Coming Soon")

		gameSelect.SetFont("cBlack s36", "Yu Gothic")
		MovieBkg := gameSelect.Add("Picture", "w400 h100 xm-" MyMargin " Section", "soon.png")
		Movie := gameSelect.Add("Text", "w400 h100 BackgroundTrans cGray 0x201 xp yp", "MOVIE")
		gameSelect.SetFont("cBlack s16", "Yu Gothic")
		MovieComingSoon := gameSelect.Add("Text", "w400 h100 BackgroundTrans cGray 0x201 xp yp+35", "Coming Soon")

		gameSelect.SetFont("cBlack s36", "Yu Gothic")
		GameBkg := gameSelect.Add("Picture", "w400 h100 xp+500 yp-35", "soon.png")
		Game := gameSelect.Add("Text", "w400 h100 BackgroundTrans cGray 0x201 xp yp", "MEETING")
		gameSelect.SetFont("cBlack s16", "Yu Gothic")
		GameComingSoon := gameSelect.Add("Text", "w400 h100 BackgroundTrans cGray 0x201 xp yp+35", "Coming Soon")

	} else {
		GolfBkg := gameSelect.Add("Picture", "w400 h100 xm+" MyMargin, "btnBackground.png")
		Golf := gameSelect.Add("Text", "w400 h100 BackgroundTrans cWhite 0x201 xp yp", "GOLF")

		KaraokeBkg := gameSelect.Add("Picture", "w400 h100 xp+500", "soon.png")
		Karaoke := gameSelect.Add("Text", "w400 h100 BackgroundTrans cGray 0x201 xp yp", "KARAOKE")
		gameSelect.SetFont("cBlack s16", "Yu Gothic")
		KaraokeComingSoon := gameSelect.Add("Text", "w400 h100 BackgroundTrans cGray 0x201 xp yp+35", "Coming Soon")

		gameSelect.SetFont("cBlack s36", "Yu Gothic")
		MovieBkg := gameSelect.Add("Picture", "w400 h100 xm+" MyMargin " Section", "soon.png")
		Movie := gameSelect.Add("Text", "w400 h100 BackgroundTrans cGray 0x201 xp yp", "MOVIE")
		gameSelect.SetFont("cBlack s16", "Yu Gothic")
		MovieComingSoon := gameSelect.Add("Text", "w400 h100 BackgroundTrans cGray 0x201 xp yp+35", "Coming Soon")

		gameSelect.SetFont("cBlack s36", "Yu Gothic")
		GameBkg := gameSelect.Add("Picture", "w400 h100 xp+500 yp-35", "soon.png")
		Game := gameSelect.Add("Text", "w400 h100 BackgroundTrans cGray 0x201 xp yp", "GAME")
		gameSelect.SetFont("cBlack s16", "Yu Gothic")
		GameComingSoon := gameSelect.Add("Text", "w400 h100 BackgroundTrans cGray 0x201 xp yp+35", "Coming Soon")
	}

	Golf.OnEvent("Click", BuildNewUser)

	gameSelect.Show()
	gameSelect.Maximize()

	GoBack(*)
	{
		gameSelect.Destroy()
	}
}

BuildNewUser(*)
{
	ui := Gui()
	ui.BackColor := "161616"
	ui.Opt("+AlwaysOnTop -Caption +ToolWindow")
	ui.SetFont("cBlack s36", "Yu Gothic")
	Wsize := SysGet(16)
	Hsize := SysGet(17)

	LogoWidth := Wsize / 8
	ui.MarginX := (Wsize / 2) - (LogoWidth / 2)
	ui.MarginY := Hsize / 15
	ui.AddPicture("w" LogoWidth " h-1", "loftgolflogo-white2.png")

	OptionsMargin := (LogoWidth / 2) - 450
	QuestionsMargin := (LogoWidth / 2) - 500
	MainMargin := (LogoWidth / 2) - 300
	MyMargin := Abs(OptionsMargin)
	TextMargin := Abs(QuestionsMargin)
	ReturnMargin := Abs(MainMargin)

	AskUser := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center xm-" TextMargin, "FIRST TIME HERE OR BEEN HERE BEFORE?")

	if (OptionsMargin < 0) {
		NewBkg := ui.Add("Picture", "w400 h100 xm-" MyMargin, "btnBackground.png")
		New := ui.Add("Text", "w400 h100 BackgroundTrans cWhite 0x201 xp yp", "FIRST TIME")

		ExistingBkg := ui.Add("Picture", "w400 h100 xp+500", "btnBackground.png")
		Existing := ui.Add("Text", "w400 h100 BackgroundTrans cWhite 0x201 xp yp", "RETURN VISIT")

		GoBack := ui.Add("Text", "w600 h100 BackgroundFFFFFF 0x201 xm-" ReturnMargin " Section", "BACK TO MAIN MENU")

	} else {
		NewBkg := ui.Add("Picture", "w400 h100 xm+" MyMargin, "btnBackground.png")
		New := ui.Add("Text", "w400 h100 BackgroundTrans cWhite 0x201 xp yp", "NEW")

		ExistingBkg := ui.Add("Picture", "w400 h100 xp+500", "btnBackground.png")
		Existing := ui.Add("Text", "w400 h100 BackgroundTrans cWhite 0x201 xp yp", "EXISTING")

		GoBack := ui.Add("Text", "w600 h100 BackgroundFFFFFF 0x201 xm+" ReturnMargin " Section", "GO BACK")
	}

	New.OnEvent("Click", PlayVideo)
	Existing.OnEvent("Click", DestroyUi)
	GoBack.OnEvent("Click", ReturnToMain)

	ui.Show()
	ui.Maximize()

	PlayVideo(*)
	{
		ui.Destroy()
		BuildVideo
	}

	ReturnToMain(*)
	{
		ui.Destroy()
	}

	DestroyUi(*)
	{
		ui.Destroy()
		gameSelect.Destroy()
		LoftStartupGSPro
	}
}

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
	Wmp.Url := "C:\LOFT\Video\Loft Orientation3.mp4"

	videoPlayer.Show()
	videoPlayer.Maximize()

	Sleep 320000
	ReplayVideo
	videoPlayer.Destroy()
}

ReplayVideo(*)
{
	ui := Gui()
	ui.BackColor := "161616"
	ui.Opt("+AlwaysOnTop -Caption +ToolWindow")
	ui.SetFont("cBlack s36", "Yu Gothic")
	Wsize := SysGet(16)
	Hsize := SysGet(17)

	LogoWidth := Wsize / 8
	ui.MarginX := (Wsize / 2) - (LogoWidth / 2)
	ui.MarginY := Hsize / 15
	ui.AddPicture("w" LogoWidth " h-1", "loftgolflogo-white2.png")

	OptionsMargin := (LogoWidth / 2) - 450
	MainMargin := (LogoWidth / 2) - 300
	MyMargin := Abs(OptionsMargin)
	ReturnMargin := Abs(MainMargin)


	if (OptionsMargin < 0) {
		NewBkg := ui.Add("Picture", "w400 h100 xm-" MyMargin, "btnBackground.png")
		New := ui.Add("Text", "w400 h100 BackgroundTrans cWhite 0x201 xp yp", "REPLAY")

		ExistingBkg := ui.Add("Picture", "w400 h100 xp+500", "btnBackground.png")
		Existing := ui.Add("Text", "w400 h100 BackgroundTrans cWhite 0x201 xp yp", "LETS GOLF")

	} else {
		NewBkg := ui.Add("Picture", "w400 h100 xm+" MyMargin, "btnBackground.png")
		New := ui.Add("Text", "w400 h100 BackgroundTrans cWhite 0x201 xp yp", "NEW")

		ExistingBkg := ui.Add("Picture", "w400 h100 xp+500", "btnBackground.png")
		Existing := ui.Add("Text", "w400 h100 BackgroundTrans cWhite 0x201 xp yp", "EXISTING")
	}

	New.OnEvent("Click", PlayVideo)
	Existing.OnEvent("Click", DestroyUi)

	ui.Show()
	ui.Maximize()

	PlayVideo(*)
	{
		ui.Destroy()
		BuildVideo
	}

	ReturnToMain(*)
	{
		ui.Destroy()
	}

	DestroyUi(*)
	{
		ui.Destroy()
		gameSelect.Destroy()
		LoftStartupGSPro
	}
}

LoftStartupGSPro(*)
{
	RunGSPro
	Sleep 600000
	Loop
	{
		sleep 60000
		TimeString := FormatTime("T2 T12", "Time")
		GetMinutes := SubStr(TimeString, 4, 2)
		ConvertToInt := Integer(GetMinutes)
		TimeLeft := (60 - ConvertToInt)
		if (TimeLeft < 10)
		{
			BuildPrompt
			break
		}
	}

	BuildPrompt(*)
	{
		ui := Gui()
		ui.BackColor := "161616"
		ui.Opt("+AlwaysOnTop -Caption +ToolWindow")
		ui.SetFont("cBlack s36", "Yu Gothic")
		Wsize := SysGet(16)
		Hsize := SysGet(17)

		AskUser := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center", "There are 5 minutes left in this session.")
		AskUser2 := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center", "Please prepare to leave, or")
		AskUser3 := ui.Add("Text", "w1000 h100 BackgroundTrans cWhite 0x201 Center", "continue if you have next hour reserved.")

		ReminderBkg := ui.Add("Picture", "w400 h100 xm+300", "btnBackground.png")
		Reminder := ui.Add("Text", "w400 h100 BackgroundTrans cWhite 0x201 xp yp", "Continue")

		Reminder.OnEvent("Click", DestroyUi)

		ui.Show()

		DestroyUi(*)
		{
			ui.Destroy()
			gameSelect.Destroy()
		}
	}
}

RunGSPro(*)
{
	Run '"C:\Program Files\AutoHotkey\v2\AutoHotkey64.exe" "C:\LOFT\AutoHotkey\LoftStartupGSPro_1.ahk"'
}