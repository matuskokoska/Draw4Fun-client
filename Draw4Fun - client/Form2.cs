using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw4Fun___client
{
    public partial class Form2 : Form
    {
        public Form2()
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
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) ||  !checkBox1.Checked)
            {
                MessageBox.Show("Please fill all the required fields.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else
            {
                PassHash hash = new PassHash();
                string newPass;
                newPass = textBox3.Text;
                hash.EncodePasswordToBase64(newPass);
                /*  string connectionString = null;
                string sql = null;
                connectionString = "Data Source=UMAIR;Initial Catalog=Air; Trusted_Connection=True;";
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    sql = "insert into NewUser ([username], [password]) values(@username,@password)";
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@username", textBox1.Text);
                        cmd.Parameters.AddWithValue("@password", textBox2.Text);
                        cmd.ExecuteNonQuery();
                    } 
                } */
                this.Close();
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
    }
}
