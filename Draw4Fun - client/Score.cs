using Newtonsoft.Json;
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
    public partial class Score : Form
    {
        private int poradie;

        public Score()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            InitializeComponent();
            initLeaderboard();
        }

        private void initLeaderboard()
        {
            Request req = new Request();
            String jsonString = req.getLeaderboard();

            dynamic data = JsonConvert.DeserializeObject(jsonString);

            for(int i = 0; i < 10; i++){
                int id = data[i].id;
                String nickname = data[i].nickname;
                int score = data[i].score;

                poradie = i + 1;

                String user = poradie + "   " + nickname + "    " + score;
                listBox1.Items.Add(user);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
