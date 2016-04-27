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
    public partial class Menu : Form
    {
        public Menu()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Draw.Draw draw = new Draw.Draw();
            draw.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Guess.GuessForm guess = new Guess.GuessForm();
            guess.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 forma = new Form1();
            forma.ShowDialog();
            
        }
    }
}
