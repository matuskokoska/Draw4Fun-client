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
    public partial class Friends : Form
    {
        public Friends()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            InitializeComponent();
            label1.Text = User.nickname;
            initFriendlist();
        }

        private void initFriendlist()
        {
            Request req = new Request();
            string jsonString = req.getFriendsList(User.id);

            if (jsonString != "[]")
            {
                JArray data = (JArray)JsonConvert.DeserializeObject(jsonString);
                int count = data.Count;

                dynamic data2 = JsonConvert.DeserializeObject(jsonString);

                for (int i = 0; i < count; i++)
                {
                    string nickname = data2[i].nickname;
                    listBox1.Items.Add(i + 1 + ". " + nickname);
                }
            }
            else
            {
                listBox1.Items.Add("You have no friends.");
                listBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFriend adfr = new AddFriend();
            adfr.ShowDialog();
            listBox1.Items.Clear();
            initFriendlist();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
