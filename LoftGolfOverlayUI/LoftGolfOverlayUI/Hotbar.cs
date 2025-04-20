namespace LoftGolfOverlayUI
{
    public partial class Hotbar : Form
    {
        private System.Windows.Forms.Timer timer;
        private HomeScreen.activity currActivity;
        private bool helpShown = false;
        string hoverImg = Path.Combine(Application.StartupPath, "Images", "btn_outline.png");

        private KaraokeBG karaokeBGImg;
        private MovieBG movieBGImg;
        private MeetingBG meetingBGImg;

        public Hotbar(HomeScreen.activity newActivity)
        {
            InitializeComponent();
            currActivity = newActivity;

            if (currActivity == HomeScreen.activity.karaoke)
            {
                karaokeBGImg = new KaraokeBG();
                karaokeBGImg.Show();
            }else if (currActivity == HomeScreen.activity.movie)
            {
                movieBGImg = new MovieBG();
                movieBGImg.Show();
            }else if (currActivity == HomeScreen.activity.meeting)
            {
                meetingBGImg = new MeetingBG();
                meetingBGImg.Show();
            }

                this.Location = new System.Drawing.Point(100, 745);
            // Initialize timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;  // Set interval to 1 second (1000 ms)
            timer.Tick += Timer_Tick;  // Subscribe to the Tick event
            timer.Start();  // Start the timer
        }

        private void Pull_up_UI(object sender, EventArgs e)
        {
            while (this.Location.Y > 230)
            {
                this.Location = new System.Drawing.Point(100, Location.Y - 1);
            }
        }

        private void Pull_down_UI(object sender, EventArgs e)
        {
            if (this.PointToClient(Cursor.Position).X < 0 || this.PointToClient(Cursor.Position).X > this.Width - 10 ||
                this.PointToClient(Cursor.Position).Y < 0)
            {
                // this.Location = new System.Drawing.Point(465, 1440);
                while (this.Location.Y < 745)
                {
                    this.Location = new System.Drawing.Point(100, Location.Y + 1);
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the label with the current system time
            UI_Clock.Text = DateTime.Now.ToString("hh:mm");
        }

        private void goHome()
        {
            HomeScreen form2 = new HomeScreen();

            form2.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            caution(HomeScreen.activity.home);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            caution(HomeScreen.activity.home);
        }

        private void golf_hover(object sender, EventArgs e)
        {
            label8.BackgroundImage = Image.FromFile(hoverImg); // Make sure to add your image to Resources
            label8.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void golf_leave(object sender, EventArgs e)
        {
            label8.BackgroundImage = null;
        }
        private void home_hover(object sender, EventArgs e)
        {
            label7.BackgroundImage = Image.FromFile(hoverImg); // Make sure to add your image to Resources
            label7.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void home_leave(object sender, EventArgs e)
        {
            label7.BackgroundImage = null;
        }
        private void karaoke_hover(object sender, EventArgs e)
        {
            label9.BackgroundImage = Image.FromFile(hoverImg); // Make sure to add your image to Resources
            label9.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void karaoke_leave(object sender, EventArgs e)
        {
            label9.BackgroundImage = null;
        }
        private void movie_hover(object sender, EventArgs e)
        {
            label10.BackgroundImage = Image.FromFile(hoverImg); // Make sure to add your image to Resources
            label10.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void movie_leave(object sender, EventArgs e)
        {
            label10.BackgroundImage = null;
        }
        private void meeting_hover(object sender, EventArgs e)
        {
            label11.BackgroundImage = Image.FromFile(hoverImg); // Make sure to add your image to Resources
            label11.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void meeting_leave(object sender, EventArgs e)
        {
            label11.BackgroundImage = null;
        }

        private void system_hover(object sender, EventArgs e)
        {
            label12.BackgroundImage = Image.FromFile(hoverImg);
            label12.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void system_leave(object sender, EventArgs e)
        {
            label12.BackgroundImage = null;
        }

        private void caution(HomeScreen.activity newActivity)
        {
            Caution form3;
            switch(currActivity){
                case (HomeScreen.activity.golf):
                    form3 = new Caution(newActivity, currActivity);
                    form3.Show();
                    this.Hide();
                    break;
                case (HomeScreen.activity.karaoke):
                    form3 = new Caution(newActivity, currActivity, karaokeBGImg);
                    form3.Show();
                    this.Hide();
                    break;
                case (HomeScreen.activity.movie):
                    form3 = new Caution(newActivity, currActivity, movieBGImg);
                    form3.Show();
                    this.Hide();
                    break;
                case (HomeScreen.activity.meeting):
                    form3 = new Caution(newActivity, currActivity, meetingBGImg);
                    form3.Show();
                    this.Hide();
                    break;
            }
        }

        private void restart(HomeScreen.activity newActivity)
        {
            LeaveCurrent form5 = new LeaveCurrent(newActivity);
            form5.ShowDialog();
            this.Hide();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (currActivity == HomeScreen.activity.golf)
            {
                restart(HomeScreen.activity.golf);
            }
            else
            {
                caution(HomeScreen.activity.golf);
            }
        }


        private void label12_Click(object sender, EventArgs e) // help menu
        {
            Troubleshoot form6 = new Troubleshoot(currActivity);
            form6.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (currActivity == HomeScreen.activity.golf)
            {
                restart(HomeScreen.activity.golf);
            }
            else
            {
                caution(HomeScreen.activity.golf);
            }
        }

        // === CLICK KARAOKE BUTTON ===
        private void label9_Click(object sender, EventArgs e)
        {
            if (currActivity == HomeScreen.activity.karaoke)
            {
                restart(HomeScreen.activity.karaoke);
            }
            else
            {
                caution(HomeScreen.activity.karaoke);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (currActivity == HomeScreen.activity.karaoke)
            {
                restart(HomeScreen.activity.karaoke);
            }
            else
            {
                caution(HomeScreen.activity.karaoke);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (currActivity == HomeScreen.activity.movie)
            {
                restart(HomeScreen.activity.movie);
            }
            else
            {
                caution(HomeScreen.activity.movie);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (currActivity == HomeScreen.activity.movie)
            {
                restart(HomeScreen.activity.movie);
            }
            else
            {
                caution(HomeScreen.activity.movie);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (currActivity == HomeScreen.activity.meeting)
            {
                restart(HomeScreen.activity.meeting);
            }
            else
            {
                caution(HomeScreen.activity.meeting);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (currActivity == HomeScreen.activity.meeting)
            {
                restart(HomeScreen.activity.meeting);
            }
            else
            {
                caution(HomeScreen.activity.meeting);
            }
        }
    }
}