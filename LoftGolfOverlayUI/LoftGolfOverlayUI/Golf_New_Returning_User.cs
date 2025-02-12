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
    public partial class Golf_New_Returning_User : Form
    {
        private Form2.activity currActivity;

        public Golf_New_Returning_User(Form2.activity newActivity)
        {
            InitializeComponent();
            currActivity = newActivity;
            this.Location = new System.Drawing.Point(0, 0);
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.golf_highlight; // Make sure to add your image to Resources
            button1.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = null;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.movie_highlight; // Make sure to add your image to Resources
            button2.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
