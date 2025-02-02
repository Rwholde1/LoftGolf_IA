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
        string destination;
        public Form3(string destination)
        {
            InitializeComponent();
            this.destination = destination;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();
        }

        private void displayOverlay()
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (destination){
                case "home":
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                    break;
                case "golf":
                    // run autohotkey stuff for golf
                    displayOverlay();
                    break;
                case "karaoke":
                    // run autohotkey stuff for karaoke
                    displayOverlay();
                    break;
                case "movie":
                    // run autohotkey stuff for movies
                    displayOverlay();
                    break;
                case "meeting":
                    // run autohotkey stuff for meeting
                    displayOverlay();
                    break;
                    
            };
                
        }
    }
}
