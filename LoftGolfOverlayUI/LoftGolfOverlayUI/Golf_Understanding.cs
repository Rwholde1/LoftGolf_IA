using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Golf_Understanding : Form
    {
        string hoverImg = Path.Combine(Application.StartupPath, "Images", "btn_glow.png");
        private Form2.activity currActivity;
        private Golf_New_Returning_User.userType user;
        public Golf_Understanding(Form2.activity newActivity)
        {
            InitializeComponent();
            currActivity = newActivity;
            this.Location = new System.Drawing.Point(0, 0);
        }
        private void golfBtn_MouseEnter(object sender, EventArgs e)
        {
            golfBtn.BackgroundImage = Image.FromFile(hoverImg); // Make sure to add your image to Resources
            golfBtn.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void golfBtn_MouseLeave(object sender, EventArgs e)
        {
            golfBtn.BackgroundImage = null;
        }

        private void videoAgainBtn_MouseEnter(object sender, EventArgs e)
        {
            videoAgainBtn.BackgroundImage = Image.FromFile(hoverImg); // Make sure to add your image to Resources
            videoAgainBtn.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void videoAgainBtn_MouseLeave(object sender, EventArgs e)
        {
            videoAgainBtn.BackgroundImage = null;
        }

        private void golfBtn_Click(object sender, EventArgs e)
        {
            user = Golf_New_Returning_User.userType.returningUser;
            Program.changeForm(new Golf_Video_Transition(currActivity, user));
        }

        private void videoAgainBtn_Click(object sender, EventArgs e)
        {
            user = Golf_New_Returning_User.userType.newUser;
            Program.changeForm(new Golf_Video_Transition(currActivity, user));
        }
    }
}
