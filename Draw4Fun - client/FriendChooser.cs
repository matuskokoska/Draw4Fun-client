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
        
        public FriendChooser()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            InitializeComponent();
            listBox1.Enabled = false;
        }

        public void initFriendList()
        {
            Request req = new Request();
            req.getFriendsList(User.id);
            //rozparsovat a addnut do listu
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
                    //wordChooser = new WordChooser();  nejake cislo frienda
                    //wordChooser.ShowDialog();
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
