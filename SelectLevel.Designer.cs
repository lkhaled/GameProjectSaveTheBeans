namespace SaveTheCoffeeBeans
{
    partial class SelectLevel
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
            this.easy = new System.Windows.Forms.Button();
            this.medium = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.levelselection = new System.Windows.Forms.Label();
            this.hard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.SystemColors.Menu;
            this.easy.Location = new System.Drawing.Point(238, 195);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(95, 67);
            this.easy.TabIndex = 0;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.Click += new System.EventHandler(this.easy_Click);
            // 
            // medium
            // 
            this.medium.BackColor = System.Drawing.SystemColors.Menu;
            this.medium.Location = new System.Drawing.Point(238, 268);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(95, 65);
            this.medium.TabIndex = 1;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = false;
            this.medium.Click += new System.EventHandler(this.medium_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Menu;
            this.menu.Location = new System.Drawing.Point(238, 410);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(95, 65);
            this.menu.TabIndex = 2;
            this.menu.Text = "Main Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // levelselection
            // 
            this.levelselection.AutoSize = true;
            this.levelselection.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelselection.Location = new System.Drawing.Point(193, 58);
            this.levelselection.Name = "levelselection";
            this.levelselection.Size = new System.Drawing.Size(179, 46);
            this.levelselection.TabIndex = 3;
            this.levelselection.Text = "Select Level";
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.SystemColors.MenuBar;
            this.hard.Location = new System.Drawing.Point(238, 339);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(95, 65);
            this.hard.TabIndex = 4;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = false;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // SelectLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 694);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.levelselection);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.easy);
            this.Name = "SelectLevel";
            this.Text = "Level Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Button medium;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Label levelselection;
        private System.Windows.Forms.Button hard;
    }
}