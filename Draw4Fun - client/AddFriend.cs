﻿using Newtonsoft.Json;
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
    public partial class AddFriend : Form
    {
        public AddFriend()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Request req = new Request();
            string jsonString = req.findFriend(textBox1.Text);

            if (jsonString != "[]")
            {
                JArray data = (JArray)JsonConvert.DeserializeObject(jsonString);
                int count = data.Count;

                dynamic data2 = JsonConvert.DeserializeObject(jsonString);

                for (int i = 0; i < count; i++)
                {
                    string nickname = data2[i].nickname;
                    listBox1.Items.Add(nickname);
                }
            }
            else
            {
                listBox1.Items.Add("User not found.");
                listBox1.Enabled = false;
                button1.Enabled = false;
            }
        }
    }
}
