using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw4Fun___client.Draw
{
    public partial class Draw : Form
    {
        private SolidBrush myBrush;
        private Graphics myGraphics;
        private bool IsPainting = false;

        public Draw()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                myBrush.Color = colorDialog1.Color;
                panel1.BackColor = colorDialog1.Color;
            }
        }

        private void Draw_Load(object sender, EventArgs e)
        {
            myBrush = new SolidBrush(panel1.BackColor);
           // textBox1.Text = trackBar1.Value.ToString();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            IsPainting = true;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            IsPainting = false;
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            myBrush.Color = button1.BackColor;
            panel1.BackColor = button1.BackColor;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            myBrush.Color = button20.BackColor;
            panel1.BackColor = button20.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myBrush.Color = button3.BackColor;
            panel1.BackColor = button3.BackColor;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            myBrush.Color = button19.BackColor;
            panel1.BackColor = button19.BackColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myBrush.Color = button4.BackColor;
            panel1.BackColor = button4.BackColor;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            myBrush.Color = button17.BackColor;
            panel1.BackColor = button17.BackColor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myBrush.Color = button7.BackColor;
            panel1.BackColor = button7.BackColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myBrush.Color = button6.BackColor;
            panel1.BackColor = button6.BackColor;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            myBrush.Color = button10.BackColor;
            panel1.BackColor = button10.BackColor;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            myBrush.Color = button12.BackColor;
            panel1.BackColor = button12.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myBrush.Color = button2.BackColor;
            panel1.BackColor = button2.BackColor;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            myBrush.Color = button15.BackColor;
            panel1.BackColor = button15.BackColor;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            myBrush.Color = button13.BackColor;
            panel1.BackColor = button13.BackColor;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            myBrush.Color = button16.BackColor;
            panel1.BackColor = button16.BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            myBrush.Color = button5.BackColor;
            panel1.BackColor = button5.BackColor;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            myBrush.Color = button14.BackColor;
            panel1.BackColor = button14.BackColor;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            myBrush.Color = button8.BackColor;
            panel1.BackColor = button8.BackColor;
        }

        private void rubber_Click(object sender, EventArgs e)
        {
            myBrush.Color = rubber.BackColor;
            panel1.BackColor = rubber.BackColor;
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            myBrush.Color = button18.BackColor;
            panel1.BackColor = button18.BackColor;
        }

        private void panel2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (IsPainting == true)
            {
                myGraphics = panel2.CreateGraphics();
                myGraphics.FillEllipse(myBrush, e.X, e.Y, trackBar1.Value, trackBar1.Value);
            }
        }
    }
}
