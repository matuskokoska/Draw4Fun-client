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
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please, fill all the needed informations.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                Menu menu = new Draw4Fun___client.Menu();
                menu.ShowDialog();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 register = new Form2();
            register.ShowDialog();
        }
    }
}
