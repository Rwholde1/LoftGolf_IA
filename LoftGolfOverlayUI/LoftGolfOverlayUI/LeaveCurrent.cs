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
    public partial class LeaveCurrent : Form
    {
        HomeScreen.activity currActivity;
        public LeaveCurrent(HomeScreen.activity newActivity)
        {
            InitializeComponent();
            currActivity = newActivity;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (currActivity)
            {
                case HomeScreen.activity.home:
                    Program.changeForm(new HomeScreen());
                    this.Hide();
                    break;
                case HomeScreen.activity.golf:
                    // run autohotkey stuff for golf
                    Program.changeForm(new Golf_New_Returning_User(currActivity));
                    this.Hide();
                    break;
                case HomeScreen.activity.karaoke:
                    // run autohotkey stuff for karaoke
                    Program.changeForm(new Hotbar(currActivity));
                    this.Hide();
                    break;
                case HomeScreen.activity.movie:
                    // run autohotkey stuff for movies
                    Program.changeForm(new Hotbar(currActivity));
                    this.Hide();
                    break;
                case HomeScreen.activity.meeting:
                    // run autohotkey stuff for meeting
                    Program.changeForm(new Hotbar(currActivity));
                    this.Hide();
                    break;

            };
        }
        private void under_Construction()
        {
            UnderConstruction form4 = new UnderConstruction();
            form4.ShowDialog();
        }
        private void displayOverlay(HomeScreen.activity newActivity)
        {
            Hotbar form1 = new Hotbar(newActivity);

            form1.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hotbar form1 = new Hotbar(currActivity);
            form1.Show();
            this.Hide();
        }
    }
}
