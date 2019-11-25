namespace SaveTheCoffeeBeans
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.HelpTabs = new System.Windows.Forms.TabControl();
            this.mainMenu = new System.Windows.Forms.Button();
            this.ctrl = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.HelpTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(598, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Levels";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctrl);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(598, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Controls";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // HelpTabs
            // 
            this.HelpTabs.Controls.Add(this.tabPage1);
            this.HelpTabs.Controls.Add(this.tabPage2);
            this.HelpTabs.Location = new System.Drawing.Point(1, 12);
            this.HelpTabs.Name = "HelpTabs";
            this.HelpTabs.SelectedIndex = 0;
            this.HelpTabs.Size = new System.Drawing.Size(606, 514);
            this.HelpTabs.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.Menu;
            this.mainMenu.Location = new System.Drawing.Point(115, 532);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(100, 55);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = false;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // ctrl
            // 
            this.ctrl.Image = ((System.Drawing.Image)(resources.GetObject("ctrl.Image")));
            this.ctrl.Location = new System.Drawing.Point(21, 27);
            this.ctrl.Name = "ctrl";
            this.ctrl.Size = new System.Drawing.Size(534, 345);
            this.ctrl.TabIndex = 0;
            this.ctrl.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaveTheCoffeeBeans.Properties.Resources.lvls;
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 461);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 694);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.HelpTabs);
            this.Name = "Help";
            this.Text = "Instructions";
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.HelpTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl HelpTabs;
        private System.Windows.Forms.PictureBox ctrl;
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}