﻿using System;
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
    public partial class Golf_New_Returning_User : Form
    {
        public enum userType
        {
            newUser, returningUser
        }
        public userType user;
        private Form2.activity currActivity;

        public Golf_New_Returning_User(Form2.activity newActivity)
        {
            InitializeComponent();
            currActivity = newActivity;
            this.Location = new System.Drawing.Point(0, 0);
        }
        private void newUserBtn_MouseEnter(object sender, EventArgs e)
        {
            newUserBtn.BackgroundImage = Properties.Resources.golf_highlight; // Make sure to add your image to Resources
            newUserBtn.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void newUserBtn_MouseLeave(object sender, EventArgs e)
        {
            newUserBtn.BackgroundImage = null;
        }

        private void returningUserBtn_MouseEnter(object sender, EventArgs e)
        {
            returningUserBtn.BackgroundImage = Properties.Resources.movie_highlight; // Make sure to add your image to Resources
            returningUserBtn.BackgroundImageLayout = ImageLayout.Stretch; // Optional: Set how the image should fit
        }

        private void returningUserBtn_MouseLeave(object sender, EventArgs e)
        {
            returningUserBtn.BackgroundImage = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = userType.newUser;
            Program.changeForm(new Golf_Video_Transition(currActivity, user));
        }

        private void returningUserBtn_Click(object sender, EventArgs e)
        {
            user = userType.returningUser;
            Program.changeForm(new Golf_Video_Transition(currActivity, user));
        }
    }
}
