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
        private String json;

        public GuessForm(int myId)
        {
            InitializeComponent();
            meLbl.Text = myId+"";
            string picture;

            //there will be method to get string of image
            picture ="";
            pb_Canvas.Image =stringToImage(picture);
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
            SubmitGuess();
        }

        private void SubmitGuess()
        {   
            guess = "{\"guess\":\""+guessBox.Text+"\"}";
            json = JsonConvert.SerializeObject(guess);
            Console.Write("JSON:"+json);
        }

    }

}
