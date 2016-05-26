namespace Draw4Fun___client.Guess
{
    partial class GuessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuessForm));
            this.pb_Canvas = new System.Windows.Forms.PictureBox();
            this.guessLabel = new System.Windows.Forms.Label();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hintLbl = new System.Windows.Forms.Label();
            this.opponentLbl = new System.Windows.Forms.Label();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.pb_Menu = new System.Windows.Forms.PictureBox();
            this.pb_Submit = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Submit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Canvas
            // 
            this.pb_Canvas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_Canvas.BackColor = System.Drawing.Color.White;
            this.pb_Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Canvas.Location = new System.Drawing.Point(130, 120);
            this.pb_Canvas.Name = "pb_Canvas";
            this.pb_Canvas.Size = new System.Drawing.Size(1000, 500);
            this.pb_Canvas.TabIndex = 0;
            this.pb_Canvas.TabStop = false;
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(226)))), ((int)(((byte)(248)))));
            this.guessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.guessLabel.Location = new System.Drawing.Point(19, 41);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(141, 29);
            this.guessLabel.TabIndex = 1;
            this.guessLabel.Text = "Your guess:";
            // 
            // guessBox
            // 
            this.guessBox.Location = new System.Drawing.Point(169, 45);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(190, 20);
            this.guessBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(226)))), ((int)(((byte)(248)))));
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opponent: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(226)))), ((int)(((byte)(248)))));
            this.label3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(236, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "is drawing from category:";
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(226)))), ((int)(((byte)(248)))));
            this.categoryLbl.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.categoryLbl.Location = new System.Drawing.Point(579, 32);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(64, 28);
            this.categoryLbl.TabIndex = 6;
            this.categoryLbl.Text = "easy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(226)))), ((int)(((byte)(248)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(844, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hint:";
            // 
            // hintLbl
            // 
            this.hintLbl.AutoSize = true;
            this.hintLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(226)))), ((int)(((byte)(248)))));
            this.hintLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.hintLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.hintLbl.Location = new System.Drawing.Point(905, 16);
            this.hintLbl.Name = "hintLbl";
            this.hintLbl.Size = new System.Drawing.Size(360, 31);
            this.hintLbl.TabIndex = 10;
            this.hintLbl.Text = "You can find it in the kitchen.";
            // 
            // opponentLbl
            // 
            this.opponentLbl.AutoSize = true;
            this.opponentLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(226)))), ((int)(((byte)(248)))));
            this.opponentLbl.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponentLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.opponentLbl.Location = new System.Drawing.Point(166, 32);
            this.opponentLbl.Name = "opponentLbl";
            this.opponentLbl.Size = new System.Drawing.Size(64, 28);
            this.opponentLbl.TabIndex = 11;
            this.opponentLbl.Text = "Feri";
            // 
            // pb_Logo
            // 
            this.pb_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pb_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_Logo.Image = global::Draw4Fun___client.Properties.Resources.guessing;
            this.pb_Logo.Location = new System.Drawing.Point(12, 454);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(210, 220);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Logo.TabIndex = 12;
            this.pb_Logo.TabStop = false;
            // 
            // pb_Menu
            // 
            this.pb_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(226)))), ((int)(((byte)(248)))));
            this.pb_Menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_Menu.Image = global::Draw4Fun___client.Properties.Resources.button;
            this.pb_Menu.Location = new System.Drawing.Point(1152, 16);
            this.pb_Menu.Name = "pb_Menu";
            this.pb_Menu.Size = new System.Drawing.Size(113, 61);
            this.pb_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Menu.TabIndex = 16;
            this.pb_Menu.TabStop = false;
            this.pb_Menu.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pb_Submit
            // 
            this.pb_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(226)))), ((int)(((byte)(248)))));
            this.pb_Submit.Image = global::Draw4Fun___client.Properties.Resources.button_s;
            this.pb_Submit.Location = new System.Drawing.Point(365, 32);
            this.pb_Submit.Name = "pb_Submit";
            this.pb_Submit.Size = new System.Drawing.Size(119, 50);
            this.pb_Submit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Submit.TabIndex = 17;
            this.pb_Submit.TabStop = false;
            this.pb_Submit.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(226)))), ((int)(((byte)(248)))));
            this.groupBox1.Controls.Add(this.pb_Submit);
            this.groupBox1.Controls.Add(this.guessLabel);
            this.groupBox1.Controls.Add(this.guessBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.hintLbl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 680);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1268, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(226)))), ((int)(((byte)(248)))));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pb_Menu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.categoryLbl);
            this.groupBox2.Controls.Add(this.opponentLbl);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1268, 80);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // GuessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Draw4Fun___client.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1268, 780);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pb_Canvas);
            this.Controls.Add(this.pb_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pb_Canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Submit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Canvas;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label hintLbl;
        private System.Windows.Forms.Label opponentLbl;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.PictureBox pb_Menu;
        private System.Windows.Forms.PictureBox pb_Submit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}