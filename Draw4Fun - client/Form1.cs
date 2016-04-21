using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guess.GuessForm guess = new Guess.GuessForm();
            guess.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Draw.Draw draw = new Draw.Draw();
            draw.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
