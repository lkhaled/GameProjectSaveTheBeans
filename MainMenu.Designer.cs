namespace SaveTheCoffeeBeans
{
    partial class MainMenu
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
            this.Play = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.iconplayerhurt = new System.Windows.Forms.PictureBox();
            this.sackicon3 = new System.Windows.Forms.PictureBox();
            this.iconsack2 = new System.Windows.Forms.PictureBox();
            this.iconsack1 = new System.Windows.Forms.PictureBox();
            this.iconplayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconplayerhurt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sackicon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconsack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconsack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.SystemColors.Menu;
            this.Play.Location = new System.Drawing.Point(227, 222);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(126, 64);
            this.Play.TabIndex = 0;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.MenuText;
            this.title.Location = new System.Drawing.Point(155, 83);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(243, 46);
            this.title.TabIndex = 1;
            this.title.Text = "Save The Beans";
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.SystemColors.Menu;
            this.help.Location = new System.Drawing.Point(227, 304);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(126, 64);
            this.help.TabIndex = 7;
            this.help.Text = "Instructions";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // iconplayerhurt
            // 
            this.iconplayerhurt.Image = global::SaveTheCoffeeBeans.Properties.Resources.player_hurt;
            this.iconplayerhurt.Location = new System.Drawing.Point(386, 458);
            this.iconplayerhurt.Name = "iconplayerhurt";
            this.iconplayerhurt.Size = new System.Drawing.Size(212, 196);
            this.iconplayerhurt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconplayerhurt.TabIndex = 6;
            this.iconplayerhurt.TabStop = false;
            // 
            // sackicon3
            // 
            this.sackicon3.Image = global::SaveTheCoffeeBeans.Properties.Resources.Sack1;
            this.sackicon3.Location = new System.Drawing.Point(0, 338);
            this.sackicon3.Name = "sackicon3";
            this.sackicon3.Size = new System.Drawing.Size(143, 132);
            this.sackicon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sackicon3.TabIndex = 5;
            this.sackicon3.TabStop = false;
            // 
            // iconsack2
            // 
            this.iconsack2.Image = global::SaveTheCoffeeBeans.Properties.Resources.Sack2;
            this.iconsack2.Location = new System.Drawing.Point(45, 26);
            this.iconsack2.Name = "iconsack2";
            this.iconsack2.Size = new System.Drawing.Size(114, 140);
            this.iconsack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconsack2.TabIndex = 4;
            this.iconsack2.TabStop = false;
            // 
            // iconsack1
            // 
            this.iconsack1.Image = global::SaveTheCoffeeBeans.Properties.Resources.Sack3;
            this.iconsack1.Location = new System.Drawing.Point(12, 212);
            this.iconsack1.Name = "iconsack1";
            this.iconsack1.Size = new System.Drawing.Size(117, 120);
            this.iconsack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconsack1.TabIndex = 3;
            this.iconsack1.TabStop = false;
            // 
            // iconplayer
            // 
            this.iconplayer.Image = global::SaveTheCoffeeBeans.Properties.Resources.player;
            this.iconplayer.Location = new System.Drawing.Point(0, 486);
            this.iconplayer.Name = "iconplayer";
            this.iconplayer.Size = new System.Drawing.Size(176, 196);
            this.iconplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconplayer.TabIndex = 2;
            this.iconplayer.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 694);
            this.Controls.Add(this.help);
            this.Controls.Add(this.iconplayerhurt);
            this.Controls.Add(this.sackicon3);
            this.Controls.Add(this.iconsack2);
            this.Controls.Add(this.iconsack1);
            this.Controls.Add(this.iconplayer);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Play);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.iconplayerhurt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sackicon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconsack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconsack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox iconplayer;
        private System.Windows.Forms.PictureBox iconsack1;
        private System.Windows.Forms.PictureBox iconsack2;
        private System.Windows.Forms.PictureBox sackicon3;
        private System.Windows.Forms.PictureBox iconplayerhurt;
        private System.Windows.Forms.Button help;
    }
}

