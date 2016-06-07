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
    public partial class FriendChooser : Form
    {
        private string jsonString;

        public FriendChooser()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            InitializeComponent();
            initFriendlist();
            listBox1.Enabled = false;
        }

        private void initFriendlist()
        {
            Request req = new Request();
            jsonString = req.getFriendsList(User.id);
            //this.jsonString = jsonString;

            if (jsonString != "[]")
            {
                JArray data = (JArray)JsonConvert.DeserializeObject(jsonString);
                int count = data.Count;

                dynamic data2 = JsonConvert.DeserializeObject(jsonString);

                for (int i = 0; i < count; i++)
                {
                    int friendId = data2[i].id;
                    string nickname = data2[i].nickname;
                    listBox1.Items.Add(i + 1 + ". " + nickname);
                }
            }
            else
            {
                listBox1.Items.Add("You have no friends. Looser!");
                listBox1.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton2.Checked && listBox1.SelectedIndex != -1) || radioButton1.Checked)
            {
                WordChooser wordChooser;
                //ak je zvoleny random tak 0 
                if (radioButton1.Checked) { 
                    wordChooser = new WordChooser(0);
                    wordChooser.ShowDialog();
                }
                //inac sa to nastavi podla id daneho frienda
                else
                {
                    int selected = listBox1.SelectedIndex;

                    dynamic data2 = JsonConvert.DeserializeObject(jsonString);
                    int friendId = data2[selected].id;
                    
                    wordChooser = new WordChooser(friendId);
                    wordChooser.ShowDialog();
                }
                this.Dispose();
                
            }
            else
            {
                MessageBox.Show("You must choose a friend.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
