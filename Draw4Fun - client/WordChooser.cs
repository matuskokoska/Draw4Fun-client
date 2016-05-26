using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class WordChooser : Form
    {
        private int friendId;
        private int wordId;
        private string guessedWord { get; set; }

        public WordChooser(int friendId)
        {
            InitializeComponent();
            initWords();
            this.friendId = friendId;
            

        }

        public void initWords()
        {
            Request req = new Request();
            String jsonString = req.getWords();

            dynamic data = JsonConvert.DeserializeObject(jsonString);

            for(int i = 0; i < 5; i++)
            {
                int id = data[i].id;
                String word = data[i].word;
                int category = data[i].category;
 
                switch (i)
                {
                    case 0: radioButton1.Text = word; break;
                    case 1: radioButton2.Text = word; break;
                    case 2: radioButton3.Text = word; break;
                    case 3: radioButton4.Text = word; break;
                    case 4: radioButton5.Text = word; break;
                }
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var checkedButton = groupBox1.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            Console.WriteLine("STLACIL SI: " + checkedButton);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Draw.Draw draw = new Draw.Draw(friendId, wordId, Login.myId);
            //this.Dispose();
            //draw.ShowDialog();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
