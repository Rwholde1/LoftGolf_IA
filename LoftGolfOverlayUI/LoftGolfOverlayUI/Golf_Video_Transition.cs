using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace LoftGolfOverlayUI
{
    public partial class Golf_Video_Transition : Form
    {
        private Form2.activity currActivity;
        private Golf_New_Returning_User.userType userType;
        private const string ahkexe = @"C:\Program Files\AutoHotkey\v2\AutoHotkey64_UIA.exe";
        private const string scriptPath = @"C:\LOFT\AutoHotkey\LoftStartupGSPro_1.ahk";
        public Golf_Video_Transition(Form2.activity newActivity, Golf_New_Returning_User.userType type)
        {
            InitializeComponent();
            currActivity = newActivity;
            userType = type;
            this.Location = new System.Drawing.Point(0, 0);
            this.TopMost = true;
        }

        private void Golf_Video_Transition_Shown(object sender, EventArgs e)
        {
            if (userType == Golf_New_Returning_User.userType.returningUser)
            {
                axWindowsMediaPlayer1.URL = @"C:\Users\Loft\Desktop\Videos\StartupVideo_3.mp4";
                axWindowsMediaPlayer1.uiMode = "none";
                // run LoftStartupGSPro
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = ahkexe,
                    Arguments = $"\"{scriptPath}\"",
                    UseShellExecute = true
                };
                try
                {
                    Process.Start(psi);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error launching AHK script: " + ex.Message);

                }
            }
            else
            {
                axWindowsMediaPlayer1.URL = @"C:\Users\Loft\Desktop\Videos\LoftOrientation_5.mp4";
                axWindowsMediaPlayer1.uiMode = "none";
            }


        }

        private void axWindowsMediaPlayer1_EndOfStream(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                if (userType == Golf_New_Returning_User.userType.returningUser)
                {
                    Program.changeForm(new Form1(currActivity));
                }
                else
                {
                    Program.changeForm(new Golf_Understanding(currActivity));
                }

            }
        }
    }
}
