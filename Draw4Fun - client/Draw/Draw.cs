using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw4Fun___client.Draw
{
    public partial class  Draw : Form
    { 
        private SolidBrush myBrush;
        private Graphics myGraphics;
        private bool IsPainting = false;
        private int timerDuration = 90;

        public Draw(int friendId, int wordId, int myId, String word)
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
<<<<<<< HEAD
            label2.Text = word;
=======
            label2.Text = wordId + "";
>>>>>>> 624d98219df21ba7a7c7d691c1096ad1289596de
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


        private void rubber_Click(object sender, EventArgs e)
        {
            myBrush.Color = rubber.BackColor;
            panel1.BackColor = rubber.BackColor;
        }


        private void panel2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (IsPainting == true)
            {
                myGraphics = panel2.CreateGraphics();
                myGraphics.FillEllipse(myBrush, e.X, e.Y, trackBar1.Value, trackBar1.Value);
            }
        }

        private void black_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = black_btn.BackColor;
            panel1.BackColor = black_btn.BackColor;
        }

        private void white_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = white_btn.BackColor;
            panel1.BackColor = white_btn.BackColor;
        }

        private void grey_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = grey_btn.BackColor;
            panel1.BackColor = grey_btn.BackColor;
        }

        private void silver_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = silver_btn.BackColor;
            panel1.BackColor = silver_btn.BackColor;
        }

        private void darkRed_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = darkRed_btn.BackColor;
            panel1.BackColor = darkRed_btn.BackColor;
        }

        private void saddleBrown_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = saddleBrown_btn.BackColor;
            panel1.BackColor = saddleBrown_btn.BackColor;
        }

        private void red_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = red_btn.BackColor;
            panel1.BackColor = red_btn.BackColor;
        }

        private void fuchsia_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = fuchsia_btn.BackColor;
            panel1.BackColor = fuchsia_btn.BackColor;
        }

        private void orange_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = orange_btn.BackColor;
            panel1.BackColor = orange_btn.BackColor;
        }

        private void pink_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = pink_btn.BackColor;
            panel1.BackColor = pink_btn.BackColor;
        }

        private void yellow_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = yellow_btn.BackColor;
            panel1.BackColor = yellow_btn.BackColor;
        }

        private void limeGreen_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = limeGreen_btn.BackColor;
            panel1.BackColor = limeGreen_btn.BackColor;
        }

        private void lightYellow_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = lightYellow_btn.BackColor;
            panel1.BackColor = lightYellow_btn.BackColor;
        }

        private void darkGreen_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = darkGreen_btn.BackColor;
            panel1.BackColor = darkGreen_btn.BackColor;
        }

        private void mediumBlue_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = mediumBlue_btn.BackColor;
            panel1.BackColor = mediumBlue_btn.BackColor;
        }

        private void dodgerBlue_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = dodgerBlue_btn.BackColor;
            panel1.BackColor = dodgerBlue_btn.BackColor;
        }

        private void purple_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = purple_btn.BackColor;
            panel1.BackColor = purple_btn.BackColor;
        }

        private void cyan_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = cyan_btn.BackColor;
            panel1.BackColor = cyan_btn.BackColor;
        }

        private void blankPage_btn_Click(object sender, EventArgs e)
        {
            myGraphics.Clear(Color.White);
        }

        private void pencil_btn_Click(object sender, EventArgs e)
        {
            myBrush.Color = Color.Black;
            panel1.BackColor = Color.Black;
        }

        System.Drawing.Drawing2D.GraphicsState transState;

        public string ImageToBase64(Image image,
        System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private void sendImagetoServer()
        {
            Bitmap bmp = new Bitmap(panel2.Width, panel2.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = panel2.RectangleToScreen(panel2.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, panel2.Size);
            g.Dispose();
            bmp.Save("drawedPicture.jpg", ImageFormat.Jpeg);

            string binaryFile = ImageToBase64(bmp,ImageFormat.Jpeg);
            Console.Write("Binary picture is: " + binaryFile);

            Request req = new Request();
            req.imagePost(binaryFile);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            sendImagetoServer();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = timerDuration.ToString();
            timerDuration--;
            if (timerDuration == -1)
            {
                sendImagetoServer();
                panel2.Enabled = false;
                timer1.Stop();
            }
        }
    }
}
