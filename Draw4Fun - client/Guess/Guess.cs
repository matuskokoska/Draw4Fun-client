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
        string picture;
        private int timerDuration = 30;
        private string word;
        private int painterId;
        private string category;
        private int drawingId;

        public GuessForm(int drawingId, string nickname, string word, int painterId, string category)
        {
            InitializeComponent();
            opponentLbl.Text = nickname;
            categoryLbl.Text = category;
            timer1.Enabled = true;
            timer1.Start();

            this.word = word;
            this.painterId = painterId;
            this.category = category;
            this.drawingId = drawingId;

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

        private bool SubmitGuess()
        {
            guess = guessBox.Text.ToLower();
            if (guess.Equals(word))
            {
                timer1.Stop();
                Request req = new Request();
                req.setState(drawingId,2);
                // send to server function
                return true;
            }
            else
            {
                return false;
            }

        }

        private void sendToServer()
        {
            
            if (guessBox.Text == "")
            {
                MessageReport msg = new MessageReport("Empty field");
                msg.Show();               
            }
            else
            {
                if (SubmitGuess())
                {
                    MessageReport msg = new MessageReport("Nice. Your guess was successful.");
                    msg.Show();
                    this.Close();
                }
                else
                {
                    MessageReport msg = new MessageReport("Try again.");
                    msg.Show();
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = timerDuration.ToString();
            timerDuration--;
            if (timerDuration == -1)
            {
                timer1.Stop();
                Request req = new Request();
                req.setState(drawingId, 1);

                MessageReport msg = new MessageReport("Whooops......");
                msg.Show();
                this.Close();         
            }
        }
    }

}