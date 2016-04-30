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
    public partial class Menu : Form
    {
        public Menu()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Jak je dole ten friends button --- po kliknuti by mohlo otvorit tamto kde by vyzve kamarata na hru // odpoveda na vyzvu a hada
            Draw.Draw draw = new Draw.Draw();
            draw.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO: tym padom ked to zrealizujeme jak ^ je spominane tento button netreba
            Guess.GuessForm guess = new Guess.GuessForm();
            guess.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TODO: Tabulka highscore
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //TODO: Info o nás
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //TODO: Dajaka tabulka / novy formular kde bude mat friendov - tam by som navrhol button na Challenge friend abo co, pridat priatela, vyhladavanie apod.
        }
    }
}
