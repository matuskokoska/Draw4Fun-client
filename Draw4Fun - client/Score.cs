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
        private List<String> leaderboardList = new List<String>();
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
            listBox1.Items.Clear();
            Request req = new Request();
            String jsonString = req.getLeaderboard();

            dynamic data = JsonConvert.DeserializeObject(jsonString);

            for(int i = 0; i < 10; i++){
                int id = data[i].id;
                String username = data[i].username;
                int score = data[i].score;

                poradie = i + 1;

                String user = poradie + " " + username + " " + score;
                leaderboardList.Add(user);
            }

            listBox1.Items.Add(leaderboardList);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
