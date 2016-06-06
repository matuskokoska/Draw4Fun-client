using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw4Fun___client.Guess
{
    public partial class GuessForm : Form
    {
        private String guess;
        private int painter;
        string picture;
        private int timerDuration = 30;

        public GuessForm(int drawingId,string nickname,string word)
        {
            InitializeComponent();
            opponentLbl.Text = nickname;
            timer1.Enabled = true;
            timer1.Start();

            Request req = new Request();

            string jsonString = req.showImage(drawingId);
            dynamic data = JsonConvert.DeserializeObject(jsonString);

            string picture = data[0].streambinary;

              
            pb_Canvas.Image = stringToImage(picture);
            
        }

         public Image stringToImage(string base64String)
         {
             // Convert Base64 String to byte[]
             byte[] imageBytes = Convert.FromBase64String(base64String);
             MemoryStream ms = new MemoryStream(imageBytes, 0,
               imageBytes.Length);

             // Convert byte[] to Image
             ms.Write(imageBytes, 0, imageBytes.Length);
             Image image = Image.FromStream(ms, true);
             return image;
         }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            sendToServer();
        }

        private void SubmitGuess()
        {
            guess = guessBox.Text;
            Request req = new Request();
            req.guessPost(guess, painter, User.id);
        }

        private void sendToServer()
        {
            timer1.Stop();
            if (guessBox.Text == "")
            {
                MessageReport msg = new MessageReport("Empty field");
                msg.Show();
                this.Close();
            }
            else
            {
                SubmitGuess();
                MessageReport msg = new MessageReport("Successful send");
                msg.Show();
                this.Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = timerDuration.ToString();
            timerDuration--;
            if (timerDuration == -1)
            {
                sendToServer();
            }
        }
    }

}
