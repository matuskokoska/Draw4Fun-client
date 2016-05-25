using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw4Fun___client
{
    public partial class Register : Form
    {
        public Register()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) || !checkBox1.Checked)
            {
                MessageBox.Show("Please fill all the required fields.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else
            {
                if (!isUsernameValid(textBox1.Text))
                {
                    MessageBox.Show("Invalid username. Username must contain 3 - 16 characters", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!isPasswordValid(textBox2.Text))
                {
                    MessageBox.Show("Invalid password. Password must contain 8 - 16 characters.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else if(!isPasswordEqual(textBox2.Text, textBox3.Text)) {
                    MessageBox.Show("Passwords are not equal.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    PassHash hash = new PassHash();
                    string encryptedPass;
                    encryptedPass = hash.EncodePasswordToBase64(textBox3.Text);


                    //test
                    Request req = new Request();
                    req.registerPost(textBox1.Text, encryptedPass);
                    //end test

                    this.Close();
               }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string newusername;
            newusername = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/policies/terms/");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private Boolean isUsernameValid(string username)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9_]{3,16}$");
            Match match = regex.Match(username);
            if (!match.Success)
            {
                return false;
            }
            else {
                return true;
            }

        }

        private Boolean isPasswordValid(string password)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9]{8,16}$");
            Match match = regex.Match(password);
            if (!match.Success)
            {
                return false;
            }
            else {
                return true;
            }

        }

        private bool isPasswordEqual(string password, string confirmPassword)
        {
            if (!password.Equals(confirmPassword))
            {
                return false;
            } else {
                return true;
            }
            
        }
    }
}
