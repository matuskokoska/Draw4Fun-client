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
            GuessInfo guess = new GuessInfo();
            guess = req.getGuess(User.id);
            if (guess.nickname != null)
            {
                listBox1.Items.Add(guess.nickname);
            }
            else
            {
                listBox1.Items.Add("NO DRAWINGS");
                listBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guess.GuessForm guess = new Guess.GuessForm();
            guess.ShowDialog();
        }
    }
}
