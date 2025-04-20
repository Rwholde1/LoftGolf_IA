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
        private Dictionary<string, string> scriptFileDict;
        public Golf_Video_Transition(Form2.activity newActivity, Golf_New_Returning_User.userType type)
        {
            InitializeComponent();
            currActivity = newActivity;
            userType = type;
            scriptFileDict = Program.retrieveDict();
            this.Location = new System.Drawing.Point(0, 0);
            this.TopMost = true;
        }

        private void Golf_Video_Transition_Shown(object sender, EventArgs e)
        {
            if (userType == Golf_New_Returning_User.userType.returningUser)
            {
                string retUserVideoFile = scriptFileDict["GSPro Startup Video"];
                axWindowsMediaPlayer1.URL = retUserVideoFile;
                axWindowsMediaPlayer1.uiMode = "none";

                string launchGSProAHKFile = scriptFileDict["STARTUP GSPRO"];
                Program.runAHKScript(launchGSProAHKFile);
            }
            else
            {
                string newUserVideoFile = scriptFileDict["New User Orientation Video"];
                axWindowsMediaPlayer1.URL = newUserVideoFile;
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
