using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveTheCoffeeBeans
{
    public partial class HardLevel : Form
    {
        bool goleft;
        bool goright;
        int speed = 20;
        int score = 0;
        int missed = 0;
        int flscore = 0;
        int scorefl = 2;
        int flmissed = 0;
        int missedfl = 2;
        int lifes = 3;
        Random rndY = new Random();
        Random rndX = new Random();
        PictureBox splash = new PictureBox();
        public HardLevel()
        {
            InitializeComponent();
        }

        private void iskeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void iskeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void gameTick(object sender, EventArgs e)
        {
            bagscatched.Text = "Bags Caught: " + score;
            bagsdropped.Text = "Bags Missed: " + missed;
            flowerscatched.Text = "Flowers Caught: " + flscore;
            flowersdropped.Text = "Flowers Missed: " + flmissed;
            life.Text = "Lifes: " + lifes;

            if (goleft == true && player.Left > 0)
            {
                player.Left -= 12;
            }
            if (goright == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += 12;
            }
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && X.Tag == "Sacks")
                {
                    X.Top += speed;
                    if (X.Top + X.Height > this.ClientSize.Height)
                    {
                        splash.Image = Properties.Resources.Broken_sack_removebg_preview;
                        splash.Location = X.Location;
                        splash.Height = 59;
                        splash.Width = 60;
                        splash.BackColor = Color.Transparent;
                        this.Controls.Add(splash);
                        X.Top = rndY.Next(80, 300) * -1;
                        X.Left = rndY.Next(5, this.ClientSize.Width - X.Width);
                        missed++;
                        player.Image = Properties.Resources.player_hurt;
                    }
                    if (X.Bounds.IntersectsWith(player.Bounds))
                    {
                        X.Top = rndY.Next(100, 300) * -1;
                        X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                        score++;
                    }
                    if (score >= 10)
                    {
                        speed = 25;
                    }
                    if (missed > 25)
                    {
                        gameTimer.Stop();
                        MessageBox.Show("Game Over!!" + "\r\n" + "You have caught " + score + " bags" + " &" + "\r\n" + flscore + " flowers" + "\r\n" + "Click Ok to restart");
                        reset();
                    }
                }
            }
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && X.Tag == "Flowers")
                {
                    X.Top += speed;
                    if (X.Top + X.Height > this.ClientSize.Height)
                    {
                        splash.Image = Properties.Resources.broken_flowerpot;
                        splash.Location = X.Location;
                        splash.Height = 59;
                        splash.Width = 60;
                        splash.BackColor = Color.Transparent;
                        this.Controls.Add(splash);
                        X.Top = rndY.Next(80, 300) * -1;
                        X.Left = rndY.Next(5, this.ClientSize.Width - X.Width);
                        flmissed = missedfl++;
                        player.Image = Properties.Resources.player_hurt_flower;
                    }
                    if (X.Bounds.IntersectsWith(player.Bounds))
                    {
                        X.Top = rndY.Next(100, 300) * -1;
                        X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                        flscore = scorefl++;
                    }
                    if (flscore >= 10)
                    {
                        speed = 25;
                    }
                    if (flmissed > 25)
                    {
                        gameTimer.Stop();
                        MessageBox.Show("Game Over!!" + "\r\n" + "You have caught " + score + " bags" + " &" + "\r\n" + flscore + " flowers" + "\r\n" + "Click Ok to restart");
                        reset();
                    }
                }
            }
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && X.Tag == "Anvil")
                {
                    X.Top += speed;
                    if (X.Top + X.Height > this.ClientSize.Height)
                    {
                        splash.Image = Properties.Resources.anvil2;
                        splash.Location = X.Location;
                        splash.Height = 59;
                        splash.Width = 60;
                        splash.BackColor = Color.Transparent;
                        this.Controls.Add(splash);
                        X.Top = rndY.Next(80, 300) * -1;
                        X.Left = rndY.Next(5, this.ClientSize.Width - X.Width);
                        flmissed = missedfl++;
                        player.Image = Properties.Resources.player_hurt_anvil;
                    }
                    if (X.Bounds.IntersectsWith(player.Bounds))
                    {
                        X.Top = rndY.Next(100, 300) * -1;
                        X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                        lifes--;
                    }
                    if (lifes < 0)
                    {
                        gameTimer.Stop();
                        MessageBox.Show("Game Over!!" + "\r\n" + "You have caught " + score + " bags" + " &" + "\r\n" + flscore + " flowers" + "\r\n" + "Click Ok to restart");
                        reset();
                    }
                }
            }

        }
        private void reset()
        {
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && X.Tag == "Sacks")
                {
                    X.Top = rndY.Next(80, 300) * -1;
                    X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                }
            }
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && X.Tag == "Flowers")
                {
                    X.Top = rndY.Next(80, 300) * -1;
                    X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                }
            }
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && X.Tag == "Anvil")
                {
                    X.Top = rndY.Next(80, 300) * -1;
                    X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                }
            }
            player.Left = this.ClientSize.Width / 2;
            player.Image = Properties.Resources.player;
            score = 0;
            flscore = 0;
            scorefl = 2;
            missed = 0;
            flmissed = 0;
            missedfl = 2;
            speed = 20;
            lifes = 3;
            goleft = false;
            goright = false;
            gameTimer.Start();
        }
    }
}
