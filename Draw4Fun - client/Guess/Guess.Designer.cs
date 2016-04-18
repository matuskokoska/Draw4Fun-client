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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.guessLabel = new System.Windows.Forms.Label();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.oppL = new System.Windows.Forms.Label();
            this.drawingL = new System.Windows.Forms.Label();
            this.categoryL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(147, 222);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(826, 439);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guessLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.guessLabel.Location = new System.Drawing.Point(17, 724);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(111, 24);
            this.guessLabel.TabIndex = 1;
            this.guessLabel.Text = "Your guess:";
            // 
            // guessBox
            // 
            this.guessBox.Location = new System.Drawing.Point(134, 728);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(190, 20);
            this.guessBox.TabIndex = 2;
            // 
            // oppL
            // 
            this.oppL.AutoSize = true;
            this.oppL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.oppL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oppL.ForeColor = System.Drawing.Color.OrangeRed;
            this.oppL.Location = new System.Drawing.Point(197, 9);
            this.oppL.Name = "oppL";
            this.oppL.Size = new System.Drawing.Size(105, 24);
            this.oppL.TabIndex = 3;
            this.oppL.Text = "Opponent: ";
            // 
            // drawingL
            // 
            this.drawingL.AutoSize = true;
            this.drawingL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.drawingL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.drawingL.ForeColor = System.Drawing.Color.OrangeRed;
            this.drawingL.Location = new System.Drawing.Point(363, 9);
            this.drawingL.Name = "drawingL";
            this.drawingL.Size = new System.Drawing.Size(219, 24);
            this.drawingL.TabIndex = 5;
            this.drawingL.Text = "is drawing from category:";
            // 
            // categoryL
            // 
            this.categoryL.AutoSize = true;
            this.categoryL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categoryL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryL.ForeColor = System.Drawing.Color.White;
            this.categoryL.Location = new System.Drawing.Point(588, 8);
            this.categoryL.Name = "categoryL";
            this.categoryL.Size = new System.Drawing.Size(58, 25);
            this.categoryL.TabIndex = 6;
            this.categoryL.Text = "easy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Logged in as:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(142, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Feri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(368, 728);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hint:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(422, 728);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "You can find it in the kitchen.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(308, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Feri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Draw4Fun___client.Properties.Resources.painter;
            this.pictureBox1.Location = new System.Drawing.Point(954, 482);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 220);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-1, 708);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1190, 57);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1190, 57);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Draw4Fun___client.Properties.Resources.logo;
            this.pictureBox4.Location = new System.Drawing.Point(134, 90);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(886, 111);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Draw4Fun___client.Properties.Resources.button;
            this.button1.Location = new System.Drawing.Point(1051, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 47);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Draw4Fun___client.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryL);
            this.Controls.Add(this.drawingL);
            this.Controls.Add(this.oppL);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Label oppL;
        private System.Windows.Forms.Label drawingL;
        private System.Windows.Forms.Label categoryL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
    }
}