using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw4Fun___client
{
    public partial class Login : Form
    {

        public Login()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
  
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
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
                    
                } else if (!isPasswordValid(textBox2.Text)) {
                    MessageBox.Show("Invalid password. Password must contain 8 - 16 characters.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    PassHash hash = new PassHash();
                    string encryptedPass;
                    encryptedPass = hash.EncodePasswordToBase64(textBox2.Text);

                    Request req = new Request();
                    if(req.loginPost(textBox1.Text, encryptedPass))
                    {
                        User.nickname = textBox1.Text.ToString();
                        this.Hide();
                        Menu menu = new Draw4Fun___client.Menu();
                        menu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    

                    
                }
                

            }

        }

        private Boolean isUsernameValid(string username)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9_]{3,16}$");
            Match match = regex.Match(username);
            if (!match.Success)
            {
                return false;
            } else {
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
            } else {
                return true;
            }
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string username;
            username = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            PassHash hash = new PassHash();
            string password;
            password = textBox2.Text;          
            hash.EncodePasswordToBase64(password);
        }
    }
}
