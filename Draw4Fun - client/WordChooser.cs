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
    public partial class WordChooser : Form
    {
        private int friendId;
        private int wordId;

        public WordChooser(int friendId)
        {
            InitializeComponent();
            this.friendId = friendId;
            Request req = new Request();
            req.getWords();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Draw.Draw draw = new Draw.Draw(friendId, wordId, Login.myId);
            this.Dispose();
            draw.ShowDialog();
        }
    }
}
