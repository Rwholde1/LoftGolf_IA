#Requires AutoHotkey v2.0
#SingleInstance
#Warn  ; Enable warnings to assist with detecting common errors.
;For resolutions 1280x800 Monitor 3 left, 1920x1080 Monitor 1/2 Right

CoordMode "Mouse", "Window"
mouseX
mouseY
SetTitleMatchMode 2
{
   BlockInput true
   {
   ;Check if View is running and if not open the program
   If WinExist("ahk_exe VIEW.exe")
        WinActivate "ahk_exe VIEW.exe"
      else
      {
      Run "C:\LOFT\Uneekor\Launcher\UneekorLauncher.exe /run VIEW"
      WinWaitActive("ahk_exe VIEW.exe", , 30)
      }
      Sleep 25000
      {
      Loop 2  ;Sign into VIEW
         {
         if WinExist("ahk_exe VIEW.exe")
         {
            WinActivate "ahk_exe VIEW.exe"
            MouseMove 455, 340  ;Move to and Click top recent user (window)
            MouseGetPos(&mouseX, &mouseY)
            while (PixelGetColor(mouseX, mouseY) != "0x979797")
            {
                MouseMove 455, 340
                Sleep(200)
                MouseGetPos(&mouseX, &mouseY)
            }
            Click 455, 340

            Sleep 200
            Click 1375, 1025  ;Move to and Click start on View user (window)
         }
            else
               break

         Sleep 500   ;Sleep for 1/2 second before checking again
         }
      }

   Sleep 6000  ;Sleep for 6 seconds

      {
      Loop 2  ;Click ADD
         {
         if WinExist("ahk_exe VIEW.exe")
         {
            WinActivate "ahk_exe VIEW.exe"
               Click 1360, 910  ;Move to and Click ADD (window)
         }
            else
               break

         Sleep 500   ;Sleep for 1/2 second before checking again
         }
      }

   Sleep 1000  ;Sleep for 1 second

      {
      Loop 2  ;Click Club
         {
         if WinExist("ahk_exe VIEW.exe")
         {
            WinActivate "ahk_exe VIEW.exe"
               Click 317, 380  ;Move to and Click Club (window)
         }
            else
               break

         Sleep 500   ;Sleep for 1/2 second before checking again
         }
      }

   Sleep 500  ;Sleep for 1/2 second

      {
      Loop 2  ;Click Photo
         {
         if WinExist("ahk_exe VIEW.exe")
         {
            WinActivate "ahk_exe VIEW.exe"
               Click 1770,445  ;Move to and Click Photo (window)
         }
            else
               break

         Sleep 500   ;Sleep for 1/2 second before checking again
         }
      }

   }
   BlockInput false

Run '"C:\Program Files\AutoHotkey\v2\AutoHotkey64" "C:\LOFT\LoftUI\LG_Start_GUI.ahk"'
}
ExitApp

