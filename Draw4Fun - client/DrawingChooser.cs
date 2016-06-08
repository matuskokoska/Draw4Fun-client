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
    public partial class DrawingChooser : Form
    {
        public DrawingChooser()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            InitializeComponent();
            Request req = new Request();
            /*GuessInfo guess = new GuessInfo();
            guess = req.getGuess(User.id);*/

            string jsonString = req.getGuess(User.id);

            Console.Write("STRING JSON JE:" + jsonString + "a user id je: "+User.id );

            if (jsonString != "[]")
            {
                JArray data = (JArray)JsonConvert.DeserializeObject(jsonString);
                int count = data.Count;

                Console.Write("Dlzka DATA JE: " + count);

                dynamic data2 = JsonConvert.DeserializeObject(jsonString);
                
                for(int i=0; i< count; i++)
                {
                    string nickname = data2[i].nickname;
                    string datepainted = data2[i].datepainted;
                    listBox1.Items.Add(i+1+". "+nickname+" time: "+datepainted);
                }   
            }
            else
            {
                listBox1.Items.Add("NO DRAWINGS");
                listBox1.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int selectedIndex = listBox1.SelectedIndex;

                Request req = new Request();
                string jsonString = req.getGuess(User.id);
                dynamic data = JsonConvert.DeserializeObject(jsonString);
                


                string nickname = data[selectedIndex].nickname;
                string word = data[selectedIndex].word;
                int drawingId = data[selectedIndex].id;
                int painterId = data[selectedIndex].painterid;
                string category = data[selectedIndex].category;

                Guess.GuessForm guess = new Guess.GuessForm(drawingId,nickname,word,painterId,category);
                guess.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
