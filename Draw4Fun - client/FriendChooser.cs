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
            InitializeComponent();
            listBox1.Enabled = false;
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
                Draw.Draw draw = new Draw.Draw();
                draw.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must choose friend", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
