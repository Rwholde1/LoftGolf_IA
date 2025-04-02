namespace LoftGolfOverlayUI
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private Form2.activity currActivity;
        private bool helpShown = false;
        public Form1(Form2.activity newActivity)
        {
            InitializeComponent();
            currActivity = newActivity;
            this.Location = new System.Drawing.Point(465, 1420);
            // Initialize timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;  // Set interval to 1 second (1000 ms)
            timer.Tick += Timer_Tick;  // Subscribe to the Tick event
            timer.Start();  // Start the timer
        }

        private void Pull_up_UI(object sender, EventArgs e)
        {
            while (this.Location.Y > 1290)
            {
                this.Location = new System.Drawing.Point(465, Location.Y - 1);
            }
            /*
            for(int i = 0; i < 150; i++)
            {
                this.Location = new System.Drawing.Point(465, Location.Y - 1);
            }
            */
            // this.Location = new System.Drawing.Point(465, 1290);
        }

        private void Pull_down_UI(object sender, EventArgs e)
        {
            if (this.PointToClient(Cursor.Position).X < 0 || this.PointToClient(Cursor.Position).X > this.Width - 50 ||
                this.PointToClient(Cursor.Position).Y < 0)
            {
                // this.Location = new System.Drawing.Point(465, 1440);
                while (this.Location.Y < 1420)
                {
                    this.Location = new System.Drawing.Point(465, Location.Y + 1);
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the label with the current system time
            UI_Clock.Text = DateTime.Now.ToString("T");
        }

        private void goHome()
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            caution(Form2.activity.home);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            caution(Form2.activity.home);
        }

        private void golf_hover(object sender, EventArgs e)
        {
            label8.BackgroundImage = Properties.Resources.golf_highlight1; // Make sure to add your image to Resources
            label8.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void golf_leave(object sender, EventArgs e)
        {
            label8.BackgroundImage = null;
        }
        private void home_hover(object sender, EventArgs e)
        {
            label7.BackgroundImage = Properties.Resources.system_highlight1; // Make sure to add your image to Resources
            label7.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void home_leave(object sender, EventArgs e)
        {
            label7.BackgroundImage = null;
        }
        private void karaoke_hover(object sender, EventArgs e)
        {
            label9.BackgroundImage = Properties.Resources.karaoke_highlight1; // Make sure to add your image to Resources
            label9.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void karaoke_leave(object sender, EventArgs e)
        {
            label9.BackgroundImage = null;
        }
        private void movie_hover(object sender, EventArgs e)
        {
            label10.BackgroundImage = Properties.Resources.movie_highlight1; // Make sure to add your image to Resources
            label10.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void movie_leave(object sender, EventArgs e)
        {
            label10.BackgroundImage = null;
        }
        private void meeting_hover(object sender, EventArgs e)
        {
            label11.BackgroundImage = Properties.Resources.meeting_highlight1; // Make sure to add your image to Resources
            label11.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void meeting_leave(object sender, EventArgs e)
        {
            label11.BackgroundImage = null;
        }

        private void system_hover(object sender, EventArgs e)
        {
            label12.BackgroundImage = Properties.Resources.system_highlight1;
            label12.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void system_leave(object sender, EventArgs e)
        {
            label12.BackgroundImage = null;
        }

        private void caution(Form2.activity newActivity)
        {
            Form3 form3 = new Form3(newActivity, currActivity);

            form3.Show();

            this.Hide();
        }

        private void restart(Form2.activity newActivity)
        {
            Form5 form5 = new Form5(newActivity);
            form5.ShowDialog();
            this.Hide();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (currActivity == Form2.activity.golf)
            {
                restart(Form2.activity.golf);
            }
            else
            {
                caution(Form2.activity.golf);
            }
        }


        private void label12_Click(object sender, EventArgs e) // help menu
        {
            Form6 form6 = new Form6(currActivity);
            form6.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (currActivity == Form2.activity.golf)
            {
                restart(Form2.activity.golf);
            }
            else
            {
                caution(Form2.activity.golf);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (currActivity == Form2.activity.karaoke)
            {
                restart(Form2.activity.karaoke);
            }
            else
            {
                caution(Form2.activity.karaoke);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (currActivity == Form2.activity.karaoke)
            {
                restart(Form2.activity.karaoke);
            }
            else
            {
                caution(Form2.activity.karaoke);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (currActivity == Form2.activity.movie)
            {
                restart(Form2.activity.movie);
            }
            else
            {
                caution(Form2.activity.movie);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (currActivity == Form2.activity.movie)
            {
                restart(Form2.activity.movie);
            }
            else
            {
                caution(Form2.activity.movie);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (currActivity == Form2.activity.meeting)
            {
                restart(Form2.activity.meeting);
            }
            else
            {
                caution(Form2.activity.meeting);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (currActivity == Form2.activity.meeting)
            {
                restart(Form2.activity.meeting);
            }
            else
            {
                caution(Form2.activity.meeting);
            }
        }
    }
}