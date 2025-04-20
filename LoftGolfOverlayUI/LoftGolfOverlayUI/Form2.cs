using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace LoftGolfOverlayUI
{
    public partial class Form2 : Form
    {
        string hoverImg = Path.Combine(Application.StartupPath, "Images", "btn_glow.png");
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

            button1.BackgroundImage = Image.FromFile(hoverImg); // Make sure to add your image to Resources
            button1.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = null;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = Image.FromFile(hoverImg); // Make sure to add your image to Resources
            button2.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = null;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackgroundImage = Image.FromFile(hoverImg); // Make sure to add your image to Resources
            button3.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = null;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackgroundImage = Image.FromFile(hoverImg); // Make sure to add your image to Resources
            button4.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currActivity = activity.golf;
            Program.changeForm(new Golf_New_Returning_User(currActivity));
            // ============== insert subsequent forms and automation execution here
            //System.Diagnostics.Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
            // ============== 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // temporary functionality to transition between activites home page and overlay
            currActivity = activity.meeting;
            Form1 form1 = new Form1(currActivity);

            // ============== insert subsequent forms and automation execution here
            //System.Diagnostics.Process.Start("\"C:\\Users\\admin\\AppData\\Roaming\\Zoom\\bin\\Zoom.exe\"");
            // ============== 

            form1.Show();

            this.Hide();
        }

        /*
         * experiment with "panels" in designer to see if we want each subsequent page
         * for each respective activity to be different pages, or if we'll make separate
         * forms for each.
         */
    }
}
