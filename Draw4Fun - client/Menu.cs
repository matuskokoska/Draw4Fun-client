﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw4Fun___client
{
    public partial class Menu : Form
    {

        public Menu()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            InitializeComponent();
            Console.WriteLine("User ID: " + User.id + " User nickname: " + User.nickname);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FriendChooser chooser = new FriendChooser();
            chooser.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DrawingChooser chooser = new DrawingChooser();
            chooser.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Score score = new Score();
            score.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            About about= new About();
            about.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Friends fr = new Friends();
            fr.ShowDialog();
        }
    }
}
