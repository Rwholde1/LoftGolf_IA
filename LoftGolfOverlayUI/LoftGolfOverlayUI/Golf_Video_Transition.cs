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
        public Golf_Video_Transition(Form2.activity newActivity, Golf_New_Returning_User.userType type)
        {
            InitializeComponent();
            currActivity = newActivity;
            userType = type;
            this.Location = new System.Drawing.Point(0, 0);
        }

        private void Golf_Video_Transition_Shown(object sender, EventArgs e)
        {
            if (userType == Golf_New_Returning_User.userType.returningUser)
            {
                label1.Text = "  Getting golf ready for you! Just a moment! ";
                axWindowsMediaPlayer1.URL = @"C:\Users\admin\Documents\LoftGolf_IA\LoftGolfOverlayUI\LoftGolfOverlayUI\testvideo.mp4";
                axWindowsMediaPlayer1.uiMode = "none";
            }
            else
            {
                label1.Text = "Please watch this video to learn how to golf!";
                axWindowsMediaPlayer1.URL = @"C:\Users\admin\Documents\LoftGolf_IA\LoftGolfOverlayUI\LoftGolfOverlayUI\testvideo2.mp4";
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
