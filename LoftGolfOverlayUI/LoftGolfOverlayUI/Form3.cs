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
    public partial class Form3 : Form
    {
        Form2.activity nextActivity;
        Form2.activity prevActivity;
        public Form3(Form2.activity newActivity, Form2.activity prevActivity)
        {
            InitializeComponent();
            nextActivity = newActivity;
            this.prevActivity = prevActivity;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayOverlay(prevActivity);
        }

        private void displayOverlay(Form2.activity newActivity)
        {
            Form1 form1 = new Form1(newActivity);

            form1.Show();

            this.Hide();
        }

        private void under_Construction()
        {
            Form4 form3 = new Form4();
            form3.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            switch (nextActivity)
            {
                case Form2.activity.home:
                    Program.changeForm(new Form2());
                    this.Hide();
                    break;
                case Form2.activity.golf:
                    // run autohotkey stuff for golf
                    Program.changeForm(new Golf_New_Returning_User(nextActivity));
                    this.Hide();
                    break;
                case Form2.activity.karaoke:
                    // run autohotkey stuff for karaoke
                    under_Construction();
                    displayOverlay(nextActivity);
                    break;
                case Form2.activity.movie:
                    // run autohotkey stuff for movies
                    under_Construction();
                    displayOverlay(nextActivity);
                    break;
                case Form2.activity.meeting:
                    // run autohotkey stuff for meeting
                    under_Construction();
                    displayOverlay(nextActivity);
                    break;

            };

        }
    }
}
