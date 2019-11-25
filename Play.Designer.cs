namespace SaveTheCoffeeBeans
{
    partial class Play
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
            this.components = new System.ComponentModel.Container();
            this.bagscatched = new System.Windows.Forms.Label();
            this.bagsdropped = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bagscatched
            // 
            this.bagscatched.AutoSize = true;
            this.bagscatched.Location = new System.Drawing.Point(33, 29);
            this.bagscatched.Name = "bagscatched";
            this.bagscatched.Size = new System.Drawing.Size(105, 17);
            this.bagscatched.TabIndex = 0;
            this.bagscatched.Text = "Bags Caught: 0";
            // 
            // bagsdropped
            // 
            this.bagsdropped.AutoSize = true;
            this.bagsdropped.Location = new System.Drawing.Point(431, 29);
            this.bagsdropped.Name = "bagsdropped";
            this.bagsdropped.Size = new System.Drawing.Size(104, 17);
            this.bagsdropped.TabIndex = 1;
            this.bagsdropped.Text = "Bags Missed: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTick);
            // 
            // player
            // 
            this.player.Image = global::SaveTheCoffeeBeans.Properties.Resources.player_removebg_preview;
            this.player.Location = new System.Drawing.Point(227, 610);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(93, 83);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SaveTheCoffeeBeans.Properties.Resources.Sack3_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(366, 76);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Sacks";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SaveTheCoffeeBeans.Properties.Resources.Sack2_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(179, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Sacks";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaveTheCoffeeBeans.Properties.Resources.Sack1_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(36, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Sacks";
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 694);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bagsdropped);
            this.Controls.Add(this.bagscatched);
            this.Name = "Play";
            this.Text = "Easy";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bagscatched;
        private System.Windows.Forms.Label bagsdropped;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
    }
}