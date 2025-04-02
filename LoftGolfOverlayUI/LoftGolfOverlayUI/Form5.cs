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
    public partial class Form5 : Form
    {
        Form2.activity currActivity;
        public Form5(Form2.activity newActivity)
        {
            InitializeComponent();
            currActivity = newActivity;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (currActivity)
            {
                case Form2.activity.home:
                    Program.changeForm(new Form2());
                    this.Hide();
                    break;
                case Form2.activity.golf:
                    // run autohotkey stuff for golf
                    Program.changeForm(new Golf_New_Returning_User(currActivity));
                    this.Hide();
                    break;
                case Form2.activity.karaoke:
                    // run autohotkey stuff for karaoke
                    under_Construction();
                    displayOverlay(currActivity);
                    break;
                case Form2.activity.movie:
                    // run autohotkey stuff for movies
                    under_Construction();
                    displayOverlay(currActivity);
                    break;
                case Form2.activity.meeting:
                    // run autohotkey stuff for meeting
                    under_Construction();
                    displayOverlay(currActivity);
                    break;

            };
        }
        private void under_Construction()
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
        private void displayOverlay(Form2.activity newActivity)
        {
            Form1 form1 = new Form1(newActivity);

            form1.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(currActivity);
            form1.Show();
            this.Hide();
        }
    }
}
