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
    public partial class Caution : Form
    {
        HomeScreen.activity nextActivity;
        HomeScreen.activity prevActivity;
        KaraokeBG? karaokeBG;
        MovieBG? movieBG;
        MeetingBG? meetingBG;
        public Caution(HomeScreen.activity newActivity, HomeScreen.activity prevActivity)
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(750, 450);
            nextActivity = newActivity;
            this.prevActivity = prevActivity;
        }

        public Caution(HomeScreen.activity newActivity, HomeScreen.activity prevActivity, KaraokeBG karaokeBG)
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(750, 450);
            nextActivity = newActivity;
            this.prevActivity = prevActivity;
            this.karaokeBG = karaokeBG;
        }

        public Caution(HomeScreen.activity newActivity, HomeScreen.activity prevActivity, MovieBG movieBG)
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(750, 450);
            nextActivity = newActivity;
            this.prevActivity = prevActivity;
            this.movieBG = movieBG;
        }

        public Caution(HomeScreen.activity newActivity, HomeScreen.activity prevActivity, MeetingBG meetingBG)
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(750, 450);
            nextActivity = newActivity;
            this.prevActivity = prevActivity;
            this.meetingBG = meetingBG;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayOverlay(prevActivity);
        }

        private void displayOverlay(HomeScreen.activity newActivity)
        {
            Hotbar form1 = new Hotbar(newActivity);

            form1.Show();

            this.Hide();
        }

        private void under_Construction()
        {
            UnderConstruction form3 = new UnderConstruction();
            form3.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(this.karaokeBG != null)
            {
                karaokeBG.Close();
            }else if(this.movieBG != null)
            {
                movieBG.Close();
            }else if(this.meetingBG != null)
            {
                meetingBG.Close();
            }

            switch (nextActivity)
            {
                case HomeScreen.activity.home:
                    Program.changeForm(new HomeScreen());
                    this.Hide();
                    break;
                case HomeScreen.activity.golf:
                    // run autohotkey stuff for golf
                    Program.changeForm(new Golf_New_Returning_User(nextActivity));
                    this.Hide();
                    break;
                case HomeScreen.activity.karaoke:
                    // run autohotkey stuff for karaoke
                    Program.changeForm(new Hotbar(nextActivity));
                    this.Hide();
                    break;
                case HomeScreen.activity.movie:
                    Program.changeForm(new Hotbar(nextActivity));
                    this.Hide();
                    break;
                case HomeScreen.activity.meeting:
                    Program.changeForm(new Hotbar(nextActivity));
                    this.Hide();
                    break;
            }
        }
    }
}
