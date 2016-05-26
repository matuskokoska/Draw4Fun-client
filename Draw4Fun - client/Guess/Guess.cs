using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw4Fun___client.Guess
{
    public partial class GuessForm : Form
    {
        //private String opponent;
        //private String hint;
        private String guess;
        private String json;

        public GuessForm(String loggedIn)
        {
            InitializeComponent();
            meLbl.Text = loggedIn;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SubmitGuess();
        }

        private void SubmitGuess()
        {
            
            guess = "{\"guess\":\""+guessBox.Text+"\"}";
            json = JsonConvert.SerializeObject(guess);
            Console.Write("JSON:"+json);
        }

    }

}
