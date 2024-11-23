namespace LoftGolfOverlayUI
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
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
            UI_Clock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Hide();
        }
    }
}