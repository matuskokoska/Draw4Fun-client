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
    public partial class DrawingChooser : Form
    {
        public DrawingChooser()
        {
            InitializeComponent();
            Request req = new Request();       
            listBox1.Text = req.getGuess(User.id);         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guess.GuessForm guess = new Guess.GuessForm();
            guess.ShowDialog();
        }
    }
}
