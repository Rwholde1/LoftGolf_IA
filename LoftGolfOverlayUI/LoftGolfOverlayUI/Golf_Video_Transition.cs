using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoftGolfOverlayUI
{
    public partial class Golf_Video_Transition : Form
    {
        private Form2.activity currActivity;
        private Golf_New_Returning_User.userType userType;
        private Dictionary<string, string> scriptFileDict;
        private string filePathStub;
        public Golf_Video_Transition(Form2.activity newActivity, Golf_New_Returning_User.userType type)
        {
            InitializeComponent();
            currActivity = newActivity;
            userType = type;
            scriptFileDict = Program.retrieveDict();
            filePathStub = Program.retrieveScriptsFilePath();
            this.Location = new System.Drawing.Point(0, 0);
        }

        private void Golf_Video_Transition_Shown(object sender, EventArgs e)
        {
            string fullPath = "";
            if (userType == Golf_New_Returning_User.userType.returningUser)
            {
                string retUserVideoFile = scriptFileDict["GSPro Startup Video"];
                fullPath = Path.Combine(filePathStub, retUserVideoFile);
                axWindowsMediaPlayer1.URL = fullPath;
                axWindowsMediaPlayer1.uiMode = "none";

                string launchGSProAHKFile = scriptFileDict["STARTUP GSPRO"];
                fullPath = Path.Combine(filePathStub, launchGSProAHKFile);
                //Program.runAHKScript(fullPath); //Uncomment when new file system is in place with AHK scripts
            }
            else
            {
                string newUserVideoFile = scriptFileDict["New User Orientation Video"];
                fullPath = Path.Combine(filePathStub, newUserVideoFile);
                axWindowsMediaPlayer1.URL = fullPath;
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
