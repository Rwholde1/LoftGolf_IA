#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.
;For resolutions 1280x800 Monitor 3 left, 1920x1080 Monitor 1/2 Right

Wsize := SysGet(16)
Hsize := SysGet(17)
DimensionsText := Wsize " / " Hsize

CoordMode "Mouse", "Window"
SetTitleMatchMode 2
BlockInput true

{

;Check if GSPro is running and if not open the program
If WinExist("ahk_exe gspro.exe")
      WinActivate "ahk_exe gspro.exe"
   else
     {
     Run "C:\LOFT\GSProV1\GSPLauncher.exe"
     WinWait("ahk_Class #32770")
     Loop 3
        {
         if WinExist("ahk_Class #32770")
            {
            WinActivate
            SetControlDelay 0
            ControlSetChecked(0, "Button1", "ahk_Class #32770")
            SetControlDelay 0
            ControlChooseString("1280 x 800", "ComboBox1", "ahk_Class #32770")
            SetControlDelay 0
            ControlChooseString("Very High", "ComboBox2","ahk_Class #32770")
            SetControlDelay 0
            ControlChooseString("Display 1 (Left)", "ComboBox3", "ahk_Class #32770")
            SetControlDelay 0
            ControlClick("Play!", "ahk_Class #32770")
            }
            else
               break

             Sleep 500 ;Sleep for 1/2 second before checking again
         }
      }
	  
BuildVideo

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
	Wmp.Url := "C:\Users\Loft\Documents\Videos\TestClip.mp4"

	videoPlayer.Show()
	videoPlayer.Maximize()

	Sleep 32000 ;Milliseconds close to the video length (30000 - 60000)
	videoPlayer.Destroy()
}

if WinExist("ahk_class WindowsForms10.Window.8.app.0.13965fa_r7_ad1")
      WinMinimize "ahk_class WindowsForms10.Window.8.app.0.13965fa_r7_ad1"

;   MsgBox "
;      (
;      DO NOT CLOSE: the "Uneekor Connect" window
;         - or GSPro will not work.
;      )", "LOFT Golf Studios - REMINDERS", "iconi T120"
   }
BlockInput false

ExitApp

