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
    public partial class Form2 : Form
    {
        public enum activity
        {
            home, golf, karaoke, movie, meeting
        }
        public activity currActivity = activity.home;

        public Form2()
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(0, 0);
            currActivity = 0;
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

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.karaoke_highlight; // Make sure to add your image to Resources
            button3.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = null;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackgroundImage = Properties.Resources.meeting_highlight; // Make sure to add your image to Resources
            button4.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // temporary functionality to transition between activites home page and overlay
            currActivity = activity.golf;
            Golf_New_Returning_User form1 = new Golf_New_Returning_User(currActivity);
            
            // ============== insert subsequent forms and automation execution here

            // ============== 

            form1.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        /*
         * experiment with "panels" in designer to see if we want each subsequent page
         * for each respective activity to be different pages, or if we'll make separate
         * forms for each.
         */
    }
}
