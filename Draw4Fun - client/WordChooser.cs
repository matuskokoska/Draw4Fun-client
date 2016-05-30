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
        private int wordId;
        private int friendId;
        private String word;
        private GuessWord guessWord;
        private List<GuessWord> wordsList = new List<GuessWord>();

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

                guessWord = new GuessWord(id, word, category);
                wordsList.Add(guessWord);

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
            Draw.Draw draw = new Draw.Draw(friendId, wordId, word);
            this.Dispose();
            draw.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            wordId = wordsList[0].getId();
            word = wordsList[0].getWord();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            wordId = wordsList[1].getId();
            word = wordsList[1].getWord();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            wordId = wordsList[2].getId();
            word = wordsList[2].getWord();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            wordId = wordsList[3].getId();
            word = wordsList[3].getWord();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            wordId = wordsList[4].getId();
            word = wordsList[4].getWord();
        }
    }
}
