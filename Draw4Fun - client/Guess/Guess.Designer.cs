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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.guessLabel = new System.Windows.Forms.Label();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.oppL = new System.Windows.Forms.Label();
            this.oppNameL = new System.Windows.Forms.Label();
            this.drawingL = new System.Windows.Forms.Label();
            this.categoryL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(12, 54);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(732, 376);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guessLabel.ForeColor = System.Drawing.Color.Navy;
            this.guessLabel.Location = new System.Drawing.Point(191, 447);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(111, 24);
            this.guessLabel.TabIndex = 1;
            this.guessLabel.Text = "Your guess:";
            // 
            // guessBox
            // 
            this.guessBox.Location = new System.Drawing.Point(308, 451);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(190, 20);
            this.guessBox.TabIndex = 2;
            // 
            // oppL
            // 
            this.oppL.AutoSize = true;
            this.oppL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oppL.ForeColor = System.Drawing.Color.Navy;
            this.oppL.Location = new System.Drawing.Point(13, 13);
            this.oppL.Name = "oppL";
            this.oppL.Size = new System.Drawing.Size(88, 20);
            this.oppL.TabIndex = 3;
            this.oppL.Text = "Opponent: ";
            // 
            // oppNameL
            // 
            this.oppNameL.AutoSize = true;
            this.oppNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oppNameL.ForeColor = System.Drawing.Color.White;
            this.oppNameL.Location = new System.Drawing.Point(107, 13);
            this.oppNameL.Name = "oppNameL";
            this.oppNameL.Size = new System.Drawing.Size(36, 20);
            this.oppNameL.TabIndex = 4;
            this.oppNameL.Text = "Feri";
            // 
            // drawingL
            // 
            this.drawingL.AutoSize = true;
            this.drawingL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.drawingL.ForeColor = System.Drawing.Color.Navy;
            this.drawingL.Location = new System.Drawing.Point(149, 13);
            this.drawingL.Name = "drawingL";
            this.drawingL.Size = new System.Drawing.Size(184, 20);
            this.drawingL.TabIndex = 5;
            this.drawingL.Text = "is drawing from category:";
            // 
            // categoryL
            // 
            this.categoryL.AutoSize = true;
            this.categoryL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryL.ForeColor = System.Drawing.Color.White;
            this.categoryL.Location = new System.Drawing.Point(339, 13);
            this.categoryL.Name = "categoryL";
            this.categoryL.Size = new System.Drawing.Size(42, 20);
            this.categoryL.TabIndex = 6;
            this.categoryL.Text = "easy";
            // 
            // GuessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(757, 500);
            this.Controls.Add(this.categoryL);
            this.Controls.Add(this.drawingL);
            this.Controls.Add(this.oppNameL);
            this.Controls.Add(this.oppL);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.canvas);
            this.Name = "GuessForm";
            this.Text = "Guess";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Label oppL;
        private System.Windows.Forms.Label oppNameL;
        private System.Windows.Forms.Label drawingL;
        private System.Windows.Forms.Label categoryL;
    }
}